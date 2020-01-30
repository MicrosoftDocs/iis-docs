---
title: IIS Smooth Streaming Server Manifest (On-Demand)
TOCTitle: On-Demand Server Manifest
ms:assetid: 9fafe692-87d3-41d9-a882-76e266f74bf6
ms:mtpsurl: https://msdn.microsoft.com/library/Ee230817(v=VS.90)
ms:contentKeyID: 22049445
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand)

For on-demand scenarios, the server manifest serves three key roles. Those roles are:

  - Specify the group of media files that comprise the presentation.

  - Specify heuristic parameters, such as bit rate and fragment quality index, for each track.

  - Abstract the layout of the tracks into files on disk for consumption by the client.

In addition to enabling consumption of media as a single cohesive presentation, the abstraction provided by the server manifest allows for a variety of management tasks to be performed without altering the underlying media files. Those tasks include:

  - Adding additional language tracks

  - Adding commentary tracks

  - Adding alternate video angles

  - Creating previews/highlights

  - Creating a limited-quality version of the presentation for non-subscription users

## Conceptual Organization

Each stream comprises one or more associated media files and a client manifest, which are tied together using a metadata file called the disk manifest. The disk manifest specifies the different quality levels (aggregate bit rates) available to stream content and the tracks that each quality level comprises.

