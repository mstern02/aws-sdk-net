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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAttendee Request Marshaller
    /// </summary>       
    public class GetAttendeeRequestMarshaller : IMarshaller<IRequest, GetAttendeeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAttendeeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAttendeeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAttendeeId())
                throw new AmazonChimeException("Request object does not have required field AttendeeId set");
            request.AddPathResource("{attendeeId}", StringUtils.FromString(publicRequest.AttendeeId));
            if (!publicRequest.IsSetMeetingId())
                throw new AmazonChimeException("Request object does not have required field MeetingId set");
            request.AddPathResource("{meetingId}", StringUtils.FromString(publicRequest.MeetingId));
            request.ResourcePath = "/meetings/{meetingId}/attendees/{attendeeId}";

            return request;
        }
        private static GetAttendeeRequestMarshaller _instance = new GetAttendeeRequestMarshaller();        

        internal static GetAttendeeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAttendeeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618