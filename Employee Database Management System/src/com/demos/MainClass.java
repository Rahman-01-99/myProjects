package com.demos;
import java.util.Scanner;
public class MainClass {
	public static void main(String[] args) {		
		DBCode db=new DBCode();
		Scanner sc=new Scanner(System.in);
		while(true) {
		System.out.println("Press 1 to Register\nPress 2 to View the Records");
		System.out.println("Press 3 to Edit\nPress 4 to Remove");
		System.out.println("Press 0 to exit");
		System.out.print("Enter Your Choice : ");
		int ch=sc.nextInt();	
		sc.nextLine();
		if(ch==1) {
			System.out.print("Enter the Name : ");
			String name=sc.nextLine();
			System.out.print("Enter the Mail ID : ");
			String mail=sc.nextLine();
			System.out.print("Enter the Salary : ");
			float sal=sc.nextFloat();
			
			int res=db.insert(name, mail, sal);
			System.out.println((res>0)?"Registered":"Not Registered");			
		}
		else if(ch==2) {
				db.select();	
				System.out.println("End of the Records!!!");
		}
		else if(ch==3) {
			System.out.print("Enter the Employee ID : ");
			int id=sc.nextInt();
			System.out.print("Enter the Employee Salary to be Updated : ");
			float sal=sc.nextFloat();
			int res=db.update(id, sal);
			System.out.println((res>0)?"Updated":"Not Updated");
		}
		else if(ch==4) {
			System.out.print("Enter the Employee ID : ");
			int id=sc.nextInt();
			sc.nextLine();
			System.out.print("Press Y to Confirm\nN to Abort");
			char r=sc.next().charAt(0);
			if(r=='Y'||r=='y') {	
				int res=db.delete(id);
				System.out.println((res>0)?"Deleted":"Not Deleted");
			}else {
				System.out.println("Operation Terminated!!!");
			}
		}
		else if(ch==0) {
			System.out.println("----Application Terminated----");
			break;
		}
		else {
			System.out.println("Invalid Operation!!");
		}
	 }
	}
}
