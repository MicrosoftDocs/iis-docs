ApplicationPool apppool = serverManager.ApplicationPools["RacingApplicationPool"];
apppool.ManagedPipelineMode = ManagedPipelineMode.ISAPI;
serverManager.CommitChanges();
apppool.Recycle();