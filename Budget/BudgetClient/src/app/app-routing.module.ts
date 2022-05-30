import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './admin/components/dashboard/dashboard.component';
import { LayoutComponent } from './admin/layout/layout.component';
import { HomeComponent } from './ui/components/home/home.component';

const routes: Routes = [
{
  path: "admin",component:LayoutComponent,children:[
  {path:"",component:DashboardComponent},
  {path:"users", loadChildren:()=> import("./admin/components/users/users.module").then(
    module=> module.UsersModule)},
  {path:"budgets", loadChildren:()=> import("./admin/components/budgets/budgets.module").then(
      module=> module.BudgetsModule)}
]
},
{path:"",component:HomeComponent},
{path:"budgets", loadChildren:()=> import("./ui/components/budgets/budgets.module").then(
  module=> module.BudgetsModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
