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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutWarmPool Request Marshaller
    /// </summary>       
    public class PutWarmPoolRequestMarshaller : IMarshaller<IRequest, PutWarmPoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutWarmPoolRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutWarmPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "PutWarmPool");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetInstanceReusePolicy())
                {
                    if(publicRequest.InstanceReusePolicy.IsSetReuseOnScaleIn())
                    {
                        request.Parameters.Add("InstanceReusePolicy" + "." + "ReuseOnScaleIn", StringUtils.FromBool(publicRequest.InstanceReusePolicy.ReuseOnScaleIn));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaxGroupPreparedCapacity())
                {
                    request.Parameters.Add("MaxGroupPreparedCapacity", StringUtils.FromInt(publicRequest.MaxGroupPreparedCapacity));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMinSize())
                {
                    request.Parameters.Add("MinSize", StringUtils.FromInt(publicRequest.MinSize));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPoolState())
                {
                    request.Parameters.Add("PoolState", StringUtils.FromString(publicRequest.PoolState));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static PutWarmPoolRequestMarshaller _instance = new PutWarmPoolRequestMarshaller();        

        internal static PutWarmPoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutWarmPoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}