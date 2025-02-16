# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['FunctionArgs', 'Function']

@pulumi.input_type
class FunctionArgs:
    def __init__(__self__, *,
                 build_config: Optional[pulumi.Input['FunctionBuildConfigArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 event_trigger: Optional[pulumi.Input['FunctionEventTriggerArgs']] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 service_config: Optional[pulumi.Input['FunctionServiceConfigArgs']] = None):
        """
        The set of arguments for constructing a Function resource.
        :param pulumi.Input['FunctionBuildConfigArgs'] build_config: Describes the Build step of the function that builds a container
               from the given source.
               Structure is documented below.
        :param pulumi.Input[str] description: User-provided description of a function.
        :param pulumi.Input['FunctionEventTriggerArgs'] event_trigger: An Eventarc trigger managed by Google Cloud Functions that fires events in
               response to a condition in another service.
               Structure is documented below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs associated with this Cloud Function.
        :param pulumi.Input[str] location: The location of this cloud function.
        :param pulumi.Input[str] name: A user-defined name of the function. Function names must
               be unique globally and match pattern `projects/*/locations/*/functions/*`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input['FunctionServiceConfigArgs'] service_config: Describes the Service being deployed.
               Structure is documented below.
        """
        if build_config is not None:
            pulumi.set(__self__, "build_config", build_config)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if event_trigger is not None:
            pulumi.set(__self__, "event_trigger", event_trigger)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if service_config is not None:
            pulumi.set(__self__, "service_config", service_config)

    @property
    @pulumi.getter(name="buildConfig")
    def build_config(self) -> Optional[pulumi.Input['FunctionBuildConfigArgs']]:
        """
        Describes the Build step of the function that builds a container
        from the given source.
        Structure is documented below.
        """
        return pulumi.get(self, "build_config")

    @build_config.setter
    def build_config(self, value: Optional[pulumi.Input['FunctionBuildConfigArgs']]):
        pulumi.set(self, "build_config", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        User-provided description of a function.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="eventTrigger")
    def event_trigger(self) -> Optional[pulumi.Input['FunctionEventTriggerArgs']]:
        """
        An Eventarc trigger managed by Google Cloud Functions that fires events in
        response to a condition in another service.
        Structure is documented below.
        """
        return pulumi.get(self, "event_trigger")

    @event_trigger.setter
    def event_trigger(self, value: Optional[pulumi.Input['FunctionEventTriggerArgs']]):
        pulumi.set(self, "event_trigger", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A set of key/value label pairs associated with this Cloud Function.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        The location of this cloud function.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        A user-defined name of the function. Function names must
        be unique globally and match pattern `projects/*/locations/*/functions/*`.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def project(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter(name="serviceConfig")
    def service_config(self) -> Optional[pulumi.Input['FunctionServiceConfigArgs']]:
        """
        Describes the Service being deployed.
        Structure is documented below.
        """
        return pulumi.get(self, "service_config")

    @service_config.setter
    def service_config(self, value: Optional[pulumi.Input['FunctionServiceConfigArgs']]):
        pulumi.set(self, "service_config", value)


@pulumi.input_type
class _FunctionState:
    def __init__(__self__, *,
                 build_config: Optional[pulumi.Input['FunctionBuildConfigArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 environment: Optional[pulumi.Input[str]] = None,
                 event_trigger: Optional[pulumi.Input['FunctionEventTriggerArgs']] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 service_config: Optional[pulumi.Input['FunctionServiceConfigArgs']] = None,
                 state: Optional[pulumi.Input[str]] = None,
                 update_time: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Function resources.
        :param pulumi.Input['FunctionBuildConfigArgs'] build_config: Describes the Build step of the function that builds a container
               from the given source.
               Structure is documented below.
        :param pulumi.Input[str] description: User-provided description of a function.
        :param pulumi.Input[str] environment: The environment the function is hosted on.
        :param pulumi.Input['FunctionEventTriggerArgs'] event_trigger: An Eventarc trigger managed by Google Cloud Functions that fires events in
               response to a condition in another service.
               Structure is documented below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs associated with this Cloud Function.
        :param pulumi.Input[str] location: The location of this cloud function.
        :param pulumi.Input[str] name: A user-defined name of the function. Function names must
               be unique globally and match pattern `projects/*/locations/*/functions/*`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input['FunctionServiceConfigArgs'] service_config: Describes the Service being deployed.
               Structure is documented below.
        :param pulumi.Input[str] state: Describes the current state of the function.
        :param pulumi.Input[str] update_time: The last update timestamp of a Cloud Function.
        """
        if build_config is not None:
            pulumi.set(__self__, "build_config", build_config)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if environment is not None:
            pulumi.set(__self__, "environment", environment)
        if event_trigger is not None:
            pulumi.set(__self__, "event_trigger", event_trigger)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if service_config is not None:
            pulumi.set(__self__, "service_config", service_config)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if update_time is not None:
            pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="buildConfig")
    def build_config(self) -> Optional[pulumi.Input['FunctionBuildConfigArgs']]:
        """
        Describes the Build step of the function that builds a container
        from the given source.
        Structure is documented below.
        """
        return pulumi.get(self, "build_config")

    @build_config.setter
    def build_config(self, value: Optional[pulumi.Input['FunctionBuildConfigArgs']]):
        pulumi.set(self, "build_config", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        User-provided description of a function.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def environment(self) -> Optional[pulumi.Input[str]]:
        """
        The environment the function is hosted on.
        """
        return pulumi.get(self, "environment")

    @environment.setter
    def environment(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "environment", value)

    @property
    @pulumi.getter(name="eventTrigger")
    def event_trigger(self) -> Optional[pulumi.Input['FunctionEventTriggerArgs']]:
        """
        An Eventarc trigger managed by Google Cloud Functions that fires events in
        response to a condition in another service.
        Structure is documented below.
        """
        return pulumi.get(self, "event_trigger")

    @event_trigger.setter
    def event_trigger(self, value: Optional[pulumi.Input['FunctionEventTriggerArgs']]):
        pulumi.set(self, "event_trigger", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A set of key/value label pairs associated with this Cloud Function.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        The location of this cloud function.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        A user-defined name of the function. Function names must
        be unique globally and match pattern `projects/*/locations/*/functions/*`.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def project(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter(name="serviceConfig")
    def service_config(self) -> Optional[pulumi.Input['FunctionServiceConfigArgs']]:
        """
        Describes the Service being deployed.
        Structure is documented below.
        """
        return pulumi.get(self, "service_config")

    @service_config.setter
    def service_config(self, value: Optional[pulumi.Input['FunctionServiceConfigArgs']]):
        pulumi.set(self, "service_config", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        """
        Describes the current state of the function.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> Optional[pulumi.Input[str]]:
        """
        The last update timestamp of a Cloud Function.
        """
        return pulumi.get(self, "update_time")

    @update_time.setter
    def update_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "update_time", value)


class Function(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 build_config: Optional[pulumi.Input[pulumi.InputType['FunctionBuildConfigArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 event_trigger: Optional[pulumi.Input[pulumi.InputType['FunctionEventTriggerArgs']]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 service_config: Optional[pulumi.Input[pulumi.InputType['FunctionServiceConfigArgs']]] = None,
                 __props__=None):
        """
        ## Example Usage
        ### Cloudfunctions2 Basic

        ```python
        import pulumi
        import pulumi_gcp as gcp

        bucket = gcp.storage.Bucket("bucket",
            location="US",
            uniform_bucket_level_access=True,
            opts=pulumi.ResourceOptions(provider=google_beta))
        object = gcp.storage.BucketObject("object",
            bucket=bucket.name,
            source=pulumi.FileAsset("path/to/index.zip"),
            opts=pulumi.ResourceOptions(provider=google_beta))
        terraform_test2 = gcp.cloudfunctionsv2.Function("terraform-test2",
            location="us-central1",
            description="a new function",
            build_config=gcp.cloudfunctionsv2.FunctionBuildConfigArgs(
                runtime="nodejs12",
                entry_point="helloHttp",
                source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceArgs(
                    storage_source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceStorageSourceArgs(
                        bucket=bucket.name,
                        object=object.name,
                    ),
                ),
            ),
            service_config=gcp.cloudfunctionsv2.FunctionServiceConfigArgs(
                max_instance_count=1,
                available_memory="256M",
                timeout_seconds=60,
            ),
            opts=pulumi.ResourceOptions(provider=google_beta))
        ```
        ### Cloudfunctions2 Full

        ```python
        import pulumi
        import pulumi_gcp as gcp

        sub = gcp.pubsub.Topic("sub", opts=pulumi.ResourceOptions(provider=google_beta))
        bucket = gcp.storage.Bucket("bucket",
            location="US",
            uniform_bucket_level_access=True,
            opts=pulumi.ResourceOptions(provider=google_beta))
        object = gcp.storage.BucketObject("object",
            bucket=bucket.name,
            source=pulumi.FileAsset("path/to/index.zip"),
            opts=pulumi.ResourceOptions(provider=google_beta))
        terraform_test = gcp.cloudfunctionsv2.Function("terraform-test",
            location="us-central1",
            description="a new function",
            build_config=gcp.cloudfunctionsv2.FunctionBuildConfigArgs(
                runtime="nodejs12",
                entry_point="helloHttp",
                environment_variables={
                    "BUILD_CONFIG_TEST": "build_test",
                },
                source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceArgs(
                    storage_source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceStorageSourceArgs(
                        bucket=bucket.name,
                        object=object.name,
                    ),
                ),
            ),
            service_config=gcp.cloudfunctionsv2.FunctionServiceConfigArgs(
                max_instance_count=3,
                min_instance_count=1,
                available_memory="256M",
                timeout_seconds=60,
                environment_variables={
                    "SERVICE_CONFIG_TEST": "config_test",
                },
                ingress_settings="ALLOW_INTERNAL_ONLY",
                all_traffic_on_latest_revision=True,
            ),
            event_trigger=gcp.cloudfunctionsv2.FunctionEventTriggerArgs(
                trigger_region="us-central1",
                event_type="google.cloud.pubsub.topic.v1.messagePublished",
                pubsub_topic=sub.id,
                retry_policy="RETRY_POLICY_RETRY",
            ),
            opts=pulumi.ResourceOptions(provider=google_beta))
        ```

        ## Import

        function can be imported using any of these accepted formats

        ```sh
         $ pulumi import gcp:cloudfunctionsv2/function:Function default projects/{{project}}/locations/{{location}}/functions/{{name}}
        ```

        ```sh
         $ pulumi import gcp:cloudfunctionsv2/function:Function default {{project}}/{{location}}/{{name}}
        ```

        ```sh
         $ pulumi import gcp:cloudfunctionsv2/function:Function default {{location}}/{{name}}
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['FunctionBuildConfigArgs']] build_config: Describes the Build step of the function that builds a container
               from the given source.
               Structure is documented below.
        :param pulumi.Input[str] description: User-provided description of a function.
        :param pulumi.Input[pulumi.InputType['FunctionEventTriggerArgs']] event_trigger: An Eventarc trigger managed by Google Cloud Functions that fires events in
               response to a condition in another service.
               Structure is documented below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs associated with this Cloud Function.
        :param pulumi.Input[str] location: The location of this cloud function.
        :param pulumi.Input[str] name: A user-defined name of the function. Function names must
               be unique globally and match pattern `projects/*/locations/*/functions/*`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[pulumi.InputType['FunctionServiceConfigArgs']] service_config: Describes the Service being deployed.
               Structure is documented below.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[FunctionArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## Example Usage
        ### Cloudfunctions2 Basic

        ```python
        import pulumi
        import pulumi_gcp as gcp

        bucket = gcp.storage.Bucket("bucket",
            location="US",
            uniform_bucket_level_access=True,
            opts=pulumi.ResourceOptions(provider=google_beta))
        object = gcp.storage.BucketObject("object",
            bucket=bucket.name,
            source=pulumi.FileAsset("path/to/index.zip"),
            opts=pulumi.ResourceOptions(provider=google_beta))
        terraform_test2 = gcp.cloudfunctionsv2.Function("terraform-test2",
            location="us-central1",
            description="a new function",
            build_config=gcp.cloudfunctionsv2.FunctionBuildConfigArgs(
                runtime="nodejs12",
                entry_point="helloHttp",
                source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceArgs(
                    storage_source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceStorageSourceArgs(
                        bucket=bucket.name,
                        object=object.name,
                    ),
                ),
            ),
            service_config=gcp.cloudfunctionsv2.FunctionServiceConfigArgs(
                max_instance_count=1,
                available_memory="256M",
                timeout_seconds=60,
            ),
            opts=pulumi.ResourceOptions(provider=google_beta))
        ```
        ### Cloudfunctions2 Full

        ```python
        import pulumi
        import pulumi_gcp as gcp

        sub = gcp.pubsub.Topic("sub", opts=pulumi.ResourceOptions(provider=google_beta))
        bucket = gcp.storage.Bucket("bucket",
            location="US",
            uniform_bucket_level_access=True,
            opts=pulumi.ResourceOptions(provider=google_beta))
        object = gcp.storage.BucketObject("object",
            bucket=bucket.name,
            source=pulumi.FileAsset("path/to/index.zip"),
            opts=pulumi.ResourceOptions(provider=google_beta))
        terraform_test = gcp.cloudfunctionsv2.Function("terraform-test",
            location="us-central1",
            description="a new function",
            build_config=gcp.cloudfunctionsv2.FunctionBuildConfigArgs(
                runtime="nodejs12",
                entry_point="helloHttp",
                environment_variables={
                    "BUILD_CONFIG_TEST": "build_test",
                },
                source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceArgs(
                    storage_source=gcp.cloudfunctionsv2.FunctionBuildConfigSourceStorageSourceArgs(
                        bucket=bucket.name,
                        object=object.name,
                    ),
                ),
            ),
            service_config=gcp.cloudfunctionsv2.FunctionServiceConfigArgs(
                max_instance_count=3,
                min_instance_count=1,
                available_memory="256M",
                timeout_seconds=60,
                environment_variables={
                    "SERVICE_CONFIG_TEST": "config_test",
                },
                ingress_settings="ALLOW_INTERNAL_ONLY",
                all_traffic_on_latest_revision=True,
            ),
            event_trigger=gcp.cloudfunctionsv2.FunctionEventTriggerArgs(
                trigger_region="us-central1",
                event_type="google.cloud.pubsub.topic.v1.messagePublished",
                pubsub_topic=sub.id,
                retry_policy="RETRY_POLICY_RETRY",
            ),
            opts=pulumi.ResourceOptions(provider=google_beta))
        ```

        ## Import

        function can be imported using any of these accepted formats

        ```sh
         $ pulumi import gcp:cloudfunctionsv2/function:Function default projects/{{project}}/locations/{{location}}/functions/{{name}}
        ```

        ```sh
         $ pulumi import gcp:cloudfunctionsv2/function:Function default {{project}}/{{location}}/{{name}}
        ```

        ```sh
         $ pulumi import gcp:cloudfunctionsv2/function:Function default {{location}}/{{name}}
        ```

        :param str resource_name: The name of the resource.
        :param FunctionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FunctionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 build_config: Optional[pulumi.Input[pulumi.InputType['FunctionBuildConfigArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 event_trigger: Optional[pulumi.Input[pulumi.InputType['FunctionEventTriggerArgs']]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 service_config: Optional[pulumi.Input[pulumi.InputType['FunctionServiceConfigArgs']]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FunctionArgs.__new__(FunctionArgs)

            __props__.__dict__["build_config"] = build_config
            __props__.__dict__["description"] = description
            __props__.__dict__["event_trigger"] = event_trigger
            __props__.__dict__["labels"] = labels
            __props__.__dict__["location"] = location
            __props__.__dict__["name"] = name
            __props__.__dict__["project"] = project
            __props__.__dict__["service_config"] = service_config
            __props__.__dict__["environment"] = None
            __props__.__dict__["state"] = None
            __props__.__dict__["update_time"] = None
        super(Function, __self__).__init__(
            'gcp:cloudfunctionsv2/function:Function',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            build_config: Optional[pulumi.Input[pulumi.InputType['FunctionBuildConfigArgs']]] = None,
            description: Optional[pulumi.Input[str]] = None,
            environment: Optional[pulumi.Input[str]] = None,
            event_trigger: Optional[pulumi.Input[pulumi.InputType['FunctionEventTriggerArgs']]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            location: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            service_config: Optional[pulumi.Input[pulumi.InputType['FunctionServiceConfigArgs']]] = None,
            state: Optional[pulumi.Input[str]] = None,
            update_time: Optional[pulumi.Input[str]] = None) -> 'Function':
        """
        Get an existing Function resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['FunctionBuildConfigArgs']] build_config: Describes the Build step of the function that builds a container
               from the given source.
               Structure is documented below.
        :param pulumi.Input[str] description: User-provided description of a function.
        :param pulumi.Input[str] environment: The environment the function is hosted on.
        :param pulumi.Input[pulumi.InputType['FunctionEventTriggerArgs']] event_trigger: An Eventarc trigger managed by Google Cloud Functions that fires events in
               response to a condition in another service.
               Structure is documented below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs associated with this Cloud Function.
        :param pulumi.Input[str] location: The location of this cloud function.
        :param pulumi.Input[str] name: A user-defined name of the function. Function names must
               be unique globally and match pattern `projects/*/locations/*/functions/*`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[pulumi.InputType['FunctionServiceConfigArgs']] service_config: Describes the Service being deployed.
               Structure is documented below.
        :param pulumi.Input[str] state: Describes the current state of the function.
        :param pulumi.Input[str] update_time: The last update timestamp of a Cloud Function.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FunctionState.__new__(_FunctionState)

        __props__.__dict__["build_config"] = build_config
        __props__.__dict__["description"] = description
        __props__.__dict__["environment"] = environment
        __props__.__dict__["event_trigger"] = event_trigger
        __props__.__dict__["labels"] = labels
        __props__.__dict__["location"] = location
        __props__.__dict__["name"] = name
        __props__.__dict__["project"] = project
        __props__.__dict__["service_config"] = service_config
        __props__.__dict__["state"] = state
        __props__.__dict__["update_time"] = update_time
        return Function(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="buildConfig")
    def build_config(self) -> pulumi.Output[Optional['outputs.FunctionBuildConfig']]:
        """
        Describes the Build step of the function that builds a container
        from the given source.
        Structure is documented below.
        """
        return pulumi.get(self, "build_config")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        User-provided description of a function.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def environment(self) -> pulumi.Output[str]:
        """
        The environment the function is hosted on.
        """
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter(name="eventTrigger")
    def event_trigger(self) -> pulumi.Output[Optional['outputs.FunctionEventTrigger']]:
        """
        An Eventarc trigger managed by Google Cloud Functions that fires events in
        response to a condition in another service.
        Structure is documented below.
        """
        return pulumi.get(self, "event_trigger")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A set of key/value label pairs associated with this Cloud Function.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        The location of this cloud function.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        A user-defined name of the function. Function names must
        be unique globally and match pattern `projects/*/locations/*/functions/*`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="serviceConfig")
    def service_config(self) -> pulumi.Output[Optional['outputs.FunctionServiceConfig']]:
        """
        Describes the Service being deployed.
        Structure is documented below.
        """
        return pulumi.get(self, "service_config")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        Describes the current state of the function.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        The last update timestamp of a Cloud Function.
        """
        return pulumi.get(self, "update_time")

