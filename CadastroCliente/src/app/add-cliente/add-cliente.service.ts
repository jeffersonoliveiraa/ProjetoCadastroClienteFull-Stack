import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Cliente } from '../model/Cliente';

@Injectable({
  providedIn: 'root'
})
export class AddClienteService {

  constructor(private http: HttpClient) { }
  CreateCliente(clienteData: any): Observable<HttpResponse<any>>{
    const headers: HttpHeaders = new HttpHeaders({
      'Content-Type': 'application/json'
    });

    //Motando a URL para envio de informação
    const urlService = 'http://localhost:51972/Cliente/';
    debugger
    return this.http.put<HttpResponse<any>>(urlService, clienteData,
      { headers: headers, observe: 'response' }).pipe(catchError(this.errorHandler));
  }
  errorHandler(error: Response) {
    return throwError(error);
  }
}
