// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary>
    /// Model that represents the base action model. 9 total per experiment.
    /// Please note <see cref="ChaosExperimentAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ChaosContinuousAction"/>, <see cref="ChaosDelayAction"/> and <see cref="ChaosDiscreteAction"/>.
    /// </summary>
    public abstract partial class ChaosExperimentAction
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChaosExperimentAction"/>. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected ChaosExperimentAction(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosExperimentAction"/>. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="type"> Chaos experiment action discriminator type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChaosExperimentAction(string name, ExperimentActionType type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosExperimentAction"/> for deserialization. </summary>
        internal ChaosExperimentAction()
        {
        }

        /// <summary> String that represents a Capability URN. </summary>
        public string Name { get; set; }
        /// <summary> Chaos experiment action discriminator type. </summary>
        internal ExperimentActionType Type { get; set; }
    }
}
