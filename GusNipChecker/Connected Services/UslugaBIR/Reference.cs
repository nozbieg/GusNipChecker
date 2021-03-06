﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GusNipChecker.UslugaBIR {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParametryWyszukiwania", Namespace="http://CIS/BIR/PUBL/2014/07/DataContract")]
    [System.SerializableAttribute()]
    public partial class ParametryWyszukiwania : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony14znField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony9znField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krs {
            get {
                return this.KrsField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsField, value) != true)) {
                    this.KrsField = value;
                    this.RaisePropertyChanged("Krs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krsy {
            get {
                return this.KrsyField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsyField, value) != true)) {
                    this.KrsyField = value;
                    this.RaisePropertyChanged("Krsy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nip {
            get {
                return this.NipField;
            }
            set {
                if ((object.ReferenceEquals(this.NipField, value) != true)) {
                    this.NipField = value;
                    this.RaisePropertyChanged("Nip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nipy {
            get {
                return this.NipyField;
            }
            set {
                if ((object.ReferenceEquals(this.NipyField, value) != true)) {
                    this.NipyField = value;
                    this.RaisePropertyChanged("Nipy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regon {
            get {
                return this.RegonField;
            }
            set {
                if ((object.ReferenceEquals(this.RegonField, value) != true)) {
                    this.RegonField = value;
                    this.RaisePropertyChanged("Regon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony14zn {
            get {
                return this.Regony14znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony14znField, value) != true)) {
                    this.Regony14znField = value;
                    this.RaisePropertyChanged("Regony14zn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony9zn {
            get {
                return this.Regony9znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony9znField, value) != true)) {
                    this.Regony9znField = value;
                    this.RaisePropertyChanged("Regony9zn");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UslugaBIR.IUslugaBIRzewnPubl")]
    public interface IUslugaBIRzewnPubl {
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/2014/07) komunikatu GetValueRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        GusNipChecker.UslugaBIR.GetValueResponse GetValue(GusNipChecker.UslugaBIR.GetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.GetValueResponse> GetValueAsync(GusNipChecker.UslugaBIR.GetValueRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu ZalogujRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        GusNipChecker.UslugaBIR.ZalogujResponse Zaloguj(GusNipChecker.UslugaBIR.ZalogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.ZalogujResponse> ZalogujAsync(GusNipChecker.UslugaBIR.ZalogujRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu WylogujRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        GusNipChecker.UslugaBIR.WylogujResponse Wyloguj(GusNipChecker.UslugaBIR.WylogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.WylogujResponse> WylogujAsync(GusNipChecker.UslugaBIR.WylogujRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DaneSzukajPodmiotyRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        GusNipChecker.UslugaBIR.DaneSzukajPodmiotyResponse DaneSzukajPodmioty(GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DanePobierzPelnyRaportRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        GusNipChecker.UslugaBIR.DanePobierzPelnyRaportResponse DanePobierzPelnyRaport(GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DanePobierzRaportZbiorczyRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyResponse DanePobierzRaportZbiorczy(GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pNazwaParametru;
        
        public GetValueRequest() {
        }
        
        public GetValueRequest(string pNazwaParametru) {
            this.pNazwaParametru = pNazwaParametru;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValueResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string GetValueResult;
        
        public GetValueResponse() {
        }
        
        public GetValueResponse(string GetValueResult) {
            this.GetValueResult = GetValueResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Zaloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pKluczUzytkownika;
        
        public ZalogujRequest() {
        }
        
        public ZalogujRequest(string pKluczUzytkownika) {
            this.pKluczUzytkownika = pKluczUzytkownika;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ZalogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string ZalogujResult;
        
        public ZalogujResponse() {
        }
        
        public ZalogujResponse(string ZalogujResult) {
            this.ZalogujResult = ZalogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Wyloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pIdentyfikatorSesji;
        
        public WylogujRequest() {
        }
        
        public WylogujRequest(string pIdentyfikatorSesji) {
            this.pIdentyfikatorSesji = pIdentyfikatorSesji;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WylogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public bool WylogujResult;
        
        public WylogujResponse() {
        }
        
        public WylogujResponse(bool WylogujResult) {
            this.WylogujResult = WylogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmioty", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public GusNipChecker.UslugaBIR.ParametryWyszukiwania pParametryWyszukiwania;
        
        public DaneSzukajPodmiotyRequest() {
        }
        
        public DaneSzukajPodmiotyRequest(GusNipChecker.UslugaBIR.ParametryWyszukiwania pParametryWyszukiwania) {
            this.pParametryWyszukiwania = pParametryWyszukiwania;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmiotyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DaneSzukajPodmiotyResult;
        
        public DaneSzukajPodmiotyResponse() {
        }
        
        public DaneSzukajPodmiotyResponse(string DaneSzukajPodmiotyResult) {
            this.DaneSzukajPodmiotyResult = DaneSzukajPodmiotyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaport", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pRegon;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzPelnyRaportRequest() {
        }
        
        public DanePobierzPelnyRaportRequest(string pRegon, string pNazwaRaportu) {
            this.pRegon = pRegon;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaportResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzPelnyRaportResult;
        
        public DanePobierzPelnyRaportResponse() {
        }
        
        public DanePobierzPelnyRaportResponse(string DanePobierzPelnyRaportResult) {
            this.DanePobierzPelnyRaportResult = DanePobierzPelnyRaportResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczy", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pDataRaportu;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzRaportZbiorczyRequest() {
        }
        
        public DanePobierzRaportZbiorczyRequest(string pDataRaportu, string pNazwaRaportu) {
            this.pDataRaportu = pDataRaportu;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzRaportZbiorczyResult;
        
        public DanePobierzRaportZbiorczyResponse() {
        }
        
        public DanePobierzRaportZbiorczyResponse(string DanePobierzRaportZbiorczyResult) {
            this.DanePobierzRaportZbiorczyResult = DanePobierzRaportZbiorczyResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUslugaBIRzewnPublChannel : GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UslugaBIRzewnPublClient : System.ServiceModel.ClientBase<GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl>, GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl {
        
        public UslugaBIRzewnPublClient() {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GusNipChecker.UslugaBIR.GetValueResponse GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.GetValue(GusNipChecker.UslugaBIR.GetValueRequest request) {
            return base.Channel.GetValue(request);
        }
        
        public string GetValue(string pNazwaParametru) {
            GusNipChecker.UslugaBIR.GetValueRequest inValue = new GusNipChecker.UslugaBIR.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            GusNipChecker.UslugaBIR.GetValueResponse retVal = ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).GetValue(inValue);
            return retVal.GetValueResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.GetValueResponse> GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.GetValueAsync(GusNipChecker.UslugaBIR.GetValueRequest request) {
            return base.Channel.GetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.GetValueResponse> GetValueAsync(string pNazwaParametru) {
            GusNipChecker.UslugaBIR.GetValueRequest inValue = new GusNipChecker.UslugaBIR.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            return ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).GetValueAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GusNipChecker.UslugaBIR.ZalogujResponse GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.Zaloguj(GusNipChecker.UslugaBIR.ZalogujRequest request) {
            return base.Channel.Zaloguj(request);
        }
        
        public string Zaloguj(string pKluczUzytkownika) {
            GusNipChecker.UslugaBIR.ZalogujRequest inValue = new GusNipChecker.UslugaBIR.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            GusNipChecker.UslugaBIR.ZalogujResponse retVal = ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).Zaloguj(inValue);
            return retVal.ZalogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.ZalogujResponse> GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.ZalogujAsync(GusNipChecker.UslugaBIR.ZalogujRequest request) {
            return base.Channel.ZalogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.ZalogujResponse> ZalogujAsync(string pKluczUzytkownika) {
            GusNipChecker.UslugaBIR.ZalogujRequest inValue = new GusNipChecker.UslugaBIR.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            return ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).ZalogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GusNipChecker.UslugaBIR.WylogujResponse GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.Wyloguj(GusNipChecker.UslugaBIR.WylogujRequest request) {
            return base.Channel.Wyloguj(request);
        }
        
        public bool Wyloguj(string pIdentyfikatorSesji) {
            GusNipChecker.UslugaBIR.WylogujRequest inValue = new GusNipChecker.UslugaBIR.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            GusNipChecker.UslugaBIR.WylogujResponse retVal = ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).Wyloguj(inValue);
            return retVal.WylogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.WylogujResponse> GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.WylogujAsync(GusNipChecker.UslugaBIR.WylogujRequest request) {
            return base.Channel.WylogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.WylogujResponse> WylogujAsync(string pIdentyfikatorSesji) {
            GusNipChecker.UslugaBIR.WylogujRequest inValue = new GusNipChecker.UslugaBIR.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            return ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).WylogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GusNipChecker.UslugaBIR.DaneSzukajPodmiotyResponse GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.DaneSzukajPodmioty(GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest request) {
            return base.Channel.DaneSzukajPodmioty(request);
        }
        
        public string DaneSzukajPodmioty(GusNipChecker.UslugaBIR.ParametryWyszukiwania pParametryWyszukiwania) {
            GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest inValue = new GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            GusNipChecker.UslugaBIR.DaneSzukajPodmiotyResponse retVal = ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmioty(inValue);
            return retVal.DaneSzukajPodmiotyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DaneSzukajPodmiotyResponse> GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.DaneSzukajPodmiotyAsync(GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest request) {
            return base.Channel.DaneSzukajPodmiotyAsync(request);
        }
        
        public System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(GusNipChecker.UslugaBIR.ParametryWyszukiwania pParametryWyszukiwania) {
            GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest inValue = new GusNipChecker.UslugaBIR.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            return ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmiotyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GusNipChecker.UslugaBIR.DanePobierzPelnyRaportResponse GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.DanePobierzPelnyRaport(GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest request) {
            return base.Channel.DanePobierzPelnyRaport(request);
        }
        
        public string DanePobierzPelnyRaport(string pRegon, string pNazwaRaportu) {
            GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest inValue = new GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            GusNipChecker.UslugaBIR.DanePobierzPelnyRaportResponse retVal = ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaport(inValue);
            return retVal.DanePobierzPelnyRaportResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DanePobierzPelnyRaportResponse> GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.DanePobierzPelnyRaportAsync(GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest request) {
            return base.Channel.DanePobierzPelnyRaportAsync(request);
        }
        
        public System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(string pRegon, string pNazwaRaportu) {
            GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest inValue = new GusNipChecker.UslugaBIR.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaportAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyResponse GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczy(GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest request) {
            return base.Channel.DanePobierzRaportZbiorczy(request);
        }
        
        public string DanePobierzRaportZbiorczy(string pDataRaportu, string pNazwaRaportu) {
            GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest inValue = new GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyResponse retVal = ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczy(inValue);
            return retVal.DanePobierzRaportZbiorczyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyResponse> GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczyAsync(GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest request) {
            return base.Channel.DanePobierzRaportZbiorczyAsync(request);
        }
        
        public System.Threading.Tasks.Task<GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(string pDataRaportu, string pNazwaRaportu) {
            GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest inValue = new GusNipChecker.UslugaBIR.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((GusNipChecker.UslugaBIR.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczyAsync(inValue);
        }
    }
}
