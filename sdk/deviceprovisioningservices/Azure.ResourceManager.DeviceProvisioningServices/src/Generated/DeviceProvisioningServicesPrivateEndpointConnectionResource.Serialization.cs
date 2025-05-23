// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    public partial class DeviceProvisioningServicesPrivateEndpointConnectionResource : IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionData>
    {
        void IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionData>)Data).Write(writer, options);

        DeviceProvisioningServicesPrivateEndpointConnectionData IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DeviceProvisioningServicesPrivateEndpointConnectionData>(Data, options, AzureResourceManagerDeviceProvisioningServicesContext.Default);

        DeviceProvisioningServicesPrivateEndpointConnectionData IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DeviceProvisioningServicesPrivateEndpointConnectionData>(data, options, AzureResourceManagerDeviceProvisioningServicesContext.Default);

        string IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionData>)Data).GetFormatFromOptions(options);
    }
}
