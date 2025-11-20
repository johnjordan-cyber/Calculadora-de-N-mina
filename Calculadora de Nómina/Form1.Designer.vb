<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtname = New TextBox()
        txtbase = New TextBox()
        txtExtras = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtPagoporhora = New TextBox()
        Label4 = New Label()
        txtsegur = New TextBox()
        txtsueldoneto = New TextBox()
        txtsegurodevida = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtTomorrow = New RadioButton()
        txttard = New RadioButton()
        txtacepta = New Button()
        txtBorrar = New Button()
        txtsal = New Button()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(46, 115)
        txtname.Name = "txtname"
        txtname.Size = New Size(161, 27)
        txtname.TabIndex = 0
        ' 
        ' txtbase
        ' 
        txtbase.Location = New Point(46, 181)
        txtbase.Name = "txtbase"
        txtbase.Size = New Size(161, 27)
        txtbase.TabIndex = 0
        ' 
        ' txtExtras
        ' 
        txtExtras.Location = New Point(46, 255)
        txtExtras.Name = "txtExtras"
        txtExtras.Size = New Size(167, 27)
        txtExtras.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre del empleado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 20)
        Label2.TabIndex = 1
        Label2.Text = "Salario Base Mensual"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 20)
        Label3.TabIndex = 1
        Label3.Text = "Horas Extras Trabajadas"
        ' 
        ' txtPagoporhora
        ' 
        txtPagoporhora.Location = New Point(648, 312)
        txtPagoporhora.Name = "txtPagoporhora"
        txtPagoporhora.Size = New Size(167, 27)
        txtPagoporhora.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(635, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 20)
        Label4.TabIndex = 1
        Label4.Text = "Salario final Neto a pagar"
        ' 
        ' txtsegur
        ' 
        txtsegur.Enabled = False
        txtsegur.Location = New Point(649, 101)
        txtsegur.Name = "txtsegur"
        txtsegur.Size = New Size(167, 27)
        txtsegur.TabIndex = 0
        ' 
        ' txtsueldoneto
        ' 
        txtsueldoneto.Location = New Point(649, 181)
        txtsueldoneto.Name = "txtsueldoneto"
        txtsueldoneto.Size = New Size(167, 27)
        txtsueldoneto.TabIndex = 0
        ' 
        ' txtsegurodevida
        ' 
        txtsegurodevida.Location = New Point(648, 246)
        txtsegurodevida.Name = "txtsegurodevida"
        txtsegurodevida.Size = New Size(167, 27)
        txtsegurodevida.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(635, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(195, 20)
        Label7.TabIndex = 1
        Label7.Text = "Descuento de Seguro Social"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(635, 158)
        Label8.Name = "Label8"
        Label8.Size = New Size(220, 20)
        Label8.TabIndex = 1
        Label8.Text = "Descuento de Seguro Educativo"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(606, 223)
        Label9.Name = "Label9"
        Label9.Size = New Size(275, 20)
        Label9.TabIndex = 1
        Label9.Text = "Costo Total del Recargo de Horas Extras"
        ' 
        ' txtTomorrow
        ' 
        txtTomorrow.AutoSize = True
        txtTomorrow.Location = New Point(281, 421)
        txtTomorrow.Name = "txtTomorrow"
        txtTomorrow.Size = New Size(130, 24)
        txtTomorrow.TabIndex = 2
        txtTomorrow.TabStop = True
        txtTomorrow.Text = "Jornada Diurna"
        txtTomorrow.UseVisualStyleBackColor = True
        ' 
        ' txttard
        ' 
        txttard.AutoSize = True
        txttard.Location = New Point(432, 421)
        txttard.Name = "txttard"
        txttard.Size = New Size(190, 24)
        txttard.TabIndex = 2
        txttard.TabStop = True
        txttard.Text = "Jornada Nocturna/Mixta"
        txttard.UseVisualStyleBackColor = True
        ' 
        ' txtacepta
        ' 
        txtacepta.Location = New Point(403, 256)
        txtacepta.Name = "txtacepta"
        txtacepta.Size = New Size(94, 29)
        txtacepta.TabIndex = 3
        txtacepta.Text = "Calcular"
        txtacepta.UseVisualStyleBackColor = True
        ' 
        ' txtBorrar
        ' 
        txtBorrar.Location = New Point(403, 320)
        txtBorrar.Name = "txtBorrar"
        txtBorrar.Size = New Size(94, 29)
        txtBorrar.TabIndex = 3
        txtBorrar.Text = "Borrar"
        txtBorrar.UseVisualStyleBackColor = True
        ' 
        ' txtsal
        ' 
        txtsal.Location = New Point(403, 375)
        txtsal.Name = "txtsal"
        txtsal.Size = New Size(94, 29)
        txtsal.TabIndex = 3
        txtsal.Text = "Salir"
        txtsal.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(323, 25)
        Label10.Name = "Label10"
        Label10.Size = New Size(264, 31)
        Label10.TabIndex = 1
        Label10.Text = "Calculadora de Nómina"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(915, 477)
        Controls.Add(txtsal)
        Controls.Add(txtBorrar)
        Controls.Add(txtacepta)
        Controls.Add(txttard)
        Controls.Add(txtTomorrow)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label3)
        Controls.Add(Label8)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtsegurodevida)
        Controls.Add(txtExtras)
        Controls.Add(txtsueldoneto)
        Controls.Add(txtsegur)
        Controls.Add(txtPagoporhora)
        Controls.Add(txtbase)
        Controls.Add(txtname)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents txtbase As TextBox
    Friend WithEvents txtExtras As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPagoporhora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsegur As TextBox
    Friend WithEvents txtsueldoneto As TextBox
    Friend WithEvents txtsegurodevida As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTomorrow As RadioButton
    Friend WithEvents txttard As RadioButton
    Friend WithEvents txtacepta As Button
    Friend WithEvents txtBorrar As Button
    Friend WithEvents txtsal As Button
    Friend WithEvents Label10 As Label

End Class
