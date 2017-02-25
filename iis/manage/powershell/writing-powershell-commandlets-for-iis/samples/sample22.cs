StringBuilder bindingText = new StringBuilder("(");
               foreach (PSObject b in bindings)
                {
                    Hashtable ht = b.BaseObject as Hashtable;
                    foreach (object key in ht.Keys)
                    {
                        string bstr = String.Format("{0}={1}",
                            key.ToString(), ht[key].ToString());
                        bindingText.Append(bstr + ",");
                    }
                    bindingText.Remove(bindingText.Length - 1, 1);
                    bindingText.Append(";");
                }
                bindingText.Remove(bindingText.Length - 1, 1);
                bindingText.Append(")");
                if (ShouldProcess(string.Format("{0} bound to {1} on {2}", name, bindingText.ToString(), rootFolder)))