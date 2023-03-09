export class Contato {
  id?: number;
  nome?: string;
  telefone?: string;
  estado?: string;
  cidade?: string;
  bairro?: string;
  constructor(obj: Partial<Contato>){
    Object.assign(this,obj);
 }
}
