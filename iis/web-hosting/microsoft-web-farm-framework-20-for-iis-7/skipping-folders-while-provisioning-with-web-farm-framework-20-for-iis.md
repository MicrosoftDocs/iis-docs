---
title: "Skipping Folders while Provisioning with Web Farm Framework 2.0 for IIS 7"
author: rick-anderson
description: "Web Farm Framework enables you to control the provisioning of selected folders using its default synchronization provider. The default behavior of the provid..."
ms.date: 02/02/2011
ms.assetid: 5934bf1f-010f-420a-ac20-805a6342d593
msc.legacyurl: /learn/web-hosting/microsoft-web-farm-framework-20-for-iis-7/skipping-folders-while-provisioning-with-web-farm-framework-20-for-iis
msc.type: authoredcontent
---
# Skipping Folders while Provisioning with Web Farm Framework 2.0 for IIS 7

by Keith Newman

Web Farm Framework enables you to control the provisioning of selected folders using its default synchronization provider. The default behavior of the provider is to provision all the files and directories from the primary server to all secondary servers. However, by editing **ApplicationHost.config** file, you can cause the provider to skip folders that you select.

To see how this works, assume that you have Folder1 and Folder2 under Default Web Site and you want to sync only Folder2 and exclude Folder1.

## To exclude folders from provisioning

1. On the controller machine, open the **ApplicationHost.config** file. This is under the directory

    [!code-console[Main](skipping-folders-while-provisioning-with-web-farm-framework-20-for-iis/samples/sample1.cmd)]
2. Under the **applicationProvision** element, add an entry to skip the directives as follows

   [!code-xml[Main](skipping-folders-while-provisioning-with-web-farm-framework-20-for-iis/samples/sample2.xml?highlight=7-10)]

3. When you save the changes, Web Farms Framework immediately picks up the changes from the configuration file and does application provisioning.
4. Verify that the secondary servers provisioned only Folder2, and Folder1 was excluded.
5. You can also skip binding as follows:

    [!code-xml[Main](skipping-folders-while-provisioning-with-web-farm-framework-20-for-iis/samples/sample3.xml)]
6. Alternatively, you can sync a specific directory using the **msdeploy** command directly for each secondary server as follows:

    [!code-console[Main](skipping-folders-while-provisioning-with-web-farm-framework-20-for-iis/samples/sample4.cmd)]