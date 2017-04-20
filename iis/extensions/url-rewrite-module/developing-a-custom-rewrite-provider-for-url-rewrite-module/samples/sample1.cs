using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Iis.Rewrite;

public class ReplaceProvider: IRewriteProvider, IProviderDescriptor
{
    char oldChar, newChar;

    #region IRewriteProvider Members

    public void Initialize(IDictionary<string, string> settings, IRewriteContext rewriteContext)
    {
        string oldCharString, newCharString;

        if (!settings.TryGetValue("OldChar", out oldCharString) || string.IsNullOrEmpty(oldCharString))
            throw new ArgumentException("OldChar provider setting is required and cannot be empty");

        if (!settings.TryGetValue("NewChar", out newCharString) || string.IsNullOrEmpty(newCharString))
            throw new ArgumentException("NewChar provider setting is required and cannot be empty");

        if (!string.IsNullOrEmpty(oldCharString))
            oldChar = oldCharString.Trim()[0];
        else
            throw new ArgumentException("OldChar parameter cannot be empty");

        if (!string.IsNullOrEmpty(newCharString))
            newChar = newCharString.Trim()[0];
        else
            throw new ArgumentException("NewChar parameter cannot be empty");
    }

    public string Rewrite(string value)
    {
        return value.Replace(oldChar, newChar);
    }

    #endregion

    #region IProviderDescriptor Members

    public IEnumerable<SettingDescriptor> GetSettings()
    {
        yield return new SettingDescriptor("OldChar", "Old Character");
        yield return new SettingDescriptor("NewChar", "New Character");
    }

    #endregion
}