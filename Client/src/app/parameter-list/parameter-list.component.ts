import { Component, OnInit } from '@angular/core';
import { ParameterService } from '../Services/parameter.service';
import { Parameter } from '../Models/parameter.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-parameter-list',
  standalone: false,
  templateUrl: './parameter-list.component.html',
  styleUrls: ['./parameter-list.component.css']  // Changed from .scss to .css
})
export class ParameterListComponent implements OnInit {
  parameters: Parameter[] = [];

  constructor(
    private parameterService: ParameterService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.loadParameters();
  }

  loadParameters(): void {
    this.parameterService.getParameters()
      .subscribe(parameters => {
        this.parameters = parameters;
      });
  }

  editParameter(id: number): void {
    this.router.navigate(['/parameters/edit', id]);
  }

  deleteParameter(id: number): void {
    if (confirm('آیا از حذف این پارامتر اطمینان دارید؟')) {
      this.parameterService.deleteParameter(id)
        .subscribe(() => {
          this.loadParameters();
        });
    }
  }

  createNewParameter(): void {
    this.router.navigate(['/parameters/new']);
  }
}