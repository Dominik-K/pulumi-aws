# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetRulesPackagesResult:
    """
    A collection of values returned by getRulesPackages.
    """
    def __init__(__self__, arns=None, id=None):
        if arns and not isinstance(arns, list):
            raise TypeError("Expected argument 'arns' to be a list")
        __self__.arns = arns
        """
        A list of the AWS Inspector Rules Packages arns available in the AWS region.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_rules_packages(opts=None):
    """
    The AWS Inspector Rules Packages data source allows access to the list of AWS
    Inspector Rules Packages which can be used by AWS Inspector within the region
    configured in the provider.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/inspector_rules_packages.html.markdown.
    """
    __args__ = dict()

    if opts is None:
        opts = pulumi.ResourceOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = await pulumi.runtime.invoke('aws:inspector/getRulesPackages:getRulesPackages', __args__, opts=opts)

    return GetRulesPackagesResult(
        arns=__ret__.get('arns'),
        id=__ret__.get('id'))
