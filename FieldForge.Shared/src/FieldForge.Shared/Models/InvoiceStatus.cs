namespace FieldForge.Shared.Models
{
    /// <summary>
    /// Represents the current status of an invoice
    /// </summary>
    public enum InvoiceStatus
    {
        /// <summary>
        /// Invoice is pending and not yet sent to the customer
        /// </summary>
        Pending = 0,

        /// <summary>
        /// Invoice has been sent to the customer
        /// </summary>
        Sent = 1,

        /// <summary>
        /// Invoice has been paid by the customer
        /// </summary>
        Paid = 2
    }
}