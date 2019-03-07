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
    /// Base client model for BinaryFileType that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class BinaryFileTypeEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public bool AllowCaching { get; set; }

        /// <summary />
        public string Description { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string IconCssClass { get; set; }

        /// <summary />
        public bool IsSystem { get; set; }

        /// <summary />
        public int? MaxHeight { get; set; }

        /// <summary />
        public int? MaxWidth { get; set; }

        /// <summary />
        public string Name { get; set; }

        /// <summary />
        public Rock.Client.Enums.ColorDepth PreferredColorDepth { get; set; } = Rock.Client.Enums.ColorDepth.Undefined;

        /// <summary />
        public Rock.Client.Enums.Format PreferredFormat { get; set; } = Rock.Client.Enums.Format.Undefined;

        /// <summary />
        public bool PreferredRequired { get; set; }

        /// <summary />
        public Rock.Client.Enums.Resolution PreferredResolution { get; set; } = Rock.Client.Enums.Resolution.Undefined;

        /// <summary />
        public bool RequiresViewSecurity { get; set; }

        /// <summary />
        public int? StorageEntityTypeId { get; set; }

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
        /// Copies the base properties from a source BinaryFileType object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( BinaryFileType source )
        {
            this.Id = source.Id;
            this.AllowCaching = source.AllowCaching;
            this.Description = source.Description;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.IconCssClass = source.IconCssClass;
            this.IsSystem = source.IsSystem;
            this.MaxHeight = source.MaxHeight;
            this.MaxWidth = source.MaxWidth;
            this.Name = source.Name;
            this.PreferredColorDepth = source.PreferredColorDepth;
            this.PreferredFormat = source.PreferredFormat;
            this.PreferredRequired = source.PreferredRequired;
            this.PreferredResolution = source.PreferredResolution;
            this.RequiresViewSecurity = source.RequiresViewSecurity;
            this.StorageEntityTypeId = source.StorageEntityTypeId;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for BinaryFileType that includes all the fields that are available for GETs. Use this for GETs (use BinaryFileTypeEntity for POST/PUTs)
    /// </summary>
    public partial class BinaryFileType : BinaryFileTypeEntity
    {
        /// <summary />
        public EntityType StorageEntityType { get; set; }

    }
}
