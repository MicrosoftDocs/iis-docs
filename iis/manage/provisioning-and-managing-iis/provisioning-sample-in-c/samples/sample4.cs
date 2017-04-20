public static bool AddUserDiskQuota(string userName, double quota, double quotaThreshold, string diskVolume)
{
   try
   {
      DiskQuotaControlClass diskQuotaCtrl = GetDiskQuotaControl(diskVolume);
      diskQuotaCtrl.UserNameResolution = UserNameResolutionConstants.dqResolveNone;
      DIDiskQuotaUser diskUser = diskQuotaCtrl.AddUser(userName);
      diskUser.QuotaLimit = quota;
      diskUser.QuotaThreshold = quotaThreshold;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message, ex);
    }
    return true;
}