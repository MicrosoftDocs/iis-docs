public class NotificationComparer: IEqualityComparer<NotificationModel>, IComparer<NotificationModel>
    {
        public bool Equals(NotificationModel x, NotificationModel y)
        {
            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;