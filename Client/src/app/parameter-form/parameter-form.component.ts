import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-parameter-form',
  standalone: false ,
  templateUrl: './parameter-form.component.html',
  styleUrls: ['./parameter-form.component.css']
})
export class ParameterFormComponent implements OnInit {
  parameterForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private http: HttpClient) { }

  ngOnInit() {
    this.parameterForm = this.formBuilder.group({
      title: ['', Validators.required],
      groupName: [''],
      valueControl: [''],
      value: [''],
      status: ['active'],
      displayPriority: [''], // This will now be a select dropdown
      description: ['']
    });
  }

  onSubmit() {
    if (this.parameterForm.valid) {
      console.log('Form submitted:', this.parameterForm.value);
      // Add your form submission logic here
    }
  }

  // onSubmitAndNew() {
  //   if (this.parameterForm.valid) {
  //     console.log('Form submitted and creating new:', this.parameterForm.value);

  //     this.parameterForm.reset({
  //       status: 'active'
  //     });
  //   }
  // }

  onSubmitAndNew() {
    if (this.parameterForm.valid) {
      this.http.post('https://localhost:7024/api/parameter', this.parameterForm.value).subscribe(response => {
        console.log('Form submitted and creating new:', response);
        this.parameterForm.reset({
          status: 'active'
        });
      }, error => {
        console.error('Error saving data:', error);
      });
    }
  }

  onCancel() {
    // Add your cancel logic here
    this.parameterForm.reset();
  }
}