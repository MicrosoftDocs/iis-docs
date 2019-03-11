// IFtpLogProvider Methods
public:
    STDMETHOD(Log)(LOGGING_PARAMETERS * pLoggingParameters)
    {
        // Note: You would add your own custom logic here.
        HRESULT hr = S_OK;
        DWORD dwResult;
        HANDLE hFile;
        char szLogEntry[256]="";
        const DWORD FILE_WRITE_TO_END_OF_FILE = 0xffffffff;

        OVERLAPPED Overlapped = { 0 };
        Overlapped.Offset = FILE_WRITE_TO_END_OF_FILE;
        Overlapped.OffsetHigh = -1;
        
        // Retrieve the current date and time for the log entry.
        SYSTEMTIME CurrentTime;
        GetSystemTime(&CurrentTime);
        
        // Open the log file for output.
        hFile = CreateFile(
            L"\\\\?\\C:\\logfiles\\myftpsite\\myftplog.log",
            GENERIC_WRITE,
            FILE_SHARE_READ,
            NULL,
            OPEN_ALWAYS,
            FILE_ATTRIBUTE_NORMAL | FILE_FLAG_WRITE_THROUGH,
            NULL);
        
        // Return an error if a failure occurs.
        if (hFile == INVALID_HANDLE_VALUE)
        {
            hr = HRESULT_FROM_WIN32(GetLastError());
            goto EXIT;
        }
        
        // Format the log entry.
        hr = StringCchPrintfA(
            szLogEntry,256,
            "%04d-%02d-%02d\t%02d:%02d:%02d\t%S\t%d\r\n",
            CurrentTime.wYear,CurrentTime.wMonth,CurrentTime.wDay,
            CurrentTime.wHour,CurrentTime.wMinute,CurrentTime.wSecond,
            pLoggingParameters->pszCommand,
            pLoggingParameters->FtpStatus);

        // Test for error.
        if (FAILED(hr))
        {
            // Return the error if a failure occurs.
            hr = HRESULT_FROM_WIN32(GetLastError());
            goto EXIT;
        }
        
        // Write the log entry to the log file.
        if(!WriteFile(hFile, szLogEntry,
            strlen(szLogEntry), &dwResult, &Overlapped))        
        {
            // Return an error if a failure occurs.
            hr = HRESULT_FROM_WIN32(GetLastError());
            goto EXIT;
        }

EXIT:
        // Close the log file if it is open.
        if(CloseHandle(hFile)==0)
        {
            // Return an error if a failure occurs.
            hr = HRESULT_FROM_WIN32(GetLastError());
        }
        return hr;
    }