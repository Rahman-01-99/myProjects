import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { CrudHttpService } from './crud-http.service';
import { FormsModule } from '@angular/forms';
import { AddUserComponent } from './add-user/add-user.component';
import { EditUserComponent } from './edit-user/edit-user.component';
import { UsersListComponent } from './users-list/users-list.component';
@NgModule({
 declarations: [
 AppComponent,
AddUserComponent,
EditUserComponent,
UsersListComponent
 ],
 imports: [
 BrowserModule,
AppRoutingModule,
FormsModule,
HttpClientModule
 ],
 providers: [CrudHttpService],
bootstrap: [AppComponent]
})
export class AppModule { }
