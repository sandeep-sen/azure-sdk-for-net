// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.OracleDatabase
{
    public partial class AutonomousDatabaseBackupResource : IJsonModel<AutonomousDatabaseBackupData>
    {
        void IJsonModel<AutonomousDatabaseBackupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutonomousDatabaseBackupData>)Data).Write(writer, options);

        AutonomousDatabaseBackupData IJsonModel<AutonomousDatabaseBackupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutonomousDatabaseBackupData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AutonomousDatabaseBackupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AutonomousDatabaseBackupData>(Data, options, AzureResourceManagerOracleDatabaseContext.Default);

        AutonomousDatabaseBackupData IPersistableModel<AutonomousDatabaseBackupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutonomousDatabaseBackupData>(data, options, AzureResourceManagerOracleDatabaseContext.Default);

        string IPersistableModel<AutonomousDatabaseBackupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutonomousDatabaseBackupData>)Data).GetFormatFromOptions(options);
    }
}
