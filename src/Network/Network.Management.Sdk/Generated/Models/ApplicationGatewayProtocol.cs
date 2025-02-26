// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{

    /// <summary>
    /// Defines values for ApplicationGatewayProtocol.
    /// </summary>
    public static class ApplicationGatewayProtocol
    {
        /// <summary>
        /// Supported for httpListeners and  backendHttpSettingsCollection
        /// properties.
        /// </summary>
        public const string Http = "Http";
        /// <summary>
        /// Supported for httpListeners and  backendHttpSettingsCollection
        /// properties.
        /// </summary>
        public const string Https = "Https";
        /// <summary>
        /// Supported for listeners and backendSettingsCollection properties.
        /// </summary>
        public const string Tcp = "Tcp";
        /// <summary>
        /// Supported for listeners and backendSettingsCollection properties.
        /// </summary>
        public const string Tls = "Tls";
    }
}
