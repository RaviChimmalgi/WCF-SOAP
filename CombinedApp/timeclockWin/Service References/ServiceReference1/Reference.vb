﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4234
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace ServiceReference1
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="UserDetails", [Namespace]:="http://wcfservicetest.org/Service1"),  _
     System.SerializableAttribute()>  _
    Partial Public Class UserDetails
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private User_NameField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private time_nowField As Date
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property User_Name() As String
            Get
                Return Me.User_NameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.User_NameField, value) <> true) Then
                    Me.User_NameField = value
                    Me.RaisePropertyChanged("User_Name")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property time_now() As Date
            Get
                Return Me.time_nowField
            End Get
            Set
                If (Me.time_nowField.Equals(value) <> true) Then
                    Me.time_nowField = value
                    Me.RaisePropertyChanged("time_now")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="testadd", [Namespace]:="http://wcfservicetest.org/Service1"),  _
     System.SerializableAttribute()>  _
    Partial Public Class testadd
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private number_1Field As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private number_2Field As Integer
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property number_1() As Integer
            Get
                Return Me.number_1Field
            End Get
            Set
                If (Me.number_1Field.Equals(value) <> true) Then
                    Me.number_1Field = value
                    Me.RaisePropertyChanged("number_1")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property number_2() As Integer
            Get
                Return Me.number_2Field
            End Get
            Set
                If (Me.number_2Field.Equals(value) <> true) Then
                    Me.number_2Field = value
                    Me.RaisePropertyChanged("number_2")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://wcfservicetest.org/Service1", ConfigurationName:="ServiceReference1.IService1")>  _
    Public Interface IService1
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://wcfservicetest.org/Service1/IService1/InsertUserDetails", ReplyAction:="http://wcfservicetest.org/Service1/IService1/InsertUserDetailsResponse")>  _
        Function InsertUserDetails(ByVal userInfo As ServiceReference1.UserDetails) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://wcfservicetest.org/Service1/IService1/UpdateUserDetails", ReplyAction:="http://wcfservicetest.org/Service1/IService1/UpdateUserDetailsResponse")>  _
        Function UpdateUserDetails(ByVal userInfo As ServiceReference1.UserDetails) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://wcfservicetest.org/Service1/IService1/getusercount", ReplyAction:="http://wcfservicetest.org/Service1/IService1/getusercountResponse")>  _
        Function getusercount(ByVal username As String) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://wcfservicetest.org/Service1/IService1/ksoapAdd", ReplyAction:="http://wcfservicetest.org/Service1/IService1/ksoapAddResponse")>  _
        Function ksoapAdd(ByVal num1 As ServiceReference1.testadd) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://wcfservicetest.org/Service1/IService1/addParam", ReplyAction:="http://wcfservicetest.org/Service1/IService1/addParamResponse")>  _
        Function addParam(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface IService1Channel
        Inherits ServiceReference1.IService1, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class Service1Client
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IService1)
        Implements ServiceReference1.IService1
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function InsertUserDetails(ByVal userInfo As ServiceReference1.UserDetails) As String Implements ServiceReference1.IService1.InsertUserDetails
            Return MyBase.Channel.InsertUserDetails(userInfo)
        End Function
        
        Public Function UpdateUserDetails(ByVal userInfo As ServiceReference1.UserDetails) As String Implements ServiceReference1.IService1.UpdateUserDetails
            Return MyBase.Channel.UpdateUserDetails(userInfo)
        End Function
        
        Public Function getusercount(ByVal username As String) As Integer Implements ServiceReference1.IService1.getusercount
            Return MyBase.Channel.getusercount(username)
        End Function
        
        Public Function ksoapAdd(ByVal num1 As ServiceReference1.testadd) As Integer Implements ServiceReference1.IService1.ksoapAdd
            Return MyBase.Channel.ksoapAdd(num1)
        End Function
        
        Public Function addParam(ByVal num1 As Integer, ByVal num2 As Integer) As Integer Implements ServiceReference1.IService1.addParam
            Return MyBase.Channel.addParam(num1, num2)
        End Function
    End Class
End Namespace
