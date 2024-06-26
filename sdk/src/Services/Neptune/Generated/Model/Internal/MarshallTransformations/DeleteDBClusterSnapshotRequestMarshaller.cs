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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptune.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteDBClusterSnapshot Request Marshaller
    /// </summary>       
    public class DeleteDBClusterSnapshotRequestMarshaller : IMarshaller<IRequest, DeleteDBClusterSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDBClusterSnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteDBClusterSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptune");
            request.Parameters.Add("Action", "DeleteDBClusterSnapshot");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBClusterSnapshotIdentifier())
                {
                    request.Parameters.Add("DBClusterSnapshotIdentifier", StringUtils.FromString(publicRequest.DBClusterSnapshotIdentifier));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static DeleteDBClusterSnapshotRequestMarshaller _instance = new DeleteDBClusterSnapshotRequestMarshaller();        

        internal static DeleteDBClusterSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteDBClusterSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}