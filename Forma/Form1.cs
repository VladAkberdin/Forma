﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter1.Fill(this.database1DataSet1.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter1.Fill(this.database1DataSet1.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

    }
}
