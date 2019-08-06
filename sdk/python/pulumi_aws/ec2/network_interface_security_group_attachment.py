# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class NetworkInterfaceSecurityGroupAttachment(pulumi.CustomResource):
    network_interface_id: pulumi.Output[str]
    """
    The ID of the network interface to attach to.
    """
    security_group_id: pulumi.Output[str]
    """
    The ID of the security group.
    """
    def __init__(__self__, resource_name, opts=None, network_interface_id=None, security_group_id=None, __name__=None, __opts__=None):
        """
        This resource attaches a security group to an Elastic Network Interface (ENI).
        It can be used to attach a security group to any existing ENI, be it a
        secondary ENI or one attached as the primary interface on an instance.
        
        > **NOTE on instances, interfaces, and security groups:** This provider currently
        provides the capability to assign security groups via the [`ec2.Instance`][1]
        and the [`ec2.NetworkInterface`][2] resources. Using this resource in
        conjunction with security groups provided in-line in those resources will cause
        conflicts, and will lead to spurious diffs and undefined behavior - please use
        one or the other.
        
        [1]: /docs/providers/aws/d/instance.html
        [2]: /docs/providers/aws/r/network_interface.html
        
        ## Output Reference
        
        There are no outputs for this resource.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] network_interface_id: The ID of the network interface to attach to.
        :param pulumi.Input[str] security_group_id: The ID of the security group.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/network_interface_sg_attachment.html.markdown.
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

        if network_interface_id is None:
            raise TypeError("Missing required property 'network_interface_id'")
        __props__['network_interface_id'] = network_interface_id

        if security_group_id is None:
            raise TypeError("Missing required property 'security_group_id'")
        __props__['security_group_id'] = security_group_id

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(NetworkInterfaceSecurityGroupAttachment, __self__).__init__(
            'aws:ec2/networkInterfaceSecurityGroupAttachment:NetworkInterfaceSecurityGroupAttachment',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

