public static string GetXElementValue(System.Xml.Linq.XElement element, System.Xml.Linq.XName name)
{
    string value = null; 
    if (element != null) { value = (string)element.Element(name); }
    return value;
}
public static string GetWorkItemAttributeValue(System.Xml.Linq.XElement element, System.Xml.Linq.XName name)
{
    string value = null;
    if (element != null) { value = (string)element.Attribute(name); }
    return value;
}
#endregion