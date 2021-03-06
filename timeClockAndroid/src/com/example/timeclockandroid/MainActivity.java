package com.example.timeclockandroid;

import java.util.Date;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.RadioButton;
import android.widget.TextView;


public class MainActivity extends Activity {
	private static final String SOAP_ACTION1 = "http://wcfservicetest.org/Service1/IService1/InsertUserDetails";
	private static final String METHOD_NAME1 = "InsertUserDetails";

	private static final String SOAP_ACTION2 = "http://wcfservicetest.org/Service1/IService1/UpdateUserDetails";
	private static final String METHOD_NAME2 = "UpdateUserDetails";

	private static final String SOAP_ACTION3 = "http://wcfservicetest.org/Service1/IService1/getusercount";
	private static final String METHOD_NAME3 = "getusercount";

	private static final String SOAP_ACTION4 = "http://wcfservicetest.org/Service1/IService1/ksoapAdd";
	private static final String METHOD_NAME4 = "ksoapAdd";
	
	private static final String SOAP_ACTION5 = "http://wcfservicetest.org/Service1/IService1/addParam";
	private static final String METHOD_NAME5 = "addParam";

	//private static final String NAMESPACE = "http://tempuri.org/";
	private static final String URL = "http://10.0.2.2:52697/Service1.svc?wsdl";
		
	private static final String NEW_NAMESPACE = "http://wcfservicetest.org/Service1";
	private String username = "default";

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);

	}
	
	
	
	public static final String logtag = "logtag";
	
	public void onClickSignin(View view) {
		 RadioButton user1 = (RadioButton) findViewById(R.id.radioButton1);
		 RadioButton user2 = (RadioButton) findViewById(R.id.radioButton2);
		 RadioButton user3 = (RadioButton) findViewById(R.id.radioButton3);
		if (user1.isChecked())
			username = "User1";
		if (user2.isChecked())
			username = "User2";
		if (user3.isChecked())
			username = "User3";
		
		
		TextView view1;
		view1 = (TextView) findViewById(R.id.textView3);
		view1.setText(username);
		Thread networkThread = new Thread() {
			@Override
			public void run() {
				try {
					
					SoapObject Request = new SoapObject(NEW_NAMESPACE, METHOD_NAME1);
					
					Date date = new Date();
					//String strdate = date.toString();
					//System.out.println(strdate);
					
					UserDetails user = new UserDetails(username, date,date);
					//System.out.println(user.timein);
					
							
					/*
					testadd numX = new testadd(25,25);
					PropertyInfo prop = new PropertyInfo();
					prop.setNamespace(NEW_NAMESPACE);
					prop.setName("num1");
				    prop.setType(numX.getClass());
				    prop.setValue(numX);
					Request.addProperty(prop);
					*/
					
					PropertyInfo usr = new PropertyInfo();
					usr.setNamespace(NEW_NAMESPACE);
					usr.setName("userInfo");
					usr.setType(user.getClass());
					usr.setValue(user);
					Request.addProperty(usr);
					
					
					//System.out.println("iso: "+IsoDate.dateToString(date, IsoDate.DATE_TIME));
				
				    SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
					envelope.dotNet = true;
					envelope.setOutputSoapObject(Request);
					
					MarshalDate md = new MarshalDate();
					
					md.register(envelope);
					
					envelope.implicitTypes = true;
					
					HttpTransportSE androidHttpTransport = new HttpTransportSE(URL);
					androidHttpTransport.debug=true;
					androidHttpTransport.call(SOAP_ACTION1, envelope);
					
					
					Log.d(logtag + " request dump", androidHttpTransport.requestDump);
				    Log.d(logtag + " response dump", androidHttpTransport.responseDump);
					
					final SoapPrimitive response = (SoapPrimitive)envelope.getResponse();
					//final int num = Integer.parseInt(response.toString());
					
					
					runOnUiThread(new Runnable() {
						public void run() {
			
							TextView result1;
							result1 = (TextView) findViewById(R.id.textView2);
							result1.setText(""+response.toString());
							}
					});
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		};
		networkThread.start();

	}

	
	public void onClickSignOut(View view)
	{
		 RadioButton user1 = (RadioButton) findViewById(R.id.radioButton1);
		 RadioButton user2 = (RadioButton) findViewById(R.id.radioButton2);
		 RadioButton user3 = (RadioButton) findViewById(R.id.radioButton3);
		if (user1.isChecked())
			username = "User1";
		if (user2.isChecked())
			username = "User2";
		if (user3.isChecked())
			username = "User3";
		
		
		TextView view1;
		view1 = (TextView) findViewById(R.id.textView3);
		view1.setText(username);
		Thread networkThread = new Thread() {
			@Override
			public void run() {
				try {
					//
					
					SoapObject Request = new SoapObject(NEW_NAMESPACE, METHOD_NAME2);
					
					Date date = new Date();
					String strdate = date.toString();
					System.out.println(strdate);
					
					UserDetails user = new UserDetails(username, date,date);
					System.out.println(user.timein);
					
							
					/*
					testadd numX = new testadd(25,25);
					PropertyInfo prop = new PropertyInfo();
					prop.setNamespace(NEW_NAMESPACE);
					prop.setName("num1");
				    prop.setType(numX.getClass());
				    prop.setValue(numX);
					Request.addProperty(prop);
					*/
					
					PropertyInfo usr = new PropertyInfo();
					usr.setNamespace(NEW_NAMESPACE);
					usr.setName("userInfo");
					usr.setType(user.getClass());
					usr.setValue(user);
					Request.addProperty(usr);
					
				
				    SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
					envelope.dotNet = true;
					envelope.setOutputSoapObject(Request);
					
					MarshalDate md = new MarshalDate();
					md.register(envelope);
					
					envelope.implicitTypes = true;
					
					HttpTransportSE androidHttpTransport = new HttpTransportSE(URL);
					androidHttpTransport.debug=true;
					androidHttpTransport.call(SOAP_ACTION2, envelope);
					
					
					Log.d(logtag + " request dump", androidHttpTransport.requestDump);
				    Log.d(logtag + " response dump", androidHttpTransport.responseDump);
					
					final SoapPrimitive response = (SoapPrimitive)envelope.getResponse();
					//final int num = Integer.parseInt(response.toString());
					
					
					runOnUiThread(new Runnable() {
						public void run() {
							
							TextView result1;
							result1 = (TextView) findViewById(R.id.textView2);
							result1.setText(""+response.toString());
							}
							
					});
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		};
		networkThread.start();

	}
	
	
}






