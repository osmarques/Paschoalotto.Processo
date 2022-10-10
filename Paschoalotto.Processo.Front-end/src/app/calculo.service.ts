import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class CalculoService {
  constructor(private http: HttpClient) { }

  CalcularAcordo(divida:string,vencimento:string ){
    const headers = { 'Content-Type': 'application/json', 'Accept': 'application/json' }
    var teste = this.http.post(`https://localhost:7274/v1/api/calculo`,{"divida": parseFloat(divida), "data_Vencimento": vencimento}).toPromise()
    console.log(teste);
    return teste
  }
}
