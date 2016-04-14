# WCF-SOAP
A project to learn and evaluate creation and use of SOAP webservices by applications on different platforms.

This project includes a SOAP service containing database functions which are used by the client web, windows, android and Windows Phone 7 applications. The client application is a timeclock application used to log user sign-in and sign-out timings in a database.


## File Descriptions
 - CombinedAPP contains:
    1) InsertIntoUserWCF, the SOAP service
    2) timeclock, the client web application
    3) timeclockWin, the client windows application

- TimeClockWP7 is the client windows phone 7 application
- timeClockAndroid is the client android application
- scriptTimeClock is the sql script for the databse used in the project

## Features
- Database manipulations(read/write) through SOAP Service
- All 3 client applications read/write to the same database
- Application checks whether user is signed-in when sign-out is initiated 

## Software versions
- Visiual Studio 2008
- SQL Server 2008 R2
- Visual Studio 2010 Express for Windows Phone
- android:minSdkVersion="8", android:targetSdkVersion="15"
 

## More info
My [Stackoverflow](http://stackoverflow.com/questions/12846149/passing-objects-to-wcf-soap-service-from-android-using-ksoap2-it-sends-and-rece/12862257#12862257) of the issue I had with SOAP and android and how I solved it.

## Technology used
VB, .NET, SQL, WCF-SOAP, Java
