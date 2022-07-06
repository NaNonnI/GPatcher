Imports System.IO
Imports System.Text

Public Class loadingcss

    Dim BaseFile = ""
    Dim PatchedFile = ""

    Dim FileName = "loading.css"

    Dim FilePath As String

    Dim MainPath As String

    Dim Oldtext = "#background
{
	background-image: url( 'img/bg.png' );
	background-size: 100% 100%;
	height: 100%;
}
body.dark #background
{
	background-image: url( 'img/bg_dark.png' );
}
body.dark
{
	color: #fff;
}"

    Dim Newtext = "#background
{

    -webkit-animation-name: bganim;
    -webkit-animation-duration: 15.0s;
    -webkit-animation-iteration-count: infinite;
    -webkit-animation-timing-function: linear;
    -webkit-perspective: 6000px;

    background: linear-gradient(-45deg, #ee7752, #e73c7e, #23a6d5, #23d5ab);
    background-size: 400% 400%;
    height: 100vh;
}

@-webkit-keyframes bganim {
    0% {
        background-position: 0% 50%;
    }
    50% {
        background-position: 100% 50%;
    }
    100% {
        background-position: 0% 50%;
    }
}"

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
        My.Settings.loadingcss = "patched"
        File.WriteAllText(PatchedFile, IO.File.ReadAllText(BaseFile).Replace(Oldtext, Newtext), Encoding.UTF8)
        File.Delete(BaseFile)
        My.Computer.FileSystem.RenameFile(PatchedFile, FileName)
    End Sub

    Private Sub Unpatch()
        My.Settings.loadingcss = "not patched"
        File.WriteAllText(PatchedFile, IO.File.ReadAllText(BaseFile).Replace(Newtext, Oldtext), Encoding.UTF8)
        File.Delete(BaseFile)
        My.Computer.FileSystem.RenameFile(PatchedFile, FileName)
    End Sub

    Public Sub Run()
        If My.Settings.loadingcss = "not patched" Then
            Patch()
        ElseIf My.Settings.loadingcss = "patched" Then
            Unpatch()
        End If
        main.LoadSettings()
    End Sub
End Class