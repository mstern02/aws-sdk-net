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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCisScansFilterCriteria Marshaller
    /// </summary>
    public class ListCisScansFilterCriteriaMarshaller : IRequestMarshaller<ListCisScansFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListCisScansFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFailedChecksFilters())
            {
                context.Writer.WritePropertyName("failedChecksFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFailedChecksFiltersListValue in requestObject.FailedChecksFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisNumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFailedChecksFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanArnFilters())
            {
                context.Writer.WritePropertyName("scanArnFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanArnFiltersListValue in requestObject.ScanArnFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanArnFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanAtFilters())
            {
                context.Writer.WritePropertyName("scanAtFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanAtFiltersListValue in requestObject.ScanAtFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisDateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanAtFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanConfigurationArnFilters())
            {
                context.Writer.WritePropertyName("scanConfigurationArnFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanConfigurationArnFiltersListValue in requestObject.ScanConfigurationArnFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanConfigurationArnFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanNameFilters())
            {
                context.Writer.WritePropertyName("scanNameFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanNameFiltersListValue in requestObject.ScanNameFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanNameFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanStatusFilters())
            {
                context.Writer.WritePropertyName("scanStatusFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanStatusFiltersListValue in requestObject.ScanStatusFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisScanStatusFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanStatusFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScheduledByFilters())
            {
                context.Writer.WritePropertyName("scheduledByFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScheduledByFiltersListValue in requestObject.ScheduledByFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScheduledByFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetAccountIdFilters())
            {
                context.Writer.WritePropertyName("targetAccountIdFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetAccountIdFiltersListValue in requestObject.TargetAccountIdFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetAccountIdFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetResourceIdFilters())
            {
                context.Writer.WritePropertyName("targetResourceIdFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetResourceIdFiltersListValue in requestObject.TargetResourceIdFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetResourceIdFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetResourceTagFilters())
            {
                context.Writer.WritePropertyName("targetResourceTagFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetResourceTagFiltersListValue in requestObject.TargetResourceTagFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetResourceTagFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListCisScansFilterCriteriaMarshaller Instance = new ListCisScansFilterCriteriaMarshaller();

    }
}
#pragma warning restore CS0612,CS0618