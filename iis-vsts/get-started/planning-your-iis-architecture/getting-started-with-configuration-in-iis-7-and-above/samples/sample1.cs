//
// Snippet from IIS 6.0 Metabase.xml
//
<IIsWebService    Location ="/LM/W3SVC"
      ... many lines here ...
    AuthFlags="AuthAnonymous"
      ... many lines here ...
    >
</IIsWebService>
<IIsWebDirectory    Location ="/LM/W3SVC/1/ROOT/aspnet_webadmin/2_0_41016"
    AuthFlags="AuthAnonymous | AuthNTLM"
    >
</IIsWebDirectory>
<IIsWebVirtualDir    Location ="/LM/W3SVC/Info/Templates/Public Web Site/Root"
        AuthFlags="AuthAnonymous"
    >
</IIsWebVirtualDir>

//
// Snippet from IIS 7.0 applicationHost.config
//
<anonymousAuthentication enabled="true"  userName="…"  password="…" />
<basicAuthentication enabled="false" />
<clientCertificateMappingAuthentication enabled="false" />
<windowsAuthentication enabled="true" >
    <providers>
        <add value="Negotiate" />
        <add value="NTLM" />
    </providers>
</windowsAuthentication>