ProductManager pm = new ProductManager();
string fileLocation = GetXmlLocationFromFeed(feedUrl);
pm.Load(new Uri(fileLocation));