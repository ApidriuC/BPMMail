﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPMMail
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaEnvio", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class RespuestaEnvio : object
    {
        
        private long idEnvioField;
        
        private string mensajeField;
        
        private string mensajeServicioField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long idEnvio
        {
            get
            {
                return this.idEnvioField;
            }
            set
            {
                this.idEnvioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string mensaje
        {
            get
            {
                return this.mensajeField;
            }
            set
            {
                this.mensajeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string mensajeServicio
        {
            get
            {
                return this.mensajeServicioField;
            }
            set
            {
                this.mensajeServicioField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Adjunto", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class Adjunto : object
    {
        
        private byte[] contenidoField;
        
        private string nombAdjuntoField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] contenido
        {
            get
            {
                return this.contenidoField;
            }
            set
            {
                this.contenidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string nombAdjunto
        {
            get
            {
                return this.nombAdjuntoField;
            }
            set
            {
                this.nombAdjuntoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BPMMail.IBPMMailService")]
    public interface IBPMMailService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBPMMailService/EnviarCorreo", ReplyAction="http://tempuri.org/IBPMMailService/EnviarCorreoResponse")]
        System.Threading.Tasks.Task<BPMMail.RespuestaEnvio> EnviarCorreoAsync(
                    int cuenta, 
                    int id_producto, 
                    int proyecto, 
                    int aplicacion, 
                    int tipoEnvio, 
                    string asunto, 
                    string mensaje, 
                    string nombAdjunto1, 
                    byte[] adjunto1, 
                    string nombAdjunto2, 
                    byte[] adjunto2, 
                    long idUsuaCre, 
                    string ipOrigen, 
                    string correoDest, 
                    long idRefClie, 
                    string optXmlCorreos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBPMMailService/getRutas", ReplyAction="http://tempuri.org/IBPMMailService/getRutasResponse")]
        System.Threading.Tasks.Task<string> getRutasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBPMMailService/validaCorreo", ReplyAction="http://tempuri.org/IBPMMailService/validaCorreoResponse")]
        System.Threading.Tasks.Task<string> validaCorreoAsync(string direccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBPMMailService/getServiciosEnvio", ReplyAction="http://tempuri.org/IBPMMailService/getServiciosEnvioResponse")]
        System.Threading.Tasks.Task<string> getServiciosEnvioAsync(string llaveCons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBPMMailService/EnviarCorreoAdjuntos", ReplyAction="http://tempuri.org/IBPMMailService/EnviarCorreoAdjuntosResponse")]
        System.Threading.Tasks.Task<BPMMail.RespuestaEnvio> EnviarCorreoAdjuntosAsync(int cuenta, int id_producto, int proyecto, int aplicacion, int tipoEnvio, string asunto, string mensaje, BPMMail.Adjunto[] adjuntos, long idUsuaCre, string ipOrigen, string correoDest, long idRefClie, string optXmlCorreos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBPMMailService/EnviarCorreoEML", ReplyAction="http://tempuri.org/IBPMMailService/EnviarCorreoEMLResponse")]
        System.Threading.Tasks.Task<BPMMail.RespuestaEnvio> EnviarCorreoEMLAsync(
                    int cuenta, 
                    int id_producto, 
                    int proyecto, 
                    int aplicacion, 
                    int tipoEnvio, 
                    string asunto, 
                    string mensaje, 
                    string nombAdjunto1, 
                    byte[] adjunto1, 
                    string nombAdjunto2, 
                    byte[] adjunto2, 
                    long idUsuaCre, 
                    string ipOrigen, 
                    string correoDest, 
                    long idRefClie, 
                    string optXmlCorreos, 
                    int generaEML);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IBPMMailServiceChannel : BPMMail.IBPMMailService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class BPMMailServiceClient : System.ServiceModel.ClientBase<BPMMail.IBPMMailService>, BPMMail.IBPMMailService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BPMMailServiceClient() : 
                base(BPMMailServiceClient.GetDefaultBinding(), BPMMailServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IBPMMailService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BPMMailServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BPMMailServiceClient.GetBindingForEndpoint(endpointConfiguration), BPMMailServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BPMMailServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BPMMailServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BPMMailServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BPMMailServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BPMMailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<BPMMail.RespuestaEnvio> EnviarCorreoAsync(
                    int cuenta, 
                    int id_producto, 
                    int proyecto, 
                    int aplicacion, 
                    int tipoEnvio, 
                    string asunto, 
                    string mensaje, 
                    string nombAdjunto1, 
                    byte[] adjunto1, 
                    string nombAdjunto2, 
                    byte[] adjunto2, 
                    long idUsuaCre, 
                    string ipOrigen, 
                    string correoDest, 
                    long idRefClie, 
                    string optXmlCorreos)
        {
            return base.Channel.EnviarCorreoAsync(cuenta, id_producto, proyecto, aplicacion, tipoEnvio, asunto, mensaje, nombAdjunto1, adjunto1, nombAdjunto2, adjunto2, idUsuaCre, ipOrigen, correoDest, idRefClie, optXmlCorreos);
        }
        
        public System.Threading.Tasks.Task<string> getRutasAsync()
        {
            return base.Channel.getRutasAsync();
        }
        
        public System.Threading.Tasks.Task<string> validaCorreoAsync(string direccion)
        {
            return base.Channel.validaCorreoAsync(direccion);
        }
        
        public System.Threading.Tasks.Task<string> getServiciosEnvioAsync(string llaveCons)
        {
            return base.Channel.getServiciosEnvioAsync(llaveCons);
        }
        
        public System.Threading.Tasks.Task<BPMMail.RespuestaEnvio> EnviarCorreoAdjuntosAsync(int cuenta, int id_producto, int proyecto, int aplicacion, int tipoEnvio, string asunto, string mensaje, BPMMail.Adjunto[] adjuntos, long idUsuaCre, string ipOrigen, string correoDest, long idRefClie, string optXmlCorreos)
        {
            return base.Channel.EnviarCorreoAdjuntosAsync(cuenta, id_producto, proyecto, aplicacion, tipoEnvio, asunto, mensaje, adjuntos, idUsuaCre, ipOrigen, correoDest, idRefClie, optXmlCorreos);
        }
        
        public System.Threading.Tasks.Task<BPMMail.RespuestaEnvio> EnviarCorreoEMLAsync(
                    int cuenta, 
                    int id_producto, 
                    int proyecto, 
                    int aplicacion, 
                    int tipoEnvio, 
                    string asunto, 
                    string mensaje, 
                    string nombAdjunto1, 
                    byte[] adjunto1, 
                    string nombAdjunto2, 
                    byte[] adjunto2, 
                    long idUsuaCre, 
                    string ipOrigen, 
                    string correoDest, 
                    long idRefClie, 
                    string optXmlCorreos, 
                    int generaEML)
        {
            return base.Channel.EnviarCorreoEMLAsync(cuenta, id_producto, proyecto, aplicacion, tipoEnvio, asunto, mensaje, nombAdjunto1, adjunto1, nombAdjunto2, adjunto2, idUsuaCre, ipOrigen, correoDest, idRefClie, optXmlCorreos, generaEML);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBPMMailService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBPMMailService))
            {
                return new System.ServiceModel.EndpointAddress("http://servicesbpm.sycpruebas.com/wsBPMMAILPRUEBAS/BPMMailService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BPMMailServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IBPMMailService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BPMMailServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IBPMMailService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IBPMMailService,
        }
    }
}
