﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Citus.Education.WebApp.Sample.Web.WebAPIClient.Models
{
    public partial class ExternalLoginViewModel
    {
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _url;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ExternalLoginViewModel class.
        /// </summary>
        public ExternalLoginViewModel()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
                JToken stateValue = inputObject["State"];
                if (stateValue != null && stateValue.Type != JTokenType.Null)
                {
                    this.State = ((string)stateValue);
                }
                JToken urlValue = inputObject["Url"];
                if (urlValue != null && urlValue.Type != JTokenType.Null)
                {
                    this.Url = ((string)urlValue);
                }
            }
        }
    }
}