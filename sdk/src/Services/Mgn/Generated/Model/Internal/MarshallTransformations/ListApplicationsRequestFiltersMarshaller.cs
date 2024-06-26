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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListApplicationsRequestFilters Marshaller
    /// </summary>
    public class ListApplicationsRequestFiltersMarshaller : IRequestMarshaller<ListApplicationsRequestFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListApplicationsRequestFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApplicationIDs())
            {
                context.Writer.WritePropertyName("applicationIDs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectApplicationIDsListValue in requestObject.ApplicationIDs)
                {
                        context.Writer.Write(requestObjectApplicationIDsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIsArchived())
            {
                context.Writer.WritePropertyName("isArchived");
                context.Writer.Write(requestObject.IsArchived);
            }

            if(requestObject.IsSetWaveIDs())
            {
                context.Writer.WritePropertyName("waveIDs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWaveIDsListValue in requestObject.WaveIDs)
                {
                        context.Writer.Write(requestObjectWaveIDsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListApplicationsRequestFiltersMarshaller Instance = new ListApplicationsRequestFiltersMarshaller();

    }
}
#pragma warning restore CS0612,CS0618