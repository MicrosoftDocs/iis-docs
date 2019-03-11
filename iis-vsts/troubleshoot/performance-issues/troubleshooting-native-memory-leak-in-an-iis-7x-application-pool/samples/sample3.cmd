STDMETHODIMP CFoo::crtheap(void)
{
    malloc(1024 * 10);

    return S_OK;
}