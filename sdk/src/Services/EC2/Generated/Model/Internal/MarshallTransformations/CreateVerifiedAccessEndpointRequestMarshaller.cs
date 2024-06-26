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
    /// CreateVerifiedAccessEndpoint Request Marshaller
    /// </summary>       
    public class CreateVerifiedAccessEndpointRequestMarshaller : IMarshaller<IRequest, CreateVerifiedAccessEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVerifiedAccessEndpointRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVerifiedAccessEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateVerifiedAccessEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationDomain())
                {
                    request.Parameters.Add("ApplicationDomain", StringUtils.FromString(publicRequest.ApplicationDomain));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAttachmentType())
                {
                    request.Parameters.Add("AttachmentType", StringUtils.FromString(publicRequest.AttachmentType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainCertificateArn())
                {
                    request.Parameters.Add("DomainCertificateArn", StringUtils.FromString(publicRequest.DomainCertificateArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEndpointDomainPrefix())
                {
                    request.Parameters.Add("EndpointDomainPrefix", StringUtils.FromString(publicRequest.EndpointDomainPrefix));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEndpointType())
                {
                    request.Parameters.Add("EndpointType", StringUtils.FromString(publicRequest.EndpointType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLoadBalancerOptions())
                {
                    if(publicRequest.LoadBalancerOptions.IsSetLoadBalancerArn())
                    {
                        request.Parameters.Add("LoadBalancerOptions" + "." + "LoadBalancerArn", StringUtils.FromString(publicRequest.LoadBalancerOptions.LoadBalancerArn));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LoadBalancerOptions.IsSetPort())
                    {
                        request.Parameters.Add("LoadBalancerOptions" + "." + "Port", StringUtils.FromInt(publicRequest.LoadBalancerOptions.Port));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LoadBalancerOptions.IsSetProtocol())
                    {
                        request.Parameters.Add("LoadBalancerOptions" + "." + "Protocol", StringUtils.FromString(publicRequest.LoadBalancerOptions.Protocol));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LoadBalancerOptions.IsSetSubnetIds())
                    {
                        int publicRequestLoadBalancerOptionslistValueIndex = 1;
                        foreach(var publicRequestLoadBalancerOptionslistValue in publicRequest.LoadBalancerOptions.SubnetIds)
                        {
                            request.Parameters.Add("LoadBalancerOptions" + "." + "SubnetId" + "." + publicRequestLoadBalancerOptionslistValueIndex, StringUtils.FromString(publicRequestLoadBalancerOptionslistValue));
                            publicRequestLoadBalancerOptionslistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNetworkInterfaceOptions())
                {
                    if(publicRequest.NetworkInterfaceOptions.IsSetNetworkInterfaceId())
                    {
                        request.Parameters.Add("NetworkInterfaceOptions" + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceOptions.NetworkInterfaceId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.NetworkInterfaceOptions.IsSetPort())
                    {
                        request.Parameters.Add("NetworkInterfaceOptions" + "." + "Port", StringUtils.FromInt(publicRequest.NetworkInterfaceOptions.Port));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.NetworkInterfaceOptions.IsSetProtocol())
                    {
                        request.Parameters.Add("NetworkInterfaceOptions" + "." + "Protocol", StringUtils.FromString(publicRequest.NetworkInterfaceOptions.Protocol));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPolicyDocument())
                {
                    request.Parameters.Add("PolicyDocument", StringUtils.FromString(publicRequest.PolicyDocument));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSseSpecification())
                {
                    if(publicRequest.SseSpecification.IsSetCustomerManagedKeyEnabled())
                    {
                        request.Parameters.Add("SseSpecification" + "." + "CustomerManagedKeyEnabled", StringUtils.FromBool(publicRequest.SseSpecification.CustomerManagedKeyEnabled));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SseSpecification.IsSetKmsKeyArn())
                    {
                        request.Parameters.Add("SseSpecification" + "." + "KmsKeyArn", StringUtils.FromString(publicRequest.SseSpecification.KmsKeyArn));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVerifiedAccessGroupId())
                {
                    request.Parameters.Add("VerifiedAccessGroupId", StringUtils.FromString(publicRequest.VerifiedAccessGroupId));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateVerifiedAccessEndpointRequestMarshaller _instance = new CreateVerifiedAccessEndpointRequestMarshaller();        

        internal static CreateVerifiedAccessEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVerifiedAccessEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}