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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAnomalyDetector Request Marshaller
    /// </summary>       
    public class PutAnomalyDetectorRequestMarshaller : IMarshaller<IRequest, PutAnomalyDetectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAnomalyDetectorRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAnomalyDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "PutAnomalyDetector");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConfiguration())
                {
                    if(publicRequest.Configuration.IsSetExcludedTimeRanges())
                    {
                        int publicRequestConfigurationlistValueIndex = 1;
                        foreach(var publicRequestConfigurationlistValue in publicRequest.Configuration.ExcludedTimeRanges)
                        {
                            if(publicRequestConfigurationlistValue.IsSetEndTime())
                            {
                                request.Parameters.Add("Configuration" + "." + "ExcludedTimeRanges" + "." + "member" + "." + publicRequestConfigurationlistValueIndex + "." + "EndTime", StringUtils.FromDateTimeToISO8601(publicRequestConfigurationlistValue.EndTime));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestConfigurationlistValue.IsSetStartTime())
                            {
                                request.Parameters.Add("Configuration" + "." + "ExcludedTimeRanges" + "." + "member" + "." + publicRequestConfigurationlistValueIndex + "." + "StartTime", StringUtils.FromDateTimeToISO8601(publicRequestConfigurationlistValue.StartTime));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestConfigurationlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Configuration.IsSetMetricTimezone())
                    {
                        request.Parameters.Add("Configuration" + "." + "MetricTimezone", StringUtils.FromString(publicRequest.Configuration.MetricTimezone));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDimensions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Dimensions)
                    {
                        if(publicRequestlistValue.IsSetName())
                        {
                            request.Parameters.Add("Dimensions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Dimensions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMetricMathAnomalyDetector())
                {
                    if(publicRequest.MetricMathAnomalyDetector.IsSetMetricDataQueries())
                    {
                        int publicRequestMetricMathAnomalyDetectorlistValueIndex = 1;
                        foreach(var publicRequestMetricMathAnomalyDetectorlistValue in publicRequest.MetricMathAnomalyDetector.MetricDataQueries)
                        {
                            if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetAccountId())
                            {
                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "AccountId", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.AccountId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetExpression())
                            {
                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.Expression));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetId())
                            {
                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.Id));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetLabel())
                            {
                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.Label));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetMetricStat())
                            {
                                if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetMetric())
                                {
                                    if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.IsSetDimensions())
                                    {
                                        int publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex = 1;
                                        foreach(var publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue in publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.Dimensions)
                                        {
                                            if(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.IsSetName())
                                            {
                                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.Name));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.IsSetValue())
                                            {
                                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.Value));
                                            }
#pragma warning restore CS0612,CS0618
                                            publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.IsSetMetricName())
                                    {
                                        request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.MetricName));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.IsSetNamespace())
                                    {
                                        request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.Namespace));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetPeriod())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Period", StringUtils.FromInt(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Period));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetStat())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Stat));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetUnit())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Unit));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetPeriod())
                            {
                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Period", StringUtils.FromInt(publicRequestMetricMathAnomalyDetectorlistValue.Period));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetReturnData())
                            {
                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestMetricMathAnomalyDetectorlistValue.ReturnData));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestMetricMathAnomalyDetectorlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMetricName())
                {
                    request.Parameters.Add("MetricName", StringUtils.FromString(publicRequest.MetricName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNamespace())
                {
                    request.Parameters.Add("Namespace", StringUtils.FromString(publicRequest.Namespace));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSingleMetricAnomalyDetector())
                {
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetAccountId())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "AccountId", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.AccountId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetDimensions())
                    {
                        int publicRequestSingleMetricAnomalyDetectorlistValueIndex = 1;
                        foreach(var publicRequestSingleMetricAnomalyDetectorlistValue in publicRequest.SingleMetricAnomalyDetector.Dimensions)
                        {
                            if(publicRequestSingleMetricAnomalyDetectorlistValue.IsSetName())
                            {
                                request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Dimensions" + "." + "member" + "." + publicRequestSingleMetricAnomalyDetectorlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestSingleMetricAnomalyDetectorlistValue.Name));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSingleMetricAnomalyDetectorlistValue.IsSetValue())
                            {
                                request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Dimensions" + "." + "member" + "." + publicRequestSingleMetricAnomalyDetectorlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestSingleMetricAnomalyDetectorlistValue.Value));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestSingleMetricAnomalyDetectorlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetMetricName())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "MetricName", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.MetricName));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetNamespace())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Namespace", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.Namespace));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetStat())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Stat", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.Stat));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStat())
                {
                    request.Parameters.Add("Stat", StringUtils.FromString(publicRequest.Stat));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static PutAnomalyDetectorRequestMarshaller _instance = new PutAnomalyDetectorRequestMarshaller();        

        internal static PutAnomalyDetectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAnomalyDetectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}