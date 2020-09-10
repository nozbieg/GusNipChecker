using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GusNipChecker.Classes
{
    // UWAGA: Wygenerowany kod może wymagać co najmniej programu .NET Framework 4.5 lub .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class root
    {

        private rootDane[] daneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dane")]
        public rootDane[] dane
        {
            get
            {
                return this.daneField;
            }
            set
            {
                this.daneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootDane
    {

        private uint regonField;

        private ulong nipField;

        private object statusNipField;

        private string nazwaField;

        private string wojewodztwoField;

        private string powiatField;

        private string gminaField;

        private string miejscowoscField;

        private string kodPocztowyField;

        private string ulicaField;

        private string nrNieruchomosciField;

        private object nrLokaluField;

        private string typField;

        private byte silosIDField;

        private object dataZakonczeniaDzialalnosciField;

        /// <remarks/>
        public uint Regon
        {
            get
            {
                return this.regonField;
            }
            set
            {
                this.regonField = value;
            }
        }

        /// <remarks/>
        public ulong Nip
        {
            get
            {
                return this.nipField;
            }
            set
            {
                this.nipField = value;
            }
        }

        /// <remarks/>
        public object StatusNip
        {
            get
            {
                return this.statusNipField;
            }
            set
            {
                this.statusNipField = value;
            }
        }

        /// <remarks/>
        public string Nazwa
        {
            get
            {
                return this.nazwaField;
            }
            set
            {
                this.nazwaField = value;
            }
        }

        /// <remarks/>
        public string Wojewodztwo
        {
            get
            {
                return this.wojewodztwoField;
            }
            set
            {
                this.wojewodztwoField = value;
            }
        }

        /// <remarks/>
        public string Powiat
        {
            get
            {
                return this.powiatField;
            }
            set
            {
                this.powiatField = value;
            }
        }

        /// <remarks/>
        public string Gmina
        {
            get
            {
                return this.gminaField;
            }
            set
            {
                this.gminaField = value;
            }
        }

        /// <remarks/>
        public string Miejscowosc
        {
            get
            {
                return this.miejscowoscField;
            }
            set
            {
                this.miejscowoscField = value;
            }
        }

        /// <remarks/>
        public string KodPocztowy
        {
            get
            {
                return this.kodPocztowyField;
            }
            set
            {
                this.kodPocztowyField = value;
            }
        }

        /// <remarks/>
        public string Ulica
        {
            get
            {
                return this.ulicaField;
            }
            set
            {
                this.ulicaField = value;
            }
        }

        /// <remarks/>
        public string NrNieruchomosci
        {
            get
            {
                return this.nrNieruchomosciField;
            }
            set
            {
                this.nrNieruchomosciField = value;
            }
        }

        /// <remarks/>
        public object NrLokalu
        {
            get
            {
                return this.nrLokaluField;
            }
            set
            {
                this.nrLokaluField = value;
            }
        }

        /// <remarks/>
        public string Typ
        {
            get
            {
                return this.typField;
            }
            set
            {
                this.typField = value;
            }
        }

        /// <remarks/>
        public byte SilosID
        {
            get
            {
                return this.silosIDField;
            }
            set
            {
                this.silosIDField = value;
            }
        }

        /// <remarks/>
        public object DataZakonczeniaDzialalnosci
        {
            get
            {
                return this.dataZakonczeniaDzialalnosciField;
            }
            set
            {
                this.dataZakonczeniaDzialalnosciField = value;
            }
        }
        public void Show()
        {

        }
    }
}
