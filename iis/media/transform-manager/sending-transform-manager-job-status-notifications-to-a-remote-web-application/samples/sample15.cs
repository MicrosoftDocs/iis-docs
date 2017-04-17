public NotificationDataSource()
        {
            var account = Microsoft.WindowsAzure.CloudStorageAccount.FromConfigurationSetting("DataConnectionString");
            _serviceContext = new NotificationDataServiceContext(account.TableEndpoint.ToString(), account.Credentials);
            _serviceContext.RetryPolicy = RetryPolicies.Retry(3, TimeSpan.FromSeconds(1)); 
            CloudTableClient client = account.CreateCloudTableClient(); 
            client.CreateTableIfNotExist(NotificationDataServiceContext.TableName);
        }
        public IEnumerable<NotificationModel> Select()
        {
            var results = from c in _serviceContext.Notifications
                          select c ;
            var query = results.AsTableServiceQuery<NotificationModel>();
            var queryResults = query.Execute();
            return queryResults;
        }
        public void Insert(NotificationModel newItem)
        {
            _serviceContext.AddObject(NotificationDataServiceContext.TableName, newItem);
            _serviceContext.SaveChangesWithRetries();  
        }
    }