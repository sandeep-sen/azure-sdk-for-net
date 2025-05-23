// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SelfHostedIntegrationRuntime : IUtf8JsonSerializable, IJsonModel<SelfHostedIntegrationRuntime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHostedIntegrationRuntime>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SelfHostedIntegrationRuntime>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntime)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedInfo))
            {
                writer.WritePropertyName("linkedInfo"u8);
                writer.WriteObjectValue(LinkedInfo, options);
            }
            if (Optional.IsDefined(IsSelfContainedInteractiveAuthoringEnabled))
            {
                writer.WritePropertyName("selfContainedInteractiveAuthoringEnabled"u8);
                writer.WriteBooleanValue(IsSelfContainedInteractiveAuthoringEnabled.Value);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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

        SelfHostedIntegrationRuntime IJsonModel<SelfHostedIntegrationRuntime>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntime)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHostedIntegrationRuntime(document.RootElement, options);
        }

        internal static SelfHostedIntegrationRuntime DeserializeSelfHostedIntegrationRuntime(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            string description = default;
            LinkedIntegrationRuntimeType linkedInfo = default;
            bool? selfContainedInteractiveAuthoringEnabled = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("linkedInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedInfo = LinkedIntegrationRuntimeType.DeserializeLinkedIntegrationRuntimeType(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("selfContainedInteractiveAuthoringEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            selfContainedInteractiveAuthoringEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SelfHostedIntegrationRuntime(type, description, additionalProperties, linkedInfo, selfContainedInteractiveAuthoringEnabled);
        }

        BinaryData IPersistableModel<SelfHostedIntegrationRuntime>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntime)} does not support writing '{options.Format}' format.");
            }
        }

        SelfHostedIntegrationRuntime IPersistableModel<SelfHostedIntegrationRuntime>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSelfHostedIntegrationRuntime(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntime)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHostedIntegrationRuntime>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
