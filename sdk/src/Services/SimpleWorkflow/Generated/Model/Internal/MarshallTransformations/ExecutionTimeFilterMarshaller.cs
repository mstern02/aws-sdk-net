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
    /// ExecutionTimeFilter Marshaller
    /// </summary>
    public class ExecutionTimeFilterMarshaller : IRequestMarshaller<ExecutionTimeFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExecutionTimeFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetLatestDate())
            {
                context.Writer.WritePropertyName("latestDate");
                context.Writer.Write(requestObject.LatestDate);
            }

            if(requestObject.IsSetOldestDate())
            {
                context.Writer.WritePropertyName("oldestDate");
                context.Writer.Write(requestObject.OldestDate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExecutionTimeFilterMarshaller Instance = new ExecutionTimeFilterMarshaller();

    }
}
#pragma warning restore CS0612,CS0618