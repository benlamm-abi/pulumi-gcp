// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage.Outputs
{

    [OutputType]
    public sealed class GetBucketLifecycleRuleResult
    {
        public readonly ImmutableArray<Outputs.GetBucketLifecycleRuleActionResult> Actions;
        public readonly ImmutableArray<Outputs.GetBucketLifecycleRuleConditionResult> Conditions;

        [OutputConstructor]
        private GetBucketLifecycleRuleResult(
            ImmutableArray<Outputs.GetBucketLifecycleRuleActionResult> actions,

            ImmutableArray<Outputs.GetBucketLifecycleRuleConditionResult> conditions)
        {
            Actions = actions;
            Conditions = conditions;
        }
    }
}
