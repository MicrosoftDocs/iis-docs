class CustomModule : Module { 
  protected override void Initialize(IServiceProvider serviceProvider, 
	ModuleInfo moduleInfo) { 
	base.Initialize(serviceProvider, moduleInfo); 

	// Register the control panel category and page with the control panel 
				IControlPanel controlPanel = 
	  (IControlPanel)serviceProvider.GetService(typeof(IControlPanel)); 
	Debug.Assert(controlPanel != null, "Couldn't get IControlPanel"); 
	ModulePageInfo customPage = 
	  new ModulePageInfo(this, typeof(CustomPage), 
	  "Custom Section Settings", "Edits the custom settings"); 
	controlPanel.RegisterPage(ControlPanelCategoryInfo.Server, customPage); 
  } 
}