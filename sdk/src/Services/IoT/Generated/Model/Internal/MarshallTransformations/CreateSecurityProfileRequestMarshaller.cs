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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSecurityProfile Request Marshaller
    /// </summary>       
    public class CreateSecurityProfileRequestMarshaller : IMarshaller<IRequest, CreateSecurityProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSecurityProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSecurityProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSecurityProfileName())
                throw new AmazonIoTException("Request object does not have required field SecurityProfileName set");
            request.AddPathResource("{securityProfileName}", StringUtils.FromString(publicRequest.SecurityProfileName));
            request.ResourcePath = "/security-profiles/{securityProfileName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalMetricsToRetain())
                {
                    context.Writer.WritePropertyName("additionalMetricsToRetain");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalMetricsToRetainListValue in publicRequest.AdditionalMetricsToRetain)
                    {
                            context.Writer.Write(publicRequestAdditionalMetricsToRetainListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAdditionalMetricsToRetainV2())
                {
                    context.Writer.WritePropertyName("additionalMetricsToRetainV2");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalMetricsToRetainV2ListValue in publicRequest.AdditionalMetricsToRetainV2)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricToRetainMarshaller.Instance;
                        marshaller.Marshall(publicRequestAdditionalMetricsToRetainV2ListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAlertTargets())
                {
                    context.Writer.WritePropertyName("alertTargets");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAlertTargetsKvp in publicRequest.AlertTargets)
                    {
                        context.Writer.WritePropertyName(publicRequestAlertTargetsKvp.Key);
                        var publicRequestAlertTargetsValue = publicRequestAlertTargetsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = AlertTargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestAlertTargetsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBehaviors())
                {
                    context.Writer.WritePropertyName("behaviors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBehaviorsListValue in publicRequest.Behaviors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BehaviorMarshaller.Instance;
                        marshaller.Marshall(publicRequestBehaviorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetricsExportConfig())
                {
                    context.Writer.WritePropertyName("metricsExportConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricsExportConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricsExportConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSecurityProfileDescription())
                {
                    context.Writer.WritePropertyName("securityProfileDescription");
                    context.Writer.Write(publicRequest.SecurityProfileDescription);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSecurityProfileRequestMarshaller _instance = new CreateSecurityProfileRequestMarshaller();        

        internal static CreateSecurityProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSecurityProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618