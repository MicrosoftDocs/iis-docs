PS IIS:\Sites\DemoSite\DemoApp> get-content (((get-item .).physicalPath).ToString() + "\web.config")
<?xml version="1.0" encoding="UTF-8"?>
<configuration>
    <system.webServer>
         <handlers>
            <remove name="PageHandlerFactory-ISAPI-2.0-64" />
            <remove name="PageHandlerFactory-ISAPI-2.0" />
            <remove name="PageHandlerFactory-Integrated" />
            <add name="PageHandlerFactory-Integrated" path="*.mspx" verb="GET,HEAD,POST,DEBUG" type="System.Web.UI.PageHandlerFactory" preCondition="integratedMode" />
            <add name="PageHandlerFactory-ISAPI-2.0" path="*.mspx" verb="GET,HEAD,POST,DEBUG" modules="IsapiModule" scriptProcessor="%windir%\Microsoft.NET\Framework\v2.0.50727\aspnet_isapi.dll" preCondition="classicMode,runtimeVersionv2.0,bitness32" responseBufferLimit="0" />
            <add name="PageHandlerFactory-ISAPI-2.0-64" path="*.mspx" verb="GET,HEAD,POST,DEBUG" modules="IsapiModule" scriptProcessor="%windir%\Microsoft.NET\Framework64\v2.0.50727\aspnet_isapi.dll" preCondition="classicMode,runtimeVersionv2.0,bitness64" responseBufferLimit="0" />
        </handlers>
    </system.webServer>
</configuration>