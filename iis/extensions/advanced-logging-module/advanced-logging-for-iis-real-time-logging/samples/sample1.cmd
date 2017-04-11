struct HTTP_TRACE_EVENT{
   LPCGUID pProviderGuid;
   DWORD dwArea;
   LPCGUID pAreaGuid;
   DWORD dwEvent;
   LPCWSTR pszEventName;
   DWORD dwEventVersion;
   DWORD dwVerbosity;
   LPCGUID pActivityGuid;
   LPCGUID pRelatedActivityGuid;
   DWORD dwTimeStamp;
   DWORD dwFlags;
   DWORD cEventItems;
   __field_ecount(cEventItems) HTTP_TRACE_EVENT_ITEM * pEventItems;
};