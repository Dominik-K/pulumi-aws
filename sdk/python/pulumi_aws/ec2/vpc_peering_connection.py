# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class VpcPeeringConnection(pulumi.CustomResource):
    accept_status: pulumi.Output[str]
    """
    The status of the VPC Peering Connection request.
    """
    accepter: pulumi.Output[dict]
    """
    An optional configuration block that allows for [VPC Peering Connection]
    (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
    the peering connection (a maximum of one).

      * `allowClassicLinkToRemoteVpc` (`bool`) - Allow a local linked EC2-Classic instance to communicate
        with instances in a peer VPC. This enables an outbound communication from the local ClassicLink connection
        to the remote VPC.
      * `allowRemoteVpcDnsResolution` (`bool`) - Allow a local VPC to resolve public DNS hostnames to
        private IP addresses when queried from instances in the peer VPC. This is
        [not supported](https://docs.aws.amazon.com/vpc/latest/peering/modify-peering-connections.html) for
        inter-region VPC peering.
      * `allowVpcToRemoteClassicLink` (`bool`) - Allow a local VPC to communicate with a linked EC2-Classic
        instance in a peer VPC. This enables an outbound communication from the local VPC to the remote ClassicLink
        connection.
    """
    auto_accept: pulumi.Output[bool]
    """
    Accept the peering (both VPCs need to be in the same AWS account).
    """
    peer_owner_id: pulumi.Output[str]
    """
    The AWS account ID of the owner of the peer VPC.
    Defaults to the account ID the [AWS provider](https://www.terraform.io/docs/providers/aws/index.html) is currently connected to.
    """
    peer_region: pulumi.Output[str]
    """
    The region of the accepter VPC of the [VPC Peering Connection]. `auto_accept` must be `false`,
    and use the `ec2.VpcPeeringConnectionAccepter` to manage the accepter side.
    """
    peer_vpc_id: pulumi.Output[str]
    """
    The ID of the VPC with which you are creating the VPC Peering Connection.
    """
    requester: pulumi.Output[dict]
    """
    A optional configuration block that allows for [VPC Peering Connection]
    (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
    the peering connection (a maximum of one).

      * `allowClassicLinkToRemoteVpc` (`bool`) - Allow a local linked EC2-Classic instance to communicate
        with instances in a peer VPC. This enables an outbound communication from the local ClassicLink connection
        to the remote VPC.
      * `allowRemoteVpcDnsResolution` (`bool`) - Allow a local VPC to resolve public DNS hostnames to
        private IP addresses when queried from instances in the peer VPC. This is
        [not supported](https://docs.aws.amazon.com/vpc/latest/peering/modify-peering-connections.html) for
        inter-region VPC peering.
      * `allowVpcToRemoteClassicLink` (`bool`) - Allow a local VPC to communicate with a linked EC2-Classic
        instance in a peer VPC. This enables an outbound communication from the local VPC to the remote ClassicLink
        connection.
    """
    tags: pulumi.Output[dict]
    """
    A map of tags to assign to the resource.
    """
    vpc_id: pulumi.Output[str]
    """
    The ID of the requester VPC.
    """
    def __init__(__self__, resource_name, opts=None, accepter=None, auto_accept=None, peer_owner_id=None, peer_region=None, peer_vpc_id=None, requester=None, tags=None, vpc_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a resource to manage a VPC peering connection.

        > **NOTE on VPC Peering Connections and VPC Peering Connection Options:** This provider provides
        both a standalone VPC Peering Connection Options and a VPC Peering Connection
        resource with `accepter` and `requester` attributes. Do not manage options for the same VPC peering
        connection in both a VPC Peering Connection resource and a VPC Peering Connection Options resource.
        Doing so will cause a conflict of options and will overwrite the options.
        Using a VPC Peering Connection Options resource decouples management of the connection options from
        management of the VPC Peering Connection and allows options to be set correctly in cross-account scenarios.

        > **Note:** For cross-account (requester's AWS account differs from the accepter's AWS account) or inter-region
        VPC Peering Connections use the `ec2.VpcPeeringConnection` resource to manage the requester's side of the
        connection and use the `ec2.VpcPeeringConnectionAccepter` resource to manage the accepter's side of the connection.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        foo = aws.ec2.VpcPeeringConnection("foo",
            peer_owner_id=var["peer_owner_id"],
            peer_vpc_id=aws_vpc["bar"]["id"],
            vpc_id=aws_vpc["foo"]["id"])
        ```

        Basic usage with connection options:

        ```python
        import pulumi
        import pulumi_aws as aws

        foo = aws.ec2.VpcPeeringConnection("foo",
            accepter={
                "allowRemoteVpcDnsResolution": True,
            },
            peer_owner_id=var["peer_owner_id"],
            peer_vpc_id=aws_vpc["bar"]["id"],
            requester={
                "allowRemoteVpcDnsResolution": True,
            },
            vpc_id=aws_vpc["foo"]["id"])
        ```

        Basic usage with tags:

        ```python
        import pulumi
        import pulumi_aws as aws

        foo_vpc = aws.ec2.Vpc("fooVpc", cidr_block="10.1.0.0/16")
        bar = aws.ec2.Vpc("bar", cidr_block="10.2.0.0/16")
        foo_vpc_peering_connection = aws.ec2.VpcPeeringConnection("fooVpcPeeringConnection",
            auto_accept=True,
            peer_owner_id=var["peer_owner_id"],
            peer_vpc_id=bar.id,
            tags={
                "Name": "VPC Peering between foo and bar",
            },
            vpc_id=foo_vpc.id)
        ```

        Basic usage with region:

        ```python
        import pulumi
        import pulumi_aws as aws

        foo_vpc = aws.ec2.Vpc("fooVpc", cidr_block="10.1.0.0/16",
        opts=ResourceOptions(provider="aws.us-west-2"))
        bar = aws.ec2.Vpc("bar", cidr_block="10.2.0.0/16",
        opts=ResourceOptions(provider="aws.us-east-1"))
        foo_vpc_peering_connection = aws.ec2.VpcPeeringConnection("fooVpcPeeringConnection",
            peer_owner_id=var["peer_owner_id"],
            peer_vpc_id=bar.id,
            vpc_id=foo_vpc.id,
            peer_region="us-east-1")
        ```
        ## Notes

        If both VPCs are not in the same AWS account do not enable the `auto_accept` attribute.
        The accepter can manage its side of the connection using the `ec2.VpcPeeringConnectionAccepter` resource
        or accept the connection manually using the AWS Management Console, AWS CLI, through SDKs, etc.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] accepter: An optional configuration block that allows for [VPC Peering Connection]
               (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
               the peering connection (a maximum of one).
        :param pulumi.Input[bool] auto_accept: Accept the peering (both VPCs need to be in the same AWS account).
        :param pulumi.Input[str] peer_owner_id: The AWS account ID of the owner of the peer VPC.
               Defaults to the account ID the [AWS provider](https://www.terraform.io/docs/providers/aws/index.html) is currently connected to.
        :param pulumi.Input[str] peer_region: The region of the accepter VPC of the [VPC Peering Connection]. `auto_accept` must be `false`,
               and use the `ec2.VpcPeeringConnectionAccepter` to manage the accepter side.
        :param pulumi.Input[str] peer_vpc_id: The ID of the VPC with which you are creating the VPC Peering Connection.
        :param pulumi.Input[dict] requester: A optional configuration block that allows for [VPC Peering Connection]
               (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
               the peering connection (a maximum of one).
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.
        :param pulumi.Input[str] vpc_id: The ID of the requester VPC.

        The **accepter** object supports the following:

          * `allowClassicLinkToRemoteVpc` (`pulumi.Input[bool]`) - Allow a local linked EC2-Classic instance to communicate
            with instances in a peer VPC. This enables an outbound communication from the local ClassicLink connection
            to the remote VPC.
          * `allowRemoteVpcDnsResolution` (`pulumi.Input[bool]`) - Allow a local VPC to resolve public DNS hostnames to
            private IP addresses when queried from instances in the peer VPC. This is
            [not supported](https://docs.aws.amazon.com/vpc/latest/peering/modify-peering-connections.html) for
            inter-region VPC peering.
          * `allowVpcToRemoteClassicLink` (`pulumi.Input[bool]`) - Allow a local VPC to communicate with a linked EC2-Classic
            instance in a peer VPC. This enables an outbound communication from the local VPC to the remote ClassicLink
            connection.

        The **requester** object supports the following:

          * `allowClassicLinkToRemoteVpc` (`pulumi.Input[bool]`) - Allow a local linked EC2-Classic instance to communicate
            with instances in a peer VPC. This enables an outbound communication from the local ClassicLink connection
            to the remote VPC.
          * `allowRemoteVpcDnsResolution` (`pulumi.Input[bool]`) - Allow a local VPC to resolve public DNS hostnames to
            private IP addresses when queried from instances in the peer VPC. This is
            [not supported](https://docs.aws.amazon.com/vpc/latest/peering/modify-peering-connections.html) for
            inter-region VPC peering.
          * `allowVpcToRemoteClassicLink` (`pulumi.Input[bool]`) - Allow a local VPC to communicate with a linked EC2-Classic
            instance in a peer VPC. This enables an outbound communication from the local VPC to the remote ClassicLink
            connection.
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

            __props__['accepter'] = accepter
            __props__['auto_accept'] = auto_accept
            __props__['peer_owner_id'] = peer_owner_id
            __props__['peer_region'] = peer_region
            if peer_vpc_id is None:
                raise TypeError("Missing required property 'peer_vpc_id'")
            __props__['peer_vpc_id'] = peer_vpc_id
            __props__['requester'] = requester
            __props__['tags'] = tags
            if vpc_id is None:
                raise TypeError("Missing required property 'vpc_id'")
            __props__['vpc_id'] = vpc_id
            __props__['accept_status'] = None
        super(VpcPeeringConnection, __self__).__init__(
            'aws:ec2/vpcPeeringConnection:VpcPeeringConnection',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, accept_status=None, accepter=None, auto_accept=None, peer_owner_id=None, peer_region=None, peer_vpc_id=None, requester=None, tags=None, vpc_id=None):
        """
        Get an existing VpcPeeringConnection resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] accept_status: The status of the VPC Peering Connection request.
        :param pulumi.Input[dict] accepter: An optional configuration block that allows for [VPC Peering Connection]
               (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
               the peering connection (a maximum of one).
        :param pulumi.Input[bool] auto_accept: Accept the peering (both VPCs need to be in the same AWS account).
        :param pulumi.Input[str] peer_owner_id: The AWS account ID of the owner of the peer VPC.
               Defaults to the account ID the [AWS provider](https://www.terraform.io/docs/providers/aws/index.html) is currently connected to.
        :param pulumi.Input[str] peer_region: The region of the accepter VPC of the [VPC Peering Connection]. `auto_accept` must be `false`,
               and use the `ec2.VpcPeeringConnectionAccepter` to manage the accepter side.
        :param pulumi.Input[str] peer_vpc_id: The ID of the VPC with which you are creating the VPC Peering Connection.
        :param pulumi.Input[dict] requester: A optional configuration block that allows for [VPC Peering Connection]
               (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
               the peering connection (a maximum of one).
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.
        :param pulumi.Input[str] vpc_id: The ID of the requester VPC.

        The **accepter** object supports the following:

          * `allowClassicLinkToRemoteVpc` (`pulumi.Input[bool]`) - Allow a local linked EC2-Classic instance to communicate
            with instances in a peer VPC. This enables an outbound communication from the local ClassicLink connection
            to the remote VPC.
          * `allowRemoteVpcDnsResolution` (`pulumi.Input[bool]`) - Allow a local VPC to resolve public DNS hostnames to
            private IP addresses when queried from instances in the peer VPC. This is
            [not supported](https://docs.aws.amazon.com/vpc/latest/peering/modify-peering-connections.html) for
            inter-region VPC peering.
          * `allowVpcToRemoteClassicLink` (`pulumi.Input[bool]`) - Allow a local VPC to communicate with a linked EC2-Classic
            instance in a peer VPC. This enables an outbound communication from the local VPC to the remote ClassicLink
            connection.

        The **requester** object supports the following:

          * `allowClassicLinkToRemoteVpc` (`pulumi.Input[bool]`) - Allow a local linked EC2-Classic instance to communicate
            with instances in a peer VPC. This enables an outbound communication from the local ClassicLink connection
            to the remote VPC.
          * `allowRemoteVpcDnsResolution` (`pulumi.Input[bool]`) - Allow a local VPC to resolve public DNS hostnames to
            private IP addresses when queried from instances in the peer VPC. This is
            [not supported](https://docs.aws.amazon.com/vpc/latest/peering/modify-peering-connections.html) for
            inter-region VPC peering.
          * `allowVpcToRemoteClassicLink` (`pulumi.Input[bool]`) - Allow a local VPC to communicate with a linked EC2-Classic
            instance in a peer VPC. This enables an outbound communication from the local VPC to the remote ClassicLink
            connection.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["accept_status"] = accept_status
        __props__["accepter"] = accepter
        __props__["auto_accept"] = auto_accept
        __props__["peer_owner_id"] = peer_owner_id
        __props__["peer_region"] = peer_region
        __props__["peer_vpc_id"] = peer_vpc_id
        __props__["requester"] = requester
        __props__["tags"] = tags
        __props__["vpc_id"] = vpc_id
        return VpcPeeringConnection(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
