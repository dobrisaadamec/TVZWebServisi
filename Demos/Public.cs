﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesWS.ServiceSOAP
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MoviesWS.ServiceSOAP")]
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
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPublic")]
public interface IPublic
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/GetMovieName", ReplyAction="http://tempuri.org/IPublic/GetMovieNameResponse")]
    string GetMovieName(int Id, string Search);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/GetMovie2", ReplyAction="http://tempuri.org/IPublic/GetMovie2Response")]
    MoviesWS.ServiceSOAP.Movie GetMovie2(int Id, string Search);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublic/OrderMovie", ReplyAction="http://tempuri.org/IPublic/OrderMovieResponse")]
    bool OrderMovie(MoviesWS.ServiceSOAP.Movie Id);
}