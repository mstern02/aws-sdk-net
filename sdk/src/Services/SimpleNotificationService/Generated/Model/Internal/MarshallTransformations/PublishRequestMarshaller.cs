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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Publish Request Marshaller
    /// </summary>       
    public class PublishRequestMarshaller : IMarshaller<IRequest, PublishRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PublishRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.Parameters.Add("Action", "Publish");
            request.Parameters.Add("Version", "2010-03-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetMessage())
                {
                    request.Parameters.Add("Message", StringUtils.FromString(publicRequest.Message));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMessageAttributes())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.MessageAttributes.Keys)
                    {
                        MessageAttributeValue value;
                        bool hasValue = publicRequest.MessageAttributes.TryGetValue(key, out value);
                        request.Parameters.Add("MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Name", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            if(value.IsSetBinaryValue())
                            {
                                request.Parameters.Add("MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Value" + "." + "BinaryValue", StringUtils.FromMemoryStream(value.BinaryValue));
                            }
#pragma warning restore CS0612,CS0618
                            if(value.IsSetDataType())
                            {
                                request.Parameters.Add("MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Value" + "." + "DataType", StringUtils.FromString(value.DataType));
                            }
#pragma warning restore CS0612,CS0618
                            if(value.IsSetStringValue())
                            {
                                request.Parameters.Add("MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Value" + "." + "StringValue", StringUtils.FromString(value.StringValue));
                            }
#pragma warning restore CS0612,CS0618
                        }
                        mapIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMessageDeduplicationId())
                {
                    request.Parameters.Add("MessageDeduplicationId", StringUtils.FromString(publicRequest.MessageDeduplicationId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMessageGroupId())
                {
                    request.Parameters.Add("MessageGroupId", StringUtils.FromString(publicRequest.MessageGroupId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMessageStructure())
                {
                    request.Parameters.Add("MessageStructure", StringUtils.FromString(publicRequest.MessageStructure));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPhoneNumber())
                {
                    request.Parameters.Add("PhoneNumber", StringUtils.FromString(publicRequest.PhoneNumber));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSubject())
                {
                    request.Parameters.Add("Subject", StringUtils.FromString(publicRequest.Subject));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTargetArn())
                {
                    request.Parameters.Add("TargetArn", StringUtils.FromString(publicRequest.TargetArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTopicArn())
                {
                    request.Parameters.Add("TopicArn", StringUtils.FromString(publicRequest.TopicArn));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static PublishRequestMarshaller _instance = new PublishRequestMarshaller();        

        internal static PublishRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PublishRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}