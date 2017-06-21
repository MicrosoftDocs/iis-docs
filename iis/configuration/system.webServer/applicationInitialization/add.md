Adding Initialization Page <add> <add>
====================
<a id="001"></a>
## Overview

The `<add>` element under the `<applicationInitialization>` element specifies the application to be initialized upon application restart. To perform the application initialization process, IIS sends a fake request to the application to prompt the initialization. Multiple application URLs can be specified by using multiple <add>tags. These applications are not served to a requester. The page specified by the remapManagedRequestsTo attribute in the <code>&lt;applicationInitialization&gt;</code> element will be served to the customer.<h2 id="002">Compatibility</h2><table class="data-table" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>Version</th>
<th>Notes</th>
</tr>
<tr>
<th>IIS 10.0</th>
<td>The <code>&lt;add&gt;</code> element was not modified in IIS 10.0.</td></tr>
<tr><th>IIS 8.5</th>
<td>The <code>&lt;add&gt;</code> element was not modified in IIS 8.5.</td></tr>
<tr>
<th>IIS 8.0</th>
<td>The <code>&lt;add&gt;</code> element was introduced in IIS 8.0.</td></tr>
<tr>
<th>IIS 7.5</th>
<td>N/A</td></tr>
<tr>
<th>IIS 7.0</th>
<td>N/A</td></tr>
<tr>
<th>IIS 6.0</th>
<td>N/A</td></tr></tbody></table><h2 id="003">Setup</h2><p>To support application initialization on your Web server, you must install the Application Initialization role or feature.</p>
<h3>Windows Server 2012 or Windows Server 2012 R2</h3>
<ol>
<li>On the taskbar, click <strong>Server Manager</strong>.</li> 
<li>In <strong>Server Manager</strong>, click the <strong>Manage</strong> menu, and then click <strong>Add Roles and Features</strong>.</li> 
<li>In the <strong>Add Roles and Features</strong> wizard, click <strong>Next</strong>. Select the installation type and click <strong>Next</strong>. Select the destination server and click <strong>Next</strong>.</li> 
<li>On the <strong>Server Roles</strong> page, expand <strong>Web Server (IIS)</strong>, expand <strong>Web Server</strong>, expand <strong>Application Development</strong>, and then select <strong>Application Initialization</strong>. Click <strong>Next</strong>.<br><a href="add/_static/image1.png"><img alt="" src="add/_static/image2.png"></a>.</li> 
<li>On the <strong>Select Features</strong> page, click <strong>Next</strong>.</li> 
<li>On the <strong>Confirm installation selections</strong> page, click <strong>Install</strong>.</li> 
<li>On the <strong>Results</strong> page, click <strong>Close</strong>. </li></ol>
<h3>Windows 8 or Windows 8.1</h3>
<ol>
<li>On the <strong>Start</strong> screen, move the pointer all the way to the lower left corner, right-click the <strong>Start</strong> button, and then click <strong>Control Panel</strong>.</li> 
<li>In <strong>Control Panel</strong>, click <strong>Programs and Features</strong>, and then click <strong>Turn Windows features on or off</strong>.</li> 
<li>Expand <strong>Internet Information Services</strong>, expand <strong>World Wide Web Services</strong>, expand <strong>Application Development Features</strong>, and then select <strong>Application Initialization</strong>.<br><a href="add/_static/image3.png"><img alt="" src="add/_static/image4.png"></a></li> 
<li>Click <strong>OK</strong>.</li>
<li>Click <strong>Close</strong>.</li></ol><h2 id="004">How To</h2><h3>How to configure application initialization</h3>
<ol>
<li>Open <strong>Internet Information Services (IIS) Manager</strong>: 
<ul>
<li>If you are using Windows Server 2012 or later: 
<ul>
<li>On the taskbar, click <strong>Server Manager</strong>, click <strong>Tools</strong>, and then click <strong>Internet Information Services (IIS) Manager</strong>. </li></ul></li>
<li>If you are using Windows 8 or later: 
<ul>
<li>Hold down the <strong>Windows</strong> key, press the letter <strong>X</strong>, and then click <strong>Control Panel</strong>.</li> 
<li>Click <strong>Administrative Tools</strong>, and then double-click <strong>Internet Information Services (IIS) Manager</strong>. </li></ul></li></ul></li> 
<li>In the <strong>Connections</strong> pane, select the server, or expand the server, expand <strong>Sites</strong>, and then select a site.</li> 
<li>In the <strong>Home</strong> pane, double-click the <strong>Configuration Editor</strong> feature.</li> 
<li>If you selected a site, select <strong>&lt;site name&gt; Web.config</strong> in the <strong>From</strong> text box, and then select <strong>system.webServer/applicationInitialization</strong> in the <strong>Section</strong> text box.</li> 
<li>If you selected the server, select <strong>system.webServer/applicationInitialization</strong> in the <strong>Section</strong> text box.<br><br><a href="add/_static/image5.png"><img alt="" src="add/_static/image6.png"></a></li> 
<li>To specify the name of a static file to be returned during initialization, set <strong>remapManagedRequestsTo</strong> to the name of the file.</li> 
<li>If you do not want to load managed modules, set <strong>skipManagedModules</strong> to <strong>true</strong>.</li> 
<li>To specify that the initialization process is initiated automatically whenever an application restart occurs, set <strong>doAppInitAfterRestart</strong> to <strong>true</strong>.</li> 
<li>To specify the application or applications to be initialized upon application restart, click the <strong>(Collection)</strong> line and then click the ellipsis.</li> 
<li>In the Collection Editor, to add an application to be initialized, click <strong>Add</strong>, click <strong>hostName</strong>, and then set hostName to the name of the host. Click <strong>initializationPage</strong> and set it to a URL for the application. Close the dialog box.<br><br><a href="add/_static/image7.png"><img alt="" src="add/_static/image8.png"></a></li> 
<li>Click <strong>Apply</strong> in the <strong>Actions</strong> pane. </li></ol><h2 id="005">Configuration</h2><p>The <code>&lt;add&gt;</code> element of the <code>&lt;applicationInitialization&gt;</code> element is configured at the server, site, or application level.</p>
<h3>Attributes</h3>
<table class="data-table" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>Attribute</th>
<th>Description</th></tr>
<tr>
<th><code>initializationPage</code></th>
<td>Required string attribute.<br><br>Specifies the URL of an application to be initialized upon application restart. <br><br>The default value is <code>""</code>.</td></tr>
<tr>
<th><code>hostName</code></th>
<td>Optional string attribute.<br><br>A host name to be used with the application URL provided in the initializationPage attribute.<br><br>The default value is <code>""</code>.</td></tr></tbody></table>
<h3>Child Elements</h3>
<p>None.</p>
<h3>Configuration Sample</h3><p>The following sample shows configuration of application initialization.</p><pre class="prettyprint lang-xml">&lt;system.webServer&gt;
   &lt;applicationInitialization
      doAppInitAfterRestart="true"
      skipManagedModules="true"
      remapManagedRequestsTo="filename.htm"/&gt;
      &lt;add initializationPage="/default.aspx" hostName="myhost"/&gt;
   &lt;/applicationInitialization&gt;
&lt;/system.webServer&gt;
</pre><h2 id="006">Sample Code</h2><p>The following examples configure <strong>&lt;applicationInitialization&gt;</strong> for a site.</p>
<h3>AppCmd.exe</h3><pre id="AppCmdSample">appcmd.exe set config "Default Web Site" -section:system.webServer/applicationInitialization /remapManagedRequestsTo:"HelloJoe.htm" /skipManagedModules:"True" /doAppInitAfterRestart:"True"  /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/applicationInitialization /+"[initializationPage='JoesSite.htm',hostName='JoesHost']" /commit:apphost
  
</pre>
<p><strong>Note</strong>: You must be sure to set the <strong>commit</strong> parameter to <code>apphost</code> when using AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.</p>
<h3>C#</h3><pre id="CSharpSample" class="prettyprint lang-cs">using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            
            ConfigurationSection applicationInitializationSection = config.GetSection("system.webServer/applicationInitialization", "Default Web Site");
            applicationInitializationSection["remapManagedRequestsTo"] = @"HelloJoe.htm";
            applicationInitializationSection["skipManagedModules"] = true;
            applicationInitializationSection["doAppInitAfterRestart"] = true;
            
            ConfigurationElementCollection applicationInitializationCollection = applicationInitializationSection.GetCollection();
            
            ConfigurationElement addElement = applicationInitializationCollection.CreateElement("add");
            addElement["initializationPage"] = @"JoesSite.htm";
            addElement["hostName"] = @"JoesHost";
            applicationInitializationCollection.Add(addElement);
            
            serverManager.CommitChanges();
        }
    }
}

</pre>
<h3>VB.NET</h3><pre id="VbNetSample" class="prettyprint lang-vb">Imports System
Imports System.Text
Imports Microsoft.Web.Administration
Module Sample
     
     Sub Main()
         Dim serverManager As ServerManager = New ServerManager
         Dim config As Configuration = serverManager.GetApplicationHostConfiguration
         Dim applicationInitializationSection As ConfigurationSection = config.GetSection("system.webServer/applicationInitialization", "Default Web Site")
         applicationInitializationSection("remapManagedRequestsTo") = "HelloJoe.htm"
         applicationInitializationSection("skipManagedModules") = true
         applicationInitializationSection("doAppInitAfterRestart") = true
         Dim applicationInitializationCollection As ConfigurationElementCollection = applicationInitializationSection.GetCollection
         Dim addElement As ConfigurationElement = applicationInitializationCollection.CreateElement("add")
         addElement("initializationPage") = "JoesSite.htm"
         addElement("hostName") = "JoesHost"
         applicationInitializationCollection.Add(addElement)
         serverManager.CommitChanges
     End Sub
 End Module

</pre>
<h3>JavaScript</h3><pre id="JavaScriptSample" class="prettyprint lang-js">var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var applicationInitializationSection = adminManager.GetAdminSection("system.webServer/applicationInitialization", "MACHINE/WEBROOT/APPHOST/Default Web Site");
applicationInitializationSection.Properties.Item("remapManagedRequestsTo").Value = "HelloJoe.htm";
applicationInitializationSection.Properties.Item("skipManagedModules").Value = true;
applicationInitializationSection.Properties.Item("doAppInitAfterRestart").Value = true;

var applicationInitializationCollection = applicationInitializationSection.Collection;

var addElement = applicationInitializationCollection.CreateNewElement("add");
addElement.Properties.Item("initializationPage").Value = "JoesSite.htm";
addElement.Properties.Item("hostName").Value = "JoesHost";
applicationInitializationCollection.AddElement(addElement);

adminManager.CommitChanges();

</pre><br>
<h3>VBScript</h3><pre id="VbScriptSample" class="prettyprint lang-vb">Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set applicationInitializationSection = adminManager.GetAdminSection("system.webServer/applicationInitialization", "MACHINE/WEBROOT/APPHOST/Default Web Site")
applicationInitializationSection.Properties.Item("remapManagedRequestsTo").Value = "HelloJoe.htm"
applicationInitializationSection.Properties.Item("skipManagedModules").Value = true
applicationInitializationSection.Properties.Item("doAppInitAfterRestart").Value = true

Set applicationInitializationCollection = applicationInitializationSection.Collection

Set addElement = applicationInitializationCollection.CreateNewElement("add")
addElement.Properties.Item("initializationPage").Value = "JoesSite.htm"
addElement.Properties.Item("hostName").Value = "JoesHost"
applicationInitializationCollection.AddElement(addElement)

adminManager.CommitChanges()
</pre>
<h3>PowerShell</h3><pre id="PowerShellSample" class="prettyprint lang-ps">Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "remapManagedRequestsTo" -value "HelloJoe.htm"
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "skipManagedModules" -value "True"
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "doAppInitAfterRestart" -value "True"

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "." -value @{initializationPage='JoesSite.htm';hostName='JoesHost'}

</pre></add>