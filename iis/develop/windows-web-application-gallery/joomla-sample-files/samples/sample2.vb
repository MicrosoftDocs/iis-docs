<parameters>

<!-- Prompts where to copy the content files and takes a web site path (such as "contoso.com/app"). -->
<parameter name="ApplicationPath"
description="Full site path you would like to install your application to(i.e. Default Web Site/joomla)."
defaultValue="Default Web Site/joomla_17"
tags="iisapp" >

<parameterEntry
type="ProviderPath"
scope="iisapp"
match="joomla_17$" />
</parameter>

<!-- Setting ACL parameters for Joomla -->

<parameter name="SetAclParameter1"
description="Sets the ACL on /"
defaultValue="{ApplicationPath}"
tags="Hidden" >

<parameterEntry
type="ProviderPath"
scope="setAcl"
match="joomla_17"/>
</parameter>

<!-- Database Parameters -->

<!-- Prompts the user for the database server name.-->
<!-- Note that this parameter has only one parameterEntry element. This parameter is used with the configuration file and the connection string. It is not used within the SQL script itself like the other paramters are. -->

<parameter name="DatabaseServer"
description="This is usually localhost or a host name provided by the hosting provider."
defaultValue="localhost"
tags="MySQL, dbServer" >

<!-- Parameter substitution -->
<parameterEntry
type="TextFile"
scope="install.sql"
match="PlaceHolderForServer" />
</parameter>

<parameter name="Automatic DatabaseServer"
defaultValue="public $host = '{DatabaseServer}';"
tags="Hidden, MySQL" >
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$host[\s]*=[\s]*'([^']*)';" />
</parameter>

<!-- Prompts the user for the database name. -->
<parameter name="DatabaseName"
description="Database Name for your application. Please note database name must start with a letter and must be in lowercase along. You can also use numerals and underscore(_)."
defaultValue="my_site_db"
tags="MySQL, dbName" >

<!-- This Regular expression ensures that Database name can be alphanumeric and allows _ character -->
<parameterValidation type = "RegularExpression" validationString = "^[a-z0-9_]+$" />

<!-- Parameter substitution-->
<parameterEntry
type="TextFile"
scope="install.sql"
match="PlaceHolderForDb" />

<parameterEntry
type="TextFile"
scope="joomla.sql"
match="PlaceHolderForDb" />

<parameterEntry
type="TextFile"
scope="sample_data.sql"
match="PlaceHolderForDb" />

</parameter>

<!-- Prompts the user for the database name. -->
<parameter name="Automatic DatabaseName"
defaultValue="public $db = '{DatabaseName}';"
tags="Hidden, MySQL" >
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$db[\s]*=[\s]*'([^']*)';" />
</parameter> 

<!-- Prompts user for a Database prefix -->

<parameter name="Database Prefix"
description="Use the table prefix that is added to your all table names."
defaultValue="jos_"
tags="Hidden,MySQL,NoStore" >

<!-- This Regular expression ensures that perfixes can be alphabets or underscore and 15 characters in length -->
<parameterValidation type = "RegularExpression" validationString = "[a-zA-Z0-9_]{1,15}" />

<!-- Parameter substitution-->
<parameterEntry
type="TextFile"
scope="joomla.sql"
match="#__" />

<parameterEntry
type="TextFile"
scope="sample_data.sql"
match="#__" />

<parameterEntry
type="TextFile"
scope="joomla_user.sql"
match="#__" />

</parameter>

<parameter name="Automatic db prefix"
defaultValue="public $dbprefix = '{Database Prefix}';" 
tags="Hidden,NoStore" >
<!-- Parameter substitution -->
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$dbprefix[\s]*=[\s]*'([^']*)';" />
</parameter>

<!--Prompts the user for the database username. -->

<parameter name="DatabaseAdministrator"
description="This can be the default MySQL username root, a username provided by your hosting provider, or one that you created in setting up your database server. "
defaultValue="root"
tags="MySQL, DbAdminUsername" >

</parameter>

<!-- Prompts the user for the database user's password. -->

<parameter name="DatabaseAdministratorPassword"
description="Using a password for the MySQL account is mandatory for site security. This is the same password used to access your database. This may be predefined by your hosting provider. "
tags="Password, MySQL, DbAdminPassword" >

</parameter>

<parameter name="Database Username"
description="Username to access your Joomla database"
defaultValue="joomlauser"
tags="MySQL, DbUsername">
<!-- Parameter substitution-->
<parameterEntry
type="TextFile"
scope="install.sql"
match="PlaceHolderForUser" />

</parameter>
<parameter name="Automatic Database Username"
defaultValue="public $user = '{Database Username}';"
tags="Hidden, MySQL">
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$user[\s]*=[\s]*'([^']*)';" />
</parameter>

<!-- Prompts for the database password and fills it into the database scripts.The MySQL tag indicates it is a parameter required for MySQL, the DbUserPassword tag indicates this is a Db password -->
<parameter name="Database Password"
description="Password for your Joomla database"
tags="New, Password, MySQL, DbUserPassword">

<parameterValidation 
type = "RegularExpression" 
validationString = "(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$" /> 

<!-- Parameter substitution-->
<parameterEntry
type="TextFile"
scope="install.sql"
match="PlaceHolderForPassword" />
</parameter>

<parameter name="Automatic Database Password"
defaultValue="public $password = '{Database Password}';"
tags="Hidden, MySQL">
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$password[\s]*=[\s]*'([^']*)';" />
</parameter>

<!-- Prompts the user for the Load Sample data or not. -->
<parameter name="Load Sample Data"
description="Do you wish to load Sample Data"
defaultValue="Yes"
tags="MySQL,NoStore" >

<!-- This Regular expression ensures that ENUM data type is used -->
<parameterValidation type="Enumeration" validationString="Yes,No"/>

<!-- Parameter substitution-->
<parameterEntry
type="TextFile"
scope="sample_data.sql"
match="PlaceHolderForSampleDataFlag" />

</parameter>

<!-- This is the hidden admin connection string used to run the database scripts. -->

<parameter name="ConnectionString"
description="Automatically sets the connection string for the connection request."
defaultValue="Server={DatabaseServer};Database={DatabaseName};uid={DatabaseAdministrator};Pwd={DatabaseAdministratorPassword};"
tags="Hidden,MySQLConnectionString,validate" >

<parameterEntry
type="ProviderPath"
scope="dbmysql"
match="install.sql" />

<parameterEntry
type="ProviderPath"
scope="dbmysql"
match="joomla.sql" />

<parameterEntry
type="ProviderPath"
scope="dbmysql"
match="joomla_user.sql" />

<parameterEntry
type="ProviderPath"
scope="dbmysql"
match="sample_data.sql"
/>
</parameter>

<!-- Prompt user for Joomla Site Name -->

<parameter name="Website Name"
description="Name your Website(i.e., Joomla , XYZ company)"
defaultValue="My XYZ Website" tags="NoStore" >

<parameterValidation type = "RegularExpression" validationString = "^[^\']*$" />

</parameter>
<parameter name="Automatic Website Name1"
defaultValue="public $fromname = '{Website Name}';" tags="Hidden,NoStore" >
<!-- Parameter substitution -->
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$fromname[\s]*=[\s]*'([^']*)';" />
</parameter>

<parameter name="Automatic Website Name2"
defaultValue="public $sitename = '{Website Name}';" tags="Hidden,NoStore" >
<!-- Parameter substitution -->
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$sitename[\s]*=[\s]*'([^']*)';" />
</parameter>

<!-- Prompt user for Joomla Administrator username-->

<parameter name="Site Administrator"
description="Joomla Site Administrator Username . You can access the Joomla! Administrator area using http://www.yourwebsite.com/administrator or Using Clicking on Main Menu-->Administrator Link ."
defaultValue="admin" tags="NoStore" >

<!-- Parameter substitution -->
<parameterEntry
type="TextFile"
scope="joomla_user.sql"
match="PlaceHolderForAdminUser" />

</parameter>

<!-- Prompt user for Joomla Site Administrator password -->

<parameter name="Site Administrator Password"
  description="Joomla Site Administrator Password must be at least 8 characters in length with at least one lower case/uppercase letter and at least one special character/numeric"
tags="New,Password,NoStore" >

<!-- This Regular Expression ensures that Passwords will contain at least (1) upper case letter/at least (1) lower case letter, at least (1) number or special character, and be least (8) characters in length. -->
<parameterValidation
type = "RegularExpression"
validationString = "(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$" />

<!-- Parameter substitution -->
<parameterEntry
type="TextFile"
scope="joomla_user.sql"
match="PlaceHolderForAdminPass" />

</parameter>

<!-- Prompt user for Joomla Site Administrator's Email -->

<parameter name="Site Administrator Email"
description="Joomla Site Administrator Email(Eg: john@example.com , john.adam@example.com)" tags="NoStore">

<!-- This Regular Expression ensures that Administrator Email address is a valid email address -->
<parameterValidation
type="RegularExpression"
validationString="^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+"/>

<!-- Parameter substitution -->
<parameterEntry
type="TextFile"
scope="joomla_user.sql"
match="PlaceHolderForAdminEmail" />

</parameter>

<!--Hidden Fields -->
<parameter
name="FTPDisabled"
description="Disable FTP configuration (Default setting)"
defaultValue="0"
tags="Hidden,NoStore"
>

</parameter>

<!--Hidden Fields -->
<parameter
name="Automatic FTPDisabled"
defaultValue="public $ftp_enable = '{FTPDisabled}';"
tags="Hidden,NoStore"
>
<parameterEntry
type="TextFile"
scope="configuration.php"
match="public[\s]*\$ftp_enable[\s]*=[\s]*'([^']*)';"
/>
</parameter>

</parameters>
