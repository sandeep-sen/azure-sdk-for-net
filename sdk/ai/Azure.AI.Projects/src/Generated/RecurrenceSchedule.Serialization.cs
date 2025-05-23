// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class RecurrenceSchedule : IUtf8JsonSerializable, IJsonModel<RecurrenceSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecurrenceSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecurrenceSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecurrenceSchedule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("hours"u8);
            writer.WriteStartArray();
            foreach (var item in Hours)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("minutes"u8);
            writer.WriteStartArray();
            foreach (var item in Minutes)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(WeekDays))
            {
                writer.WritePropertyName("weekDays"u8);
                writer.WriteStartArray();
                foreach (var item in WeekDays)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthDays))
            {
                writer.WritePropertyName("monthDays"u8);
                writer.WriteStartArray();
                foreach (var item in MonthDays)
                {
                    writer.WriteNumberValue(item);
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

        RecurrenceSchedule IJsonModel<RecurrenceSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecurrenceSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecurrenceSchedule(document.RootElement, options);
        }

        internal static RecurrenceSchedule DeserializeRecurrenceSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<int> hours = default;
            IList<int> minutes = default;
            IList<WeekDays> weekDays = default;
            IList<int> monthDays = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hours"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    hours = array;
                    continue;
                }
                if (property.NameEquals("minutes"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    minutes = array;
                    continue;
                }
                if (property.NameEquals("weekDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WeekDays> array = new List<WeekDays>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WeekDays(item.GetString()));
                    }
                    weekDays = array;
                    continue;
                }
                if (property.NameEquals("monthDays"u8))
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
                    monthDays = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecurrenceSchedule(hours, minutes, weekDays ?? new ChangeTrackingList<WeekDays>(), monthDays ?? new ChangeTrackingList<int>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecurrenceSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIProjectsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RecurrenceSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        RecurrenceSchedule IPersistableModel<RecurrenceSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRecurrenceSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecurrenceSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecurrenceSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RecurrenceSchedule FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRecurrenceSchedule(document.RootElement);
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
