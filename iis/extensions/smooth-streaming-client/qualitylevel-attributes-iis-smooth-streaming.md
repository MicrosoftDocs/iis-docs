---
title: QualityLevel, Attributes (IIS Smooth Streaming)
TOCTitle: QualityLevel, Attributes (IIS Smooth Streaming)
ms:assetid: c33074d3-f806-450d-98e9-ef307c532d26
ms:mtpsurl: https://msdn.microsoft.com/library/Ff728116(v=VS.90)
ms:contentKeyID: 31469136
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# QualityLevel, Attributes (IIS Smooth Streaming)

The QualityLevel element of the client manifest specifies metadata for a video or audio track at a specified quality level.

## QualityLevel Element and Attributes

The QualityLevel element must be present for video and audio tracks, even if there is only a single quality level available for the track type. The parent StreamIndex element can contain as many QualityLevel elements as required to support various bandwidth streams.

The QualityLevel element supports the following attributes:

  - Index. \[Required\] Specifies an index for this QualityLevel element.

  - Bitrate. \[Required\] Specifies the bitrate (only for this track) for this QualityLevel, in bits-per-second (bps).

  - Scheme. \[Optional\] Specifies a four-character code for the protection scheme used. If omitted, the default value is "piff".

  - SchemeVersion. \[Optional\] Specifies a major and minor version for the protection scheme used. If omitted, the default value is determined by the MajorVersion and MinorVersion values of the client manifest, as shown in the following table:
    
    |MajorVersion|MinorVersion|SchemeVersion|
    |--- |--- |--- |
    |1|Any|1.0|
    |2|0|1.0|
    |2|1|1.1|

<!-- end list -->

  - HardwareProfile: \[Optional\] Deprecated.

  - {Namespace}\_{CustomAttribute}: \[Optional\] Deprecated.

Depending on the value of the Type attribute of the parent StreamIndex element, the following additional QualityLevel attributes might apply:

|QualityLevel attribute|StreamIndex Type="video"|StreamIndex Type="audio"|
|--- |--- |--- |
|Index|Required|Required|
|Bitrate|Required|Required|
|BufferTime|Optional|Optional|
|NominalBitrate|Optional|Optional|
|HardwareProfile|Optional|Optional|
|CodecPrivateData|Required|Required|
|MaxHeight|Required|Ignored|
|MaxWidth|Required|Ignored|
|SamplingRate|Ignored|Required|
|Channels|Ignored|Required|
|BitsPerSample|Ignored|Required|
|PacketSize|Ignored|Required|
|AudioTag|Ignored|Required|
|FourCC|Required|Optional|
|NALUnitLengthField|Optional|Ignored|

### Additional Attributes

If the Type of the track is video, the following additional attributes are supported:

  - BufferTime. \[Optional\] Specifies the number of milliseconds that the client should buffer data before playback. Depending on the codec, this value will correspond to different values in the reference decoder buffer model:
    
      - VC-1. BufferTime corresponds to BUFFER\_SIZE divided by the bitrate of the stream.
    
      - H.264. BufferTime corresponds to the value, in kilohertz, of the result of calculating (initial\_cpb\_removal\_delay + initial\_cpb\_removal\_delay\_offset) / 90.

  - NominalBitrate. \[Optional\] Specifies the maximum bitrate for this quality level in bits-per-second (bps) over any window of one second.

  - CodecPrivateData. \[Required\] Specifies the codec private data property of this video stream:
    
      - For VC-1, the CodecPrivateData field is the data appended to the BITMAPINFOHEADER value, encoded in base16.
    
      - For H.264 MPEG4 Part15, the CodecPrivateData field must contain SPS and PPS, in the following form, base16-encoded: \[start code\]\[SPS\]\[start code\]\[PPS\], where \[start code\] is the following four bytes: 0x00, 0x00, 0x00, 0x01.

  - MaxHeight. \[Optional\] Specifies the maximum coded height in pixels for this quality level. Defaults to the corresponding value in the parent StreamIndex element.

  - MaxWidth. \[Optional\] Specifies the maximum width in pixels for this quality level. Defaults to the corresponding value in the parent StreamIndex element.

  - FourCC. \[Required\] Specifies the FourCC code for the video codec.

  - NALUnitLengthField. \[Optional\] Specifies the number of bytes used for the NAL. The default is 4 bytes. This applies only to H.264 MPEG 4 Part 15 video.

When the Type of the StreamIndex element is video, the FourCC attribute indicates the video codec. Supported values are:

  - WVC1, which represents the VC-1 codec

  - AVC1, which represents H.264 MPEG 4 Part 15. Other synonyms are X264, DAVC, and H264.

  - AVCB, which represents H.264 MPEG 4 Annex B

Note that X264, DAVC, H264 values should not be used; instead, use AVC1 as noted in the second bullet point above.

If the Type of track is audio the following additional attributes are required:

  - SamplingRate: \[Required\] Specifies the audio sampling rate in hertz (Hz).

  - Channels: \[Required\] Specifies the number of audio channels in the track—for example, 2 for stereo.

  - BitsPerSample: \[Required\] Specifies the size of each audio sample, in bits.

  - PacketSize: \[Required\] Specifies the block alignment, in bytes.

  - AudioTag: \[Required\] Specifies the audio format type.

  - CodecPrivateData: \[Required\] Specifies the extra codec-specific information appended to the end of the [WAVEFORMATEX](https://go.microsoft.com/fwlink/?linkid=204792) structure. This value is base16 encoded.

  - FourCC: \[Optional\] Specifies the FourCC code for the audio codec.

The FourCC attribute indicates the audio codec used. Supported values are:

  - WMA, which represents WMA with no version-specific information. For more information, see [WAVEFORMATEX](https://go.microsoft.com/fwlink/?linkid=204792) structure.

  - WMAP, which represents WMA Pro.

  - WMA2, which represents Windows Media 9.1-compatible WMA audio.

  - AAC, which represents AAC (ISO AAC coding).

  - AACL, which represents AAC-LC (AAC low complexity).

  - AACH, which represents AAC-HE.

  - AACP, which represents AAC+.

For presentations that use content protection, the following defaults are in effect, which correspond to fields in the track-encryption specification:

  - The default AlgorithmID value is 1 (AES-CTR).

  - The default IVSize value is 8.

  - The default KID value is determined by the information in a protection-system-specific header.

## See Also

### Concepts

[Stream Type, Subtype, Other Attributes (IIS Smooth Streaming)](stream-type-subtype-other-attributes.md)
