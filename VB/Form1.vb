Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Data

Namespace DragDropTwoGrids
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim table As DataTable = FillTable()
            SetUpGrid(gridControl1, table)
            SetUpGrid(gridControl2, table.Clone())
        End Sub
        Public Function FillTable() As DataTable
            Dim table As New DataTable()
            table.Columns.Add("Column")
            For i As Integer = 1 To 5
                table.Rows.Add(New Object() { "Item " & i.ToString() })
            Next i
            Return table
        End Function
        Public Sub SetUpGrid(ByVal grid As GridControl, ByVal table As DataTable)
            Dim view As GridView = TryCast(grid.MainView, GridView)
            grid.DataSource = table
            view.OptionsBehavior.Editable = False
        End Sub
    End Class
End Namespace
