ProductManager pm = new ProductManager();
    pm.Load(new Uri(appXml), false, false);
    foreach (Keyword k in pm.Keywords) {
        tw.WriteLine("******** Keyword " + k.Text + " Products *********");
        foreach (Product p in k.Products) {
            tw.WriteLine(p.Title + " (id = '" + p.ProductId + "')");
        }
    }