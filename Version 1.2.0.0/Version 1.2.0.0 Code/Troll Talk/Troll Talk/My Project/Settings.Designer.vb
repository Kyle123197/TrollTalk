﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolCapStandard() As Boolean
            Get
                Return CType(Me("boolCapStandard"),Boolean)
            End Get
            Set
                Me("boolCapStandard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolCapAll() As Boolean
            Get
                Return CType(Me("boolCapAll"),Boolean)
            End Get
            Set
                Me("boolCapAll") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolCapNone() As Boolean
            Get
                Return CType(Me("boolCapNone"),Boolean)
            End Get
            Set
                Me("boolCapNone") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolCapEvery() As Boolean
            Get
                Return CType(Me("boolCapEvery"),Boolean)
            End Get
            Set
                Me("boolCapEvery") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolCapInvert() As Boolean
            Get
                Return CType(Me("boolCapInvert"),Boolean)
            End Get
            Set
                Me("boolCapInvert") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolCapAlt() As Boolean
            Get
                Return CType(Me("boolCapAlt"),Boolean)
            End Get
            Set
                Me("boolCapAlt") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolPuncStandard() As Boolean
            Get
                Return CType(Me("boolPuncStandard"),Boolean)
            End Get
            Set
                Me("boolPuncStandard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolPuncExclaim() As Boolean
            Get
                Return CType(Me("boolPuncExclaim"),Boolean)
            End Get
            Set
                Me("boolPuncExclaim") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolPuncQuestion() As Boolean
            Get
                Return CType(Me("boolPuncQuestion"),Boolean)
            End Get
            Set
                Me("boolPuncQuestion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolPuncPeriod() As Boolean
            Get
                Return CType(Me("boolPuncPeriod"),Boolean)
            End Get
            Set
                Me("boolPuncPeriod") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property boolOtherReverse() As Boolean
            Get
                Return CType(Me("boolOtherReverse"),Boolean)
            End Get
            Set
                Me("boolOtherReverse") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property colorCustom() As Global.System.Drawing.Color
            Get
                Return CType(Me("colorCustom"),Global.System.Drawing.Color)
            End Get
            Set
                Me("colorCustom") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property fontCustom() As Global.System.Drawing.Font
            Get
                Return CType(Me("fontCustom"),Global.System.Drawing.Font)
            End Get
            Set
                Me("fontCustom") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strPrefix() As String
            Get
                Return CType(Me("strPrefix"),String)
            End Get
            Set
                Me("strPrefix") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strSuffix() As String
            Get
                Return CType(Me("strSuffix"),String)
            End Get
            Set
                Me("strSuffix") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore1() As String
            Get
                Return CType(Me("strReplaceBefore1"),String)
            End Get
            Set
                Me("strReplaceBefore1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore2() As String
            Get
                Return CType(Me("strReplaceBefore2"),String)
            End Get
            Set
                Me("strReplaceBefore2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore3() As String
            Get
                Return CType(Me("strReplaceBefore3"),String)
            End Get
            Set
                Me("strReplaceBefore3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore4() As String
            Get
                Return CType(Me("strReplaceBefore4"),String)
            End Get
            Set
                Me("strReplaceBefore4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore5() As String
            Get
                Return CType(Me("strReplaceBefore5"),String)
            End Get
            Set
                Me("strReplaceBefore5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore6() As String
            Get
                Return CType(Me("strReplaceBefore6"),String)
            End Get
            Set
                Me("strReplaceBefore6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore7() As String
            Get
                Return CType(Me("strReplaceBefore7"),String)
            End Get
            Set
                Me("strReplaceBefore7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore8() As String
            Get
                Return CType(Me("strReplaceBefore8"),String)
            End Get
            Set
                Me("strReplaceBefore8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore9() As String
            Get
                Return CType(Me("strReplaceBefore9"),String)
            End Get
            Set
                Me("strReplaceBefore9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore10() As String
            Get
                Return CType(Me("strReplaceBefore10"),String)
            End Get
            Set
                Me("strReplaceBefore10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore11() As String
            Get
                Return CType(Me("strReplaceBefore11"),String)
            End Get
            Set
                Me("strReplaceBefore11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceBefore12() As String
            Get
                Return CType(Me("strReplaceBefore12"),String)
            End Get
            Set
                Me("strReplaceBefore12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter1() As String
            Get
                Return CType(Me("strReplaceAfter1"),String)
            End Get
            Set
                Me("strReplaceAfter1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter2() As String
            Get
                Return CType(Me("strReplaceAfter2"),String)
            End Get
            Set
                Me("strReplaceAfter2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter3() As String
            Get
                Return CType(Me("strReplaceAfter3"),String)
            End Get
            Set
                Me("strReplaceAfter3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter4() As String
            Get
                Return CType(Me("strReplaceAfter4"),String)
            End Get
            Set
                Me("strReplaceAfter4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter5() As String
            Get
                Return CType(Me("strReplaceAfter5"),String)
            End Get
            Set
                Me("strReplaceAfter5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter6() As String
            Get
                Return CType(Me("strReplaceAfter6"),String)
            End Get
            Set
                Me("strReplaceAfter6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter7() As String
            Get
                Return CType(Me("strReplaceAfter7"),String)
            End Get
            Set
                Me("strReplaceAfter7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter8() As String
            Get
                Return CType(Me("strReplaceAfter8"),String)
            End Get
            Set
                Me("strReplaceAfter8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter9() As String
            Get
                Return CType(Me("strReplaceAfter9"),String)
            End Get
            Set
                Me("strReplaceAfter9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter10() As String
            Get
                Return CType(Me("strReplaceAfter10"),String)
            End Get
            Set
                Me("strReplaceAfter10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter11() As String
            Get
                Return CType(Me("strReplaceAfter11"),String)
            End Get
            Set
                Me("strReplaceAfter11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strReplaceAfter12() As String
            Get
                Return CType(Me("strReplaceAfter12"),String)
            End Get
            Set
                Me("strReplaceAfter12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property strCustomName() As String
            Get
                Return CType(Me("strCustomName"),String)
            End Get
            Set
                Me("strCustomName") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WindowsApplication1.My.MySettings
            Get
                Return Global.WindowsApplication1.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
