import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Cidade } from "../models/cidade.model";
import { environment } from "src/environments/environment";

@Injectable({
    providedIn: 'root'
  })
  export class CidadeService {
    config = environment;
  
    constructor(private http: HttpClient) { }
  
    list(uf?: string, terms?: string): Observable<Cidade[]> {
      let params = new HttpParams();
      if (uf) {
        params = params.set('uf', uf);
      }
      if (terms) {
        params = params.set('terms', terms);
      }
  
      return this.http.get<Cidade[]>(this.config.API.cidade, { params });
    }
  
    get(id: string): Observable<Cidade> {
      return this.http.get<Cidade>(`${this.config.API.cidade}/${id}`);
    }
  }