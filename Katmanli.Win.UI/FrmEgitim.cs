using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Katmanli.BL.BusinessClasses;

namespace Katmanli.Win.UI
{
    public partial class FrmEgitim : Form
    {
        public FrmEgitim()
        {
            InitializeComponent();
        }
        EgitimRepository eRep = new EgitimRepository();
        private void FrmEgitim_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eRep.Liste();
        }
    }
}
