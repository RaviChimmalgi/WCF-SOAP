

Imports System
Imports System.ServiceModel
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports TimeClockWP7.ServiceReference1

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Dim proxy As ServiceReference1.Service1Client
    Dim num2 As Integer = 1
    ' Constructor
    Public Sub New()
        InitializeComponent()
        AddHandler Loaded, AddressOf MainPage_Loaded
    End Sub
    Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        proxy = New ServiceReference1.Service1Client()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        proxy = New ServiceReference1.Service1Client()
        AddHandler proxy.InsertUserDetailsCompleted, AddressOf proxy_InsertUserDetailsCompleted

        'Handles Button1.Click
        Dim user1 As New ServiceReference1.UserDetails
        Dim mesg As String = String.Empty
        Dim temp As ListBoxItem = ListBox1.ItemContainerGenerator.ContainerFromItem(ListBox1.SelectedItem)

        user1.User_Name = temp.Content
        user1.time_now = DateTime.Now
        MessageBox.Show(DateTime.Now + " " + user1.time_now)
        proxy.InsertUserDetailsAsync(user1)

        'MessageBox.Show("You have signed in at: " + DateTime.Now)
    End Sub



    Private Sub proxy_InsertUserDetailsCompleted(ByVal sender As Object, ByVal e As InsertUserDetailsCompletedEventArgs)
        'If e.Result IsNot Nothing Then
        MessageBox.Show(e.Result)
        ' End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button2.Click

        proxy = New ServiceReference1.Service1Client()
        AddHandler proxy.UpdateUserDetailsCompleted, AddressOf proxy_UpdateUserDetailsCompleted

        Dim user1 As New ServiceReference1.UserDetails

        Dim temp As ListBoxItem = ListBox1.ItemContainerGenerator.ContainerFromItem(ListBox1.SelectedItem)

        user1.User_Name = temp.Content
        user1.time_now = DateTime.Now


        proxy.UpdateUserDetailsAsync(user1)
    End Sub

    Private Sub proxy_UpdateUserDetailsCompleted(ByVal sender As Object, ByVal e As UpdateUserDetailsCompletedEventArgs)

        MessageBox.Show(e.Result)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button3.Click
        NavigationService.Navigate(New Uri("/Page1.xaml", UriKind.Relative))
    End Sub
End Class
