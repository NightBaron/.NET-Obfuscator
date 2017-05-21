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
        Me.import_btn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ildasm = New System.Windows.Forms.CheckBox()
        Me.tamper = New System.Windows.Forms.CheckBox()
        Me.ctrlflow = New System.Windows.Forms.CheckBox()
        Me.encodestr = New System.Windows.Forms.CheckBox()
        Me.renames = New System.Windows.Forms.CheckBox()
        Me.junkmethod = New System.Windows.Forms.CheckBox()
        Me.signature = New System.Windows.Forms.CheckBox()
        Me.obfuscate_btn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'import_btn
        '
        Me.import_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.import_btn.Location = New System.Drawing.Point(12, 12)
        Me.import_btn.Name = "import_btn"
        Me.import_btn.Size = New System.Drawing.Size(75, 23)
        Me.import_btn.TabIndex = 0
        Me.import_btn.Text = "Import"
        Me.import_btn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ildasm
        '
        Me.ildasm.AutoSize = True
        Me.ildasm.Location = New System.Drawing.Point(12, 41)
        Me.ildasm.Name = "ildasm"
        Me.ildasm.Size = New System.Drawing.Size(77, 17)
        Me.ildasm.TabIndex = 2
        Me.ildasm.Text = "Anti Ildasm"
        Me.ildasm.UseVisualStyleBackColor = True
        '
        'tamper
        '
        Me.tamper.AutoSize = True
        Me.tamper.Location = New System.Drawing.Point(12, 64)
        Me.tamper.Name = "tamper"
        Me.tamper.Size = New System.Drawing.Size(83, 17)
        Me.tamper.TabIndex = 3
        Me.tamper.Text = "Anti Tamper"
        Me.tamper.UseVisualStyleBackColor = True
        '
        'ctrlflow
        '
        Me.ctrlflow.AutoSize = True
        Me.ctrlflow.Location = New System.Drawing.Point(135, 41)
        Me.ctrlflow.Name = "ctrlflow"
        Me.ctrlflow.Size = New System.Drawing.Size(84, 17)
        Me.ctrlflow.TabIndex = 4
        Me.ctrlflow.Text = "Control Flow"
        Me.ctrlflow.UseVisualStyleBackColor = True
        '
        'encodestr
        '
        Me.encodestr.AutoSize = True
        Me.encodestr.Location = New System.Drawing.Point(135, 64)
        Me.encodestr.Name = "encodestr"
        Me.encodestr.Size = New System.Drawing.Size(93, 17)
        Me.encodestr.TabIndex = 5
        Me.encodestr.Text = "Encode String"
        Me.encodestr.UseVisualStyleBackColor = True
        '
        'renames
        '
        Me.renames.AutoSize = True
        Me.renames.Location = New System.Drawing.Point(258, 64)
        Me.renames.Name = "renames"
        Me.renames.Size = New System.Drawing.Size(71, 17)
        Me.renames.TabIndex = 6
        Me.renames.Text = "Renames"
        Me.renames.UseVisualStyleBackColor = True
        '
        'junkmethod
        '
        Me.junkmethod.AutoSize = True
        Me.junkmethod.Location = New System.Drawing.Point(258, 41)
        Me.junkmethod.Name = "junkmethod"
        Me.junkmethod.Size = New System.Drawing.Size(87, 17)
        Me.junkmethod.TabIndex = 7
        Me.junkmethod.Text = "Junk method"
        Me.junkmethod.UseVisualStyleBackColor = True
        '
        'signature
        '
        Me.signature.AutoSize = True
        Me.signature.Location = New System.Drawing.Point(12, 87)
        Me.signature.Name = "signature"
        Me.signature.Size = New System.Drawing.Size(93, 17)
        Me.signature.TabIndex = 8
        Me.signature.Text = "Add Signature"
        Me.signature.UseVisualStyleBackColor = True
        '
        'obfuscate_btn
        '
        Me.obfuscate_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.obfuscate_btn.Location = New System.Drawing.Point(135, 83)
        Me.obfuscate_btn.Name = "obfuscate_btn"
        Me.obfuscate_btn.Size = New System.Drawing.Size(222, 23)
        Me.obfuscate_btn.TabIndex = 9
        Me.obfuscate_btn.Text = "Obfuscate Assembly !"
        Me.obfuscate_btn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = ".NET|*.exe|.NET|*.dll"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 109)
        Me.Controls.Add(Me.obfuscate_btn)
        Me.Controls.Add(Me.signature)
        Me.Controls.Add(Me.junkmethod)
        Me.Controls.Add(Me.renames)
        Me.Controls.Add(Me.encodestr)
        Me.Controls.Add(Me.ctrlflow)
        Me.Controls.Add(Me.tamper)
        Me.Controls.Add(Me.ildasm)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.import_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple .NET Obfuscator using Mono Cecil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents import_btn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ildasm As CheckBox
    Friend WithEvents tamper As CheckBox
    Friend WithEvents ctrlflow As CheckBox
    Friend WithEvents encodestr As CheckBox
    Friend WithEvents renames As CheckBox
    Friend WithEvents junkmethod As CheckBox
    Friend WithEvents signature As CheckBox
    Friend WithEvents obfuscate_btn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
