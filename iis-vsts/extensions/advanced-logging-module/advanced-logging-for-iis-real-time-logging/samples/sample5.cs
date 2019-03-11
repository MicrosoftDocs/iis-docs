void ProcessLogEvent(
        __in    HTTP_TRACE_EVENT *  pHttpTraceEvent,
        __in    IHttpContext     *  pHttpContext)
    {
        HRESULT                     hr = S_OK;
        DWORD                       cchName = 0;
        HTTP_TRACE_EVENT *          pNewHttpTraceEvent  = NULL;
        LPCSTR                      pszHostName     = NULL;
        pNewHttpTraceEvent = new HTTP_TRACE_EVENT;
        if (pNewHttpTraceEvent == NULL)
        {
            goto Finished;
        }
        pNewHttpTraceEvent->pEventItems = new HTTP_TRACE_EVENT_ITEM[pHttpTraceEvent->cEventItems];
        if (pNewHttpTraceEvent->pEventItems == NULL)
        {
            goto Finished;
        }
        ZeroMemory(pNewHttpTraceEvent->pEventItems, sizeof(HTTP_TRACE_EVENT_ITEM) * pHttpTraceEvent->cEventItems);
        
        for (DWORD ix = 0; ix < pHttpTraceEvent->cEventItems; ix++)
        {
            if (pHttpTraceEvent->pEventItems[ix].pszName == NULL)
            {
                pNewHttpTraceEvent->pEventItems[ix].pszName = NULL;
                pNewHttpTraceEvent->pEventItems[ix].cbData = 0;
                pNewHttpTraceEvent->pEventItems[ix].pbData = NULL;
                continue;
            }
            //
            //  Copy the name of this event item
            //
            cchName = wcslen(pHttpTraceEvent->pEventItems[ix].pszName);
            pNewHttpTraceEvent->pEventItems[ix].pszName = new WCHAR[cchName + 1];
            if (pNewHttpTraceEvent->pEventItems[ix].pszName == NULL)
            {
                goto Finished;
            }
            memcpy((VOID *)pNewHttpTraceEvent->pEventItems[ix].pszName, pHttpTraceEvent->pEventItems[ix].pszName, (cchName+1) * sizeof(WCHAR));
            //
            //  If there's no data to copy, mark it empty
            //           
            if ((pHttpTraceEvent->pEventItems[ix].cbData == 0) ||
                (pHttpTraceEvent->pEventItems[ix].pbData == NULL))
            {
                pNewHttpTraceEvent->pEventItems[ix].cbData = 0;
                pNewHttpTraceEvent->pEventItems[ix].pbData = NULL;
                continue;
            }
            pNewHttpTraceEvent->pEventItems[ix].pbData = new BYTE[pHttpTraceEvent->pEventItems[ix].cbData];
            if (pNewHttpTraceEvent->pEventItems[ix].pbData  == NULL)
            {
                goto Finished;
            }
            memcpy(pNewHttpTraceEvent->pEventItems[ix].pbData, pHttpTraceEvent->pEventItems[ix].pbData, pHttpTraceEvent->pEventItems[ix].cbData);
            pNewHttpTraceEvent->pEventItems[ix].cbData = pHttpTraceEvent->pEventItems[ix].cbData;
            pNewHttpTraceEvent->pEventItems[ix].dwDataType = pHttpTraceEvent->pEventItems[ix].dwDataType;
        }
        //
        //  At this point, you've copied the event into your memory and can now process your copy, queue it, etc.
        //
//        WriteEventViewerLog(pHttpTraceEvent->pszEventName);   // Can write to eventViewer log to verify that event is processed...
    Finished:
        return;
    }