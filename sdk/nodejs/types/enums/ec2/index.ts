// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const InstancePlatform = {
    LinuxUnix: "Linux/UNIX",
    RedHatEnterpriseLinux: "Red Hat Enterprise Linux",
    SuseLinux: "SUSE Linux",
    Windows: "Windows",
    WindowsWithSqlServer: "Windows with SQL Server",
    WindowsWithSqlServerEnterprise: "Windows with SQL Server Enterprise",
    WindowsWithSqlServerStandard: "Windows with SQL Server Standard",
    WindowsWithSqlServerWeb: "Windows with SQL Server Web",
} as const;

export type InstancePlatform = (typeof InstancePlatform)[keyof typeof InstancePlatform];

export const InstanceType = {
    A1_2XLarge: "a1.2xlarge",
    A1_4XLarge: "a1.4xlarge",
    A1_Large: "a1.large",
    A1_Medium: "a1.medium",
    A1_XLarge: "a1.xlarge",
    C3_2XLarge: "c3.2xlarge",
    C3_4XLarge: "c3.4xlarge",
    C3_8XLarge: "c3.8xlarge",
    C3_Large: "c3.large",
    C3_XLarge: "c3.xlarge",
    C4_2XLarge: "c4.2xlarge",
    C4_4XLarge: "c4.4xlarge",
    C4_8XLarge: "c4.8xlarge",
    C4_Large: "c4.large",
    C4_XLarge: "c4.xlarge",
    C5_18XLarge: "c5.18xlarge",
    C5_2XLarge: "c5.2xlarge",
    C5_4XLarge: "c5.4xlarge",
    C5_9XLarge: "c5.9xlarge",
    C5_Large: "c5.large",
    C5_XLarge: "c5.xlarge",
    C5a_12XLarge: "c5a.12xlarge",
    C5a_16XLarge: "c5a.16xlarge",
    C5a_2XLarge: "c5a.2xlarge",
    C5a_24XLarge: "c5a.24xlarge",
    C5a_4XLarge: "c5a.4xlarge",
    C5a_8XLarge: "c5a.8xlarge",
    C5a_Large: "c5a.large",
    C5a_XLarge: "c5a.xlarge",
    C5d_18XLarge: "c5d.18xlarge",
    C5d_2XLarge: "c5d.2xlarge",
    C5d_4XLarge: "c5d.4xlarge",
    C5d_9XLarge: "c5d.9xlarge",
    C5d_Large: "c5d.large",
    C5d_XLarge: "c5d.xlarge",
    C5n_18XLarge: "c5n.18xlarge",
    C5n_2XLarge: "c5n.2xlarge",
    C5n_4XLarge: "c5n.4xlarge",
    C5n_9XLarge: "c5n.9xlarge",
    C5n_Large: "c5n.large",
    C5n_XLarge: "c5n.xlarge",
    D2_2XLarge: "d2.2xlarge",
    D2_4XLarge: "d2.4xlarge",
    D2_8XLarge: "d2.8xlarge",
    D2_XLarge: "d2.xlarge",
    F1_16XLarge: "f1.16xlarge",
    F1_2XLarge: "f1.2xlarge",
    G2_2XLarge: "g2.2xlarge",
    G2_8XLarge: "g2.8xlarge",
    G3_16XLarge: "g3.16xlarge",
    G3_4XLarge: "g3.4xlarge",
    G3_8XLarge: "g3.8xlarge",
    G3s_XLarge: "g3s.xlarge",
    H1_16XLarge: "h1.16xlarge",
    H1_2XLarge: "h1.2xlarge",
    H1_4XLarge: "h1.4xlarge",
    H1_8XLarge: "h1.8xlarge",
    Hs1_8XLarge: "hs1.8xlarge",
    I3_16XLarge: "i3.16xlarge",
    I3_2XLarge: "i3.2xlarge",
    I3_4XLarge: "i3.4xlarge",
    I3_8XLarge: "i3.8xlarge",
    I3_Large: "i3.large",
    I3_XLarge: "i3.xlarge",
    I3_Metal: "i3.metal",
    M3_2XLarge: "m3.2xlarge",
    M3_Large: "m3.large",
    M3_Medium: "m3.medium",
    M3_XLarge: "m3.xlarge",
    M4_10XLarge: "m4.10xlarge",
    M4_16XLarge: "m4.16xlarge",
    M4_2XLarge: "m4.2xlarge",
    M4_4XLarge: "m4.4xlarge",
    M4_Large: "m4.large",
    M4_XLarge: "m4.xlarge",
    M5_Large: "m5.large",
    M5_XLarge: "m5.xlarge",
    M5_2XLarge: "m5.2xlarge",
    M5_4XLarge: "m5.4xlarge",
    M5_12XLarge: "m5.12xlarge",
    M5_24XLarge: "m5.24xlarge",
    M5d_Large: "m5d.large",
    M5d_XLarge: "m5d.xlarge",
    M5d_2XLarge: "m5d.2xlarge",
    M5d_4XLarge: "m5d.4xlarge",
    M5d_12XLarge: "m5d.12xlarge",
    M5d_24XLarge: "m5d.24xlarge",
    M5a_12XLarge: "m5a.12xlarge",
    M5a_24XLarge: "m5a.24xlarge",
    M5a_2XLarge: "m5a.2xlarge",
    M5a_4XLarge: "m5a.4xlarge",
    M5a_Large: "m5a.large",
    M5a_XLarge: "m5a.xlarge",
    P2_16XLarge: "p2.16xlarge",
    P2_8XLarge: "p2.8xlarge",
    P2_XLarge: "p2.xlarge",
    P3_16XLarge: "p3.16xlarge",
    P3_2XLarge: "p3.2xlarge",
    P3_8XLarge: "p3.8xlarge",
    P3dn_24XLarge: "p3dn.24xlarge",
    R3_2XLarge: "r3.2xlarge",
    R3_4XLarge: "r3.4xlarge",
    R3_8XLarge: "r3.8xlarge",
    R3_Large: "r3.large",
    R3_XLarge: "r3.xlarge",
    R4_16XLarge: "r4.16xlarge",
    R4_2XLarge: "r4.2xlarge",
    R4_4XLarge: "r4.4xlarge",
    R4_8XLarge: "r4.8xlarge",
    R4_Large: "r4.large",
    R4_XLarge: "r4.xlarge",
    R5_12XLarge: "r5.12xlarge",
    R5_24XLarge: "r5.24xlarge",
    R5_2XLarge: "r5.2xlarge",
    R5_4XLarge: "r5.4xlarge",
    R5_Large: "r5.large",
    R5_XLarge: "r5.xlarge",
    R5a_12XLarge: "r5a.12xlarge",
    R5a_24XLarge: "r5a.24xlarge",
    R5a_2XLarge: "r5a.2xlarge",
    R5a_4XLarge: "r5a.4xlarge",
    R5a_Large: "r5a.large",
    R5a_XLarge: "r5a.xlarge",
    R5d_12XLarge: "r5d.12xlarge",
    R5d_24XLarge: "r5d.24xlarge",
    R5d_2XLarge: "r5d.2xlarge",
    R5d_4XLarge: "r5d.4xlarge",
    R5d_Large: "r5d.large",
    R5d_XLarge: "r5d.xlarge",
    T2_2XLarge: "t2.2xlarge",
    T2_Large: "t2.large",
    T2_Medium: "t2.medium",
    T2_Micro: "t2.micro",
    T2_Nano: "t2.nano",
    T2_Small: "t2.small",
    T2_XLarge: "t2.xlarge",
    T3_2XLarge: "t3.2xlarge",
    T3_Large: "t3.large",
    T3_Medium: "t3.medium",
    T3_Micro: "t3.micro",
    T3_Nano: "t3.nano",
    T3_Small: "t3.small",
    T3_XLarge: "t3.xlarge",
    T3a_2XLarge: "t3a.2xlarge",
    T3a_Large: "t3a.large",
    T3a_Medium: "t3a.medium",
    T3a_Micro: "t3a.micro",
    T3a_Nano: "t3a.nano",
    T3a_Small: "t3a.small",
    T3a_XLarge: "t3a.xlarge",
    U_12tb1Metal: "u-12tb1.metal",
    U_6tb1Metal: "u-6tb1.metal",
    U_9tb1Metal: "u-9tb1.metal",
    X1_16XLarge: "x1.16xlarge",
    X1_32XLarge: "x1.32xlarge",
    X1e_16XLarge: "x1e.16xlarge",
    X1e_2XLarge: "x1e.2xlarge",
    X1e_32XLarge: "x1e.32xlarge",
    X1e_4XLarge: "x1e.4xlarge",
    X1e_8XLarge: "x1e.8xlarge",
    X1e_XLarge: "x1e.xlarge",
    Z1d_12XLarge: "z1d.12xlarge",
    Z1d_2XLarge: "z1d.2xlarge",
    Z1d_3XLarge: "z1d.3xlarge",
    Z1d_6XLarge: "z1d.6xlarge",
    Z1d_Large: "z1d.large",
    Z1d_XLarge: "z1d.xlarge",
} as const;

export type InstanceType = (typeof InstanceType)[keyof typeof InstanceType];

export const PlacementStrategy = {
    /**
     * A `spread` placement group places instances on distinct hardware.
     */
    Spread: "spread",
    /**
     * A `cluster` placement group is a logical grouping of instances within a single
     * Availability Zone that benefit from low network latency, high network throughput.
     */
    Cluster: "cluster",
} as const;

/**
 * The strategy of the placement group determines how the instances are organized within the group.
 * See https://docs.aws.amazon.com/cli/latest/reference/ec2/create-placement-group.html
 */
export type PlacementStrategy = (typeof PlacementStrategy)[keyof typeof PlacementStrategy];

export const ProtocolType = {
    All: "all",
    TCP: "tcp",
    UDP: "udp",
    ICMP: "icmp",
} as const;

export type ProtocolType = (typeof ProtocolType)[keyof typeof ProtocolType];

export const Tenancy = {
    Default: "default",
    Dedicated: "dedicated",
} as const;

export type Tenancy = (typeof Tenancy)[keyof typeof Tenancy];
