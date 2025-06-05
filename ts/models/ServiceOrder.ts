/**
 * Status enum for service orders
 */
export enum ServiceOrderStatus {
    Scheduled = 'Scheduled',
    InProgress = 'InProgress',
    Completed = 'Completed'
}

/**
 * Interface representing a service order data transfer object
 */
export interface ServiceOrderDto {
    /** Unique identifier for the service order */
    id: string;
    /** Identifier of the customer associated with this service order */
    customerId: string;
    /** Street address where the service is to be performed */
    addressLine: string;
    /** City where the service is to be performed */
    city: string;
    /** State where the service is to be performed */
    state: string;
    /** ZIP/Postal code where the service is to be performed */
    zip: string;
    /** Description of the service to be performed */
    description: string;
    /** Date and time when the service is scheduled (ISO 8601 string) */
    scheduledDate: string;
    /** Current status of the service order */
    status: ServiceOrderStatus;
}