using System;
using System.Collections.Generic;
using Microsoft.Web.Management.Server;
using Microsoft.Web.Administration;

namespace CanonicalDomainTemplate
{
    class CanonicalDomainModuleService : ModuleService
    {

        [ModuleServiceMethod]
        public void GenerateRule(string domainName)
        {
            string sectionPath = "system.webServer/rewrite/rules";
            
            if (ManagementUnit.ConfigurationPath.PathType == ConfigurationPathType.Server)
            {
                sectionPath = "system.webServer/rewrite/globalRules";
            }

            ConfigurationSection rulesSection = ManagementUnit.Configuration.GetSection(sectionPath);
            ConfigurationElementCollection rulesCollection = rulesSection.GetCollection();

            ConfigurationElement ruleElement = rulesCollection.CreateElement("rule");
            ruleElement["name"] = @"Canonical domain for " + domainName;
            ruleElement["patternSyntax"] = @"Wildcard";
            ruleElement["stopProcessing"] = true;

            ConfigurationElement matchElement = ruleElement.GetChildElement("match");
            matchElement["url"] = @"*";

            ConfigurationElement conditionsElement = ruleElement.GetChildElement("conditions");

            ConfigurationElementCollection conditionsCollection = conditionsElement.GetCollection();

            ConfigurationElement addElement = conditionsCollection.CreateElement("add");
            addElement["input"] = @"{HTTP_HOST}";
            addElement["negate"] = true;
            addElement["pattern"] = domainName;
            conditionsCollection.Add(addElement);

            ConfigurationElement actionElement = ruleElement.GetChildElement("action");
            actionElement["type"] = @"Redirect";
            actionElement["url"] = @"http://" + domainName + @"/{R:1}";
            actionElement["appendQueryString"] = true;
            rulesCollection.Add(ruleElement);

            ManagementUnit.Update();
        }
    }
}