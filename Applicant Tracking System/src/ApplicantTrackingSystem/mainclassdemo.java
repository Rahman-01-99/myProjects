package ApplicantTrackingSystem;

import java.util.Scanner;

public class mainclassdemo {

	public static void main(String[] args) {		
		Applicantdemo db = new Applicantdemo();
		
		
        Scanner sc = new Scanner(System.in);
        System.out.println("Please enter your Username:");
        String username = sc.nextLine();
        System.out.println("Please enter your Password:");
        String password = sc.nextLine();
        if (db.login(username, password)) {
            System.out.println("Login Successful. Access Granted!");
   
		while (true) {  
			
			System.out.println("Welcome to  Database" );
			System.out.println("Press 1 to Register");
			System.out.println("Press 2 to View the Records");
			System.out.println("Press 3 to Edit");
			System.out.println("Press 4 to Remove");
			System.out.println("Press 0 to Exit");
			System.out.print("Enter Your Choice: ");
			int ch = sc.nextInt();	
			sc.nextLine();
			
			if (ch == 1) {
				System.out.print("Enter the Id: ");
				int id = sc.nextInt();
				sc.nextLine();
				System.out.print("Enter the Full Name: ");
				String name = sc.nextLine();
				System.out.print("Enter the Email Id: ");
				String mail = sc.nextLine();
				System.out.print("Enter the Mobile No: ");
				String mob = sc.nextLine();
				System.out.println("Enter the Gender: ");
				String gen = sc.nextLine();
				System.out.println("Enter the DOB:");
				String dob = sc.nextLine();
				System.out.println("Enter the Degree: ");
				String deg = sc.nextLine();
				System.out.println("Enter the Department: ");
				String dept = sc.nextLine();
				System.out.println("Enter the Percentage: ");
				float per = sc.nextFloat();
				System.out.println("Enter the YOP: ");
				int yop = sc.nextInt();
				System.out.println("Enter the Experience");
				int exp = sc.nextInt();
				sc.nextLine();
				System.out.println("Enter the Role: ");
				String role = sc.nextLine();
				System.out.println("Enter the Status");
				String stat = sc.nextLine();
				
				int res = db.insert(id, name, mail, mob, gen, dob, deg, dept, per, yop, exp, role, stat);
				System.out.println((res > 0) ? "Registered" : "Not Registered");			
			} else if (ch == 2) {
				db.select();	
				System.out.println("End of the Records!!!");
			} else if (ch == 3) {
				System.out.print("Enter the Applicant ID: ");
				int id = sc.nextInt();
				sc.nextLine();
				System.out.print("Enter the new Status: ");
				String status = sc.nextLine();
				int res = db.update(id, status);
				System.out.println((res > 0) ? "Updated" : "Not Updated");

			} else if (ch == 4) {
				System.out.print("Enter the Candidate ID: ");
				int id = sc.nextInt();
				sc.nextLine();
				System.out.print("Press Y to Confirm or N to Abort: ");
				char r = sc.next().charAt(0);
				if (r == 'Y' || r == 'y') {	
					int res = db.delete(id);
					System.out.println((res > 0) ? "Deleted" : "Not Deleted");
				} else {
					System.out.println("Operation Terminated!!!");
				}
			} else if (ch == 0) {
				System.out.println("----Application Terminated----");
				break;
			} else {
				System.out.println("Invalid Operation!!");
			} 
		}
		
	 } else {
         System.out.println("Invalid username or password. Access denied!");
     }
		
	sc.close();
	}
 }
