public int GetHashCode(NotificationModel obj)
{
	int hashProductName = 0;
	if (!Object.ReferenceEquals(obj, null) && !string.IsNullOrEmpty(obj.JobName))
	{
	   hashProductName= obj.JobName.GetHashCode();
	}
	return hashProductName;
}