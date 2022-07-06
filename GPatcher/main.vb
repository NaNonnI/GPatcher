Imports System.IO

Public Class main

    Dim Loadingcss As New loadingcss
    Dim Loadinghtml As New loadinghtml
    Dim Definepath As New definepath
    Private Sub OK()
        sf.Enabled = False
        sf.Text = "OK"
        My.Settings.Save()
        LoadPatchers()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fp.Text = "" Then
            MsgBox("Please select a folder to save the patchers to.", MsgBoxStyle.Critical, "Error")
        Else
            OK()
        End If
    End Sub

    Public Sub LoadSettings()
        If My.Settings.loadingcss = "not patched" Then loadingcsscb.Checked = False Else loadingcsscb.Checked = True
        If My.Settings.loadinghtml = "not patched" Then loadinghtmlcb.Checked = False Else loadinghtmlcb.Checked = True
    End Sub

    Private Sub LoadPatchers()
        LoadSettings()
        Definepath.Define()
        Loadingcss.Load()
        Loadinghtml.Load()
    End Sub

    Private Sub sf_Click(sender As Object, e As EventArgs) Handles sf.Click
        FolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog.Description = "Select GMOD installation folder:"
        FolderBrowserDialog.ShowNewFolderButton = False
        FolderBrowserDialog.SelectedPath = fp.Text
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            fp.Text = FolderBrowserDialog.SelectedPath()
            If File.Exists(fp.Text + "\hl2.exe") Then
                My.Settings.Save()
                OK()
            Else
                MsgBox("hl2.exe n'as pas été trouvé.", MsgBoxStyle.Critical, "Error")
                fp.Text = ""
            End If
            LoadPatchers()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loadingcss.Run()
        Loadinghtml.Run()
    End Sub
End Class