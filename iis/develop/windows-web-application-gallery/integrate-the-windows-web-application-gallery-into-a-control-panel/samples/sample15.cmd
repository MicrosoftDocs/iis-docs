[...]
Installer installer = p.GetInstaller(english);
if (installer == null) {
       if (p.Installers.Count > 0) {
         installer = p.Installers[0];
        }
        else {
           // some products are just for detection
           continue;
        }
}
// if there's no install location we'll skip as well
if (installer.InstallerFile == null) {
        continue;
}
Package package = new Package {
    ID = p.ProductId,
    Description = p.Summary,
    Title = p.Title,
    Version = p.Version,
    SartPage = installer.MSDeployPackage.StartPage ?? String.Empty,
    DownloadUrl = installer.InstallerFile.InstallerUrl.AbsoluteUri,
    DownloadHash = installer.InstallerFile.SHA1Hash
};
[...]