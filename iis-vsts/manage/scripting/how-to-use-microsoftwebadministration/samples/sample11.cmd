serverManager.ApplicationPools.Add("RacingApplicationPool");
serverManager.Sites["Racing Site"].Applications[0].ApplicationPoolName = "RacingApplicationPool";