// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.GraphServices
{
    public partial class GraphServicesAccountResource : IJsonModel<GraphServicesAccountResourceData>
    {
        void IJsonModel<GraphServicesAccountResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GraphServicesAccountResourceData>)Data).Write(writer, options);

        GraphServicesAccountResourceData IJsonModel<GraphServicesAccountResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GraphServicesAccountResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GraphServicesAccountResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<GraphServicesAccountResourceData>(Data, options, AzureResourceManagerGraphServicesContext.Default);

        GraphServicesAccountResourceData IPersistableModel<GraphServicesAccountResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GraphServicesAccountResourceData>(data, options, AzureResourceManagerGraphServicesContext.Default);

        string IPersistableModel<GraphServicesAccountResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GraphServicesAccountResourceData>)Data).GetFormatFromOptions(options);
    }
}
