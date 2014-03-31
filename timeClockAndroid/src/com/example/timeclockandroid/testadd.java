package com.example.timeclockandroid;

import java.util.Hashtable;

import org.ksoap2.serialization.KvmSerializable;
import org.ksoap2.serialization.PropertyInfo;

public class testadd implements KvmSerializable{
	int number1;
	int number2;
	
	testadd(){}
	testadd(int a, int b){ number1 = a; number2 = b;}
	
	
	@Override
	public Object getProperty(int arg0) {
		switch(arg0)
        {
        case 0:
            return number1;
        case 1:
            return number2;
        
        }
	
	return null;
	}

	@Override
	public int getPropertyCount() {
	
		return 2;
	}

	@Override
	public void getPropertyInfo(int arg0, Hashtable arg1, PropertyInfo arg2) {
		
		 switch(arg0)
	        {
	        case 0:
	            arg2.type = PropertyInfo.INTEGER_CLASS;
	            arg2.name = "number_1";
	            break;
	        case 1:
	        	arg2.type = PropertyInfo.INTEGER_CLASS;
	        	arg2.name = "number_2";
	        	break;
	       
	        default:break;
	        }
		
	}

	@Override
	public void setProperty(int arg0, Object value) {
		
		switch(arg0)
        {
        case 0:
           number1 = Integer.parseInt(value.toString());
            break;
        case 1:
            number2 = Integer.parseInt(value.toString());
            break;
       
        default:
            break;
        }
	}
}
