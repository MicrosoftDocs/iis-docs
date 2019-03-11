using System;
using System.DirectoryServices;
class Program
{
    static void Main(string[] args)
    {
        DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
        DirectoryEntry NewUser = AD.Children.Add("PoolID1", "user");
        NewUser.Invoke("SetPassword", new object[] { "PoolIDPwd1" });
        NewUser.Invoke("Put", new object[] { "Description", "AppPool Account" });
        NewUser.CommitChanges();
    }
}