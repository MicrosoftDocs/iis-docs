---
title: SmoothStreaming Schema Reference
TOCTitle: SmoothStreaming Schema Reference
ms:assetid: 6df06a17-bef6-4a2b-b406-a5d3d39f9feb
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547046(v=VS.90)
ms:contentKeyID: 37836887
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# SmoothStreaming Schema Reference

The XML elements that form the request body and response body of Smooth Streaming REST Services publishing point management are included in the SmoothStreaming schema. The schema is defined in the SmoothStreaming.xsd file and includes the following elements:

## 

[SmoothStreaming Element](smoothstreaming-element.md)

    [Settings Element](settings-element.md)

        [Title Element](title-element.md)

        [SourceType Element](sourcetype-element.md)

        [EstimatedDuration Element](estimatedduration-element.md)

        [AutoStart Element](autostart-element.md)

        [AutoRestartOnEncoderReconnect Element](autorestartonencoderreconnect-element.md)

        [LookAheadChunks Element](lookaheadchunks-element.md)

        [Archive Element](archive-element.md)

            [SegmentLength Element](segmentlength-element.md)

            [Path Element](path-element.md)

        [ClientConnections Element](clientconnections-element.md)

            [WindowLength Element](windowlength-element.md)

            [LiveCacheLength Element](livecachelength-element.md)

            [ClientManifestVersion Element](clientmanifestversion-element.md)

        [ServerConnections Element](serverconnections-element.md)

            [SendEndOfStreamOnStop Element](sendendofstreamonstop-element.md)

        [PullFrom Element](pullfrom-element.md) | [PushTo Element](pushto-element.md)

            [PublishingPoints Element](publishingpoints-element.md)

                [PublishingPoint Element](publishingpoint-element.md)

        [Modules Element](modules-element.md)

            [Module Element](module-element.md)

    [State Element (SmoothStreaming)](state-element-smoothstreaming.md)

        [Value Element](value-element.md)

        [LastError Element](lasterror-element.md)

    [Statistics Element](statistics-element.md)

        [InputStreams Element](inputstreams-element.md)

            [InputStream Element](inputstream-element.md)

                [State Element (InputStream)](state-element-inputstream.md)

                [ArchiveFileName Element](archivefilename-element.md)

                [Sources Element (Sources)](sources-element-sources.md)

                    [Source Element (Sources)](source-element-sources.md)

                        [Properties Element](properties-element.md)

                            [Property Element](property-element.md)

                [Sinks Element](sinks-element.md)

                    [Sink Element](sink-element.md)

                        [Properties Element](properties-element.md)

                            [Property Element](property-element.md)

                [Tracks Element](tracks-element.md)

                    [Track Element](track-element.md)

                        [Name Element](name-element.md)

                        [EncodedBitRate Element](encodedbitrate-element.md)

                        [IncomingBitRate Element](incomingbitrate-element.md)

                        [IncomingFragmentWaitTime Element](incomingfragmentwaittime-element.md)

                        [IncomingFragmentTimeStamp Element](incomingfragmenttimestamp-element.md)

                        [IncomingFragmentDuration Element](incomingfragmentduration-element.md)

                        [RequestRate Element](requestrate-element.md)

        [OutputStreams Element](outputstreams-element.md)

            [OuputStream Element](ouputstream-element.md)

                [LastOutputFragmentTimestamp Element](lastoutputfragmenttimestamp-element.md)

    [Error Element](error-element.md)

        [ErrorCode Element](errorcode-element.md)

        [ErrorMessage Element](errormessage-element.md)

        [InternalError Element](internalerror-element.md)

