// This interface defines the structure of a "Parameter" object,
// which is used to represent a single item submitted or edited in the parameter form.
// It ensures type safety and consistency throughout the Angular application.

export interface Parameter {
  id?: number;
  title: string;
  groupName: string;
  value: string;
  valueControl: string;
  status: string;
  displayPriority: string;
  description: string;
}