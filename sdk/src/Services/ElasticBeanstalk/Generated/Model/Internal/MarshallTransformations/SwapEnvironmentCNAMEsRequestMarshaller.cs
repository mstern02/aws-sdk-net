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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SwapEnvironmentCNAMEs Request Marshaller
    /// </summary>       
    public class SwapEnvironmentCNAMEsRequestMarshaller : IMarshaller<IRequest, SwapEnvironmentCNAMEsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SwapEnvironmentCNAMEsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SwapEnvironmentCNAMEsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "SwapEnvironmentCNAMEs");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDestinationEnvironmentId())
                {
                    request.Parameters.Add("DestinationEnvironmentId", StringUtils.FromString(publicRequest.DestinationEnvironmentId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDestinationEnvironmentName())
                {
                    request.Parameters.Add("DestinationEnvironmentName", StringUtils.FromString(publicRequest.DestinationEnvironmentName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourceEnvironmentId())
                {
                    request.Parameters.Add("SourceEnvironmentId", StringUtils.FromString(publicRequest.SourceEnvironmentId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourceEnvironmentName())
                {
                    request.Parameters.Add("SourceEnvironmentName", StringUtils.FromString(publicRequest.SourceEnvironmentName));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static SwapEnvironmentCNAMEsRequestMarshaller _instance = new SwapEnvironmentCNAMEsRequestMarshaller();        

        internal static SwapEnvironmentCNAMEsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SwapEnvironmentCNAMEsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}