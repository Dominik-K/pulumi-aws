# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = [
    'RecordAlias',
    'RecordFailoverRoutingPolicy',
    'RecordGeolocationRoutingPolicy',
    'RecordLatencyRoutingPolicy',
    'RecordWeightedRoutingPolicy',
    'ResolverEndpointIpAddress',
    'ResolverRuleTargetIp',
    'ZoneVpc',
    'GetResolverEndpointFilterResult',
]

@pulumi.output_type
class RecordAlias(dict):
    def __init__(__self__, *,
                 evaluate_target_health: bool,
                 name: str,
                 zone_id: str):
        """
        :param bool evaluate_target_health: Set to `true` if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see [related part of documentation](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resource-record-sets-values.html#rrsets-values-alias-evaluate-target-health).
        :param str name: DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
        :param str zone_id: Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See `resource_elb.zone_id` for example.
        """
        pulumi.set(__self__, "evaluate_target_health", evaluate_target_health)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "zone_id", zone_id)

    @property
    @pulumi.getter(name="evaluateTargetHealth")
    def evaluate_target_health(self) -> bool:
        """
        Set to `true` if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see [related part of documentation](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resource-record-sets-values.html#rrsets-values-alias-evaluate-target-health).
        """
        return pulumi.get(self, "evaluate_target_health")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> str:
        """
        Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See `resource_elb.zone_id` for example.
        """
        return pulumi.get(self, "zone_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RecordFailoverRoutingPolicy(dict):
    def __init__(__self__, *,
                 type: str):
        """
        :param str type: `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
        """
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RecordGeolocationRoutingPolicy(dict):
    def __init__(__self__, *,
                 continent: Optional[str] = None,
                 country: Optional[str] = None,
                 subdivision: Optional[str] = None):
        """
        :param str continent: A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either `continent` or `country` must be specified.
        :param str country: A two-character country code or `*` to indicate a default resource record set.
        :param str subdivision: A subdivision code for a country.
        """
        if continent is not None:
            pulumi.set(__self__, "continent", continent)
        if country is not None:
            pulumi.set(__self__, "country", country)
        if subdivision is not None:
            pulumi.set(__self__, "subdivision", subdivision)

    @property
    @pulumi.getter
    def continent(self) -> Optional[str]:
        """
        A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either `continent` or `country` must be specified.
        """
        return pulumi.get(self, "continent")

    @property
    @pulumi.getter
    def country(self) -> Optional[str]:
        """
        A two-character country code or `*` to indicate a default resource record set.
        """
        return pulumi.get(self, "country")

    @property
    @pulumi.getter
    def subdivision(self) -> Optional[str]:
        """
        A subdivision code for a country.
        """
        return pulumi.get(self, "subdivision")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RecordLatencyRoutingPolicy(dict):
    def __init__(__self__, *,
                 region: str):
        """
        :param str region: An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency
        """
        pulumi.set(__self__, "region", region)

    @property
    @pulumi.getter
    def region(self) -> str:
        """
        An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency
        """
        return pulumi.get(self, "region")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RecordWeightedRoutingPolicy(dict):
    def __init__(__self__, *,
                 weight: int):
        """
        :param int weight: A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.
        """
        pulumi.set(__self__, "weight", weight)

    @property
    @pulumi.getter
    def weight(self) -> int:
        """
        A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.
        """
        return pulumi.get(self, "weight")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ResolverEndpointIpAddress(dict):
    def __init__(__self__, *,
                 subnet_id: str,
                 ip: Optional[str] = None,
                 ip_id: Optional[str] = None):
        """
        :param str subnet_id: The ID of the subnet that contains the IP address.
        :param str ip: The IP address in the subnet that you want to use for DNS queries.
        """
        pulumi.set(__self__, "subnet_id", subnet_id)
        if ip is not None:
            pulumi.set(__self__, "ip", ip)
        if ip_id is not None:
            pulumi.set(__self__, "ip_id", ip_id)

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> str:
        """
        The ID of the subnet that contains the IP address.
        """
        return pulumi.get(self, "subnet_id")

    @property
    @pulumi.getter
    def ip(self) -> Optional[str]:
        """
        The IP address in the subnet that you want to use for DNS queries.
        """
        return pulumi.get(self, "ip")

    @property
    @pulumi.getter(name="ipId")
    def ip_id(self) -> Optional[str]:
        return pulumi.get(self, "ip_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ResolverRuleTargetIp(dict):
    def __init__(__self__, *,
                 ip: str,
                 port: Optional[int] = None):
        """
        :param str ip: One IP address that you want to forward DNS queries to. You can specify only IPv4 addresses.
        :param int port: The port at `ip` that you want to forward DNS queries to. Default value is `53`
        """
        pulumi.set(__self__, "ip", ip)
        if port is not None:
            pulumi.set(__self__, "port", port)

    @property
    @pulumi.getter
    def ip(self) -> str:
        """
        One IP address that you want to forward DNS queries to. You can specify only IPv4 addresses.
        """
        return pulumi.get(self, "ip")

    @property
    @pulumi.getter
    def port(self) -> Optional[int]:
        """
        The port at `ip` that you want to forward DNS queries to. Default value is `53`
        """
        return pulumi.get(self, "port")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ZoneVpc(dict):
    def __init__(__self__, *,
                 vpc_id: str,
                 vpc_region: Optional[str] = None):
        """
        :param str vpc_id: ID of the VPC to associate.
        :param str vpc_region: Region of the VPC to associate. Defaults to AWS provider region.
        """
        pulumi.set(__self__, "vpc_id", vpc_id)
        if vpc_region is not None:
            pulumi.set(__self__, "vpc_region", vpc_region)

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> str:
        """
        ID of the VPC to associate.
        """
        return pulumi.get(self, "vpc_id")

    @property
    @pulumi.getter(name="vpcRegion")
    def vpc_region(self) -> Optional[str]:
        """
        Region of the VPC to associate. Defaults to AWS provider region.
        """
        return pulumi.get(self, "vpc_region")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GetResolverEndpointFilterResult(dict):
    def __init__(__self__, *,
                 name: str,
                 values: Sequence[str]):
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def values(self) -> Sequence[str]:
        return pulumi.get(self, "values")

