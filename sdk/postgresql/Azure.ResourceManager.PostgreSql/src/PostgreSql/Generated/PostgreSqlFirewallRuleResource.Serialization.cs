// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql
{
    public partial class PostgreSqlFirewallRuleResource : IJsonModel<PostgreSqlFirewallRuleData>
    {
        void IJsonModel<PostgreSqlFirewallRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlFirewallRuleData>)Data).Write(writer, options);

        PostgreSqlFirewallRuleData IJsonModel<PostgreSqlFirewallRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlFirewallRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PostgreSqlFirewallRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PostgreSqlFirewallRuleData>(Data, options, AzureResourceManagerPostgreSqlContext.Default);

        PostgreSqlFirewallRuleData IPersistableModel<PostgreSqlFirewallRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PostgreSqlFirewallRuleData>(data, options, AzureResourceManagerPostgreSqlContext.Default);

        string IPersistableModel<PostgreSqlFirewallRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PostgreSqlFirewallRuleData>)Data).GetFormatFromOptions(options);
    }
}
