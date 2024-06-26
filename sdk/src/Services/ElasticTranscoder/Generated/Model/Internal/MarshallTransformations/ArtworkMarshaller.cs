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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Artwork Marshaller
    /// </summary>
    public class ArtworkMarshaller : IRequestMarshaller<Artwork, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Artwork requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAlbumArtFormat())
            {
                context.Writer.WritePropertyName("AlbumArtFormat");
                context.Writer.Write(requestObject.AlbumArtFormat);
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("Encryption");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputKey())
            {
                context.Writer.WritePropertyName("InputKey");
                context.Writer.Write(requestObject.InputKey);
            }

            if(requestObject.IsSetMaxHeight())
            {
                context.Writer.WritePropertyName("MaxHeight");
                context.Writer.Write(requestObject.MaxHeight);
            }

            if(requestObject.IsSetMaxWidth())
            {
                context.Writer.WritePropertyName("MaxWidth");
                context.Writer.Write(requestObject.MaxWidth);
            }

            if(requestObject.IsSetPaddingPolicy())
            {
                context.Writer.WritePropertyName("PaddingPolicy");
                context.Writer.Write(requestObject.PaddingPolicy);
            }

            if(requestObject.IsSetSizingPolicy())
            {
                context.Writer.WritePropertyName("SizingPolicy");
                context.Writer.Write(requestObject.SizingPolicy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ArtworkMarshaller Instance = new ArtworkMarshaller();

    }
}
#pragma warning restore CS0612,CS0618