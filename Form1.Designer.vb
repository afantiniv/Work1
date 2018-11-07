<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUcase = New System.Windows.Forms.TextBox()
        Me.btnUcase = New System.Windows.Forms.Button()
        Me.lbUcase = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLen = New System.Windows.Forms.TextBox()
        Me.lbLen = New System.Windows.Forms.Label()
        Me.btnLen = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMid2 = New System.Windows.Forms.TextBox()
        Me.txtMid1 = New System.Windows.Forms.TextBox()
        Me.txtMid = New System.Windows.Forms.TextBox()
        Me.lbMid = New System.Windows.Forms.Label()
        Me.btnMid = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUcase
        '
        Me.txtUcase.Location = New System.Drawing.Point(79, 80)
        Me.txtUcase.Name = "txtUcase"
        Me.txtUcase.Size = New System.Drawing.Size(614, 35)
        Me.txtUcase.TabIndex = 0
        '
        'btnUcase
        '
        Me.btnUcase.Location = New System.Drawing.Point(79, 192)
        Me.btnUcase.Name = "btnUcase"
        Me.btnUcase.Size = New System.Drawing.Size(330, 50)
        Me.btnUcase.TabIndex = 1
        Me.btnUcase.Text = "Cambiar  a Mayusculas"
        Me.btnUcase.UseVisualStyleBackColor = True
        '
        'lbUcase
        '
        Me.lbUcase.AutoSize = True
        Me.lbUcase.Location = New System.Drawing.Point(79, 293)
        Me.lbUcase.Name = "lbUcase"
        Me.lbUcase.Size = New System.Drawing.Size(0, 29)
        Me.lbUcase.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 426)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtUcase)
        Me.TabPage1.Controls.Add(Me.lbUcase)
        Me.TabPage1.Controls.Add(Me.btnUcase)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "UCase"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Texto"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtLen)
        Me.TabPage2.Controls.Add(Me.lbLen)
        Me.TabPage2.Controls.Add(Me.btnLen)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Len"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Texto"
        '
        'txtLen
        '
        Me.txtLen.Location = New System.Drawing.Point(79, 80)
        Me.txtLen.Name = "txtLen"
        Me.txtLen.Size = New System.Drawing.Size(614, 35)
        Me.txtLen.TabIndex = 3
        '
        'lbLen
        '
        Me.lbLen.AutoSize = True
        Me.lbLen.Location = New System.Drawing.Point(79, 293)
        Me.lbLen.Name = "lbLen"
        Me.lbLen.Size = New System.Drawing.Size(0, 29)
        Me.lbLen.TabIndex = 5
        '
        'btnLen
        '
        Me.btnLen.Location = New System.Drawing.Point(79, 192)
        Me.btnLen.Name = "btnLen"
        Me.btnLen.Size = New System.Drawing.Size(257, 50)
        Me.btnLen.TabIndex = 4
        Me.btnLen.Text = "Medir texto"
        Me.btnLen.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtMid2)
        Me.TabPage3.Controls.Add(Me.txtMid1)
        Me.TabPage3.Controls.Add(Me.txtMid)
        Me.TabPage3.Controls.Add(Me.lbMid)
        Me.TabPage3.Controls.Add(Me.btnMid)
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(768, 384)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mid"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cantidad (#):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Inicio (#):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Texto"
        '
        'txtMid2
        '
        Me.txtMid2.Location = New System.Drawing.Point(581, 130)
        Me.txtMid2.Name = "txtMid2"
        Me.txtMid2.Size = New System.Drawing.Size(100, 35)
        Me.txtMid2.TabIndex = 7
        '
        'txtMid1
        '
        Me.txtMid1.Location = New System.Drawing.Point(200, 130)
        Me.txtMid1.Name = "txtMid1"
        Me.txtMid1.Size = New System.Drawing.Size(100, 35)
        Me.txtMid1.TabIndex = 6
        '
        'txtMid
        '
        Me.txtMid.Location = New System.Drawing.Point(79, 80)
        Me.txtMid.Name = "txtMid"
        Me.txtMid.Size = New System.Drawing.Size(614, 35)
        Me.txtMid.TabIndex = 3
        '
        'lbMid
        '
        Me.lbMid.AutoSize = True
        Me.lbMid.Location = New System.Drawing.Point(79, 293)
        Me.lbMid.Name = "lbMid"
        Me.lbMid.Size = New System.Drawing.Size(0, 29)
        Me.lbMid.TabIndex = 5
        '
        'btnMid
        '
        Me.btnMid.Location = New System.Drawing.Point(79, 192)
        Me.btnMid.Name = "btnMid"
        Me.btnMid.Size = New System.Drawing.Size(257, 50)
        Me.btnMid.TabIndex = 4
        Me.btnMid.Text = "Selección Mid"
        Me.btnMid.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUcase As TextBox
    Friend WithEvents btnUcase As Button
    Friend WithEvents lbUcase As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtLen As TextBox
    Friend WithEvents lbLen As Label
    Friend WithEvents btnLen As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtMid As TextBox
    Friend WithEvents lbMid As Label
    Friend WithEvents btnMid As Button
    Friend WithEvents txtMid2 As TextBox
    Friend WithEvents txtMid1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
