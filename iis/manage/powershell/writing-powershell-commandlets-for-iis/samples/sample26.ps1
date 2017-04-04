> Remove-IISSite foo -computer test-server -confirm

Confirm
Are you sure you want to perform this action?
Performing operation "Remove-IISSite" on Target "foo on server sergeia-a".
[Y] Yes  [A] Yes to All  [N] No  [L] No to All  [S] Suspend  [?] Help
(default is "Y"): <CR>

> get-iissite -computer test-server | ft name,status

Name                                    Status
----                                    ------
Default Web Site                        Started