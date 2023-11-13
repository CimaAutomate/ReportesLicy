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

  navigation: any;
  isOpened: Boolean = true;
  buttonOptions: any;

  constructor(private router: Router) {
      this.buttonOptions = {
          icon: "menu",
          onClick: () => {
              this.isOpened = !this.isOpened;
          }
      };
      this.navigation = [
          { id: 1, text: "Reportes de impresión", icon: "folder", filePath: "/impresion", selected:true }

      ];
  }

  loadView(e) {
      this.router.navigate([e.addedItems[0].filePath])
  }
}

