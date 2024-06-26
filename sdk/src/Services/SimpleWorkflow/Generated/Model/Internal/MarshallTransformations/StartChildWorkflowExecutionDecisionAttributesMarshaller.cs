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
    /// StartChildWorkflowExecutionDecisionAttributes Marshaller
    /// </summary>
    public class StartChildWorkflowExecutionDecisionAttributesMarshaller : IRequestMarshaller<StartChildWorkflowExecutionDecisionAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StartChildWorkflowExecutionDecisionAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChildPolicy())
            {
                context.Writer.WritePropertyName("childPolicy");
                context.Writer.Write(requestObject.ChildPolicy);
            }

            if(requestObject.IsSetControl())
            {
                context.Writer.WritePropertyName("control");
                context.Writer.Write(requestObject.Control);
            }

            if(requestObject.IsSetExecutionStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("executionStartToCloseTimeout");
                context.Writer.Write(requestObject.ExecutionStartToCloseTimeout);
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.Write(requestObject.Input);
            }

            if(requestObject.IsSetLambdaRole())
            {
                context.Writer.WritePropertyName("lambdaRole");
                context.Writer.Write(requestObject.LambdaRole);
            }

            if(requestObject.IsSetTagList())
            {
                context.Writer.WritePropertyName("tagList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagListListValue in requestObject.TagList)
                {
                        context.Writer.Write(requestObjectTagListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTaskList())
            {
                context.Writer.WritePropertyName("taskList");
                context.Writer.WriteObjectStart();

                var marshaller = TaskListMarshaller.Instance;
                marshaller.Marshall(requestObject.TaskList, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTaskPriority())
            {
                context.Writer.WritePropertyName("taskPriority");
                context.Writer.Write(requestObject.TaskPriority);
            }

            if(requestObject.IsSetTaskStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("taskStartToCloseTimeout");
                context.Writer.Write(requestObject.TaskStartToCloseTimeout);
            }

            if(requestObject.IsSetWorkflowId())
            {
                context.Writer.WritePropertyName("workflowId");
                context.Writer.Write(requestObject.WorkflowId);
            }

            if(requestObject.IsSetWorkflowType())
            {
                context.Writer.WritePropertyName("workflowType");
                context.Writer.WriteObjectStart();

                var marshaller = WorkflowTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkflowType, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StartChildWorkflowExecutionDecisionAttributesMarshaller Instance = new StartChildWorkflowExecutionDecisionAttributesMarshaller();

    }
}
#pragma warning restore CS0612,CS0618