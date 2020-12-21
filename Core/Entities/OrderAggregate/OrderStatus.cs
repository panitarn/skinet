using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value ="Pending")]
        Pending,

        [EnumMember(Value ="Paymend Received")]
        PaymentReceived,

        [EnumMember(Value ="Payment Failed")]
        PaymentFailed,
    }
}