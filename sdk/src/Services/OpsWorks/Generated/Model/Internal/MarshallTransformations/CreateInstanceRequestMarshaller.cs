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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInstance Request Marshaller
    /// </summary>       
    public class CreateInstanceRequestMarshaller : IMarshaller<IRequest, CreateInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.CreateInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-02-18";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentVersion())
                {
                    context.Writer.WritePropertyName("AgentVersion");
                    context.Writer.Write(publicRequest.AgentVersion);
                }

                if(publicRequest.IsSetAmiId())
                {
                    context.Writer.WritePropertyName("AmiId");
                    context.Writer.Write(publicRequest.AmiId);
                }

                if(publicRequest.IsSetArchitecture())
                {
                    context.Writer.WritePropertyName("Architecture");
                    context.Writer.Write(publicRequest.Architecture);
                }

                if(publicRequest.IsSetAutoScalingType())
                {
                    context.Writer.WritePropertyName("AutoScalingType");
                    context.Writer.Write(publicRequest.AutoScalingType);
                }

                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("AvailabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetBlockDeviceMappings())
                {
                    context.Writer.WritePropertyName("BlockDeviceMappings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBlockDeviceMappingsListValue in publicRequest.BlockDeviceMappings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BlockDeviceMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestBlockDeviceMappingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEbsOptimized())
                {
                    context.Writer.WritePropertyName("EbsOptimized");
                    context.Writer.Write(publicRequest.EbsOptimized);
                }

                if(publicRequest.IsSetHostname())
                {
                    context.Writer.WritePropertyName("Hostname");
                    context.Writer.Write(publicRequest.Hostname);
                }

                if(publicRequest.IsSetInstallUpdatesOnBoot())
                {
                    context.Writer.WritePropertyName("InstallUpdatesOnBoot");
                    context.Writer.Write(publicRequest.InstallUpdatesOnBoot);
                }

                if(publicRequest.IsSetInstanceType())
                {
                    context.Writer.WritePropertyName("InstanceType");
                    context.Writer.Write(publicRequest.InstanceType);
                }

                if(publicRequest.IsSetLayerIds())
                {
                    context.Writer.WritePropertyName("LayerIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLayerIdsListValue in publicRequest.LayerIds)
                    {
                            context.Writer.Write(publicRequestLayerIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOs())
                {
                    context.Writer.WritePropertyName("Os");
                    context.Writer.Write(publicRequest.Os);
                }

                if(publicRequest.IsSetRootDeviceType())
                {
                    context.Writer.WritePropertyName("RootDeviceType");
                    context.Writer.Write(publicRequest.RootDeviceType);
                }

                if(publicRequest.IsSetSshKeyName())
                {
                    context.Writer.WritePropertyName("SshKeyName");
                    context.Writer.Write(publicRequest.SshKeyName);
                }

                if(publicRequest.IsSetStackId())
                {
                    context.Writer.WritePropertyName("StackId");
                    context.Writer.Write(publicRequest.StackId);
                }

                if(publicRequest.IsSetSubnetId())
                {
                    context.Writer.WritePropertyName("SubnetId");
                    context.Writer.Write(publicRequest.SubnetId);
                }

                if(publicRequest.IsSetTenancy())
                {
                    context.Writer.WritePropertyName("Tenancy");
                    context.Writer.Write(publicRequest.Tenancy);
                }

                if(publicRequest.IsSetVirtualizationType())
                {
                    context.Writer.WritePropertyName("VirtualizationType");
                    context.Writer.Write(publicRequest.VirtualizationType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateInstanceRequestMarshaller _instance = new CreateInstanceRequestMarshaller();        

        internal static CreateInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618