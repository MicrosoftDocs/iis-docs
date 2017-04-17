using Microsoft.WindowsAzure.StorageClient;
public class NotifyMeMVC : Microsoft.WindowsAzure.ServiceRuntime.RoleEntryPoint
{
    public override bool OnStart()
    {
        var account = Microsoft.WindowsAzure.CloudStorageAccount.Parse(
            Microsoft.WindowsAzure.ServiceRuntime.RoleEnvironment.GetConfigurationSettingValue("DataConnectionString"));
        // Required to ensure that the table is created on time
        account.CreateCloudTableClient().CreateTableIfNotExist(Models.NotificationDataServiceContext.TableName); //Note: We will implement the NotificationDataServiceContext class later in this article