﻿using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;

namespace SmartMonitor.UI
{
    public partial class Alert : MetroFramework.Forms.MetroForm
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void createAlert_Click(object sender, System.EventArgs e)
        {
            int cpuMax = cpuTrackBar.Value;
            string email = emailAddress.Text;

            RunPsScript("C:\\Users\\bcarausan\\Disertatie\\SmartMonitor\\Scripts\\createAlert.ps1");
        }

        private Collection<PSObject> RunPsScript(string psScriptPath)
        {
            string psScript = string.Empty;
            if (File.Exists(psScriptPath))
                psScript = File.ReadAllText(psScriptPath);
            else
                throw new FileNotFoundException("Wrong path for the script file");
            RunspaceConfiguration config = RunspaceConfiguration.Create();
            PSSnapInException psEx;
            //add Microsoft SharePoint PowerShell SnapIn
            PSSnapInInfo pssnap = config.AddPSSnapIn("Microsoft.SharePoint.PowerShell", out psEx);
            //create powershell runspace
            Runspace cmdlet = RunspaceFactory.CreateRunspace(config);
            cmdlet.Open();
            RunspaceInvoke scriptInvoker = new RunspaceInvoke(cmdlet);
            // set powershell execution policy to unrestricted
            scriptInvoker.Invoke("Set-ExecutionPolicy Unrestricted");
            // create a pipeline and load it with command object
            Pipeline pipeline = cmdlet.CreatePipeline();
            try
            {
                // Using Get-SPFarm powershell command 
                pipeline.Commands.AddScript(psScript);
                pipeline.Commands.AddScript("Out-String");
                // this will format the output
                Collection<PSObject> output = pipeline.Invoke();
                pipeline.Stop();
                cmdlet.Close();
                // process each object in the output and append to stringbuilder  
                StringBuilder results = new StringBuilder();
                foreach (PSObject obj in output)
                {
                    results.AppendLine(obj.ToString());
                }
                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
