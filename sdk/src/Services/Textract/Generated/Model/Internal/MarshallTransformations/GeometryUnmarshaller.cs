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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Textract.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Textract.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Geometry Object
    /// </summary>  
    public class GeometryUnmarshaller : IUnmarshaller<Geometry, XmlUnmarshallerContext>, IUnmarshaller<Geometry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Geometry IUnmarshaller<Geometry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Geometry Unmarshall(JsonUnmarshallerContext context)
        {
            Geometry unmarshalledObject = new Geometry();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BoundingBox", targetDepth))
                {
                    var unmarshaller = BoundingBoxUnmarshaller.Instance;
                    unmarshalledObject.BoundingBox = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Polygon", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Point, PointUnmarshaller>(PointUnmarshaller.Instance);
                    unmarshalledObject.Polygon = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GeometryUnmarshaller _instance = new GeometryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GeometryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618