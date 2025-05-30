// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiIssueResource : IJsonModel<IssueContractData>
    {
        void IJsonModel<IssueContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<IssueContractData>)Data).Write(writer, options);

        IssueContractData IJsonModel<IssueContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<IssueContractData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<IssueContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<IssueContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        IssueContractData IPersistableModel<IssueContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<IssueContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<IssueContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<IssueContractData>)Data).GetFormatFromOptions(options);
    }
}
