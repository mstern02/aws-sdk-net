/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output of the PutPipelineDefinition action.</para>
    /// </summary>
    public class PutPipelineDefinitionResult
    {
        
        private List<ValidationError> validationErrors = new List<ValidationError>();
        private List<ValidationWarning> validationWarnings = new List<ValidationWarning>();
        private bool? errored;

        /// <summary>
        /// A list of the validation errors that are associated with the objects defined in <c>pipelineObjects</c>.
        ///  
        /// </summary>
        public List<ValidationError> ValidationErrors
        {
            get { return this.validationErrors; }
            set { this.validationErrors = value; }
        }
        /// <summary>
        /// Adds elements to the ValidationErrors collection
        /// </summary>
        /// <param name="validationErrors">The values to add to the ValidationErrors collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutPipelineDefinitionResult WithValidationErrors(params ValidationError[] validationErrors)
        {
            foreach (ValidationError element in validationErrors)
            {
                this.validationErrors.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ValidationErrors collection
        /// </summary>
        /// <param name="validationErrors">The values to add to the ValidationErrors collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutPipelineDefinitionResult WithValidationErrors(IEnumerable<ValidationError> validationErrors)
        {
            foreach (ValidationError element in validationErrors)
            {
                this.validationErrors.Add(element);
            }

            return this;
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this.validationErrors.Count > 0;
        }

        /// <summary>
        /// A list of the validation warnings that are associated with the objects defined in <c>pipelineObjects</c>.
        ///  
        /// </summary>
        public List<ValidationWarning> ValidationWarnings
        {
            get { return this.validationWarnings; }
            set { this.validationWarnings = value; }
        }
        /// <summary>
        /// Adds elements to the ValidationWarnings collection
        /// </summary>
        /// <param name="validationWarnings">The values to add to the ValidationWarnings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutPipelineDefinitionResult WithValidationWarnings(params ValidationWarning[] validationWarnings)
        {
            foreach (ValidationWarning element in validationWarnings)
            {
                this.validationWarnings.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ValidationWarnings collection
        /// </summary>
        /// <param name="validationWarnings">The values to add to the ValidationWarnings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutPipelineDefinitionResult WithValidationWarnings(IEnumerable<ValidationWarning> validationWarnings)
        {
            foreach (ValidationWarning element in validationWarnings)
            {
                this.validationWarnings.Add(element);
            }

            return this;
        }

        // Check to see if ValidationWarnings property is set
        internal bool IsSetValidationWarnings()
        {
            return this.validationWarnings.Count > 0;
        }

        /// <summary>
        /// If <c>True</c>, there were validation errors. If errored is <c>True</c>, the pipeline definition is stored but cannot be activated until you
        /// correct the pipeline and call <a>PutPipelineDefinition</a> to commit the corrected pipeline.
        ///  
        /// </summary>
        public bool Errored
        {
            get { return this.errored ?? default(bool); }
            set { this.errored = value; }
        }

        /// <summary>
        /// Sets the Errored property
        /// </summary>
        /// <param name="errored">The value to set for the Errored property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutPipelineDefinitionResult WithErrored(bool errored)
        {
            this.errored = errored;
            return this;
        }
            

        // Check to see if Errored property is set
        internal bool IsSetErrored()
        {
            return this.errored.HasValue;
        }
    }
}
