﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesWS.ConsumerProxy.WSMovies {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MoviesWS.ServiceSOAP")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSMovies.IPublic")]
    public interface IPublic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/GetMovieName", ReplyAction="http://tempuri.org/IPublic/GetMovieNameResponse")]
        string GetMovieName(int Id, string Search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/GetMovieName", ReplyAction="http://tempuri.org/IPublic/GetMovieNameResponse")]
        System.Threading.Tasks.Task<string> GetMovieNameAsync(int Id, string Search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/GetMovie2", ReplyAction="http://tempuri.org/IPublic/GetMovie2Response")]
        MoviesWS.ConsumerProxy.WSMovies.Movie GetMovie2(int Id, string Search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/GetMovie2", ReplyAction="http://tempuri.org/IPublic/GetMovie2Response")]
        System.Threading.Tasks.Task<MoviesWS.ConsumerProxy.WSMovies.Movie> GetMovie2Async(int Id, string Search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/OrderMovie", ReplyAction="http://tempuri.org/IPublic/OrderMovieResponse")]
        bool OrderMovie(MoviesWS.ConsumerProxy.WSMovies.Movie Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/OrderMovie", ReplyAction="http://tempuri.org/IPublic/OrderMovieResponse")]
        System.Threading.Tasks.Task<bool> OrderMovieAsync(MoviesWS.ConsumerProxy.WSMovies.Movie Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublicChannel : MoviesWS.ConsumerProxy.WSMovies.IPublic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublicClient : System.ServiceModel.ClientBase<MoviesWS.ConsumerProxy.WSMovies.IPublic>, MoviesWS.ConsumerProxy.WSMovies.IPublic {
        
        public PublicClient() {
        }
        
        public PublicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PublicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMovieName(int Id, string Search) {
            return base.Channel.GetMovieName(Id, Search);
        }
        
        public System.Threading.Tasks.Task<string> GetMovieNameAsync(int Id, string Search) {
            return base.Channel.GetMovieNameAsync(Id, Search);
        }
        
        public MoviesWS.ConsumerProxy.WSMovies.Movie GetMovie2(int Id, string Search) {
            return base.Channel.GetMovie2(Id, Search);
        }
        
        public System.Threading.Tasks.Task<MoviesWS.ConsumerProxy.WSMovies.Movie> GetMovie2Async(int Id, string Search) {
            return base.Channel.GetMovie2Async(Id, Search);
        }
        
        public bool OrderMovie(MoviesWS.ConsumerProxy.WSMovies.Movie Id) {
            return base.Channel.OrderMovie(Id);
        }
        
        public System.Threading.Tasks.Task<bool> OrderMovieAsync(MoviesWS.ConsumerProxy.WSMovies.Movie Id) {
            return base.Channel.OrderMovieAsync(Id);
        }
    }
}
