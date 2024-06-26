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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAccessPolicy Request Marshaller
    /// </summary>       
    public class UpdateAccessPolicyRequestMarshaller : IMarshaller<IRequest, UpdateAccessPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAccessPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAccessPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAccessPolicyId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field AccessPolicyId set");
            request.AddPathResource("{accessPolicyId}", StringUtils.FromString(publicRequest.AccessPolicyId));
            request.ResourcePath = "/access-policies/{accessPolicyId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessPolicyIdentity())
                {
                    context.Writer.WritePropertyName("accessPolicyIdentity");
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentityMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessPolicyIdentity, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAccessPolicyPermission())
                {
                    context.Writer.WritePropertyName("accessPolicyPermission");
                    context.Writer.Write(publicRequest.AccessPolicyPermission);
                }

                if(publicRequest.IsSetAccessPolicyResource())
                {
                    context.Writer.WritePropertyName("accessPolicyResource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessPolicyResource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"monitor.";

            return request;
        }
        private static UpdateAccessPolicyRequestMarshaller _instance = new UpdateAccessPolicyRequestMarshaller();        

        internal static UpdateAccessPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAccessPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618