import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeModule } from './home/home.module';
import { BudgetsModule } from './budgets/budgets.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    HomeModule,
    BudgetsModule
  ]
})
export class ComponentsModule { }
