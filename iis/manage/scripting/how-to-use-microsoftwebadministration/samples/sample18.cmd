ConfigurationAttribute enabled = section.GetAttribute("enabled");
enabled.Value = true;    
serverManager.CommitChanges();