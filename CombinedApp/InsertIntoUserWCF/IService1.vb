' NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
'Imports System.ServiceModel.Web
Imports System.Text


<ServiceContract(Namespace:="http://wcfservicetest.org/Service1")> _
Public Interface IService1

    <OperationContract()> _
    Function InsertUserDetails(ByVal userInfo As UserDetails) As String

    <OperationContract()> _
    Function UpdateUserDetails(ByVal userInfo As UserDetails) As String

    <OperationContract()> _
    Function getusercount(ByVal username As String) As Integer

    <OperationContract()> _
    Function ksoapAdd(ByVal num1 As testadd) As Integer

    <OperationContract()> _
    Function addParam(ByVal num1 As Integer, ByVal num2 As Integer) As Integer

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.
<DataContract(Namespace:="http://wcfservicetest.org/Service1")> _
Public Class UserDetails

    Private username As String = String.Empty
    Private timenow As DateTime


    <DataMember()> _
    Public Property User_Name() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    <DataMember()> _
    Public Property time_now() As DateTime
        Get
            Return timenow
        End Get
        Set(ByVal value As DateTime)
            timenow = value
        End Set
    End Property

   

End Class

<DataContract(Namespace:="http://wcfservicetest.org/Service1")> _
Public Class testadd
    Private number1 As Integer
    Private number2 As Integer

    <DataMember()> _
    Public Property number_1() As Integer
        Get
            Return number1
        End Get
        Set(ByVal value As Integer)
            number1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property number_2() As Integer
        Get
            Return number2
        End Get
        Set(ByVal value As Integer)
            number2 = value
        End Set
    End Property

End Class






