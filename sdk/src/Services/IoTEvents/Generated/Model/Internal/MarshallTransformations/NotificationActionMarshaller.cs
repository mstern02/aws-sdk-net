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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotificationAction Marshaller
    /// </summary>
    public class NotificationActionMarshaller : IRequestMarshaller<NotificationAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NotificationAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteObjectStart();

                var marshaller = NotificationTargetActionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Action, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmailConfigurations())
            {
                context.Writer.WritePropertyName("emailConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEmailConfigurationsListValue in requestObject.EmailConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EmailConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEmailConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSmsConfigurations())
            {
                context.Writer.WritePropertyName("smsConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSmsConfigurationsListValue in requestObject.SmsConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SMSConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectSmsConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NotificationActionMarshaller Instance = new NotificationActionMarshaller();

    }
}
#pragma warning restore CS0612,CS0618