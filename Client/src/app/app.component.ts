import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'Client';
  users:any;

  constructor(private http:HttpClient){}

  ngOnInit(): void {
    this.http.get('https://localhost:7024/api/InformationForm').subscribe((data)=>{
      this.users=data;
    },(error)=>{
      console.log(error);
    },()=>{
      console.log("done");
    });
  }

}
