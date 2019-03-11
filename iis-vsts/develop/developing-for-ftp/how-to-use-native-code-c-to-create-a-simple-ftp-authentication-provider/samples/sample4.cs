// IFtpAuthenticationProvider Methods
public:
    STDMETHOD(AuthenticateUser)(LPWSTR pszSessionId,
        LPWSTR pszSiteName,
        LPWSTR pszUserName,
        LPWSTR pszPassword,
        LPWSTR * ppszCanonicalUserName,
        long * pfAuthenticated)
    {
        // Note: You would add your own custom logic here.
        *ppszCanonicalUserName = pszUserName;
        
        CString strUserName = L"MyUser";
        CString strPassword = L"MyPassword";
        
        // Verify that the user name and password are valid.
        // In this example, the user name is case-insensitive
        // and the password is case-sensitive.
        if ((strUserName.CompareNoCase(pszUserName)==0) &&
            (strPassword.Compare(pszPassword)==0))
        {
            *pfAuthenticated = TRUE;
        }
        else
        {
            *pfAuthenticated = FALSE;
        }
        return S_OK;
    }