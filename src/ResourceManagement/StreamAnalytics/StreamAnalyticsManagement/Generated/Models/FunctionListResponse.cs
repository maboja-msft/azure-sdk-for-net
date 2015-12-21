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
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The response of the function list operation.
    /// </summary>
    public partial class FunctionListResponse : AzureOperationResponse
    {
        private DateTime _date;
        
        /// <summary>
        /// Optional. Gets a UTC date/time value generated by the service that
        /// indicates the time at which the response was initiated.
        /// </summary>
        public DateTime Date
        {
            get { return this._date; }
            set { this._date = value; }
        }
        
        private string _nextLink;
        
        /// <summary>
        /// Optional. Gets or sets the url returned by the Function List
        /// operation. It can be used by the client side to fetch the next
        /// page of Functions.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        private IList<Function> _value;
        
        /// <summary>
        /// Optional. Gets or sets the list of the returned Functions.
        /// </summary>
        public IList<Function> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FunctionListResponse class.
        /// </summary>
        public FunctionListResponse()
        {
            this.Value = new LazyList<Function>();
        }
    }
}
