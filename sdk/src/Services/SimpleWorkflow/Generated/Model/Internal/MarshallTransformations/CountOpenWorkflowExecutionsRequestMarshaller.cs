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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CountOpenWorkflowExecutions Request Marshaller
    /// </summary>       
    public class CountOpenWorkflowExecutionsRequestMarshaller : IMarshaller<IRequest, CountOpenWorkflowExecutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CountOpenWorkflowExecutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CountOpenWorkflowExecutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleWorkflow");
            string target = "SimpleWorkflowService.CountOpenWorkflowExecutions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-01-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("domain");
                    context.Writer.Write(publicRequest.Domain);
                }

                if(publicRequest.IsSetExecutionFilter())
                {
                    context.Writer.WritePropertyName("executionFilter");
                    context.Writer.WriteObjectStart();

                    var marshaller = WorkflowExecutionFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExecutionFilter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStartTimeFilter())
                {
                    context.Writer.WritePropertyName("startTimeFilter");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExecutionTimeFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StartTimeFilter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTagFilter())
                {
                    context.Writer.WritePropertyName("tagFilter");
                    context.Writer.WriteObjectStart();

                    var marshaller = TagFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TagFilter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTypeFilter())
                {
                    context.Writer.WritePropertyName("typeFilter");
                    context.Writer.WriteObjectStart();

                    var marshaller = WorkflowTypeFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TypeFilter, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CountOpenWorkflowExecutionsRequestMarshaller _instance = new CountOpenWorkflowExecutionsRequestMarshaller();        

        internal static CountOpenWorkflowExecutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CountOpenWorkflowExecutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618