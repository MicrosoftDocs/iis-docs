//
// Snippet from IIS 6.0 MBSchema.xml
//
<Property InternalName="AuthFlags" ID="6000" Type="DWORD" UserType="IIS_MD_UT_FILE" Attributes="INHERIT" >
    <Flag   InternalName="AuthAnonymous"   Value="1"   ID="6218"   />
    <Flag   InternalName="AuthBasic"             Value="2"   ID="6219"  />
    <Flag   InternalName="AuthNTLM"            Value="4"   ID="6220"  />
    <Flag   InternalName="AuthMD5"              Value="16"  ID="6221"  />
    <Flag   InternalName="AuthPassport"        Value="64"  ID="6299"  />
</Property>

//
// Snippet from IIS 7.0 IIS_Schema.xml
//
<sectionSchema name="system.webServer/security/authentication/basicAuthentication">
  <attribute name="enabled" type="bool" defaultValue="false" />
  <attribute name="realm" type="string" />
  <attribute name="defaultLogonDomain" type="string" />
  <attribute name="logonMethod" type="enum" defaultValue="ClearText">
    <enum name="Interactive" value="0" />
    <enum name="Batch" value="1" />
    <enum name="Network" value="2" />
    <enum name="ClearText" value="3" />
  </attribute>
</sectionSchema>