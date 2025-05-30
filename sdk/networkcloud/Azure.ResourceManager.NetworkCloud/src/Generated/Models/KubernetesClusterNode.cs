// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> KubernetesClusterNode represents the details of a node in a Kubernetes cluster. </summary>
    public partial class KubernetesClusterNode
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterNode"/>. </summary>
        internal KubernetesClusterNode()
        {
            Labels = new ChangeTrackingList<KubernetesLabel>();
            NetworkAttachments = new ChangeTrackingList<NetworkAttachment>();
            Taints = new ChangeTrackingList<KubernetesLabel>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterNode"/>. </summary>
        /// <param name="agentPoolArmId"> The resource ID of the agent pool that this node belongs to. This value is not represented on control plane nodes. </param>
        /// <param name="availabilityZone"> The availability zone this node is running within. </param>
        /// <param name="bareMetalMachineArmId"> The resource ID of the bare metal machine that hosts this node. </param>
        /// <param name="cpuCores"> The number of CPU cores configured for this node, derived from the VM SKU specified. </param>
        /// <param name="detailedStatus"> The detailed state of this node. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="diskSizeGB"> The size of the disk configured for this node. Allocations are measured in gibibytes. </param>
        /// <param name="image"> The machine image used to deploy this node. </param>
        /// <param name="kubernetesVersion"> The currently running version of Kubernetes and bundled features running on this node. </param>
        /// <param name="labels"> The list of labels on this node that have been assigned to the agent pool containing this node. </param>
        /// <param name="memorySizeGB"> The amount of memory configured for this node, derived from the vm SKU specified. Allocations are measured in gibibytes. </param>
        /// <param name="mode"> The mode of the agent pool containing this node. Not applicable for control plane nodes. </param>
        /// <param name="name"> The name of this node, as realized in the Kubernetes cluster. </param>
        /// <param name="networkAttachments"> The NetworkAttachments made to this node. </param>
        /// <param name="powerState"> The power state of this node. </param>
        /// <param name="role"> The role of this node in the cluster. </param>
        /// <param name="taints"> The list of taints that have been assigned to the agent pool containing this node. </param>
        /// <param name="vmSkuName"> The VM SKU name that was used to create this cluster node. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesClusterNode(ResourceIdentifier agentPoolArmId, string availabilityZone, ResourceIdentifier bareMetalMachineArmId, long? cpuCores, KubernetesClusterNodeDetailedStatus? detailedStatus, string detailedStatusMessage, long? diskSizeGB, string image, string kubernetesVersion, IReadOnlyList<KubernetesLabel> labels, long? memorySizeGB, NetworkCloudAgentPoolMode? mode, string name, IReadOnlyList<NetworkAttachment> networkAttachments, KubernetesNodePowerState? powerState, KubernetesNodeRole? role, IReadOnlyList<KubernetesLabel> taints, string vmSkuName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AgentPoolArmId = agentPoolArmId;
            AvailabilityZone = availabilityZone;
            BareMetalMachineArmId = bareMetalMachineArmId;
            CpuCores = cpuCores;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            DiskSizeGB = diskSizeGB;
            Image = image;
            KubernetesVersion = kubernetesVersion;
            Labels = labels;
            MemorySizeGB = memorySizeGB;
            Mode = mode;
            Name = name;
            NetworkAttachments = networkAttachments;
            PowerState = powerState;
            Role = role;
            Taints = taints;
            VmSkuName = vmSkuName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the agent pool that this node belongs to. This value is not represented on control plane nodes. </summary>
        public ResourceIdentifier AgentPoolArmId { get; }
        /// <summary> The availability zone this node is running within. </summary>
        public string AvailabilityZone { get; }
        /// <summary> The resource ID of the bare metal machine that hosts this node. </summary>
        public ResourceIdentifier BareMetalMachineArmId { get; }
        /// <summary> The number of CPU cores configured for this node, derived from the VM SKU specified. </summary>
        public long? CpuCores { get; }
        /// <summary> The detailed state of this node. </summary>
        public KubernetesClusterNodeDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The size of the disk configured for this node. Allocations are measured in gibibytes. </summary>
        public long? DiskSizeGB { get; }
        /// <summary> The machine image used to deploy this node. </summary>
        public string Image { get; }
        /// <summary> The currently running version of Kubernetes and bundled features running on this node. </summary>
        public string KubernetesVersion { get; }
        /// <summary> The list of labels on this node that have been assigned to the agent pool containing this node. </summary>
        public IReadOnlyList<KubernetesLabel> Labels { get; }
        /// <summary> The amount of memory configured for this node, derived from the vm SKU specified. Allocations are measured in gibibytes. </summary>
        public long? MemorySizeGB { get; }
        /// <summary> The mode of the agent pool containing this node. Not applicable for control plane nodes. </summary>
        public NetworkCloudAgentPoolMode? Mode { get; }
        /// <summary> The name of this node, as realized in the Kubernetes cluster. </summary>
        public string Name { get; }
        /// <summary> The NetworkAttachments made to this node. </summary>
        public IReadOnlyList<NetworkAttachment> NetworkAttachments { get; }
        /// <summary> The power state of this node. </summary>
        public KubernetesNodePowerState? PowerState { get; }
        /// <summary> The role of this node in the cluster. </summary>
        public KubernetesNodeRole? Role { get; }
        /// <summary> The list of taints that have been assigned to the agent pool containing this node. </summary>
        public IReadOnlyList<KubernetesLabel> Taints { get; }
        /// <summary> The VM SKU name that was used to create this cluster node. </summary>
        public string VmSkuName { get; }
    }
}
