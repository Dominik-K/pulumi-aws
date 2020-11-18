# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['ZoneAssociation']


class ZoneAssociation(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None,
                 vpc_region: Optional[pulumi.Input[str]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Route53 Hosted Zone VPC association. VPC associations can only be made on private zones. See the `route53.VpcAssociationAuthorization` resource for setting up cross-account associations.

        > **NOTE:** Unless explicit association ordering is required (e.g. a separate cross-account association authorization), usage of this resource is not recommended. Use the `vpc` configuration blocks available within the `route53.Zone` resource instead.

        > **NOTE:** This provider provides both this standalone Zone VPC Association resource and exclusive VPC associations defined in-line in the `route53.Zone` resource via `vpc` configuration blocks. At this time, you cannot use those in-line VPC associations in conjunction with this resource and the same zone ID otherwise it will cause a perpetual difference in plan output. You can optionally use [`ignoreChanges`](https://www.pulumi.com/docs/intro/concepts/programming-model/#ignorechanges) in the `route53.Zone` resource to manage additional associations via this resource.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        primary = aws.ec2.Vpc("primary",
            cidr_block="10.6.0.0/16",
            enable_dns_hostnames=True,
            enable_dns_support=True)
        secondary_vpc = aws.ec2.Vpc("secondaryVpc",
            cidr_block="10.7.0.0/16",
            enable_dns_hostnames=True,
            enable_dns_support=True)
        example = aws.route53.Zone("example", vpcs=[aws.route53.ZoneVpcArgs(
            vpc_id=primary.id,
        )])
        secondary_zone_association = aws.route53.ZoneAssociation("secondaryZoneAssociation",
            zone_id=example.zone_id,
            vpc_id=secondary_vpc.id)
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] vpc_id: The VPC to associate with the private hosted zone.
        :param pulumi.Input[str] vpc_region: The VPC's region. Defaults to the region of the AWS provider.
        :param pulumi.Input[str] zone_id: The private hosted zone to associate.
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
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if vpc_id is None:
                raise TypeError("Missing required property 'vpc_id'")
            __props__['vpc_id'] = vpc_id
            __props__['vpc_region'] = vpc_region
            if zone_id is None:
                raise TypeError("Missing required property 'zone_id'")
            __props__['zone_id'] = zone_id
            __props__['owning_account'] = None
        super(ZoneAssociation, __self__).__init__(
            'aws:route53/zoneAssociation:ZoneAssociation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            owning_account: Optional[pulumi.Input[str]] = None,
            vpc_id: Optional[pulumi.Input[str]] = None,
            vpc_region: Optional[pulumi.Input[str]] = None,
            zone_id: Optional[pulumi.Input[str]] = None) -> 'ZoneAssociation':
        """
        Get an existing ZoneAssociation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] owning_account: The account ID of the account that created the hosted zone.
        :param pulumi.Input[str] vpc_id: The VPC to associate with the private hosted zone.
        :param pulumi.Input[str] vpc_region: The VPC's region. Defaults to the region of the AWS provider.
        :param pulumi.Input[str] zone_id: The private hosted zone to associate.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["owning_account"] = owning_account
        __props__["vpc_id"] = vpc_id
        __props__["vpc_region"] = vpc_region
        __props__["zone_id"] = zone_id
        return ZoneAssociation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="owningAccount")
    def owning_account(self) -> pulumi.Output[str]:
        """
        The account ID of the account that created the hosted zone.
        """
        return pulumi.get(self, "owning_account")

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> pulumi.Output[str]:
        """
        The VPC to associate with the private hosted zone.
        """
        return pulumi.get(self, "vpc_id")

    @property
    @pulumi.getter(name="vpcRegion")
    def vpc_region(self) -> pulumi.Output[str]:
        """
        The VPC's region. Defaults to the region of the AWS provider.
        """
        return pulumi.get(self, "vpc_region")

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> pulumi.Output[str]:
        """
        The private hosted zone to associate.
        """
        return pulumi.get(self, "zone_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

