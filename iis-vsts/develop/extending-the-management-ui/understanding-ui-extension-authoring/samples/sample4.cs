using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Web.Management.Client.Win32;
using Microsoft.Web.Management.Server;

namespace Client {
    internal class DemoModuleListPage : ModuleListPage {
        private ColumnHeader _keyColumnHeader;
        private ColumnHeader _valueColumnHeader;
        private DemoModuleServiceProxy _serviceProxy;

        private DemoModuleServiceProxy ServiceProxy {
            get {
                if (_serviceProxy == null) {
                    _serviceProxy = (DemoModuleServiceProxy)CreateProxy(typeof(DemoModuleServiceProxy));
                }
                return _serviceProxy;
            }
        }

        protected override void InitializeListPage() {
            _keyColumnHeader = new ColumnHeader();
            _keyColumnHeader.Text = "Key";
            _keyColumnHeader.Width = 200;

            _valueColumnHeader = new ColumnHeader();
            _valueColumnHeader.Text = "Value";
            _valueColumnHeader.Width = 200;

            ListView.Columns.Add(_keyColumnHeader);
            ListView.Columns.Add(_valueColumnHeader);
        }

        protected override void OnActivated(bool initialActivation) {
            base.OnActivated(initialActivation);
            if (initialActivation) {
                GetAppSettings();
            }
        }

        private void GetAppSettings() {
            StartAsyncTask("Getting Settings", new DoWorkEventHandler(GetSettings),
                                              new RunWorkerCompletedEventHandler(GetSettingsCompleted));
        }

        private void GetSettings(object sender, DoWorkEventArgs e) {
            e.Result = ServiceProxy.GetAppSettings();
        }

        private void GetSettingsCompleted(object sender, RunWorkerCompletedEventArgs e) {
            ListView.BeginUpdate();
            try {
                ArrayList settingsList = (ArrayList)e.Result;
                foreach (PropertyBag bag in settingsList) {
                    ListViewItem item = new ListViewItem();
                    item.Text = (string)bag[0];
                    item.SubItems.Add((string)bag[1]);

                    ListView.Items.Add(item);
                }
            }
            finally {
                ListView.EndUpdate();
            }
        }
    }
}