// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HealthBot
{
    internal class HealthBotOperationSource : IOperationSource<HealthBotResource>
    {
        private readonly ArmClient _client;

        internal HealthBotOperationSource(ArmClient client)
        {
            _client = client;
        }

        HealthBotResource IOperationSource<HealthBotResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HealthBotData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHealthBotContext.Default);
            return new HealthBotResource(_client, data);
        }

        async ValueTask<HealthBotResource> IOperationSource<HealthBotResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HealthBotData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHealthBotContext.Default);
            return await Task.FromResult(new HealthBotResource(_client, data)).ConfigureAwait(false);
        }
    }
}
