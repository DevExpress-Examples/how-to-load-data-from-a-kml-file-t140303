<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576570/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T140303)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/KMLFileSample/Form1.cs) (VB: [Form1.vb](./VB/KMLFileSample/Form1.vb))**
<!-- default file list end -->
# How to load data from a KML file


<p>This example demonstrates how to load vector items from a <em>KML </em>file.<em><br /></em></p>


<h3>Description</h3>

To solve this task, do the following.<br />1. Create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapVectorFileLayertopic">VectorFileLayer</a> object and&nbsp;add it to&nbsp;the Map control's&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapLayerCollectiontopic">LayerCollection</a> via the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_Layerstopic">MapControl.Layers</a> property.<br />2. Create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapKmlFileLoadertopic">KmlFileLoader</a> object, specify its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapKmlFileLoader_FileUritopic">KmlFileLoader.FileUri</a> property value as a <em>KML</em> file Uri, and assign&nbsp;the object&nbsp;with the&nbsp;vector file layer object via the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorFileLayer_FileLoadertopic">VectorFileLayer.FileLoader</a> property.

<br/>


