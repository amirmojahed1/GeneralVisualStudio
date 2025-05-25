import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';


import { AppComponent } from './app.component';
import { ParameterFormComponent } from './parameter-form/parameter-form.component';
import { ParameterListComponent } from './parameter-list/parameter-list.component';
import { DataTableComponent } from './datatable/datatable.component';
import { Datatable2Component } from './datatable2/datatable2.component';
import { Datatable3Component } from './datatable3/datatable3.component';

const routes: Routes = [
  { path: '', redirectTo: '/parameters/new', pathMatch: 'full' },
  { path: 'parameters', component: ParameterListComponent },
  { path: 'parameters/new', component: ParameterFormComponent },
  { path: 'parameters/edit/:id', component: ParameterFormComponent },
  { path: 'datatable', component: DataTableComponent },
  { path: 'datatable2', component: Datatable2Component },
  { path: 'datatable3', component: Datatable3Component }
];

@NgModule({
  declarations: [
    AppComponent,
    ParameterFormComponent,
    ParameterListComponent,
    Datatable2Component,
    DataTableComponent,
    Datatable3Component
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }