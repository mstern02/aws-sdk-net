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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OrganizationConfigRule Object
    /// </summary>  
    public class OrganizationConfigRuleUnmarshaller : IUnmarshaller<OrganizationConfigRule, XmlUnmarshallerContext>, IUnmarshaller<OrganizationConfigRule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OrganizationConfigRule IUnmarshaller<OrganizationConfigRule, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OrganizationConfigRule Unmarshall(JsonUnmarshallerContext context)
        {
            OrganizationConfigRule unmarshalledObject = new OrganizationConfigRule();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExcludedAccounts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExcludedAccounts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationConfigRuleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationConfigRuleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationConfigRuleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationConfigRuleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationCustomPolicyRuleMetadata", targetDepth))
                {
                    var unmarshaller = OrganizationCustomPolicyRuleMetadataNoPolicyUnmarshaller.Instance;
                    unmarshalledObject.OrganizationCustomPolicyRuleMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationCustomRuleMetadata", targetDepth))
                {
                    var unmarshaller = OrganizationCustomRuleMetadataUnmarshaller.Instance;
                    unmarshalledObject.OrganizationCustomRuleMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationManagedRuleMetadata", targetDepth))
                {
                    var unmarshaller = OrganizationManagedRuleMetadataUnmarshaller.Instance;
                    unmarshalledObject.OrganizationManagedRuleMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OrganizationConfigRuleUnmarshaller _instance = new OrganizationConfigRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrganizationConfigRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618