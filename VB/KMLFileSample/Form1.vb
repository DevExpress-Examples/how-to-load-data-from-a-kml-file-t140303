Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace KMLFileSample
    Partial Public Class Form1
        Inherits Form

        Private Const filePath As String = "../../kmlFile.kml"

        Public Sub New()
            InitializeComponent()

            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            ' Create a Map control.            
            Dim map As New MapControl() With {.CenterPoint = New GeoPoint(40.689830, -74.045229), .Dock = DockStyle.Fill, .ZoomLevel = 16}
            Me.Controls.Add(map)

            ' Create a tiles layer and add it to map.
            Dim tilesLayer As New ImageTilesLayer() With {.DataProvider = New OpenStreetMapDataProvider()}
            map.Layers.Add(tilesLayer)

            ' Create a file loader.
            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Dim loader As New KmlFileLoader() With {.FileUri = New Uri(baseUri, filePath)}

            ' Create a vector layer and add it to map.
            Dim vectorLayer As New VectorFileLayer() With {.FileLoader = loader}
            map.Layers.Add(vectorLayer)
        End Sub
    End Class

End Namespace
