//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for RegistrationTemplateFormField that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class RegistrationTemplateFormFieldEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int? AttributeId { get; set; }

        /// <summary />
        public Rock.Client.Enums.RegistrationFieldSource FieldSource { get; set; }

        /// <summary />
        public string FieldVisibilityRulesJSON { get; set; } = @"[]";

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public bool IsGridField { get; set; }

        /// <summary />
        public bool IsInternal { get; set; }

        /// <summary />
        public bool IsRequired { get; set; }

        /// <summary />
        public bool IsSharedValue { get; set; }

        /// <summary />
        public int Order { get; set; }

        /// <summary />
        public Rock.Client.Enums.RegistrationPersonFieldType PersonFieldType { get; set; }

        /// <summary />
        public string PostText { get; set; }

        /// <summary />
        public string PreText { get; set; }

        /// <summary />
        public int RegistrationTemplateFormId { get; set; }

        /// <summary />
        public bool ShowCurrentValue { get; set; }

        /// <summary />
        public bool ShowOnWaitlist { get; set; }

        /// <summary />
        public DateTime? CreatedDateTime { get; set; }

        /// <summary />
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary />
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary />
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source RegistrationTemplateFormField object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( RegistrationTemplateFormField source )
        {
            this.Id = source.Id;
            this.AttributeId = source.AttributeId;
            this.FieldSource = source.FieldSource;
            this.FieldVisibilityRulesJSON = source.FieldVisibilityRulesJSON;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.IsGridField = source.IsGridField;
            this.IsInternal = source.IsInternal;
            this.IsRequired = source.IsRequired;
            this.IsSharedValue = source.IsSharedValue;
            this.Order = source.Order;
            this.PersonFieldType = source.PersonFieldType;
            this.PostText = source.PostText;
            this.PreText = source.PreText;
            this.RegistrationTemplateFormId = source.RegistrationTemplateFormId;
            this.ShowCurrentValue = source.ShowCurrentValue;
            this.ShowOnWaitlist = source.ShowOnWaitlist;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for RegistrationTemplateFormField that includes all the fields that are available for GETs. Use this for GETs (use RegistrationTemplateFormFieldEntity for POST/PUTs)
    /// </summary>
    public partial class RegistrationTemplateFormField : RegistrationTemplateFormFieldEntity
    {
        /// <summary />
        public Attribute Attribute { get; set; }

    }
}
