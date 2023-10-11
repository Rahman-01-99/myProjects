import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
class User
{
 id!:number;
name!:string;
email!:string;
phone!:number;
}

@Injectable({
  providedIn: 'root'
})
export class CrudHttpService {
  endpoint="http://localhost:3000/users/";

  constructor(public hc:HttpClient) { }
 addUser(data:any):Observable<User>
 {
 return this.hc.post<User>(this.endpoint,data);
 }
 getUsers():Observable<User>
 {
 return this.hc.get<User>(this.endpoint);
 }
 getSingleUser(id:number):Observable<User>
 {
 return this.hc.get<User>(this.endpoint+id);
 }
 editUser(id:number,data:any):Observable<User>
 {
 return this.hc.put<User>(this.endpoint+id,data);
 }
 deleteUser(id:number):Observable<User>
 {
 return this.hc.delete<User>(this.endpoint+id);
 }
}
