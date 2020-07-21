import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EmployeeService } from './employees.service';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'employees',
  templateUrl: './employees.component.html'
})
export class EmployeesComponent implements OnInit {
  employees: Employees[];
  form: FormGroup;
  baseUrl: string;
  errorMessage = '';
  _id:number = 0;
  get id(): number {
    return this.id;
  }
  set id(value: number) {
    this._id = value;
    this.performFilter(value);
  }
  constructor(private fb:FormBuilder, private employeesService: EmployeeService) { }
  ngOnInit(): void {
    this.performFilter();
    this.form = this.fb.group({ id: [''] });
    
    this.form.get('id').valueChanges.subscribe((employeeId) => {
      if (employeeId == '') { employeeId = 0; }
      this.performFilter(employeeId);
    });
    
  }
  performFilter(filterBy: number=0){
    this.employeesService.getEmployees(filterBy).subscribe({
      next: employees => {
        this.employees = employees;
      },
      error: err => this.errorMessage = err
    });
  }
}

