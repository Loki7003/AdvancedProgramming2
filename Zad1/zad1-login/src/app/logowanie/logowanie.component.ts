import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

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

  logowanie() {
    if (this.formData.username === 'admin' && this.formData.password === 'admin123'){
      console.log('Zalogowano pomyślnie.');
    } else {
      console.log('Błąd logowania. Wprowadź poprawne dane.')
    }
  }
}