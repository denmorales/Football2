using Football2.MyDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private FootballContext context { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.context = new FootballContext();
            this.context.Teams.Load();
            this.teamBindingSource.DataSource = this.context.Teams.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.SaveChanges();
            this.context.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.context.SaveChanges();
            dataGridView1.Refresh();
        }

        
    }
}

