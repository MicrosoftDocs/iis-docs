HRESULT        
__stdcall        
RegisterModule(        
    DWORD                           dwServerVersion,    
    IHttpModuleRegistrationInfo *   pModuleInfo,
    IHttpServer *                   pHttpServer            
)
{
   // step 1: save the IHttpServer and the module context id for future use 
    g_pModuleContext = pModuleInfo->GetId();
    g_pHttpServer = pHttpServer;

    // step 2: create the module factory 
    pFactory = new CMyHttpModuleFactory();

    // step 3: register for server events 
    hr = pModuleInfo->SetRequestNotifications( pFactory, 
                                              RQ_ACQUIRE_REQUEST_STATE,
                                               0 );            
}