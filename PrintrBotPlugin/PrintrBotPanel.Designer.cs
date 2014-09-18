namespace PrintrBotPlugin
{
    partial class PrintrBotPanel
    {
        /// <summary> 
        /// Required by the conceptor.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Cleaning resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Generated Code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintrBotPanel));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonUnload = new System.Windows.Forms.Button();
            this.groupFilament = new System.Windows.Forms.GroupBox();
            this.labelLoadingStatus = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupPreheating = new System.Windows.Forms.GroupBox();
            this.buttonPreheat = new System.Windows.Forms.Button();
            this.labelPreheatingStatus = new System.Windows.Forms.Label();
            this.preheatingTemperature = new System.Windows.Forms.NumericUpDown();
            this.labelPreheatingTemp = new System.Windows.Forms.Label();
            this.labelTitlePanel = new System.Windows.Forms.Label();
            this.panelLogos = new System.Windows.Forms.Panel();
            this.LogoPRINTRBOT = new System.Windows.Forms.PictureBox();
            this.groupCalibration = new System.Windows.Forms.GroupBox();
            this.buttonCalibrationOK = new System.Windows.Forms.Button();
            this.buttonTooFar = new System.Windows.Forms.Button();
            this.buttonTooClose = new System.Windows.Forms.Button();
            this.labelCalibration = new System.Windows.Forms.Label();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.linkCKAB = new System.Windows.Forms.LinkLabel();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.labelConnection = new System.Windows.Forms.Label();
            this.buttonCheckConnection = new System.Windows.Forms.Button();
            this.groupFilament.SuspendLayout();
            this.groupPreheating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preheatingTemperature)).BeginInit();
            this.panelLogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPRINTRBOT)).BeginInit();
            this.groupCalibration.SuspendLayout();
            this.panelConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLoad.Location = new System.Drawing.Point(6, 19);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(119, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load filament";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonUnload
            // 
            this.buttonUnload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnload.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonUnload.Location = new System.Drawing.Point(6, 48);
            this.buttonUnload.Name = "buttonUnload";
            this.buttonUnload.Size = new System.Drawing.Size(119, 23);
            this.buttonUnload.TabIndex = 4;
            this.buttonUnload.Text = "Unload filament";
            this.buttonUnload.UseVisualStyleBackColor = true;
            this.buttonUnload.Click += new System.EventHandler(this.buttonUnload_Click);
            // 
            // groupFilament
            // 
            this.groupFilament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilament.Controls.Add(this.buttonLoad);
            this.groupFilament.Controls.Add(this.buttonUnload);
            this.groupFilament.Controls.Add(this.labelLoadingStatus);
            this.groupFilament.Controls.Add(this.buttonCancel);
            this.groupFilament.Location = new System.Drawing.Point(10, 141);
            this.groupFilament.MinimumSize = new System.Drawing.Size(131, 79);
            this.groupFilament.Name = "groupFilament";
            this.groupFilament.Size = new System.Drawing.Size(131, 79);
            this.groupFilament.TabIndex = 5;
            this.groupFilament.TabStop = false;
            this.groupFilament.Text = "Filament";
            // 
            // labelLoadingStatus
            // 
            this.labelLoadingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoadingStatus.Location = new System.Drawing.Point(6, 19);
            this.labelLoadingStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadingStatus.Name = "labelLoadingStatus";
            this.labelLoadingStatus.Size = new System.Drawing.Size(119, 23);
            this.labelLoadingStatus.TabIndex = 5;
            this.labelLoadingStatus.Text = "<TEXT>";
            this.labelLoadingStatus.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Location = new System.Drawing.Point(6, 48);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupPreheating
            // 
            this.groupPreheating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPreheating.Controls.Add(this.buttonPreheat);
            this.groupPreheating.Controls.Add(this.labelPreheatingStatus);
            this.groupPreheating.Controls.Add(this.preheatingTemperature);
            this.groupPreheating.Controls.Add(this.labelPreheatingTemp);
            this.groupPreheating.Location = new System.Drawing.Point(147, 141);
            this.groupPreheating.MinimumSize = new System.Drawing.Size(181, 79);
            this.groupPreheating.Name = "groupPreheating";
            this.groupPreheating.Size = new System.Drawing.Size(181, 79);
            this.groupPreheating.TabIndex = 7;
            this.groupPreheating.TabStop = false;
            this.groupPreheating.Text = "Preheating";
            // 
            // buttonPreheat
            // 
            this.buttonPreheat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPreheat.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPreheat.Location = new System.Drawing.Point(8, 42);
            this.buttonPreheat.Name = "buttonPreheat";
            this.buttonPreheat.Size = new System.Drawing.Size(56, 29);
            this.buttonPreheat.TabIndex = 3;
            this.buttonPreheat.Text = "Start";
            this.buttonPreheat.UseVisualStyleBackColor = false;
            this.buttonPreheat.Click += new System.EventHandler(this.buttonPreheat_Click);
            // 
            // labelPreheatingStatus
            // 
            this.labelPreheatingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreheatingStatus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelPreheatingStatus.Location = new System.Drawing.Point(70, 42);
            this.labelPreheatingStatus.Name = "labelPreheatingStatus";
            this.labelPreheatingStatus.Size = new System.Drawing.Size(100, 29);
            this.labelPreheatingStatus.TabIndex = 2;
            this.labelPreheatingStatus.Text = "Not Heating";
            this.labelPreheatingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preheatingTemperature
            // 
            this.preheatingTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preheatingTemperature.Location = new System.Drawing.Point(126, 19);
            this.preheatingTemperature.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.preheatingTemperature.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.preheatingTemperature.Name = "preheatingTemperature";
            this.preheatingTemperature.Size = new System.Drawing.Size(44, 20);
            this.preheatingTemperature.TabIndex = 0;
            this.preheatingTemperature.Value = new decimal(new int[] {
            215,
            0,
            0,
            0});
            // 
            // labelPreheatingTemp
            // 
            this.labelPreheatingTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreheatingTemp.AutoSize = true;
            this.labelPreheatingTemp.Location = new System.Drawing.Point(5, 22);
            this.labelPreheatingTemp.Name = "labelPreheatingTemp";
            this.labelPreheatingTemp.Size = new System.Drawing.Size(123, 13);
            this.labelPreheatingTemp.TabIndex = 1;
            this.labelPreheatingTemp.Text = "Preheating temperature :";
            // 
            // labelTitlePanel
            // 
            this.labelTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePanel.Location = new System.Drawing.Point(8, 93);
            this.labelTitlePanel.MinimumSize = new System.Drawing.Size(200, 20);
            this.labelTitlePanel.Name = "labelTitlePanel";
            this.labelTitlePanel.Size = new System.Drawing.Size(320, 20);
            this.labelTitlePanel.TabIndex = 9;
            this.labelTitlePanel.Text = "PrintrBot Control Panel by CKAB";
            this.labelTitlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogos
            // 
            this.panelLogos.BackColor = System.Drawing.Color.White;
            this.panelLogos.Controls.Add(this.LogoPRINTRBOT);
            this.panelLogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogos.Location = new System.Drawing.Point(0, 0);
            this.panelLogos.Name = "panelLogos";
            this.panelLogos.Size = new System.Drawing.Size(340, 71);
            this.panelLogos.TabIndex = 10;
            // 
            // LogoPRINTRBOT
            // 
            this.LogoPRINTRBOT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPRINTRBOT.Image = ((System.Drawing.Image)(resources.GetObject("LogoPRINTRBOT.Image")));
            this.LogoPRINTRBOT.Location = new System.Drawing.Point(0, 0);
            this.LogoPRINTRBOT.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPRINTRBOT.Name = "LogoPRINTRBOT";
            this.LogoPRINTRBOT.Size = new System.Drawing.Size(340, 71);
            this.LogoPRINTRBOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPRINTRBOT.TabIndex = 7;
            this.LogoPRINTRBOT.TabStop = false;
            // 
            // groupCalibration
            // 
            this.groupCalibration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCalibration.Controls.Add(this.buttonCalibrationOK);
            this.groupCalibration.Controls.Add(this.buttonTooFar);
            this.groupCalibration.Controls.Add(this.buttonTooClose);
            this.groupCalibration.Controls.Add(this.labelCalibration);
            this.groupCalibration.Controls.Add(this.buttonCalibrate);
            this.groupCalibration.Location = new System.Drawing.Point(10, 222);
            this.groupCalibration.Name = "groupCalibration";
            this.groupCalibration.Size = new System.Drawing.Size(318, 163);
            this.groupCalibration.TabIndex = 11;
            this.groupCalibration.TabStop = false;
            this.groupCalibration.Text = "Calibration";
            // 
            // buttonCalibrationOK
            // 
            this.buttonCalibrationOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalibrationOK.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCalibrationOK.Location = new System.Drawing.Point(137, 131);
            this.buttonCalibrationOK.Name = "buttonCalibrationOK";
            this.buttonCalibrationOK.Size = new System.Drawing.Size(48, 23);
            this.buttonCalibrationOK.TabIndex = 4;
            this.buttonCalibrationOK.Text = "All is OK";
            this.buttonCalibrationOK.UseVisualStyleBackColor = false;
            this.buttonCalibrationOK.Visible = false;
            this.buttonCalibrationOK.Click += new System.EventHandler(this.buttonCalibrationOK_Click);
            // 
            // buttonTooFar
            // 
            this.buttonTooFar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTooFar.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonTooFar.Location = new System.Drawing.Point(191, 131);
            this.buttonTooFar.Name = "buttonTooFar";
            this.buttonTooFar.Size = new System.Drawing.Size(104, 23);
            this.buttonTooFar.TabIndex = 3;
            this.buttonTooFar.Text = "Nozzle Too Far";
            this.buttonTooFar.UseVisualStyleBackColor = false;
            this.buttonTooFar.Visible = false;
            this.buttonTooFar.Click += new System.EventHandler(this.buttonTooFar_Click);
            // 
            // buttonTooClose
            // 
            this.buttonTooClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTooClose.BackColor = System.Drawing.Color.White;
            this.buttonTooClose.Location = new System.Drawing.Point(27, 131);
            this.buttonTooClose.Name = "buttonTooClose";
            this.buttonTooClose.Size = new System.Drawing.Size(104, 23);
            this.buttonTooClose.TabIndex = 2;
            this.buttonTooClose.Text = "Nozzle Too Close";
            this.buttonTooClose.UseVisualStyleBackColor = false;
            this.buttonTooClose.Visible = false;
            this.buttonTooClose.Click += new System.EventHandler(this.buttonTooClose_Click);
            // 
            // labelCalibration
            // 
            this.labelCalibration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCalibration.Location = new System.Drawing.Point(6, 20);
            this.labelCalibration.Name = "labelCalibration";
            this.labelCalibration.Size = new System.Drawing.Size(301, 108);
            this.labelCalibration.TabIndex = 1;
            this.labelCalibration.Text = "To calibrate the Z axis, you need to find the correct offset for the nozzle first" +
    ", and then calculate the planearity of the plate";
            // 
            // buttonCalibrate
            // 
            this.buttonCalibrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalibrate.Location = new System.Drawing.Point(102, 131);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(119, 23);
            this.buttonCalibrate.TabIndex = 0;
            this.buttonCalibrate.Text = "Calibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibrate_Click);
            // 
            // linkCKAB
            // 
            this.linkCKAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkCKAB.Location = new System.Drawing.Point(274, 388);
            this.linkCKAB.Name = "linkCKAB";
            this.linkCKAB.Size = new System.Drawing.Size(54, 13);
            this.linkCKAB.TabIndex = 12;
            this.linkCKAB.TabStop = true;
            this.linkCKAB.Text = "ckab.com";
            this.linkCKAB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCKAB_LinkClicked);
            // 
            // panelConnection
            // 
            this.panelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnection.Controls.Add(this.labelConnection);
            this.panelConnection.Controls.Add(this.buttonCheckConnection);
            this.panelConnection.Location = new System.Drawing.Point(10, 189);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(318, 125);
            this.panelConnection.TabIndex = 13;
            this.panelConnection.Visible = false;
            // 
            // labelConnection
            // 
            this.labelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnection.Location = new System.Drawing.Point(9, 14);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(298, 45);
            this.labelConnection.TabIndex = 1;
            this.labelConnection.Text = "The PrintrBot seems not connected. Connect it and press the button below to start" +
    ".";
            // 
            // buttonCheckConnection
            // 
            this.buttonCheckConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckConnection.Location = new System.Drawing.Point(95, 62);
            this.buttonCheckConnection.Name = "buttonCheckConnection";
            this.buttonCheckConnection.Size = new System.Drawing.Size(126, 45);
            this.buttonCheckConnection.TabIndex = 0;
            this.buttonCheckConnection.Text = "Check Connection";
            this.buttonCheckConnection.UseVisualStyleBackColor = true;
            this.buttonCheckConnection.Click += new System.EventHandler(this.buttonCheckConnection_Click);
            // 
            // PrintrBotPanel
            // 
            this.Controls.Add(this.linkCKAB);
            this.Controls.Add(this.groupCalibration);
            this.Controls.Add(this.panelLogos);
            this.Controls.Add(this.labelTitlePanel);
            this.Controls.Add(this.groupPreheating);
            this.Controls.Add(this.groupFilament);
            this.Controls.Add(this.panelConnection);
            this.Name = "PrintrBotPanel";
            this.Size = new System.Drawing.Size(340, 410);
            this.Load += new System.EventHandler(this.PrintrBotPanel_Load);
            this.groupFilament.ResumeLayout(false);
            this.groupPreheating.ResumeLayout(false);
            this.groupPreheating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preheatingTemperature)).EndInit();
            this.panelLogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPRINTRBOT)).EndInit();
            this.groupCalibration.ResumeLayout(false);
            this.panelConnection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Skin
        private System.Windows.Forms.Label labelTitlePanel;
        private System.Windows.Forms.Panel panelLogos;
        private System.Windows.Forms.PictureBox LogoPRINTRBOT;
        private System.Windows.Forms.LinkLabel linkCKAB;

        // Filament
        private System.Windows.Forms.GroupBox groupFilament;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonUnload;

        // Pre heating
        private System.Windows.Forms.GroupBox groupPreheating;
        private System.Windows.Forms.Label labelPreheatingTemp;
        private System.Windows.Forms.Label labelPreheatingStatus;
        private System.Windows.Forms.Button buttonPreheat;
        private System.Windows.Forms.NumericUpDown preheatingTemperature;

        // Calibration
        private System.Windows.Forms.GroupBox groupCalibration;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLoadingStatus;
        private System.Windows.Forms.Label labelCalibration;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.Button buttonTooFar;
        private System.Windows.Forms.Button buttonTooClose;
        private System.Windows.Forms.Button buttonCalibrationOK;

        // Check Connection
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Button buttonCheckConnection;

    }
}
