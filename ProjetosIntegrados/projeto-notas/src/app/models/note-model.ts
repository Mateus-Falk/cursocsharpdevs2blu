import { User } from './user-model';

export class Note {
  id?: number;
  userid?: number;
  title?: string;
  description?: string;
  category?: number;
  Fixed?: boolean;
  timeNote?: Date;
  user?: User = new User({});

  constructor(obj: Partial<Note>){
    Object.assign(this,obj);
  }
}
