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
        Me.AddUniqueItemButton = New System.Windows.Forms.Button()
        Me.AddUniqueItemFromListButton = New System.Windows.Forms.Button()
        Me.ListContainsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddUniqueItemButton
        '
        Me.AddUniqueItemButton.Location = New System.Drawing.Point(12, 22)
        Me.AddUniqueItemButton.Name = "AddUniqueItemButton"
        Me.AddUniqueItemButton.Size = New System.Drawing.Size(189, 23)
        Me.AddUniqueItemButton.TabIndex = 0
        Me.AddUniqueItemButton.Text = "Add Unique item"
        Me.AddUniqueItemButton.UseVisualStyleBackColor = True
        '
        'AddUniqueItemFromListButton
        '
        Me.AddUniqueItemFromListButton.Location = New System.Drawing.Point(12, 51)
        Me.AddUniqueItemFromListButton.Name = "AddUniqueItemFromListButton"
        Me.AddUniqueItemFromListButton.Size = New System.Drawing.Size(189, 23)
        Me.AddUniqueItemFromListButton.TabIndex = 1
        Me.AddUniqueItemFromListButton.Text = "Add Unique from List"
        Me.AddUniqueItemFromListButton.UseVisualStyleBackColor = True
        '
        'ListContainsButton
        '
        Me.ListContainsButton.Location = New System.Drawing.Point(12, 80)
        Me.ListContainsButton.Name = "ListContainsButton"
        Me.ListContainsButton.Size = New System.Drawing.Size(189, 23)
        Me.ListContainsButton.TabIndex = 2
        Me.ListContainsButton.Text = "List contains"
        Me.ListContainsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 236)
        Me.Controls.Add(Me.ListContainsButton)
        Me.Controls.Add(Me.AddUniqueItemFromListButton)
        Me.Controls.Add(Me.AddUniqueItemButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddUniqueItemButton As Button
    Friend WithEvents AddUniqueItemFromListButton As Button
    Friend WithEvents ListContainsButton As Button
End Class
