using System.Configuration;
using System.Xml;

namespace BackEndAplication.Models
{
    public class ElementoConfiguracao : ConfigurationElement
    {
        #region ConfigurationProperties

        [ConfigurationProperty("name",
            DefaultValue = "DadosConfig",
            IsRequired = true,
            IsKey = true)]
        public string Name
        {
            get { return (string) this["name"]; }
            set { this["name"] = value; }
        }

        #region elementosConfiguracao

        #region ItemsConfiguracao

        [ConfigurationProperty("RegistoOK", IsRequired = true, DefaultValue = false)]
        public bool DadosConfiguracaoRegistoOk
        {
            get { return this["RegistoOK"].ToString().ToLower() == "true" ? true : false; }
            set { this["RegistoOK"] = value; }
        }

        [ConfigurationProperty("ConfiguracaoServidor", IsRequired = true, DefaultValue = false)]
        public bool DadosConfiguracaoServidorOk
        {
            get { return this["ConfiguracaoServidor"].ToString().ToLower() == "true" ? true : false; }
            set { this["ConfiguracaoServidor"] = value; }
        }

        [ConfigurationProperty("ConfiguracaoSQL", IsRequired = true, DefaultValue = false)]
        public bool DadosConfiguracaoSQLServer
        {
            get { return this["ConfiguracaoSQL"].ToString().ToLower() == "true" ? true : false; }
            set { this["ConfiguracaoSQL"] = value; }
        }

        [ConfigurationProperty("InstalacaoServico", IsRequired = true, DefaultValue = false)]
        public bool DadosConfiguracaoServico
        {
            get { return this["InstalacaoServico"].ToString().ToLower() == "true" ? true : false; }
            set { this["InstalacaoServico"] = value; }
        }

        #endregion

        #region Dados

        [ConfigurationProperty("SerialCliente", IsRequired = true, DefaultValue = "")]
        public string DadosConfiguracaoSerial
        {
            get { return (string) this["SerialCliente"]; }
            set { this["SerialCliente"] = value; }
        }

        [ConfigurationProperty("MailCliente", IsRequired = true, DefaultValue = "")]
        public string DadosConfiguracaoMailCliente
        {
            get { return (string) this["MailCliente"]; }
            set { this["MailCliente"] = value; }
        }

        [ConfigurationProperty("LicencaValida", IsRequired = true, DefaultValue = false)]
        public bool DadosConfiguracaoLicencaValida
        {
            get { return this["LicencaValida"].ToString().ToLower() == "true" ? true : false; }
            set { this["LicencaValida"] = value; }
        }


        //[ConfigurationProperty("PHCDBNAME", IsRequired = true, DefaultValue = "")]
        //public string DadosConfiguracaoNomeDbphc
        //{
        //    get { return (string)this["PHCDBNAME"]; }
        //    set { this["PHCDBNAME"] = value; }
        //}


        //[ConfigurationProperty("PHCSQLUSERNAME", IsRequired = true, DefaultValue = "")]
        //public string DadosConfiguracaoSQLUserNamePhc
        //{
        //    get { return (string)this["PHCSQLUSERNAME"]; }
        //    set { this["PHCSQLUSERNAME"] = value; }
        //}

        //[ConfigurationProperty("PHCSQLPASS", IsRequired = true, DefaultValue = "")]
        //public string DadosConfiguracaoSQLPassPhc
        //{
        //    get { return (string)this["PHCSQLPASS"]; }
        //    set { this["PHCSQLPASS"] = value; }
        //}


        [ConfigurationProperty("ConfiguracaoOK", IsRequired = true, DefaultValue = false)]
        public bool DadosConfiguracaoConfigOk
        {
            get { return this["ConfiguracaoOK"].ToString().ToLower() == "true" ? true : false; }
            set { this["ConfiguracaoOK"] = value; }
        }

        [ConfigurationProperty("NomeWebSite", IsRequired = true, DefaultValue = "")]
        public string DadosConfiguracaoNomeSite
        {
            get { return (string) this["NomeWebSite"]; }
            set { this["NomeWebSite"] = value; }
        }

        [ConfigurationProperty("NomeAppPool", IsRequired = true, DefaultValue = "")]
        public string DadosConfiguracaoNomeAppPool
        {
            get { return (string) this["NomeAppPool"]; }
            set { this["NomeAppPool"] = value; }
        }

        [ConfigurationProperty("NomeVirtualDir", IsRequired = true, DefaultValue = "")]
        public string DadosConfiguracaoNomeVDir
        {
            get { return (string) this["NomeVirtualDir"]; }
            set { this["NomeVirtualDir"] = value; }
        }

        #endregion

        #endregion

        #endregion

        #region Metodos

        protected override bool SerializeElement(
            XmlWriter writer,
            bool serializeCollectionKey)
        {
            bool ret = base.SerializeElement(writer,
                                             serializeCollectionKey);
            // You can enter your custom processing code here. 
            return ret;
        }


        protected override bool IsModified()
        {
            bool ret = base.IsModified();
            // You can enter your custom processing code here. 
            return ret;
        }

        #endregion
    }
}