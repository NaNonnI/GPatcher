Imports System.IO
Imports System.Text

Public Class loadinghtml

    Dim BaseFile = ""
    Dim PatchedFile = ""

    Dim FileName = "loading.html"

    Dim FilePath As String

    Dim MainPath As String

    Dim Oldtext = "<center>
					<br />
					<div class=""walk"">:v</div>
				</center>"

    Dim Newtext = "<center>
					<br />
					<div class=""walk"">:D</div>
				</center>"

    Public Sub Load()
        If main.var1.Text = "OK" Then

            MainPath = My.Settings.filepath

            BaseFile = MainPath + "\garrysmod\html\" + FileName
            PatchedFile = MainPath + "\garrysmod\html\" + FileName + ".patch"

            main.Button1.Enabled = True

            Dim txt = My.Computer.FileSystem.ReadAllText(BaseFile, System.Text.Encoding.ASCII)

        Else
            main.Button1.Enabled = False
        End If
    End Sub

    Private Sub Patch()
        My.Settings.loadinghtml = "patched"
        File.WriteAllText(PatchedFile, IO.File.ReadAllText(BaseFile).Replace(Oldtext, Newtext), Encoding.UTF8)
        File.Delete(BaseFile)
        My.Computer.FileSystem.RenameFile(PatchedFile, FileName)
    End Sub

    Private Sub Unpatch()
        My.Settings.loadinghtml = "not patched"
        File.WriteAllText(PatchedFile, IO.File.ReadAllText(BaseFile).Replace(Newtext, Oldtext), Encoding.UTF8)
        File.Delete(BaseFile)
        My.Computer.FileSystem.RenameFile(PatchedFile, FileName)
    End Sub

    Public Sub Run()
        If My.Settings.loadinghtml = "not patched" Then
            Patch()
        ElseIf My.Settings.loadinghtml = "patched" Then
            Unpatch()
        End If
        main.LoadSettings()
    End Sub
End Class