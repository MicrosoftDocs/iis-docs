---
title: "Troubleshooting Transform Manager Events and Errors"
author: rick-anderson
description: "The Beta release of IIS Transform Manager 1.0 doesn't contain robust event and error reporting. This article provides troubleshooting guidance for the follow..."
ms.date: 04/26/2011
ms.assetid: 43d73528-51dc-4b40-b4d3-7fad417abdc3
msc.legacyurl: /learn/media/transform-manager/troubleshooting-transform-manager-events-and-errors
msc.type: authoredcontent
---
# Troubleshooting Transform Manager Events and Errors

by Dave Nelson

The Beta release of [IIS Transform Manager 1.0](https://go.microsoft.com/?linkid=9771037) doesn't contain robust event and error reporting. This article provides troubleshooting guidance for the following types of issues that you might encounter while using the software:

- [Failed Tasks](troubleshooting-transform-manager-events-and-errors.md#tasks)
- [Configuration Errors](troubleshooting-transform-manager-events-and-errors.md#config)
- [Events](troubleshooting-transform-manager-events-and-errors.md#events)

Check this article often as it will be updated with additional guidance.

<a id="license"></a>

## Licensing

IIS Transform Manager is designed to work with other programs, such as programs that handle audio or video signals. It's solely your responsibility to ensure your compliance with any terms accompanying such other programs, and that you have obtained any necessary rights for your use of the programs.

<a id="tasks"></a>

## Troubleshooting Failed Tasks

When a task fails, an error is always written to the Windows Event Viewer. You can also configure watch folder settings to record the error in job instance logs and job manager logs. For more information about how to record error activity for watch folders, see [Logging and Monitoring Watch Folder Events](https://go.microsoft.com/?linkid=9771038).

The error code for a failed task is a Dword decimal value and is displayed (for example) as: **Last task result: -2147023652**. For troubleshooting purposes, you must convert the Dword decimal value to a Hexadecimal value that reveals the error code. To do this, you can use the conversion tool of your choice or use Windows Calculator:

1. Start Windows Calculator (click **Start** &gt; **All Programs** &gt; **Accessories** &gt; **Calculator**).
2. In Calculator, on the **View** menu, select **Programmer**.
3. Make sure that the **Dec** and **Dword** radio buttons are selected, and then enter the Dword decimal value without the "minus" (-) character (for example, **2147023652**).
4. Press the **+/-** button (the button just above the **/** button) to convert the value to a negative value (for example, **-2147023652**).
5. Select the **Hex** radio button to display the equivalent hexadecimal error code (in our example, the error code is **800704DD**).

You can then search the Internet for the hexadecimal error code to find clues about what might be causing the problem. In our example, the error code 800704DD indicates that the task failed because a user isn't logged-on to the computer. The local task scheduler can't initialize the task if a user with administrative privileges isn't logged-on.

<a id="config"></a>

## Troubleshooting Configuration Errors

Content for this section is coming soon!

<a id="events"></a>

## Troubleshooting Events

Content for this section is coming soon!
