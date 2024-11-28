using System.ComponentModel.DataAnnotations;

namespace TechTestPaymentAPI.src.Entities
{
    public enum Status
    {
        [Display(Name = "Awaiting payment")]
        AwaitingPayment = 1,

        [Display(Name = "Payment approved")]
        PaymentApproved = 2,

        [Display(Name = "Sent for transport")]
        SentForTransport = 3,

        [Display(Name = "Delivred")]
        Deliverd = 4,

        [Display(Name = "Canceled")]
        Canceled = 5

    }
}