// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class SpringBootAppProperties : IUtf8JsonSerializable, IJsonModel<SpringBootAppProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpringBootAppProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SpringBootAppProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootAppProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AppName))
            {
                writer.WritePropertyName("appName"u8);
                writer.WriteStringValue(AppName);
            }
            if (Optional.IsDefined(ArtifactName))
            {
                writer.WritePropertyName("artifactName"u8);
                writer.WriteStringValue(ArtifactName);
            }
            if (Optional.IsDefined(AppPort))
            {
                writer.WritePropertyName("appPort"u8);
                writer.WriteNumberValue(AppPort.Value);
            }
            if (Optional.IsDefined(AppType))
            {
                writer.WritePropertyName("appType"u8);
                writer.WriteStringValue(AppType);
            }
            if (Optional.IsCollectionDefined(ApplicationConfigurations))
            {
                writer.WritePropertyName("applicationConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BindingPorts))
            {
                writer.WritePropertyName("bindingPorts"u8);
                writer.WriteStartArray();
                foreach (var item in BindingPorts)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BuildJdkVersion))
            {
                writer.WritePropertyName("buildJdkVersion"u8);
                writer.WriteStringValue(BuildJdkVersion);
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Checksum))
            {
                writer.WritePropertyName("checksum"u8);
                writer.WriteStringValue(Checksum);
            }
            if (Optional.IsCollectionDefined(Dependencies))
            {
                writer.WritePropertyName("dependencies"u8);
                writer.WriteStartArray();
                foreach (var item in Dependencies)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Environments))
            {
                writer.WritePropertyName("environments"u8);
                writer.WriteStartArray();
                foreach (var item in Environments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            if (Optional.IsDefined(JarFileLocation))
            {
                writer.WritePropertyName("jarFileLocation"u8);
                writer.WriteStringValue(JarFileLocation);
            }
            if (Optional.IsDefined(JvmMemoryInMB))
            {
                writer.WritePropertyName("jvmMemoryInMB"u8);
                writer.WriteNumberValue(JvmMemoryInMB.Value);
            }
            if (Optional.IsCollectionDefined(JvmOptions))
            {
                writer.WritePropertyName("jvmOptions"u8);
                writer.WriteStartArray();
                foreach (var item in JvmOptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Miscs))
            {
                writer.WritePropertyName("miscs"u8);
                writer.WriteStartArray();
                foreach (var item in Miscs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Instances))
            {
                writer.WritePropertyName("instances"u8);
                writer.WriteStartArray();
                foreach (var item in Instances)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RuntimeJdkVersion))
            {
                writer.WritePropertyName("runtimeJdkVersion"u8);
                writer.WriteStringValue(RuntimeJdkVersion);
            }
            if (Optional.IsCollectionDefined(Servers))
            {
                writer.WritePropertyName("servers"u8);
                writer.WriteStartArray();
                foreach (var item in Servers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MachineArmIds))
            {
                writer.WritePropertyName("machineArmIds"u8);
                writer.WriteStartArray();
                foreach (var item in MachineArmIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (Optional.IsDefined(SpringBootVersion))
            {
                writer.WritePropertyName("springBootVersion"u8);
                writer.WriteStringValue(SpringBootVersion);
            }
            if (Optional.IsCollectionDefined(StaticContentLocations))
            {
                writer.WritePropertyName("staticContentLocations"u8);
                writer.WriteStartArray();
                foreach (var item in StaticContentLocations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConnectionStrings))
            {
                writer.WritePropertyName("connectionStrings"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionStrings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        SpringBootAppProperties IJsonModel<SpringBootAppProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootAppProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpringBootAppProperties(document.RootElement, options);
        }

        internal static SpringBootAppProperties DeserializeSpringBootAppProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string appName = default;
            string artifactName = default;
            int? appPort = default;
            string appType = default;
            IList<SpringBootAppApplicationConfigurationsItem> applicationConfigurations = default;
            IList<int> bindingPorts = default;
            string buildJdkVersion = default;
            IList<string> certificates = default;
            string checksum = default;
            IList<string> dependencies = default;
            IList<string> environments = default;
            int? instanceCount = default;
            string jarFileLocation = default;
            int? jvmMemoryInMB = default;
            IList<string> jvmOptions = default;
            IList<SpringBootAppMiscsItem> miscs = default;
            IList<SpringBootAppInstancesItem> instances = default;
            string runtimeJdkVersion = default;
            IList<string> servers = default;
            IList<ResourceIdentifier> machineArmIds = default;
            string siteName = default;
            string springBootVersion = default;
            IList<string> staticContentLocations = default;
            IList<string> connectionStrings = default;
            DateTimeOffset? lastModifiedTime = default;
            DateTimeOffset? lastUpdatedTime = default;
            SpringAppDiscoveryProvisioningState? provisioningState = default;
            IList<SpringBootSiteError> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appName"u8))
                {
                    appName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactName"u8))
                {
                    artifactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appType"u8))
                {
                    appType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpringBootAppApplicationConfigurationsItem> array = new List<SpringBootAppApplicationConfigurationsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpringBootAppApplicationConfigurationsItem.DeserializeSpringBootAppApplicationConfigurationsItem(item, options));
                    }
                    applicationConfigurations = array;
                    continue;
                }
                if (property.NameEquals("bindingPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    bindingPorts = array;
                    continue;
                }
                if (property.NameEquals("buildJdkVersion"u8))
                {
                    buildJdkVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    certificates = array;
                    continue;
                }
                if (property.NameEquals("checksum"u8))
                {
                    checksum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dependencies = array;
                    continue;
                }
                if (property.NameEquals("environments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    environments = array;
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("jarFileLocation"u8))
                {
                    jarFileLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jvmMemoryInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jvmMemoryInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("jvmOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    jvmOptions = array;
                    continue;
                }
                if (property.NameEquals("miscs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpringBootAppMiscsItem> array = new List<SpringBootAppMiscsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpringBootAppMiscsItem.DeserializeSpringBootAppMiscsItem(item, options));
                    }
                    miscs = array;
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpringBootAppInstancesItem> array = new List<SpringBootAppInstancesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpringBootAppInstancesItem.DeserializeSpringBootAppInstancesItem(item, options));
                    }
                    instances = array;
                    continue;
                }
                if (property.NameEquals("runtimeJdkVersion"u8))
                {
                    runtimeJdkVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    servers = array;
                    continue;
                }
                if (property.NameEquals("machineArmIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    machineArmIds = array;
                    continue;
                }
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("springBootVersion"u8))
                {
                    springBootVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("staticContentLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    staticContentLocations = array;
                    continue;
                }
                if (property.NameEquals("connectionStrings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    connectionStrings = array;
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SpringAppDiscoveryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpringBootSiteError> array = new List<SpringBootSiteError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpringBootSiteError.DeserializeSpringBootSiteError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SpringBootAppProperties(
                appName,
                artifactName,
                appPort,
                appType,
                applicationConfigurations ?? new ChangeTrackingList<SpringBootAppApplicationConfigurationsItem>(),
                bindingPorts ?? new ChangeTrackingList<int>(),
                buildJdkVersion,
                certificates ?? new ChangeTrackingList<string>(),
                checksum,
                dependencies ?? new ChangeTrackingList<string>(),
                environments ?? new ChangeTrackingList<string>(),
                instanceCount,
                jarFileLocation,
                jvmMemoryInMB,
                jvmOptions ?? new ChangeTrackingList<string>(),
                miscs ?? new ChangeTrackingList<SpringBootAppMiscsItem>(),
                instances ?? new ChangeTrackingList<SpringBootAppInstancesItem>(),
                runtimeJdkVersion,
                servers ?? new ChangeTrackingList<string>(),
                machineArmIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                siteName,
                springBootVersion,
                staticContentLocations ?? new ChangeTrackingList<string>(),
                connectionStrings ?? new ChangeTrackingList<string>(),
                lastModifiedTime,
                lastUpdatedTime,
                provisioningState,
                errors ?? new ChangeTrackingList<SpringBootSiteError>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpringBootAppProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSpringAppDiscoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SpringBootAppProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SpringBootAppProperties IPersistableModel<SpringBootAppProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSpringBootAppProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpringBootAppProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpringBootAppProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
