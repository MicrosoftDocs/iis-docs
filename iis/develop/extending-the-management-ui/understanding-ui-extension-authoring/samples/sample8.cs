using System.Reflection;

internal static class AssemblyRef {

    private static string client;

    internal static string Client {
        get {
            if (client == null) {
                AssemblyName assemblyName = typeof(AssemblyRef).Assembly.GetName();
                string assemblyFullName = assemblyName.FullName;
                client = assemblyFullName.Replace(assemblyName.Name, "Client");
            }

            return client;
        }
    }
}