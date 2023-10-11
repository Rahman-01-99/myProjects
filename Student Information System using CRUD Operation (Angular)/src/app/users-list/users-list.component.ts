import { Component, OnInit } from '@angular/core';
import { CrudHttpService } from '../crud-http.service'
@Component({
 selector: 'app-users-list',
templateUrl: './users-list.component.html',
styleUrls: ['./users-list.component.css']
})
export class UsersListComponent implements OnInit {
 Users:any=[];
 constructor(public cs:CrudHttpService) { }
 ngOnInit(): void {
 this.fetchUsers();
 }
 fetchUsers()
 {
 this.cs.getUsers().subscribe((res:{}) => {
 this.Users=res;
 })
 }
 delete(id:number)
 {
 if(window.confirm("Are you delete this user?"))
 {
 this.cs.deleteUser(id).subscribe(res => {
 this.fetchUsers();
 })
 }
}
}