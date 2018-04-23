using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DragDropTwoGrids
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.DataSet dataSet1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataSet1 = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
																		  this.dataTable1});
			// 
			// dataTable1
			// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
																			  this.dataColumn1});
			this.dataTable1.TableName = "Table1";
			// 
			// dataColumn1
			// 
			this.dataColumn1.ColumnName = "Column1";
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
			// 
			// gridControl1.EmbeddedNavigator
			// 
			this.gridControl1.EmbeddedNavigator.Name = "";
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(240, 282);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																										this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// gridControl2
			// 
			this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// gridControl2.EmbeddedNavigator
			// 
			this.gridControl2.EmbeddedNavigator.Name = "";
			this.gridControl2.Location = new System.Drawing.Point(240, 0);
			this.gridControl2.MainView = this.gridView2;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(248, 282);
			this.gridControl2.TabIndex = 1;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																										this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.gridControl2;
			this.gridView2.Name = "gridView2";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(240, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(2, 282);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 282);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.gridControl2);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			FillTable(dataTable1);
			SetUpGrid(gridControl1);
			SetUpGrid(gridControl2);
			gridControl1.DataSource = dataTable1;
			gridControl2.DataSource = dataTable1.Clone();
		}
		
		public void FillTable(DataTable table) {
			for(int i = 1; i <= 5 ; i++)
				table.Rows.Add(new object[] {"Item " + i.ToString()});
		}

		public void SetUpGrid(GridControl grid) {
			grid.AllowDrop = true;
			grid.DragOver += new System.Windows.Forms.DragEventHandler(grid_DragOver);
			grid.DragDrop += new System.Windows.Forms.DragEventHandler(grid_DragDrop);
			GridView view = grid.MainView as GridView;
			view.OptionsBehavior.Editable = false;
			view.MouseMove += new System.Windows.Forms.MouseEventHandler(view_MouseMove);
			view.MouseDown += new System.Windows.Forms.MouseEventHandler(view_MouseDown);
		}

		GridHitInfo downHitInfo = null;

		private void view_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			GridView view = sender as GridView;
			downHitInfo = null;
			GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
			if(Control.ModifierKeys != Keys.None) return;
			if(e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
				downHitInfo = hitInfo;
		}

		private void view_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			GridView view = sender as GridView;
			if(e.Button == MouseButtons.Left && downHitInfo != null) {
				Size dragSize = SystemInformation.DragSize;
				Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
					downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

				if(!dragRect.Contains(new Point(e.X, e.Y))) {
					DataRow row = view.GetDataRow(downHitInfo.RowHandle);
					view.GridControl.DoDragDrop(row, DragDropEffects.Move);
					downHitInfo = null;
					DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
				}
			}
		}

		private void grid_DragOver(object sender, System.Windows.Forms.DragEventArgs e) {
			if(e.Data.GetDataPresent(typeof(DataRow)))
				e.Effect = DragDropEffects.Move;
			else
				e.Effect = DragDropEffects.None;
		}

		private void grid_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
			GridControl grid = sender as GridControl;
			DataTable table = grid.DataSource as DataTable;
			DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
			if(row != null && table != null && row.Table != table) {
				table.ImportRow(row);
				row.Delete();				
			}
		}
	}
}
