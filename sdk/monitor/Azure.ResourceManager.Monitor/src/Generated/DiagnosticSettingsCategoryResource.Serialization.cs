// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Monitor
{
    public partial class DiagnosticSettingsCategoryResource : IJsonModel<DiagnosticSettingsCategoryData>
    {
        void IJsonModel<DiagnosticSettingsCategoryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DiagnosticSettingsCategoryData>)Data).Write(writer, options);

        DiagnosticSettingsCategoryData IJsonModel<DiagnosticSettingsCategoryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DiagnosticSettingsCategoryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DiagnosticSettingsCategoryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DiagnosticSettingsCategoryData>(Data, options, AzureResourceManagerMonitorContext.Default);

        DiagnosticSettingsCategoryData IPersistableModel<DiagnosticSettingsCategoryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DiagnosticSettingsCategoryData>(data, options, AzureResourceManagerMonitorContext.Default);

        string IPersistableModel<DiagnosticSettingsCategoryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DiagnosticSettingsCategoryData>)Data).GetFormatFromOptions(options);
    }
}
