// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class IotOperationsDataflowProperties : IUtf8JsonSerializable, IJsonModel<IotOperationsDataflowProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotOperationsDataflowProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotOperationsDataflowProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsDataflowProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotOperationsDataflowProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WritePropertyName("operations"u8);
            writer.WriteStartArray();
            foreach (var item in Operations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        IotOperationsDataflowProperties IJsonModel<IotOperationsDataflowProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsDataflowProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotOperationsDataflowProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotOperationsDataflowProperties(document.RootElement, options);
        }

        internal static IotOperationsDataflowProperties DeserializeIotOperationsDataflowProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IotOperationsOperationalMode? mode = default;
            IList<DataflowOperationProperties> operations = default;
            IotOperationsProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new IotOperationsOperationalMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operations"u8))
                {
                    List<DataflowOperationProperties> array = new List<DataflowOperationProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataflowOperationProperties.DeserializeDataflowOperationProperties(item, options));
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new IotOperationsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotOperationsDataflowProperties(mode, operations, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotOperationsDataflowProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsDataflowProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotOperationsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IotOperationsDataflowProperties)} does not support writing '{options.Format}' format.");
            }
        }

        IotOperationsDataflowProperties IPersistableModel<IotOperationsDataflowProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsDataflowProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotOperationsDataflowProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotOperationsDataflowProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotOperationsDataflowProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
