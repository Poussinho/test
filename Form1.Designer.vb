<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisionCotat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.DateFirst = New System.Windows.Forms.DateTimePicker()
        Me.DateSecond = New System.Windows.Forms.DateTimePicker()
        Me.QuotaMin = New System.Windows.Forms.TextBox()
        Me.QuotaMax = New System.Windows.Forms.TextBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(500, 434)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(119, 35)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Rechercher"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LeaveButton
        '
        Me.LeaveButton.Location = New System.Drawing.Point(684, 434)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(90, 35)
        Me.LeaveButton.TabIndex = 2
        Me.LeaveButton.Text = "Quitter"
        Me.LeaveButton.UseVisualStyleBackColor = True
        '
        'DateFirst
        '
        Me.DateFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFirst.Location = New System.Drawing.Point(143, 26)
        Me.DateFirst.Name = "DateFirst"
        Me.DateFirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateFirst.Size = New System.Drawing.Size(182, 20)
        Me.DateFirst.TabIndex = 3
        '
        'DateSecond
        '
        Me.DateSecond.Location = New System.Drawing.Point(457, 26)
        Me.DateSecond.Name = "DateSecond"
        Me.DateSecond.Size = New System.Drawing.Size(194, 20)
        Me.DateSecond.TabIndex = 4
        '
        'QuotaMin
        '
        Me.QuotaMin.HideSelection = False
        Me.QuotaMin.Location = New System.Drawing.Point(181, 74)
        Me.QuotaMin.Name = "QuotaMin"
        Me.QuotaMin.Size = New System.Drawing.Size(100, 20)
        Me.QuotaMin.TabIndex = 5
        Me.QuotaMin.Text = "Quotat min"
        Me.QuotaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QuotaMax
        '
        Me.QuotaMax.Location = New System.Drawing.Point(500, 74)
        Me.QuotaMax.Name = "QuotaMax"
        Me.QuotaMax.Size = New System.Drawing.Size(100, 20)
        Me.QuotaMax.TabIndex = 6
        Me.QuotaMax.Text = "Quotat max"
        Me.QuotaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'VisionCotat
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(815, 481)
        Me.Controls.Add(Me.QuotaMax)
        Me.Controls.Add(Me.QuotaMin)
        Me.Controls.Add(Me.DateSecond)
        Me.Controls.Add(Me.DateFirst)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Name = "VisionCotat"
        Me.Text = "Vision des cotats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchButton As Button
    Friend WithEvents LeaveButton As Button
    Friend WithEvents DateFirst As DateTimePicker
    Friend WithEvents DateSecond As DateTimePicker
    Friend WithEvents QuotaMin As TextBox
    Friend WithEvents QuotaMax As TextBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
End Class
