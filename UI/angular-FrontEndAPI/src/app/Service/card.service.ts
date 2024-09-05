import { HttpClient } from "@angular/common/http";
import { Card } from "../Models/cards";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
    providedIn:'root'
})

export class CardService{
    baseUrl = 'https://localhost:7047/api/Card';
    constructor(private http:HttpClient){}
    getAllCards():Observable<Card[]>{
        return this.http.get<Card[]>(this.baseUrl);
    }
}

