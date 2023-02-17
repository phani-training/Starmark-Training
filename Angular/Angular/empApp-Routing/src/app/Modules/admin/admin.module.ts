import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { DashboardComponent } from '../../Components/dashboard/dashboard.component';
import { UserComponent } from '../../Components/user/user.component';
import { RightsComponent } from '../../Components/rights/rights.component';


@NgModule({
  declarations: [ DashboardComponent, UserComponent, RightsComponent ],
  imports: [
    CommonModule,
    AdminRoutingModule
  ]
})
export class AdminModule { }
