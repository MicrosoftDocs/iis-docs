msdeploy.exe -Verb:Sync -Source:dbDacFx="Data Source=.\SQLEXPRESS; Database=OldDatabase; User ID=sa; Password=P@$$W0rd" -Dest:dbDacFx="Data Source=.\SQLEXPRESS; Database=NewDatabase; User ID=sa; Password=P@$$W0rd"