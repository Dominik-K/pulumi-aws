# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class PublicDnsNamespace(pulumi.CustomResource):
    arn: pulumi.Output[str]
    """
    The ARN that Amazon Route 53 assigns to the namespace when you create it.
    """
    description: pulumi.Output[str]
    """
    The description that you specify for the namespace when you create it.
    """
    hosted_zone: pulumi.Output[str]
    """
    The ID for the hosted zone that Amazon Route 53 creates when you create a namespace.
    """
    name: pulumi.Output[str]
    """
    The name of the namespace.
    """
    tags: pulumi.Output[dict]
    """
    A map of tags to assign to the namespace.
    """
    def __init__(__self__, resource_name, opts=None, description=None, name=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Service Discovery Public DNS Namespace resource.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.servicediscovery.PublicDnsNamespace("example", description="example")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description that you specify for the namespace when you create it.
        :param pulumi.Input[str] name: The name of the namespace.
        :param pulumi.Input[dict] tags: A map of tags to assign to the namespace.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['description'] = description
            __props__['name'] = name
            __props__['tags'] = tags
            __props__['arn'] = None
            __props__['hosted_zone'] = None
        super(PublicDnsNamespace, __self__).__init__(
            'aws:servicediscovery/publicDnsNamespace:PublicDnsNamespace',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, arn=None, description=None, hosted_zone=None, name=None, tags=None):
        """
        Get an existing PublicDnsNamespace resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The ARN that Amazon Route 53 assigns to the namespace when you create it.
        :param pulumi.Input[str] description: The description that you specify for the namespace when you create it.
        :param pulumi.Input[str] hosted_zone: The ID for the hosted zone that Amazon Route 53 creates when you create a namespace.
        :param pulumi.Input[str] name: The name of the namespace.
        :param pulumi.Input[dict] tags: A map of tags to assign to the namespace.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["description"] = description
        __props__["hosted_zone"] = hosted_zone
        __props__["name"] = name
        __props__["tags"] = tags
        return PublicDnsNamespace(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
