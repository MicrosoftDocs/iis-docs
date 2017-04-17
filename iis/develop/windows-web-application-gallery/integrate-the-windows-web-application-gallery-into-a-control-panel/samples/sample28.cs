private void LoadParameters() {
        string zipFile = GetDownload();
        if (!File.Exists(zipFile)) {
            throw new InvalidOperationException("Could not download package for ID=" + ID + ", Title=" + Title);
        }
        using (DeploymentObject iisApplication = DeploymentManager.CreateObject(DeploymentWellKnownProvider.Package, zipFile)) {
            _parameters = (from parameter in iisApplication.SyncParameters
                           where !IsHidden(parameter)
                           select parameter).ToList();
        }
    }