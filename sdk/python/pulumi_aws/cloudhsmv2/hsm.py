# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class Hsm(pulumi.CustomResource):
    """
    Creates an HSM module in Amazon CloudHSM v2 cluster.
    """
    def __init__(__self__, __name__, __opts__=None, availability_zone=None, cluster_id=None, ip_address=None, subnet_id=None):
        """Create a Hsm resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['availabilityZone'] = availability_zone

        if not cluster_id:
            raise TypeError('Missing required property cluster_id')
        __props__['clusterId'] = cluster_id

        __props__['ipAddress'] = ip_address

        __props__['subnetId'] = subnet_id

        __props__['hsm_eni_id'] = None
        __props__['hsm_id'] = None
        __props__['hsm_state'] = None

        super(Hsm, __self__).__init__(
            'aws:cloudhsmv2/hsm:Hsm',
            __name__,
            __props__,
            __opts__)
