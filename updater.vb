Imports System.Net
Imports System.IO

Public Class updater
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Contains("-elder") = True Then
            elder()
        End If
        If My.Application.CommandLineArgs.Contains("-elderbeta") = True Then
            elderbeta()
        End If
        If My.Application.CommandLineArgs.Contains("-launcher") = True Then
            launcher()
        End If
        If My.Application.CommandLineArgs.Contains("-mhd") = True Then
            mhd()
        End If
        If My.Application.CommandLineArgs.Contains("-antiezo") = True Then
            antiezo()
        End If
        If My.Application.CommandLineArgs.Contains("-fdc") = True Then
            fdc()
        End If
        If My.Application.CommandLineArgs.Contains("-bf2") = True Then
            bf2()
        End If
        If My.Application.CommandLineArgs.Contains("-wur") = True Then
            wur()
        End If
        If My.Application.CommandLineArgs.Contains("-elder") = False And My.Application.CommandLineArgs.Contains("-elderbeta") = False And My.Application.CommandLineArgs.Contains("-launcher") = False And My.Application.CommandLineArgs.Contains("-mhd") = False And My.Application.CommandLineArgs.Contains("-antiezo") = False And My.Application.CommandLineArgs.Contains("-fdc") = False And My.Application.CommandLineArgs.Contains("-bf2") = False And My.Application.CommandLineArgs.Contains("-wur") = False Then
            MsgBox("No argument was found. / Nebyl zadán nebo rozpoznán žádný argument.", MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End If
    End Sub

    Public Sub launcher()
        Dim wc As WebClient = New WebClient()
        If Application.ExecutablePath.Contains("Program Files") Then
            wc.DownloadFile("https://dl.henryolik.ga/mini/launcher/updater.exe", "migrate.exe")
            Process.Start(Application.StartupPath & "/migrate.exe")
            Me.Close()
        End If
        Do Until FileInUse(Application.StartupPath & "/launcher.exe") = False
            Snooze(1)
        Loop
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        pb_load.Value = 1
        Try
            wc.DownloadFile("https://dl.henryolik.ga/mini/launcher/files/launcher.exe", Application.StartupPath & "\launcher.exe")
            pb_load.Value = 10
            wc.DownloadFile("https://dl.henryolik.ga/mini/launcher/files/mini.exe", Application.StartupPath & "\mini.exe")
            pb_load.Value = 20
            wc.DownloadFile("https://dl.henryolik.ga/mini/launcher/files/mini2.exe", Application.StartupPath & "\mini2.exe")
            pb_load.Value = 30
            wc.DownloadFile("https://dl.henryolik.ga/mini/launcher/files/icon.ico", Application.StartupPath & "\icon.ico")
            pb_load.Value = 35
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "/7z") Then
            System.IO.Directory.Delete(Application.StartupPath & "/7z", True)
            pb_load.Value = 40
        Else
            pb_load.Value = 40
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/7za.exe") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/7za.exe")
            pb_load.Value = 50
        Else
            pb_load.Value = 50
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/7za.dll") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/7za.dll")
            pb_load.Value = 60
        Else
            pb_load.Value = 60
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/7zxa.dll") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/7zxa.dll")
            pb_load.Value = 70
        Else
            pb_load.Value = 70
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/update.bat") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/update.bat")
            pb_load.Value = 80
        Else
            pb_load.Value = 80
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/mini.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/mini.zip")
            pb_load.Value = 90
        Else
            pb_load.Value = 90
        End If
        pb_load.Value = 100
        Process.Start(Application.StartupPath & "\launcher.exe")
        Me.Close()
    End Sub

    Public Sub elder()
        Dim wc As WebClient = New WebClient()
        If Application.ExecutablePath.Contains("Program Files") Then
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/updater.exe", Application.StartupPath & "/migrate.exe")
            Process.Start(Application.StartupPath & "/migrate.exe")
            Me.Close()
        End If
        Do Until FileInUse(Application.StartupPath & "/launcher.exe") = False
            Snooze(1)
        Loop
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        Try
            pb_load.Value = 1
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/files/launcher.exe", Application.StartupPath & "\launcher.exe")
            pb_load.Value = 20
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/files/mini.exe", Application.StartupPath & "\mini.exe")
            pb_load.Value = 40
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/files/mini2.exe", Application.StartupPath & "\mini2.exe")
            pb_load.Value = 60
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/files/icon.ico", Application.StartupPath & "\icon.ico")
            pb_load.Value = 80
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        pb_load.Value = 100
        Process.Start(Application.StartupPath & "\launcher.exe")
        Me.Close()
    End Sub

    Public Sub elderbeta()
        Dim wc As WebClient = New WebClient()
        If Application.ExecutablePath.Contains("Program Files") Then
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/updater.exe", Application.StartupPath & "/migrate.exe")
            Process.Start(Application.StartupPath & "/migrate.exe")
            Me.Close()
        End If
        Do Until FileInUse(Application.StartupPath & "/launcher.exe") = False
            Snooze(1)
        Loop
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        Try
            pb_load.Value = 1
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/beta/files/launcher.exe", Application.StartupPath & "\launcher.exe")
            pb_load.Value = 20
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/beta/files/mini.exe", Application.StartupPath & "\mini.exe")
            pb_load.Value = 40
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/beta/files/mini2.exe", Application.StartupPath & "\mini2.exe")
            pb_load.Value = 60
            wc.DownloadFile("http://nonssl.dl.henryolik.ga/mini/elder/beta/files/icon.ico", Application.StartupPath & "\icon.ico")
            pb_load.Value = 80
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        pb_load.Value = 100
        Process.Start(Application.StartupPath & "\launcher.exe")
        Me.Close()
    End Sub

    Public Sub mhd()
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            pb_load.Value = 1
            wc.DownloadFile("https://dl.henryolik.ga/mhd/mhd.exe", Application.StartupPath & "/mhd.exe")
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        pb_load.Value = 100
        Process.Start(Application.StartupPath & "/mhd.exe")
        Me.Close()
    End Sub

    Public Sub fdc()
        Dim exeloc As String
        Dim mystr As String = My.Application.CommandLineArgs.Item(1)
        Dim cut_at As String = "-e:"
        Dim x As Integer = InStr(mystr, cut_at)
        exeloc = mystr.Substring(x + cut_at.Length - 1)
        la_text.Text = "Update in progress..."
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            pb_load.Value = 1
            wc.DownloadFile("https://dl.henryolik.ga/fdc/fdc.exe", exeloc)
        Catch ex As Exception
            MsgBox("Update failed! Error: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        pb_load.Value = 100
        Process.Start(exeloc)
        Me.Close()
    End Sub

    Public Sub antiezo()
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            pb_load.Value = 1
            wc.DownloadFile("https://dl.henryolik.ga/antiezo/files/antiezo.exe", Application.StartupPath & "/antiezo.exe")
            pb_load.Value = 50
            wc.DownloadFile("https://dl.henryolik.ga/antiezo/files/tov.bat", Application.StartupPath & "/tov.bat")
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        pb_load.Value = 100
        Process.Start(Application.StartupPath & "/antiezo.exe")
        Me.Close()
    End Sub

    Public Sub bf2()
        Dim exeloc As String
        If My.Application.CommandLineArgs.Count >= 2 Then
            Dim mystr As String = My.Application.CommandLineArgs.Item(1)
            Dim cut_at As String = "-e:"
            Dim x As Integer = InStr(mystr, cut_at)
            exeloc = mystr.Substring(x + cut_at.Length - 1)
        Else
            exeloc = Application.StartupPath & "/BF2Updater.exe"
        End If
        If exeloc.IndexOf(".EXE") < 0 And exeloc.IndexOf(".exe") < 0 Then
            MsgBox("A path doesn't contain any exe file. BF2Updater will be downloaded to desktop, you can move it afterwards where you want, keep it on the desktop or rename it. We're sorry for this, it was a bug in version 1.0.3 and it was fixed. Thanks for your patience.", MsgBoxStyle.Information, "Bug!")
            exeloc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "/BF2Updater.exe"
        End If
        la_text.Text = "Update in progress..."
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            pb_load.Value = 1
            wc.DownloadFile("https://dl.henryolik.ga/bf2/updater/BF2Updater.exe", exeloc)
        Catch ex As Exception
            MsgBox("Update failed! Error: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        pb_load.Value = 100
        Process.Start(exeloc)
        Me.Close()
    End Sub

    Public Sub wur()
        Dim exeloc As String
        Dim mystr As String = My.Application.CommandLineArgs.Item(1)
        Dim cut_at As String = "-e:"
        Dim x As Integer = InStr(mystr, cut_at)
        exeloc = mystr.Substring(x + cut_at.Length - 1)
        la_text.Text = "Update in progress..."
        Me.Show()
        pb_load.Minimum = 0
        pb_load.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            pb_load.Value = 1
            wc.DownloadFile("https://dl.henryolik.ga/wur/WUreset.exe", exeloc)
        Catch ex As Exception
            MsgBox("Update failed! Error: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        pb_load.Value = 100
        Process.Start(exeloc)
        Me.Close()
    End Sub

    Public Function Internet() As Boolean
        Dim objUrl As New System.Uri("https://dl.henryolik.ga/status.txt")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            objWebReq = Nothing
            Return False
        End Try
    End Function

    Private Sub Snooze(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Public Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    ' thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function
End Class

