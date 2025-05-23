// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.AdditionalProperties
{
    public partial class IsUnknownAdditionalPropertiesDiscriminatedDerived : IJsonModel<IsUnknownAdditionalPropertiesDiscriminatedDerived>
    {
        internal IsUnknownAdditionalPropertiesDiscriminatedDerived() => throw null;

        void IJsonModel<IsUnknownAdditionalPropertiesDiscriminatedDerived>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        IsUnknownAdditionalPropertiesDiscriminatedDerived IJsonModel<IsUnknownAdditionalPropertiesDiscriminatedDerived>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected override IsUnknownAdditionalPropertiesDiscriminated JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<IsUnknownAdditionalPropertiesDiscriminatedDerived>.Write(ModelReaderWriterOptions options) => throw null;

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        IsUnknownAdditionalPropertiesDiscriminatedDerived IPersistableModel<IsUnknownAdditionalPropertiesDiscriminatedDerived>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected override IsUnknownAdditionalPropertiesDiscriminated PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<IsUnknownAdditionalPropertiesDiscriminatedDerived>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="isUnknownAdditionalPropertiesDiscriminatedDerived"> The <see cref="IsUnknownAdditionalPropertiesDiscriminatedDerived"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(IsUnknownAdditionalPropertiesDiscriminatedDerived isUnknownAdditionalPropertiesDiscriminatedDerived) => throw null;

        public static explicit operator IsUnknownAdditionalPropertiesDiscriminatedDerived(Response result) => throw null;
    }
}
