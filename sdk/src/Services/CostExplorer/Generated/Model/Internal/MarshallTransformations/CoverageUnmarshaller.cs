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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Coverage Object
    /// </summary>  
    public class CoverageUnmarshaller : IUnmarshaller<Coverage, XmlUnmarshallerContext>, IUnmarshaller<Coverage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Coverage IUnmarshaller<Coverage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Coverage Unmarshall(JsonUnmarshallerContext context)
        {
            Coverage unmarshalledObject = new Coverage();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CoverageCost", targetDepth))
                {
                    var unmarshaller = CoverageCostUnmarshaller.Instance;
                    unmarshalledObject.CoverageCost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CoverageHours", targetDepth))
                {
                    var unmarshaller = CoverageHoursUnmarshaller.Instance;
                    unmarshalledObject.CoverageHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CoverageNormalizedUnits", targetDepth))
                {
                    var unmarshaller = CoverageNormalizedUnitsUnmarshaller.Instance;
                    unmarshalledObject.CoverageNormalizedUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CoverageUnmarshaller _instance = new CoverageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CoverageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618