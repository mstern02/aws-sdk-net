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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Compliance Marshaller
    /// </summary>
    public class ComplianceMarshaller : IRequestMarshaller<Compliance, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Compliance requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssociatedStandards())
            {
                context.Writer.WritePropertyName("AssociatedStandards");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssociatedStandardsListValue in requestObject.AssociatedStandards)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssociatedStandardMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociatedStandardsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRelatedRequirements())
            {
                context.Writer.WritePropertyName("RelatedRequirements");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelatedRequirementsListValue in requestObject.RelatedRequirements)
                {
                        context.Writer.Write(requestObjectRelatedRequirementsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecurityControlId())
            {
                context.Writer.WritePropertyName("SecurityControlId");
                context.Writer.Write(requestObject.SecurityControlId);
            }

            if(requestObject.IsSetSecurityControlParameters())
            {
                context.Writer.WritePropertyName("SecurityControlParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityControlParametersListValue in requestObject.SecurityControlParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SecurityControlParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecurityControlParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetStatusReasons())
            {
                context.Writer.WritePropertyName("StatusReasons");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatusReasonsListValue in requestObject.StatusReasons)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StatusReasonMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatusReasonsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComplianceMarshaller Instance = new ComplianceMarshaller();

    }
}
#pragma warning restore CS0612,CS0618