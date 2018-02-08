using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlProject
{
    public class VeseConfig : ConfigurationSection
    {

        public static VeseConfig Default
        {
            get 
            {
                return ConfigurationManager.GetSection("sajatok") as VeseConfig;
            }               
        }

        [ConfigurationProperty("logoUrl", IsRequired = true)]
        public string LogoUrl
        {
            get { return (string)this["logoUrl"]; }
            set { this["logoUrl"] = value; }
        }

        [ConfigurationProperty("position")]
        public PositionElement Position
        {
            get { return this["position"] as PositionElement; }
            set { this["position"] = value; }
        }
    }

    public class PositionElement : ConfigurationElement
    {
        [ConfigurationProperty("X", DefaultValue = 12, IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 30, MinValue = 5)]
        public int X
        {
            get { return (int)this["X"]; }
            set { this["X"] = value; }
        }

    }
}
