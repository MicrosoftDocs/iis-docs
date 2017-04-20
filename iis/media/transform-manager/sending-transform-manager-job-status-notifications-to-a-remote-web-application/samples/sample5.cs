Microsoft.WindowsAzure.CloudStorageAccount.SetConfigurationSettingPublisher((configName, configSettingPublisher) =>
{
	var connectionString = Microsoft.WindowsAzure.ServiceRuntime.RoleEnvironment.GetConfigurationSettingValue(configName);
	configSettingPublisher(connectionString);
});