/* This is the plugin for the Printrbot printers
 *
 * 
 * Authors: Cyril Chapellier for CKAB
 * Licence: CC-BY-NC-SA 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RepetierHostExtender.interfaces;
using RepetierHostExtender.geom;
using RepetierHostExtender.basic;

namespace PrintrBotPlugin
{
    public partial class PrintrBotPanel : UserControl,IHostComponent
    {
        private IHost host;
        private Boolean preheating = false;
        private Boolean calibrating = false;
        private Boolean loading = false;
        private Boolean unloading = false;

        private int loadingTemperature = 215;
        private int temperatureBias = 3;

        private double M212_Z_Offset = 1000;

        public PrintrBotPanel()
        {
            InitializeComponent();
            this.InitializeStrings();
        }

        private void InitializeStrings()
        {
            this.buttonLoad.Text = Properties.Resources.LoadingButton_Load;
            this.buttonUnload.Text = Properties.Resources.LoadingButton_Unload;
            this.groupFilament.Text = Properties.Resources.FilamentPanelTitle;
            this.buttonCancel.Text = Properties.Resources.CalibrateButton_Cancel;
            this.groupPreheating.Text = Properties.Resources.PreheatPanelTitle;
            this.buttonPreheat.Text = Properties.Resources.PreheatButton_Do;
            this.labelPreheatingStatus.Text = Properties.Resources.PreheatLabel_NotHeating;
            this.labelPreheatingTemp.Text = Properties.Resources.LabelPreheating;
            this.labelTitlePanel.Text = Properties.Resources.Title;
            this.groupCalibration.Text = Properties.Resources.CalibratePanelTitle;
            this.buttonCalibrationOK.Text = Properties.Resources.Calibrate_Step3_OK;
            this.buttonTooFar.Text = Properties.Resources.Calibrate_Step3_TooFar;
            this.buttonTooClose.Text = Properties.Resources.Calibrate_Step3_TooClose;
            this.labelCalibration.Text = Properties.Resources.CalibrateHelp;
            this.buttonCalibrate.Text = Properties.Resources.CalibrateButton_Do;
            this.labelConnection.Text = Properties.Resources.PrinterDisconnected_Label;
            this.buttonCheckConnection.Text = Properties.Resources.PrinterDisconnected_Button;
        }

        #region IHostComponent implementation

        // Name inside component repository
        public string ComponentName { get { return "PrintrBotPanel"; } }
        // Name for tab
        public string ComponentDescription { get { return "PrintrBot Control Panel"; } }
        // Used for positioning.
        public int ComponentOrder { get { return 8000; } }
        // Where to add it. We want it on the right tab.
        public PreferredComponentPositions PreferredPosition { get { return PreferredComponentPositions.SIDEBAR; } }
        // Return the UserControl.
        public Control ComponentControl { get { return this; } }
        /// 

        /// Associated ThreeDView object to show in the 3d view. Return null for no association
        /// 
        public ThreeDView Associated3DView { get { return null; } }
        /// 

        /// Gets called when the component comes into view. For tabs this means
        /// when the tab gets selected.
        ///
        public void ComponentActivated() { }
        #endregion

        /*
         * Connection stuff
         */
        #region Connection stuff

        /// Host instance
        public void Connect(IHost _host)
        {
            host = _host;

            //Add the connection change event
            host.Connection.eventConnectionChange += Connection_eventConnectionChange;

            // Temperature history change
            // host.Connection.eventTempHistory += eventTempHistory;
        }

        private Boolean checkConnection()
        {
            return (host.Connection.connector.IsConnected());
        }

        private void toggleControls(Boolean show)
        {
            groupCalibration.Visible = show;
            groupPreheating.Visible = show;
            groupFilament.Visible = show;

            panelConnection.Visible = !show;
        }

        private void PrintrBotPanel_Load(object sender, EventArgs e)
        {
            if (!this.checkConnection())
            {
                this.toggleControls(false);
            }
        }

        private void buttonCheckConnection_Click(object sender, EventArgs e)
        {
            if (this.checkConnection())
            {
                this.toggleControls(true);
            }
        }

        private void injectCommand(String command)
        {
            if (this.checkConnection())
            {
                host.Connection.injectManualCommand(command);
            }
            else
            {
                MessageBox.Show(Properties.Resources.PrinterDisconnected_Text, Properties.Resources.PrinterDisconnected_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.toggleControls(false);
            }
        }

        private void Connection_eventConnectionChange(string msg)
        {
            host.LogWarning("host.Connection.connector.IsConnected():" + host.Connection.connector.IsConnected().ToString());
            if (!host.Connection.connector.IsConnected())
            {
                toggleControls(false);
            }
            else
            {
                toggleControls(true);
            }
        }

        #endregion


        private void loadUnloadProcedure()
        {

            buttonUnload.Visible = false;
            buttonLoad.Visible = false;
            buttonCancel.Visible = true;
            labelLoadingStatus.Visible = true;
            buttonPreheat.Enabled = false;
            buttonCalibrate.Enabled = false;

            // Go to Z 0 (approx) and then up by at least 5cm to leave 
            // room for the filament to go out of the nozzle
            labelLoadingStatus.Text = Properties.Resources.LoadingLabel_MovingAway;
            this.injectCommand("G1 Z50 F3000");

            // If you don't put the fan on, the extruded filament 
            // will stick to the nozzle - we don't want that
            labelLoadingStatus.Text = Properties.Resources.LoadingLabel_FanOn;
            this.injectCommand("M106");

            // Go to temperature X and wait
            labelLoadingStatus.Text = Properties.Resources.LoadingLabel_Heating;
            this.injectCommand("M104 S" + this.loadingTemperature.ToString());

            // Then wait ...
            host.Connection.eventTempHistory += loadUnloadProcedure_Continue;

        }

        private async void loadUnloadProcedure_Continue(TemperatureEntry ent)
        {
            if (ent.extruder >= this.loadingTemperature - this.temperatureBias)
            {
               
                // Cannot cancel the move ...
                buttonCancel.Enabled = false;

                // Relative
                this.injectCommand("G91");

                // Then extrude 
                if (this.loading == true)
                {
                    MessageBox.Show(Properties.Resources.LoadingMessageBox_Text, Properties.Resources.LoadingMessageBox_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    labelLoadingStatus.Text = Properties.Resources.LoadingLabel_Loading;
                    this.injectCommand("G1 E100 F300");
                }
                else if (this.unloading == true)
                {
                    MessageBox.Show(Properties.Resources.UnloadingMessageBox_Text, Properties.Resources.UnloadingMessageBox_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    labelLoadingStatus.Text = Properties.Resources.LoadingLabel_Unloading;
                    this.injectCommand("G1 E-70 F300");
                }
                // Absolute
                this.injectCommand("G90");

                // Remove event Handler for waiting
                host.Connection.eventTempHistory -= loadUnloadProcedure_Continue;

                // Wait for the move to finish
                await this.loadUnloadProcedure_Finish();
                // Stop heating a few minutes after
                await this.loadUnloadProcedure_StopHeating();
            }
        }

        async Task loadUnloadProcedure_Finish()
        {
            int delay = (this.loading == true) ? 20000 : 14000;
            await Task.Delay(delay);

            // Fan off
            labelLoadingStatus.Text = Properties.Resources.LoadingLabel_FanOff;
            this.injectCommand("M107");

            buttonUnload.Visible = true;
            buttonLoad.Visible = true;
            buttonCancel.Visible = false;
            labelLoadingStatus.Visible = false;
            buttonPreheat.Enabled = true;
            buttonCalibrate.Enabled = true;
            buttonCancel.Enabled = true;

            this.unloading = false;
            this.loading = false;
        }

        async Task loadUnloadProcedure_StopHeating()
        {
            // Stop heating after 5 min
            await Task.Delay(300000);

            if (this.unloading == false && this.loading == false && this.preheating == false)
            {
                this.injectCommand("M104 S0");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.loading = true;
            this.unloading = false;
            this.loadUnloadProcedure();
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            this.loading = false;
            this.unloading = true;
            this.loadUnloadProcedure();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonUnload.Visible = true;
            buttonLoad.Visible = true;
            buttonCancel.Visible = false;
            labelLoadingStatus.Visible = false;
            buttonPreheat.Enabled = true;
            buttonCalibrate.Enabled = true;

            this.loading = false;
            this.unloading = false;

            // Remove event Handler for waiting
            host.Connection.eventTempHistory -= loadUnloadProcedure_Continue;

            // And cancels the commands
            // Temp to 0°C, fan off
            this.injectCommand("G90");
            this.injectCommand("M107");
            this.injectCommand("M104 S0");

        }

        private void buttonPreheat_Click(object sender, EventArgs e)
        {

            if (this.preheating == false)
            {

                labelPreheatingStatus.BackColor = Color.LightCoral;
                labelPreheatingStatus.Text = Properties.Resources.PreheatLabel_Heating;

                buttonPreheat.Text = Properties.Resources.PreheatButton_Cancel;

                // Disables load/unload
                buttonUnload.Enabled = false;
                buttonLoad.Enabled = false;
                buttonCancel.Enabled = false;

                this.preheating = true;

                // Temp to X°C
                this.injectCommand("M104 S" + preheatingTemperature.Value);

                // Wait ? Display

            } else {

                labelPreheatingStatus.BackColor = Color.DeepSkyBlue;
                labelPreheatingStatus.Text = Properties.Resources.PreheatLabel_NotHeating;

                buttonPreheat.Text = Properties.Resources.PreheatButton_Do;

                // Reenables load/unload
                buttonUnload.Enabled = true;
                buttonLoad.Enabled = true;
                buttonCancel.Enabled = true;

                this.preheating = false;

                // Temp to 0°C
                this.injectCommand("M104 S0");
                
            }

        }

        void preheat_Update(TemperatureEntry ent)
        {
            if (ent.extruder >= this.loadingTemperature - this.temperatureBias)
            {
                labelPreheatingStatus.Text = Properties.Resources.PreheatLabel_NotHeating;
            }
        }

        private void stopCalibration()
        {
            buttonUnload.Enabled = true;
            buttonLoad.Enabled = true;
            buttonCancel.Enabled = true;
            buttonPreheat.Enabled = true;

            buttonTooClose.Visible = false;
            buttonCalibrationOK.Visible = false;
            buttonTooFar.Visible = false;
            buttonCalibrate.Visible = true;

            buttonCalibrate.Text = Properties.Resources.CalibrateButton_Do;
            labelCalibration.Text = Properties.Resources.CalibrateHelp;

            this.calibrating = false;

            // Stop heating, in case
            this.injectCommand("M104 S0");
            this.injectCommand("G90");
            this.injectCommand("M107");
        }

        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            if (this.calibrating == true)
            {
                this.stopCalibration();
            }
            else
            {
                buttonUnload.Enabled = false;
                buttonLoad.Enabled = false;
                buttonCancel.Enabled = false;
                buttonPreheat.Enabled = false;

                this.calibrating = true;

                /* STEP 1 */
                buttonCalibrate.Text = Properties.Resources.CalibrateButton_Cancel;
                labelCalibration.Text = Properties.Resources.Calibrate_Step1;

                DialogResult newOrNot = MessageBox.Show(Properties.Resources.NewCalibrationOrNot_Text, Properties.Resources.NewCalibrationOrNot_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // Start with an offset
                if (newOrNot == DialogResult.Yes)
                {
                    this.injectCommand("M212 Z0.6");
                    this.injectCommand("M500");
                }

                this.injectCommand("G28 X0 Y0");
                this.injectCommand("G28 Z0");
                this.injectCommand("G29");

                System.Threading.Thread.Sleep(3); // Wait for G29 a bit

                /* STEP 2 */
                // Then run job
                var context = TaskScheduler.FromCurrentSynchronizationContext();

                Task calibrationPrint = Task.Factory.StartNew(() =>
                {
                    using (StringReader reader = new StringReader(global::PrintrBotPlugin.Properties.Resources.calibration_cube))
                    {
                        string line;
                        double count = 0.0;
                        while ((line = reader.ReadLine()) != null && this.calibrating == true)
                        {
                            count++;
                            var token = Task.Factory.CancellationToken;
                            Task.Factory.StartNew(() =>
                            {
                                if (count > 15)
                                {
                                    labelCalibration.Text = Properties.Resources.Calibrate_Step2 + String.Format(" ({0:P0})", (count / System.Convert.ToDouble(global::PrintrBotPlugin.Properties.Resources.NumberOfLinesInCalibrationGCODE) ));
                                }
                            }, token, TaskCreationOptions.None, context);

                            while (host.Connection.connector.InjectedCommands != 0 && this.calibrating == true)
                            {
                                System.Threading.Thread.Sleep(1);
                            }
                            if (this.calibrating == true)
                            {
                                this.injectCommand(line);
                            }
                        }
                    }

                }).ContinueWith(_ => {

                    /* STEP 3 */
                    if (this.calibrating == true)
                    {
                        // We want to retrieve the M212 Offsets, so we trigger a M501 and handle the response below
                        host.Connection.eventResponse += Connection_eventResponse;
                        host.Connection.injectManualCommand("M501");

                        labelCalibration.Text = Properties.Resources.Calibrate_Step2Done;
                        buttonTooClose.Visible = true;
                        buttonCalibrationOK.Visible = true;
                        buttonTooFar.Visible = true;
                        buttonCalibrate.Visible = false;
                    }

                }, context);

            }

        }

        private void Connection_eventResponse(string response, ref RepetierHostExtender.basic.LogLevel level)
        {
            if (response.Contains("M212") && this.calibrating == true)
            {
                // Let's extract the value from the echo sent by Marlin
                this.M212_Z_Offset = System.Convert.ToDouble(host.Connection.extract(response, "Z"));
                // We don't need this handler anymore, we have a value  
                host.Connection.eventResponse -= Connection_eventResponse;
            }

        }

        private void changeZProbeOffset(double offset)
        {
            if (this.M212_Z_Offset != 1000 ) // <> not probed yet
            {
               // Change offset by "offset" -1 < Z < 1
               this.injectCommand(String.Format("M212 Z{0:f1}", Math.Min(1,Math.Max(this.M212_Z_Offset + offset, -1.0))));
               this.injectCommand("M500"); // Saves
            }
        }

        private void buttonTooClose_Click(object sender, EventArgs e)
        {
            // Bigger offset, so the probe triggers farther from the plate
            this.changeZProbeOffset(0.2);
            this.stopCalibration();
        }

        private void buttonTooFar_Click(object sender, EventArgs e)
        {
            // Lower offset, so the probe triggers closer to the plate
            this.changeZProbeOffset(-0.2);
            this.stopCalibration();
        }

        private void buttonCalibrationOK_Click(object sender, EventArgs e)
        {
            // Offset was alright, no need to change anything
            this.stopCalibration();
        }

        private void linkCKAB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ckab.com");
        }
 
    }
}
