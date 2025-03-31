<configProtectedData defaultProvider="RsaProtectedConfigurationProvider">
    <providers>
        <add name="RsaProtectedConfigurationProvider" type="System.Configuration.RsaProtectedConfigurationProvider,System.Configuration, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" description="Uses RsaCryptoServiceProvider to encrypt and decrypt" keyContainerName="NetFrameworkConfigurationKey" cspProviderName="" useMachineContainer="true" useOAEP="false"/>

        <add name="DataProtectionConfigurationProvider" type="System.Configuration.DpapiProtectedConfigurationProvider,System.Configuration, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" description="Uses CryptProtectData and CryptUnProtectData Windows APIs to encrypt and decrypt" useMachineProtection="true" keyEntropy=""/>

        <add name="Rsa_WAS" type="System.Configuration.RsaProtectedConfigurationProvider,System.Configuration, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" description="RsaKeyForWAS" keyContainerName="iisWasKey" cspProviderName="" useMachineContainer="true" useOAEP="false" />
    </providers>
</configProtectedData>
