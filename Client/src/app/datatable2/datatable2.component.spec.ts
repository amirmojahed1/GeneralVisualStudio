import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Datatable2Component } from './datatable2.component';

describe('Datatable2Component', () => {
  let component: Datatable2Component;
  let fixture: ComponentFixture<Datatable2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Datatable2Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Datatable2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
