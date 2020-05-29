---
title: Query Publishing Point Statistics
TOCTitle: Query Publishing Point Statistics
ms:assetid: ea6936a4-c399-4bc7-998f-f088fa3fba81
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547070(v=VS.90)
ms:contentKeyID: 37836911
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Query Publishing Point Statistics

The Query Publishing Point Statistics operation retrieves statistics for a specific publishing point.

## Restrictions

The publishing point must be in any state other than Idle.

## Publishing point state after successful operation

This operation does not change the publishing point state.

## Request

The Query Publishing Point Statistics request may be specified as follows:

|Method|URI|
|--- |--- |
|GET|http(s)://<hostname>/<filepath>/statistics|

### URI Parameters

The following table lists URL template segments and parameters.

|Parameter|Description|Example|
|--- |--- |--- |
|hostname|The host name.|Contoso.com|
|filepath|The path of the publishing point file.|media/bunny.isml|

### Request Body

None.

## Response

The response includes an HTTP status code and a response body.

### Status Code

A successful operation returns status code 200 (OK). For information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

The following example shows the format of the response body after the operation has finished. For information of element values and attribute values, see [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

```xml
<?xml version="1.0" encoding="UTF-8"?>
<entry xmlns="http://www.w3.org/2005/Atom">
  <id>http://contoso.com/bunny.isml/statistics</id>
  <author>
    <name />
  </author>
  <updated>2011-06-23T21:39:49.412Z</updated>
  <link href="http://contoso.com/bunny.isml/statistics" rel="self" type="application/atom+xml" title="State" />
  <link href="http://contoso.com/bunny.isml/settings" rel="related" type="application/atom+xml" title="Settings" />
  <content type="application/xml">
    <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
      <Statistics>
        <InputStreams>
          <InputStream id="input-stream-ID-1">
            <State>state</State>
            <ArchiveFileName>archive-file-name.ismv</ArchiveFileName>
            <Sources>
              <Source name="source-name">
                <Properties>
                  <Property name="Source Type">Push|Pull</Property>
                  <Property name="source-IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="sink-name-1" />
              <Sink name="sink-name-2" />
            </Sinks>
            <Tracks>
              <Track id="track-ID">
                <Name>name</Name>
                <EncodedBitRate>encoded-bit-rate</EncodedBitRate>
                <IncomingBitRate>incoming-bit-rate</IncomingBitRate>
                <IncomingFragmentWaitTime>incoming-fragment-wait-time</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>incoming-fragment-time-stamp</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>incoming-fragment-duration</IncomingFragmentDuration>
                <RequestRate>request-rate</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="input-stream-ID-2">
            <!--InputStream Data -->
          </InputStream>
          <InputStream id="input-stream-ID-N">
            <!--InputStream Data -->
          </InputStream>
        </InputStreams>
        <OutputStreams>
          <OutputStream name="output-stream-name-1">
            <LastOutputFragmentTimestamp>last-output-fragment-timestamp-1</LastOutputFragmentTimestamp>
          </OutputStream>
          <OutputStream name="output-stream-name-2">
            <LastOutputFragmentTimestamp>last-output-fragment-timestamp-2</LastOutputFragmentTimestamp>
          </OutputStream>
        </OutputStreams>
      </Statistics>
    </SmoothStreaming>
  </content>
</entry>
```

The following example shows a response body.

```xml
<?xml version="1.0" encoding="UTF-8"?>
<entry xmlns="http://www.w3.org/2005/Atom">
  <id>http://contoso.com/bunny.isml/statistics</id>
  <author>
    <name />
  </author>
  <updated>2011-06-23T21:39:49.412Z</updated>
  <link href="http://contoso.com/bunny.isml/statistics" rel="self" type="application/atom+xml" title="State" />
  <link href="http://contoso.com/bunny.isml/settings" rel="related" type="application/atom+xml" title="Settings" />
  <content type="application/xml">
    <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
      <Statistics>
        <InputStreams>
          <InputStream id="9092-stream2">
            <State>Started</State>
            <ArchiveFileName>9092-stream2.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>1427000</EncodedBitRate>
                <IncomingBitRate>1636359</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.811S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="9092-stream1">
            <State>Started</State>
            <ArchiveFileName>9092-stream1.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>2056000</EncodedBitRate>
                <IncomingBitRate>2350439</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.717S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="9092-stream3">
            <State>Started</State>
            <ArchiveFileName>9092-stream3.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>991000</EncodedBitRate>
                <IncomingBitRate>1122932</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.670S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="9092-stream0">
            <State>Started</State>
            <ArchiveFileName>9092-stream0.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>2962000</EncodedBitRate>
                <IncomingBitRate>3449096</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.764S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>1</RequestRate>
              </Track>
              <Track id="1">
                <Name>audio</Name>
                <EncodedBitRate>160000</EncodedBitRate>
                <IncomingBitRate>161273</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.748S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260063492</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>19969160</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="9092-stream4">
            <State>Started</State>
            <ArchiveFileName>9092-stream4.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>688000</EncodedBitRate>
                <IncomingBitRate>772661</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.717S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="9092-stream5">
            <State>Started</State>
            <ArchiveFileName>9092-stream5.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>477000</EncodedBitRate>
                <IncomingBitRate>540033</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.717S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="9092-stream6">
            <State>Started</State>
            <ArchiveFileName>9092-stream6.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>331000</EncodedBitRate>
                <IncomingBitRate>376287</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.670S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
          <InputStream id="9092-stream7">
            <State>Started</State>
            <ArchiveFileName>9092-stream7.ismv</ArchiveFileName>
            <Sources>
              <Source name="HTTP Push">
                <Properties>
                  <Property name="Source Type">Push</Property>
                  <Property name="Source IP">fe80::e546:4b59:2f44:afed%14</Property>
                </Properties>
              </Source>
            </Sources>
            <Sinks>
              <Sink name="IIS Smooth Streaming" />
              <Sink name="Apple HTTP Live Streaming" />
            </Sinks>
            <Tracks>
              <Track id="2">
                <Name>video</Name>
                <EncodedBitRate>230000</EncodedBitRate>
                <IncomingBitRate>260202</IncomingBitRate>
                <IncomingFragmentWaitTime>PT0.624S</IncomingFragmentWaitTime>
                <IncomingFragmentTimeStamp>260000000</IncomingFragmentTimeStamp>
                <IncomingFragmentDuration>20000000</IncomingFragmentDuration>
                <RequestRate>0</RequestRate>
              </Track>
            </Tracks>
          </InputStream>
        </InputStreams>
        <OutputStreams>
          <OutputStream name="video">
            <LastOutputFragmentTimestamp>220000000</LastOutputFragmentTimestamp>
          </OutputStream>
          <OutputStream name="audio">
            <LastOutputFragmentTimestamp>220125170</LastOutputFragmentTimestamp>
          </OutputStream>
        </OutputStreams>
      </Statistics>
    </SmoothStreaming>
  </content>
</entry>
```

## Authorization

The authenticated user must have read access to the .isml file.
