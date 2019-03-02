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
    /// Base client model for Assessment that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class AssessmentEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public string AssessmentResultData { get; set; }

        /// <summary />
        public int AssessmentTypeID { get; set; }

        /// <summary />
        public DateTime? CompletedDateTime { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public DateTime? LastReminderDate { get; set; }

        /// <summary />
        public int PersonAliasID { get; set; }

        /// <summary />
        public DateTime? RequestedDateTime { get; set; }

        /// <summary />
        public DateTime? RequestedDueDate { get; set; }

        /// <summary />
        public int? RequestorPersonAliasID { get; set; }

        /// <summary />
        public Rock.Client.Enums.Status Status { get; set; }

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
        /// Copies the base properties from a source Assessment object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( Assessment source )
        {
            this.Id = source.Id;
            this.AssessmentResultData = source.AssessmentResultData;
            this.AssessmentTypeID = source.AssessmentTypeID;
            this.CompletedDateTime = source.CompletedDateTime;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.LastReminderDate = source.LastReminderDate;
            this.PersonAliasID = source.PersonAliasID;
            this.RequestedDateTime = source.RequestedDateTime;
            this.RequestedDueDate = source.RequestedDueDate;
            this.RequestorPersonAliasID = source.RequestorPersonAliasID;
            this.Status = source.Status;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for Assessment that includes all the fields that are available for GETs. Use this for GETs (use AssessmentEntity for POST/PUTs)
    /// </summary>
    public partial class Assessment : AssessmentEntity
    {
    }
}