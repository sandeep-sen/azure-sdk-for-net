// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The default strategy. This strategy currently uses a max_chunk_size_tokens of 800 and chunk_overlap_tokens of 400. </summary>
    public partial class VectorStoreAutoChunkingStrategy : VectorStoreChunkingStrategy
    {
        /// <summary> Initializes a new instance of <see cref="VectorStoreAutoChunkingStrategy"/>. </summary>
        public VectorStoreAutoChunkingStrategy()
        {
            Type = VectorStoreChunkingStrategyRequestType.Auto;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreAutoChunkingStrategy"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VectorStoreAutoChunkingStrategy(VectorStoreChunkingStrategyRequestType type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
