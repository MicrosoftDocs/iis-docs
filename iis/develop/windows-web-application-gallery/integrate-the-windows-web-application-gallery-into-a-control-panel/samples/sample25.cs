// get the php keyword
Keyword phpKeyword = pm.GetKeyword("PHP");
tw.WriteLine("******** PHP apps ********");
foreach (Product p in phpKeyword.Products) {
	tw.WriteLine(p.Title + "(id = '" + p.ProductId + "')");
}
tw.Write("\r\n");
// get aspnet keyword
Keyword aspnetKeyword = pm.GetKeyword("ASPNET");
tw.WriteLine("******** ASPNET apps ********");
foreach (Product p in aspnetKeyword.Products) {
	tw.WriteLine(p.Title + "(id = '" + p.ProductId + "')");
}