# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['Domain']


class Domain(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 encryption_key: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a CodeArtifact Domain Resource.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        example_key = aws.kms.Key("exampleKey", description="domain key")
        example_domain = aws.codeartifact.Domain("exampleDomain",
            domain="example",
            encryption_key=example_key.arn)
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: The name of the domain to create. All domain names in an AWS Region that are in the same AWS account must be unique. The domain name is used as the prefix in DNS hostnames. Do not use sensitive information in a domain name because it is publicly discoverable.
        :param pulumi.Input[str] encryption_key: The encryption key for the domain. This is used to encrypt content stored in a domain. The KMS Key Amazon Resource Name (ARN).
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
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

            if domain is None:
                raise TypeError("Missing required property 'domain'")
            __props__['domain'] = domain
            if encryption_key is None:
                raise TypeError("Missing required property 'encryption_key'")
            __props__['encryption_key'] = encryption_key
            __props__['tags'] = tags
            __props__['arn'] = None
            __props__['asset_size_bytes'] = None
            __props__['created_time'] = None
            __props__['owner'] = None
            __props__['repository_count'] = None
        super(Domain, __self__).__init__(
            'aws:codeartifact/domain:Domain',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            arn: Optional[pulumi.Input[str]] = None,
            asset_size_bytes: Optional[pulumi.Input[int]] = None,
            created_time: Optional[pulumi.Input[str]] = None,
            domain: Optional[pulumi.Input[str]] = None,
            encryption_key: Optional[pulumi.Input[str]] = None,
            owner: Optional[pulumi.Input[str]] = None,
            repository_count: Optional[pulumi.Input[int]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'Domain':
        """
        Get an existing Domain resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The ARN of Domain.
        :param pulumi.Input[int] asset_size_bytes: The total size of all assets in the domain.
        :param pulumi.Input[str] created_time: A timestamp that represents the date and time the domain was created in [RFC3339 format](https://tools.ietf.org/html/rfc3339#section-5.8).
        :param pulumi.Input[str] domain: The name of the domain to create. All domain names in an AWS Region that are in the same AWS account must be unique. The domain name is used as the prefix in DNS hostnames. Do not use sensitive information in a domain name because it is publicly discoverable.
        :param pulumi.Input[str] encryption_key: The encryption key for the domain. This is used to encrypt content stored in a domain. The KMS Key Amazon Resource Name (ARN).
        :param pulumi.Input[str] owner: The AWS account ID that owns the domain.
        :param pulumi.Input[int] repository_count: The number of repositories in the domain.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["asset_size_bytes"] = asset_size_bytes
        __props__["created_time"] = created_time
        __props__["domain"] = domain
        __props__["encryption_key"] = encryption_key
        __props__["owner"] = owner
        __props__["repository_count"] = repository_count
        __props__["tags"] = tags
        return Domain(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The ARN of Domain.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="assetSizeBytes")
    def asset_size_bytes(self) -> pulumi.Output[int]:
        """
        The total size of all assets in the domain.
        """
        return pulumi.get(self, "asset_size_bytes")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> pulumi.Output[str]:
        """
        A timestamp that represents the date and time the domain was created in [RFC3339 format](https://tools.ietf.org/html/rfc3339#section-5.8).
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Output[str]:
        """
        The name of the domain to create. All domain names in an AWS Region that are in the same AWS account must be unique. The domain name is used as the prefix in DNS hostnames. Do not use sensitive information in a domain name because it is publicly discoverable.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="encryptionKey")
    def encryption_key(self) -> pulumi.Output[str]:
        """
        The encryption key for the domain. This is used to encrypt content stored in a domain. The KMS Key Amazon Resource Name (ARN).
        """
        return pulumi.get(self, "encryption_key")

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Output[str]:
        """
        The AWS account ID that owns the domain.
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter(name="repositoryCount")
    def repository_count(self) -> pulumi.Output[int]:
        """
        The number of repositories in the domain.
        """
        return pulumi.get(self, "repository_count")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Key-value map of resource tags.
        """
        return pulumi.get(self, "tags")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

