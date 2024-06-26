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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RobotApplicationConfig Marshaller
    /// </summary>
    public class RobotApplicationConfigMarshaller : IRequestMarshaller<RobotApplicationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RobotApplicationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApplication())
            {
                context.Writer.WritePropertyName("application");
                context.Writer.Write(requestObject.Application);
            }

            if(requestObject.IsSetApplicationVersion())
            {
                context.Writer.WritePropertyName("applicationVersion");
                context.Writer.Write(requestObject.ApplicationVersion);
            }

            if(requestObject.IsSetLaunchConfig())
            {
                context.Writer.WritePropertyName("launchConfig");
                context.Writer.WriteObjectStart();

                var marshaller = LaunchConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTools())
            {
                context.Writer.WritePropertyName("tools");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectToolsListValue in requestObject.Tools)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ToolMarshaller.Instance;
                    marshaller.Marshall(requestObjectToolsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUploadConfigurations())
            {
                context.Writer.WritePropertyName("uploadConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUploadConfigurationsListValue in requestObject.UploadConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = UploadConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectUploadConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUseDefaultTools())
            {
                context.Writer.WritePropertyName("useDefaultTools");
                context.Writer.Write(requestObject.UseDefaultTools);
            }

            if(requestObject.IsSetUseDefaultUploadConfigurations())
            {
                context.Writer.WritePropertyName("useDefaultUploadConfigurations");
                context.Writer.Write(requestObject.UseDefaultUploadConfigurations);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RobotApplicationConfigMarshaller Instance = new RobotApplicationConfigMarshaller();

    }
}
#pragma warning restore CS0612,CS0618