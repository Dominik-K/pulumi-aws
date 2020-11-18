// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Rds.Inputs
{

    public sealed class ProxyDefaultTargetGroupConnectionPoolConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of seconds for a proxy to wait for a connection to become available in the connection pool. Only applies when the proxy has opened its maximum number of connections and all connections are busy with client sessions.
        /// </summary>
        [Input("connectionBorrowTimeout")]
        public Input<int>? ConnectionBorrowTimeout { get; set; }

        /// <summary>
        /// One or more SQL statements for the proxy to run when opening each new database connection. Typically used with `SET` statements to make sure that each connection has identical settings such as time zone and character set. This setting is empty by default. For multiple statements, use semicolons as the separator. You can also include multiple variables in a single `SET` statement, such as `SET x=1, y=2`.
        /// </summary>
        [Input("initQuery")]
        public Input<string>? InitQuery { get; set; }

        /// <summary>
        /// The maximum size of the connection pool for each target in a target group. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.
        /// </summary>
        [Input("maxConnectionsPercent")]
        public Input<int>? MaxConnectionsPercent { get; set; }

        /// <summary>
        /// Controls how actively the proxy closes idle database connections in the connection pool. A high value enables the proxy to leave a high percentage of idle connections open. A low value causes the proxy to close idle client connections and return the underlying database connections to the connection pool. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.
        /// </summary>
        [Input("maxIdleConnectionsPercent")]
        public Input<int>? MaxIdleConnectionsPercent { get; set; }

        [Input("sessionPinningFilters")]
        private InputList<string>? _sessionPinningFilters;

        /// <summary>
        /// Each item in the list represents a class of SQL operations that normally cause all later statements in a session using a proxy to be pinned to the same underlying database connection. Including an item in the list exempts that class of SQL operations from the pinning behavior. Currently, the only allowed value is `EXCLUDE_VARIABLE_SETS`.
        /// </summary>
        public InputList<string> SessionPinningFilters
        {
            get => _sessionPinningFilters ?? (_sessionPinningFilters = new InputList<string>());
            set => _sessionPinningFilters = value;
        }

        public ProxyDefaultTargetGroupConnectionPoolConfigArgs()
        {
        }
    }
}
