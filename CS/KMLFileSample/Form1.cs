using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace KMLFileSample {
    public partial class Form1 : Form {
        const string filePath = "../../kmlFile.kml";
        
        public Form1() {
            InitializeComponent();

            InitializeMap();
        }

        private void InitializeMap() {
            // Create a Map control.            
            MapControl map = new MapControl() {
                CenterPoint = new GeoPoint(40.689830, -74.045229),
                Dock = DockStyle.Fill,
                ZoomLevel = 16
            };
            this.Controls.Add(map);

            // Create a tiles layer and add it to map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer() {
                DataProvider = new OpenStreetMapDataProvider()
            };
            map.Layers.Add(tilesLayer);

            // Create a file loader.
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            KmlFileLoader loader = new KmlFileLoader() { 
                FileUri = new Uri(baseUri, filePath)
            };

            // Create a vector layer and add it to map.
            VectorFileLayer vectorLayer = new VectorFileLayer() {
                FileLoader = loader
            };
            map.Layers.Add(vectorLayer);
        }
    }

}
