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
using System.Net;
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
    /// Response Unmarshaller for SimulationApplicationConfig Object
    /// </summary>  
    public class SimulationApplicationConfigUnmarshaller : IUnmarshaller<SimulationApplicationConfig, XmlUnmarshallerContext>, IUnmarshaller<SimulationApplicationConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SimulationApplicationConfig IUnmarshaller<SimulationApplicationConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SimulationApplicationConfig Unmarshall(JsonUnmarshallerContext context)
        {
            SimulationApplicationConfig unmarshalledObject = new SimulationApplicationConfig();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("application", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Application = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("applicationVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchConfig", targetDepth))
                {
                    var unmarshaller = LaunchConfigUnmarshaller.Instance;
                    unmarshalledObject.LaunchConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tools", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tool, ToolUnmarshaller>(ToolUnmarshaller.Instance);
                    unmarshalledObject.Tools = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uploadConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UploadConfiguration, UploadConfigurationUnmarshaller>(UploadConfigurationUnmarshaller.Instance);
                    unmarshalledObject.UploadConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("useDefaultTools", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseDefaultTools = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("useDefaultUploadConfigurations", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseDefaultUploadConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("worldConfigs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WorldConfig, WorldConfigUnmarshaller>(WorldConfigUnmarshaller.Instance);
                    unmarshalledObject.WorldConfigs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SimulationApplicationConfigUnmarshaller _instance = new SimulationApplicationConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimulationApplicationConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618