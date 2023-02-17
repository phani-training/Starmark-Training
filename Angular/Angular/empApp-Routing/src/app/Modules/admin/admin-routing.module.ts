import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from '../../Components/dashboard/dashboard.component';
import { UserComponent } from '../../Components/user/user.component';
import { RightsComponent } from '../../Components/rights/rights.component';

const routes: Routes = [
  {
    path :"admin",
    children :[
      { path : "Dashboard", component : DashboardComponent},
      { path : "User", component : UserComponent},
      { path : "Rights", component : RightsComponent},
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
