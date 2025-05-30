// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterRole : IUtf8JsonSerializable, IJsonModel<HDInsightClusterRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterRole>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightClusterRole>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterRole)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(MinInstanceCount))
            {
                writer.WritePropertyName("minInstanceCount"u8);
                writer.WriteNumberValue(MinInstanceCount.Value);
            }
            if (Optional.IsDefined(TargetInstanceCount))
            {
                writer.WritePropertyName("targetInstanceCount"u8);
                writer.WriteNumberValue(TargetInstanceCount.Value);
            }
            if (Optional.IsDefined(VmGroupName))
            {
                writer.WritePropertyName("VMGroupName"u8);
                writer.WriteStringValue(VmGroupName);
            }
            if (Optional.IsDefined(AutoScaleConfiguration))
            {
                writer.WritePropertyName("autoscale"u8);
                writer.WriteObjectValue(AutoScaleConfiguration, options);
            }
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile, options);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile, options);
            }
            if (Optional.IsDefined(VirtualNetworkProfile))
            {
                writer.WritePropertyName("virtualNetworkProfile"u8);
                writer.WriteObjectValue(VirtualNetworkProfile, options);
            }
            if (Optional.IsCollectionDefined(DataDisksGroups))
            {
                writer.WritePropertyName("dataDisksGroups"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisksGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScriptActions))
            {
                writer.WritePropertyName("scriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncryptDataDisks))
            {
                writer.WritePropertyName("encryptDataDisks"u8);
                writer.WriteBooleanValue(EncryptDataDisks.Value);
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

        HDInsightClusterRole IJsonModel<HDInsightClusterRole>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterRole)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterRole(document.RootElement, options);
        }

        internal static HDInsightClusterRole DeserializeHDInsightClusterRole(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int? minInstanceCount = default;
            int? targetInstanceCount = default;
            string vmGroupName = default;
            HDInsightAutoScaleConfiguration autoScale = default;
            HardwareProfile hardwareProfile = default;
            OSProfile osProfile = default;
            HDInsightVirtualNetworkProfile virtualNetworkProfile = default;
            IList<HDInsightClusterDataDiskGroup> dataDisksGroups = default;
            IList<ScriptAction> scriptActions = default;
            bool? encryptDataDisks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("VMGroupName"u8))
                {
                    vmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoscale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScale = HDInsightAutoScaleConfiguration.DeserializeHDInsightAutoScaleConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hardwareProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareProfile = HardwareProfile.DeserializeHardwareProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("osProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = OSProfile.DeserializeOSProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("virtualNetworkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualNetworkProfile = HDInsightVirtualNetworkProfile.DeserializeHDInsightVirtualNetworkProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataDisksGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightClusterDataDiskGroup> array = new List<HDInsightClusterDataDiskGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightClusterDataDiskGroup.DeserializeHDInsightClusterDataDiskGroup(item, options));
                    }
                    dataDisksGroups = array;
                    continue;
                }
                if (property.NameEquals("scriptActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptAction> array = new List<ScriptAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptAction.DeserializeScriptAction(item, options));
                    }
                    scriptActions = array;
                    continue;
                }
                if (property.NameEquals("encryptDataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptDataDisks = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightClusterRole(
                name,
                minInstanceCount,
                targetInstanceCount,
                vmGroupName,
                autoScale,
                hardwareProfile,
                osProfile,
                virtualNetworkProfile,
                dataDisksGroups ?? new ChangeTrackingList<HDInsightClusterDataDiskGroup>(),
                scriptActions ?? new ChangeTrackingList<ScriptAction>(),
                encryptDataDisks,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterRole>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHDInsightContext.Default);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterRole)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightClusterRole IPersistableModel<HDInsightClusterRole>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightClusterRole(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterRole)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterRole>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
