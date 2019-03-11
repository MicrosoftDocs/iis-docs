//
// {3C729B22-F9A9-4096-92A4-07E0DDF403EB}
//
static const GUID _LOGGING_PUBLISHING_GUID = 
{ 0x3c729b22, 0xf9a9, 0x4096, { 0x92, 0xa4, 0x7, 0xe0, 0xdd, 0xf4, 0x3, 0xeb } };
………………
………………
    
if ((pTraceEvent->pProviderGuid != &_LOGGING_PUBLISHING_GUID) &&
        (!IsEqualGUID(*(pTraceEvent->pProviderGuid), _LOGGING_PUBLISHING_GUID)))
{
    goto Finished;
}