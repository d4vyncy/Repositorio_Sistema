﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneradorCodigoControladoras.srRegistro {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsBoletaBE", Namespace="http://schemas.datacontract.org/2004/07/WcfRegistro.Entidades")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GeneradorCodigoControladoras.srRegistro.clsBoletaDA))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GeneradorCodigoControladoras.srRegistro.clsBoleta))]
    public partial class clsBoletaBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaEscaneoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBoletaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextoBoletaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UsuarioEscaneoField;
        
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
        public System.DateTime FechaEscaneo {
            get {
                return this.FechaEscaneoField;
            }
            set {
                if ((this.FechaEscaneoField.Equals(value) != true)) {
                    this.FechaEscaneoField = value;
                    this.RaisePropertyChanged("FechaEscaneo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBoleta {
            get {
                return this.IdBoletaField;
            }
            set {
                if ((this.IdBoletaField.Equals(value) != true)) {
                    this.IdBoletaField = value;
                    this.RaisePropertyChanged("IdBoleta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TextoBoleta {
            get {
                return this.TextoBoletaField;
            }
            set {
                if ((object.ReferenceEquals(this.TextoBoletaField, value) != true)) {
                    this.TextoBoletaField = value;
                    this.RaisePropertyChanged("TextoBoleta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UsuarioEscaneo {
            get {
                return this.UsuarioEscaneoField;
            }
            set {
                if ((this.UsuarioEscaneoField.Equals(value) != true)) {
                    this.UsuarioEscaneoField = value;
                    this.RaisePropertyChanged("UsuarioEscaneo");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsBoletaDA", Namespace="http://schemas.datacontract.org/2004/07/WcfRegistro.Datos")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GeneradorCodigoControladoras.srRegistro.clsBoleta))]
    public partial class clsBoletaDA : GeneradorCodigoControladoras.srRegistro.clsBoletaBE {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsBoleta", Namespace="http://schemas.datacontract.org/2004/07/WcfRegistro.Negocios")]
    [System.SerializableAttribute()]
    public partial class clsBoleta : GeneradorCodigoControladoras.srRegistro.clsBoletaDA {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srRegistro.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ProcedureConParametro", ReplyAction="http://tempuri.org/IService1/ProcedureConParametroResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GeneradorCodigoControladoras.srRegistro.clsBoletaBE))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GeneradorCodigoControladoras.srRegistro.clsBoletaDA))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GeneradorCodigoControladoras.srRegistro.clsBoleta))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        System.Data.DataSet ProcedureConParametro(string Procedimiento, object[] pParametros);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ProcedureParametro", ReplyAction="http://tempuri.org/IService1/ProcedureParametroResponse")]
        System.Data.DataSet ProcedureParametro(
                    string Procedimiento, 
                    string Campo, 
                    string Valor, 
                    string Campo1, 
                    string Valor1, 
                    string Campo2, 
                    string Valor2, 
                    string Campo3, 
                    string Valor3, 
                    string Campo4, 
                    string Valor4, 
                    string Campo5, 
                    string Valor5, 
                    string Campo6, 
                    string Valor6, 
                    string Campo7, 
                    string Valor7);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EjecutaConsulta", ReplyAction="http://tempuri.org/IService1/EjecutaConsultaResponse")]
        int EjecutaConsulta(string Consulta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtieneBoleta", ReplyAction="http://tempuri.org/IService1/ObtieneBoletaResponse")]
        GeneradorCodigoControladoras.srRegistro.clsBoleta ObtieneBoleta(int IdBoleta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregaBoleta", ReplyAction="http://tempuri.org/IService1/AgregaBoletaResponse")]
        int AgregaBoleta(GeneradorCodigoControladoras.srRegistro.clsBoleta oBoleta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificaBoleta", ReplyAction="http://tempuri.org/IService1/ModificaBoletaResponse")]
        int ModificaBoleta(GeneradorCodigoControladoras.srRegistro.clsBoleta oBoleta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminaBoleta", ReplyAction="http://tempuri.org/IService1/EliminaBoletaResponse")]
        int EliminaBoleta(int IdBoleta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtienepavBoleta1", ReplyAction="http://tempuri.org/IService1/ObtienepavBoleta1Response")]
        System.Data.DataSet ObtienepavBoleta1(string Campo, string Valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtienepavBoleta2", ReplyAction="http://tempuri.org/IService1/ObtienepavBoleta2Response")]
        System.Data.DataSet ObtienepavBoleta2(string Campo, string Valor, string Campo1, string Valor1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtienepavBoleta3", ReplyAction="http://tempuri.org/IService1/ObtienepavBoleta3Response")]
        System.Data.DataSet ObtienepavBoleta3(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtienepavBoleta4", ReplyAction="http://tempuri.org/IService1/ObtienepavBoleta4Response")]
        System.Data.DataSet ObtienepavBoleta4(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtienepavBoleta5", ReplyAction="http://tempuri.org/IService1/ObtienepavBoleta5Response")]
        System.Data.DataSet ObtienepavBoleta5(
                    string Campo, 
                    string Valor, 
                    string Campo1, 
                    string Valor1, 
                    string Campo2, 
                    string Valor2, 
                    string Campo3, 
                    string Valor3, 
                    string Campo4, 
                    string Valor4, 
                    string Campo5, 
                    string Valor5, 
                    string Campo6, 
                    string Valor6, 
                    string Campo7, 
                    string Valor7);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GeneradorCodigoControladoras.srRegistro.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GeneradorCodigoControladoras.srRegistro.IService1>, GeneradorCodigoControladoras.srRegistro.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ProcedureConParametro(string Procedimiento, object[] pParametros) {
            return base.Channel.ProcedureConParametro(Procedimiento, pParametros);
        }
        
        public System.Data.DataSet ProcedureParametro(
                    string Procedimiento, 
                    string Campo, 
                    string Valor, 
                    string Campo1, 
                    string Valor1, 
                    string Campo2, 
                    string Valor2, 
                    string Campo3, 
                    string Valor3, 
                    string Campo4, 
                    string Valor4, 
                    string Campo5, 
                    string Valor5, 
                    string Campo6, 
                    string Valor6, 
                    string Campo7, 
                    string Valor7) {
            return base.Channel.ProcedureParametro(Procedimiento, Campo, Valor, Campo1, Valor1, Campo2, Valor2, Campo3, Valor3, Campo4, Valor4, Campo5, Valor5, Campo6, Valor6, Campo7, Valor7);
        }
        
        public int EjecutaConsulta(string Consulta) {
            return base.Channel.EjecutaConsulta(Consulta);
        }
        
        public GeneradorCodigoControladoras.srRegistro.clsBoleta ObtieneBoleta(int IdBoleta) {
            return base.Channel.ObtieneBoleta(IdBoleta);
        }
        
        public int AgregaBoleta(GeneradorCodigoControladoras.srRegistro.clsBoleta oBoleta) {
            return base.Channel.AgregaBoleta(oBoleta);
        }
        
        public int ModificaBoleta(GeneradorCodigoControladoras.srRegistro.clsBoleta oBoleta) {
            return base.Channel.ModificaBoleta(oBoleta);
        }
        
        public int EliminaBoleta(int IdBoleta) {
            return base.Channel.EliminaBoleta(IdBoleta);
        }
        
        public System.Data.DataSet ObtienepavBoleta1(string Campo, string Valor) {
            return base.Channel.ObtienepavBoleta1(Campo, Valor);
        }
        
        public System.Data.DataSet ObtienepavBoleta2(string Campo, string Valor, string Campo1, string Valor1) {
            return base.Channel.ObtienepavBoleta2(Campo, Valor, Campo1, Valor1);
        }
        
        public System.Data.DataSet ObtienepavBoleta3(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2) {
            return base.Channel.ObtienepavBoleta3(Campo, Valor, Campo1, Valor1, Campo2, Valor2);
        }
        
        public System.Data.DataSet ObtienepavBoleta4(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3) {
            return base.Channel.ObtienepavBoleta4(Campo, Valor, Campo1, Valor1, Campo2, Valor2, Campo3, Valor3);
        }
        
        public System.Data.DataSet ObtienepavBoleta5(
                    string Campo, 
                    string Valor, 
                    string Campo1, 
                    string Valor1, 
                    string Campo2, 
                    string Valor2, 
                    string Campo3, 
                    string Valor3, 
                    string Campo4, 
                    string Valor4, 
                    string Campo5, 
                    string Valor5, 
                    string Campo6, 
                    string Valor6, 
                    string Campo7, 
                    string Valor7) {
            return base.Channel.ObtienepavBoleta5(Campo, Valor, Campo1, Valor1, Campo2, Valor2, Campo3, Valor3, Campo4, Valor4, Campo5, Valor5, Campo6, Valor6, Campo7, Valor7);
        }
    }
}
