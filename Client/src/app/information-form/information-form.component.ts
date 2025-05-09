import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { InformationFormService } from '../Services/information-form.service';

@Component({
  selector: 'app-information-form',
  templateUrl: './information-form.component.html',
  styleUrls: ['./information-form.component.css']
})
export class InformationFormComponent {
  form: FormGroup;

  constructor(private fb: FormBuilder, private service: InformationFormService) {
    this.form = this.fb.group({
      leader: [''],
      title: [''],
      value: [0],
      valueControl: [false],
      priority: [0],
      status: ['']
    });
  }

  submit() {
    if (this.form.valid) {
      this.service.createForm(this.form.value).subscribe(response => {
        console.log('Form submitted successfully', response);
      });
    }
  }
}
