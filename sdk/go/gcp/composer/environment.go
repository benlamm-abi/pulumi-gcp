// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package composer

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## Import
//
// Environment can be imported using any of these accepted formats
//
// ```sh
//  $ pulumi import gcp:composer/environment:Environment default projects/{{project}}/locations/{{region}}/environments/{{name}}
// ```
//
// ```sh
//  $ pulumi import gcp:composer/environment:Environment default {{project}}/{{region}}/{{name}}
// ```
//
// ```sh
//  $ pulumi import gcp:composer/environment:Environment default {{name}}
// ```
type Environment struct {
	pulumi.CustomResourceState

	// Configuration parameters for this environment.
	Config EnvironmentConfigOutput `pulumi:"config"`
	// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map
	// are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and
	// must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63
	// characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be
	// associated with a given environment. Both keys and values must be <= 128 bytes in size.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Name of the environment.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	// The location or Compute Engine region for the environment.
	Region pulumi.StringOutput `pulumi:"region"`
}

// NewEnvironment registers a new resource with the given unique name, arguments, and options.
func NewEnvironment(ctx *pulumi.Context,
	name string, args *EnvironmentArgs, opts ...pulumi.ResourceOption) (*Environment, error) {
	if args == nil {
		args = &EnvironmentArgs{}
	}

	var resource Environment
	err := ctx.RegisterResource("gcp:composer/environment:Environment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEnvironment gets an existing Environment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEnvironment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EnvironmentState, opts ...pulumi.ResourceOption) (*Environment, error) {
	var resource Environment
	err := ctx.ReadResource("gcp:composer/environment:Environment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Environment resources.
type environmentState struct {
	// Configuration parameters for this environment.
	Config *EnvironmentConfig `pulumi:"config"`
	// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map
	// are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and
	// must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63
	// characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be
	// associated with a given environment. Both keys and values must be <= 128 bytes in size.
	Labels map[string]string `pulumi:"labels"`
	// Name of the environment.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The location or Compute Engine region for the environment.
	Region *string `pulumi:"region"`
}

type EnvironmentState struct {
	// Configuration parameters for this environment.
	Config EnvironmentConfigPtrInput
	// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map
	// are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and
	// must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63
	// characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be
	// associated with a given environment. Both keys and values must be <= 128 bytes in size.
	Labels pulumi.StringMapInput
	// Name of the environment.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The location or Compute Engine region for the environment.
	Region pulumi.StringPtrInput
}

func (EnvironmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentState)(nil)).Elem()
}

type environmentArgs struct {
	// Configuration parameters for this environment.
	Config *EnvironmentConfig `pulumi:"config"`
	// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map
	// are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and
	// must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63
	// characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be
	// associated with a given environment. Both keys and values must be <= 128 bytes in size.
	Labels map[string]string `pulumi:"labels"`
	// Name of the environment.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The location or Compute Engine region for the environment.
	Region *string `pulumi:"region"`
}

// The set of arguments for constructing a Environment resource.
type EnvironmentArgs struct {
	// Configuration parameters for this environment.
	Config EnvironmentConfigPtrInput
	// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map
	// are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and
	// must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63
	// characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be
	// associated with a given environment. Both keys and values must be <= 128 bytes in size.
	Labels pulumi.StringMapInput
	// Name of the environment.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The location or Compute Engine region for the environment.
	Region pulumi.StringPtrInput
}

func (EnvironmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentArgs)(nil)).Elem()
}

type EnvironmentInput interface {
	pulumi.Input

	ToEnvironmentOutput() EnvironmentOutput
	ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput
}

func (*Environment) ElementType() reflect.Type {
	return reflect.TypeOf((**Environment)(nil)).Elem()
}

func (i *Environment) ToEnvironmentOutput() EnvironmentOutput {
	return i.ToEnvironmentOutputWithContext(context.Background())
}

func (i *Environment) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EnvironmentOutput)
}

// EnvironmentArrayInput is an input type that accepts EnvironmentArray and EnvironmentArrayOutput values.
// You can construct a concrete instance of `EnvironmentArrayInput` via:
//
//          EnvironmentArray{ EnvironmentArgs{...} }
type EnvironmentArrayInput interface {
	pulumi.Input

	ToEnvironmentArrayOutput() EnvironmentArrayOutput
	ToEnvironmentArrayOutputWithContext(context.Context) EnvironmentArrayOutput
}

type EnvironmentArray []EnvironmentInput

func (EnvironmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Environment)(nil)).Elem()
}

func (i EnvironmentArray) ToEnvironmentArrayOutput() EnvironmentArrayOutput {
	return i.ToEnvironmentArrayOutputWithContext(context.Background())
}

func (i EnvironmentArray) ToEnvironmentArrayOutputWithContext(ctx context.Context) EnvironmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EnvironmentArrayOutput)
}

// EnvironmentMapInput is an input type that accepts EnvironmentMap and EnvironmentMapOutput values.
// You can construct a concrete instance of `EnvironmentMapInput` via:
//
//          EnvironmentMap{ "key": EnvironmentArgs{...} }
type EnvironmentMapInput interface {
	pulumi.Input

	ToEnvironmentMapOutput() EnvironmentMapOutput
	ToEnvironmentMapOutputWithContext(context.Context) EnvironmentMapOutput
}

type EnvironmentMap map[string]EnvironmentInput

func (EnvironmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Environment)(nil)).Elem()
}

func (i EnvironmentMap) ToEnvironmentMapOutput() EnvironmentMapOutput {
	return i.ToEnvironmentMapOutputWithContext(context.Background())
}

func (i EnvironmentMap) ToEnvironmentMapOutputWithContext(ctx context.Context) EnvironmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EnvironmentMapOutput)
}

type EnvironmentOutput struct{ *pulumi.OutputState }

func (EnvironmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Environment)(nil)).Elem()
}

func (o EnvironmentOutput) ToEnvironmentOutput() EnvironmentOutput {
	return o
}

func (o EnvironmentOutput) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return o
}

type EnvironmentArrayOutput struct{ *pulumi.OutputState }

func (EnvironmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Environment)(nil)).Elem()
}

func (o EnvironmentArrayOutput) ToEnvironmentArrayOutput() EnvironmentArrayOutput {
	return o
}

func (o EnvironmentArrayOutput) ToEnvironmentArrayOutputWithContext(ctx context.Context) EnvironmentArrayOutput {
	return o
}

func (o EnvironmentArrayOutput) Index(i pulumi.IntInput) EnvironmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Environment {
		return vs[0].([]*Environment)[vs[1].(int)]
	}).(EnvironmentOutput)
}

type EnvironmentMapOutput struct{ *pulumi.OutputState }

func (EnvironmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Environment)(nil)).Elem()
}

func (o EnvironmentMapOutput) ToEnvironmentMapOutput() EnvironmentMapOutput {
	return o
}

func (o EnvironmentMapOutput) ToEnvironmentMapOutputWithContext(ctx context.Context) EnvironmentMapOutput {
	return o
}

func (o EnvironmentMapOutput) MapIndex(k pulumi.StringInput) EnvironmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Environment {
		return vs[0].(map[string]*Environment)[vs[1].(string)]
	}).(EnvironmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EnvironmentInput)(nil)).Elem(), &Environment{})
	pulumi.RegisterInputType(reflect.TypeOf((*EnvironmentArrayInput)(nil)).Elem(), EnvironmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*EnvironmentMapInput)(nil)).Elem(), EnvironmentMap{})
	pulumi.RegisterOutputType(EnvironmentOutput{})
	pulumi.RegisterOutputType(EnvironmentArrayOutput{})
	pulumi.RegisterOutputType(EnvironmentMapOutput{})
}
