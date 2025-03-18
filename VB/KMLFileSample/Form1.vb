Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace KMLFileSample

    Public Partial Class Form1
        Inherits Form

        Const filePath As String = "../../kmlFile.kml"

        Public Sub New()
            InitializeComponent()
            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            ' Create a Map control.            
            Dim map As MapControl = New MapControl() With {.CenterPoint = New GeoPoint(40.689830, -74.045229), .Dock = DockStyle.Fill, .ZoomLevel = 16}
            Me.Controls.Add(map)
            ' Create a tiles layer and add it to map.
            Dim tilesLayer As ImageTilesLayer = New ImageTilesLayer() With {.DataProvider = New OpenStreetMapDataProvider()}
            map.Layers.Add(tilesLayer)
            ' Create a file loader.
            Dim baseUri As Uri = New Uri(Reflection.Assembly.GetEntryAssembly().Location)
            Dim loader As KmlFileLoader = New KmlFileLoader() With {.FileUri = New Uri(baseUri, filePath)}
            ' Create a vector layer and add it to map.
            Dim vectorLayer As VectorFileLayer = New VectorFileLayer() With {.FileLoader = loader}
            map.Layers.Add(vectorLayer)
        End Sub
    End Class
End Namespace
