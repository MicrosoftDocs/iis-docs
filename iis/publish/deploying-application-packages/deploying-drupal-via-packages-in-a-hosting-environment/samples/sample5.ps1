# Powershell Args
$dbusername = $args[0]                                    # Administrative Username
$dbpassword = $args[1]                                    # Administrative Password
$dbname = $args[2]                                        # Database Name to Create
$appUsername = $args[3]                                   # Application Username
$appPassword = $args[4]                                   # Application Users Username  
# Add MySQL Data Connector
[void][system.reflection.Assembly]::LoadWithPartialName("MySql.Data")  
# Open Connection to SQL Server
$connStr = "server=127.0.0.1;port=3306;uid=root;pwd=SQLPassword"
$conn = New-Object MySql.Data.MySqlClient.MySqlConnection($connStr)
$conn.Open()  
# Create MySQL Database
$createmysqldatabase = 'CREATE DATABASE `' + $dbname + '`'
$cmd = New-Object MySql.Data.MySqlClient.MySqlCommand($createmysqldatabase, $conn)
$da = New-Object MySql.Data.MySqlClient.MySqlDataAdapter($cmd)
$ds = New-Object System.Data.DataSet
$da.Fill($ds)  
# Create MySQL User
$createmysqluser = 'CREATE USER `' + $appUsername  + '`@`localhost` ' + ' identified by `' + $appPassword + '`'
$cmd = New-Object MySql.Data.MySqlClient.MySqlCommand($createmysqluser, $conn)
$da = New-Object MySql.Data.MySqlClient.MySqlDataAdapter($cmd)
$ds = New-Object System.Data.DataSet
$da.Fill($ds)  
# Grant permissions to Database
$grantmysqldatabaseperms = 'Grant ALL on ' + $dbname + '.* to `' + $appUsername  + '`@`localhost` '
$cmd = New-Object MySql.Data.MySqlClient.MySqlCommand($grantmysqldatabaseperms, $conn)
$da = New-Object MySql.Data.MySqlClient.MySqlDataAdapter($cmd)
$ds = New-Object System.Data.DataSet
$da.Fill($ds)