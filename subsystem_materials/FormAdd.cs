using subsystem_materials.Models;
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

    public partial class FormAdd : Form
    {
        // Свойства для получения данных из текстовых полей
        public string SupplierName => textBoxName.Text;
        public string SupplierInn => textBoxTin.Text;
        public int SupplierTypeId => int.Parse(textBoxTypeofSupplier.Text);
        public bool IsCurrentChecked => checkBoxCurrent.Checked;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
        //public bool IsCurrentChecked
        //{
        //    get { return checkBoxCurrent.Checked; }
        //}
        public FormAdd(Supplier supplier) : this() 
        {
            // Заполняем поля данными существующего поставщика
            textBoxName.Text = supplier.NameSupplier;
            textBoxTin.Text = supplier.Inn;
            textBoxTypeofSupplier.Text = supplier.IdSupplierType.ToString();
            checkBoxCurrent.Checked = supplier.IsActive;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Проверяем, заполнены ли обязательные поля
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxTin.Text) ||
                string.IsNullOrWhiteSpace(textBoxTypeofSupplier.Text))
            {
                MessageBox.Show("Ошибка! Все поля должны быть заполнены.");
                return; // Выходим из метода, если поля не заполнены
            }

            // Закрываем форму и возвращаем результат OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
