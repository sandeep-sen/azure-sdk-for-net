// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ScoringRuleOptions : IUtf8JsonSerializable, IJsonModel<ScoringRuleOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScoringRuleOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScoringRuleOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScoringRuleOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScoringRuleOptions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Optional.IsCollectionDefined(ScoringParameters))
            {
                writer.WritePropertyName("scoringParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ScoringParameters)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsBatchScoringEnabled))
            {
                writer.WritePropertyName("isBatchScoringEnabled"u8);
                writer.WriteBooleanValue(IsBatchScoringEnabled.Value);
            }
            if (Optional.IsDefined(DescendingOrder))
            {
                writer.WritePropertyName("descendingOrder"u8);
                writer.WriteBooleanValue(DescendingOrder.Value);
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

        ScoringRuleOptions IJsonModel<ScoringRuleOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScoringRuleOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScoringRuleOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScoringRuleOptions(document.RootElement, options);
        }

        internal static ScoringRuleOptions DeserializeScoringRuleOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? batchSize = default;
            IList<ScoringRuleParameterSelector> scoringParameters = default;
            bool? isBatchScoringEnabled = default;
            bool? descendingOrder = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scoringParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringRuleParameterSelector> array = new List<ScoringRuleParameterSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScoringRuleParameterSelector(item.GetString()));
                    }
                    scoringParameters = array;
                    continue;
                }
                if (property.NameEquals("isBatchScoringEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isBatchScoringEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("descendingOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    descendingOrder = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScoringRuleOptions(batchSize, scoringParameters ?? new ChangeTrackingList<ScoringRuleParameterSelector>(), isBatchScoringEnabled, descendingOrder, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScoringRuleOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScoringRuleOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureCommunicationJobRouterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ScoringRuleOptions)} does not support writing '{options.Format}' format.");
            }
        }

        ScoringRuleOptions IPersistableModel<ScoringRuleOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScoringRuleOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeScoringRuleOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScoringRuleOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScoringRuleOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ScoringRuleOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeScoringRuleOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
