import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { ParameterFormComponent } from './parameter-form/parameter-form.component';
import { ParameterListComponent } from './parameter-list/parameter-list.component';

const routes: Routes = [
  { path: '', redirectTo: '/parameters/new', pathMatch: 'full' },
  { path: 'parameters', component: ParameterListComponent },
  { path: 'parameters/new', component: ParameterFormComponent },
  { path: 'parameters/edit/:id', component: ParameterFormComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    ParameterFormComponent,
    ParameterListComponent
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