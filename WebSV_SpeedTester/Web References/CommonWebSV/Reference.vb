﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.34209
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'このソース コードは Microsoft.VSDesigner、バージョン 4.0.30319.34209 によって自動生成されました。
'
Namespace CommonWebSV
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="CommonWebSVSoap", [Namespace]:="http://tempuri.org/"),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(Object()))>  _
    Partial Public Class CommonWebSV
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private HelloWorldOperationCompleted As System.Threading.SendOrPostCallback
        
        Private gfncGetDBCountOperationCompleted As System.Threading.SendOrPostCallback
        
        Private gfncGetDBValueOperationCompleted As System.Threading.SendOrPostCallback
        
        Private gfncDBReadSQLOperationCompleted As System.Threading.SendOrPostCallback
        
        Private gfncDBReadSQL2LogOperationCompleted As System.Threading.SendOrPostCallback
        
        Private gfncDBExecuteSQLOperationCompleted As System.Threading.SendOrPostCallback
        
        Private gfncDBExecuteSQL_IMGOperationCompleted As System.Threading.SendOrPostCallback
        
        Private gfncGetDBNameOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WebSV_SpeedTester.My.MySettings.Default.WebSV_SpeedTester_CommonWebSV_CommonWebSV
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event HelloWorldCompleted As HelloWorldCompletedEventHandler
        
        '''<remarks/>
        Public Event gfncGetDBCountCompleted As gfncGetDBCountCompletedEventHandler
        
        '''<remarks/>
        Public Event gfncGetDBValueCompleted As gfncGetDBValueCompletedEventHandler
        
        '''<remarks/>
        Public Event gfncDBReadSQLCompleted As gfncDBReadSQLCompletedEventHandler
        
        '''<remarks/>
        Public Event gfncDBReadSQL2LogCompleted As gfncDBReadSQL2LogCompletedEventHandler
        
        '''<remarks/>
        Public Event gfncDBExecuteSQLCompleted As gfncDBExecuteSQLCompletedEventHandler
        
        '''<remarks/>
        Public Event gfncDBExecuteSQL_IMGCompleted As gfncDBExecuteSQL_IMGCompletedEventHandler
        
        '''<remarks/>
        Public Event gfncGetDBNameCompleted As gfncGetDBNameCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function HelloWorld() As String
            Dim results() As Object = Me.Invoke("HelloWorld", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub HelloWorldAsync()
            Me.HelloWorldAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub HelloWorldAsync(ByVal userState As Object)
            If (Me.HelloWorldOperationCompleted Is Nothing) Then
                Me.HelloWorldOperationCompleted = AddressOf Me.OnHelloWorldOperationCompleted
            End If
            Me.InvokeAsync("HelloWorld", New Object(-1) {}, Me.HelloWorldOperationCompleted, userState)
        End Sub
        
        Private Sub OnHelloWorldOperationCompleted(ByVal arg As Object)
            If (Not (Me.HelloWorldCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent HelloWorldCompleted(Me, New HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/gfncGetDBCount", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function gfncGetDBCount(ByVal parrKey() As Object, ByRef pstrExpMsg As String) As Integer
            Dim results() As Object = Me.Invoke("gfncGetDBCount", New Object() {parrKey, pstrExpMsg})
            pstrExpMsg = CType(results(1),String)
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub gfncGetDBCountAsync(ByVal parrKey() As Object, ByVal pstrExpMsg As String)
            Me.gfncGetDBCountAsync(parrKey, pstrExpMsg, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub gfncGetDBCountAsync(ByVal parrKey() As Object, ByVal pstrExpMsg As String, ByVal userState As Object)
            If (Me.gfncGetDBCountOperationCompleted Is Nothing) Then
                Me.gfncGetDBCountOperationCompleted = AddressOf Me.OngfncGetDBCountOperationCompleted
            End If
            Me.InvokeAsync("gfncGetDBCount", New Object() {parrKey, pstrExpMsg}, Me.gfncGetDBCountOperationCompleted, userState)
        End Sub
        
        Private Sub OngfncGetDBCountOperationCompleted(ByVal arg As Object)
            If (Not (Me.gfncGetDBCountCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent gfncGetDBCountCompleted(Me, New gfncGetDBCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/gfncGetDBValue", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function gfncGetDBValue(ByVal pstrSql As String, ByRef pstrExpMsg As String) As String
            Dim results() As Object = Me.Invoke("gfncGetDBValue", New Object() {pstrSql, pstrExpMsg})
            pstrExpMsg = CType(results(1),String)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub gfncGetDBValueAsync(ByVal pstrSql As String, ByVal pstrExpMsg As String)
            Me.gfncGetDBValueAsync(pstrSql, pstrExpMsg, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub gfncGetDBValueAsync(ByVal pstrSql As String, ByVal pstrExpMsg As String, ByVal userState As Object)
            If (Me.gfncGetDBValueOperationCompleted Is Nothing) Then
                Me.gfncGetDBValueOperationCompleted = AddressOf Me.OngfncGetDBValueOperationCompleted
            End If
            Me.InvokeAsync("gfncGetDBValue", New Object() {pstrSql, pstrExpMsg}, Me.gfncGetDBValueOperationCompleted, userState)
        End Sub
        
        Private Sub OngfncGetDBValueOperationCompleted(ByVal arg As Object)
            If (Not (Me.gfncGetDBValueCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent gfncGetDBValueCompleted(Me, New gfncGetDBValueCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/gfncDBReadSQL", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function gfncDBReadSQL(ByVal pstrSQL As String, ByRef pds As System.Data.DataSet, ByRef pstrExpMsg As String) As Boolean
            Dim results() As Object = Me.Invoke("gfncDBReadSQL", New Object() {pstrSQL, pds, pstrExpMsg})
            pds = CType(results(1),System.Data.DataSet)
            pstrExpMsg = CType(results(2),String)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub gfncDBReadSQLAsync(ByVal pstrSQL As String, ByVal pds As System.Data.DataSet, ByVal pstrExpMsg As String)
            Me.gfncDBReadSQLAsync(pstrSQL, pds, pstrExpMsg, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub gfncDBReadSQLAsync(ByVal pstrSQL As String, ByVal pds As System.Data.DataSet, ByVal pstrExpMsg As String, ByVal userState As Object)
            If (Me.gfncDBReadSQLOperationCompleted Is Nothing) Then
                Me.gfncDBReadSQLOperationCompleted = AddressOf Me.OngfncDBReadSQLOperationCompleted
            End If
            Me.InvokeAsync("gfncDBReadSQL", New Object() {pstrSQL, pds, pstrExpMsg}, Me.gfncDBReadSQLOperationCompleted, userState)
        End Sub
        
        Private Sub OngfncDBReadSQLOperationCompleted(ByVal arg As Object)
            If (Not (Me.gfncDBReadSQLCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent gfncDBReadSQLCompleted(Me, New gfncDBReadSQLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/gfncDBReadSQL2Log", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function gfncDBReadSQL2Log(ByVal pstrSQL As String, ByRef pds As System.Data.DataSet, ByRef pstrExpMsg As String) As Boolean
            Dim results() As Object = Me.Invoke("gfncDBReadSQL2Log", New Object() {pstrSQL, pds, pstrExpMsg})
            pds = CType(results(1),System.Data.DataSet)
            pstrExpMsg = CType(results(2),String)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub gfncDBReadSQL2LogAsync(ByVal pstrSQL As String, ByVal pds As System.Data.DataSet, ByVal pstrExpMsg As String)
            Me.gfncDBReadSQL2LogAsync(pstrSQL, pds, pstrExpMsg, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub gfncDBReadSQL2LogAsync(ByVal pstrSQL As String, ByVal pds As System.Data.DataSet, ByVal pstrExpMsg As String, ByVal userState As Object)
            If (Me.gfncDBReadSQL2LogOperationCompleted Is Nothing) Then
                Me.gfncDBReadSQL2LogOperationCompleted = AddressOf Me.OngfncDBReadSQL2LogOperationCompleted
            End If
            Me.InvokeAsync("gfncDBReadSQL2Log", New Object() {pstrSQL, pds, pstrExpMsg}, Me.gfncDBReadSQL2LogOperationCompleted, userState)
        End Sub
        
        Private Sub OngfncDBReadSQL2LogOperationCompleted(ByVal arg As Object)
            If (Not (Me.gfncDBReadSQL2LogCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent gfncDBReadSQL2LogCompleted(Me, New gfncDBReadSQL2LogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/gfncDBExecuteSQL", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function gfncDBExecuteSQL(ByVal pstrSQL As String, ByVal ptbleBasic As System.Data.DataTable, ByVal ptbleForm As System.Data.DataTable, ByRef pstrExpMsg As String) As Boolean
            Dim results() As Object = Me.Invoke("gfncDBExecuteSQL", New Object() {pstrSQL, ptbleBasic, ptbleForm, pstrExpMsg})
            pstrExpMsg = CType(results(1),String)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub gfncDBExecuteSQLAsync(ByVal pstrSQL As String, ByVal ptbleBasic As System.Data.DataTable, ByVal ptbleForm As System.Data.DataTable, ByVal pstrExpMsg As String)
            Me.gfncDBExecuteSQLAsync(pstrSQL, ptbleBasic, ptbleForm, pstrExpMsg, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub gfncDBExecuteSQLAsync(ByVal pstrSQL As String, ByVal ptbleBasic As System.Data.DataTable, ByVal ptbleForm As System.Data.DataTable, ByVal pstrExpMsg As String, ByVal userState As Object)
            If (Me.gfncDBExecuteSQLOperationCompleted Is Nothing) Then
                Me.gfncDBExecuteSQLOperationCompleted = AddressOf Me.OngfncDBExecuteSQLOperationCompleted
            End If
            Me.InvokeAsync("gfncDBExecuteSQL", New Object() {pstrSQL, ptbleBasic, ptbleForm, pstrExpMsg}, Me.gfncDBExecuteSQLOperationCompleted, userState)
        End Sub
        
        Private Sub OngfncDBExecuteSQLOperationCompleted(ByVal arg As Object)
            If (Not (Me.gfncDBExecuteSQLCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent gfncDBExecuteSQLCompleted(Me, New gfncDBExecuteSQLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/gfncDBExecuteSQL_IMG", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function gfncDBExecuteSQL_IMG(ByVal pstrSQL As String, ByVal ptableParam As System.Data.DataTable, ByVal ptbleBasic As System.Data.DataTable, ByVal ptbleForm As System.Data.DataTable, ByRef pstrExpMsg As String) As Boolean
            Dim results() As Object = Me.Invoke("gfncDBExecuteSQL_IMG", New Object() {pstrSQL, ptableParam, ptbleBasic, ptbleForm, pstrExpMsg})
            pstrExpMsg = CType(results(1),String)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub gfncDBExecuteSQL_IMGAsync(ByVal pstrSQL As String, ByVal ptableParam As System.Data.DataTable, ByVal ptbleBasic As System.Data.DataTable, ByVal ptbleForm As System.Data.DataTable, ByVal pstrExpMsg As String)
            Me.gfncDBExecuteSQL_IMGAsync(pstrSQL, ptableParam, ptbleBasic, ptbleForm, pstrExpMsg, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub gfncDBExecuteSQL_IMGAsync(ByVal pstrSQL As String, ByVal ptableParam As System.Data.DataTable, ByVal ptbleBasic As System.Data.DataTable, ByVal ptbleForm As System.Data.DataTable, ByVal pstrExpMsg As String, ByVal userState As Object)
            If (Me.gfncDBExecuteSQL_IMGOperationCompleted Is Nothing) Then
                Me.gfncDBExecuteSQL_IMGOperationCompleted = AddressOf Me.OngfncDBExecuteSQL_IMGOperationCompleted
            End If
            Me.InvokeAsync("gfncDBExecuteSQL_IMG", New Object() {pstrSQL, ptableParam, ptbleBasic, ptbleForm, pstrExpMsg}, Me.gfncDBExecuteSQL_IMGOperationCompleted, userState)
        End Sub
        
        Private Sub OngfncDBExecuteSQL_IMGOperationCompleted(ByVal arg As Object)
            If (Not (Me.gfncDBExecuteSQL_IMGCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent gfncDBExecuteSQL_IMGCompleted(Me, New gfncDBExecuteSQL_IMGCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/gfncGetDBName", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function gfncGetDBName(ByRef pstrExpMsg As String) As String
            Dim results() As Object = Me.Invoke("gfncGetDBName", New Object() {pstrExpMsg})
            pstrExpMsg = CType(results(1),String)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub gfncGetDBNameAsync(ByVal pstrExpMsg As String)
            Me.gfncGetDBNameAsync(pstrExpMsg, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub gfncGetDBNameAsync(ByVal pstrExpMsg As String, ByVal userState As Object)
            If (Me.gfncGetDBNameOperationCompleted Is Nothing) Then
                Me.gfncGetDBNameOperationCompleted = AddressOf Me.OngfncGetDBNameOperationCompleted
            End If
            Me.InvokeAsync("gfncGetDBName", New Object() {pstrExpMsg}, Me.gfncGetDBNameOperationCompleted, userState)
        End Sub
        
        Private Sub OngfncGetDBNameOperationCompleted(ByVal arg As Object)
            If (Not (Me.gfncGetDBNameCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent gfncGetDBNameCompleted(Me, New gfncGetDBNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub HelloWorldCompletedEventHandler(ByVal sender As Object, ByVal e As HelloWorldCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class HelloWorldCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub gfncGetDBCountCompletedEventHandler(ByVal sender As Object, ByVal e As gfncGetDBCountCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class gfncGetDBCountCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pstrExpMsg() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub gfncGetDBValueCompletedEventHandler(ByVal sender As Object, ByVal e As gfncGetDBValueCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class gfncGetDBValueCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pstrExpMsg() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub gfncDBReadSQLCompletedEventHandler(ByVal sender As Object, ByVal e As gfncDBReadSQLCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class gfncDBReadSQLCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pds() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),System.Data.DataSet)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pstrExpMsg() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(2),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub gfncDBReadSQL2LogCompletedEventHandler(ByVal sender As Object, ByVal e As gfncDBReadSQL2LogCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class gfncDBReadSQL2LogCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pds() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),System.Data.DataSet)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pstrExpMsg() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(2),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub gfncDBExecuteSQLCompletedEventHandler(ByVal sender As Object, ByVal e As gfncDBExecuteSQLCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class gfncDBExecuteSQLCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pstrExpMsg() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub gfncDBExecuteSQL_IMGCompletedEventHandler(ByVal sender As Object, ByVal e As gfncDBExecuteSQL_IMGCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class gfncDBExecuteSQL_IMGCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pstrExpMsg() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub gfncGetDBNameCompletedEventHandler(ByVal sender As Object, ByVal e As gfncGetDBNameCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class gfncGetDBNameCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pstrExpMsg() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
End Namespace
