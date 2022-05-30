import { Component, OnInit } from '@angular/core';
import {  NgxSpinnerService } from 'ngx-spinner';
import { subscribeOn } from 'rxjs';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-budgets',
  templateUrl: './budgets.component.html',
  styleUrls: ['./budgets.component.scss']
})
export class BudgetsComponent extends BaseComponent implements OnInit {

  constructor(spinner:NgxSpinnerService,private httpClientService:HttpClientService) { 
    super(spinner)
  }

  ngOnInit(): void {
    this.showSpinner(SpinnerType.BallAtom);
    this.httpClientService.get({
      controller: "butgets",
    }).subscribe(data=> console.log(data));

 
  }

}
