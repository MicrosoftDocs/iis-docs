public static void Reload() {
    lock (_packagesLock) {
        string feedUrl = ConfigurationManager.AppSettings["FeedXmlUrl"];
        if (String.IsNullOrEmpty(feedUrl)) {
            throw new InvalidOperationException("Could not find FeedXmlUrl in application settings");
        }
        // Parse the XML feed with the packages in them
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(GetXmlFromFeed(feedUrl));
        // Feed uses the Atom XML schema
        XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
        nsmgr.AddNamespace("atom", "http://www.w3.org/2005/Atom");
        _packages = new Dictionary<string, Package>();
        foreach (XmlNode app in doc.SelectNodes("//atom:entry[@type='application']", nsmgr)) {
            Package package = new Package {
                ID = GetXmlNodeText(app, nsmgr, "atom:productId"),
                Description = GetXmlNodeText(app, nsmgr, "atom:summary"),
                Title = GetXmlNodeText(app, nsmgr, "atom:title"),
                Version = GetXmlNodeText(app, nsmgr, "atom:version"),
                StartPage = GetXmlNodeText(app, nsmgr, "atom:pageName"),
                DownloadUrl = GetXmlNodeText(app, nsmgr, "atom:installers/atom:installer/atom:installerFile/atom:installerURL"),
                DownloadHash = GetXmlNodeText(app, nsmgr, "atom:installers/atom:installer/atom:installerFile/atom:sha1")
            };
            _packages.Add(package.ID, package);
        }
    }
}