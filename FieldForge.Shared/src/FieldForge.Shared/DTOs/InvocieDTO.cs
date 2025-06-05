using System;

namespace FieldForge.Shared.Models
{
    /// <summary>
    /// Data Transfer Object representing an invoice
    /// </summary>
    public class InvoiceDto
    {
        /// <summary>
        /// Unique identifier for the invoice
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of the company issuing the invoice
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Identifier of the associated service order
        /// </summary>
        public Guid ServiceOrderId { get; set; }

        /// <summary>
        /// Identifier of the customer being invoiced
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Total amount due on the invoice
        /// </summary>
        public decimal AmountDue { get; set; }

        /// <summary>
        /// Date when the invoice was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Date by which the payment is due
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Current status of the invoice
        /// </summary>
        public InvoiceStatus Status { get; set; }
    }
}