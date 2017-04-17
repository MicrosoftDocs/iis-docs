class CMyHttpModuleFactory : public IHttpModuleFactory
{
public:
    virtual HRESULT GetHttpModule(
        OUT CHttpModule            **ppModule, 
        IN IModuleAllocator        *
    )
            
    {
    }

   virtual void Terminate()
    {
    }

};