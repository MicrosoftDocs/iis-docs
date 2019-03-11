#For sites running on a port other than 80:
RewriteCond %{HTTP_HOST}   !^www_mysite_com [NC]
RewriteCond %{HTTP_HOST}   !^$
RewriteCond %{SERVER_PORT} !^80$
RewriteRule ^/(.*)         http://www_mysite_com:%{SERVER_PORT}/$1 [L,R]

#And for a site running on port 80
RewriteCond %{HTTP_HOST}   !^www_mysite_com [NC]
RewriteCond %{HTTP_HOST}   !^$
RewriteRule ^/(.*)         http://www_mysite_com/$1 [L,R]