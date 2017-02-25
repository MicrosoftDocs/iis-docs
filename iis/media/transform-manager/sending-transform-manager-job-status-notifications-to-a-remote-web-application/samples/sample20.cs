public int Compare(NotificationModel x, NotificationModel y)
        {
            if (Object.ReferenceEquals(x, null))
            {
                // If x is null and y is null, they're equal. otherwise Y is greater
                if (Object.ReferenceEquals(y, null)) 
                { return 0; }
                else 
                { return 1; }
            }
            else
            {
                // x is not null
                //If y is null X is greater otherwise... 
                if (Object.ReferenceEquals(y, null)) 
                { return -1; }
                else
                {
                    //if they are equal otherwise ...
                    if (x.PostedDateTime == y.PostedDateTime) 
                    { return 0; }
                    else
                    {
                        //If x is greater , x is greater otherwise y is greater
                        if (DateTime.Parse(x.PostedDateTime) > DateTime.Parse(y.PostedDateTime))
                        { return -1; }
                        else 
                        { return 1; }
                    }
                }
            }
        }
    }