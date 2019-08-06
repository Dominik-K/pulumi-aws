# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class DefaultSubnet(pulumi.CustomResource):
    arn: pulumi.Output[str]
    assign_ipv6_address_on_creation: pulumi.Output[bool]
    availability_zone: pulumi.Output[str]
    availability_zone_id: pulumi.Output[str]
    cidr_block: pulumi.Output[str]
    """
    The CIDR block for the subnet.
    """
    ipv6_cidr_block: pulumi.Output[str]
    """
    The IPv6 CIDR block.
    """
    ipv6_cidr_block_association_id: pulumi.Output[str]
    map_public_ip_on_launch: pulumi.Output[bool]
    """
    Specify true to indicate
    that instances launched into the subnet should be assigned
    a public IP address.
    """
    owner_id: pulumi.Output[str]
    """
    The ID of the AWS account that owns the subnet.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    vpc_id: pulumi.Output[str]
    """
    The VPC ID.
    """
    def __init__(__self__, resource_name, opts=None, availability_zone=None, map_public_ip_on_launch=None, tags=None, __name__=None, __opts__=None):
        """
        Provides a resource to manage a [default AWS VPC subnet](http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html#default-vpc-basics)
        in the current region.
        
        The `ec2.DefaultSubnet` behaves differently from normal resources, in that
        this provider does not _create_ this resource, but instead "adopts" it
        into management.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] map_public_ip_on_launch: Specify true to indicate
               that instances launched into the subnet should be assigned
               a public IP address.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/default_subnet.html.markdown.
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

        if availability_zone is None:
            raise TypeError("Missing required property 'availability_zone'")
        __props__['availability_zone'] = availability_zone

        __props__['map_public_ip_on_launch'] = map_public_ip_on_launch

        __props__['tags'] = tags

        __props__['arn'] = None
        __props__['assign_ipv6_address_on_creation'] = None
        __props__['availability_zone_id'] = None
        __props__['cidr_block'] = None
        __props__['ipv6_cidr_block'] = None
        __props__['ipv6_cidr_block_association_id'] = None
        __props__['owner_id'] = None
        __props__['vpc_id'] = None

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(DefaultSubnet, __self__).__init__(
            'aws:ec2/defaultSubnet:DefaultSubnet',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

