$ret = Get-Acl C:\site1
$ret.Access
I don’t see u1 in the list. Let me give the user u1 access as follows
Set-WDAcl "site1" -SetAclUser u1
Check whether this worked
$ret = Get-Acl C:\site1
$ret.Access
I see that u1 has been given read access as below. [I have not pasted the other permissions on this folder. Just the u1 part]
FileSystemRights  : Read, Synchronize
AccessControlType : Allow
IdentityReference : MOSHAIKH1\u1
IsInherited       : False
InheritanceFlags  : ContainerInherit, ObjectInherit
PropagationFlags  : None