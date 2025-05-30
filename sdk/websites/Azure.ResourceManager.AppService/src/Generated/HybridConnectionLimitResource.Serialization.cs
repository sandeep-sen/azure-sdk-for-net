// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class HybridConnectionLimitResource : IJsonModel<HybridConnectionLimitData>
    {
        void IJsonModel<HybridConnectionLimitData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HybridConnectionLimitData>)Data).Write(writer, options);

        HybridConnectionLimitData IJsonModel<HybridConnectionLimitData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HybridConnectionLimitData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HybridConnectionLimitData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<HybridConnectionLimitData>(Data, options, AzureResourceManagerAppServiceContext.Default);

        HybridConnectionLimitData IPersistableModel<HybridConnectionLimitData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HybridConnectionLimitData>(data, options, AzureResourceManagerAppServiceContext.Default);

        string IPersistableModel<HybridConnectionLimitData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HybridConnectionLimitData>)Data).GetFormatFromOptions(options);
    }
}
