﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Citus.Education.WebApp.Sample.Web.WebAPIClient;
using Citus.Education.WebApp.Sample.Web.WebAPIClient.Models;
using Microsoft.Rest;

namespace Citus.Education.WebApp.Sample.Web.WebAPIClient
{
    public static partial class CVExtensions
    {
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static object Delete(this ICV operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICV)s).DeleteAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> DeleteAsync(this ICV operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.DeleteWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        public static IList<CvCompetenceModel> Get(this ICV operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICV)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<CvCompetenceModel>> GetAsync(this ICV operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<Citus.Education.WebApp.Sample.Web.WebAPIClient.Models.CvCompetenceModel>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object Post(this ICV operations, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICV)s).PostAsync(value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PostAsync(this ICV operations, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PostWithOperationResponseAsync(value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object Put(this ICV operations, int id, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICV)s).PutAsync(id, value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Citus.Education.WebApp.Sample.Web.WebAPIClient.ICV.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutAsync(this ICV operations, int id, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutWithOperationResponseAsync(id, value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
