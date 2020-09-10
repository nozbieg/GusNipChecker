using GusNipChecker.Classes;
using GusNipChecker.UslugaBIR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusNipChecker
{
    class Program
    {
        public static void CheckNIP()
        {
            UslugaBIRzewnPublClient cc = ConBIR();
            ParametryWyszukiwania numerNip = new ParametryWyszukiwania();
            Console.WriteLine("Wprowadź nip lub kilka nipów oddzielonych przecinkiem : ");
            numerNip.Nipy = Console.ReadLine();
            string ret = cc.DaneSzukajPodmioty(numerNip);
            SerializeModule(ret);
            cc.Close();
        }

        public static void SerializeModule(string ret)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "root";
            root retDeserialized = new root();
            UslugaBIRzewnPublClient gusWebService = new UslugaBIRzewnPublClient();
            XmlSerializer serializer = new XmlSerializer(typeof(root), xRoot);
            using (TextReader reader = new StringReader(ret))
            {
                retDeserialized = (root)serializer.Deserialize(reader);
            }

            foreach (var x in retDeserialized.dane)
            {
                Console.WriteLine(x.Nazwa);
                Console.WriteLine(x.Nip);
                Console.WriteLine(x.Miejscowosc);
            }

        }

        public static UslugaBIRzewnPublClient ConBIR()
        {
            GusKey apiKey = new GusKey();
            WSHttpBinding myBinding = Binding();
            EndpointAddress ea = new EndpointAddress("https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");

            UslugaBIRzewnPublClient cc = new UslugaBIRzewnPublClient(myBinding, ea);
            cc.Open();

            string sid = cc.Zaloguj(apiKey.Key);
            Console.WriteLine("Zaloguj " + sid);

            OperationContextScope scope = new OperationContextScope(cc.InnerChannel);

            HttpRequestMessageProperty reqProps = new HttpRequestMessageProperty();
            reqProps.Headers.Add("sid", sid);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = reqProps;
            return cc;
        }

        public static WSHttpBinding Binding()
        {
            //create binding
            WSHttpBinding myBinding = new WSHttpBinding();
            myBinding.Security.Mode = SecurityMode.Transport;
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            myBinding.MessageEncoding = WSMessageEncoding.Mtom;
            return myBinding;
        }


        static void Main(string[] args)
        {

        }
    }
}
