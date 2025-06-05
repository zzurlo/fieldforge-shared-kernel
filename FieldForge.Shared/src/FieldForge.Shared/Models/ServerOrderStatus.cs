namespace FieldForge.Shared.Models
{
    /// <summary>
    /// Represents the current status of a service order
    /// </summary>
    public enum ServiceOrderStatus
    {
        /// <summary>
        /// Service order is scheduled but not yet started
        /// </summary>
        Scheduled = 0,

        /// <summary>
        /// Service order is currently being worked on
        /// </summary>
        InProgress = 1,

        /// <summary>
        /// Service order has been completed
        /// </summary>
        Completed = 2
    }
}