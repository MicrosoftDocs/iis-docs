AppCmd set config "Default Web Site/" /section:system.webServer/security/requestFiltering /+hiddenSegments.[segment='_fpclass'] /commit:apphost
AppCmd set config "Default Web Site/" /section:system.webServer/security/requestFiltering /+hiddenSegments.[segment='_private'] /commit:apphost
AppCmd set config "Default Web Site/" /section:system.webServer/security/requestFiltering /+hiddenSegments.[segment='_vti_cnf'] /commit:apphost
AppCmd set config "Default Web Site/" /section:system.webServer/security/requestFiltering /+hiddenSegments.[segment='_vti_log'] /commit:apphost
AppCmd set config "Default Web Site/" /section:system.webServer/security/requestFiltering /+hiddenSegments.[segment='_vti_pvt'] /commit:apphost
AppCmd set config "Default Web Site/" /section:system.webServer/security/requestFiltering /+hiddenSegments.[segment='_vti_txt'] /commit:apphost
AppCmd set config "Default Web Site/" /section:system.webServer/security/requestFiltering /+hiddenSegments.[segment='fpdb'] /commit:apphost