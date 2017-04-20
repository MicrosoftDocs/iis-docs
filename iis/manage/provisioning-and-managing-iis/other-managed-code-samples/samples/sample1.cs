using System;
using System.IO;
using System.DirectoryServices;
using System.Security.AccessControl;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        String dir = @"e:\content";
        DirectorySecurity dirsec = Directory.GetAccessControl(dir);
        dirsec.SetAccessRuleProtection(true, false);
        foreach (AuthorizationRule rule in dirsec.GetAccessRules(true, true, typeof(NTAccount)))
        {
        dirsec.RemoveAccessRuleAll(new FileSystemAccessRule(rule.IdentityReference, FileSystemRights.FullControl, AccessControlType.Allow));
        }
    dirsec.AddAccessRule(new FileSystemAccessRule(@"BUILTIN\Administrators", FileSystemRights. FullControl,AccessControlType.Allow));
    dirsec.AddAccessRule(new FileSystemAccessRule(@"BUILTIN\Administrators", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
    dirsec.AddAccessRule(new FileSystemAccessRule(@"BUILTIN\Administrators", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
    Directory.SetAccessControl(dir, dirsec);
    }
}