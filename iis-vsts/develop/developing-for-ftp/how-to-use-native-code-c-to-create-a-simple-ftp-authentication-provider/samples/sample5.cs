// IFtpRoleProvider Methods
public:
    STDMETHOD(IsUserInRole)(LPWSTR pszSessionId,
        LPWSTR pszSiteName,
        LPWSTR pszUserName,
        LPWSTR pszRole,
        long * pfIsInRole)
    {
        // Note: You would add your own custom logic here.
        CString strUserName = L"MyUser";
        CString strRoleName = L"MyRole";
        
        // Verify that the user name and role name are valid.
        // In this example, both the user name and
        // the role name are case-insensitive.
        if ((strUserName.CompareNoCase(pszUserName)==0) &&
            (strRoleName.CompareNoCase(pszRole)==0))
        {
            *pfIsInRole = TRUE;
        }
        else
        {
            *pfIsInRole = FALSE;
        }
        
        return S_OK;
    }