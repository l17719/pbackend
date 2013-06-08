using System.Configuration;

namespace BackEndAplication.Models
{
    public class ElementosConfiguracao : ConfigurationSection
    {
        #region ConfigElements

        [ConfigurationProperty("name",
            DefaultValue = "Dados",
            IsRequired = true,
            IsKey = false)]
        [StringValidator(InvalidCharacters =
            " ~!@#$%^&*()[]{}/;'\"|\\",
            MinLength = 1, MaxLength = 60)]
        public string Name
        {
            get { return (string) this["name"]; }
            set { this["name"] = value; }
        }


        [ConfigurationProperty("ConfigData", IsKey = false, IsRequired = true)]
        public ElementoConfiguracao ConfigData
        {
            get
            {
                var data = (ElementoConfiguracao) base["ConfigData"];
                return data;
            }
            set { this["ConfigData"] = value; }
        }

        #endregion

        #region Methods

        protected override string SerializeSection(ConfigurationElement parentElement, string name,
                                                   ConfigurationSaveMode saveMode)
        {
            string s = base.SerializeSection(parentElement, name, saveMode);
            return s;
        }

        #endregion
    }
}