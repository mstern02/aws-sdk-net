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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDatasetGroup Request Marshaller
    /// </summary>       
    public class UpdateDatasetGroupRequestMarshaller : IMarshaller<IRequest, UpdateDatasetGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDatasetGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDatasetGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.UpdateDatasetGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDatasetArns())
                {
                    context.Writer.WritePropertyName("DatasetArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDatasetArnsListValue in publicRequest.DatasetArns)
                    {
                            context.Writer.Write(publicRequestDatasetArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDatasetGroupArn())
                {
                    context.Writer.WritePropertyName("DatasetGroupArn");
                    context.Writer.Write(publicRequest.DatasetGroupArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDatasetGroupRequestMarshaller _instance = new UpdateDatasetGroupRequestMarshaller();        

        internal static UpdateDatasetGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDatasetGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618