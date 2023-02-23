export class ApiReturn {
  results?: Results[];

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}

export class Results{
  id?: Int16Array;
  name?: string;
  status?: string;
  species?: string;
  gender?: string;
  image?: string;

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}
