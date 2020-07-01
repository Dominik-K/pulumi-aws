# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class ParameterGroup(pulumi.CustomResource):
    arn: pulumi.Output[str]
    """
    Amazon Resource Name (ARN) of parameter group
    """
    description: pulumi.Output[str]
    """
    The description of the Redshift parameter group. Defaults to "Managed by Pulumi".
    """
    family: pulumi.Output[str]
    """
    The family of the Redshift parameter group.
    """
    name: pulumi.Output[str]
    """
    The name of the Redshift parameter.
    """
    parameters: pulumi.Output[list]
    """
    A list of Redshift parameters to apply.

      * `name` (`str`) - The name of the Redshift parameter.
      * `value` (`str`) - The value of the Redshift parameter.
    """
    tags: pulumi.Output[dict]
    """
    A map of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, description=None, family=None, name=None, parameters=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Redshift Cluster parameter group resource.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        bar = aws.redshift.ParameterGroup("bar",
            family="redshift-1.0",
            parameters=[
                {
                    "name": "require_ssl",
                    "value": "true",
                },
                {
                    "name": "query_group",
                    "value": "example",
                },
                {
                    "name": "enable_user_activity_logging",
                    "value": "true",
                },
            ])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the Redshift parameter group. Defaults to "Managed by Pulumi".
        :param pulumi.Input[str] family: The family of the Redshift parameter group.
        :param pulumi.Input[str] name: The name of the Redshift parameter.
        :param pulumi.Input[list] parameters: A list of Redshift parameters to apply.
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.

        The **parameters** object supports the following:

          * `name` (`pulumi.Input[str]`) - The name of the Redshift parameter.
          * `value` (`pulumi.Input[str]`) - The value of the Redshift parameter.
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

            if description is None:
                description = 'Managed by Pulumi'
            __props__['description'] = description
            if family is None:
                raise TypeError("Missing required property 'family'")
            __props__['family'] = family
            __props__['name'] = name
            __props__['parameters'] = parameters
            __props__['tags'] = tags
            __props__['arn'] = None
        super(ParameterGroup, __self__).__init__(
            'aws:redshift/parameterGroup:ParameterGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, arn=None, description=None, family=None, name=None, parameters=None, tags=None):
        """
        Get an existing ParameterGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: Amazon Resource Name (ARN) of parameter group
        :param pulumi.Input[str] description: The description of the Redshift parameter group. Defaults to "Managed by Pulumi".
        :param pulumi.Input[str] family: The family of the Redshift parameter group.
        :param pulumi.Input[str] name: The name of the Redshift parameter.
        :param pulumi.Input[list] parameters: A list of Redshift parameters to apply.
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.

        The **parameters** object supports the following:

          * `name` (`pulumi.Input[str]`) - The name of the Redshift parameter.
          * `value` (`pulumi.Input[str]`) - The value of the Redshift parameter.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["description"] = description
        __props__["family"] = family
        __props__["name"] = name
        __props__["parameters"] = parameters
        __props__["tags"] = tags
        return ParameterGroup(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
