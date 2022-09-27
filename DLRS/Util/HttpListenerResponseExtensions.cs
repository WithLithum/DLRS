using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DLRS.Util
{
    public static class HttpListenerResponseExtensions
    {
        /// <summary>
        /// Sets the status code of this instance to the specified <see cref="HttpStatusCode"/> value.
        /// </summary>
        /// <param name="response">The response instance.</param>
        /// <param name="statusCode">The status code to set to.</param>
        public static void StatusCode(this HttpListenerResponse response, HttpStatusCode statusCode)
        {
            response.StatusCode = (int)statusCode;
        }
    }
}