private void GenerateRule(string domainName)
{
    try
    {
        _serviceProxy.GenerateRule(domainName);
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}