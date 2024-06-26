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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipeSourceDynamoDBStreamParameters Marshaller
    /// </summary>
    public class PipeSourceDynamoDBStreamParametersMarshaller : IRequestMarshaller<PipeSourceDynamoDBStreamParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipeSourceDynamoDBStreamParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBatchSize())
            {
                context.Writer.WritePropertyName("BatchSize");
                context.Writer.Write(requestObject.BatchSize);
            }

            if(requestObject.IsSetDeadLetterConfig())
            {
                context.Writer.WritePropertyName("DeadLetterConfig");
                context.Writer.WriteObjectStart();

                var marshaller = DeadLetterConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DeadLetterConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMaximumBatchingWindowInSeconds())
            {
                context.Writer.WritePropertyName("MaximumBatchingWindowInSeconds");
                context.Writer.Write(requestObject.MaximumBatchingWindowInSeconds);
            }

            if(requestObject.IsSetMaximumRecordAgeInSeconds())
            {
                context.Writer.WritePropertyName("MaximumRecordAgeInSeconds");
                context.Writer.Write(requestObject.MaximumRecordAgeInSeconds);
            }

            if(requestObject.IsSetMaximumRetryAttempts())
            {
                context.Writer.WritePropertyName("MaximumRetryAttempts");
                context.Writer.Write(requestObject.MaximumRetryAttempts);
            }

            if(requestObject.IsSetOnPartialBatchItemFailure())
            {
                context.Writer.WritePropertyName("OnPartialBatchItemFailure");
                context.Writer.Write(requestObject.OnPartialBatchItemFailure);
            }

            if(requestObject.IsSetParallelizationFactor())
            {
                context.Writer.WritePropertyName("ParallelizationFactor");
                context.Writer.Write(requestObject.ParallelizationFactor);
            }

            if(requestObject.IsSetStartingPosition())
            {
                context.Writer.WritePropertyName("StartingPosition");
                context.Writer.Write(requestObject.StartingPosition);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipeSourceDynamoDBStreamParametersMarshaller Instance = new PipeSourceDynamoDBStreamParametersMarshaller();

    }
}
#pragma warning restore CS0612,CS0618