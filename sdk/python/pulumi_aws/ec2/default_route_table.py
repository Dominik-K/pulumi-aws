# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class DefaultRouteTable(pulumi.CustomResource):
    default_route_table_id: pulumi.Output[str]
    """
    The ID of the Default Routing Table.
    """
    owner_id: pulumi.Output[str]
    """
    The ID of the AWS account that owns the route table
    """
    propagating_vgws: pulumi.Output[list]
    """
    A list of virtual gateways for propagation.
    """
    routes: pulumi.Output[list]
    """
    A list of route objects. Their keys are documented below.
    This argument is processed in [attribute-as-blocks mode](https://www.terraform.io/docs/configuration/attr-as-blocks.html).
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    vpc_id: pulumi.Output[str]
    def __init__(__self__, resource_name, opts=None, default_route_table_id=None, propagating_vgws=None, routes=None, tags=None, __name__=None, __opts__=None):
        """
        Provides a resource to manage a Default VPC Routing Table.
        
        Each VPC created in AWS comes with a Default Route Table that can be managed, but not
        destroyed. **This is an advanced resource**, and has special caveats to be aware
        of when using it. Please read this document in its entirety before using this
        resource. It is recommended you **do not** use both `ec2.DefaultRouteTable` to
        manage the default route table **and** use the `ec2.MainRouteTableAssociation`,
        due to possible conflict in routes.
        
        The `ec2.DefaultRouteTable` behaves differently from normal resources, in that
        this provider does not _create_ this resource, but instead attempts to "adopt" it
        into management. We can do this because each VPC created has a Default Route
        Table that cannot be destroyed, and is created with a single route.
        
        When this provider first adopts the Default Route Table, it **immediately removes all
        defined routes**. It then proceeds to create any routes specified in the
        configuration. This step is required so that only the routes specified in the
        configuration present in the Default Route Table.
        
        For more information about Route Tables, see the AWS Documentation on
        [Route Tables][aws-route-tables].
        
        For more information about managing normal Route Tables in this provider, see our
        documentation on [ec2.RouteTable][tf-route-tables].
        
        > **NOTE on Route Tables and Routes:** This provider currently
        provides both a standalone Route resource and a Route Table resource with routes
        defined in-line. At this time you cannot use a Route Table with in-line routes
        in conjunction with any Route resources. Doing so will cause
        a conflict of rule settings and will overwrite routes.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] default_route_table_id: The ID of the Default Routing Table.
        :param pulumi.Input[list] propagating_vgws: A list of virtual gateways for propagation.
        :param pulumi.Input[list] routes: A list of route objects. Their keys are documented below.
               This argument is processed in [attribute-as-blocks mode](https://www.terraform.io/docs/configuration/attr-as-blocks.html).
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/default_route_table.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if default_route_table_id is None:
            raise TypeError("Missing required property 'default_route_table_id'")
        __props__['default_route_table_id'] = default_route_table_id

        __props__['propagating_vgws'] = propagating_vgws

        __props__['routes'] = routes

        __props__['tags'] = tags

        __props__['owner_id'] = None
        __props__['vpc_id'] = None

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(DefaultRouteTable, __self__).__init__(
            'aws:ec2/defaultRouteTable:DefaultRouteTable',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

