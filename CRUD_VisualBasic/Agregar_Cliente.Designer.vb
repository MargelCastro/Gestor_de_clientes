﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Cliente
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txt_nombreSV = New TextBox()
        txt_ApellidoSV = New TextBox()
        txt_cedulaSV = New TextBox()
        txt_CelularSV = New TextBox()
        txt_DeudaSV = New TextBox()
        btn_GuardarSV = New Button()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(109, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(475, 59)
        Label1.TabIndex = 5
        Label1.Text = "AGREGAR NUEVO CLIENTE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(170, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 6
        Label2.Text = "Nombre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(170, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 7
        Label3.Text = "Apellido:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(157, 308)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 8
        Label4.Text = "No Cedula:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(157, 356)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 20)
        Label5.TabIndex = 9
        Label5.Text = "No Celular:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(135, 407)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 10
        Label6.Text = "Monto Deuda:"
        ' 
        ' txt_nombreSV
        ' 
        txt_nombreSV.Location = New Point(257, 208)
        txt_nombreSV.Name = "txt_nombreSV"
        txt_nombreSV.Size = New Size(254, 27)
        txt_nombreSV.TabIndex = 11
        ' 
        ' txt_ApellidoSV
        ' 
        txt_ApellidoSV.Location = New Point(257, 251)
        txt_ApellidoSV.Name = "txt_ApellidoSV"
        txt_ApellidoSV.Size = New Size(254, 27)
        txt_ApellidoSV.TabIndex = 12
        ' 
        ' txt_cedulaSV
        ' 
        txt_cedulaSV.Location = New Point(257, 301)
        txt_cedulaSV.Name = "txt_cedulaSV"
        txt_cedulaSV.Size = New Size(254, 27)
        txt_cedulaSV.TabIndex = 13
        ' 
        ' txt_CelularSV
        ' 
        txt_CelularSV.Location = New Point(257, 349)
        txt_CelularSV.Name = "txt_CelularSV"
        txt_CelularSV.Size = New Size(254, 27)
        txt_CelularSV.TabIndex = 14
        ' 
        ' txt_DeudaSV
        ' 
        txt_DeudaSV.Location = New Point(257, 400)
        txt_DeudaSV.Name = "txt_DeudaSV"
        txt_DeudaSV.Size = New Size(254, 27)
        txt_DeudaSV.TabIndex = 15
        ' 
        ' btn_GuardarSV
        ' 
        btn_GuardarSV.BackColor = Color.RoyalBlue
        btn_GuardarSV.Cursor = Cursors.Hand
        btn_GuardarSV.FlatStyle = FlatStyle.Flat
        btn_GuardarSV.Font = New Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_GuardarSV.ForeColor = Color.Transparent
        btn_GuardarSV.Location = New Point(201, 507)
        btn_GuardarSV.Name = "btn_GuardarSV"
        btn_GuardarSV.Size = New Size(294, 65)
        btn_GuardarSV.TabIndex = 16
        btn_GuardarSV.Text = "Guardar Cliente"
        btn_GuardarSV.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.volver
        PictureBox1.Location = New Point(522, 614)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(547, 679)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 27)
        Label7.TabIndex = 18
        Label7.Text = "Volver"
        ' 
        ' Agregar_Cliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(670, 710)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(btn_GuardarSV)
        Controls.Add(txt_DeudaSV)
        Controls.Add(txt_CelularSV)
        Controls.Add(txt_cedulaSV)
        Controls.Add(txt_ApellidoSV)
        Controls.Add(txt_nombreSV)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MinimizeBox = False
        Name = "Agregar_Cliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar_Cliente"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nombreSV As TextBox
    Friend WithEvents txt_ApellidoSV As TextBox
    Friend WithEvents txt_cedulaSV As TextBox
    Friend WithEvents txt_CelularSV As TextBox
    Friend WithEvents txt_DeudaSV As TextBox
    Friend WithEvents btn_GuardarSV As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
