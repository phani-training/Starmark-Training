import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable} from 'rxjs';
import { Place } from '../Models/place';
/*
services are singleton classes. They have a directive called Injectable that makes its instance available thru DI by angular. DI is done using constructors. 
We can use services to create functions and data that can be accessed from anywhere within the module. It can be used among the components. 

HttpClient is a class within the HttpClient module that has APIs for performing REST full calls using http methods: get, put, post and delete. 
*/
@Injectable({
  providedIn: 'root'
})
export class PlaceService {
  url : string ="http://localhost:60835/api/Places";
  constructor(private proxy : HttpClient) { }//The angular creates an object of the type HttpClient and makes that as private field of this class
  
  public getAllPlaces() : Observable<Place[]>{
    return this.proxy.get<Place[]>(this.url);
  }
  
  getAllImages(PlaceId: number): any {
    const tempUrl = this.url + "/Images/" + PlaceId; 
    return this.proxy.get(tempUrl);
  }

  addNewPlace(postedData : any){
    const tempUrl = "http://localhost:60835/api/Places/Tourist";
    return this.proxy.post(tempUrl, postedData);
  }
}
