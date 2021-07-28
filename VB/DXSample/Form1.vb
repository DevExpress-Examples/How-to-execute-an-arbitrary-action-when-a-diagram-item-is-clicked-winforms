Imports DevExpress.XtraDiagram
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Forms

Namespace DXSample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub diagramControl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles diagramControl1.Click
			Dim clickedItem = diagramControl1.CalcHitItem(CType(e, MouseEventArgs).Location)
			Dim tempVar As Boolean = TypeOf clickedItem Is DiagramItem
			Dim item As DiagramItem = If(tempVar, CType(clickedItem, DiagramItem), Nothing)
			If tempVar Then
				MessageBox.Show(owner:=Me, caption:= "An item was clicked", text:= $"Item: {item.GetType()}{Environment.NewLine}Position: {item.Position}", buttons:= MessageBoxButtons.OK, icon:= MessageBoxIcon.Information)
			End If
		End Sub
	End Class
End Namespace
