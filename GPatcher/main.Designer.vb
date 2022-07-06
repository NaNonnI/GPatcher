<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.sf = New System.Windows.Forms.Button()
        Me.var1 = New System.Windows.Forms.Label()
        Me.var2 = New System.Windows.Forms.Label()
        Me.var3 = New System.Windows.Forms.Label()
        Me.loadingcsscb = New System.Windows.Forms.CheckBox()
        Me.fp = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.loadinghtmlcb = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'sf
        '
        Me.sf.Location = New System.Drawing.Point(12, 12)
        Me.sf.Name = "sf"
        Me.sf.Size = New System.Drawing.Size(75, 20)
        Me.sf.TabIndex = 4
        Me.sf.Text = "Search"
        Me.sf.UseVisualStyleBackColor = True
        '
        'var1
        '
        Me.var1.AutoSize = True
        Me.var1.Location = New System.Drawing.Point(90, 82)
        Me.var1.Name = "var1"
        Me.var1.Size = New System.Drawing.Size(39, 13)
        Me.var1.TabIndex = 7
        Me.var1.Text = "Label1"
        '
        'var2
        '
        Me.var2.AutoSize = True
        Me.var2.Location = New System.Drawing.Point(90, 107)
        Me.var2.Name = "var2"
        Me.var2.Size = New System.Drawing.Size(39, 13)
        Me.var2.TabIndex = 8
        Me.var2.Text = "Label1"
        '
        'var3
        '
        Me.var3.AutoSize = True
        Me.var3.Location = New System.Drawing.Point(90, 132)
        Me.var3.Name = "var3"
        Me.var3.Size = New System.Drawing.Size(39, 13)
        Me.var3.TabIndex = 9
        Me.var3.Text = "Label1"
        '
        'loadingcsscb
        '
        Me.loadingcsscb.AutoSize = True
        Me.loadingcsscb.Enabled = False
        Me.loadingcsscb.Location = New System.Drawing.Point(174, 42)
        Me.loadingcsscb.Name = "loadingcsscb"
        Me.loadingcsscb.Size = New System.Drawing.Size(122, 17)
        Me.loadingcsscb.TabIndex = 6
        Me.loadingcsscb.Text = "Patched loading.css"
        Me.loadingcsscb.UseVisualStyleBackColor = True
        '
        'fp
        '
        Me.fp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GPatcher.My.MySettings.Default, "filepath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.fp.Location = New System.Drawing.Point(93, 12)
        Me.fp.Name = "fp"
        Me.fp.Size = New System.Drawing.Size(695, 20)
        Me.fp.TabIndex = 5
        Me.fp.Text = Global.GPatcher.My.MySettings.Default.filepath
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Patch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'loadinghtmlcb
        '
        Me.loadinghtmlcb.AutoSize = True
        Me.loadinghtmlcb.Enabled = False
        Me.loadinghtmlcb.Location = New System.Drawing.Point(174, 58)
        Me.loadinghtmlcb.Name = "loadinghtmlcb"
        Me.loadinghtmlcb.Size = New System.Drawing.Size(125, 17)
        Me.loadinghtmlcb.TabIndex = 11
        Me.loadinghtmlcb.Text = "Patched loading.html"
        Me.loadinghtmlcb.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loadinghtmlcb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.var3)
        Me.Controls.Add(Me.var2)
        Me.Controls.Add(Me.var1)
        Me.Controls.Add(Me.loadingcsscb)
        Me.Controls.Add(Me.fp)
        Me.Controls.Add(Me.sf)
        Me.Name = "main"
        Me.Text = "cs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fp As TextBox
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents sf As Button
    Friend WithEvents var1 As Label
    Friend WithEvents var2 As Label
    Friend WithEvents var3 As Label
    Friend WithEvents loadingcsscb As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents loadinghtmlcb As CheckBox
End Class
