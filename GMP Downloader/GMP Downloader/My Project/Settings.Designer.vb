﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Bu kod araç tarafından oluşturuldu.
'     Çalışma Zamanı Sürümü:4.0.30319.42000
'
'     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
'     kod yeniden oluşturulursa kaybolur.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Otomatik Kaydetme İşlevi"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
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
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property textSave() As String
            Get
                Return CType(Me("textSave"),String)
            End Get
            Set
                Me("textSave") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property textAdmin() As String
            Get
                Return CType(Me("textAdmin"),String)
            End Get
            Set
                Me("textAdmin") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Kullanıcı"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property pcUserName() As String
            Get
                Return CType(Me("pcUserName"),String)
            End Get
            Set
                Me("pcUserName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ımage() As String
            Get
                Return CType(Me("ımage"),String)
            End Get
            Set
                Me("ımage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ımage2() As String
            Get
                Return CType(Me("ımage2"),String)
            End Get
            Set
                Me("ımage2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property pcMail() As String
            Get
                Return CType(Me("pcMail"),String)
            End Get
            Set
                Me("pcMail") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsStartSwitch() As Boolean
            Get
                Return CType(Me("settingsStartSwitch"),Boolean)
            End Get
            Set
                Me("settingsStartSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsLowCpuSwitch() As Boolean
            Get
                Return CType(Me("settingsLowCpuSwitch"),Boolean)
            End Get
            Set
                Me("settingsLowCpuSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsUpdatePackSwitch() As Boolean
            Get
                Return CType(Me("settingsUpdatePackSwitch"),Boolean)
            End Get
            Set
                Me("settingsUpdatePackSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsAutoUpdateSwitch() As Boolean
            Get
                Return CType(Me("settingsAutoUpdateSwitch"),Boolean)
            End Get
            Set
                Me("settingsAutoUpdateSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsUpdateHealingSwitch() As Boolean
            Get
                Return CType(Me("settingsUpdateHealingSwitch"),Boolean)
            End Get
            Set
                Me("settingsUpdateHealingSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsTransitionSwitch() As Boolean
            Get
                Return CType(Me("settingsTransitionSwitch"),Boolean)
            End Get
            Set
                Me("settingsTransitionSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property settingsCpuComboBox() As String
            Get
                Return CType(Me("settingsCpuComboBox"),String)
            End Get
            Set
                Me("settingsCpuComboBox") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsGpuSwitch() As Boolean
            Get
                Return CType(Me("settingsGpuSwitch"),Boolean)
            End Get
            Set
                Me("settingsGpuSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsBetaSwtich() As Boolean
            Get
                Return CType(Me("settingsBetaSwtich"),Boolean)
            End Get
            Set
                Me("settingsBetaSwtich") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsUpdateSwitch() As Boolean
            Get
                Return CType(Me("settingsUpdateSwitch"),Boolean)
            End Get
            Set
                Me("settingsUpdateSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsSystemRecSwitch() As Boolean
            Get
                Return CType(Me("settingsSystemRecSwitch"),Boolean)
            End Get
            Set
                Me("settingsSystemRecSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsCrashReportSwitch() As Boolean
            Get
                Return CType(Me("settingsCrashReportSwitch"),Boolean)
            End Get
            Set
                Me("settingsCrashReportSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsWindowsCompatibility() As Boolean
            Get
                Return CType(Me("settingsWindowsCompatibility"),Boolean)
            End Get
            Set
                Me("settingsWindowsCompatibility") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property settingsWindowsGameMod() As Boolean
            Get
                Return CType(Me("settingsWindowsGameMod"),Boolean)
            End Get
            Set
                Me("settingsWindowsGameMod") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsMemoryClearSwitch() As Boolean
            Get
                Return CType(Me("settingsMemoryClearSwitch"),Boolean)
            End Get
            Set
                Me("settingsMemoryClearSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsNetworkOptimization() As Boolean
            Get
                Return CType(Me("settingsNetworkOptimization"),Boolean)
            End Get
            Set
                Me("settingsNetworkOptimization") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsNetworkHealing() As Boolean
            Get
                Return CType(Me("settingsNetworkHealing"),Boolean)
            End Get
            Set
                Me("settingsNetworkHealing") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsNetworkUnloading() As Boolean
            Get
                Return CType(Me("settingsNetworkUnloading"),Boolean)
            End Get
            Set
                Me("settingsNetworkUnloading") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property mainSettings() As Boolean
            Get
                Return CType(Me("mainSettings"),Boolean)
            End Get
            Set
                Me("mainSettings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property settingsAnimatedSwitch() As Boolean
            Get
                Return CType(Me("settingsAnimatedSwitch"),Boolean)
            End Get
            Set
                Me("settingsAnimatedSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property settingsTransitionAnimatedCheck() As Boolean
            Get
                Return CType(Me("settingsTransitionAnimatedCheck"),Boolean)
            End Get
            Set
                Me("settingsTransitionAnimatedCheck") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property settingsButtonAnimatedCheck() As Boolean
            Get
                Return CType(Me("settingsButtonAnimatedCheck"),Boolean)
            End Get
            Set
                Me("settingsButtonAnimatedCheck") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property settingsLoginAnimatedCheck() As Boolean
            Get
                Return CType(Me("settingsLoginAnimatedCheck"),Boolean)
            End Get
            Set
                Me("settingsLoginAnimatedCheck") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property settingsNotificationAnimatedCheck() As Boolean
            Get
                Return CType(Me("settingsNotificationAnimatedCheck"),Boolean)
            End Get
            Set
                Me("settingsNotificationAnimatedCheck") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsSteamGameCheck() As Boolean
            Get
                Return CType(Me("settingsSteamGameCheck"),Boolean)
            End Get
            Set
                Me("settingsSteamGameCheck") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsSteamProfilCheck() As Boolean
            Get
                Return CType(Me("settingsSteamProfilCheck"),Boolean)
            End Get
            Set
                Me("settingsSteamProfilCheck") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsSteamLibraryCheck() As Boolean
            Get
                Return CType(Me("settingsSteamLibraryCheck"),Boolean)
            End Get
            Set
                Me("settingsSteamLibraryCheck") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsSteamProfileConnctionSwitch() As Boolean
            Get
                Return CType(Me("settingsSteamProfileConnctionSwitch"),Boolean)
            End Get
            Set
                Me("settingsSteamProfileConnctionSwitch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingslanguageBox() As String
            Get
                Return CType(Me("settingslanguageBox"),String)
            End Get
            Set
                Me("settingslanguageBox") = value
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
        Friend ReadOnly Property Settings() As Global.GMP_Downloader.My.MySettings
            Get
                Return Global.GMP_Downloader.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace