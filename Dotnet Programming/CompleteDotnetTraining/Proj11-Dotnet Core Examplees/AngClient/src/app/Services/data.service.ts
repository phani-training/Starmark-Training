import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { DataModel } from '../Models/data-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  url : string = "http://localhost:60780/api/Data";
  constructor(private http : HttpClient) { }

  getAllData():Observable<DataModel[]>{
    return this.http.get<DataModel[]>(this.url);
  }
}
