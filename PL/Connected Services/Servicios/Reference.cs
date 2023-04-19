﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.Servicios {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servicios.IOperacionesServices")]
    public interface IOperacionesServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Suma", ReplyAction="http://tempuri.org/IOperacionesServices/SumaResponse")]
        int Suma(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Suma", ReplyAction="http://tempuri.org/IOperacionesServices/SumaResponse")]
        System.Threading.Tasks.Task<int> SumaAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Resta", ReplyAction="http://tempuri.org/IOperacionesServices/RestaResponse")]
        int Resta(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Resta", ReplyAction="http://tempuri.org/IOperacionesServices/RestaResponse")]
        System.Threading.Tasks.Task<int> RestaAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Multiplicacion", ReplyAction="http://tempuri.org/IOperacionesServices/MultiplicacionResponse")]
        int Multiplicacion(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Multiplicacion", ReplyAction="http://tempuri.org/IOperacionesServices/MultiplicacionResponse")]
        System.Threading.Tasks.Task<int> MultiplicacionAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Division", ReplyAction="http://tempuri.org/IOperacionesServices/DivisionResponse")]
        double Division(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesServices/Division", ReplyAction="http://tempuri.org/IOperacionesServices/DivisionResponse")]
        System.Threading.Tasks.Task<double> DivisionAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOperacionesServicesChannel : PL.Servicios.IOperacionesServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OperacionesServicesClient : System.ServiceModel.ClientBase<PL.Servicios.IOperacionesServices>, PL.Servicios.IOperacionesServices {
        
        public OperacionesServicesClient() {
        }
        
        public OperacionesServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OperacionesServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Suma(int a, int b) {
            return base.Channel.Suma(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumaAsync(int a, int b) {
            return base.Channel.SumaAsync(a, b);
        }
        
        public int Resta(int a, int b) {
            return base.Channel.Resta(a, b);
        }
        
        public System.Threading.Tasks.Task<int> RestaAsync(int a, int b) {
            return base.Channel.RestaAsync(a, b);
        }
        
        public int Multiplicacion(int a, int b) {
            return base.Channel.Multiplicacion(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicacionAsync(int a, int b) {
            return base.Channel.MultiplicacionAsync(a, b);
        }
        
        public double Division(int a, int b) {
            return base.Channel.Division(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(int a, int b) {
            return base.Channel.DivisionAsync(a, b);
        }
    }
}