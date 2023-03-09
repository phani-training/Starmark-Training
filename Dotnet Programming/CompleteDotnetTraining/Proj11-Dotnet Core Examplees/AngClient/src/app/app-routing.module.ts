import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DataComponent } from './Components/data/data.component';

const routes: Routes = [
  {path: "", redirectTo:'admin', pathMatch : "full"},
  {path: "admin", component: DataComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
