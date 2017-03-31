RewriteCond %{HTTP_HOST} ^example\.com$ [NC]
  RewriteRule ^(.*)$ http://www.example.com/$1 [L,R=301]

  RewriteCond %{REQUEST_FILENAME} !-f
  RewriteCond %{REQUEST_FILENAME} !-d
  RewriteCond %{REQUEST_URI} !=/favicon.ico
  RewriteRule ^(.*)$ index.php?q=$1 [L,QSA]