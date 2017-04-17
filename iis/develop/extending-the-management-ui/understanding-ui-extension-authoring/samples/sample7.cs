using System.Collections;
using Microsoft.Web.Administration;
using Microsoft.Web.Management.Server;

namespace Server {
    internal class DemoModuleService : ModuleService {

        [ModuleServiceMethod(PassThrough = true)]
        public ArrayList GetAppSettings() {

            ArrayList settingsList = new ArrayList();

            ConfigurationSection appSettingsSection =
                ManagementUnit.Configuration.GetSection(@"appSettings");
            ConfigurationElementCollection settingsCollection = appSettingsSection.GetCollection();

            foreach (ConfigurationElement element in settingsCollection) {
                PropertyBag bag = new PropertyBag();
                bag[0] = element.GetAttributeValue("key");
                bag[1] = element.GetAttributeValue("value");
                settingsList.Add(bag);
            }

            return settingsList;
        }
    }
}