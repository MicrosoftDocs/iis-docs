#pragma AUTORECOVER
#pragma namespace("\\\\.\\Root\\WebAdministration")
[            
    dynamic : ToInstance ToSubClass,
    provider("WebAdministrationProvider") : ToInstance ToSubClass,
    Description("imageCopyright Section") : ToSubClass,
    Locale(1033) : ToInstance ToSubClass,
    factory_clsid("{901a70b2-0f7a-44ea-b97b-1e9299dec8ca}"),
    section_path("system.webServer/imageCopyright"),
    SupportsUpdate
]
 
class imageCopyright : ConfigurationSection
{      
    [
        read: ToSubClass ToInstance,
        write: ToSubClass ToInstance,
        DefaultValue("False"): ToSubClass ToInstance,
        Description("To be written"): ToSubClass ToInstance
    ]
    boolean Enabled;
  
    [
        read: ToSubClass ToInstance,
        write: ToSubClass ToInstance,
        DefaultValue("Your Copyright Message"): ToSubClass ToInstance,
        Description("Copyright Message"): ToSubClass ToInstance
    ]
    string Message;

    [
        read: ToSubClass ToInstance,
        write: ToSubClass ToInstance,
        DefaultValue("Yellow"): ToSubClass ToInstance,
        Description("Color of Copyright Message"): ToSubClass ToInstance
    ]
    string Color;
};