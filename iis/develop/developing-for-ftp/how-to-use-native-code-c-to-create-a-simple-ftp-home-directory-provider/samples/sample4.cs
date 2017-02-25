// IFtpHomeDirectoryProvider Methods
public:
    STDMETHOD(GetUserHomeDirectoryData)(
        LPWSTR pszSessionId,
        LPWSTR pszSiteName,
        LPWSTR pszUserName,
        LPWSTR * ppszHomeDirectoryData)
    {
        // Note: You would add your own custom logic here.
        HRESULT hr = S_OK;
        WCHAR wszPath[MAX_PATH] = L"";
        
        // Calculate the user's home directory based on their user name.
        hr = StringCchPrintf(wszPath,_countof(wszPath),
            L"\\\\?\\C:\\ftpusers\\%s",pszUserName);
        // Return an error if a failure occurs.
        if (FAILED(hr))
        {
            return hr;
        }
        
        // Allocate a block of memory for the user's home directory.
        LPWSTR wszHomeDirectoryData =
            (LPWSTR)CoTaskMemAlloc(_countof(wszPath) * sizeof(WCHAR));
        // Return an error if a failure occurs.
        if (wszHomeDirectoryData == NULL)
        {
            return E_OUTOFMEMORY;
        }
        
        // Copy the user's home directory into the memory block.
        hr = StringCchCopy(wszHomeDirectoryData,
            _countof(wszPath), wszPath);
        // Return an error if a failure occurs.
        if (FAILED(hr))
        {
            return hr;
        }
        
        // Return the user's home directory.
        (*ppszHomeDirectoryData) = wszHomeDirectoryData;
        return S_OK;
    }