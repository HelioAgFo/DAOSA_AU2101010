Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxAuInterv
Public Class xAuInterv
Inherits SolomonDataObject
< _
DataBinding(PropertyIndex:=0, StringSize:=10) _
> _
Public Property Categoria() As String
     Get
          Return Me.GetPropertyValue("Categoria")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Categoria", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=1, StringSize:=3) _
> _
Public Property CatInterventionCode() As String
     Get
          Return Me.GetPropertyValue("CatInterventionCode")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CatInterventionCode", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=2, StringSize:=10) _
> _
Public Property CodigoInterv() As String
     Get
          Return Me.GetPropertyValue("CodigoInterv")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CodigoInterv", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=3, StringSize:=255) _
> _
Public Property Comentarios() As String
     Get
          Return Me.GetPropertyValue("Comentarios")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Comentarios", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=4) _
> _
Public Property Crtd_DateTime() As Integer
     Get
          Return Me.GetPropertyValue("Crtd_DateTime")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("Crtd_DateTime", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=5, StringSize:=8) _
> _
Public Property Crtd_Prog() As String
     Get
          Return Me.GetPropertyValue("Crtd_Prog")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Crtd_Prog", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=6, StringSize:=10) _
> _
Public Property Crtd_User() As String
     Get
          Return Me.GetPropertyValue("Crtd_User")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Crtd_User", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=7, StringSize:=38) _
> _
Public Property CustObjection() As String
     Get
          Return Me.GetPropertyValue("CustObjection")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CustObjection", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=8, StringSize:=2) _
> _
Public Property CustObjectionCode() As String
     Get
          Return Me.GetPropertyValue("CustObjectionCode")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CustObjectionCode", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=9) _
> _
Public Property Fortuito() As Short
     Get
          Return Me.GetPropertyValue("Fortuito")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("Fortuito", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=10, StringSize:=30) _
> _
Public Property FunctionDescr() As String
     Get
          Return Me.GetPropertyValue("FunctionDescr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("FunctionDescr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=11, StringSize:=3) _
> _
Public Property FunctionDescrCode() As String
     Get
          Return Me.GetPropertyValue("FunctionDescrCode")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("FunctionDescrCode", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=12) _
> _
Public Property InmovilizaUnidad() As Short
     Get
          Return Me.GetPropertyValue("InmovilizaUnidad")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("InmovilizaUnidad", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=13) _
> _
Public Property Lupd_DateTime() As Integer
     Get
          Return Me.GetPropertyValue("Lupd_DateTime")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("Lupd_DateTime", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=14, StringSize:=8) _
> _
Public Property Lupd_Prog() As String
     Get
          Return Me.GetPropertyValue("Lupd_Prog")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Lupd_Prog", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=15, StringSize:=10) _
> _
Public Property Lupd_User() As String
     Get
          Return Me.GetPropertyValue("Lupd_User")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Lupd_User", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=16) _
> _
Public Property NoteID() As Integer
     Get
          Return Me.GetPropertyValue("NoteID")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("NoteID", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=17) _
> _
Public Property OrdenadaPorElCte() As Short
     Get
          Return Me.GetPropertyValue("OrdenadaPorElCte")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("OrdenadaPorElCte", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=18, StringSize:=80) _
> _
Public Property OTSDescr() As String
     Get
          Return Me.GetPropertyValue("OTSDescr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("OTSDescr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=19, StringSize:=4) _
> _
Public Property OTSNumber() As String
     Get
          Return Me.GetPropertyValue("OTSNumber")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("OTSNumber", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=20, StringSize:=80) _
> _
Public Property Requerimiento() As String
     Get
          Return Me.GetPropertyValue("Requerimiento")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Requerimiento", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=21, StringSize:=10) _
> _
Public Property ServiceCallID() As String
     Get
          Return Me.GetPropertyValue("ServiceCallID")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("ServiceCallID", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=22, StringSize:=10) _
> _
Public Property Status() As String
     Get
          Return Me.GetPropertyValue("Status")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Status", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=23, StringSize:=10) _
> _
Public Property Tecnico() As String
     Get
          Return Me.GetPropertyValue("Tecnico")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Tecnico", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=24, StringSize:=10) _
> _
Public Property TipoInterv() As String
     Get
          Return Me.GetPropertyValue("TipoInterv")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TipoInterv", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=25) _
> _
Public Property Total() As Double
     Get
          Return Me.GetPropertyValue("Total")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("Total", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=26, StringSize:=30) _
> _
Public Property User01() As String
     Get
          Return Me.GetPropertyValue("User01")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User01", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=27, StringSize:=30) _
> _
Public Property User02() As String
     Get
          Return Me.GetPropertyValue("User02")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User02", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=28, StringSize:=30) _
> _
Public Property User03() As String
     Get
          Return Me.GetPropertyValue("User03")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User03", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=29, StringSize:=30) _
> _
Public Property User04() As String
     Get
          Return Me.GetPropertyValue("User04")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User04", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=30, StringSize:=10) _
> _
Public Property User05() As String
     Get
          Return Me.GetPropertyValue("User05")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User05", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=31, StringSize:=10) _
> _
Public Property User06() As String
     Get
          Return Me.GetPropertyValue("User06")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User06", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=32, StringSize:=10) _
> _
Public Property User07() As String
     Get
          Return Me.GetPropertyValue("User07")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User07", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=33, StringSize:=10) _
> _
Public Property User08() As String
     Get
          Return Me.GetPropertyValue("User08")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User08", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=34) _
> _
Public Property User09() As Double
     Get
          Return Me.GetPropertyValue("User09")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("User09", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=35) _
> _
Public Property User10() As Double
     Get
          Return Me.GetPropertyValue("User10")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("User10", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=36) _
> _
Public Property User11() As Double
     Get
          Return Me.GetPropertyValue("User11")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("User11", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=37) _
> _
Public Property User12() As Double
     Get
          Return Me.GetPropertyValue("User12")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("User12", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=38) _
> _
Public Property User13() As Integer
     Get
          Return Me.GetPropertyValue("User13")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User13", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=39) _
> _
Public Property User14() As Integer
     Get
          Return Me.GetPropertyValue("User14")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User14", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=40) _
> _
Public Property User15() As Integer
     Get
          Return Me.GetPropertyValue("User15")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User15", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=41) _
> _
Public Property User16() As Integer
     Get
          Return Me.GetPropertyValue("User16")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User16", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=42) _
> _
Public Property User17() As Short
     Get
          Return Me.GetPropertyValue("User17")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("User17", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=43) _
> _
Public Property User18() As Short
     Get
          Return Me.GetPropertyValue("User18")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("User18", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=44) _
> _
Public Property User19() As Short
     Get
          Return Me.GetPropertyValue("User19")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("User19", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=45) _
> _
Public Property User20() As Short
     Get
          Return Me.GetPropertyValue("User20")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("User20", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=46) _
> _
Public Property User21() As Integer
     Get
          Return Me.GetPropertyValue("User21")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User21", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=47) _
> _
Public Property User22() As Integer
     Get
          Return Me.GetPropertyValue("User22")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User22", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=48) _
> _
Public Property User23() As Integer
     Get
          Return Me.GetPropertyValue("User23")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User23", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=49) _
> _
Public Property User24() As Integer
     Get
          Return Me.GetPropertyValue("User24")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User24", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=50, StringSize:=30) _
> _
Public Property zFuture01() As String
     Get
          Return Me.GetPropertyValue("zFuture01")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture01", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=51, StringSize:=30) _
> _
Public Property zFuture02() As String
     Get
          Return Me.GetPropertyValue("zFuture02")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture02", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=52, StringSize:=10) _
> _
Public Property zFuture03() As String
     Get
          Return Me.GetPropertyValue("zFuture03")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture03", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=53, StringSize:=10) _
> _
Public Property zFuture04() As String
     Get
          Return Me.GetPropertyValue("zFuture04")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture04", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=54) _
> _
Public Property zFuture05() As Short
     Get
          Return Me.GetPropertyValue("zFuture05")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("zFuture05", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=55) _
> _
Public Property zFuture06() As Short
     Get
          Return Me.GetPropertyValue("zFuture06")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("zFuture06", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=56) _
> _
Public Property zFuture07() As Double
     Get
          Return Me.GetPropertyValue("zFuture07")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("zFuture07", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=57) _
> _
Public Property zFuture08() As Double
     Get
          Return Me.GetPropertyValue("zFuture08")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("zFuture08", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=58) _
> _
Public Property zFuture09() As Integer
     Get
          Return Me.GetPropertyValue("zFuture09")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture09", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=59) _
> _
Public Property zFuture10() As Integer
     Get
          Return Me.GetPropertyValue("zFuture10")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture10", setval)
     End Set
End Property
 
End Class
    Public bxAuInterv As xAuInterv = New xAuInterv, nxAuInterv As xAuInterv = New xAuInterv, bxAuInterv1 As xAuInterv = New xAuInterv
 
Public CSR_xAuInterv As Short
Public Sub Init_xAuInterv(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
     Call SetAddr(x_Level, "bxAuInterv", bxAuInterv, nxAuInterv)
     If x_Cursor = True Then
            Call SqlCursorEx(CSR_xAuInterv, x_Level, "CSR_xAuInterv", "xAuInterv", "xAuInterv")
     End If
End Sub
 
End Module
