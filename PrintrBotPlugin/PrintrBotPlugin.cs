/* This is the plugin for the Printrbot printers
 *
 * 
 * Authors: Cyril Chapellier for CKAB
 * Licence: CC-BY-NC-SA 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepetierHostExtender.interfaces;

namespace PrintrBotPlugin
{
    public class PrintrBotPlugin : IHostPlugin
    {
        IHost host;
        /// <summary>
        /// Called first to allow filling some lists. Host is not fully set up at that moment.
        /// </summary>
        /// <param name="host"></param>
        public void PreInitalize(IHost _host)
        {
            host = _host;
        }
        /// <summary>
        /// Called after everything is initalized to finish parts, that rely on other initializations.
        /// Here you must create and register new Controls and Windows.
        /// </summary>
        public void PostInitialize()
        {
            // Add the Panel to the right tab
            PrintrBotPanel panel = new PrintrBotPanel();
            panel.Connect(host);
            host.RegisterHostComponent(panel);

            // Add some text in the about dialog
            host.AboutDialog.RegisterThirdParty("PrintrBotPlugin", "\r\n\r\nPrintrBotPlugin v1\r\nwritten by Cyril Chapellier for CKAB \r\nwww.ckab.com");
        }
        /// <summary>
        /// Last round of plugin calls. All controls exist, so now you may modify them to your wishes.
        /// </summary>
        public void FinializeInitialize()
        {

        }
    }
}
