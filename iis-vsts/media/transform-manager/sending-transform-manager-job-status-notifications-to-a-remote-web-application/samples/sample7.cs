public NotificationModel()
     : base((DateTime.MaxValue - DateTime.Now).Ticks.ToString(), Guid.NewGuid().ToString())
{
}