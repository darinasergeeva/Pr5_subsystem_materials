using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subsystem_materials
{
    public partial class DeliveryHistory : Form
    {
        private AppContext db;
        public DeliveryHistory()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.SuppliersMaterials.Load();
            this.dataGridViewHistory.DataSource = this.db.SuppliersMaterials.Local.OrderBy(o => o.Material).ToList();

            dataGridViewHistory.Columns["id"].Visible = false;
            dataGridViewHistory.Columns["Material"].Visible = false;
            dataGridViewHistory.Columns["Supplier"].Visible = false;

            dataGridViewHistory.Columns["CountPack"].HeaderText = "Количество упаковок";
            dataGridViewHistory.Columns["DateOfSupply"].HeaderText = "Дата поставки";
            dataGridViewHistory.Columns["CostForPack"].HeaderText = "Цена за упаковку";
            dataGridViewHistory.Columns["QualitySupply"].HeaderText = "Качество поставки";
        }
        private void DeliveryHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
