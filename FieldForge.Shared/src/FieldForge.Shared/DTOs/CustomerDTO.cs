using System;

namespace FieldForge.Shared.Models
{
    /// <summary>
    /// Data Transfer Object representing a customer
    /// </summary>
    public class CustomerDto
    {
        /// <summary>
        /// Unique identifier for the customer
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of the company the customer belongs to
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Full name of the customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email address of the customer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone number of the customer
        /// </summary>
        public string Phone { get; set; }
    }
}