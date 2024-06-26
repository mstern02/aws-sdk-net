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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMLModel Request Marshaller
    /// </summary>       
    public class CreateMLModelRequestMarshaller : IMarshaller<IRequest, CreateMLModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMLModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMLModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MachineLearning");
            string target = "AmazonML_20141212.CreateMLModel";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-12-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMLModelId())
                {
                    context.Writer.WritePropertyName("MLModelId");
                    context.Writer.Write(publicRequest.MLModelId);
                }

                if(publicRequest.IsSetMLModelName())
                {
                    context.Writer.WritePropertyName("MLModelName");
                    context.Writer.Write(publicRequest.MLModelName);
                }

                if(publicRequest.IsSetMLModelType())
                {
                    context.Writer.WritePropertyName("MLModelType");
                    context.Writer.Write(publicRequest.MLModelType);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                            context.Writer.Write(publicRequestParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRecipe())
                {
                    context.Writer.WritePropertyName("Recipe");
                    context.Writer.Write(publicRequest.Recipe);
                }

                if(publicRequest.IsSetRecipeUri())
                {
                    context.Writer.WritePropertyName("RecipeUri");
                    context.Writer.Write(publicRequest.RecipeUri);
                }

                if(publicRequest.IsSetTrainingDataSourceId())
                {
                    context.Writer.WritePropertyName("TrainingDataSourceId");
                    context.Writer.Write(publicRequest.TrainingDataSourceId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMLModelRequestMarshaller _instance = new CreateMLModelRequestMarshaller();        

        internal static CreateMLModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMLModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618