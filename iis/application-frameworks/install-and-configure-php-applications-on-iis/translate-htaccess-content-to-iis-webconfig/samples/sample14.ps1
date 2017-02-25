# Requires mod_expires to be enabled.
<IfModule mod_expires.c>
  # Enable expirations.
  ExpiresActive On
 
  # Cache all files for 2 weeks after access (A).
  ExpiresDefault A1209600
 
  # Do not cache dynamically generated pages.
  ExpiresByType text/html A1
</IfModule>