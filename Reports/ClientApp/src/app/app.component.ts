import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'] 
})
export class AppComponent {
  
  title = 'app';

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  navigtion: any;
  isOpened: Boolean = true;
  buttonOptions: any;

  constructor(private router: Router) {
      this.buttonOptions = {
          icon: "menu",
          onClick: () => {
              this.isOpened = !this.isOpened;
          }
      };
      
      this.navigtion = [
        { id: 1, text: "Reportes de impresión", icon: "message", path: "impresion" },
        { id: 2, text: "Reportes de seguridad", icon: "check", path: "impresion" }

      ];
      


      //this.selectDefault();

  }

  private selectDefault(){
    document.addEventListener('DOMContentLoaded', () => {
      const primerElemento = document.querySelector('.dx-list .dx-list-item');
      if (primerElemento) {
        // Crea un nuevo evento de clic
        var event = new MouseEvent('click', {
          'view': window,
          'bubbles': true,
          'cancelable': true
        });
        // Despacha el evento en el primer elemento
        primerElemento.dispatchEvent(event);
      }
    });
  }


  
}

