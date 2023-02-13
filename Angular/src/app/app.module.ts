import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule} from '@angular/forms'

import { AppComponent } from './app.component';
import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';
import { ContentComponent } from './Components/content/content.component';
import { CalcComponent } from './Components/calc/calc.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    ContentComponent,
    CalcComponent
  ],
  imports: [
    BrowserModule,
    FormsModule//For ngModel 2 way binding....
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
