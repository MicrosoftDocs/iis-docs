[Options]
UseAllowVerbs=1          ; Use the [AllowVerbs] section.
UseAllowExtensions=0     ; Use the [DenyExtensions] section.
NormalizeUrlBeforeScan=1 ; Normalize a URL before processing.
VerifyNormalization=1    ; Normalize a URL twice and reject request if a change occurs.
AllowHighBitCharacters=0 ; Deny high bit characters in URL.
AllowDotInPath=0         ; Deny dots that are not file name extensions.
RemoveServerHeader=0     ; Do not remove the "Server" header from response.
EnableLogging=1          ; Log UrlScan activity.
PerProcessLogging=0      ; Do not create log files for each process.
AllowLateScanning=0      ; Load UrlScan as a high priority filter.
PerDayLogging=1          ; UrlScan will create a new log file each day.
RejectResponseUrl=       ; Default is /<Rejected-by-UrlScan>
UseFastPathReject=0      ; Use the RejectResponseUrl or allow IIS to log the request.
LogLongUrls=1            ; Log URLs up to 128 KB per request.
UnescapeQueryString=1    ; Perform two passes on the query string.