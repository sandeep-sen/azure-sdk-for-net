// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteCircuitResource : IJsonModel<ExpressRouteCircuitData>
    {
        void IJsonModel<ExpressRouteCircuitData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteCircuitData>)Data).Write(writer, options);

        ExpressRouteCircuitData IJsonModel<ExpressRouteCircuitData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteCircuitData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ExpressRouteCircuitData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ExpressRouteCircuitData>(Data, options, AzureResourceManagerNetworkContext.Default);

        ExpressRouteCircuitData IPersistableModel<ExpressRouteCircuitData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ExpressRouteCircuitData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<ExpressRouteCircuitData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ExpressRouteCircuitData>)Data).GetFormatFromOptions(options);
    }
}
