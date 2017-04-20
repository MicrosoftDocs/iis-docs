using (DeploymentObject iisApplication =  
  DeploymentManager.CreateObject(providerOptions, 
  sourceOptions)) {
	DeploymentBaseOptions destinationOptions = new DeploymentBaseOptions {
		ComputerName = agentUri,
		UserName = userName,
		Password = password,
		AuthenticationType = "basic",
	};