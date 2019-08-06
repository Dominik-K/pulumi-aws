# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class VpcAttachmentAccepter(pulumi.CustomResource):
    dns_support: pulumi.Output[str]
    """
    Whether DNS support is enabled. Valid values: `disable`, `enable`.
    """
    ipv6_support: pulumi.Output[str]
    """
    Whether IPv6 support is enabled. Valid values: `disable`, `enable`.
    """
    subnet_ids: pulumi.Output[list]
    """
    Identifiers of EC2 Subnets.
    """
    tags: pulumi.Output[dict]
    """
    Key-value tags for the EC2 Transit Gateway VPC Attachment.
    """
    transit_gateway_attachment_id: pulumi.Output[str]
    """
    The ID of the EC2 Transit Gateway Attachment to manage.
    """
    transit_gateway_default_route_table_association: pulumi.Output[bool]
    """
    Boolean whether the VPC Attachment should be associated with the EC2 Transit Gateway association default route table. Default value: `true`.
    """
    transit_gateway_default_route_table_propagation: pulumi.Output[bool]
    """
    Boolean whether the VPC Attachment should propagate routes with the EC2 Transit Gateway propagation default route table. Default value: `true`.
    """
    transit_gateway_id: pulumi.Output[str]
    """
    Identifier of EC2 Transit Gateway.
    """
    vpc_id: pulumi.Output[str]
    """
    Identifier of EC2 VPC.
    """
    vpc_owner_id: pulumi.Output[str]
    """
    Identifier of the AWS account that owns the EC2 VPC.
    """
    def __init__(__self__, resource_name, opts=None, tags=None, transit_gateway_attachment_id=None, transit_gateway_default_route_table_association=None, transit_gateway_default_route_table_propagation=None, __name__=None, __opts__=None):
        """
        Manages the accepter's side of an EC2 Transit Gateway VPC Attachment.
        
        When a cross-account (requester's AWS account differs from the accepter's AWS account) EC2 Transit Gateway VPC Attachment
        is created, an EC2 Transit Gateway VPC Attachment resource is automatically created in the accepter's account.
        The requester can use the `ec2transitgateway.VpcAttachment` resource to manage its side of the connection
        and the accepter can use the `ec2transitgateway.VpcAttachmentAccepter` resource to "adopt" its side of the
        connection into management.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] tags: Key-value tags for the EC2 Transit Gateway VPC Attachment.
        :param pulumi.Input[str] transit_gateway_attachment_id: The ID of the EC2 Transit Gateway Attachment to manage.
        :param pulumi.Input[bool] transit_gateway_default_route_table_association: Boolean whether the VPC Attachment should be associated with the EC2 Transit Gateway association default route table. Default value: `true`.
        :param pulumi.Input[bool] transit_gateway_default_route_table_propagation: Boolean whether the VPC Attachment should propagate routes with the EC2 Transit Gateway propagation default route table. Default value: `true`.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/ec2_transit_gateway_vpc_attachment_accepter.html.markdown.
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

        __props__['tags'] = tags

        if transit_gateway_attachment_id is None:
            raise TypeError("Missing required property 'transit_gateway_attachment_id'")
        __props__['transit_gateway_attachment_id'] = transit_gateway_attachment_id

        __props__['transit_gateway_default_route_table_association'] = transit_gateway_default_route_table_association

        __props__['transit_gateway_default_route_table_propagation'] = transit_gateway_default_route_table_propagation

        __props__['dns_support'] = None
        __props__['ipv6_support'] = None
        __props__['subnet_ids'] = None
        __props__['transit_gateway_id'] = None
        __props__['vpc_id'] = None
        __props__['vpc_owner_id'] = None

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(VpcAttachmentAccepter, __self__).__init__(
            'aws:ec2transitgateway/vpcAttachmentAccepter:VpcAttachmentAccepter',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

