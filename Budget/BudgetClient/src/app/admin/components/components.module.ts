import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BudgetsModule } from './budgets/budgets.module';
import { UsersModule } from './users/users.module';
import { DashboardModule } from './dashboard/dashboard.module';




@NgModule({
  declarations: [
   
  ],
  imports: [
    CommonModule,
    BudgetsModule,
    UsersModule,
    DashboardModule
  ]
})
export class ComponentsModule { }
