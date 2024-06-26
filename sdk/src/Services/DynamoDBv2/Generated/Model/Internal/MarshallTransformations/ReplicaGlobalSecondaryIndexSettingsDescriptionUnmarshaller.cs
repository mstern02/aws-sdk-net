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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReplicaGlobalSecondaryIndexSettingsDescription Object
    /// </summary>  
    public class ReplicaGlobalSecondaryIndexSettingsDescriptionUnmarshaller : IUnmarshaller<ReplicaGlobalSecondaryIndexSettingsDescription, XmlUnmarshallerContext>, IUnmarshaller<ReplicaGlobalSecondaryIndexSettingsDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReplicaGlobalSecondaryIndexSettingsDescription IUnmarshaller<ReplicaGlobalSecondaryIndexSettingsDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ReplicaGlobalSecondaryIndexSettingsDescription Unmarshall(JsonUnmarshallerContext context)
        {
            ReplicaGlobalSecondaryIndexSettingsDescription unmarshalledObject = new ReplicaGlobalSecondaryIndexSettingsDescription();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("IndexName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedReadCapacityAutoScalingSettings", targetDepth))
                {
                    var unmarshaller = AutoScalingSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedReadCapacityAutoScalingSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedReadCapacityUnits", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedReadCapacityUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedWriteCapacityAutoScalingSettings", targetDepth))
                {
                    var unmarshaller = AutoScalingSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedWriteCapacityAutoScalingSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedWriteCapacityUnits", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedWriteCapacityUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReplicaGlobalSecondaryIndexSettingsDescriptionUnmarshaller _instance = new ReplicaGlobalSecondaryIndexSettingsDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicaGlobalSecondaryIndexSettingsDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618