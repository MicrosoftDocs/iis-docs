using System;
using System.Net;
using System.Management;
using System.Management.Automation;
using System.ComponentModel;
using System.Security;
 
namespace Microsoft.Samples.PowerShell.IISCommands
{
    public class RemotingCommand : PSCmdlet
    {
        private string computer = Environment.MachineName;
        [Parameter(
           ValueFromPipeline = true,
           ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string[] Computer
        {
            get { return computer; }
            set { computer = value; }
        }
 
        private PSCredential credential = null;
        [Parameter(
           ValueFromPipeline = true,
           ValueFromPipelineByPropertyName = true)]
        [CredentialAttribute]
        public PSCredential Credential
        {
            get { return credential; }
            set { credential = value; }
        }

        protected ManagementScope GetScope(string computerName)
        {
            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = Credential.UserName;
            connection.Password = Credential.GetNetworkCredential().Password;
            connection.Impersonation = ImpersonationLevel.Impersonate;
            connection.Authentication = AuthenticationLevel.PacketPrivacy;
            ManagementScope scope = new ManagementScope(
"\\\\" + computerName + "\\root\\webadministration", connection);
            return scope;
        }
 
        protected override void EndProcessing()
        {
            if (null == credential)
            {
                // Check variable first 
               object varCred = GetVariableValue("IISCredential");
                if (varCred != null && varCred.GetType() == typeof(PSObject))
                {
                    credential = ((PSObject)varCred).BaseObject as PSCredential;
                }
                if (null == credential)
                {
                    // use credential of current user or process 
                   SecureString ss = new SecureString();
     foreach (char c in  CredentialCache.DefaultNetworkCredentials.Password.ToCharArray())
                    {
                        ss.AppendChar(c);
                    }
                    credential = new PSCredential(
                        CredentialCache.DefaultNetworkCredentials.UserName, ss);
                }
            }
       }
 
       protected ManagementClass CreateClassObject(
          string computerName, 
          string classPath )
       {
            return new ManagementClass(
                GetScope(computerName), 
                new ManagementPath(classPath), 
                new ObjectGetOptions()
             );
        }
    }