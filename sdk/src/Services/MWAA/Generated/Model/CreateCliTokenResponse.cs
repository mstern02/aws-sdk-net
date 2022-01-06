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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// This is the response object from the CreateCliToken operation.
    /// </summary>
    public partial class CreateCliTokenResponse : AmazonWebServiceResponse
    {
        private string _cliToken;
        private string _webServerHostname;

        /// <summary>
        /// Gets and sets the property CliToken. 
        /// <para>
        /// An Airflow CLI login token.
        /// </para>
        /// </summary>
        public string CliToken
        {
            get { return this._cliToken; }
            set { this._cliToken = value; }
        }

        // Check to see if CliToken property is set
        internal bool IsSetCliToken()
        {
            return this._cliToken != null;
        }

        /// <summary>
        /// Gets and sets the property WebServerHostname. 
        /// <para>
        /// The Airflow web server hostname for the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WebServerHostname
        {
            get { return this._webServerHostname; }
            set { this._webServerHostname = value; }
        }

        // Check to see if WebServerHostname property is set
        internal bool IsSetWebServerHostname()
        {
            return this._webServerHostname != null;
        }

    }
}