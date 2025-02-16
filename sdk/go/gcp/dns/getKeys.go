// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dns

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get the DNSKEY and DS records of DNSSEC-signed managed zones. For more information see the
// [official documentation](https://cloud.google.com/dns/docs/dnskeys/)
// and [API](https://cloud.google.com/dns/docs/reference/v1/dnsKeys).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-gcp/sdk/v6/go/gcp/dns"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		foo, err := dns.NewManagedZone(ctx, "foo", &dns.ManagedZoneArgs{
// 			DnsName: pulumi.String("foo.bar."),
// 			DnssecConfig: &dns.ManagedZoneDnssecConfigArgs{
// 				State:        pulumi.String("on"),
// 				NonExistence: pulumi.String("nsec3"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooDnsKeys := dns.GetKeysOutput(ctx, dns.GetKeysOutputArgs{
// 			ManagedZone: foo.ID(),
// 		}, nil)
// 		ctx.Export("fooDnsDsRecord", fooDnsKeys.ApplyT(func(fooDnsKeys dns.GetKeysResult) (string, error) {
// 			return fooDnsKeys.KeySigningKeys[0].DsRecord, nil
// 		}).(pulumi.StringOutput))
// 		return nil
// 	})
// }
// ```
func GetKeys(ctx *pulumi.Context, args *GetKeysArgs, opts ...pulumi.InvokeOption) (*GetKeysResult, error) {
	var rv GetKeysResult
	err := ctx.Invoke("gcp:dns/getKeys:getKeys", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKeys.
type GetKeysArgs struct {
	// The name or id of the Cloud DNS managed zone.
	ManagedZone string `pulumi:"managedZone"`
	// The ID of the project in which the resource belongs. If `project` is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}

// A collection of values returned by getKeys.
type GetKeysResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A list of Key-signing key (KSK) records. Structure is documented below. Additionally, the DS record is provided:
	KeySigningKeys []GetKeysKeySigningKey `pulumi:"keySigningKeys"`
	ManagedZone    string                 `pulumi:"managedZone"`
	Project        string                 `pulumi:"project"`
	// A list of Zone-signing key (ZSK) records. Structure is documented below.
	ZoneSigningKeys []GetKeysZoneSigningKey `pulumi:"zoneSigningKeys"`
}

func GetKeysOutput(ctx *pulumi.Context, args GetKeysOutputArgs, opts ...pulumi.InvokeOption) GetKeysResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetKeysResult, error) {
			args := v.(GetKeysArgs)
			r, err := GetKeys(ctx, &args, opts...)
			return *r, err
		}).(GetKeysResultOutput)
}

// A collection of arguments for invoking getKeys.
type GetKeysOutputArgs struct {
	// The name or id of the Cloud DNS managed zone.
	ManagedZone pulumi.StringInput `pulumi:"managedZone"`
	// The ID of the project in which the resource belongs. If `project` is not provided, the provider project is used.
	Project pulumi.StringPtrInput `pulumi:"project"`
}

func (GetKeysOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetKeysArgs)(nil)).Elem()
}

// A collection of values returned by getKeys.
type GetKeysResultOutput struct{ *pulumi.OutputState }

func (GetKeysResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetKeysResult)(nil)).Elem()
}

func (o GetKeysResultOutput) ToGetKeysResultOutput() GetKeysResultOutput {
	return o
}

func (o GetKeysResultOutput) ToGetKeysResultOutputWithContext(ctx context.Context) GetKeysResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetKeysResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetKeysResult) string { return v.Id }).(pulumi.StringOutput)
}

// A list of Key-signing key (KSK) records. Structure is documented below. Additionally, the DS record is provided:
func (o GetKeysResultOutput) KeySigningKeys() GetKeysKeySigningKeyArrayOutput {
	return o.ApplyT(func(v GetKeysResult) []GetKeysKeySigningKey { return v.KeySigningKeys }).(GetKeysKeySigningKeyArrayOutput)
}

func (o GetKeysResultOutput) ManagedZone() pulumi.StringOutput {
	return o.ApplyT(func(v GetKeysResult) string { return v.ManagedZone }).(pulumi.StringOutput)
}

func (o GetKeysResultOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v GetKeysResult) string { return v.Project }).(pulumi.StringOutput)
}

// A list of Zone-signing key (ZSK) records. Structure is documented below.
func (o GetKeysResultOutput) ZoneSigningKeys() GetKeysZoneSigningKeyArrayOutput {
	return o.ApplyT(func(v GetKeysResult) []GetKeysZoneSigningKey { return v.ZoneSigningKeys }).(GetKeysZoneSigningKeyArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetKeysResultOutput{})
}
