import { environment } from "src/environments/environment";
import { HttpClient, HttpErrorResponse } from '@angular/common/http'
import { Observable } from "rxjs";
import { Regiao } from "../models/regiao.model";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
  })
export class RegiaoService {
    config = environment;

    constructor(private http: HttpClient){ }

  getRegioes(): Observable<Regiao[]> {
    return this.http.get<Regiao[]>(`${this.config.API}`);
  }

  getRegiaoById(id: string): Observable<Regiao> {
    return this.http.get<Regiao>(`${this.config.API}/${id}`);
  }

  createRegiao(regiaoDto: Regiao): Observable<void> {
    return this.http.post<void>(`${this.config.API}`, regiaoDto);
  }

  updateRegiao(id: string, regiaoDto: Regiao): Observable<void> {
    return this.http.put<void>(`${this.config.API}/${id}`, regiaoDto);
  }

  deleteRegiao(id: string): Observable<void> {
    return this.http.delete<void>(`${this.config.API}/${id}`);
  }

  toggleAtiva(id: string): Observable<void> {
    return this.http.patch<void>(`${this.config.API}/${id}/toggle`, {});
  }

  exportRegioes(): Observable<Blob> {
    return this.http.get(`${this.config.API}/export`, { responseType: 'blob' });
  }
}