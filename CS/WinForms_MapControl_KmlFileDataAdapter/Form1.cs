using DevExpress.XtraMap;
using System;
using System.Windows.Forms;

namespace WinForms_MapControl_KmlFileDataAdapter {
    public partial class Form1 : Form {
        const string filePath = "../../kmlFile.kml";

        VectorItemsLayer KmlLayer { get { return (VectorItemsLayer)mapControl1.Layers["KmlLayer"]; } }

        public Form1() {
            InitializeComponent();

            #region #KmlFileDataAdapter
            // Create a KML file data adapter.
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            KmlLayer.Data =  new KmlFileDataAdapter() {
                FileUri = new Uri(baseUri, filePath)
            };
            #endregion #KmlFileDataAdapter
        }
    }
}
