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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the GetMonitor operation.
    /// Gets information about a monitor in Amazon CloudWatch Internet Monitor based on a
    /// monitor name. The information returned includes the Amazon Resource Name (ARN), create
    /// time, modified time, resources included in the monitor, and status information.
    /// </summary>
    public partial class GetMonitorRequest : AmazonInternetMonitorRequest
    {
        private string _linkedAccountId;
        private string _monitorName;

        /// <summary>
        /// Gets and sets the property LinkedAccountId. 
        /// <para>
        /// TBD 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string LinkedAccountId
        {
            get { return this._linkedAccountId; }
            set { this._linkedAccountId = value; }
        }

        // Check to see if LinkedAccountId property is set
        internal bool IsSetLinkedAccountId()
        {
            return this._linkedAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

    }
}