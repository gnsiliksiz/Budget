import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BudgetsComponent } from './budgets.component';
import {MatSidenavModule} from '@angular/material/sidenav';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    BudgetsComponent
  
  ],
  imports: [
    CommonModule,
    MatSidenavModule,
    RouterModule.forChild([
      {path: "",component:BudgetsComponent}
    ])
    
  ]
})
export class BudgetsModule { }
