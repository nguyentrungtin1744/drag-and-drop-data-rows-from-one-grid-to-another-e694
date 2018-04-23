Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DragDropTwoGrids
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataSet1 As System.Data.DataSet
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private splitter1 As System.Windows.Forms.Splitter
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
			' 
			' gridControl1.EmbeddedNavigator
			' 
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(240, 282)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridControl2
			' 
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' gridControl2.EmbeddedNavigator
			' 
			Me.gridControl2.EmbeddedNavigator.Name = ""
			Me.gridControl2.Location = New System.Drawing.Point(240, 0)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(248, 282)
			Me.gridControl2.TabIndex = 1
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(240, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(2, 282)
			Me.splitter1.TabIndex = 2
			Me.splitter1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(488, 282)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			FillTable(dataTable1)
			SetUpGrid(gridControl1)
			SetUpGrid(gridControl2)
			gridControl1.DataSource = dataTable1
			gridControl2.DataSource = dataTable1.Clone()
		End Sub

		Public Sub FillTable(ByVal table As DataTable)
			For i As Integer = 1 To 5
				table.Rows.Add(New Object() {"Item " & i.ToString()})
			Next i
		End Sub

		Public Sub SetUpGrid(ByVal grid As GridControl)
			grid.AllowDrop = True
			AddHandler grid.DragOver, AddressOf grid_DragOver
			AddHandler grid.DragDrop, AddressOf grid_DragDrop
			Dim view As GridView = TryCast(grid.MainView, GridView)
			view.OptionsBehavior.Editable = False
			AddHandler view.MouseMove, AddressOf view_MouseMove
			AddHandler view.MouseDown, AddressOf view_MouseDown
		End Sub

		Private downHitInfo As GridHitInfo = Nothing

		Private Sub view_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim view As GridView = TryCast(sender, GridView)
			downHitInfo = Nothing
			Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
			If Control.ModifierKeys <> Keys.None Then
				Return
			End If
			If e.Button = MouseButtons.Left AndAlso hitInfo.RowHandle >= 0 Then
				downHitInfo = hitInfo
			End If
		End Sub

		Private Sub view_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim view As GridView = TryCast(sender, GridView)
			If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
				Dim dragSize As Size = SystemInformation.DragSize
				Dim dragRect As New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize)

				If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
					Dim row As DataRow = view.GetDataRow(downHitInfo.RowHandle)
					view.GridControl.DoDragDrop(row, DragDropEffects.Move)
					downHitInfo = Nothing
					DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
				End If
			End If
		End Sub

		Private Sub grid_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
			If e.Data.GetDataPresent(GetType(DataRow)) Then
				e.Effect = DragDropEffects.Move
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		Private Sub grid_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
			Dim grid As GridControl = TryCast(sender, GridControl)
			Dim table As DataTable = TryCast(grid.DataSource, DataTable)
			Dim row As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
			If row IsNot Nothing AndAlso table IsNot Nothing AndAlso row.Table IsNot table Then
				table.ImportRow(row)
				row.Delete()
			End If
		End Sub
	End Class
End Namespace
