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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplaceRoute Request Marshaller
    /// </summary>       
    public class ReplaceRouteRequestMarshaller : IMarshaller<IRequest, ReplaceRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplaceRouteRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReplaceRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ReplaceRoute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCarrierGatewayId())
                {
                    request.Parameters.Add("CarrierGatewayId", StringUtils.FromString(publicRequest.CarrierGatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCoreNetworkArn())
                {
                    request.Parameters.Add("CoreNetworkArn", StringUtils.FromString(publicRequest.CoreNetworkArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDestinationCidrBlock())
                {
                    request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(publicRequest.DestinationCidrBlock));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDestinationIpv6CidrBlock())
                {
                    request.Parameters.Add("DestinationIpv6CidrBlock", StringUtils.FromString(publicRequest.DestinationIpv6CidrBlock));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDestinationPrefixListId())
                {
                    request.Parameters.Add("DestinationPrefixListId", StringUtils.FromString(publicRequest.DestinationPrefixListId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEgressOnlyInternetGatewayId())
                {
                    request.Parameters.Add("EgressOnlyInternetGatewayId", StringUtils.FromString(publicRequest.EgressOnlyInternetGatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetGatewayId())
                {
                    request.Parameters.Add("GatewayId", StringUtils.FromString(publicRequest.GatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLocalGatewayId())
                {
                    request.Parameters.Add("LocalGatewayId", StringUtils.FromString(publicRequest.LocalGatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLocalTarget())
                {
                    request.Parameters.Add("LocalTarget", StringUtils.FromBool(publicRequest.LocalTarget));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNatGatewayId())
                {
                    request.Parameters.Add("NatGatewayId", StringUtils.FromString(publicRequest.NatGatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNetworkInterfaceId())
                {
                    request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRouteTableId())
                {
                    request.Parameters.Add("RouteTableId", StringUtils.FromString(publicRequest.RouteTableId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTransitGatewayId())
                {
                    request.Parameters.Add("TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpcEndpointId())
                {
                    request.Parameters.Add("VpcEndpointId", StringUtils.FromString(publicRequest.VpcEndpointId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpcPeeringConnectionId())
                {
                    request.Parameters.Add("VpcPeeringConnectionId", StringUtils.FromString(publicRequest.VpcPeeringConnectionId));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ReplaceRouteRequestMarshaller _instance = new ReplaceRouteRequestMarshaller();        

        internal static ReplaceRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplaceRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}