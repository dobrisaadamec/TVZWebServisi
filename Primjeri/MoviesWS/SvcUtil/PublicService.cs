﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesWS.Contracts
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MoviesWS.Contracts")]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string NameField;
        
        private int YearField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year
        {
            get
            {
                return this.YearField;
            }
            set
            {
                this.YearField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPublicService")]
public interface IPublicService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublicService/GetMovie", ReplyAction="http://tempuri.org/IPublicService/GetMovieResponse")]
    MoviesWS.Contracts.Movie GetMovie(int Id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublicService/GetMovie", ReplyAction="http://tempuri.org/IPublicService/GetMovieResponse")]
    System.Threading.Tasks.Task<MoviesWS.Contracts.Movie> GetMovieAsync(int Id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPublicServiceChannel : IPublicService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PublicServiceClient : System.ServiceModel.ClientBase<IPublicService>, IPublicService
{
    
    public PublicServiceClient()
    {
    }
    
    public PublicServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PublicServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PublicServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PublicServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public MoviesWS.Contracts.Movie GetMovie(int Id)
    {
        return base.Channel.GetMovie(Id);
    }
    
    public System.Threading.Tasks.Task<MoviesWS.Contracts.Movie> GetMovieAsync(int Id)
    {
        return base.Channel.GetMovieAsync(Id);
    }
}
