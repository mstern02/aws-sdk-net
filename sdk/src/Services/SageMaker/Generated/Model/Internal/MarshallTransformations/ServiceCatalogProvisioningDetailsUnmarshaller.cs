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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceCatalogProvisioningDetails Object
    /// </summary>  
    public class ServiceCatalogProvisioningDetailsUnmarshaller : IUnmarshaller<ServiceCatalogProvisioningDetails, XmlUnmarshallerContext>, IUnmarshaller<ServiceCatalogProvisioningDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceCatalogProvisioningDetails IUnmarshaller<ServiceCatalogProvisioningDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceCatalogProvisioningDetails Unmarshall(JsonUnmarshallerContext context)
        {
            ServiceCatalogProvisioningDetails unmarshalledObject = new ServiceCatalogProvisioningDetails();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("PathId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PathId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisioningArtifactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProvisioningArtifactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisioningParameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProvisioningParameter, ProvisioningParameterUnmarshaller>(ProvisioningParameterUnmarshaller.Instance);
                    unmarshalledObject.ProvisioningParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceCatalogProvisioningDetailsUnmarshaller _instance = new ServiceCatalogProvisioningDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceCatalogProvisioningDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618