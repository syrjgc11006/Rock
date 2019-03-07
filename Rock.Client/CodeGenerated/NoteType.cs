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
    /// Base client model for NoteType that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class NoteTypeEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public bool AllowsAttachments { get; set; }

        /// <summary />
        public bool AllowsReplies { get; set; }

        /// <summary />
        public bool AllowsWatching { get; set; }

        /// <summary />
        public string ApprovalUrlTemplate { get; set; }

        /// <summary />
        public bool AutoWatchAuthors { get; set; }

        /// <summary />
        public string BackgroundColor { get; set; }

        /// <summary />
        public int? BinaryFileTypeId { get; set; }

        /// <summary />
        public string BorderColor { get; set; }

        /// <summary />
        [Obsolete( "No Longer Supported", false )]
        public string CssClass { get; set; }

        /// <summary />
        public int EntityTypeId { get; set; }

        /// <summary />
        public string EntityTypeQualifierColumn { get; set; }

        /// <summary />
        public string EntityTypeQualifierValue { get; set; }

        /// <summary />
        public string FontColor { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string IconCssClass { get; set; }

        /// <summary />
        public bool IsSystem { get; set; }

        /// <summary />
        public int? MaxReplyDepth { get; set; }

        /// <summary />
        public string Name { get; set; }

        /// <summary />
        public int Order { get; set; }

        /// <summary />
        public bool RequiresApprovals { get; set; }

        /// <summary />
        public bool SendApprovalNotifications { get; set; }

        /// <summary />
        public bool UserSelectable { get; set; }

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
        /// Copies the base properties from a source NoteType object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( NoteType source )
        {
            this.Id = source.Id;
            this.AllowsAttachments = source.AllowsAttachments;
            this.AllowsReplies = source.AllowsReplies;
            this.AllowsWatching = source.AllowsWatching;
            this.ApprovalUrlTemplate = source.ApprovalUrlTemplate;
            this.AutoWatchAuthors = source.AutoWatchAuthors;
            this.BackgroundColor = source.BackgroundColor;
            this.BinaryFileTypeId = source.BinaryFileTypeId;
            this.BorderColor = source.BorderColor;
            #pragma warning disable 612, 618
            this.CssClass = source.CssClass;
            #pragma warning restore 612, 618
            this.EntityTypeId = source.EntityTypeId;
            this.EntityTypeQualifierColumn = source.EntityTypeQualifierColumn;
            this.EntityTypeQualifierValue = source.EntityTypeQualifierValue;
            this.FontColor = source.FontColor;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.IconCssClass = source.IconCssClass;
            this.IsSystem = source.IsSystem;
            this.MaxReplyDepth = source.MaxReplyDepth;
            this.Name = source.Name;
            this.Order = source.Order;
            this.RequiresApprovals = source.RequiresApprovals;
            this.SendApprovalNotifications = source.SendApprovalNotifications;
            this.UserSelectable = source.UserSelectable;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for NoteType that includes all the fields that are available for GETs. Use this for GETs (use NoteTypeEntity for POST/PUTs)
    /// </summary>
    public partial class NoteType : NoteTypeEntity
    {
        /// <summary />
        public BinaryFileType BinaryFileType { get; set; }

        /// <summary />
        public EntityType EntityType { get; set; }

    }
}
