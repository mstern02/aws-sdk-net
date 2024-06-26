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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCase Request Marshaller
    /// </summary>       
    public class UpdateCaseRequestMarshaller : IMarshaller<IRequest, UpdateCaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCases");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-03";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetCaseId())
                throw new AmazonConnectCasesException("Request object does not have required field CaseId set");
            request.AddPathResource("{caseId}", StringUtils.FromString(publicRequest.CaseId));
            if (!publicRequest.IsSetDomainId())
                throw new AmazonConnectCasesException("Request object does not have required field DomainId set");
            request.AddPathResource("{domainId}", StringUtils.FromString(publicRequest.DomainId));
            request.ResourcePath = "/domains/{domainId}/cases/{caseId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFields())
                {
                    context.Writer.WritePropertyName("fields");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFieldsListValue in publicRequest.Fields)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FieldValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestFieldsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPerformedBy())
                {
                    context.Writer.WritePropertyName("performedBy");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserUnionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PerformedBy, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateCaseRequestMarshaller _instance = new UpdateCaseRequestMarshaller();        

        internal static UpdateCaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618