import { Injectable } from '@angular/core'; // Marks the service as injectable
import { HttpClient } from '@angular/common/http'; // Allows HTTP communication
import { Observable } from 'rxjs'; // Used for handling asynchronous data
import { Parameter } from '../Models/parameter.model'; // Defines the Parameter data model

@Injectable({
  providedIn: 'root' // Automatically provides the service at the root level of the application
})
export class ParameterService {
  private apiUrl = 'https://localhost:7024/api/parameter'; // Base API URL for parameter-related endpoints

  constructor(private http: HttpClient) { } // Injects HttpClient into the service for making API requests

  /**
   * Retrieves a list of parameters from the API.
   * @returns Observable<Parameter[]> - A stream of parameter data
   */
  getParameters(): Observable<Parameter[]> {
    return this.http.get<Parameter[]>(this.apiUrl);
  }

  /**
   * Retrieves a single parameter by its ID.
   * @param id - The ID of the parameter
   * @returns Observable<Parameter> - A stream containing the requested parameter
   */
  getParameter(id: number): Observable<Parameter> {
    return this.http.get<Parameter>(`${this.apiUrl}/${id}`);
  }

  /**
   * Creates a new parameter and sends it to the API.
   * @param parameter - The parameter object to create
   * @returns Observable<Parameter> - A stream containing the created parameter
   */
  createParameter(parameter: Parameter): Observable<Parameter> {
    return this.http.post<Parameter>(this.apiUrl, parameter);
  }

  /**
   * Updates an existing parameter by its ID.
   * @param id - The ID of the parameter to update
   * @param parameter - The updated parameter object
   * @returns Observable<any> - A stream containing the response from the API
   */
  updateParameter(id: number, parameter: Parameter): Observable<any> {
    return this.http.put(`${this.apiUrl}/${id}`, parameter);
  }

  /**
   * Deletes a parameter by its ID.
   * @param id - The ID of the parameter to delete
   * @returns Observable<any> - A stream containing the deletion response
   */
  deleteParameter(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}
