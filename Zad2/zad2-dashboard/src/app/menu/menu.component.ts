import { Component } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {
  constructor(private authService: AuthService){}
  isLoggedIn = this.authService.isLoggedIn$;
}
