using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Web.Management.Client.Win32;
using Microsoft.Web.Administration;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Server;
namespace IIS7Demos
{
    public sealed class imageCopyrightUIPage : ModulePage
    {
        public string message;
        public bool featureenabled;
        public string color;

        ComboBox _colCombo = new ComboBox();
        TextBox _msgTB = new TextBox();
        CheckBox _enabledCB = new CheckBox();
        public imageCopyrightUIPage()
        {
            this.Initialize();
        }
        protected override void OnActivated(bool initialActivation)
        {
           base.OnActivated(initialActivation);
           if (initialActivation)
           {
                ReadConfig();
                UpdateUI();
            }
        }

        void UpdateUI()
        {
            _enabledCB.Checked = featureenabled;
            int n = _colCombo.FindString(color, 0);
            _colCombo.SelectedIndex = n;
            _msgTB.Text = message;
        }

        void Initialize()
        {
            Label crlabel = new Label();
            crlabel.Left = 50;
            crlabel.Top = 100;
            crlabel.AutoSize = true;
            crlabel.Text = "Enable Image Copyright:";
            _enabledCB.Text = "";
            _enabledCB.Left = 200;
            _enabledCB.Top = 100;
            _enabledCB.AutoSize = true;

            Label msglabel = new Label();
            msglabel.Left = 150;
            msglabel.Top = 130;
            msglabel.AutoSize = true;
            msglabel.Text = "Message:";
            _msgTB.Left = 200;
            _msgTB.Top = 130;
            _msgTB.Width = 200;
            _msgTB.Height = 50;

            Label collabel = new Label();
            collabel.Left = 160;
            collabel.Top = 160;
            collabel.AutoSize = true;
            collabel.Text = "Color:";
            _colCombo.Left = 200;
            _colCombo.Top = 160;
            _colCombo.Width = 50;
            _colCombo.Height = 90;
            _colCombo.Items.Add((object)"Yellow");
            _colCombo.Items.Add((object)"Blue");
            _colCombo.Items.Add((object)"Red");
            _colCombo.Items.Add((object)"White");

            Button apply = new Button();
            apply.Text = "Apply";
            apply.Click += new EventHandler(this.applyClick);
            apply.Left = 200;
            apply.AutoSize = true;
            apply.Top = 250;

            Controls.Add(crlabel);
            Controls.Add(_enabledCB);
            Controls.Add(collabel);
            Controls.Add(_colCombo);
            Controls.Add(msglabel);
            Controls.Add(_msgTB);
            Controls.Add(apply);
        }

        private void applyClick(Object sender, EventArgs e)
        {
            try
            {
                UpdateVariables();
                ServerManager mgr;
                ConfigurationSection section;
                mgr = new ServerManager();
                Configuration config =
                mgr.GetWebConfiguration
                (
                       Connection.ConfigurationPath.SiteName, 
                       Connection.ConfigurationPath.ApplicationPath +
                       Connection.ConfigurationPath.FolderPath
                );

            section = config.GetSection("system.webServer/imageCopyright");
            section.GetAttribute("color").Value = (object)color;
            section.GetAttribute("message").Value = (object)message;
            section.GetAttribute("enabled").Value = (object)featureenabled;

            mgr.CommitChanges();

            }

            catch
            {}

        }

        public void UpdateVariables()
        {
            featureenabled = _enabledCB.Checked;
            color = _colCombo.Text;
            message = _msgTB.Text;
        }

        public void ReadConfig()
        {
            try
            {
                ServerManager mgr;
                ConfigurationSection section;
                mgr = new ServerManager();
                Configuration config =
                mgr.GetWebConfiguration(
                       Connection.ConfigurationPath.SiteName,
                       Connection.ConfigurationPath.ApplicationPath +
                       Connection.ConfigurationPath.FolderPath);

                section = config.GetSection("system.webServer/imageCopyright");
                color = (string)section.GetAttribute("color").Value;
                message = (string)section.GetAttribute("message").Value;
                featureenabled = (bool)section.GetAttribute("enabled").Value;

            }

            catch
            {}

        }
    }
}