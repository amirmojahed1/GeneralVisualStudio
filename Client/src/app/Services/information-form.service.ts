import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { InformationForm } from '../Models/information-form.model';

@Injectable({
  providedIn: 'root'
})
export class InformationFormService {
  private apiUrl = 'http://localhost:7024/api/InformationForm'; // Update if needed

  constructor(private http: HttpClient) {}

  getForms(): Observable<InformationForm[]> {
    return this.http.get<InformationForm[]>(this.apiUrl);
  }

  createForm(form: InformationForm): Observable<InformationForm> {
    return this.http.post<InformationForm>(this.apiUrl, form);
  }
}
