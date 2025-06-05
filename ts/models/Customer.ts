/**
 * Interface representing a customer data transfer object
 */
export interface CustomerDto {
    /** Unique identifier for the customer */
    id: string;
    /** Identifier of the company the customer belongs to */
    companyId: string;
    /** Full name of the customer */
    name: string;
    /** Email address of the customer */
    email: string;
    /** Phone number of the customer */
    phone: string;
}