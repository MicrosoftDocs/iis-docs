struct HTTP_TRACE_EVENT_ITEM{
   LPCWSTR pszName;
   HTTP_TRACE_TYPE dwDataType;
   PBYTE pbData;
   DWORD cbData;
   LPCWSTR pszDataDescription;
};