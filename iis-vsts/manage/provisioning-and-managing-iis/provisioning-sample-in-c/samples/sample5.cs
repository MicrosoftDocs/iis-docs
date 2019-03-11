public static bool CreateApplicationPool(string applicationPoolName, ProcessModelIdentityType identityType, string applicationPoolIdentity, string password, string managedRuntimeVersion, bool autoStart, bool enable32BitAppOnWin64,ManagedPipelineMode managedPipelineMode, long queueLength, TimeSpan idleTimeout, long periodicRestartPrivateMemory, TimeSpan periodicRestartTime)
{
   try
   {
      if (identityType == ProcessModelIdentityType.SpecificUser)
      {
         if (string.IsNullOrEmpty(applicationPoolName))
            throw new ArgumentNullException("applicationPoolName", "CreateApplicationPool: applicationPoolName is null or empty.");
         if (string.IsNullOrEmpty(applicationPoolIdentity))
            throw new ArgumentNullException("applicationPoolIdentity", "CreateApplicationPool: applicationPoolIdentity is null or empty.");
         if (string.IsNullOrEmpty(password))
            throw new ArgumentNullException("password", "CreateApplicationPool: password is null or empty.");
      }
      using (ServerManager mgr = new ServerManager())
      {
         ApplicationPool newAppPool = mgr.ApplicationPools.Add(applicationPoolName);
         if (identityType == ProcessModelIdentityType.SpecificUser)
         {
            newAppPool.ProcessModel.IdentityType = ProcessModelIdentityType.SpecificUser;
            newAppPool.ProcessModel.UserName = applicationPoolIdentity;
            newAppPool.ProcessModel.Password = password;
         }
         else
         {
            newAppPool.ProcessModel.IdentityType = identityType;
         }
            if (!string.IsNullOrEmpty(managedRuntimeVersion))
               newAppPool.ManagedRuntimeVersion = managedRuntimeVersion;
               newAppPool.AutoStart = autoStart;
               newAppPool.Enable32BitAppOnWin64 = enable32BitAppOnWin64;
               newAppPool.ManagedPipelineMode = managedPipelineMode;
            if (queueLength > 0)
               newAppPool.QueueLength = queueLength;
            if (idleTimeout != TimeSpan.MinValue)
               newAppPool.ProcessModel.IdleTimeout = idleTimeout;
            if (periodicRestartPrivateMemory > 0)
               newAppPool.Recycling.PeriodicRestart.PrivateMemory = periodicRestartPrivateMemory;
            if (periodicRestartTime != TimeSpan.MinValue)
               newAppPool.Recycling.PeriodicRestart.Time = periodicRestartTime;
            mgr.CommitChanges();
         }
   }
   catch (Exception ex)
   {
      throw new Exception(ex.Message, ex);
   }
   return true;
 }