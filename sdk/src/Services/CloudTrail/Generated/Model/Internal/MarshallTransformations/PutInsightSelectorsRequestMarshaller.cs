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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutInsightSelectors Request Marshaller
    /// </summary>       
    public class PutInsightSelectorsRequestMarshaller : IMarshaller<IRequest, PutInsightSelectorsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutInsightSelectorsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutInsightSelectorsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrail");
            string target = "com.amazonaws.cloudtrail.v20131101.CloudTrail_20131101.PutInsightSelectors";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEventDataStore())
                {
                    context.Writer.WritePropertyName("EventDataStore");
                    context.Writer.Write(publicRequest.EventDataStore);
                }

                if(publicRequest.IsSetInsightsDestination())
                {
                    context.Writer.WritePropertyName("InsightsDestination");
                    context.Writer.Write(publicRequest.InsightsDestination);
                }

                if(publicRequest.IsSetInsightSelectors())
                {
                    context.Writer.WritePropertyName("InsightSelectors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInsightSelectorsListValue in publicRequest.InsightSelectors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InsightSelectorMarshaller.Instance;
                        marshaller.Marshall(publicRequestInsightSelectorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTrailName())
                {
                    context.Writer.WritePropertyName("TrailName");
                    context.Writer.Write(publicRequest.TrailName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutInsightSelectorsRequestMarshaller _instance = new PutInsightSelectorsRequestMarshaller();        

        internal static PutInsightSelectorsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutInsightSelectorsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618