Imports timeclockWin.ServiceReference1

Imports System.Data.SqlClient
Public Class Form1
    Dim datatable As New DataTable("users")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

      

        Dim objService As New ServiceReference1.Service1Client()
        Dim userinfo As New UserDetails()
        userinfo.User_Name = ListBox1.SelectedItem.ToString
        userinfo.time_now = DateTime.Now


        Dim result As String = objService.InsertUserDetails(userinfo)
        MsgBox(result)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Dim objService As New ServiceReference1.Service1Client()
        'datatable = objService.getLogTable()

        'DataGridView1.DataSource = datatable


        ListBox1.SelectedIndex = 0
      
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

       

        Dim objService As New ServiceReference1.Service1Client()
        Dim userinfo As New UserDetails()
        userinfo.User_Name = ListBox1.SelectedItem.ToString
        userinfo.time_now = DateTime.Now


        Dim result As String = objService.UpdateUserDetails(userinfo)
        MsgBox(result)
    End Sub


    'Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As TabControlEventArgs) _
    ' Handles TabControl1.Selected

    '    Dim objService As New ServiceReference1.Service1Client()
    '    datatable = objService.getLogTable()
    '    DataGridView1.DataSource = datatable

    'End Sub

    'Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        DataGridView1.DataSource = datatable

    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class
