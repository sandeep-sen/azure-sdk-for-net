// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins
{
    internal class TimeSeriesDatabaseConnectionOperationSource : IOperationSource<TimeSeriesDatabaseConnectionResource>
    {
        private readonly ArmClient _client;

        internal TimeSeriesDatabaseConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        TimeSeriesDatabaseConnectionResource IOperationSource<TimeSeriesDatabaseConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<TimeSeriesDatabaseConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDigitalTwinsContext.Default);
            return new TimeSeriesDatabaseConnectionResource(_client, data);
        }

        async ValueTask<TimeSeriesDatabaseConnectionResource> IOperationSource<TimeSeriesDatabaseConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<TimeSeriesDatabaseConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDigitalTwinsContext.Default);
            return await Task.FromResult(new TimeSeriesDatabaseConnectionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
