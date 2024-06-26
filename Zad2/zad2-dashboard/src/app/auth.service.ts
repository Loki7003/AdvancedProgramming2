import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private _isLoggedIn = new BehaviorSubject<boolean>(false);

  isLoggedIn$ = this._isLoggedIn.asObservable();

  login() {
    this._isLoggedIn.next(true);
  }
  
  logout() {
    this._isLoggedIn.next(false);
  }
}