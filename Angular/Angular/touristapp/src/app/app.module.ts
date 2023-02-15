import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http'


import { AppComponent } from './app.component';
import { PlacesComponent } from './Components/places/places.component';
import { PlaceDetailsComponent } from './Components/place-details/place-details.component';
import { AddNewComponent } from './Components/add-new/add-new.component';
import { PlacePipe } from './Pipes/place.pipe';

@NgModule({
  declarations: [
    AppComponent,
    PlacesComponent,
    PlaceDetailsComponent,
    AddNewComponent,
    PlacePipe
  ],
  imports: [
    BrowserModule, 
    FormsModule, //2 Way binding
    HttpClientModule//Http services
  ],
  
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
