import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CrudHttpService } from '../crud-http.service';
@Component({
 selector: 'app-edit-user',
templateUrl: './edit-user.component.html',
styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {
 uid=this.actroute.snapshot.params['id'];
 Users:any=[];
 constructor(
 public actroute:ActivatedRoute,
 public cs:CrudHttpService,
 public rt:Router) { }
 ngOnInit(): void {
 this.cs.getSingleUser(this.uid).subscribe((res:{}) => {
 this.Users=res;
 })
 }
 updateUser(id:any,data:any)
 {
 this.cs.editUser(id,data).subscribe(res => {
 this.rt.navigate(['list']);
 })
 }
}
