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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetSubnets Request Marshaller
    /// </summary>       
    public class SetSubnetsRequestMarshaller : IMarshaller<IRequest, SetSubnetsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetSubnetsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetSubnetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "SetSubnets");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetIpAddressType())
                {
                    request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLoadBalancerArn())
                {
                    request.Parameters.Add("LoadBalancerArn", StringUtils.FromString(publicRequest.LoadBalancerArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSubnetMappings())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SubnetMappings)
                    {
                        if(publicRequestlistValue.IsSetAllocationId())
                        {
                            request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AllocationId", StringUtils.FromString(publicRequestlistValue.AllocationId));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIPv6Address())
                        {
                            request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IPv6Address", StringUtils.FromString(publicRequestlistValue.IPv6Address));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetPrivateIPv4Address())
                        {
                            request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "PrivateIPv4Address", StringUtils.FromString(publicRequestlistValue.PrivateIPv4Address));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetSubnetId())
                        {
                            request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.SubnetId));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSubnets())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Subnets)
                    {
                        request.Parameters.Add("Subnets" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static SetSubnetsRequestMarshaller _instance = new SetSubnetsRequestMarshaller();        

        internal static SetSubnetsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetSubnetsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}