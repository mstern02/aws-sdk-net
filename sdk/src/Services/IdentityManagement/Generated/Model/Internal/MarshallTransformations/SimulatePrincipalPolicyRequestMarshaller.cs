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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimulatePrincipalPolicy Request Marshaller
    /// </summary>       
    public class SimulatePrincipalPolicyRequestMarshaller : IMarshaller<IRequest, SimulatePrincipalPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimulatePrincipalPolicyRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SimulatePrincipalPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "SimulatePrincipalPolicy");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetActionNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ActionNames)
                    {
                        request.Parameters.Add("ActionNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCallerArn())
                {
                    request.Parameters.Add("CallerArn", StringUtils.FromString(publicRequest.CallerArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetContextEntries())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ContextEntries)
                    {
                        if(publicRequestlistValue.IsSetContextKeyName())
                        {
                            request.Parameters.Add("ContextEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ContextKeyName", StringUtils.FromString(publicRequestlistValue.ContextKeyName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetContextKeyType())
                        {
                            request.Parameters.Add("ContextEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ContextKeyType", StringUtils.FromString(publicRequestlistValue.ContextKeyType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetContextKeyValues())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ContextKeyValues)
                            {
                                request.Parameters.Add("ContextEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ContextKeyValues" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaxItems())
                {
                    request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPermissionsBoundaryPolicyInputList())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.PermissionsBoundaryPolicyInputList)
                    {
                        request.Parameters.Add("PermissionsBoundaryPolicyInputList" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPolicyInputList())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.PolicyInputList)
                    {
                        request.Parameters.Add("PolicyInputList" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPolicySourceArn())
                {
                    request.Parameters.Add("PolicySourceArn", StringUtils.FromString(publicRequest.PolicySourceArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetResourceArns())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ResourceArns)
                    {
                        request.Parameters.Add("ResourceArns" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetResourceHandlingOption())
                {
                    request.Parameters.Add("ResourceHandlingOption", StringUtils.FromString(publicRequest.ResourceHandlingOption));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetResourceOwner())
                {
                    request.Parameters.Add("ResourceOwner", StringUtils.FromString(publicRequest.ResourceOwner));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetResourcePolicy())
                {
                    request.Parameters.Add("ResourcePolicy", StringUtils.FromString(publicRequest.ResourcePolicy));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static SimulatePrincipalPolicyRequestMarshaller _instance = new SimulatePrincipalPolicyRequestMarshaller();        

        internal static SimulatePrincipalPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimulatePrincipalPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}