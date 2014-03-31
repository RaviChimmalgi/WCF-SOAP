package com.example.timeclockandroid;

import java.util.Date;
import java.util.Hashtable;

import org.ksoap2.serialization.KvmSerializable;
import org.ksoap2.serialization.PropertyInfo;

public class UserDetails implements KvmSerializable{
	
	String username;
	Date timein;
	Date timeou;
	
	UserDetails() {}
	
	UserDetails(String name, Date first, Date then){
		username=name;
		timein = first;
		timeou = then;
	}

	@Override
	public Object getProperty(int arg0) {
		// TODO Auto-generated method stub
		
	      switch(arg0)
	        {
	        case 0:
	            return username;
	        case 1:
	            return timein;
	        case 2:
	            return timeou;
	        }
		
		return null;
	}

	@Override
	public int getPropertyCount() {
		// TODO Auto-generated method stub
		return 3;
	}

	@Override
	public void getPropertyInfo(int arg0, Hashtable arg1, PropertyInfo info) {
		// TODO Auto-generated method stub
		
		 switch(arg0)
	        {
	        case 0:
	            info.type = PropertyInfo.STRING_CLASS;
	            info.name = "User_Name";
	            break;
	        case 1:
	            info.type = timein.getClass();
	            info.name = "time_in";
	            break;
	        case 2:
	            info.type = timeou.getClass();
	            
	            info.name = "time_ou";
	            break;
	        default:break;
	        }
		
	}

	@Override
	public void setProperty(int arg0, Object value) {
		// TODO Auto-generated method stub
		
		switch(arg0)
        {
        case 0:
           username = value.toString();
            break;
        case 1:
        	
            timein = (Date)value;
            break;
        case 2:
            timeou = (Date)value;
            break;
        default:
            break;
        }
		
	}
	
}
