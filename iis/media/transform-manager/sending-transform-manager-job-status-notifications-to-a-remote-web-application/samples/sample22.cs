		notifications = data.Select();
		
        //Azure doesn't support Distinct() so we must convert this to a list<T>
        foreach (Models.NotificationModel nm in notifications)
        {
            tms.Add(nm);
        }
        //Sort the POST to ensure the latest POST is at the top
        tms.Sort(comparer); 
        //Send a distinct job instance list to the View
        return View(tms.Distinct(comparer));
    }