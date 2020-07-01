# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetSubnetIdsResult:
    """
    A collection of values returned by getSubnetIds.
    """
    def __init__(__self__, filters=None, id=None, ids=None, tags=None, vpc_id=None):
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        __self__.filters = filters
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        __self__.ids = ids
        """
        A set of all the subnet ids found. This data source will fail if none are found.
        """
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        __self__.tags = tags
        if vpc_id and not isinstance(vpc_id, str):
            raise TypeError("Expected argument 'vpc_id' to be a str")
        __self__.vpc_id = vpc_id
class AwaitableGetSubnetIdsResult(GetSubnetIdsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSubnetIdsResult(
            filters=self.filters,
            id=self.id,
            ids=self.ids,
            tags=self.tags,
            vpc_id=self.vpc_id)

def get_subnet_ids(filters=None,tags=None,vpc_id=None,opts=None):
    """
    `ec2.getSubnetIds` provides a set of ids for a vpc_id

    This resource can be useful for getting back a set of subnet ids for a vpc.

    ## Example Usage

    The following shows outputing all cidr blocks for every subnet id in a vpc.

    ```python
    import pulumi
    import pulumi_aws as aws

    example_subnet_ids = aws.ec2.get_subnet_ids(vpc_id=var["vpc_id"])
    example_subnet = [aws.ec2.get_subnet(id=__value) for __key, __value in example_subnet_ids.ids]
    pulumi.export("subnetCidrBlocks", [s.cidr_block for s in example_subnet])
    ```

    The following example retrieves a set of all subnets in a VPC with a custom
    tag of `Tier` set to a value of "Private" so that the `ec2.Instance` resource
    can loop through the subnets, putting instances across availability zones.

    ```python
    import pulumi
    import pulumi_aws as aws

    private = aws.ec2.get_subnet_ids(vpc_id=var["vpc_id"],
        tags={
            "Tier": "Private",
        })
    app = []
    for range in [{"value": i} for i in range(0, data.aws_subnet_ids.example.ids)]:
        app.append(aws.ec2.Instance(f"app-{range['value']}",
            ami=var["ami"],
            instance_type="t2.micro",
            subnet_id=range["value"]))
    ```


    :param list filters: Custom filter block as described below.
    :param dict tags: A map of tags, each pair of which must exactly match
           a pair on the desired subnets.
    :param str vpc_id: The VPC ID that you want to filter from.

    The **filters** object supports the following:

      * `name` (`str`) - The name of the field to filter by, as defined by
        [the underlying AWS API](http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSubnets.html).
        For example, if matching against tag `Name`, use:
      * `values` (`list`) - Set of values that are accepted for the given field.
        Subnet IDs will be selected if any one of the given values match.
    """
    __args__ = dict()


    __args__['filters'] = filters
    __args__['tags'] = tags
    __args__['vpcId'] = vpc_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:ec2/getSubnetIds:getSubnetIds', __args__, opts=opts).value

    return AwaitableGetSubnetIdsResult(
        filters=__ret__.get('filters'),
        id=__ret__.get('id'),
        ids=__ret__.get('ids'),
        tags=__ret__.get('tags'),
        vpc_id=__ret__.get('vpcId'))
