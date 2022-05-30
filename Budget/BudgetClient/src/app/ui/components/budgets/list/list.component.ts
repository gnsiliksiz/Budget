import { Component,AfterViewInit, ViewChild,OnInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';


import {MatTableDataSource, _MatTableDataSource} from '@angular/material/table';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { List_Budgets } from 'src/app/contracts/list_budgets';
import { BudgetService } from 'src/app/services/common/models/budget.service';
@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent extends BaseComponent implements OnInit {

  constructor(spinner:NgxSpinnerService,private budgetService: BudgetService) {super(spinner) }
  displayedColumns: string[] = ['budgetType', 'budgetDate', 'quantity'];

  dataSource = new MatTableDataSource<List_Budgets>();
  
  @ViewChild(MatPaginator) paginator: MatPaginator;
  async ngOnInit()  {
this.showSpinner(SpinnerType.BallAtom);
  const allBudgets:List_Budgets [] = await this.budgetService.read(() => 
  this.hideSpinner(SpinnerType.BallAtom))
   this.dataSource = new MatTableDataSource<List_Budgets>(allBudgets);
    
  }
  }




