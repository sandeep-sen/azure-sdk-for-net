// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryMigrationItemProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryMigrationItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryMigrationItemProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryMigrationItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrationItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryMigrationItemProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(MachineName))
            {
                writer.WritePropertyName("machineName"u8);
                writer.WriteStringValue(MachineName);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyFriendlyName))
            {
                writer.WritePropertyName("policyFriendlyName"u8);
                writer.WriteStringValue(PolicyFriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(RecoveryServicesProviderId))
            {
                writer.WritePropertyName("recoveryServicesProviderId"u8);
                writer.WriteStringValue(RecoveryServicesProviderId);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationStatus))
            {
                writer.WritePropertyName("replicationStatus"u8);
                writer.WriteStringValue(ReplicationStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteStringValue(MigrationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationStateDescription))
            {
                writer.WritePropertyName("migrationStateDescription"u8);
                writer.WriteStringValue(MigrationStateDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(LastTestMigrationOn))
            {
                writer.WritePropertyName("lastTestMigrationTime"u8);
                writer.WriteStringValue(LastTestMigrationOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastTestMigrationStatus))
            {
                writer.WritePropertyName("lastTestMigrationStatus"u8);
                writer.WriteStringValue(LastTestMigrationStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(LastMigrationOn))
            {
                writer.WritePropertyName("lastMigrationTime"u8);
                writer.WriteStringValue(LastMigrationOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastMigrationStatus))
            {
                writer.WritePropertyName("lastMigrationStatus"u8);
                writer.WriteStringValue(LastMigrationStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(TestMigrateState))
            {
                writer.WritePropertyName("testMigrateState"u8);
                writer.WriteStringValue(TestMigrateState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TestMigrateStateDescription))
            {
                writer.WritePropertyName("testMigrateStateDescription"u8);
                writer.WriteStringValue(TestMigrateStateDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AllowedOperations))
            {
                writer.WritePropertyName("allowedOperations"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedOperations)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentJob))
            {
                writer.WritePropertyName("currentJob"u8);
                writer.WriteObjectValue(CurrentJob, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CriticalJobHistory))
            {
                writer.WritePropertyName("criticalJobHistory"u8);
                writer.WriteStartArray();
                foreach (var item in CriticalJobHistory)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(EventCorrelationId))
            {
                writer.WritePropertyName("eventCorrelationId"u8);
                writer.WriteStringValue(EventCorrelationId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails, options);
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

        SiteRecoveryMigrationItemProperties IJsonModel<SiteRecoveryMigrationItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrationItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryMigrationItemProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryMigrationItemProperties(document.RootElement, options);
        }

        internal static SiteRecoveryMigrationItemProperties DeserializeSiteRecoveryMigrationItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string machineName = default;
            ResourceIdentifier policyId = default;
            string policyFriendlyName = default;
            string recoveryServicesProviderId = default;
            string replicationStatus = default;
            SiteRecoveryMigrationState? migrationState = default;
            string migrationStateDescription = default;
            DateTimeOffset? lastTestMigrationTime = default;
            string lastTestMigrationStatus = default;
            DateTimeOffset? lastMigrationTime = default;
            string lastMigrationStatus = default;
            TestMigrationState? testMigrateState = default;
            string testMigrateStateDescription = default;
            SiteRecoveryProtectionHealth? health = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            IReadOnlyList<MigrationItemOperation> allowedOperations = default;
            CurrentJobDetails currentJob = default;
            IReadOnlyList<CriticalJobHistoryDetails> criticalJobHistory = default;
            string eventCorrelationId = default;
            MigrationProviderSpecificSettings providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyFriendlyName"u8))
                {
                    policyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderId"u8))
                {
                    recoveryServicesProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationStatus"u8))
                {
                    replicationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = new SiteRecoveryMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationStateDescription"u8))
                {
                    migrationStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastTestMigrationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTestMigrationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTestMigrationStatus"u8))
                {
                    lastTestMigrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastMigrationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastMigrationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastMigrationStatus"u8))
                {
                    lastMigrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testMigrateState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testMigrateState = new TestMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testMigrateStateDescription"u8))
                {
                    testMigrateStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("allowedOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigrationItemOperation> array = new List<MigrationItemOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MigrationItemOperation(item.GetString()));
                    }
                    allowedOperations = array;
                    continue;
                }
                if (property.NameEquals("currentJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentJob = CurrentJobDetails.DeserializeCurrentJobDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("criticalJobHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CriticalJobHistoryDetails> array = new List<CriticalJobHistoryDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CriticalJobHistoryDetails.DeserializeCriticalJobHistoryDetails(item, options));
                    }
                    criticalJobHistory = array;
                    continue;
                }
                if (property.NameEquals("eventCorrelationId"u8))
                {
                    eventCorrelationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = MigrationProviderSpecificSettings.DeserializeMigrationProviderSpecificSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryMigrationItemProperties(
                machineName,
                policyId,
                policyFriendlyName,
                recoveryServicesProviderId,
                replicationStatus,
                migrationState,
                migrationStateDescription,
                lastTestMigrationTime,
                lastTestMigrationStatus,
                lastMigrationTime,
                lastMigrationStatus,
                testMigrateState,
                testMigrateStateDescription,
                health,
                healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                allowedOperations ?? new ChangeTrackingList<MigrationItemOperation>(),
                currentJob,
                criticalJobHistory ?? new ChangeTrackingList<CriticalJobHistoryDetails>(),
                eventCorrelationId,
                providerSpecificDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryMigrationItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrationItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryMigrationItemProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryMigrationItemProperties IPersistableModel<SiteRecoveryMigrationItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrationItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSiteRecoveryMigrationItemProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryMigrationItemProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryMigrationItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
