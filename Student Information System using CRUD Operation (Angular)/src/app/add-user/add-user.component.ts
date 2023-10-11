import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CrudHttpService } from '../crud-http.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent {
  @Input() userobj={name:'',email:'',phone:0}
  constructor(public cs:CrudHttpService,public rt:Router) { }
  storedata(data:any)
  {
  this.cs.addUser(this.userobj).subscribe((data:{}) => {
  this.rt.navigate(['list']);
  });
  }

}
