# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['LocationFsxWindows']


class LocationFsxWindows(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 fsx_filesystem_arn: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 security_group_arns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 subdirectory: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages an AWS DataSync FSx Windows Location.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.datasync.LocationFsxWindows("example",
            fsx_filesystem_arn=aws_fsx_windows_file_system["example"]["arn"],
            user="SomeUser",
            password="SuperSecretPassw0rd",
            security_group_arns=[aws_security_group["example"]["arn"]])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: The name of the Windows domain that the FSx for Windows server belongs to.
        :param pulumi.Input[str] fsx_filesystem_arn: The Amazon Resource Name (ARN) for the FSx for Windows file system.
        :param pulumi.Input[str] password: The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_arns: The Amazon Resource Names (ARNs) of the security groups that are to use to configure the FSx for Windows file system.
        :param pulumi.Input[str] subdirectory: Subdirectory to perform actions as source or destination.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value pairs of resource tags to assign to the DataSync Location.
        :param pulumi.Input[str] user: The user who has the permissions to access files and folders in the FSx for Windows file system.
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

            __props__['domain'] = domain
            if fsx_filesystem_arn is None:
                raise TypeError("Missing required property 'fsx_filesystem_arn'")
            __props__['fsx_filesystem_arn'] = fsx_filesystem_arn
            if password is None:
                raise TypeError("Missing required property 'password'")
            __props__['password'] = password
            if security_group_arns is None:
                raise TypeError("Missing required property 'security_group_arns'")
            __props__['security_group_arns'] = security_group_arns
            __props__['subdirectory'] = subdirectory
            __props__['tags'] = tags
            if user is None:
                raise TypeError("Missing required property 'user'")
            __props__['user'] = user
            __props__['arn'] = None
            __props__['creation_time'] = None
            __props__['uri'] = None
        super(LocationFsxWindows, __self__).__init__(
            'aws:datasync/locationFsxWindows:LocationFsxWindows',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            arn: Optional[pulumi.Input[str]] = None,
            creation_time: Optional[pulumi.Input[str]] = None,
            domain: Optional[pulumi.Input[str]] = None,
            fsx_filesystem_arn: Optional[pulumi.Input[str]] = None,
            password: Optional[pulumi.Input[str]] = None,
            security_group_arns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            subdirectory: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            uri: Optional[pulumi.Input[str]] = None,
            user: Optional[pulumi.Input[str]] = None) -> 'LocationFsxWindows':
        """
        Get an existing LocationFsxWindows resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: Amazon Resource Name (ARN) of the DataSync Location.
        :param pulumi.Input[str] creation_time: The time that the FSx for Windows location was created.
        :param pulumi.Input[str] domain: The name of the Windows domain that the FSx for Windows server belongs to.
        :param pulumi.Input[str] fsx_filesystem_arn: The Amazon Resource Name (ARN) for the FSx for Windows file system.
        :param pulumi.Input[str] password: The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_arns: The Amazon Resource Names (ARNs) of the security groups that are to use to configure the FSx for Windows file system.
        :param pulumi.Input[str] subdirectory: Subdirectory to perform actions as source or destination.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value pairs of resource tags to assign to the DataSync Location.
        :param pulumi.Input[str] uri: The URL of the FSx for Windows location that was described.
        :param pulumi.Input[str] user: The user who has the permissions to access files and folders in the FSx for Windows file system.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["creation_time"] = creation_time
        __props__["domain"] = domain
        __props__["fsx_filesystem_arn"] = fsx_filesystem_arn
        __props__["password"] = password
        __props__["security_group_arns"] = security_group_arns
        __props__["subdirectory"] = subdirectory
        __props__["tags"] = tags
        __props__["uri"] = uri
        __props__["user"] = user
        return LocationFsxWindows(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        Amazon Resource Name (ARN) of the DataSync Location.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> pulumi.Output[str]:
        """
        The time that the FSx for Windows location was created.
        """
        return pulumi.get(self, "creation_time")

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the Windows domain that the FSx for Windows server belongs to.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="fsxFilesystemArn")
    def fsx_filesystem_arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) for the FSx for Windows file system.
        """
        return pulumi.get(self, "fsx_filesystem_arn")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        """
        The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter(name="securityGroupArns")
    def security_group_arns(self) -> pulumi.Output[Sequence[str]]:
        """
        The Amazon Resource Names (ARNs) of the security groups that are to use to configure the FSx for Windows file system.
        """
        return pulumi.get(self, "security_group_arns")

    @property
    @pulumi.getter
    def subdirectory(self) -> pulumi.Output[str]:
        """
        Subdirectory to perform actions as source or destination.
        """
        return pulumi.get(self, "subdirectory")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Key-value pairs of resource tags to assign to the DataSync Location.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def uri(self) -> pulumi.Output[str]:
        """
        The URL of the FSx for Windows location that was described.
        """
        return pulumi.get(self, "uri")

    @property
    @pulumi.getter
    def user(self) -> pulumi.Output[str]:
        """
        The user who has the permissions to access files and folders in the FSx for Windows file system.
        """
        return pulumi.get(self, "user")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

