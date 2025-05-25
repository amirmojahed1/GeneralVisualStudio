import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ParameterService } from '../Services/parameter.service';
import { Parameter } from '../Models/parameter.model';

@Component({
  selector: 'app-parameter-list',
  templateUrl: './parameter-list.component.html',
  styleUrls: ['./parameter-list.component.css']
})
export class ParameterListComponent implements OnInit {
  parameters: Parameter[] = [];

  constructor(private parameterService: ParameterService, private router: Router) {}

  ngOnInit(): void {
    this.loadParameters();
  }

  loadParameters(): void {
    this.parameterService.getParameters().subscribe(parameters => {
      this.parameters = parameters;
    });
  }

  createNewParameter(): void {
    this.router.navigate(['/parameters/new']); // Navigate to the form page
  }
}
