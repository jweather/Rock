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
    /// Base client model for AssessmentType that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class AssessmentTypeEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public string AssessmentPath { get; set; }

        /// <summary />
        public string AssessmentResultsPath { get; set; }

        /// <summary />
        public string Description { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public bool IsActive { get; set; }

        /// <summary />
        public int MinimumDaysToRetake { get; set; }

        /// <summary />
        public bool RequiresRequest { get; set; }

        /// <summary />
        public string Title { get; set; }

        /// <summary />
        public int ValidDuration { get; set; }

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
        /// Copies the base properties from a source AssessmentType object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( AssessmentType source )
        {
            this.Id = source.Id;
            this.AssessmentPath = source.AssessmentPath;
            this.AssessmentResultsPath = source.AssessmentResultsPath;
            this.Description = source.Description;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.IsActive = source.IsActive;
            this.MinimumDaysToRetake = source.MinimumDaysToRetake;
            this.RequiresRequest = source.RequiresRequest;
            this.Title = source.Title;
            this.ValidDuration = source.ValidDuration;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for AssessmentType that includes all the fields that are available for GETs. Use this for GETs (use AssessmentTypeEntity for POST/PUTs)
    /// </summary>
    public partial class AssessmentType : AssessmentTypeEntity
    {
    }
}
