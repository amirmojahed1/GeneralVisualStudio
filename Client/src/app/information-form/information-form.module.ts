import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { InformationFormComponent } from './information-form.component';

@NgModule({
  declarations: [
    InformationFormComponent // Declare the form component
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule // ✅ Required for form handling
  ],
  exports: [
    InformationFormComponent // Export for usage in other modules
  ]
})
export class InformationFormModule {}

