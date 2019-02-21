---
title: Custom Task Registration (IIS Transform Manager)
TOCTitle: Custom Task Registration (IIS Transform Manager)
ms:assetid: 4b3135a5-d21f-4210-9801-acedcaad7faa
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff728120(v=VS.90)
ms:contentKeyID: 31469140
ms.date: 06/14/2012
mtps_version: v=VS.90
---

# Custom Task Registration (IIS Transform Manager)

You register custom tasks with IIS Transform Manager by creating a task definition XML file that contains the details of the task.

## Task Definition XML Schema

To make a custom task visible to the default installation of Transform Manager, install the task definition XML file in the following directory:

%ProgramData%\\Microsoft\\IIS\\Transform Manager\\Configuration\\Task Definitions

The custom task assembly and all of its dependencies must be installed in one of the following directories:

%ProgramFiles%\\IIS\\Transform Manager\\

%ProgramFiles(x86)%\\IIS\\Transform Manager\\

The assembly and its dependencies can be stored in a subfolder for clearer organization or for installation by a third party.

For non-default installations of Transform Manager, such as an installation that is integrated with an HPC cluster, or where multiple Transform Manager servers share a watch folder, choose a location for the assemblies that can be accessed by all of the servers that will run the tasks.

### Required Task Elements

A custom task must provide a task definition XML file that includes the following elements:

  - id. A GUID that uniquely identifies the task.

  - name. A friendly name for the task that will be displayed in the user interface.

  - description. A description of the task that will be displayed in the user interface during configuration of tasks within a job template.

  - properties. An optional list of property key names and default values that can be used by a task to read and write values to the Synchronized Multimedia Integration Language (SMIL) job manifest file. The namespace and prefix attributes of the properties element are used by the framework when the properties are written to resource description framework (RDF) metadata in the SMIL manifest. Each task must use a unique namespace and prefix for custom properties that it will read and write in the SMIL manifest. For each property that you want to use in a custom task, add a properties element and set its name and value attributes. Property values are passed as string types. If you mark a property as required, a watch folder cannot be enabled until a value is specified for the required property in the job template that contains the task.

  - inputFolder. An existing folder in a job folder that holds inputs.

  - outputFolder. A folder in a job folder that holds outputs. This folder is created when the task is run.

  - configurationMessages. A collection of configurationMessage elements, which are displayed if there is a configuration requirement or problem.
    
      - configurationMessage. An element that can be used to test the Transform Manager computer configuration. The message content is the value of the element. Attributes are:
        
          - severity. Corresponds to log levels and indicates whether this is an item that must be addressed before a task can run.
        
          - regKeyFound. Specifies a registry key that will be searched for. If the key is found, it will display the message.
        
          - regKeyNotFound. Specifies a registry key that will be searched for. If the key is not found, it will display the message.

  - taskCode. An element that can contain either a type element or an executable element according to the following specifications:
    
      - type. An element that specifies the full .NET Framework assembly type name of the implementation of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) interface that will be loaded into the task engine process. This assembly must be signed with a strong name key. An additional architecture attribute is available for this element to specify which version of the task engine executable to use to run this task. Possible values are x86, x64, or AnyCPU. (These values refer to the compilation architecture used for the .NET Framework assembly.)
    
      - commandLine. Used by tasks that are implemented as a simple program that is not loaded into the task engine. This can be used to integrate existing executable tasks, to run shell commands or PowerShell scripts, or to run custom programs. The program to run and the command-line parameters are set in the commandLine element as shown in the following example.
        
            <commandLine>%ProgramFiles%\IIS\Transform Manager\MyTasks\Task1.exe parameter1 parameter2</commandLine>
        
        A command-line task can include an optional element for success codes, which consists of a comma-separated list of integer values that indicate successful execution of the command. For example, Robocopy uses many return codes other than 0 to indicate the status of a copy operation. The following example shows how to use success codes.
        
        ``` 
        
        <successCodes>0,1,2,3,4,5,6,7</successCodes>
        ```
        
        You can use the following tokens to inject values into command-line parameter values:
        
          - {File Name}   The file name (without the extension) of the original file that was added to the watch folder.
        
          - {File Extension}   The file-name extension of the original file that was added to the watch folder.
        
          - {File Full Name}   The full path of the original file that was added to the watch folder.
        
          - {User Manifest}   The full file name and extension of the manifest that was added to the watch folder by a user.
        
          - {Default Manifest}   The full file name and extension of the manifest that will be generated by Transform Manager.
        
          - {DateTime Local(yyyyMMddhhmmssffff)}   The current local date/time in a format that corresponds to a format string — in this case, year, month, day, hour, minutes, seconds, and milliseconds, with no delimiters. The format string can be modified (for example: yyyy-MM-dd).
        
          - {DateTime Utc}   The current UTC date/time in a format that corresponds to a format string.
        
          - {New Guid}   A new (generated) GUID that is formatted with hyphens, such as D44D00D7-204D-415C-95E6-DD815300B668.
        
          - {Job ID}   The ID of the currently running task.
        
          - {Watch Folder}   The original watch folder path.
        
          - {Input Folder}   The full path of the input folder, which is the job folder path plus the name specified in the inputFolder element.
        
          - {Output Folder}   The full path of the output folder, which is the job folder path plus the name specified in the outputFolder element.

The following example shows the task-definition XML for a custom type to be loaded by the Task Engine. The example includes a type element under the taskCode element.

    <taskDefinition xmlns="http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition#">
      <name>Expression Encoder 4</name>
      <id>A72D7A5D-3022-45f2-89B4-1DDC5457CC12</id>
      <properties namespace="http://schemas.microsoft.com/Expression/Encoder/V4#" prefix="ee">
        <property name="preset" required="true" value="%ProgramData%\Microsoft\IIS\Transform Manager\Configuration\Presets\VC-1 IIS Smooth Streaming - 720p CBR.xml"  helpText="The path to a valid encoding preset file that is exported from Microsoft Expression Encoder 4. A preset is a combination of encoding options and playback options that you can quickly apply to the content to be encoded."/>
        <property name="createSubdirectory" value="false" helpText="Enables output of the encoded Smooth Streams to a folder that uses the naming convention MACHINENAME DATE TIME."/>
        <property name="templateName" required="true" value="Standard" helpText="The name of the Microsoft Silverlight player template (for example, Standard) that is included with the transcoded output. The template specifies a particular skin (a stylized design that includes playback elements) that encases the encoded video."/>
        <property name="templatePath" required="true" value="%ProgramFiles(x86)%\Microsoft Expression\Encoder 4\Templates\en\Standard" helpText="The templateName directory path."/>
      </properties>
      <description xml:lang="en">Invokes Expression Encoder 4 to encode media files to Smooth Streams. Microsoft Expression Encoder 4 must be installed to use this task (H.264/AAC-LC encoding requires Expression Encoder 4 Pro). See http://go.microsoft.com/fwlink/?LinkID=186385.</description>
      <inputFolder></inputFolder>
      <outputFolder>EE4Output</outputFolder>
      <taskCode>
        <type architecture="x86" >Microsoft.Web.Media.TransformManager.EETask, Microsoft.Web.Media.TransformManager.EETask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</type>
      </taskCode>
      <configurationMessages>
        <configurationMessage regKeyNotFound="HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Expression\Encoder\4.0" severity="Error" xml:lang="en">This task requires a licensed version of Microsoft Expression Encoder 4.0.</configurationMessage>
      </configurationMessages>
    </taskDefinition>

The following example shows the task-definition XML for a custom program task that uses the executable element.

    <taskDefinition xmlns="http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition#"
     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
     xsi:schemaLocation="http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition#
           D:\oob\projects\mediapack\XFormFramework\Schemas\TaskDefinition.xsd">
        <id>A72D7A5D-3322-45f2-89B4-1FEC5457CC13</id>
        <name>Test Task</name>
        <description xml:lang="en">Used for validating manifest construction.</description>
        <inputFolder/>
        <outputFolder>Custom</outputFolder>
        <taskCode>
            <commandLine>"C:\Program Files\IIS\Transform Manager\bin\Task1.exe" {UserManifest} {FileName}.*** -log "c:\logfile"</commandLine>
        </taskCode>
    </taskDefinition>

When properties are defined for a task, their default values are put into the iisms:task RDF metadata in the SMIL manifest for the job. Each task in a job will have its own iisms:task object description with a set of custom predicates that use the namespace and prefix defined using the properties element in the task definition. The [IJobMetadata](ijobmetadata-interface-microsoft-web-media-transformmanager.md) interface can be used to read and write these custom predicates in the task's manifest metadata.

The following example shows a SMIL manifest that is created for a job. It contains the properties that are defined for a task in the RDF metadata. The property values are defined in the job template and might override properties specified in the task definition XML file. A task that implements the [ITask](itask-interface-microsoft-web-media-transformmanager.md) interface can update these predicates or add additional ones that are not already defined by using the [SetProperty(IManifestProperty)](ijobmetadata-setproperty-method-microsoft-web-media-transformmanager.md) method.

    <?xml version="1.0" encoding="utf-8"?>
    <smil xmlns="http://www.w3.org/2001/SMIL20/Language">
      <head>
        <metadata>
          <rdf:RDF xmlns:iisms="http://schemas.microsoft.com/iis/media/v4/TM#" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#">
            <iisms:job>
              <iisms:instanceId>20110419141912_A17929ADEFD84519B6C98A794419DFAE</iisms:instanceId>
              <iisms:jobDefinitionId>370CA5AF-92AC-4B5A-97BB-8705E9BD535F</iisms:jobDefinitionId>
              <iisms:jobTemplateId>FA0EC20C-3DC3-4F8A-B224-1EDF16CC2CB5</iisms:jobTemplateId>
              <iisms:instanceFileName>small.wmv</iisms:instanceFileName>
              <iisms:instanceFileIsManifest>False</iisms:instanceFileIsManifest>
              <iisms:priority>3</iisms:priority>
              <iisms:jobStatus>Finished</iisms:jobStatus>
              <iisms:taskIndex>1</iisms:taskIndex>
              <iisms:folder>C:\inetpub\media\Transform Manager\Smooth (VC1)\</iisms:folder>
              <iisms:hasScheduler>
                <iisms:scheduler rdf:about="guid:00000000-0000-0000-0000-000000000000">
                  <iisms:id>00000000-0000-0000-0000-000000000000</iisms:id>
                  <iisms:name>Local Task Scheduler</iisms:name>
                  <iisms:schedulerType>Local</iisms:schedulerType>
                  <iisms:connectionString>localhost</iisms:connectionString>
                </iisms:scheduler>
              </iisms:hasScheduler>
              <iisms:jobName />
              <iisms:logLevel>Information</iisms:logLevel>
            </iisms:job>
            <iisms:task rdf:about="guid:A72D7A5D-3022-45f2-89B4-1DDC5457CC12" xmlns:ee="http://schemas.microsoft.com/Expression/Encoder/V4#">
              <iisms:id>A72D7A5D-3022-45f2-89B4-1DDC5457CC12</iisms:id>
              <iisms:logLevel>Information</iisms:logLevel>
              <iisms:outputFolder>EE4Output</iisms:outputFolder>
              <ee:preset>%ProgramData%\Microsoft\IIS\Transform Manager\Configuration\Presets\VC-1 IIS Smooth Streaming - 720p CBR.xml</ee:preset>
              <ee:createSubdirectory>false</ee:createSubdirectory>
              <ee:templateName>Standard</ee:templateName>
              <ee:templatePath>%ProgramFiles(x86)%\Microsoft Expression\Encoder 4\Templates\en\Standard</ee:templatePath>
              <iisms:taskCode>Microsoft.Web.Media.TransformManager.EETask, Microsoft.Web.Media.TransformManager.EETask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</iisms:taskCode>
              <iisms:hasCommandLine>
                <iisms:commandLine>
                  <iisms:program>C:\Program Files (x86)\IIS\Transform Manager\TaskEngine.exe</iisms:program>
                  <iisms:arguments> /taskIndex 1 /manifest 20110419141912_A17929ADEFD84519B6C98A794419DFAE.smil</iisms:arguments>
                </iisms:commandLine>
              </iisms:hasCommandLine>
              <iisms:name>Expression Encoder 4</iisms:name>
              <iisms:description xml:lang="en">Invokes Expression Encoder 4 to encode media files to Smooth Streams. Microsoft Expression Encoder 4 must be installed to use this task (H.264/AAC-LC encoding requires Expression Encoder 4 Pro). See http://go.microsoft.com/fwlink/?LinkID=186385.</iisms:description>
              <iisms:inputFolder></iisms:inputFolder>
              <iisms:configurationMessages>This task requires a licensed version of Microsoft Expression Encoder 4.0.<configurationMessage regKeyNotFound="HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Expression\Encoder\4.0" severity="Error" xml:lang="en" xmlns="http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition#">This task requires a licensed version of Microsoft Expression Encoder 4.0.</configurationMessage></iisms:configurationMessages>
            </iisms:task>
          </rdf:RDF>
        </metadata>
      </head>
      <body>
        <seq>
          <ref src="C:\inetpub\media\Transform Manager\Smooth (VC1)\WorkQueue\Running\20110419141912_A17929ADEFD84519B6C98A794419DFAE\small.wmv"  />
        </seq>
      </body>
    </smil>

## See Also

### Reference

[Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)

### Other Resources

[Transform Manager Tasks Gallery](http://go.microsoft.com/fwlink/?linkid=191302)

[Transform Manager Knowledge Base](http://go.microsoft.com/fwlink/?linkid=191301)

[IIS Transform Manager (IIS.net)](http://go.microsoft.com/fwlink/?linkid=194958)

