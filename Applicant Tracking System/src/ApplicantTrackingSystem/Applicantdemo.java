package ApplicantTrackingSystem;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;


public class Applicantdemo {

	private Connection con;
	// Server Details 
	String url = "jdbc:mysql://localhost:3306/myproject";
	String user = "root";
	String pass = "";

	public Applicantdemo() {
		try {
			con = DriverManager.getConnection(url, user, pass);
		} catch (SQLException e) {
			System.out.println(e);
		}
	}

	    public boolean login(String username, String password) {
	        try {
	            String query = "SELECT * FROM admin WHERE username = ? AND password = ?";
	            PreparedStatement pst = con.prepareStatement(query);
	            pst.setString(1, username);
	            pst.setString(2, password);
	            ResultSet rs = pst.executeQuery();

	            return rs.next(); 

	        } catch (SQLException e) {
	            System.out.println(e);
	        }

	        return false;
	    }


	
	public int insert(int Id, String FullName, String EmailId, String MobileNo, String Gender, String DoB, String Degree, 
			String Department, float Percentage, int YoP, int Experience, String Role, String Status)   {
		int r = 0;
		try {
			String q = "INSERT INTO applicant(Id, FullName, EmailId, MobileNo, Gender, DoB, Degree, Department, "
					+ "Percentage, YoP, Experience, Role, Status) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			PreparedStatement pst = con.prepareStatement(q);
			pst.setInt(1, Id);
			pst.setString(2, FullName);
			pst.setString(3, EmailId);
			pst.setString(4, MobileNo);
			pst.setString(5, Gender);
			pst.setString(6, DoB);
			pst.setString(7, Degree);
			pst.setString(8, Department);
			pst.setFloat(9, Percentage);
			pst.setInt(10, YoP);
			pst.setInt(11, Experience);
			pst.setString(12, Role);
			pst.setString(13, Status);
			r = pst.executeUpdate();
		} catch (SQLException e) {
			System.out.println(e);
		}
		return r;
	}

	public void select() {
		try {
			String q = "SELECT * FROM applicant";
			PreparedStatement pst = con.prepareStatement(q);
			ResultSet rs = pst.executeQuery();
			while (rs.next()) {
				int cid = rs.getInt("Id");
				String cname = rs.getString("FullName");
				String cmail = rs.getString("EmailId");
				String cmob = rs.getString("MobileNo");
				String cgen = rs.getString("Gender");
				String cdeg = rs.getString("Degree");
				String cdob = rs.getString("DoB");
				String cdept = rs.getString("Department");
				float cper = rs.getFloat("Percentage");
				int cyop = rs.getInt("YoP");
				int cexp = rs.getInt("Experience");
				String crole = rs.getString("Role");
				String cstat = rs.getString("Status");
				
				System.out.println(cid + " " + cname + " " + cmail + " " + cmob + " " +cgen + " " + cdob + " "
				+ cdeg + " " + cdept + " " + cper + " " +cyop + " " + cexp + " " + crole + " " + cstat);
			}
		} catch (SQLException e) {
			System.out.println(e);
		}
	}

	public int update(int Id, String status) {
	    int r = 0;
	    try {
	        String query = "UPDATE Applicant SET Status = ? WHERE Id = ?";
	        PreparedStatement pst = con.prepareStatement(query);
	        pst.setString(1, status);
	        pst.setInt(2, Id);
	        r = pst.executeUpdate();
	    } catch (SQLException e) {
	        System.out.println("Error updating status: " + e.getMessage());
	    }
	    return r;
	}
	
	public int delete(int Id) {
		int r = 0;
		try {
			String q = "DELETE FROM applicant WHERE Id = ?";
			PreparedStatement pst = con.prepareStatement(q);
			pst.setInt(1, Id);
			r = pst.executeUpdate();
		} catch (SQLException e) {
			System.out.println(e);
		}
		return r;
	}

}
