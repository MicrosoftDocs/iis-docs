public IQueryable<NotificationModel> Notifications
{
	get { return this.CreateQuery<NotificationModel>(TableName); }
}