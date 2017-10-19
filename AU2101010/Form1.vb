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
Option Explicit On
Option Strict Off
Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Protected m_IsInitializing As Boolean
	Protected ReadOnly Property IsInitializing() As Boolean
		Get
			Return m_IsInitializing
		End Get
    End Property

    Public Spread1 As Short

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

      
        ' Load all the forms needed for this application
        'Call LoadForm(fSL01001)
        Dim sServiceCallId As String
        Dim sCodigoInterv As String
        ' Initialize the application as a Microsoft Dynamics SL Application
        Call ApplInit()

        Call Init_xAuInterv(LEVEL0, True)
        Call Init_xAuIntPW(LEVEL1, True)
        'bxAuIntPW.InvtID = ""
        ' Call Set Address for the tables that will have fields displayed on the scree,
        ' or that you would like customization manager to be able to use
        'Call SetAddr(LEVEL0, "bxSLSample", bxSLSample, nxSLSample)

        ' Define the cursors that are used by the application

        ' This is an example for a table in the System Database
        'Call SqlCursor(c1, LEVEL0 + SqlSystemDb)

        ' This is an example for a table in an Application Database
        'Call SqlCursor(c1, LEVEL0 )


        ' Call the screen init function
        sServiceCallId = ApplGetParmValue(PRMSECTION_VBRDT, "ServiceCallId")
        sCodigoInterv = ApplGetParmValue(PRMSECTION_VBRDT, "CodigoInterv")


        bxAuInterv.ServiceCallID = sServiceCallId
        bxAuInterv.CodigoInterv = sCodigoInterv

        Call ScreenInit()
        Spread1 = DetailSetup(CSR_xAuIntPW, SafGrid1, bxAuIntPW.AddressOf("User13"), bxAuIntPW, PNULL, PNULL, PNULL)

        Call SetProps(Me, cInvtType_1, cInvtType_1, "Enabled", True)
        Call SetProps(Me, cInvtID_1, cInvtID_1, "Enabled", True)
        Call SetProps(Me, cInvtDescr_1, cInvtDescr_1, "Enabled", True)
        Call SetProps(Me, cCantidad_1, cCantidad_1, "Enabled", True)
        Call SetProps(Me, cPrecioExtendido_1, cPrecioExtendido_1, "Enabled", True)
        Call SetProps(Me, cDevolucion_1, cDevolucion_1, "Visible", False)
        Call InitBuffer()

        With Timer1
            .Interval = 10000
            .Enabled = True
            .Start()
        End With

    End Sub
    Private Sub InitBuffer()
        With bxAuInterv
            .Categoria = ""
            .CatInterventionCode = ""
            '.CodigoInterv = ""
            .Comentarios = ""
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            .CustObjection = ""
            .CustObjectionCode = ""
            .Fortuito = 0
            .FunctionDescr = ""
            .FunctionDescrCode = ""
            .InmovilizaUnidad = 0
            .Lupd_DateTime = bpes.Today
            .Lupd_Prog = bpes.ScrnNbr
            .Lupd_User = bpes.UserId
            .NoteID = 0
            .OrdenadaPorElCte = 0
            .OTSDescr = ""
            .OTSNumber = ""
            .Requerimiento = ""
            '.ServiceCallID = ""
            .Status = ""
            .Tecnico = ""
            .TipoInterv = ""
            .Total = 0
            .User01 = ""
            .User02 = ""
            .User03 = ""
            .User04 = ""
            .User05 = ""
            .User06 = ""
            .User07 = ""
            .User08 = ""
            .User09 = 0
            .User10 = 0
            .User11 = 0
            .User12 = 0
            .User13 = 0
            .User14 = 0
            .User15 = 0
            .User16 = 0
            .User17 = 0
            .User18 = 0
            .User19 = 0
            .User20 = 0
            .User21 = 0
            .User22 = 0
            .User23 = 0
            .User24 = 0
            .zFuture01 = ""
            .zFuture02 = ""
            .zFuture03 = ""
            .zFuture04 = ""
            .zFuture05 = 0
            .zFuture06 = 0
            .zFuture07 = 0
            .zFuture08 = 0
            .zFuture09 = 0
            .zFuture10 = 0
        End With
        With bxAuIntPW
            .Cantidad = 0
            .CantidadEnv = 0
            .CantidadGar = 0
            .CodigoInterv = ""
            .CostoExtendido = 0
            .CostoUnitario = 0
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            .Descto_Date = 0
            .DesctoServ = 0
            .Descto_User = 0
            .Descuento = 0
            .Dif_Date = 0
            .Dif_User = ""
            .InvtDescr = ""
            .InvtID = ""
            .InvtType = ""
            .Lupd_DateTime = bpes.Today
            .Lupd_Prog = bpes.ScrnNbr
            .Lupd_User = bpes.UserId
            .Precio = 0
            .PrecioEnv = 0
            .PrecioExtendido = 0
            .PrecioGar = 0
            .ServiceCallID = ""
            .User01 = ""
            .User02 = ""
            .User03 = ""
            .User04 = ""
            .User05 = "0"
            .User06 = ""
            .User07 = ""
            .User08 = ""
            .User09 = 0
            .User10 = 0
            .User11 = 0
            .User12 = 0
            .User13 = 0
            .User14 = 0
            .User15 = 0
            .User16 = 0
            .User17 = 0
            .User18 = 0
            .User19 = 0
            .User20 = 0
            .User21 = 0
            .User22 = 0
            .User23 = 0
            .User24 = 0
            .zFuture01 = ""
            .zFuture02 = ""
            .zFuture03 = ""
            .zFuture04 = ""
            .zFuture05 = ""
            .zFuture06 = ""
            .zFuture07 = ""
            .zFuture08 = ""
            .zFuture09 = 0
            .zFuture10 = 0
            .zFuture11 = 0
            .zFuture12 = 0
            .zFuture13 = 0
            .zFuture14 = 0
            .zFuture15 = 0
            .zFuture16 = 0
            .zFuture17 = 0
            .zFuture18 = 0
            .zFuture19 = 0
            .zFuture20 = 0
            .zFuture21 = 0
            .zFuture22 = 0
            .zFuture23 = 0
            .zFuture24 = 0
        End With

        With nxAuInterv
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            .Lupd_DateTime = bpes.Today
            .Lupd_Prog = bpes.ScrnNbr
            .Lupd_User = bpes.UserId
        End With
        With nxAuIntPW
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            .Lupd_DateTime = bpes.Today
            .Lupd_Prog = bpes.ScrnNbr
            .Lupd_User = bpes.UserId
        End With

    End Sub
    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Update1_UpdateEvent(Level As Short, InsertFlg As Short, LevelsDone As Short, LevelsLeft As Short, ByRef RetVal As Short) Handles Update1.UpdateEvent

        Dim RecFound As Integer
        Dim MemMaintFlg As Integer
        Dim Nbr_OfInvt_Proceesed As Integer
        Dim Orden As String
        Dim Devolucion As String
        Dim Item As String
        Dim Precio As String
        Dim Descripcion As String
        Dim sSql As String

        If Level = LEVEL1 Then

            bxAuIntPW1 = bxAuIntPW
            Call Status(StartProcess, False, "", 0)
            'Explicitly initialize processing counter to zero BEFORE calling
            'ProcValidBatch() for the FIRST time.
            Nbr_OfInvt_Proceesed = 0
            RecFound = MFirst(Spread1, MemMaintFlg)
            While (RecFound = 0)
                Orden = bxAuInterv.ServiceCallID
                Item = bxAuIntPW.InvtID
                Precio = bxAuIntPW.Precio
                Descripcion = bxAuIntPW.InvtDescr

                sSql = "xCPRCorrigePrecio " + SParm(Orden) + SParm(Item) + SParm(Precio) + SParm(Descripcion)
                'Call MessBox(sSql, MB_OK, "Store Procedure")
                Call sql(c1, sSql)
                'Stop
                'Cuando quiere hacer devoluciones
                Devolucion = bxAuIntPW.User13
                If Devolucion = "1" Then
                    sSql = "xsp_Devolver_wrk_wrk2" + SParm(Orden) + SParm(Item) + SParm(Precio) + SParm(Descripcion)
                    Call sql(c1, sSql)
                End If
                RecFound = MNext(Spread1, MemMaintFlg)

            End While
            'Stop
            Call Status(EndProcess, False, "", 0)
            'Redisplay the grid with the modified contents of the memory array.
            RecFound = MFirst(Spread1, MemMaintFlg)
            Spread1 = DetailSetup(CSR_xAuIntPW, SafGrid1, bxAuIntPW.AddressOf("User13"), bxAuIntPW, PNULL, PNULL, PNULL)
            Call MDisplay(Spread1)
        End If
    End Sub

    Private Sub cInvtID_1_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cInvtID_1.ChkEvent

    End Sub

    Private Sub SafGrid1_LineChkEvent(ByRef Action As Short, ByRef MaintFlg As Short, ByRef RetVal As Short) Handles SafGrid1.LineChkEvent

    End Sub

    Private Sub cServiceCallId_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cServiceCallId.ChkEvent
        'serr = PVChkFetch1(PNULL, CSR_xAuInterv, ChkStrg, bxAuIntPW)
        'If serr = NOTFOUND Then
        '    RetVal = NoAutoChk
        'End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub cCodigoInterv_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cCodigoInterv.ChkEvent
        serr = PVChkFetch1(PNULL, CSR_xAuInterv, ChkStrg, bxAuInterv)
        If serr = NOTFOUND Then
            RetVal = NoAutoChk
        End If
        Call SetProps(Me, cCantidad_1, cCantidad_1, "Enabled", False)
        'Call SetDefaults(PNULL, PNULL, PNULL)
        Call SetProps(Me, cInvtType_1, cInvtType_1, "Enabled", False)
        Call SetProps(Me, cInvtID_1, cInvtID_1, "Enabled", False)
        Call SetProps(Me, cInvtDescr_1, cInvtDescr_1, "Enabled", False)
        Call SetProps(Me, cCantidad_1, cCantidad_1, "Enabled", False)
        Call SetProps(Me, cPrecioExtendido_1, cPrecioExtendido_1, "Enabled", False)

        Dim sServiceCallId As String
        Dim sCodigoInterv As String

        sServiceCallId = bxAuInterv.ServiceCallID
        sCodigoInterv = ChkStrg
        'Stop
        Dim sSql As String
        sSql = "select * from AUINTERVPARTESWRK2 WHERE SERVICECALLID =" + SParm(Trim(sServiceCallId)) + " AND CODIGOINTERV = " + SParm(Trim(sCodigoInterv))
        Call sql(c1, sSql)
        serr1 = SFetch1(c1, bAuIntervPartesWrk21)
        'serr1 = SqlFetch1(c1, sSql, bAuIntervPartesWrk2)
        If serr1 <> NOTFOUND Then
            Call SetProps(Me, cDevolucion_1, cDevolucion_1, "Visible", True)
        Else
            Call SetProps(Me, cDevolucion_1, cDevolucion_1, "Visible", False)
        End If

    End Sub

    Private Sub SafUpdate1_CancelEvent(Level As Short, ByRef RetVal As Short)
        Stop
    End Sub

    Private Sub cPrecio_1_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cPrecio_1.ChkEvent
        'Stop
        Call SetProps(Me, cPrecioExtendido_1, cPrecioExtendido_1, "Enabled", True)
        bxAuIntPW.PrecioExtendido = bxAuIntPW.Cantidad * ChkStrg
        Call SetProps(Me, cPrecioExtendido_1, cPrecioExtendido_1, "Enabled", False)
    End Sub

    Private Sub cDevolucion_1_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cDevolucion_1.ChkEvent
        'Stop
        'bxAuIntPW.User09 = ChkStrg
    End Sub
End Class
