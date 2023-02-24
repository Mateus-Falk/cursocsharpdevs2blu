export class Character{
  id?: string;
  name?: string;
  status?: string;
  species?: string;
  gender?: string;
  origin?: Place;
  location?: Place;
  image?: string;

  constructor(obj: Partial<Character>){
    Object.assign(this, obj);
  }
}

export class Place{
  name?: string;
  url?: string;

  constructor(obj: Partial<Character>){
    Object.assign(this, obj);
  }
}
