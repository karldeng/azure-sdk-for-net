// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// The Update Jobs State operation response.
    /// </summary>
    public partial class JobCollectionJobsUpdateStateResponse : OperationResponse, IEnumerable<Job>
    {
        private IList<Job> _jobs;
        
        /// <summary>
        /// Optional. The definitions of the updated jobs.
        /// </summary>
        public IList<Job> Jobs
        {
            get { return this._jobs; }
            set { this._jobs = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// JobCollectionJobsUpdateStateResponse class.
        /// </summary>
        public JobCollectionJobsUpdateStateResponse()
        {
            this.Jobs = new List<Job>();
        }
        
        /// <summary>
        /// Gets the sequence of Jobs.
        /// </summary>
        public IEnumerator<Job> GetEnumerator()
        {
            return this.Jobs.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Jobs.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
