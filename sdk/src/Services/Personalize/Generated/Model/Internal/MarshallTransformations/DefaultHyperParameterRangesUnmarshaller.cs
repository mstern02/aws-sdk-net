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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DefaultHyperParameterRanges Object
    /// </summary>  
    public class DefaultHyperParameterRangesUnmarshaller : IUnmarshaller<DefaultHyperParameterRanges, XmlUnmarshallerContext>, IUnmarshaller<DefaultHyperParameterRanges, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DefaultHyperParameterRanges IUnmarshaller<DefaultHyperParameterRanges, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DefaultHyperParameterRanges Unmarshall(JsonUnmarshallerContext context)
        {
            DefaultHyperParameterRanges unmarshalledObject = new DefaultHyperParameterRanges();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("categoricalHyperParameterRanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DefaultCategoricalHyperParameterRange, DefaultCategoricalHyperParameterRangeUnmarshaller>(DefaultCategoricalHyperParameterRangeUnmarshaller.Instance);
                    unmarshalledObject.CategoricalHyperParameterRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("continuousHyperParameterRanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DefaultContinuousHyperParameterRange, DefaultContinuousHyperParameterRangeUnmarshaller>(DefaultContinuousHyperParameterRangeUnmarshaller.Instance);
                    unmarshalledObject.ContinuousHyperParameterRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integerHyperParameterRanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DefaultIntegerHyperParameterRange, DefaultIntegerHyperParameterRangeUnmarshaller>(DefaultIntegerHyperParameterRangeUnmarshaller.Instance);
                    unmarshalledObject.IntegerHyperParameterRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DefaultHyperParameterRangesUnmarshaller _instance = new DefaultHyperParameterRangesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DefaultHyperParameterRangesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618