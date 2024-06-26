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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CheckoutLicense Request Marshaller
    /// </summary>       
    public class CheckoutLicenseRequestMarshaller : IMarshaller<IRequest, CheckoutLicenseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CheckoutLicenseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CheckoutLicenseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.CheckoutLicense";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBeneficiary())
                {
                    context.Writer.WritePropertyName("Beneficiary");
                    context.Writer.Write(publicRequest.Beneficiary);
                }

                if(publicRequest.IsSetCheckoutType())
                {
                    context.Writer.WritePropertyName("CheckoutType");
                    context.Writer.Write(publicRequest.CheckoutType);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetEntitlements())
                {
                    context.Writer.WritePropertyName("Entitlements");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEntitlementsListValue in publicRequest.Entitlements)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EntitlementDataMarshaller.Instance;
                        marshaller.Marshall(publicRequestEntitlementsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKeyFingerprint())
                {
                    context.Writer.WritePropertyName("KeyFingerprint");
                    context.Writer.Write(publicRequest.KeyFingerprint);
                }

                if(publicRequest.IsSetNodeId())
                {
                    context.Writer.WritePropertyName("NodeId");
                    context.Writer.Write(publicRequest.NodeId);
                }

                if(publicRequest.IsSetProductSKU())
                {
                    context.Writer.WritePropertyName("ProductSKU");
                    context.Writer.Write(publicRequest.ProductSKU);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CheckoutLicenseRequestMarshaller _instance = new CheckoutLicenseRequestMarshaller();        

        internal static CheckoutLicenseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CheckoutLicenseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618