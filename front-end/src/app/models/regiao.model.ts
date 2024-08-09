import { Cidade } from "./cidade.model";

export interface Regiao {
    id: string;
    nome: string;
    ativo: boolean;
    cidades: Cidade[];
}