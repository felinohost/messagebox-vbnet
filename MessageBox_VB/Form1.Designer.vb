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
        Me.btnProbar = New System.Windows.Forms.Button()
        Me.btnPregunta = New System.Windows.Forms.Button()
        Me.btn_Modulo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProbar
        '
        Me.btnProbar.Location = New System.Drawing.Point(85, 156)
        Me.btnProbar.Name = "btnProbar"
        Me.btnProbar.Size = New System.Drawing.Size(75, 23)
        Me.btnProbar.TabIndex = 0
        Me.btnProbar.Text = "Probar"
        Me.btnProbar.UseVisualStyleBackColor = True
        '
        'btnPregunta
        '
        Me.btnPregunta.Location = New System.Drawing.Point(182, 156)
        Me.btnPregunta.Name = "btnPregunta"
        Me.btnPregunta.Size = New System.Drawing.Size(75, 23)
        Me.btnPregunta.TabIndex = 1
        Me.btnPregunta.Text = "Pregunta"
        Me.btnPregunta.UseVisualStyleBackColor = True
        '
        'btn_Modulo
        '
        Me.btn_Modulo.Location = New System.Drawing.Point(280, 156)
        Me.btn_Modulo.Name = "btn_Modulo"
        Me.btn_Modulo.Size = New System.Drawing.Size(108, 23)
        Me.btn_Modulo.TabIndex = 2
        Me.btn_Modulo.Text = "Con Modulo"
        Me.btn_Modulo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Modulo)
        Me.Controls.Add(Me.btnPregunta)
        Me.Controls.Add(Me.btnProbar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProbar As Button
    Friend WithEvents btnPregunta As Button
    Friend WithEvents btn_Modulo As Button
End Class
