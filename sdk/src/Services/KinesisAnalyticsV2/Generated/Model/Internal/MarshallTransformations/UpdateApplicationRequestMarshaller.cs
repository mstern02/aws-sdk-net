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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplication Request Marshaller
    /// </summary>       
    public class UpdateApplicationRequestMarshaller : IMarshaller<IRequest, UpdateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisAnalyticsV2");
            string target = "KinesisAnalytics_20180523.UpdateApplication";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationConfigurationUpdate())
                {
                    context.Writer.WritePropertyName("ApplicationConfigurationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = ApplicationConfigurationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationConfigurationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApplicationName())
                {
                    context.Writer.WritePropertyName("ApplicationName");
                    context.Writer.Write(publicRequest.ApplicationName);
                }

                if(publicRequest.IsSetCloudWatchLoggingOptionUpdates())
                {
                    context.Writer.WritePropertyName("CloudWatchLoggingOptionUpdates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCloudWatchLoggingOptionUpdatesListValue in publicRequest.CloudWatchLoggingOptionUpdates)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CloudWatchLoggingOptionUpdateMarshaller.Instance;
                        marshaller.Marshall(publicRequestCloudWatchLoggingOptionUpdatesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetConditionalToken())
                {
                    context.Writer.WritePropertyName("ConditionalToken");
                    context.Writer.Write(publicRequest.ConditionalToken);
                }

                if(publicRequest.IsSetCurrentApplicationVersionId())
                {
                    context.Writer.WritePropertyName("CurrentApplicationVersionId");
                    context.Writer.Write(publicRequest.CurrentApplicationVersionId);
                }

                if(publicRequest.IsSetRunConfigurationUpdate())
                {
                    context.Writer.WritePropertyName("RunConfigurationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = RunConfigurationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RunConfigurationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRuntimeEnvironmentUpdate())
                {
                    context.Writer.WritePropertyName("RuntimeEnvironmentUpdate");
                    context.Writer.Write(publicRequest.RuntimeEnvironmentUpdate);
                }

                if(publicRequest.IsSetServiceExecutionRoleUpdate())
                {
                    context.Writer.WritePropertyName("ServiceExecutionRoleUpdate");
                    context.Writer.Write(publicRequest.ServiceExecutionRoleUpdate);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateApplicationRequestMarshaller _instance = new UpdateApplicationRequestMarshaller();        

        internal static UpdateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618