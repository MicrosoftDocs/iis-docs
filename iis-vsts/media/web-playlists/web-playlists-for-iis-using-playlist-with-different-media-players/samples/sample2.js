function onMediaOpened(sender, args) 
{   
    // Variable to hold the MediaAttribute.     
    var attribute;
    // Get the MediaAttribute named Title
    try     {
        var attributesCollection = sender.Attributes;
        attribute = attributesCollection.getItemByName("Title");
    }
    catch(errorObj)
    {
        alert(errorObj.message);
    }
    // Display the Value of the MediaAttribute
    if(attribute != null)
    {
      alert("The title of the track is: " + attribute.value);
    }
}