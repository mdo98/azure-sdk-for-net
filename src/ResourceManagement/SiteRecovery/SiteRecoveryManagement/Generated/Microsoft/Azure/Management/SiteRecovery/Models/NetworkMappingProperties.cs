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
using System.Linq;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of Network Mapping Properties
    /// </summary>
    public partial class NetworkMappingProperties
    {
        private string _pairingStatus;
        
        /// <summary>
        /// Optional. Pairing Status
        /// </summary>
        public string PairingStatus
        {
            get { return this._pairingStatus; }
            set { this._pairingStatus = value; }
        }
        
        private string _primaryNetworkFriendlyName;
        
        /// <summary>
        /// Optional. Friendly name of the primary network.
        /// </summary>
        public string PrimaryNetworkFriendlyName
        {
            get { return this._primaryNetworkFriendlyName; }
            set { this._primaryNetworkFriendlyName = value; }
        }
        
        private string _recoveryNetworkFriendlyName;
        
        /// <summary>
        /// Optional. Friendly name of the recovery network.
        /// </summary>
        public string RecoveryNetworkFriendlyName
        {
            get { return this._recoveryNetworkFriendlyName; }
            set { this._recoveryNetworkFriendlyName = value; }
        }
        
        private string _recoveryNetworkId;
        
        /// <summary>
        /// Optional. Recovery network id of network mapping.
        /// </summary>
        public string RecoveryNetworkId
        {
            get { return this._recoveryNetworkId; }
            set { this._recoveryNetworkId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkMappingProperties class.
        /// </summary>
        public NetworkMappingProperties()
        {
        }
    }
}
