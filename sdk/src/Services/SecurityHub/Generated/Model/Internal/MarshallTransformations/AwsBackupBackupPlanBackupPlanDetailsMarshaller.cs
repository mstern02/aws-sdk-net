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
    /// AwsBackupBackupPlanBackupPlanDetails Marshaller
    /// </summary>
    public class AwsBackupBackupPlanBackupPlanDetailsMarshaller : IRequestMarshaller<AwsBackupBackupPlanBackupPlanDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsBackupBackupPlanBackupPlanDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdvancedBackupSettings())
            {
                context.Writer.WritePropertyName("AdvancedBackupSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdvancedBackupSettingsListValue in requestObject.AdvancedBackupSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsBackupBackupPlanAdvancedBackupSettingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdvancedBackupSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBackupPlanName())
            {
                context.Writer.WritePropertyName("BackupPlanName");
                context.Writer.Write(requestObject.BackupPlanName);
            }

            if(requestObject.IsSetBackupPlanRule())
            {
                context.Writer.WritePropertyName("BackupPlanRule");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBackupPlanRuleListValue in requestObject.BackupPlanRule)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsBackupBackupPlanRuleDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectBackupPlanRuleListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsBackupBackupPlanBackupPlanDetailsMarshaller Instance = new AwsBackupBackupPlanBackupPlanDetailsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618