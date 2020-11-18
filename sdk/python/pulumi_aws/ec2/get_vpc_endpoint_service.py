# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = [
    'GetVpcEndpointServiceResult',
    'AwaitableGetVpcEndpointServiceResult',
    'get_vpc_endpoint_service',
]

@pulumi.output_type
class GetVpcEndpointServiceResult:
    """
    A collection of values returned by getVpcEndpointService.
    """
    def __init__(__self__, acceptance_required=None, arn=None, availability_zones=None, base_endpoint_dns_names=None, filters=None, id=None, manages_vpc_endpoints=None, owner=None, private_dns_name=None, service=None, service_id=None, service_name=None, service_type=None, tags=None, vpc_endpoint_policy_supported=None):
        if acceptance_required and not isinstance(acceptance_required, bool):
            raise TypeError("Expected argument 'acceptance_required' to be a bool")
        pulumi.set(__self__, "acceptance_required", acceptance_required)
        if arn and not isinstance(arn, str):
            raise TypeError("Expected argument 'arn' to be a str")
        pulumi.set(__self__, "arn", arn)
        if availability_zones and not isinstance(availability_zones, list):
            raise TypeError("Expected argument 'availability_zones' to be a list")
        pulumi.set(__self__, "availability_zones", availability_zones)
        if base_endpoint_dns_names and not isinstance(base_endpoint_dns_names, list):
            raise TypeError("Expected argument 'base_endpoint_dns_names' to be a list")
        pulumi.set(__self__, "base_endpoint_dns_names", base_endpoint_dns_names)
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        pulumi.set(__self__, "filters", filters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if manages_vpc_endpoints and not isinstance(manages_vpc_endpoints, bool):
            raise TypeError("Expected argument 'manages_vpc_endpoints' to be a bool")
        pulumi.set(__self__, "manages_vpc_endpoints", manages_vpc_endpoints)
        if owner and not isinstance(owner, str):
            raise TypeError("Expected argument 'owner' to be a str")
        pulumi.set(__self__, "owner", owner)
        if private_dns_name and not isinstance(private_dns_name, str):
            raise TypeError("Expected argument 'private_dns_name' to be a str")
        pulumi.set(__self__, "private_dns_name", private_dns_name)
        if service and not isinstance(service, str):
            raise TypeError("Expected argument 'service' to be a str")
        pulumi.set(__self__, "service", service)
        if service_id and not isinstance(service_id, str):
            raise TypeError("Expected argument 'service_id' to be a str")
        pulumi.set(__self__, "service_id", service_id)
        if service_name and not isinstance(service_name, str):
            raise TypeError("Expected argument 'service_name' to be a str")
        pulumi.set(__self__, "service_name", service_name)
        if service_type and not isinstance(service_type, str):
            raise TypeError("Expected argument 'service_type' to be a str")
        pulumi.set(__self__, "service_type", service_type)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if vpc_endpoint_policy_supported and not isinstance(vpc_endpoint_policy_supported, bool):
            raise TypeError("Expected argument 'vpc_endpoint_policy_supported' to be a bool")
        pulumi.set(__self__, "vpc_endpoint_policy_supported", vpc_endpoint_policy_supported)

    @property
    @pulumi.getter(name="acceptanceRequired")
    def acceptance_required(self) -> bool:
        """
        Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
        """
        return pulumi.get(self, "acceptance_required")

    @property
    @pulumi.getter
    def arn(self) -> str:
        """
        The Amazon Resource Name (ARN) of the VPC endpoint service.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="availabilityZones")
    def availability_zones(self) -> Sequence[str]:
        """
        The Availability Zones in which the service is available.
        """
        return pulumi.get(self, "availability_zones")

    @property
    @pulumi.getter(name="baseEndpointDnsNames")
    def base_endpoint_dns_names(self) -> Sequence[str]:
        """
        The DNS names for the service.
        """
        return pulumi.get(self, "base_endpoint_dns_names")

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetVpcEndpointServiceFilterResult']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="managesVpcEndpoints")
    def manages_vpc_endpoints(self) -> bool:
        """
        Whether or not the service manages its VPC endpoints - `true` or `false`.
        """
        return pulumi.get(self, "manages_vpc_endpoints")

    @property
    @pulumi.getter
    def owner(self) -> str:
        """
        The AWS account ID of the service owner or `amazon`.
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter(name="privateDnsName")
    def private_dns_name(self) -> str:
        """
        The private DNS name for the service.
        """
        return pulumi.get(self, "private_dns_name")

    @property
    @pulumi.getter
    def service(self) -> Optional[str]:
        return pulumi.get(self, "service")

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> str:
        """
        The ID of the endpoint service.
        """
        return pulumi.get(self, "service_id")

    @property
    @pulumi.getter(name="serviceName")
    def service_name(self) -> str:
        return pulumi.get(self, "service_name")

    @property
    @pulumi.getter(name="serviceType")
    def service_type(self) -> str:
        return pulumi.get(self, "service_type")

    @property
    @pulumi.getter
    def tags(self) -> Mapping[str, str]:
        """
        A map of tags assigned to the resource.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="vpcEndpointPolicySupported")
    def vpc_endpoint_policy_supported(self) -> bool:
        """
        Whether or not the service supports endpoint policies - `true` or `false`.
        """
        return pulumi.get(self, "vpc_endpoint_policy_supported")


class AwaitableGetVpcEndpointServiceResult(GetVpcEndpointServiceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVpcEndpointServiceResult(
            acceptance_required=self.acceptance_required,
            arn=self.arn,
            availability_zones=self.availability_zones,
            base_endpoint_dns_names=self.base_endpoint_dns_names,
            filters=self.filters,
            id=self.id,
            manages_vpc_endpoints=self.manages_vpc_endpoints,
            owner=self.owner,
            private_dns_name=self.private_dns_name,
            service=self.service,
            service_id=self.service_id,
            service_name=self.service_name,
            service_type=self.service_type,
            tags=self.tags,
            vpc_endpoint_policy_supported=self.vpc_endpoint_policy_supported)


def get_vpc_endpoint_service(filters: Optional[Sequence[pulumi.InputType['GetVpcEndpointServiceFilterArgs']]] = None,
                             service: Optional[str] = None,
                             service_name: Optional[str] = None,
                             service_type: Optional[str] = None,
                             tags: Optional[Mapping[str, str]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVpcEndpointServiceResult:
    """
    The VPC Endpoint Service data source details about a specific service that
    can be specified when creating a VPC endpoint within the region configured in the provider.

    ## Example Usage
    ### AWS Service

    ```python
    import pulumi
    import pulumi_aws as aws

    s3 = aws.ec2.get_vpc_endpoint_service(service="s3",
        service_type="Gateway")
    # Create a VPC
    foo = aws.ec2.Vpc("foo", cidr_block="10.0.0.0/16")
    # Create a VPC endpoint
    ep = aws.ec2.VpcEndpoint("ep",
        vpc_id=foo.id,
        service_name=s3.service_name)
    ```
    ### Non-AWS Service

    ```python
    import pulumi
    import pulumi_aws as aws

    custome = aws.ec2.get_vpc_endpoint_service(service_name="com.amazonaws.vpce.us-west-2.vpce-svc-0e87519c997c63cd8")
    ```
    ### Filter

    ```python
    import pulumi
    import pulumi_aws as aws

    test = aws.ec2.get_vpc_endpoint_service(filters=[aws.ec2.GetVpcEndpointServiceFilterArgs(
        name="service-name",
        values=["some-service"],
    )])
    ```


    :param Sequence[pulumi.InputType['GetVpcEndpointServiceFilterArgs']] filters: Configuration block(s) for filtering. Detailed below.
    :param str service: The common name of an AWS service (e.g. `s3`).
    :param str service_name: The service name that is specified when creating a VPC endpoint. For AWS services the service name is usually in the form `com.amazonaws.<region>.<service>` (the SageMaker Notebook service is an exception to this rule, the service name is in the form `aws.sagemaker.<region>.notebook`).
    :param str service_type: The service type, `Gateway` or `Interface`.
    :param Mapping[str, str] tags: A map of tags, each pair of which must exactly match a pair on the desired VPC Endpoint Service.
    """
    __args__ = dict()
    __args__['filters'] = filters
    __args__['service'] = service
    __args__['serviceName'] = service_name
    __args__['serviceType'] = service_type
    __args__['tags'] = tags
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:ec2/getVpcEndpointService:getVpcEndpointService', __args__, opts=opts, typ=GetVpcEndpointServiceResult).value

    return AwaitableGetVpcEndpointServiceResult(
        acceptance_required=__ret__.acceptance_required,
        arn=__ret__.arn,
        availability_zones=__ret__.availability_zones,
        base_endpoint_dns_names=__ret__.base_endpoint_dns_names,
        filters=__ret__.filters,
        id=__ret__.id,
        manages_vpc_endpoints=__ret__.manages_vpc_endpoints,
        owner=__ret__.owner,
        private_dns_name=__ret__.private_dns_name,
        service=__ret__.service,
        service_id=__ret__.service_id,
        service_name=__ret__.service_name,
        service_type=__ret__.service_type,
        tags=__ret__.tags,
        vpc_endpoint_policy_supported=__ret__.vpc_endpoint_policy_supported)
