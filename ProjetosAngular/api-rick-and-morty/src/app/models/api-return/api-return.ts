export class ApiReturn {
  results?: Results[];

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}

export class Results{
  id?: string;
  name?: string;
  image?: string;

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}
