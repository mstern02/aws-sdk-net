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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3ReportExportConfig Marshaller
    /// </summary>
    public class S3ReportExportConfigMarshaller : IRequestMarshaller<S3ReportExportConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3ReportExportConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucket())
            {
                context.Writer.WritePropertyName("bucket");
                context.Writer.Write(requestObject.Bucket);
            }

            if(requestObject.IsSetBucketOwner())
            {
                context.Writer.WritePropertyName("bucketOwner");
                context.Writer.Write(requestObject.BucketOwner);
            }

            if(requestObject.IsSetEncryptionDisabled())
            {
                context.Writer.WritePropertyName("encryptionDisabled");
                context.Writer.Write(requestObject.EncryptionDisabled);
            }

            if(requestObject.IsSetEncryptionKey())
            {
                context.Writer.WritePropertyName("encryptionKey");
                context.Writer.Write(requestObject.EncryptionKey);
            }

            if(requestObject.IsSetPackaging())
            {
                context.Writer.WritePropertyName("packaging");
                context.Writer.Write(requestObject.Packaging);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.Write(requestObject.Path);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3ReportExportConfigMarshaller Instance = new S3ReportExportConfigMarshaller();

    }
}
#pragma warning restore CS0612,CS0618