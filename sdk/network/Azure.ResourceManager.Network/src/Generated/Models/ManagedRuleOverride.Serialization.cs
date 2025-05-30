// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ManagedRuleOverride : IUtf8JsonSerializable, IJsonModel<ManagedRuleOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedRuleOverride>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedRuleOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleOverride)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("ruleId"u8);
            writer.WriteStringValue(RuleId);
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(Sensitivity))
            {
                writer.WritePropertyName("sensitivity"u8);
                writer.WriteStringValue(Sensitivity.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ManagedRuleOverride IJsonModel<ManagedRuleOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleOverride)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRuleOverride(document.RootElement, options);
        }

        internal static ManagedRuleOverride DeserializeManagedRuleOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleId = default;
            ManagedRuleEnabledState? state = default;
            RuleMatchActionType? action = default;
            ManagedRuleSensitivityType? sensitivity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"u8))
                {
                    ruleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ManagedRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new RuleMatchActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sensitivity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivity = new ManagedRuleSensitivityType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedRuleOverride(ruleId, state, action, sensitivity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedRuleOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleOverride)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedRuleOverride IPersistableModel<ManagedRuleOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedRuleOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleOverride)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedRuleOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
