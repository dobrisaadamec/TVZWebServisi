﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Citus.Education.WebApp.Sample.Web.WebAPIClient.Models
{
    public partial class RegisterBindingModel
    {
        private string _confirmPassword;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ConfirmPassword
        {
            get { return this._confirmPassword; }
            set { this._confirmPassword = value; }
        }
        
        private string _email;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        
        private string _password;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RegisterBindingModel class.
        /// </summary>
        public RegisterBindingModel()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RegisterBindingModel class with
        /// required arguments.
        /// </summary>
        public RegisterBindingModel(string email, string password)
            : this()
        {
            if (email == null)
            {
                throw new ArgumentNullException("email");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            this.Email = email;
            this.Password = password;
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type RegisterBindingModel
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Email == null)
            {
                throw new ArgumentNullException("Email");
            }
            if (this.Password == null)
            {
                throw new ArgumentNullException("Password");
            }
            if (this.ConfirmPassword != null)
            {
                outputObject["ConfirmPassword"] = this.ConfirmPassword;
            }
            if (this.Email != null)
            {
                outputObject["Email"] = this.Email;
            }
            if (this.Password != null)
            {
                outputObject["Password"] = this.Password;
            }
            return outputObject;
        }
    }
}
