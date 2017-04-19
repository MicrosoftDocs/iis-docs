private PSObject ConstructPSSite(
	string computerName,
	ManagementObject site)
{
	PSObject pssite = ObjectConverter.ToPSObject(site);
	pssite.Properties.Add(new PSNoteProperty("Computer", computerName));
	pssite.Properties.Add(new PSNoteProperty("Credential", Credential));
	return pssite;
}