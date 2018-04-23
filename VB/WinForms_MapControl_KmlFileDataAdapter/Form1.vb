Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms

Namespace WinForms_MapControl_KmlFileDataAdapter
    Partial Public Class Form1
        Inherits Form

        Private Const filePath As String = "../../kmlFile.kml"

        Private ReadOnly Property KmlLayer() As VectorItemsLayer
            Get
                Return CType(mapControl1.Layers("KmlLayer"), VectorItemsLayer)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

'            #Region "#KmlFileDataAdapter"
            ' Create a KML file data adapter.
            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            KmlLayer.Data = New KmlFileDataAdapter() With {.FileUri = New Uri(baseUri, filePath)}
'            #End Region ' #KmlFileDataAdapter
        End Sub
    End Class
End Namespace
