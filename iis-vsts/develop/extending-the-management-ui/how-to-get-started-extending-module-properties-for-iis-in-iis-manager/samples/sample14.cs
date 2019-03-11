protected override void OnException(Exception ex) { 
  while (ex.InnerException != null) { 
	ex = ex.InnerException; 
  } 
  ShowError(ex, false); 
}