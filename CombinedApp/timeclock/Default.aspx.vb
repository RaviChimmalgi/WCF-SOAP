
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports timeclock.ServiceReference1

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim objService As New ServiceReference1.Service1Client()
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
       
        Dim objService As New ServiceReference1.Service1Client()
        Dim userinfo As New ServiceReference1.UserDetails()
        userinfo.User_Name = DropDownList1.SelectedItem.Text
        userinfo.time_now = DateTime.Now


        Dim result As String = objService.InsertUserDetails(userinfo)
        MsgBox(result)

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        'Dim codeb As New CodeFile1()
        'codeb.signout(DropDownList1.SelectedItem.Text)

        Dim objService As New ServiceReference1.Service1Client()
        Dim userinfo As New ServiceReference1.UserDetails()
        userinfo.User_Name = DropDownList1.SelectedItem.Text
        userinfo.time_now = DateTime.Now
       
        Dim result As String = objService.UpdateUserDetails(userinfo)
        MsgBox(result)
    End Sub

    'Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click

    '    Dim objService As New ServiceReference1.Service1Client()
    '    Dim datatable As New DataTable()
    '    datatable.TableName = "users"
    '    datatable = objService.getLogTable()
    '    GridView1.DataSource = datatable
    '    GridView1.DataBind()

    '    If (Button4.Text = "Clock") Then

    '        GridView1.Visible = False
    '        div1.Visible = True
    '        Button4.Text = "Clock Log"

    '    Else

    '        GridView1.Visible = True
    '        GridView1.DataBind()
    '        div1.Visible = False
    '        Button4.Text = "Clock"
    '    End If

    'End Sub


End Class