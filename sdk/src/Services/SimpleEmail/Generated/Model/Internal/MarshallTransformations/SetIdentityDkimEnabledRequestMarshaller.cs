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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetIdentityDkimEnabled Request Marshaller
    /// </summary>       
    public class SetIdentityDkimEnabledRequestMarshaller : IMarshaller<IRequest, SetIdentityDkimEnabledRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetIdentityDkimEnabledRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetIdentityDkimEnabledRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "SetIdentityDkimEnabled");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDkimEnabled())
                {
                    request.Parameters.Add("DkimEnabled", StringUtils.FromBool(publicRequest.DkimEnabled));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIdentity())
                {
                    request.Parameters.Add("Identity", StringUtils.FromString(publicRequest.Identity));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static SetIdentityDkimEnabledRequestMarshaller _instance = new SetIdentityDkimEnabledRequestMarshaller();        

        internal static SetIdentityDkimEnabledRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetIdentityDkimEnabledRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}