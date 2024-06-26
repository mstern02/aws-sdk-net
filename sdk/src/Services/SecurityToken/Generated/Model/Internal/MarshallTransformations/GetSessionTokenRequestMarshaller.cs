/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityToken.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSessionToken Request Marshaller
    /// </summary>       
    public class GetSessionTokenRequestMarshaller : IMarshaller<IRequest, GetSessionTokenRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSessionTokenRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSessionTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityToken");
            request.Parameters.Add("Action", "GetSessionToken");
            request.Parameters.Add("Version", "2011-06-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDurationSeconds())
                {
                    request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSerialNumber())
                {
                    request.Parameters.Add("SerialNumber", StringUtils.FromString(publicRequest.SerialNumber));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTokenCode())
                {
                    request.Parameters.Add("TokenCode", StringUtils.FromString(publicRequest.TokenCode));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static GetSessionTokenRequestMarshaller _instance = new GetSessionTokenRequestMarshaller();        

        internal static GetSessionTokenRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSessionTokenRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}