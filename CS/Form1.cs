using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;

namespace DragDropTwoGrids {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            DataTable table = FillTable();
            SetUpGrid(gridControl1, table);
            SetUpGrid(gridControl2, table.Clone());
        }
        public DataTable FillTable() {
            DataTable table = new DataTable();
            table.Columns.Add("Column");
            for (int i = 1; i <= 5; i++)
                table.Rows.Add(new object[] { "Item " + i.ToString() });
            return table;
        }
        public void SetUpGrid(GridControl grid, DataTable table) {
            GridView view = grid.MainView as GridView;
            grid.DataSource = table;
            view.OptionsBehavior.Editable = false;
        }
    }
}
