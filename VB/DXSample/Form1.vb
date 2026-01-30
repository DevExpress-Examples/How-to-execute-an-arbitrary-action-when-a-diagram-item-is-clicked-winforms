Imports DevExpress.XtraDiagram
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DXSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub diagramControl1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim clickedItem = diagramControl1.CalcHitItem(CType(e, MouseEventArgs).Location)
            Dim item As DiagramItem = Nothing
            If CSharpImpl.__Assign(item, TryCast(clickedItem, DiagramItem)) IsNot Nothing Then
                Call MessageBox.Show(owner:=Me, caption:="An item was clicked", text:=$"Item: {item.GetType()} {Environment.NewLine}Position: {item.Position}", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
            End If
        End Sub

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
