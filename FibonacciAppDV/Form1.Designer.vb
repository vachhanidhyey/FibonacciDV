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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTerm1 = New System.Windows.Forms.TextBox()
        Me.lstSequence = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtTerm2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the first two terms and then press calculate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number 2"
        '
        'txtTerm1
        '
        Me.txtTerm1.Location = New System.Drawing.Point(153, 69)
        Me.txtTerm1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTerm1.Name = "txtTerm1"
        Me.txtTerm1.Size = New System.Drawing.Size(68, 20)
        Me.txtTerm1.TabIndex = 3
        '
        'lstSequence
        '
        Me.lstSequence.FormattingEnabled = True
        Me.lstSequence.Location = New System.Drawing.Point(70, 148)
        Me.lstSequence.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstSequence.Name = "lstSequence"
        Me.lstSequence.Size = New System.Drawing.Size(151, 95)
        Me.lstSequence.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(299, 62)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(65, 30)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(299, 107)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(57, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtTerm2
        '
        Me.txtTerm2.Location = New System.Drawing.Point(153, 103)
        Me.txtTerm2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTerm2.Name = "txtTerm2"
        Me.txtTerm2.Size = New System.Drawing.Size(68, 20)
        Me.txtTerm2.TabIndex = 7
        Me.txtTerm2.Text = "x"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 275)
        Me.Controls.Add(Me.txtTerm2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstSequence)
        Me.Controls.Add(Me.txtTerm1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Fibonacci sequence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTerm1 As System.Windows.Forms.TextBox
    Friend WithEvents lstSequence As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtTerm2 As System.Windows.Forms.TextBox

End Class
