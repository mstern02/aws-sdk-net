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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeUpdateActions Request Marshaller
    /// </summary>       
    public class DescribeUpdateActionsRequestMarshaller : IMarshaller<IRequest, DescribeUpdateActionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeUpdateActionsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeUpdateActionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "DescribeUpdateActions");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCacheClusterIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.CacheClusterIds)
                    {
                        request.Parameters.Add("CacheClusterIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetReplicationGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ReplicationGroupIds)
                    {
                        request.Parameters.Add("ReplicationGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetServiceUpdateName())
                {
                    request.Parameters.Add("ServiceUpdateName", StringUtils.FromString(publicRequest.ServiceUpdateName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetServiceUpdateStatus())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ServiceUpdateStatus)
                    {
                        request.Parameters.Add("ServiceUpdateStatus" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetServiceUpdateTimeRange())
                {
                    if(publicRequest.ServiceUpdateTimeRange.IsSetEndTime())
                    {
                        request.Parameters.Add("ServiceUpdateTimeRange" + "." + "EndTime", StringUtils.FromDateTimeToISO8601(publicRequest.ServiceUpdateTimeRange.EndTime));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ServiceUpdateTimeRange.IsSetStartTime())
                    {
                        request.Parameters.Add("ServiceUpdateTimeRange" + "." + "StartTime", StringUtils.FromDateTimeToISO8601(publicRequest.ServiceUpdateTimeRange.StartTime));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetShowNodeLevelUpdateStatus())
                {
                    request.Parameters.Add("ShowNodeLevelUpdateStatus", StringUtils.FromBool(publicRequest.ShowNodeLevelUpdateStatus));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetUpdateActionStatus())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.UpdateActionStatus)
                    {
                        request.Parameters.Add("UpdateActionStatus" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static DescribeUpdateActionsRequestMarshaller _instance = new DescribeUpdateActionsRequestMarshaller();        

        internal static DescribeUpdateActionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeUpdateActionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}