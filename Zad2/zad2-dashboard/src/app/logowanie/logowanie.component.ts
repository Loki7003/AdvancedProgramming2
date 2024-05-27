import { Component } from '@angular/core';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logowanie',
  templateUrl: './logowanie.component.html',
  styleUrl: './logowanie.component.css'
})
export class LogowanieComponent {
  formData = {
    username: '',
    password: ''
  };

  errorMessage!: string;

  logowanie() {
    if (this.formData.username === 'admin' && this.formData.password === 'admin123'){
      console.log('Zalogowano pomyślnie.');
      this.errorMessage ='' ;
    } else {
      this.errorMessage = 'Błąd logowania. Wprowadź poprawne dane.';
    }
  }
}