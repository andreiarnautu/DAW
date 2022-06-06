import { Injectable } from '@angular/core';
import { AppRoutingModule } from '../app-routing.module';
import { Books } from './books.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:44392/api/Book';
  formData:Books = new Books();

  postBook() {
    return this.http.post(this.baseURL, this.formData);
  }
}
