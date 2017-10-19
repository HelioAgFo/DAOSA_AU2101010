
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxAuIntPW
Public Class xAuIntPW
Inherits SolomonDataObject
< _
DataBinding(PropertyIndex:=0) _
> _
Public Property Cantidad() As Double
     Get
          Return Me.GetPropertyValue("Cantidad")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("Cantidad", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=1) _
> _
Public Property CantidadEnv() As Double
     Get
          Return Me.GetPropertyValue("CantidadEnv")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("CantidadEnv", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=2) _
> _
Public Property CantidadGar() As Double
     Get
          Return Me.GetPropertyValue("CantidadGar")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("CantidadGar", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=3, StringSize:=10) _
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
DataBinding(PropertyIndex:=4) _
> _
Public Property CostoExtendido() As Double
     Get
          Return Me.GetPropertyValue("CostoExtendido")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("CostoExtendido", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=5) _
> _
Public Property CostoUnitario() As Double
     Get
          Return Me.GetPropertyValue("CostoUnitario")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("CostoUnitario", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=6) _
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
DataBinding(PropertyIndex:=7, StringSize:=8) _
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
DataBinding(PropertyIndex:=8, StringSize:=10) _
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
DataBinding(PropertyIndex:=9) _
> _
Public Property Descto_Date() As Integer
     Get
          Return Me.GetPropertyValue("Descto_Date")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("Descto_Date", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=10) _
> _
Public Property DesctoServ() As Double
     Get
          Return Me.GetPropertyValue("DesctoServ")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("DesctoServ", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=11, StringSize:=10) _
> _
Public Property Descto_User() As String
     Get
          Return Me.GetPropertyValue("Descto_User")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Descto_User", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=12) _
> _
Public Property Descuento() As Double
     Get
          Return Me.GetPropertyValue("Descuento")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("Descuento", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=13) _
> _
Public Property Dif_Date() As Integer
     Get
          Return Me.GetPropertyValue("Dif_Date")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("Dif_Date", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=14, StringSize:=10) _
> _
Public Property Dif_User() As String
     Get
          Return Me.GetPropertyValue("Dif_User")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Dif_User", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=15, StringSize:=60) _
> _
Public Property InvtDescr() As String
     Get
          Return Me.GetPropertyValue("InvtDescr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("InvtDescr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=16, StringSize:=30) _
> _
Public Property InvtID() As String
     Get
          Return Me.GetPropertyValue("InvtID")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("InvtID", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=17, StringSize:=1) _
> _
Public Property InvtType() As String
     Get
          Return Me.GetPropertyValue("InvtType")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("InvtType", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=18) _
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
DataBinding(PropertyIndex:=19, StringSize:=8) _
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
DataBinding(PropertyIndex:=20, StringSize:=10) _
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
DataBinding(PropertyIndex:=21) _
> _
Public Property Precio() As Double
     Get
          Return Me.GetPropertyValue("Precio")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("Precio", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=22) _
> _
Public Property PrecioEnv() As Double
     Get
          Return Me.GetPropertyValue("PrecioEnv")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("PrecioEnv", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=23) _
> _
Public Property PrecioExtendido() As Double
     Get
          Return Me.GetPropertyValue("PrecioExtendido")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("PrecioExtendido", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=24) _
> _
Public Property PrecioGar() As Double
     Get
          Return Me.GetPropertyValue("PrecioGar")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("PrecioGar", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=25, StringSize:=10) _
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
DataBinding(PropertyIndex:=52, StringSize:=30) _
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
DataBinding(PropertyIndex:=53, StringSize:=30) _
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
DataBinding(PropertyIndex:=54, StringSize:=10) _
> _
Public Property zFuture05() As String
     Get
          Return Me.GetPropertyValue("zFuture05")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture05", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=55, StringSize:=10) _
> _
Public Property zFuture06() As String
     Get
          Return Me.GetPropertyValue("zFuture06")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture06", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=56, StringSize:=10) _
> _
Public Property zFuture07() As String
     Get
          Return Me.GetPropertyValue("zFuture07")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture07", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=57, StringSize:=10) _
> _
Public Property zFuture08() As String
     Get
          Return Me.GetPropertyValue("zFuture08")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("zFuture08", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=58) _
> _
Public Property zFuture09() As Double
     Get
          Return Me.GetPropertyValue("zFuture09")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("zFuture09", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=59) _
> _
Public Property zFuture10() As Double
     Get
          Return Me.GetPropertyValue("zFuture10")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("zFuture10", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=60) _
> _
Public Property zFuture11() As Double
     Get
          Return Me.GetPropertyValue("zFuture11")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("zFuture11", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=61) _
> _
Public Property zFuture12() As Double
     Get
          Return Me.GetPropertyValue("zFuture12")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("zFuture12", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=62) _
> _
Public Property zFuture13() As Integer
     Get
          Return Me.GetPropertyValue("zFuture13")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture13", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=63) _
> _
Public Property zFuture14() As Integer
     Get
          Return Me.GetPropertyValue("zFuture14")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture14", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=64) _
> _
Public Property zFuture15() As Integer
     Get
          Return Me.GetPropertyValue("zFuture15")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture15", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=65) _
> _
Public Property zFuture16() As Integer
     Get
          Return Me.GetPropertyValue("zFuture16")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture16", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=66) _
> _
Public Property zFuture17() As Short
     Get
          Return Me.GetPropertyValue("zFuture17")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("zFuture17", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=67) _
> _
Public Property zFuture18() As Short
     Get
          Return Me.GetPropertyValue("zFuture18")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("zFuture18", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=68) _
> _
Public Property zFuture19() As Short
     Get
          Return Me.GetPropertyValue("zFuture19")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("zFuture19", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=69) _
> _
Public Property zFuture20() As Short
     Get
          Return Me.GetPropertyValue("zFuture20")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("zFuture20", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=70) _
> _
Public Property zFuture21() As Integer
     Get
          Return Me.GetPropertyValue("zFuture21")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture21", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=71) _
> _
Public Property zFuture22() As Integer
     Get
          Return Me.GetPropertyValue("zFuture22")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture22", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=72) _
> _
Public Property zFuture23() As Integer
     Get
          Return Me.GetPropertyValue("zFuture23")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture23", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=73) _
> _
Public Property zFuture24() As Integer
     Get
          Return Me.GetPropertyValue("zFuture24")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("zFuture24", setval)
     End Set
End Property
 
End Class
    Public bxAuIntPW As xAuIntPW = New xAuIntPW, nxAuIntPW As xAuIntPW = New xAuIntPW, bxAuIntPW1 As xAuIntPW = New xAuIntPW
 
Public CSR_xAuIntPW As Short
Public Sub Init_xAuIntPW(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
     Call SetAddr(x_Level, "bxAuIntPW", bxAuIntPW, nxAuIntPW)
     If x_Cursor = True Then
            Call SqlCursorEx(CSR_xAuIntPW, x_Level, "CSR_xAuIntPW", "xAuIntPW", "xAuIntPW")
     End If
End Sub
 
End Module
