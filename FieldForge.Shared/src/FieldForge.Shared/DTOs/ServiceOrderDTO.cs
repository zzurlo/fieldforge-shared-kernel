using System;
namespace FieldForge.Shared.Models
{
    /// <summary>
    /// Data Transfer Object representing a service order
    /// </summary>
    public class ServiceOrderDto
    {
        /// <summary>
        /// Unique identifier for the service order
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of the customer associated with this service order
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Street address where the service is to be performed
        /// </summary>
        public string AddressLine { get; set; }

        /// <summary>
        /// City where the service is to be performed
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State where the service is to be performed
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// ZIP/Postal code where the service is to be performed
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Description of the service to be performed
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Date and time when the service is scheduled
        /// </summary>
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Current status of the service order
        /// </summary>
        public ServiceOrderStatus Status { get; set; }
    }
}