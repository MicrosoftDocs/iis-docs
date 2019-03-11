$computer = [ADSI]"WinNT://."
$user = $computer.Create("user", "DemoAppPoolUser")
$user.SetPassword("Secret!!Pw3009")
$user.SetInfo()