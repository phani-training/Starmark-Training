import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule} from '@angular/forms'

import { AppComponent } from './app.component';
import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';
import { ContentComponent } from './Components/content/content.component';
import { CalcComponent } from './Components/calc/calc.component';
import { MasterComponent } from './Components/master/master.component';
import { EmpDetailComponent } from './Components/emp-detail/emp-detail.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    ContentComponent,
    CalcComponent,
    MasterComponent,
    EmpDetailComponent,
    AddEmpComponent
  ],
  imports: [
    BrowserModule,
    FormsModule//For ngModel 2 way binding....
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
