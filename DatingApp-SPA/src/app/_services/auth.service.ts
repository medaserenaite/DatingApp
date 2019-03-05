import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = 'http://localhost:5000/api/auth/';

constructor(private http: HttpClient) { }

login(model: any) {
  console.log("login in component")
  return this.http.post(this.baseUrl + 'login', model)
    .pipe(
      map((response: any) => {
        console.log("login in component222")

        const user = response;
        if (user) {
          console.log("login in component------333")
          localStorage.setItem('token', user.token);
        }
      })
    );
}

//model stores usern+pw we're going to pass
register(model: any) {
  console.log("register in authsericecomponent")
  return this.http.post(this.baseUrl + 'register', model);
}

}
