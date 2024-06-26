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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplicationVersion Request Marshaller
    /// </summary>       
    public class CreateApplicationVersionRequestMarshaller : IMarshaller<IRequest, CreateApplicationVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApplicationVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServerlessApplicationRepository");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonServerlessApplicationRepositoryException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            if (!publicRequest.IsSetSemanticVersion())
                throw new AmazonServerlessApplicationRepositoryException("Request object does not have required field SemanticVersion set");
            request.AddPathResource("{semanticVersion}", StringUtils.FromString(publicRequest.SemanticVersion));
            request.ResourcePath = "/applications/{applicationId}/versions/{semanticVersion}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSourceCodeArchiveUrl())
                {
                    context.Writer.WritePropertyName("sourceCodeArchiveUrl");
                    context.Writer.Write(publicRequest.SourceCodeArchiveUrl);
                }

                if(publicRequest.IsSetSourceCodeUrl())
                {
                    context.Writer.WritePropertyName("sourceCodeUrl");
                    context.Writer.Write(publicRequest.SourceCodeUrl);
                }

                if(publicRequest.IsSetTemplateBody())
                {
                    context.Writer.WritePropertyName("templateBody");
                    context.Writer.Write(publicRequest.TemplateBody);
                }

                if(publicRequest.IsSetTemplateUrl())
                {
                    context.Writer.WritePropertyName("templateUrl");
                    context.Writer.Write(publicRequest.TemplateUrl);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateApplicationVersionRequestMarshaller _instance = new CreateApplicationVersionRequestMarshaller();        

        internal static CreateApplicationVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618