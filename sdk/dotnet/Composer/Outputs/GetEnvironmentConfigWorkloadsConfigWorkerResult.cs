// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Composer.Outputs
{

    [OutputType]
    public sealed class GetEnvironmentConfigWorkloadsConfigWorkerResult
    {
        public readonly double Cpu;
        public readonly int MaxCount;
        public readonly double MemoryGb;
        public readonly int MinCount;
        public readonly double StorageGb;

        [OutputConstructor]
        private GetEnvironmentConfigWorkloadsConfigWorkerResult(
            double cpu,

            int maxCount,

            double memoryGb,

            int minCount,

            double storageGb)
        {
            Cpu = cpu;
            MaxCount = maxCount;
            MemoryGb = memoryGb;
            MinCount = minCount;
            StorageGb = storageGb;
        }
    }
}
