package com.demos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
public class DBCode {
	private Connection con;
	//Server Details 
	String url="jdbc:mysql://localhost:3306/accordemp";
	String user="root";
	String pass="";
	public DBCode() {
		try {	con=DriverManager.getConnection(url,user,pass);	}
		catch(SQLException e) { System.out.println(e);	}
	}
	
	public int insert(String ename,String email,float esal) {
		int r=0;
		try {
			String q="insert into Employee(ename,email,esal) values(?,?,?)";
			PreparedStatement pst=con.prepareStatement(q);
			pst.setString(1, ename);
			pst.setString(2, email);
			pst.setFloat(3, esal);
			r=pst.executeUpdate();
		}catch(SQLException e) { System.out.println(e);	}
		return r;
	}
	
	public void select() {
		try {
			String q="select *from employee";
			PreparedStatement pst=con.prepareStatement(q);	
			ResultSet rs =pst.executeQuery();
			while(rs.next()) {
				int sid=rs.getInt("eid");
				String sname=rs.getString("ename");
				String email=rs.getString("email");
				float smark=rs.getFloat("esal");
				System.out.println(sid+" "+sname+" "+email+" "+smark+" ");				
			}
		}catch(SQLException e) { System.out.println(e);	}	
	}
	

	public int update(int eid,float esal) {
		int r=0;
		try {
			String q="update employee set esal=? where eid=?";
			PreparedStatement pst=con.prepareStatement(q);
			pst.setFloat(1, esal);
			pst.setInt(2, eid);
			r=pst.executeUpdate();
		}catch(SQLException e) { System.out.println(e);	}
		return r;
	}
	

	public int delete(int eid) {
		int r=0;
		try {
			String q="delete from employee where eid=?";
			PreparedStatement pst=con.prepareStatement(q);
			pst.setInt(1, eid);
			r=pst.executeUpdate();
		}catch(SQLException e) { System.out.println(e);	}
		return r;
	}
}
