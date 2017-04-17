public void Post()
    {
        // Recommended: Filter the incoming IP address before processing
        // Optionally, use configuration settings to retrieve the IP address list
        ICollection<string> ValidIPs = new List<string>();
        ValidIPs.Add("127.0.0.1"); 
        string Ip = (Request.ServerVariables["HTTP_X_FORWARDED_FOR"] == null) ? 
            Request.ServerVariables["REMOTE_ADDR"] : Request.ServerVariables["HTTP_X_FORWARDED_FOR"];