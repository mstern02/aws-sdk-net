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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MTurk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QualificationRequirement Marshaller
    /// </summary>
    public class QualificationRequirementMarshaller : IRequestMarshaller<QualificationRequirement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QualificationRequirement requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActionsGuarded())
            {
                context.Writer.WritePropertyName("ActionsGuarded");
                context.Writer.Write(requestObject.ActionsGuarded);
            }

            if(requestObject.IsSetComparator())
            {
                context.Writer.WritePropertyName("Comparator");
                context.Writer.Write(requestObject.Comparator);
            }

            if(requestObject.IsSetIntegerValues())
            {
                context.Writer.WritePropertyName("IntegerValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIntegerValuesListValue in requestObject.IntegerValues)
                {
                        context.Writer.Write(requestObjectIntegerValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLocaleValues())
            {
                context.Writer.WritePropertyName("LocaleValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLocaleValuesListValue in requestObject.LocaleValues)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LocaleMarshaller.Instance;
                    marshaller.Marshall(requestObjectLocaleValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetQualificationTypeId())
            {
                context.Writer.WritePropertyName("QualificationTypeId");
                context.Writer.Write(requestObject.QualificationTypeId);
            }

            if(requestObject.IsSetRequiredToPreview())
            {
                context.Writer.WritePropertyName("RequiredToPreview");
                context.Writer.Write(requestObject.RequiredToPreview);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QualificationRequirementMarshaller Instance = new QualificationRequirementMarshaller();

    }
}
#pragma warning restore CS0612,CS0618