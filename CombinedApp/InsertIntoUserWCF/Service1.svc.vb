' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.

Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
'Imports System.ServiceModel.Web
Imports System.Text
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

<ServiceBehavior(Namespace:="http://wcfservicetest.org/Service1")> _
Public Class Service1
    Implements IService1

    'Private con As New SqlConnection("Data Source=TE-LAPTOP-001\SQL2008R2;Initial Catalog=timeClock;Integrated Security=True")
    Dim str As String = System.Configuration.ConfigurationSettings.AppSettings("mycon")
    Private con As New SqlConnection(str)
    Public Sub New()
    End Sub
    Public Function UpdateUserDetails(ByVal userInfo As UserDetails) As String Implements IService1.UpdateUserDetails
        Dim message As String = String.Empty

        Dim numcount As Integer = 0
        'MsgBox(userInfo.User_Name)
        numcount = getusercount(userInfo.User_Name)
        If (numcount = 1) Then


            Try
                con.Open()

                Dim cmd As New SqlCommand("spUpdateLog", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@username", userInfo.User_Name)
                cmd.Parameters.AddWithValue("@timeou", userInfo.time_now)

                cmd.ExecuteNonQuery()

            Catch ex As Exception
                'MsgBox("ERROR")
            Finally
                con.Close()
            End Try
            'MsgBox("You have Signed Out at: " + userInfo.time_now)
            message = "You have Signed Out at: " + userInfo.time_now
        ElseIf (numcount = 0) Then
            'MsgBox("Error: You need to SignIn before you can SignOut")
            message = "Error: You need to SignIn before you can SignOut"
        End If

        Return message
    End Function
    Public Function InsertUserDetails(ByVal userInfo As UserDetails) As String Implements IService1.InsertUserDetails
        'MsgBox(userInfo.User_Name + " " + userInfo.time_now)
        Dim strMessage As String = String.Empty
        Dim errorMessage As String = String.Empty
        Dim numcount As Integer = 0

        numcount = getusercount(userInfo.User_Name)
        If (numcount = 0) Then

            Try


                con.Open()
                Dim cmd As New SqlCommand("spInsertLog", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@username", userInfo.User_Name)
                cmd.Parameters.AddWithValue("@timein", userInfo.time_now)


                cmd.ExecuteNonQuery()


            Catch ex As Exception
                errorMessage = ex.ToString
            Finally
                con.Close()
            End Try
            'MsgBox("You have Signed In at: " + userInfo.time_in)
            strMessage = "You have Signed In at: " + userInfo.time_now
        ElseIf (numcount = 1) Then
            'MsgBox("Error: You need to SignOut before you can SignIn")
            strMessage = "Error: You need to SignOut before you can SignIn"
        End If


        Return errorMessage + strMessage
    End Function

    'adds two integer object members
    Public Function ksoapAdd(ByVal num1 As testadd) As Integer Implements IService1.ksoapAdd
        'MsgBox(num1.number_1 + "+" + num1.number_2 + "=" + (num1.number_1 + num1.number_2))
        'MsgBox(num1.number_1)
        Return num1.number_1 + num1.number_2
    End Function

    'adds two integers
    Public Function addParam(ByVal num1 As Integer, ByVal num2 As Integer) As Integer Implements IService1.addParam
        'MsgBox(num1 + num2)
        Return num1 + num2
    End Function


    Public Function getusercount(ByVal username As String) As Integer Implements IService1.getusercount
        Dim count As Int32 = 0
        Try
            con.Open()
            Dim cmd As New SqlCommand("spgetcount", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@username", username)
            count = Convert.ToInt32(cmd.ExecuteScalar())


        Catch ex As Exception
            'MsgBox("ERROR")
        Finally
            con.Close()
        End Try


        Return count
    End Function
End Class
