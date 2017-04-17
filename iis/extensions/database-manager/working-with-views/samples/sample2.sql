SELECT TOP 1000 FabrikamUsers.Username, AccessControls.ResourceURL, AccessControls.IsUserAllowed
FROM FabrikamUsers
INNER JOIN AccessControls ON (FabrikamUsers.UserId = AccessControls.UserId)
ORDER BY FabrikamUsers.Username ASC