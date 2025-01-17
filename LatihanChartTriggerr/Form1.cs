using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanChartTriggerr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.JanFeb' table. You can move, or remove it, as needed.
            this.janFebTableAdapter.Fill(this.database1DataSet.JanFeb);

        }

        private void chart1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Tahun2020";
            chart1.Series[0].YValueMembers = "Tahun2020";

            chart1.Series[1].XValueMember = "Tahun2021";
            chart1.Series[1].YValueMembers = "Tahun2021";

            chart1.Series[2].XValueMember = "Tahun2022";
            chart1.Series[2].YValueMembers = "Tahun2022";

            chart1.Series[3].XValueMember = "Tahun2023";
            chart1.Series[3].YValueMembers = "Tahun2023";

            chart1.DataSource = database1DataSet.JanFeb;
            chart1.DataBind();
        }
    }
}
