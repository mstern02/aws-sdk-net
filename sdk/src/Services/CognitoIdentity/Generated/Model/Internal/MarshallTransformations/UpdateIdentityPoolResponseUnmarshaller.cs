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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateIdentityPool operation
    /// </summary>  
    public class UpdateIdentityPoolResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            UpdateIdentityPoolResponse response = new UpdateIdentityPoolResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowClassicFlow", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AllowClassicFlow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AllowUnauthenticatedIdentities", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AllowUnauthenticatedIdentities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CognitoIdentityProviders", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CognitoIdentityProviderInfo, CognitoIdentityProviderInfoUnmarshaller>(CognitoIdentityProviderInfoUnmarshaller.Instance);
                    response.CognitoIdentityProviders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeveloperProviderName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeveloperProviderName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentityPoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IdentityPoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentityPoolName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IdentityPoolName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentityPoolTags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.IdentityPoolTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpenIdConnectProviderARNs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.OpenIdConnectProviderARNs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SamlProviderARNs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.SamlProviderARNs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportedLoginProviders", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.SupportedLoginProviders = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConcurrentModificationException"))
                {
                    return ConcurrentModificationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalErrorException"))
                {
                    return InternalErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterException"))
                {
                    return InvalidParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                {
                    return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotAuthorizedException"))
                {
                    return NotAuthorizedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceConflictException"))
                {
                    return ResourceConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCognitoIdentityException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateIdentityPoolResponseUnmarshaller _instance = new UpdateIdentityPoolResponseUnmarshaller();        

        internal static UpdateIdentityPoolResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIdentityPoolResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618