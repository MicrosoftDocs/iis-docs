---
title: "Testing the Deployment | Microsoft Docs"
author: rick-anderson
description: "Before deployment into production, tests must be executed for each server component, in addition to testing the Windows PE media to assure proper operation...."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/testing-the-deployment
msc.type: authoredcontent
---
Testing the Deployment
====================
by Walter Oliver

## Prerequisites

Before deployment into production, tests must be executed for each server component, in addition to testing the Windows PE media to assure proper operation. The results of this testing should be documented in a report.

The high-level steps in the deployment testing phase are:

- **Perform lab tests and pilot deployments**. Before deploying into the production environment, verify the deployment process in test labs and by conducting pilot deployments. These tests and pilot deployments help identify any problems before deploying in the production network.
- **Prepare deployment teams**. After the lab tests and pilot deployments are complete, prepare the deployment teams. The deployment teams must know what was learned during the lab tests and pilot deployments.

## Lab and Pilot Deployments

During the lab tests and pilot deployments, complete the following tasks:

1. Test the Windows Deployment Services process on target computers. Focus on finalizing the deployment process in labs and pilot deployments just prior to deployment in the production environment.
2. Document common deployment problems and resolutions. While the team is going through the stages of testing and pilot deployments, team members should document any deployment problems that they encounter, along with their resolution.
3. Document troubleshooting procedures and diagnostic tools. Document any troubleshooting procedures and diagnostic tools used during lab testing and pilot deployments.
4. Revise deployment plans. After completing the lab tests and pilot deployments, revise the deployment plans to reflect any issues and resolutions that were discovered. Ensure that these revised plans are provided to the deployment teams, along with the deployment problems and resolutions, troubleshooting procedures, and diagnostic tools.

## Deployment Teams

To prepare the deployment teams, complete the following tasks:

1. Notify all Deployment team members and System Administrators of the deployment start date so that they can be ready to provide support.
2. If needed, notify users of plans and how they may be affected. Provide support contact information.
3. Identify the target group. Provide the deployment teams with a list of the computers to be included in the deployment. Ensure that the appropriate sequencing of groups of computers is provided when required.
4. Identify computer configurations that were successfully deployed during lab and pilot tests. Ensure that the deployment teams know the configurations that should work without difficulty based on lessons learned in the lab tests and pilot deployments.
5. Identify computer configurations that failed during lab and pilot testing. Ensure that the deployment teams know the computer configurations that resulted in problems so they can monitor those configurations more closely.
6. Identify any troubleshooting procedures and diagnostic tools. Provide the deployment teams with documentation that describes troubleshooting procedures and diagnostic tools used during the lab testing and pilot deployments.