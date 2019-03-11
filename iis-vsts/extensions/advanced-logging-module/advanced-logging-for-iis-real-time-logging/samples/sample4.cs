//
// {3C729B22-F9A9-4096-92A4-07E0DDF403EB}
//
static const GUID _LOGGING_PUBLISHING_GUID = 
{ 0x3c729b22, 0xf9a9, 0x4096, { 0x92, 0xa4, 0x7, 0xe0, 0xdd, 0xf4, 0x3, 0xeb } }; 
//
//  This call is happening on the same thread (synchronous/blocking call) as
//  the call to RaiseTraceEvent, so bail a.s.a.p. if this isn't something
//  we want to handle, and minimize the work we do here
//
//    
GLOBAL_NOTIFICATION_STATUS
CAnalyticsGlobalModule::OnGlobalTraceEvent(
    __in IGlobalTraceEventProvider  *  pProvider)
{
    HRESULT                 hr              = S_OK;
    IHttpContext *          pHttpContext    = NULL;
    HTTP_TRACE_EVENT *      pTraceEvent     = NULL;
    DBG_ASSERT(pProvider != NULL
    //
    //  We only want to handle trace events that are raised for 
    //  logging purposes, so bail a.s.a.p. if this event isn't
    //  for us
    //
    hr = pProvider->GetTraceEvent(&pTraceEvent
    if (FAILED(hr))
    {
        TRACEHR(hr
        goto Finished;
    }
    if (pTraceEvent->pProviderGuid == NULL)
    {
        TRACEMSG(SS_DEFAULT, 
                 TRACE_LEVEL_INFORMATION, 
                 L"Not handling trace event - NULL value for provider GUID"
        goto Finished;
    }
    if ((pTraceEvent->pProviderGuid != &_LOGGING_PUBLISHING_GUID) &&
        (!IsEqualGUID(*(pTraceEvent->pProviderGuid), _LOGGING_PUBLISHING_GUID)))
    {
        goto Finished;
    }
    //
    //  We now need the HTTP context which is used to get the site info later
    //
    hr = pProvider->GetCurrentHttpRequestContext(&pHttpContext
    if (FAILED(hr))
    {
        TRACEHR(hr
        goto Finished;
    }
    ProcessLogEvent(pTraceEvent, pHttpContext

Finished:
    
    return GL_NOTIFICATION_CONTINUE;    
}