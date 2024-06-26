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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataset Request Marshaller
    /// </summary>       
    public class CreateDatasetRequestMarshaller : IMarshaller<IRequest, CreateDatasetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDatasetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDatasetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTAnalytics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/datasets";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActions())
                {
                    context.Writer.WritePropertyName("actions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActionsListValue in publicRequest.Actions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DatasetActionMarshaller.Instance;
                        marshaller.Marshall(publicRequestActionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetContentDeliveryRules())
                {
                    context.Writer.WritePropertyName("contentDeliveryRules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestContentDeliveryRulesListValue in publicRequest.ContentDeliveryRules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DatasetContentDeliveryRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestContentDeliveryRulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDatasetName())
                {
                    context.Writer.WritePropertyName("datasetName");
                    context.Writer.Write(publicRequest.DatasetName);
                }

                if(publicRequest.IsSetLateDataRules())
                {
                    context.Writer.WritePropertyName("lateDataRules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLateDataRulesListValue in publicRequest.LateDataRules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LateDataRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestLateDataRulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRetentionPeriod())
                {
                    context.Writer.WritePropertyName("retentionPeriod");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetentionPeriodMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetentionPeriod, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetTriggers())
                {
                    context.Writer.WritePropertyName("triggers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTriggersListValue in publicRequest.Triggers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DatasetTriggerMarshaller.Instance;
                        marshaller.Marshall(publicRequestTriggersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVersioningConfiguration())
                {
                    context.Writer.WritePropertyName("versioningConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = VersioningConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VersioningConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDatasetRequestMarshaller _instance = new CreateDatasetRequestMarshaller();        

        internal static CreateDatasetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDatasetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618