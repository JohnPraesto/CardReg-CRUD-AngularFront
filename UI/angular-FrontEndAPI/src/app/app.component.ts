import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {Card} from './Models/cards'
import { CardService } from './Service/card.service';

export class AppModule{}

@Component({
  selector: 'app-root',
  standalone: false,
  // imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angular-FrontEndAPI';
  cards: Card[] = [];
  card : Card ={
    id:'',
    holderName: '',
    cardNumber:'',
    expireMonth:'',
    expireYear:'',
    cvc: ''
  }


constructor(private cardservice:CardService){}

getAllCards(){
  this.cardservice.getAllCards().subscribe(response => this.cards = response)
}
}