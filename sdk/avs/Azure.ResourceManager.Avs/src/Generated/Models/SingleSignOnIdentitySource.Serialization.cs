// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class SingleSignOnIdentitySource : IUtf8JsonSerializable, IJsonModel<SingleSignOnIdentitySource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingleSignOnIdentitySource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SingleSignOnIdentitySource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleSignOnIdentitySource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleSignOnIdentitySource)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Alias))
            {
                writer.WritePropertyName("alias"u8);
                writer.WriteStringValue(Alias);
            }
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (Optional.IsDefined(BaseUserDN))
            {
                writer.WritePropertyName("baseUserDN"u8);
                writer.WriteStringValue(BaseUserDN);
            }
            if (Optional.IsDefined(BaseGroupDN))
            {
                writer.WritePropertyName("baseGroupDN"u8);
                writer.WriteStringValue(BaseGroupDN);
            }
            if (Optional.IsDefined(PrimaryServer))
            {
                writer.WritePropertyName("primaryServer"u8);
                writer.WriteStringValue(PrimaryServer.AbsoluteUri);
            }
            if (Optional.IsDefined(SecondaryServer))
            {
                writer.WritePropertyName("secondaryServer"u8);
                writer.WriteStringValue(SecondaryServer.AbsoluteUri);
            }
            if (Optional.IsDefined(Ssl))
            {
                writer.WritePropertyName("ssl"u8);
                writer.WriteStringValue(Ssl.Value.ToString());
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        SingleSignOnIdentitySource IJsonModel<SingleSignOnIdentitySource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleSignOnIdentitySource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleSignOnIdentitySource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingleSignOnIdentitySource(document.RootElement, options);
        }

        internal static SingleSignOnIdentitySource DeserializeSingleSignOnIdentitySource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string @alias = default;
            string domain = default;
            string baseUserDN = default;
            string baseGroupDN = default;
            Uri primaryServer = default;
            Uri secondaryServer = default;
            SslCertificateStatus? ssl = default;
            string username = default;
            string password = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alias"u8))
                {
                    @alias = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseUserDN"u8))
                {
                    baseUserDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseGroupDN"u8))
                {
                    baseGroupDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryServer = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryServer = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ssl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssl = new SslCertificateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SingleSignOnIdentitySource(
                name,
                @alias,
                domain,
                baseUserDN,
                baseGroupDN,
                primaryServer,
                secondaryServer,
                ssl,
                username,
                password,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SingleSignOnIdentitySource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleSignOnIdentitySource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAvsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SingleSignOnIdentitySource)} does not support writing '{options.Format}' format.");
            }
        }

        SingleSignOnIdentitySource IPersistableModel<SingleSignOnIdentitySource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleSignOnIdentitySource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSingleSignOnIdentitySource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SingleSignOnIdentitySource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingleSignOnIdentitySource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
