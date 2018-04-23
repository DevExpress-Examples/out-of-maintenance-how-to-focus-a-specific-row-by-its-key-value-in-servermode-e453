Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication14
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.linqServerModeSource1 = New DevExpress.Data.Linq.LinqServerModeSource()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colIndex = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.DataSource = Me.linqServerModeSource1
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(12, 41)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.ServerMode = True
			Me.gridControl1.Size = New System.Drawing.Size(533, 340)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' linqServerModeSource1
			' 
			Me.linqServerModeSource1.ElementType = GetType(WindowsFormsApplication14.DataClass)
			Me.linqServerModeSource1.KeyExpression = "Index"
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colIndex, Me.colData})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colIndex
			' 
			Me.colIndex.Caption = "Index"
			Me.colIndex.FieldName = "Index"
			Me.colIndex.Name = "colIndex"
			Me.colIndex.Visible = True
			Me.colIndex.VisibleIndex = 0
			' 
			' colData
			' 
			Me.colData.Caption = "Data"
			Me.colData.FieldName = "Data"
			Me.colData.Name = "colData"
			Me.colData.Visible = True
			Me.colData.VisibleIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 12)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Find"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(93, 12)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.Mask.EditMask = "d0"
			Me.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.textEdit1.Size = New System.Drawing.Size(100, 20)
			Me.textEdit1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(557, 393)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private linqServerModeSource1 As DevExpress.Data.Linq.LinqServerModeSource
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private colIndex As DevExpress.XtraGrid.Columns.GridColumn
		Private colData As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

