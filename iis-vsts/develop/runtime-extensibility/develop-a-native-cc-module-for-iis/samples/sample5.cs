class CMyHttpModule : public CHttpModule
{
public:
    REQUEST_NOTIFICATION_STATUS
    OnAcquireRequestState(
        IN IHttpContext *                       pHttpContext,
        IN OUT IHttpEventProvider *             pProvider
    );
};