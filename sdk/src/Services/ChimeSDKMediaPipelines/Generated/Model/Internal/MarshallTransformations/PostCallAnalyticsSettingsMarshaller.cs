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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PostCallAnalyticsSettings Marshaller
    /// </summary>
    public class PostCallAnalyticsSettingsMarshaller : IRequestMarshaller<PostCallAnalyticsSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PostCallAnalyticsSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContentRedactionOutput())
            {
                context.Writer.WritePropertyName("ContentRedactionOutput");
                context.Writer.Write(requestObject.ContentRedactionOutput);
            }

            if(requestObject.IsSetDataAccessRoleArn())
            {
                context.Writer.WritePropertyName("DataAccessRoleArn");
                context.Writer.Write(requestObject.DataAccessRoleArn);
            }

            if(requestObject.IsSetOutputEncryptionKMSKeyId())
            {
                context.Writer.WritePropertyName("OutputEncryptionKMSKeyId");
                context.Writer.Write(requestObject.OutputEncryptionKMSKeyId);
            }

            if(requestObject.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("OutputLocation");
                context.Writer.Write(requestObject.OutputLocation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PostCallAnalyticsSettingsMarshaller Instance = new PostCallAnalyticsSettingsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618