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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrustedAdvisorCheckSummary Object
    /// </summary>  
    public class TrustedAdvisorCheckSummaryUnmarshaller : IUnmarshaller<TrustedAdvisorCheckSummary, XmlUnmarshallerContext>, IUnmarshaller<TrustedAdvisorCheckSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TrustedAdvisorCheckSummary IUnmarshaller<TrustedAdvisorCheckSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TrustedAdvisorCheckSummary Unmarshall(JsonUnmarshallerContext context)
        {
            TrustedAdvisorCheckSummary unmarshalledObject = new TrustedAdvisorCheckSummary();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("categorySpecificSummary", targetDepth))
                {
                    var unmarshaller = TrustedAdvisorCategorySpecificSummaryUnmarshaller.Instance;
                    unmarshalledObject.CategorySpecificSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("checkId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CheckId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hasFlaggedResources", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.HasFlaggedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourcesSummary", targetDepth))
                {
                    var unmarshaller = TrustedAdvisorResourcesSummaryUnmarshaller.Instance;
                    unmarshalledObject.ResourcesSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TrustedAdvisorCheckSummaryUnmarshaller _instance = new TrustedAdvisorCheckSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrustedAdvisorCheckSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618