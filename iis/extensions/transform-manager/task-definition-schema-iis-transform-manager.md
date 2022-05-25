---
title: Task Definition Schema (IIS Transform Manager)
description: This article defines elements and attributes of the task definition XML specified in the Task Definition schema.
TOCTitle: Task Definition Schema (IIS Transform Manager)
ms:assetid: 1d1ca5be-c667-4ec2-b475-9470002893cc
ms:mtpsurl: https://msdn.microsoft.com/library/Ff728119(v=VS.90)
ms:contentKeyID: 31469139
ms.date: 06/14/2012
mtps_version: v=VS.90
---

# Task Definition Schema (IIS Transform Manager)

The schema for the task-definition XML file defines the elements and attributes that are used to run custom tasks in the IIS Transform Manager task engine.

## Task Definition Schema

The defining elements and attributes of the task definition XML are specified in the following schema.

```xml
<?xml version="1.0" encoding="UTF-8"?>
<xs:schema xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:xml="http://www.w3.org/XML/1998/namespace"
    xmlns="http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition#"
    targetNamespace="http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition#"
    elementFormDefault="qualified" attributeFormDefault="unqualified" version="0.1">
    <xs:import namespace="http://www.w3.org/XML/1998/namespace" schemaLocation="http://www.w3.org/XML/1998/namespace">
        <xs:annotation>
            <xs:documentation>
        Get access to the xml: attribute groups for xml:lang
        </xs:documentation>
        </xs:annotation>
    </xs:import>
    <xs:element name="taskDefinition">
        <xs:annotation>
            <xs:documentation>IIS Transform Manager Task Definition 1.0</xs:documentation>
        </xs:annotation>
        <xs:complexType>
            <xs:sequence>
                <xs:element name="id" type="GUID">
                    <xs:annotation>
                        <xs:documentation>A GUID for unique identification of this Task</xs:documentation>
                    </xs:annotation>
                </xs:element>
                <xs:element name="name" type="xs:string" minOccurs="0">
                    <xs:annotation>
                        <xs:documentation>The Friendly Name of the Task as shown in the User Interface</xs:documentation>
                    </xs:annotation>
                </xs:element>
                <xs:element name="description" minOccurs="0">
                    <xs:annotation>
                        <xs:documentation>A basic description of the task that may appear in the user
    interface during configuration of Tasks within a Job Template.</xs:documentation>
                    </xs:annotation>
                    <xs:complexType>
                        <xs:simpleContent>
                            <xs:extension base="xs:string">
                                <xs:attribute ref="xml:lang"/>
                            </xs:extension>
                        </xs:simpleContent>
                    </xs:complexType>
                </xs:element>
                <xs:element name="properties" minOccurs="0">
                    <xs:annotation>
                        <xs:documentation>Properties that the Task will be updating in the
    SMIL manifest after it has completed its work</xs:documentation>
                    </xs:annotation>
                    <xs:complexType>
                        <xs:sequence minOccurs="0" maxOccurs="unbounded">
                            <xs:element name="property" minOccurs="0">
                                <xs:complexType>
                                    <xs:attribute name="name" type="xs:string" use="required"/>
                                    <xs:attribute name="value" type="xs:string" use="required"/>
                                </xs:complexType>
                            </xs:element>
                        </xs:sequence>
                        <xs:attribute name="namespace" type="xs:anyURI" use="required"/>
                        <xs:attribute name="prefix" type="xs:string" use="required"/>
                    </xs:complexType>
                </xs:element>
                <xs:element name="logLevel" minOccurs="0">
                    <xs:simpleType>
                        <xs:restriction base="xs:string">
                            <xs:enumeration value="Information"/>
                            <xs:enumeration value="Warning"/>
                            <xs:enumeration value="Error"/>
                            <xs:enumeration value="Verbose"/>
                            <xs:enumeration value="Severe"/>
                            <xs:enumeration value="Off"/>
                        </xs:restriction>
                    </xs:simpleType>
                </xs:element>
                <xs:element name="inputFolder" type="xs:string" minOccurs="0"/>
                <xs:element name="outputFolder" type="xs:string" minOccurs="0"/>
                <xs:element name="taskCode">
                    <xs:complexType>
                        <xs:choice>
                            <xs:element name="type">
                                <xs:annotation>
                                    <xs:documentation>The full class name and assembly name in
    .NET type format including version, culture, and public key.
    This must be used for all Tasks run under the TaskEngine</xs:documentation>
                                </xs:annotation>
                                <xs:complexType>
                                    <xs:simpleContent>
                                        <xs:extension base="xs:string">
                                            <xs:attribute name="architecture">
                                                <xs:annotation>
                                                    <xs:documentation>Default is AnyCPU</xs:documentation>
                                                </xs:annotation>
                                                <xs:simpleType>
                                                    <xs:restriction base="xs:string">
                                                        <xs:enumeration value="x86"/>
                                                        <xs:enumeration value="x64"/>
                                                        <xs:enumeration value="AnyCPU"/>
                                                    </xs:restriction>
                                                </xs:simpleType>
                                            </xs:attribute>
                                        </xs:extension>
                                    </xs:simpleContent>
                                </xs:complexType>
                            </xs:element>
                            <xs:element name="commandLine">
                                <xs:annotation>
                                    <xs:documentation>An executable or batch file and all parameters that can be executed from a command line.
    If paths or arguments have spaces, you must quote the string accordingly.</xs:documentation>
                                </xs:annotation>
                                <xs:complexType>
                                    <xs:sequence>
                                        <xs:element name="successCodes" type="xs:string" minOccurs="0">
                                            <xs:annotation>
                                                <xs:documentation>A comma-separated list of codes other than 0 that indicate success</xs:documentation>
                                            </xs:annotation>
                                        </xs:element>
                                    </xs:sequence>
                                </xs:complexType>
                            </xs:element>
                        </xs:choice>
                    </xs:complexType>
                </xs:element>
            </xs:sequence>
        </xs:complexType>
    </xs:element>
    <xs:simpleType name="GUID">
        <xs:annotation>
            <xs:documentation xml:lang="en">
                The representation of a GUID, generally the id of an element.
        </xs:documentation>
        </xs:annotation>
        <xs:restriction base="xs:string">
            <xs:pattern value="[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}"/>
        </xs:restriction>
    </xs:simpleType>
</xs:schema>
```

## See Also

### Reference

[Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)

[IJobMetadata](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

### Concepts

[Custom Task Registration (IIS Transform Manager)](custom-task-registration-iis-transform-manager.md)
