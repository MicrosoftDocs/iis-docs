// for each parameter that was specified in the UI, set its value 
foreach (PackageParameter updatedValue in updatedValues) {
    DeploymentSyncParameter parameter;     if (String.IsNullOrEmpty(updatedValue.Name)) {
       throw new InvalidOperationException("A value without a name was passed to the installer");
    }
 
    // find the parameter to which a value should be set
    if (! iisApplication.SyncParameters.TryGetValue(updatedValue.Name, out parameter)) {
       throw new InvalidOperationException("Could not find a parameter with the name " + updatedValue.Name);
     }
     // Set the value
     parameter.Value = updatedValue.Value;
}