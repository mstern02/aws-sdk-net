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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RouteSetDetails Marshaller
    /// </summary>
    public class RouteSetDetailsMarshaller : IRequestMarshaller<RouteSetDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteSetDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCarrierGatewayId())
            {
                context.Writer.WritePropertyName("CarrierGatewayId");
                context.Writer.Write(requestObject.CarrierGatewayId);
            }

            if(requestObject.IsSetCoreNetworkArn())
            {
                context.Writer.WritePropertyName("CoreNetworkArn");
                context.Writer.Write(requestObject.CoreNetworkArn);
            }

            if(requestObject.IsSetDestinationCidrBlock())
            {
                context.Writer.WritePropertyName("DestinationCidrBlock");
                context.Writer.Write(requestObject.DestinationCidrBlock);
            }

            if(requestObject.IsSetDestinationIpv6CidrBlock())
            {
                context.Writer.WritePropertyName("DestinationIpv6CidrBlock");
                context.Writer.Write(requestObject.DestinationIpv6CidrBlock);
            }

            if(requestObject.IsSetDestinationPrefixListId())
            {
                context.Writer.WritePropertyName("DestinationPrefixListId");
                context.Writer.Write(requestObject.DestinationPrefixListId);
            }

            if(requestObject.IsSetEgressOnlyInternetGatewayId())
            {
                context.Writer.WritePropertyName("EgressOnlyInternetGatewayId");
                context.Writer.Write(requestObject.EgressOnlyInternetGatewayId);
            }

            if(requestObject.IsSetGatewayId())
            {
                context.Writer.WritePropertyName("GatewayId");
                context.Writer.Write(requestObject.GatewayId);
            }

            if(requestObject.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.Write(requestObject.InstanceId);
            }

            if(requestObject.IsSetInstanceOwnerId())
            {
                context.Writer.WritePropertyName("InstanceOwnerId");
                context.Writer.Write(requestObject.InstanceOwnerId);
            }

            if(requestObject.IsSetLocalGatewayId())
            {
                context.Writer.WritePropertyName("LocalGatewayId");
                context.Writer.Write(requestObject.LocalGatewayId);
            }

            if(requestObject.IsSetNatGatewayId())
            {
                context.Writer.WritePropertyName("NatGatewayId");
                context.Writer.Write(requestObject.NatGatewayId);
            }

            if(requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.Write(requestObject.NetworkInterfaceId);
            }

            if(requestObject.IsSetOrigin())
            {
                context.Writer.WritePropertyName("Origin");
                context.Writer.Write(requestObject.Origin);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.Write(requestObject.State);
            }

            if(requestObject.IsSetTransitGatewayId())
            {
                context.Writer.WritePropertyName("TransitGatewayId");
                context.Writer.Write(requestObject.TransitGatewayId);
            }

            if(requestObject.IsSetVpcPeeringConnectionId())
            {
                context.Writer.WritePropertyName("VpcPeeringConnectionId");
                context.Writer.Write(requestObject.VpcPeeringConnectionId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouteSetDetailsMarshaller Instance = new RouteSetDetailsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618