$settings = @ { waitInterval = 3000; waitAttempts = 25;}
Invoke-WDCommand "dir c:\mydirectory /s/b" -DestinationSettings $settings