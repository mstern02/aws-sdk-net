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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDomainEndpointOptions Request Marshaller
    /// </summary>       
    public class UpdateDomainEndpointOptionsRequestMarshaller : IMarshaller<IRequest, UpdateDomainEndpointOptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDomainEndpointOptionsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDomainEndpointOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearch");
            request.Parameters.Add("Action", "UpdateDomainEndpointOptions");
            request.Parameters.Add("Version", "2013-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainEndpointOptions())
                {
                    if(publicRequest.DomainEndpointOptions.IsSetEnforceHTTPS())
                    {
                        request.Parameters.Add("DomainEndpointOptions" + "." + "EnforceHTTPS", StringUtils.FromBool(publicRequest.DomainEndpointOptions.EnforceHTTPS));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DomainEndpointOptions.IsSetTLSSecurityPolicy())
                    {
                        request.Parameters.Add("DomainEndpointOptions" + "." + "TLSSecurityPolicy", StringUtils.FromString(publicRequest.DomainEndpointOptions.TLSSecurityPolicy));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static UpdateDomainEndpointOptionsRequestMarshaller _instance = new UpdateDomainEndpointOptionsRequestMarshaller();        

        internal static UpdateDomainEndpointOptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDomainEndpointOptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}