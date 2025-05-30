// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPortReuseHoldTimes : IUtf8JsonSerializable, IJsonModel<MobileNetworkPortReuseHoldTimes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkPortReuseHoldTimes>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MobileNetworkPortReuseHoldTimes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Tcp))
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteNumberValue(Tcp.Value);
            }
            if (Optional.IsDefined(Udp))
            {
                writer.WritePropertyName("udp"u8);
                writer.WriteNumberValue(Udp.Value);
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

        MobileNetworkPortReuseHoldTimes IJsonModel<MobileNetworkPortReuseHoldTimes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPortReuseHoldTimes(document.RootElement, options);
        }

        internal static MobileNetworkPortReuseHoldTimes DeserializeMobileNetworkPortReuseHoldTimes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? tcp = default;
            int? udp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("udp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    udp = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MobileNetworkPortReuseHoldTimes(tcp, udp, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tcp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tcp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Tcp))
                {
                    builder.Append("  tcp: ");
                    builder.AppendLine($"{Tcp.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Udp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  udp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Udp))
                {
                    builder.Append("  udp: ");
                    builder.AppendLine($"{Udp.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MobileNetworkPortReuseHoldTimes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMobileNetworkContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support writing '{options.Format}' format.");
            }
        }

        MobileNetworkPortReuseHoldTimes IPersistableModel<MobileNetworkPortReuseHoldTimes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMobileNetworkPortReuseHoldTimes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkPortReuseHoldTimes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
