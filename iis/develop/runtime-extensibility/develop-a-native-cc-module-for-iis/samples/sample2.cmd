#define RQ_BEGIN_REQUEST               0x00000001 // request is beginning 
#define RQ_AUTHENTICATE_REQUEST        0x00000002 // request is being authenticated             
#define RQ_AUTHORIZE_REQUEST           0x00000004 // request is being authorized 
#define RQ_RESOLVE_REQUEST_CACHE       0x00000008 // satisfy request from cache 
#define RQ_MAP_REQUEST_HANDLER         0x00000010 // map handler for request 
#define RQ_ACQUIRE_REQUEST_STATE       0x00000020 // acquire request state 
#define RQ_PRE_EXECUTE_REQUEST_HANDLER 0x00000040 // pre-execute handler 
#define RQ_EXECUTE_REQUEST_HANDLER     0x00000080 // execute handler 
#define RQ_RELEASE_REQUEST_STATE       0x00000100 // release request state 
#define RQ_UPDATE_REQUEST_CACHE        0x00000200 // update cache 
#define RQ_LOG_REQUEST                 0x00000400 // log request 
#define RQ_END_REQUEST                 0x00000800 // end request