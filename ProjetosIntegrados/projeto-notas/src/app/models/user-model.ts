export class User {
  id?: number;
  name?: string;
  login?: string;
  password?: string;

  constructor(obj: Partial<User>){
    Object.assign(this, obj);
  }
}
