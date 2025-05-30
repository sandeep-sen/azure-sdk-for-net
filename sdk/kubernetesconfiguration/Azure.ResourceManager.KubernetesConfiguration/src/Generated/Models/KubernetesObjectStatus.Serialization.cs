// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesObjectStatus : IUtf8JsonSerializable, IJsonModel<KubernetesObjectStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesObjectStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KubernetesObjectStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState.Value.ToString());
            }
            if (Optional.IsDefined(AppliedBy))
            {
                if (AppliedBy != null)
                {
                    writer.WritePropertyName("appliedBy"u8);
                    writer.WriteObjectValue(AppliedBy, options);
                }
                else
                {
                    writer.WriteNull("appliedBy");
                }
            }
            if (Optional.IsCollectionDefined(StatusConditions))
            {
                if (StatusConditions != null)
                {
                    writer.WritePropertyName("statusConditions"u8);
                    writer.WriteStartArray();
                    foreach (var item in StatusConditions)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("statusConditions");
                }
            }
            if (Optional.IsDefined(HelmReleaseProperties))
            {
                if (HelmReleaseProperties != null)
                {
                    writer.WritePropertyName("helmReleaseProperties"u8);
                    writer.WriteObjectValue(HelmReleaseProperties, options);
                }
                else
                {
                    writer.WriteNull("helmReleaseProperties");
                }
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

        KubernetesObjectStatus IJsonModel<KubernetesObjectStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesObjectStatus(document.RootElement, options);
        }

        internal static KubernetesObjectStatus DeserializeKubernetesObjectStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string @namespace = default;
            string kind = default;
            KubernetesFluxComplianceState? complianceState = default;
            KubernetesObjectReference appliedBy = default;
            IReadOnlyList<KubernetesObjectStatusCondition> statusConditions = default;
            HelmReleaseProperties helmReleaseProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceState = new KubernetesFluxComplianceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appliedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appliedBy = null;
                        continue;
                    }
                    appliedBy = KubernetesObjectReference.DeserializeKubernetesObjectReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("statusConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusConditions = null;
                        continue;
                    }
                    List<KubernetesObjectStatusCondition> array = new List<KubernetesObjectStatusCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesObjectStatusCondition.DeserializeKubernetesObjectStatusCondition(item, options));
                    }
                    statusConditions = array;
                    continue;
                }
                if (property.NameEquals("helmReleaseProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        helmReleaseProperties = null;
                        continue;
                    }
                    helmReleaseProperties = HelmReleaseProperties.DeserializeHelmReleaseProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KubernetesObjectStatus(
                name,
                @namespace,
                kind,
                complianceState,
                appliedBy,
                statusConditions ?? new ChangeTrackingList<KubernetesObjectStatusCondition>(),
                helmReleaseProperties,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Namespace), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  namespace: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Namespace))
                {
                    builder.Append("  namespace: ");
                    if (Namespace.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Namespace}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Namespace}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComplianceState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  complianceState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComplianceState))
                {
                    builder.Append("  complianceState: ");
                    builder.AppendLine($"'{ComplianceState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppliedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  appliedBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppliedBy))
                {
                    builder.Append("  appliedBy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AppliedBy, options, 2, false, "  appliedBy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatusConditions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  statusConditions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(StatusConditions))
                {
                    if (StatusConditions.Any())
                    {
                        builder.Append("  statusConditions: ");
                        builder.AppendLine("[");
                        foreach (var item in StatusConditions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  statusConditions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HelmReleaseProperties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  helmReleaseProperties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HelmReleaseProperties))
                {
                    builder.Append("  helmReleaseProperties: ");
                    BicepSerializationHelpers.AppendChildObject(builder, HelmReleaseProperties, options, 2, false, "  helmReleaseProperties: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<KubernetesObjectStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerKubernetesConfigurationContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesObjectStatus IPersistableModel<KubernetesObjectStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeKubernetesObjectStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesObjectStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
