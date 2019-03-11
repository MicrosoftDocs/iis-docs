SELECT FabrikamUsers.Username, AccessControls.ResourceURL, AccessControls.IsUserAllowed
FROM FabrikamUsers
INNER JOIN AccessControls ON (FabrikamUsers.UserId = AccessControls.UserId)