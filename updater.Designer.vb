<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updater))
        Me.pb_load = New System.Windows.Forms.ProgressBar()
        Me.la_perc = New System.Windows.Forms.Label()
        Me.la_text = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pb_load
        '
        Me.pb_load.Location = New System.Drawing.Point(12, 77)
        Me.pb_load.Name = "pb_load"
        Me.pb_load.Size = New System.Drawing.Size(372, 29)
        Me.pb_load.TabIndex = 0
        '
        'la_perc
        '
        Me.la_perc.AutoSize = True
        Me.la_perc.Location = New System.Drawing.Point(12, 61)
        Me.la_perc.Name = "la_perc"
        Me.la_perc.Size = New System.Drawing.Size(10, 13)
        Me.la_perc.TabIndex = 1
        Me.la_perc.Text = "."
        '
        'la_text
        '
        Me.la_text.AutoSize = True
        Me.la_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.la_text.Location = New System.Drawing.Point(25, 9)
        Me.la_text.Name = "la_text"
        Me.la_text.Size = New System.Drawing.Size(350, 39)
        Me.la_text.TabIndex = 2
        Me.la_text.Text = "Probíhá aktualizace..."
        '
        'updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 126)
        Me.Controls.Add(Me.la_text)
        Me.Controls.Add(Me.la_perc)
        Me.Controls.Add(Me.pb_load)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "updater"
        Me.Text = "hUpdater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_load As System.Windows.Forms.ProgressBar
    Friend WithEvents la_perc As System.Windows.Forms.Label
    Friend WithEvents la_text As System.Windows.Forms.Label
End Class

