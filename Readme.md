
*Files to look at:*
* [Form1.cs](./CS/DXSample/Form1.cs) (VB: [Form1.vb](./VB/DXSample/Form1.vb))
# How to execute an arbitrary action when a diagram item is clicked
This example demonstrates how to catch the moment when one of diagram's child items is clicked and execute custom code there. The main idea of the implementation is to handle the standard [Click](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.click?view=net-5.0) event for DiagramControl and call the [CalcHitItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.CalcHitItem(System.Drawing.PointF)) method to obtain a clicked element.
