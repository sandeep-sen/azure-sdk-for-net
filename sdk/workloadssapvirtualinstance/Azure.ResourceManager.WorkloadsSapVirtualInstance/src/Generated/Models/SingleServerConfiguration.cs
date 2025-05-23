// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> Gets or sets the single server configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409). </summary>
    public partial class SingleServerConfiguration : InfrastructureConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SingleServerConfiguration"/>. </summary>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <param name="subnetId"> The subnet id. </param>
        /// <param name="virtualMachineConfiguration"> Gets or sets the virtual machine configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appResourceGroup"/>, <paramref name="subnetId"/> or <paramref name="virtualMachineConfiguration"/> is null. </exception>
        public SingleServerConfiguration(string appResourceGroup, ResourceIdentifier subnetId, SapVirtualMachineConfiguration virtualMachineConfiguration) : base(appResourceGroup)
        {
            Argument.AssertNotNull(appResourceGroup, nameof(appResourceGroup));
            Argument.AssertNotNull(subnetId, nameof(subnetId));
            Argument.AssertNotNull(virtualMachineConfiguration, nameof(virtualMachineConfiguration));

            SubnetId = subnetId;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            DeploymentType = SapDeploymentType.SingleServer;
        }

        /// <summary> Initializes a new instance of <see cref="SingleServerConfiguration"/>. </summary>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <param name="deploymentType"> The SAP deployment type. Eg: SingleServer/ThreeTier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="networkConfiguration"> Network configuration for the server. </param>
        /// <param name="databaseType"> The database type. </param>
        /// <param name="subnetId"> The subnet id. </param>
        /// <param name="virtualMachineConfiguration"> Gets or sets the virtual machine configuration. </param>
        /// <param name="dbDiskConfiguration"> Gets or sets the disk configuration. </param>
        /// <param name="customResourceNames">
        /// The set of custom names to be used for underlying azure resources that are part of the SAP system.
        /// Please note <see cref="SingleServerCustomResourceNames"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SingleServerFullResourceNames"/>.
        /// </param>
        internal SingleServerConfiguration(string appResourceGroup, SapDeploymentType deploymentType, IDictionary<string, BinaryData> serializedAdditionalRawData, NetworkConfiguration networkConfiguration, SapDatabaseType? databaseType, ResourceIdentifier subnetId, SapVirtualMachineConfiguration virtualMachineConfiguration, DiskConfiguration dbDiskConfiguration, SingleServerCustomResourceNames customResourceNames) : base(appResourceGroup, deploymentType, serializedAdditionalRawData)
        {
            NetworkConfiguration = networkConfiguration;
            DatabaseType = databaseType;
            SubnetId = subnetId;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            DBDiskConfiguration = dbDiskConfiguration;
            CustomResourceNames = customResourceNames;
            DeploymentType = deploymentType;
        }

        /// <summary> Initializes a new instance of <see cref="SingleServerConfiguration"/> for deserialization. </summary>
        internal SingleServerConfiguration()
        {
        }

        /// <summary> Network configuration for the server. </summary>
        internal NetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary> Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed. </summary>
        public bool? IsSecondaryIPEnabled
        {
            get => NetworkConfiguration is null ? default : NetworkConfiguration.IsSecondaryIPEnabled;
            set
            {
                if (NetworkConfiguration is null)
                    NetworkConfiguration = new NetworkConfiguration();
                NetworkConfiguration.IsSecondaryIPEnabled = value;
            }
        }

        /// <summary> The database type. </summary>
        public SapDatabaseType? DatabaseType { get; set; }
        /// <summary> The subnet id. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Gets or sets the virtual machine configuration. </summary>
        public SapVirtualMachineConfiguration VirtualMachineConfiguration { get; set; }
        /// <summary> Gets or sets the disk configuration. </summary>
        internal DiskConfiguration DBDiskConfiguration { get; set; }
        /// <summary> The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os'], Optional volume : ['backup']. </summary>
        public IDictionary<string, DiskVolumeConfiguration> DiskVolumeConfigurations
        {
            get
            {
                if (DBDiskConfiguration is null)
                    DBDiskConfiguration = new DiskConfiguration();
                return DBDiskConfiguration.DiskVolumeConfigurations;
            }
        }

        /// <summary>
        /// The set of custom names to be used for underlying azure resources that are part of the SAP system.
        /// Please note <see cref="SingleServerCustomResourceNames"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SingleServerFullResourceNames"/>.
        /// </summary>
        public SingleServerCustomResourceNames CustomResourceNames { get; set; }
    }
}
