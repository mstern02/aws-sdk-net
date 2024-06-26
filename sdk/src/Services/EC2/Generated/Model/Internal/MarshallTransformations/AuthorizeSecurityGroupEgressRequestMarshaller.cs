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
    /// AuthorizeSecurityGroupEgress Request Marshaller
    /// </summary>       
    public class AuthorizeSecurityGroupEgressRequestMarshaller : IMarshaller<IRequest, AuthorizeSecurityGroupEgressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AuthorizeSecurityGroupEgressRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AuthorizeSecurityGroupEgressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "AuthorizeSecurityGroupEgress");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetGroupId())
                {
                    request.Parameters.Add("GroupId", StringUtils.FromString(publicRequest.GroupId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIpPermissions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.IpPermissions)
                    {
                        if(publicRequestlistValue.IsSetFromPort())
                        {
                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "FromPort", StringUtils.FromInt(publicRequestlistValue.FromPort));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpProtocol())
                        {
                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpProtocol", StringUtils.FromString(publicRequestlistValue.IpProtocol));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv4Ranges())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv4Ranges)
                            {
                                if(publicRequestlistValuelistValue.IsSetCidrIp())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpRanges" + "." + publicRequestlistValuelistValueIndex + "." + "CidrIp", StringUtils.FromString(publicRequestlistValuelistValue.CidrIp));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetDescription())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpRanges" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv6Ranges())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv6Ranges)
                            {
                                if(publicRequestlistValuelistValue.IsSetCidrIpv6())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Ipv6Ranges" + "." + publicRequestlistValuelistValueIndex + "." + "CidrIpv6", StringUtils.FromString(publicRequestlistValuelistValue.CidrIpv6));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetDescription())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Ipv6Ranges" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetPrefixListIds())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PrefixListIds)
                            {
                                if(publicRequestlistValuelistValue.IsSetDescription())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "PrefixListIds" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetId())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "PrefixListIds" + "." + publicRequestlistValuelistValueIndex + "." + "PrefixListId", StringUtils.FromString(publicRequestlistValuelistValue.Id));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetToPort())
                        {
                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "ToPort", StringUtils.FromInt(publicRequestlistValue.ToPort));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetUserIdGroupPairs())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.UserIdGroupPairs)
                            {
                                if(publicRequestlistValuelistValue.IsSetDescription())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetGroupId())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "GroupId", StringUtils.FromString(publicRequestlistValuelistValue.GroupId));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetGroupName())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.GroupName));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetPeeringStatus())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "PeeringStatus", StringUtils.FromString(publicRequestlistValuelistValue.PeeringStatus));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetUserId())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestlistValuelistValue.UserId));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetVpcId())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "VpcId", StringUtils.FromString(publicRequestlistValuelistValue.VpcId));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetVpcPeeringConnectionId())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "VpcPeeringConnectionId", StringUtils.FromString(publicRequestlistValuelistValue.VpcPeeringConnectionId));
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
            }
            return request;
        }
                    private static AuthorizeSecurityGroupEgressRequestMarshaller _instance = new AuthorizeSecurityGroupEgressRequestMarshaller();        

        internal static AuthorizeSecurityGroupEgressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthorizeSecurityGroupEgressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}