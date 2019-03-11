public string GetMissingRequirements() {
    string displayString = String.Empty;
    try {
        ProductManager pm = new ProductManager();
        // we need to load the whole product list since app will depend on products in that file
        // the "true" parameter says filter the installer set to only installers available on this
        // architecture
        pm.Load(new Uri(ConfigurationManager.AppSettings["PLFeedXmlUrl"]), true);
        Product p = pm.GetProduct(ID);
        ICollection<Product> missingProducts = p.GetMissingDependencies(null);
        if (missingProducts.Count > 0) {
            displayString = "The server is missing the following products that are required to run this app: ";
            foreach (Product missing in missingProducts) {
                displayString += " " + missing.Title + ",";
            }
            displayString = displayString.Trim(',');
        }
    }
    catch {
    }
    return displayString;
}