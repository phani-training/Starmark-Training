import { Component, OnInit } from '@angular/core';
import { PlaceService } from '../../Services/place.service';
import { Place } from '../../Models/place';
@Component({
  selector: 'app-places',
  templateUrl: './places.component.html',
  styleUrls: ['./places.component.css']
})
//We get the data for this component from our service. service gets the data from the REST API thru HttpClient. 
export class PlacesComponent implements OnInit{
  show : number = 0;
  places : Place[] = [];
  selectedImages : string[] = [];
  selectedPlace : Place = {} as Place;
  constructor(private service : PlaceService) {
    
  }
  ngOnInit(): void {
    debugger;
   let observableObj = this.service.getAllPlaces();
   observableObj.subscribe((responseResult: Place[])=>{
      this.places = responseResult; 
   }) 
  }

  onDetail(place : Place){
    this.selectedPlace = place;
    let observableObj = this.service.getAllImages(this.selectedPlace.PlaceId);
    let tempdata : any[] = [];
    observableObj.subscribe((data : any[])=>{
      for (const img of data) {
        let tempImg = img.ImageSource.replace("./", "/");
        tempdata.push("assets" + tempImg)
      }
      this.selectedImages = tempdata;
    })
  }

  onAddNew(){
    this.show = 1;
  }
}
