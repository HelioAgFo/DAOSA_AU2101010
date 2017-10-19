'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Update1 = New Interop.SAF.SAFUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cCodigoInterv = New Interop.SAF.SAFMaskedText()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cServiceCallId = New Interop.SAF.SAFMaskedText()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cDevolucion_1 = New Interop.SAF.SAFCheck()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SafGrid1 = New Interop.SAF.SAFGrid()
        Me.cInvtType_1 = New Interop.SAF.SAFCombo()
        Me.cPrecioExtendido_1 = New Interop.SAF.SAFFloat()
        Me.cPrecio_1 = New Interop.SAF.SAFFloat()
        Me.cCantidad_1 = New Interop.SAF.SAFFloat()
        Me.cInvtDescr_1 = New Interop.SAF.SAFMaskedText()
        Me.cInvtID_1 = New Interop.SAF.SAFMaskedText()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cCodigoInterv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cServiceCallId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cDevolucion_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SafGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cInvtType_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cPrecioExtendido_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cPrecio_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cCantidad_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cInvtDescr_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cInvtID_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Enabled = True
        Me.Update1.Location = New System.Drawing.Point(220, 238)
        Me.Update1.Margin = New System.Windows.Forms.Padding(4)
        Me.Update1.Name = "Update1"
        Me.Update1.OcxState = CType(resources.GetObject("Update1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Update1.Size = New System.Drawing.Size(33, 33)
        Me.Update1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cCodigoInterv)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cServiceCallId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1054, 86)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cCodigoInterv
        '
        Me.cCodigoInterv.Location = New System.Drawing.Point(201, 38)
        Me.cCodigoInterv.Name = "cCodigoInterv"
        Me.cCodigoInterv.OcxState = CType(resources.GetObject("cCodigoInterv.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cCodigoInterv.Size = New System.Drawing.Size(68, 24)
        Me.cCodigoInterv.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Intervención"
        '
        'cServiceCallId
        '
        Me.cServiceCallId.Location = New System.Drawing.Point(9, 38)
        Me.cServiceCallId.Name = "cServiceCallId"
        Me.cServiceCallId.OcxState = CType(resources.GetObject("cServiceCallId.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cServiceCallId.Size = New System.Drawing.Size(127, 24)
        Me.cServiceCallId.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orden de Servicio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cDevolucion_1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.SafGrid1)
        Me.GroupBox2.Controls.Add(Me.cInvtType_1)
        Me.GroupBox2.Controls.Add(Me.cPrecioExtendido_1)
        Me.GroupBox2.Controls.Add(Me.cPrecio_1)
        Me.GroupBox2.Controls.Add(Me.cCantidad_1)
        Me.GroupBox2.Controls.Add(Me.cInvtDescr_1)
        Me.GroupBox2.Controls.Add(Me.cInvtID_1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1054, 409)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Partes(F4 para Table/Forma)"
        '
        'cDevolucion_1
        '
        Me.cDevolucion_1.Location = New System.Drawing.Point(162, 320)
        Me.cDevolucion_1.Name = "cDevolucion_1"
        Me.cDevolucion_1.OcxState = CType(resources.GetObject("cDevolucion_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cDevolucion_1.Size = New System.Drawing.Size(116, 24)
        Me.cDevolucion_1.TabIndex = 82
        Me.cDevolucion_1.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Devolucion"
        '
        'SafGrid1
        '
        Me.SafGrid1.Location = New System.Drawing.Point(474, 249)
        Me.SafGrid1.Name = "SafGrid1"
        Me.SafGrid1.OcxState = CType(resources.GetObject("SafGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SafGrid1.Size = New System.Drawing.Size(321, 110)
        Me.SafGrid1.TabIndex = 80
        '
        'cInvtType_1
        '
        Me.cInvtType_1.Location = New System.Drawing.Point(162, 130)
        Me.cInvtType_1.Name = "cInvtType_1"
        Me.cInvtType_1.OcxState = CType(resources.GetObject("cInvtType_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cInvtType_1.Size = New System.Drawing.Size(90, 24)
        Me.cInvtType_1.TabIndex = 73
        '
        'cPrecioExtendido_1
        '
        Me.cPrecioExtendido_1.Location = New System.Drawing.Point(162, 280)
        Me.cPrecioExtendido_1.Name = "cPrecioExtendido_1"
        Me.cPrecioExtendido_1.OcxState = CType(resources.GetObject("cPrecioExtendido_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cPrecioExtendido_1.Size = New System.Drawing.Size(90, 24)
        Me.cPrecioExtendido_1.TabIndex = 79
        '
        'cPrecio_1
        '
        Me.cPrecio_1.Location = New System.Drawing.Point(162, 230)
        Me.cPrecio_1.Name = "cPrecio_1"
        Me.cPrecio_1.OcxState = CType(resources.GetObject("cPrecio_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cPrecio_1.Size = New System.Drawing.Size(90, 24)
        Me.cPrecio_1.TabIndex = 78
        '
        'cCantidad_1
        '
        Me.cCantidad_1.Location = New System.Drawing.Point(162, 180)
        Me.cCantidad_1.Name = "cCantidad_1"
        Me.cCantidad_1.OcxState = CType(resources.GetObject("cCantidad_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cCantidad_1.Size = New System.Drawing.Size(90, 24)
        Me.cCantidad_1.TabIndex = 77
        '
        'cInvtDescr_1
        '
        Me.cInvtDescr_1.Location = New System.Drawing.Point(162, 80)
        Me.cInvtDescr_1.Name = "cInvtDescr_1"
        Me.cInvtDescr_1.OcxState = CType(resources.GetObject("cInvtDescr_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cInvtDescr_1.Size = New System.Drawing.Size(201, 24)
        Me.cInvtDescr_1.TabIndex = 76
        '
        'cInvtID_1
        '
        Me.cInvtID_1.Location = New System.Drawing.Point(162, 30)
        Me.cInvtID_1.Name = "cInvtID_1"
        Me.cInvtID_1.OcxState = CType(resources.GetObject("cInvtID_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cInvtID_1.Size = New System.Drawing.Size(90, 24)
        Me.cInvtID_1.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Precio Extendido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo Detalle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Num. Parte"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 535)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Actualizar Precios (AU21010)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cCodigoInterv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cServiceCallId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cDevolucion_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SafGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cInvtType_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cPrecioExtendido_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cPrecio_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cCantidad_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cInvtDescr_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cInvtID_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents Update1 As Interop.SAF.SAFUpdate
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cServiceCallId As Interop.SAF.SAFMaskedText
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cInvtID_1 As Interop.SAF.SAFMaskedText
    Friend WithEvents cInvtDescr_1 As Interop.SAF.SAFMaskedText
    Friend WithEvents cCantidad_1 As Interop.SAF.SAFFloat
    Friend WithEvents cPrecio_1 As Interop.SAF.SAFFloat
    Friend WithEvents cPrecioExtendido_1 As Interop.SAF.SAFFloat
    Friend WithEvents cInvtType_1 As Interop.SAF.SAFCombo
    Friend WithEvents SafGrid1 As Interop.SAF.SAFGrid
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cCodigoInterv As Interop.SAF.SAFMaskedText
    Friend WithEvents cDevolucion_1 As Interop.SAF.SAFCheck
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
