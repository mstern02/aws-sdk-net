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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DirectKinesisSource Marshaller
    /// </summary>
    public class DirectKinesisSourceMarshaller : IRequestMarshaller<DirectKinesisSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DirectKinesisSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataPreviewOptions())
            {
                context.Writer.WritePropertyName("DataPreviewOptions");
                context.Writer.WriteObjectStart();

                var marshaller = StreamingDataPreviewOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataPreviewOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDetectSchema())
            {
                context.Writer.WritePropertyName("DetectSchema");
                context.Writer.Write(requestObject.DetectSchema);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetStreamingOptions())
            {
                context.Writer.WritePropertyName("StreamingOptions");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisStreamingSourceOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamingOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWindowSize())
            {
                context.Writer.WritePropertyName("WindowSize");
                context.Writer.Write(requestObject.WindowSize);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DirectKinesisSourceMarshaller Instance = new DirectKinesisSourceMarshaller();

    }
}
#pragma warning restore CS0612,CS0618