<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.lblWords = New System.Windows.Forms.Label()
        Me.lstInfo = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(27, 61)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(75, 23)
        Me.btnRandom.TabIndex = 0
        Me.btnRandom.Text = "Play!"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblWords
        '
        Me.lblWords.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblWords.Location = New System.Drawing.Point(129, 61)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(100, 23)
        Me.lblWords.TabIndex = 1
        '
        'lstInfo
        '
        Me.lstInfo.FormattingEnabled = True
        Me.lstInfo.ItemHeight = 16
        Me.lstInfo.Items.AddRange(New Object() {"10000", "skip", "skip", "skip", "bankrupt", "bankrupt", "5000", "5000", "5000", "2000", "2000", "2000", "2000", "2000", "2000", "1000", "1000", "1000", "1000", "1000", "1000", "1000", "1000", "1000", "1000"})
        Me.lstInfo.Location = New System.Drawing.Point(27, 107)
        Me.lstInfo.Name = "lstInfo"
        Me.lstInfo.Size = New System.Drawing.Size(120, 116)
        Me.lstInfo.TabIndex = 2
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 252)
        Me.Controls.Add(Me.lstInfo)
        Me.Controls.Add(Me.lblWords)
        Me.Controls.Add(Me.btnRandom)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRandom As Button
    Friend WithEvents lblWords As Label
    Friend WithEvents lstInfo As ListBox
    Friend WithEvents Timer1 As Timer
End Class
