import {  NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";
import { AdminRoutingModule } from './Modules/admin/admin-routing.module';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';

import { AppComponent } from './app.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { EmpManagerComponent } from './Components/emp-manager/emp-manager.component';
import { ViewEmpComponent } from './Components/view-emp/view-emp.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';
import { EditEmpComponent } from './Components/edit-emp/edit-emp.component';
import { ErrorComponent } from './Components/error/error.component';


const routes : Routes =[
  {path:'', redirectTo:'/employees/admin', pathMatch:'full'},
  {path:'employees/admin', component: EmpManagerComponent},
  {path:'employees/edit/:id', component: EditEmpComponent},
  {path:'employees/view/:id', component: ViewEmpComponent},
  {path:'employees/add', component: AddEmpComponent},
  {path:'admin', loadChildren: () => import('./Modules/admin/admin.module').then(m=>m.AdminModule)},
  {path:'**', component : ErrorComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    EmpManagerComponent,
    ViewEmpComponent,
    AddEmpComponent,
    EditEmpComponent,
    ErrorComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AdminRoutingModule,
    RouterModule.forRoot(routes )
  ],
  providers: [
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
