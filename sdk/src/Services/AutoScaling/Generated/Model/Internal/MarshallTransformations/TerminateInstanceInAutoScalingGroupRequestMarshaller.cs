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
    /// TerminateInstanceInAutoScalingGroup Request Marshaller
    /// </summary>       
    public class TerminateInstanceInAutoScalingGroupRequestMarshaller : IMarshaller<IRequest, TerminateInstanceInAutoScalingGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TerminateInstanceInAutoScalingGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TerminateInstanceInAutoScalingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "TerminateInstanceInAutoScalingGroup");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetShouldDecrementDesiredCapacity())
                {
                    request.Parameters.Add("ShouldDecrementDesiredCapacity", StringUtils.FromBool(publicRequest.ShouldDecrementDesiredCapacity));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static TerminateInstanceInAutoScalingGroupRequestMarshaller _instance = new TerminateInstanceInAutoScalingGroupRequestMarshaller();        

        internal static TerminateInstanceInAutoScalingGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TerminateInstanceInAutoScalingGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}