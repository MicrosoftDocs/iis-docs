// Install the application
DeploymentSyncOptions syncOptions = new DeploymentSyncOptions();
iisApplication.SyncTo(DeploymentWellKnownProvider.Auto, String.Empty, destinationOptions, syncOptions);