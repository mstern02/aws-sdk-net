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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLaunchProfile Request Marshaller
    /// </summary>       
    public class CreateLaunchProfileRequestMarshaller : IMarshaller<IRequest, CreateLaunchProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLaunchProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLaunchProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NimbleStudio");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetStudioId())
                throw new AmazonNimbleStudioException("Request object does not have required field StudioId set");
            request.AddPathResource("{studioId}", StringUtils.FromString(publicRequest.StudioId));
            request.ResourcePath = "/2020-08-01/studios/{studioId}/launch-profiles";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEc2SubnetIds())
                {
                    context.Writer.WritePropertyName("ec2SubnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEc2SubnetIdsListValue in publicRequest.Ec2SubnetIds)
                    {
                            context.Writer.Write(publicRequestEc2SubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLaunchProfileProtocolVersions())
                {
                    context.Writer.WritePropertyName("launchProfileProtocolVersions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLaunchProfileProtocolVersionsListValue in publicRequest.LaunchProfileProtocolVersions)
                    {
                            context.Writer.Write(publicRequestLaunchProfileProtocolVersionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetStreamConfiguration())
                {
                    context.Writer.WritePropertyName("streamConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = StreamConfigurationCreateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StreamConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStudioComponentIds())
                {
                    context.Writer.WritePropertyName("studioComponentIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStudioComponentIdsListValue in publicRequest.StudioComponentIds)
                    {
                            context.Writer.Write(publicRequestStudioComponentIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static CreateLaunchProfileRequestMarshaller _instance = new CreateLaunchProfileRequestMarshaller();        

        internal static CreateLaunchProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLaunchProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618