<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/390295640/21.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1017584)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

*Files to look at:*
* [Form1.cs](./CS/DXSample/Form1.cs) (VB: [Form1.vb](./VB/DXSample/Form1.vb))
# How to execute an arbitrary action when a WinForms diagram item is clicked
This example demonstrates how to catch the moment when one of diagram's child items is clicked and execute custom code there. The main idea of the implementation is to handle the standard [Click](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.click?view=net-5.0) event for DiagramControl and call the [CalcHitItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.CalcHitItem(System.Drawing.PointF)) method to obtain a clicked element.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=How-to-execute-an-arbitrary-action-when-a-diagram-item-is-clicked-winforms&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=How-to-execute-an-arbitrary-action-when-a-diagram-item-is-clicked-winforms&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
