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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreTableFromClusterSnapshot Request Marshaller
    /// </summary>       
    public class RestoreTableFromClusterSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreTableFromClusterSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreTableFromClusterSnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreTableFromClusterSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "RestoreTableFromClusterSnapshot");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableCaseSensitiveIdentifier())
                {
                    request.Parameters.Add("EnableCaseSensitiveIdentifier", StringUtils.FromBool(publicRequest.EnableCaseSensitiveIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNewTableName())
                {
                    request.Parameters.Add("NewTableName", StringUtils.FromString(publicRequest.NewTableName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotIdentifier())
                {
                    request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(publicRequest.SnapshotIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourceDatabaseName())
                {
                    request.Parameters.Add("SourceDatabaseName", StringUtils.FromString(publicRequest.SourceDatabaseName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourceSchemaName())
                {
                    request.Parameters.Add("SourceSchemaName", StringUtils.FromString(publicRequest.SourceSchemaName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourceTableName())
                {
                    request.Parameters.Add("SourceTableName", StringUtils.FromString(publicRequest.SourceTableName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTargetDatabaseName())
                {
                    request.Parameters.Add("TargetDatabaseName", StringUtils.FromString(publicRequest.TargetDatabaseName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTargetSchemaName())
                {
                    request.Parameters.Add("TargetSchemaName", StringUtils.FromString(publicRequest.TargetSchemaName));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static RestoreTableFromClusterSnapshotRequestMarshaller _instance = new RestoreTableFromClusterSnapshotRequestMarshaller();        

        internal static RestoreTableFromClusterSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreTableFromClusterSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}