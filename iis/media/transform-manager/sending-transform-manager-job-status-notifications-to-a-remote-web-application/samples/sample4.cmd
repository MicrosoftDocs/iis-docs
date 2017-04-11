routes.MapRoute(
     "Default", // Route name
     "{controller}/{action}/{id}", // URL with parameters
     new { controller = "JobMon", action = "Index", id = UrlParameter.Optional } // Parameter defaults
);