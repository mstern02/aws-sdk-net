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
    /// TerminateWorkflowExecution Request Marshaller
    /// </summary>       
    public class TerminateWorkflowExecutionRequestMarshaller : IMarshaller<IRequest, TerminateWorkflowExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TerminateWorkflowExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TerminateWorkflowExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleWorkflow");
            string target = "SimpleWorkflowService.TerminateWorkflowExecution";
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
                if(publicRequest.IsSetChildPolicy())
                {
                    context.Writer.WritePropertyName("childPolicy");
                    context.Writer.Write(publicRequest.ChildPolicy);
                }

                if(publicRequest.IsSetDetails())
                {
                    context.Writer.WritePropertyName("details");
                    context.Writer.Write(publicRequest.Details);
                }

                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("domain");
                    context.Writer.Write(publicRequest.Domain);
                }

                if(publicRequest.IsSetReason())
                {
                    context.Writer.WritePropertyName("reason");
                    context.Writer.Write(publicRequest.Reason);
                }

                if(publicRequest.IsSetRunId())
                {
                    context.Writer.WritePropertyName("runId");
                    context.Writer.Write(publicRequest.RunId);
                }

                if(publicRequest.IsSetWorkflowId())
                {
                    context.Writer.WritePropertyName("workflowId");
                    context.Writer.Write(publicRequest.WorkflowId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static TerminateWorkflowExecutionRequestMarshaller _instance = new TerminateWorkflowExecutionRequestMarshaller();        

        internal static TerminateWorkflowExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TerminateWorkflowExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618