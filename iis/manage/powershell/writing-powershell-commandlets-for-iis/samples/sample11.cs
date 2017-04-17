class ObjectConverter
    {
        public static PSObject ToPSObject(
            ManagementBaseObject source
            )
        {
            PSObject obj = new PSObject();
            foreach (PropertyData pd in source.Properties)
            {
                if (pd.Value.GetType() == typeof(System.Management.ManagementBaseObject))
                {
                    obj.Properties.Add(new PSNoteProperty(
                        pd.Name, ObjectConverter.ToPSObject(pd.Value as ManagementBaseObject)
                        ));
                }
                else if (pd.Value.GetType() == typeof(ManagementBaseObject[]))
                {
                    ManagementBaseObject[] ar = pd.Value as ManagementBaseObject[];
                    PSObject[] psar = new PSObject[ar.Length];
                    for (int i = 0; i < ar.Length; ++i)
                    {
                        psar[i] = ObjectConverter.ToPSObject(ar[i]);
                    }
                    obj.Properties.Add(new PSNoteProperty(pd.Name, psar));
                }
                else 
               {
                    obj.Properties.Add(new PSNoteProperty(pd.Name, pd.Value));
                }
            }
            return obj;
        }
    }