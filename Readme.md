<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576570/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T140303)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# Maps for WinForms - Load Data from a KML File

This example loads vector items from a `KML` file.

## Implementation Details

For this, create a [KmlFileDataAdapter](https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapKmlFileDataAdaptertopic) object. Specify its [KmlFileDataAdapter.FileUri](https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapKmlFileDataAdapter_FileUritopic) property. Then assign this object as the [VectorItemsLayer.Data](https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Datatopic) property value.

## Files to Review

* [Form1.cs](./CS/WinForms_MapControl_KmlFileDataAdapter/Form1.cs) (VB: [Form1.vb](./VB/WinForms_MapControl_KmlFileDataAdapter/Form1.vb))
* [Program.cs](./CS/WinForms_MapControl_KmlFileDataAdapter/Program.cs) (VB: [Program.vb](./VB/WinForms_MapControl_KmlFileDataAdapter/Program.vb))

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-load-data-from-a-kml-file&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-load-data-from-a-kml-file&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
