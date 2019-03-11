#
# Apache/PHP/Application settings:
#
 
# Protect files and directories from prying eyes.
<FilesMatch "\.(engine|inc|info|install|module|profile|po|sh|.*sql|theme|tpl(\.php)?|xtmpl)$|^(code-style\.pl|Entries.*|Repository|Root|Tag|Template)$">
  Order allow,deny
</FilesMatch>
 
# Don't show directory listings for URLs which map to a directory.
Options -Indexes
 
# Follow symbolic links in this directory.
Options +FollowSymLinks
 
# Make Application handle any 404 errors.
ErrorDocument 404 /index.php
 
# Force simple error message for requests for non-existent favicon.ico.
<Files favicon.ico>
  ErrorDocument 404 "The requested file favicon.ico was not found.
</Files>
 
# Set the default handler.
DirectoryIndex index.php
 
# Override PHP settings. More in sites/default/settings.php
# but the following cannot be changed at runtime.
 
# PHP 4, Apache 1.
<IfModule mod_php4.c>
  php_value magic_quotes_gpc                0
  php_value register_globals                0
  php_value session.auto_start              0
  php_value mbstring.http_input             pass
  php_value mbstring.http_output            pass
  php_value mbstring.encoding_translation   0
</IfModule>

# PHP 4, Apache 2.
<IfModule sapi_apache2.c>
  php_value magic_quotes_gpc                0
  php_value register_globals                0
  php_value session.auto_start              0
  php_value mbstring.http_input             pass
  php_value mbstring.http_output            pass
  php_value mbstring.encoding_translation   0
</IfModule>
 
# PHP 5, Apache 1 and 2.
<IfModule mod_php5.c>
  php_value magic_quotes_gpc                0
  php_value register_globals                0
  php_value session.auto_start              0
  php_value mbstring.http_input             pass
  php_value mbstring.http_output            pass
  php_value mbstring.encoding_translation   0
</IfModule>
 
# Requires mod_expires to be enabled.
<IfModule mod_expires.c>
  # Enable expirations.
  ExpiresActive On
 
  # Cache all files for 2 weeks after access (A).
  ExpiresDefault A1209600
 
  # Do not cache dynamically generated pages.
  ExpiresByType text/html A1
</IfModule>
 
# Various rewrite rules.
<IfModule mod_rewrite.c>
  RewriteEngine on
 
  # If your site can be accessed both with and without the 'www.' prefix, you
  # can use one of the following settings to redirect users to your preferred
  # URL, either WITH or WITHOUT the 'www.' prefix. Choose ONLY one option:
  #
  # To redirect all users to access the site WITH the 'www.' prefix,
  # (http://example.com/... will be redirected to http://www.example.com/...)
  # adapt and uncomment the following:
  # RewriteCond %{HTTP_HOST} ^example\.com$ [NC]
  # RewriteRule ^(.*)$ http://www.example.com/$1 [L,R=301]
  #
  # To redirect all users to access the site WITHOUT the 'www.' prefix,
  # (http://www.example.com/... will be redirected to http://example.com/...)
  # uncomment and adapt the following:
  # RewriteCond %{HTTP_HOST} ^www\.example\.com$ [NC]
  # RewriteRule ^(.*)$ http://example.com/$1 [L,R=301]
 
  # Modify the RewriteBase if you are using Application in a subdirectory or in a
  # VirtualDocumentRoot and the rewrite rules are not working properly.
  # For example if your site is at http://example.com/application uncomment and
  # modify the following line:
  # RewriteBase /application
  #
  # If your site is running in a VirtualDocumentRoot at http://example.com/,
  # uncomment the following line:
  # RewriteBase /
 
  # Rewrite URLs of the form 'x' to the form 'index.php?q=x'.
  RewriteCond %{REQUEST_FILENAME} !-f
  RewriteCond %{REQUEST_FILENAME} !-d
  RewriteCond %{REQUEST_URI} !=/favicon.ico
  RewriteRule ^(.*)$ index.php?q=$1 [L,QSA]
</IfModule>
 
# $Id: .htaccess,v 1.90.2.1 2008/07/08 09:33:14 goba Exp $