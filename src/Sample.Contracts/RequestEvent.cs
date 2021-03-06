namespace Sample.Contracts
{
    using System;
    using MassTransit;


    [ExcludeFromTopology]
    public record RequestEvent
    {
        /// <summary>
        /// Unique transactionId, to identify this request and match up to subsequent response
        /// </summary>
        public string TransactionId { get; init; } = null!;

        /// <summary>
        /// The routing key/bin for the request
        /// </summary>
        public string? RoutingKey { get; init; }

        public string? Body { get; init; }

        /// <summary>
        /// Timestamp, in UTC, when the request was received
        /// </summary>
        public DateTime? ReceiveTimestamp { get; init; }

        /// <summary>
        /// The incoming request messageId
        /// </summary>
        public Guid? RequestMessageId { get; init; }

        public DateTime? Deadline { get; init; }
    }
}
