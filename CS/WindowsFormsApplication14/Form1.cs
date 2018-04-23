using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Base;

namespace WindowsFormsApplication14
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			data = Enumerable.Range(0, 100).Select(i => new DataClass() { Index = i, Data = (i % 10).ToString() }).ToList();

			linqServerModeSource1.QueryableSource = data.AsQueryable();
		}

		private List<DataClass> data;

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			ColumnView view = gridControl1.FocusedView as ColumnView;
			if (view == null) return;
			IListServer listserver = view.DataSource as IListServer;
			int index = listserver.GetRowIndexByKey(Convert.ToInt32(textEdit1.Text));
			int handle = view.GetRowHandle(index);
			if (handle >= 0)
				view.FocusedRowHandle = handle;
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
	}

	public class DataClass
	{
		public int Index { get; set; }
		public string Data { get; set; }
	}
}
