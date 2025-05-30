// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    public partial class SapDiscoverySiteResource : IJsonModel<SapDiscoverySiteData>
    {
        void IJsonModel<SapDiscoverySiteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SapDiscoverySiteData>)Data).Write(writer, options);

        SapDiscoverySiteData IJsonModel<SapDiscoverySiteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SapDiscoverySiteData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SapDiscoverySiteData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SapDiscoverySiteData>(Data, options, AzureResourceManagerMigrationDiscoverySapContext.Default);

        SapDiscoverySiteData IPersistableModel<SapDiscoverySiteData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SapDiscoverySiteData>(data, options, AzureResourceManagerMigrationDiscoverySapContext.Default);

        string IPersistableModel<SapDiscoverySiteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SapDiscoverySiteData>)Data).GetFormatFromOptions(options);
    }
}
