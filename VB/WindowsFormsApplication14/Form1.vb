Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base

Namespace WindowsFormsApplication14
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			data = Enumerable.Range(0, 100).Select(Function(i) New DataClass() With {.Index = i, .Data = (i Mod 10).ToString()}).ToList()

			linqServerModeSource1.QueryableSource = data.AsQueryable()
		End Sub

		Private data As List(Of DataClass)

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim view As ColumnView = TryCast(gridControl1.FocusedView, ColumnView)
			If view Is Nothing Then
				Return
			End If
			Dim listserver As IListServer = TryCast(view.DataSource, IListServer)
			Dim index As Integer = listserver.GetRowIndexByKey(Convert.ToInt32(textEdit1.Text))
			Dim handle As Integer = view.GetRowHandle(index)
			If handle >= 0 Then
				view.FocusedRowHandle = handle
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class

	Public Class DataClass
		Private privateIndex As Integer
		Public Property Index() As Integer
			Get
				Return privateIndex
			End Get
			Set(ByVal value As Integer)
				privateIndex = value
			End Set
		End Property
		Private privateData As String
		Public Property Data() As String
			Get
				Return privateData
			End Get
			Set(ByVal value As String)
				privateData = value
			End Set
		End Property
	End Class
End Namespace
