# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = [
    'GrantConstraintArgs',
    'GetSecretSecretArgs',
    'GetSecretsSecretArgs',
]

@pulumi.input_type
class GrantConstraintArgs:
    def __init__(__self__, *,
                 encryption_context_equals: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 encryption_context_subset: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] encryption_context_equals: A list of key-value pairs that must match the encryption context in subsequent cryptographic operation requests. The grant allows the operation only when the encryption context in the request is the same as the encryption context specified in this constraint. Conflicts with `encryption_context_subset`.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] encryption_context_subset: A list of key-value pairs that must be included in the encryption context of subsequent cryptographic operation requests. The grant allows the cryptographic operation only when the encryption context in the request includes the key-value pairs specified in this constraint, although it can include additional key-value pairs. Conflicts with `encryption_context_equals`.
        """
        if encryption_context_equals is not None:
            pulumi.set(__self__, "encryption_context_equals", encryption_context_equals)
        if encryption_context_subset is not None:
            pulumi.set(__self__, "encryption_context_subset", encryption_context_subset)

    @property
    @pulumi.getter(name="encryptionContextEquals")
    def encryption_context_equals(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A list of key-value pairs that must match the encryption context in subsequent cryptographic operation requests. The grant allows the operation only when the encryption context in the request is the same as the encryption context specified in this constraint. Conflicts with `encryption_context_subset`.
        """
        return pulumi.get(self, "encryption_context_equals")

    @encryption_context_equals.setter
    def encryption_context_equals(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "encryption_context_equals", value)

    @property
    @pulumi.getter(name="encryptionContextSubset")
    def encryption_context_subset(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A list of key-value pairs that must be included in the encryption context of subsequent cryptographic operation requests. The grant allows the cryptographic operation only when the encryption context in the request includes the key-value pairs specified in this constraint, although it can include additional key-value pairs. Conflicts with `encryption_context_equals`.
        """
        return pulumi.get(self, "encryption_context_subset")

    @encryption_context_subset.setter
    def encryption_context_subset(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "encryption_context_subset", value)


@pulumi.input_type
class GetSecretSecretArgs:
    def __init__(__self__, *,
                 name: str,
                 payload: str,
                 context: Optional[Mapping[str, str]] = None,
                 grant_tokens: Optional[Sequence[str]] = None):
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "payload", payload)
        if context is not None:
            pulumi.set(__self__, "context", context)
        if grant_tokens is not None:
            pulumi.set(__self__, "grant_tokens", grant_tokens)

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: str):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def payload(self) -> str:
        return pulumi.get(self, "payload")

    @payload.setter
    def payload(self, value: str):
        pulumi.set(self, "payload", value)

    @property
    @pulumi.getter
    def context(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "context")

    @context.setter
    def context(self, value: Optional[Mapping[str, str]]):
        pulumi.set(self, "context", value)

    @property
    @pulumi.getter(name="grantTokens")
    def grant_tokens(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "grant_tokens")

    @grant_tokens.setter
    def grant_tokens(self, value: Optional[Sequence[str]]):
        pulumi.set(self, "grant_tokens", value)


@pulumi.input_type
class GetSecretsSecretArgs:
    def __init__(__self__, *,
                 name: str,
                 payload: str,
                 context: Optional[Mapping[str, str]] = None,
                 grant_tokens: Optional[Sequence[str]] = None):
        """
        :param str name: The name to export this secret under in the attributes.
        :param str payload: Base64 encoded payload, as returned from a KMS encrypt operation.
        :param Mapping[str, str] context: An optional mapping that makes up the Encryption Context for the secret.
        :param Sequence[str] grant_tokens: An optional list of Grant Tokens for the secret.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "payload", payload)
        if context is not None:
            pulumi.set(__self__, "context", context)
        if grant_tokens is not None:
            pulumi.set(__self__, "grant_tokens", grant_tokens)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name to export this secret under in the attributes.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: str):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def payload(self) -> str:
        """
        Base64 encoded payload, as returned from a KMS encrypt operation.
        """
        return pulumi.get(self, "payload")

    @payload.setter
    def payload(self, value: str):
        pulumi.set(self, "payload", value)

    @property
    @pulumi.getter
    def context(self) -> Optional[Mapping[str, str]]:
        """
        An optional mapping that makes up the Encryption Context for the secret.
        """
        return pulumi.get(self, "context")

    @context.setter
    def context(self, value: Optional[Mapping[str, str]]):
        pulumi.set(self, "context", value)

    @property
    @pulumi.getter(name="grantTokens")
    def grant_tokens(self) -> Optional[Sequence[str]]:
        """
        An optional list of Grant Tokens for the secret.
        """
        return pulumi.get(self, "grant_tokens")

    @grant_tokens.setter
    def grant_tokens(self, value: Optional[Sequence[str]]):
        pulumi.set(self, "grant_tokens", value)


