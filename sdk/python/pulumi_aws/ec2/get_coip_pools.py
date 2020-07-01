# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetCoipPoolsResult:
    """
    A collection of values returned by getCoipPools.
    """
    def __init__(__self__, filters=None, id=None, pool_ids=None, tags=None):
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        __self__.filters = filters
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if pool_ids and not isinstance(pool_ids, list):
            raise TypeError("Expected argument 'pool_ids' to be a list")
        __self__.pool_ids = pool_ids
        """
        Set of COIP Pool Identifiers
        """
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        __self__.tags = tags
class AwaitableGetCoipPoolsResult(GetCoipPoolsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCoipPoolsResult(
            filters=self.filters,
            id=self.id,
            pool_ids=self.pool_ids,
            tags=self.tags)

def get_coip_pools(filters=None,tags=None,opts=None):
    """
    Provides information for multiple EC2 Customer-Owned IP Pools, such as their identifiers.


    :param list filters: Custom filter block as described below.
    :param dict tags: A mapping of tags, each pair of which must exactly match
           a pair on the desired aws_ec2_coip_pools.

    The **filters** object supports the following:

      * `name` (`str`) - The name of the field to filter by, as defined by
        [the underlying AWS API](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeCoipPools.html).
      * `values` (`list`) - Set of values that are accepted for the given field.
        A COIP Pool will be selected if any one of the given values matches.
    """
    __args__ = dict()


    __args__['filters'] = filters
    __args__['tags'] = tags
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:ec2/getCoipPools:getCoipPools', __args__, opts=opts).value

    return AwaitableGetCoipPoolsResult(
        filters=__ret__.get('filters'),
        id=__ret__.get('id'),
        pool_ids=__ret__.get('poolIds'),
        tags=__ret__.get('tags'))
