// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceAdvancedMachineFeaturesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines whether the instance should have nested virtualization  enabled. Defaults to false.
        /// </summary>
        [Input("enableNestedVirtualization")]
        public Input<bool>? EnableNestedVirtualization { get; set; }

        /// <summary>
        /// he number of threads per physical core. To disable [simultaneous multithreading (SMT)](https://cloud.google.com/compute/docs/instances/disabling-smt) set this to 1.
        /// </summary>
        [Input("threadsPerCore")]
        public Input<int>? ThreadsPerCore { get; set; }

        public InstanceAdvancedMachineFeaturesGetArgs()
        {
        }
    }
}
