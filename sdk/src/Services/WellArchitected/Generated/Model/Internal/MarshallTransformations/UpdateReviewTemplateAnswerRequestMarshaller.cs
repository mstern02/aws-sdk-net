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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateReviewTemplateAnswer Request Marshaller
    /// </summary>       
    public class UpdateReviewTemplateAnswerRequestMarshaller : IMarshaller<IRequest, UpdateReviewTemplateAnswerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateReviewTemplateAnswerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateReviewTemplateAnswerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetLensAlias())
                throw new AmazonWellArchitectedException("Request object does not have required field LensAlias set");
            request.AddPathResource("{LensAlias}", StringUtils.FromString(publicRequest.LensAlias));
            if (!publicRequest.IsSetQuestionId())
                throw new AmazonWellArchitectedException("Request object does not have required field QuestionId set");
            request.AddPathResource("{QuestionId}", StringUtils.FromString(publicRequest.QuestionId));
            if (!publicRequest.IsSetTemplateArn())
                throw new AmazonWellArchitectedException("Request object does not have required field TemplateArn set");
            request.AddPathResource("{TemplateArn}", StringUtils.FromString(publicRequest.TemplateArn));
            request.ResourcePath = "/reviewTemplates/{TemplateArn}/lensReviews/{LensAlias}/answers/{QuestionId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChoiceUpdates())
                {
                    context.Writer.WritePropertyName("ChoiceUpdates");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestChoiceUpdatesKvp in publicRequest.ChoiceUpdates)
                    {
                        context.Writer.WritePropertyName(publicRequestChoiceUpdatesKvp.Key);
                        var publicRequestChoiceUpdatesValue = publicRequestChoiceUpdatesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = ChoiceUpdateMarshaller.Instance;
                        marshaller.Marshall(publicRequestChoiceUpdatesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIsApplicable())
                {
                    context.Writer.WritePropertyName("IsApplicable");
                    context.Writer.Write(publicRequest.IsApplicable);
                }

                if(publicRequest.IsSetNotes())
                {
                    context.Writer.WritePropertyName("Notes");
                    context.Writer.Write(publicRequest.Notes);
                }

                if(publicRequest.IsSetReason())
                {
                    context.Writer.WritePropertyName("Reason");
                    context.Writer.Write(publicRequest.Reason);
                }

                if(publicRequest.IsSetSelectedChoices())
                {
                    context.Writer.WritePropertyName("SelectedChoices");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSelectedChoicesListValue in publicRequest.SelectedChoices)
                    {
                            context.Writer.Write(publicRequestSelectedChoicesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateReviewTemplateAnswerRequestMarshaller _instance = new UpdateReviewTemplateAnswerRequestMarshaller();        

        internal static UpdateReviewTemplateAnswerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateReviewTemplateAnswerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618