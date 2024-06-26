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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Allows setting a specific user's job to run first.
    /// </summary>
    public partial class UserJobsFirst
    {
        private string _userIdentityId;

        /// <summary>
        /// Gets and sets the property UserIdentityId. 
        /// <para>
        /// The user's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserIdentityId
        {
            get { return this._userIdentityId; }
            set { this._userIdentityId = value; }
        }

        // Check to see if UserIdentityId property is set
        internal bool IsSetUserIdentityId()
        {
            return this._userIdentityId != null;
        }

    }
}