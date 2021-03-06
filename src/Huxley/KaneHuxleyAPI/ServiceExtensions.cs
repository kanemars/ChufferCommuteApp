﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace KaneHuxleyAPI
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Service.
    /// </summary>
    public static partial class ServiceExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceid'>
            /// </param>
            /// <param name='serviceid1'>
            /// </param>
            /// <param name='accesstoken'>
            /// </param>
            public static object GetByserviceidserviceidaccesstoken(this IService operations, string serviceid, string serviceid1 = default(string), string accesstoken = default(string))
            {
                return Task.Factory.StartNew(s => ((IService)s).GetByserviceidserviceidaccesstokenAsync(serviceid, serviceid1, accesstoken), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceid'>
            /// </param>
            /// <param name='serviceid1'>
            /// </param>
            /// <param name='accesstoken'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetByserviceidserviceidaccesstokenAsync(this IService operations, string serviceid, string serviceid1 = default(string), string accesstoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByserviceidserviceidaccesstokenWithHttpMessagesAsync(serviceid, serviceid1, accesstoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
