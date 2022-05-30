import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { Create_Budget } from 'src/app/contracts/create_budget';
import { User } from 'src/app/contracts/user';
import { BudgetService } from 'src/app/services/common/models/budget.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent extends BaseComponent implements OnInit {
  selected!: number;
  DateSelected: any;
  constructor(spinner:NgxSpinnerService,private budgetService:BudgetService) { super(spinner) }

  ngOnInit(): void {
   
  }
 

create(quantity:HTMLInputElement){
  this.showSpinner(SpinnerType.BallAtom);
  const create_budget:Create_Budget= new Create_Budget();
  const user = new User();
  create_budget.quantity=parseFloat(quantity.value);
  create_budget.userId="d3ebb4b9-6ba7-4d05-b0c8-c139929b3a28";
  create_budget.budgetType=this.selected;
  create_budget.budgetDate=this.DateSelected;
  create_budget.user.Id="d3ebb4b9-6ba7-4d05-b0c8-c139929b3a28";
  create_budget.user.name="Gunes";
  create_budget.user.lastName="iliksiz";
  this.budgetService.create(create_budget,() =>this.hideSpinner(SpinnerType.BallAtom));
}

  


}
