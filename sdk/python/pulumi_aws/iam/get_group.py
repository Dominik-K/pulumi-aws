# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from . import outputs

__all__ = [
    'GetGroupResult',
    'AwaitableGetGroupResult',
    'get_group',
]

@pulumi.output_type
class GetGroupResult:
    """
    A collection of values returned by getGroup.
    """
    def __init__(__self__, arn=None, group_id=None, group_name=None, id=None, path=None, users=None):
        if arn and not isinstance(arn, str):
            raise TypeError("Expected argument 'arn' to be a str")
        pulumi.set(__self__, "arn", arn)
        if group_id and not isinstance(group_id, str):
            raise TypeError("Expected argument 'group_id' to be a str")
        pulumi.set(__self__, "group_id", group_id)
        if group_name and not isinstance(group_name, str):
            raise TypeError("Expected argument 'group_name' to be a str")
        pulumi.set(__self__, "group_name", group_name)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if path and not isinstance(path, str):
            raise TypeError("Expected argument 'path' to be a str")
        pulumi.set(__self__, "path", path)
        if users and not isinstance(users, list):
            raise TypeError("Expected argument 'users' to be a list")
        pulumi.set(__self__, "users", users)

    @property
    @pulumi.getter
    def arn(self) -> str:
        """
        The Amazon Resource Name (ARN) specifying the iam user.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> str:
        """
        The stable and unique string identifying the group.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> str:
        return pulumi.get(self, "group_name")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def path(self) -> str:
        """
        The path to the iam user.
        """
        return pulumi.get(self, "path")

    @property
    @pulumi.getter
    def users(self) -> Sequence['outputs.GetGroupUserResult']:
        """
        List of objects containing group member information. See supported fields below.
        """
        return pulumi.get(self, "users")


class AwaitableGetGroupResult(GetGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetGroupResult(
            arn=self.arn,
            group_id=self.group_id,
            group_name=self.group_name,
            id=self.id,
            path=self.path,
            users=self.users)


def get_group(group_name: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetGroupResult:
    """
    This data source can be used to fetch information about a specific
    IAM group. By using this data source, you can reference IAM group
    properties without having to hard code ARNs as input.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_aws as aws

    example = aws.iam.get_group(group_name="an_example_group_name")
    ```


    :param str group_name: The friendly IAM group name to match.
    """
    __args__ = dict()
    __args__['groupName'] = group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:iam/getGroup:getGroup', __args__, opts=opts, typ=GetGroupResult).value

    return AwaitableGetGroupResult(
        arn=__ret__.arn,
        group_id=__ret__.group_id,
        group_name=__ret__.group_name,
        id=__ret__.id,
        path=__ret__.path,
        users=__ret__.users)
