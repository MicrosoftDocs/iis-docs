static void Main(string[] args) {
	ServerManager serverManager = new ServerManager();
	Configuration config = serverManager.GetApplicationHostConfiguration();
	MyCustomSection section = 
		(MyCustomSection)config.GetSection("myCustomSection", typeof(MyCustomSection));
	Console.WriteLine(section.BooleanProperty);
	Console.WriteLine(section.StringProperty);
	Console.WriteLine(section.IntegerProperty);
	Console.WriteLine(section.EnumProperty);
	section.BooleanProperty = true;
	section.StringProperty = "CustomString";
	section.IntegerProperty = 300;
	section.EnumProperty = EnumValue.EnumValue2;
	serverManager.CommitChanges();
}