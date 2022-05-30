import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Create_Budget } from 'src/app/contracts/create_budget';
import { List_Budgets } from 'src/app/contracts/list_budgets';
import {HttpClientService} from '../http-client.service';
@Injectable({
  providedIn: 'root'
})
export class BudgetService {

  constructor(private httpClientService: HttpClientService) { }
  create(create_budget:Create_Budget,successCallBack?: any)
  {
  
    this.httpClientService.post({
      controller:"budgets"},create_budget)
      .subscribe(result=>{
        successCallBack();
        alert("basarılı");
});
  }
async read( successCallBack:()=>void):Promise<List_Budgets[] >
  {
   
    const promiseData: Promise<List_Budgets[] > =  this.httpClientService.get<List_Budgets[]>({
     controller:"budgets"
    }).toPromise();

    promiseData.then(d=>successCallBack())
    .catch()
  return promiseData;
     
  }
 /* 
  readd(successCallBack?: any)
  {
  
    this.httpClientService.get<List_Budgets[]>({
      controller:"budgets"})
      .subscribe(result=>{
        successCallBack();
        alert("basarılı");
});
 */
}
