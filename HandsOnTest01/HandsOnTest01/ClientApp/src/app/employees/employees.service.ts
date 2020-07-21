import { Injectable,Inject } from "@angular/core";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { tap, catchError } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private employeesUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { this.employeesUrl = baseUrl }

  getEmployees(id: number): Observable<Employees[]> {
    return this.http.get<Employees[]>(this.employeesUrl+'Employees?id='+id)
      .pipe(
        //tap(data => console.log('All: ' + JSON.stringify(data))),
        catchError(this.handleError)
      );
  }

  private handleError(err: HttpErrorResponse) {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }
}
