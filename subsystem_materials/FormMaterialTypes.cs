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
//using AppContext = subsystem_materials.Models.AppContext;

namespace subsystem_materials
{
    public partial class FormMaterialTypes : Form
    {

        private AppContext db;

        public FormMaterialTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Suppliers.Load();
            this.dataGridViewTypes.DataSource = this.db.Suppliers.Local.OrderBy(o => o.NameSupplier).ToList();
            dataGridViewTypes.Columns["id"].Visible = false;
            dataGridViewTypes.Columns["SupplierType"].Visible = false;
            dataGridViewTypes.Columns["SuppliersMaterials"].Visible = false;

            dataGridViewTypes.Columns["IdSupplierType"].HeaderText = "Тип поставщика";
            dataGridViewTypes.Columns["NameSupplier"].HeaderText = "Наименование";
            dataGridViewTypes.Columns["Inn"].HeaderText = "ИНН";
            dataGridViewTypes.Columns["IsActive"].HeaderText = "Действующий";
        }

        private void FormMaterialTypes_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeliveryHistory_Click(object sender, EventArgs e)
        {
            DeliveryHistory history = new DeliveryHistory(); // Создание новой формы
            history.Show(); // Показать форму перехода
        }
    }
}
