public class JobMonController : Controller
{
    public ActionResult Index()
    {
        List<Models.NotificationModel> tms = new List<Models.NotificationModel>();
        Models.NotificationDataSource data = new Models.NotificationDataSource();
        Models.NotificationComparer comparer = new Models.NotificationComparer();
        IEnumerable<Models.NotificationModel> notifications;