appcmd set config "Default Web Site/mypictures/" -section:handlers 

/+[name='JPG-imageCopyrightHandler',path='*.jpg',verb='GET',type='IIS7Demos.imageCopyrightHandler']