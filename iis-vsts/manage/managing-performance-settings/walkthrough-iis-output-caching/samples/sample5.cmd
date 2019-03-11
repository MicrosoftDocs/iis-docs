%windir%\system32\inetsrv\appcmd set config /section:system.web.Server/handlers 

    /+[name='imageCopyrightHandler-Integrated',path='*.jpg',

    verb='GET,HEAD',type='IIS7Demos.imageCopyrightHandler',preCondition='integratedMode']