import { Injectable } from '@angular/core'; import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
export interface ContactMessage {
  id?: number; name: string;
  email: string;
  subject: string;
  message: string;
  createdAt?: Date;
} @Injectable({
  providedIn: 'root'
})
export class ContactService {
  private apiUrl = 'https://localhost:7129/api/ContactMessage';
  constructor(private http: HttpClient) { }

  sendMessage(data: ContactMessage): Observable<any> {
    return this.http.post(this.apiUrl, data);
  } 

  getMessages(): Observable<ContactMessage[]> {
    return this.http.get<ContactMessage[]>(this.apiUrl);
  }

}