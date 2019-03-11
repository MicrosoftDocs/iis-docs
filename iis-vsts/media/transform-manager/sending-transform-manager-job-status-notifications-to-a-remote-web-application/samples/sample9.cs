#region Public Static Functions
/// <summary>
/// Parse the Posted XML string into a NotificationModel object instance
/// </summary>
public static bool TryParse(string value, out NotificationModel notification)
{
    bool success = false;
    notification = null;
    try
    {
        System.Xml.XmlReader xReader = System.Xml.XmlReader.Create(new System.IO.StringReader(value));
        System.Xml.Linq.XElement element = System.Xml.Linq.XElement.Load(xReader);
        notification = new NotificationModel();
        // Populate the top XML elements values 
        notification.Log = GetXElementValue(element, "log");
        notification.PostedDateTime = DateTime.Now.ToString();
        notification.Queue = GetXElementValue(element, "queue");
        // Populate the WorkItem attributes values 
        System.Xml.Linq.XElement wItem = null;
        if (element != null)
        {
            wItem = element.Element("workItem");
        }
        notification.Folder = GetWorkItemAttributeValue(wItem, "folder");
        notification.JobDefinitionId = GetWorkItemAttributeValue(wItem, "jobDefinitionId");
        notification.JobTemplateId = GetWorkItemAttributeValue(wItem, "jobTemplateId");
        notification.JobSchedulerId = GetWorkItemAttributeValue(wItem, "jobSchedulerId");
        notification.ManifestName = GetWorkItemAttributeValue(wItem, "manifestName");
        notification.InstanceFileName = GetWorkItemAttributeValue(wItem, "instanceFileName");
        notification.QueueTime = GetWorkItemAttributeValue(wItem, "queueTime");
        notification.Progress = GetWorkItemAttributeValue(wItem, "progress");
        notification.SubmitTime = GetWorkItemAttributeValue(wItem, "submitTime");
        notification.StartTime = GetWorkItemAttributeValue(wItem, "startTime");
        notification.EndTime = GetWorkItemAttributeValue(wItem, "endTime");
        notification.Priority = GetWorkItemAttributeValue(wItem, "priority");
        notification.Status = GetWorkItemAttributeValue(wItem, "status");
        notification.TaskCount = GetWorkItemAttributeValue(wItem, "taskCount");
        notification.TaskIndex = GetWorkItemAttributeValue(wItem, "taskIndex");
        notification.JobName = GetWorkItemAttributeValue(wItem, "jobName");
        success = true;
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message); 
    }
    return success;
}