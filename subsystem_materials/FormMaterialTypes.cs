using Microsoft.EntityFrameworkCore;
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
            DeliveryHistory history = new DeliveryHistory();
            history.Show();
        }
        private void LoadSuppliers()
        {
            // Загружаем всех поставщиков из базы данных, сортируя их по имени
            var suppliers = db.Suppliers.OrderBy(o => o.NameSupplier).ToList();

            // Устанавливаем источник данных для DataGridView, чтобы отобразить список поставщиков
            this.dataGridViewTypes.DataSource = suppliers;
        }

        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            using (FormAdd formAdd = new FormAdd())
            {
                DialogResult result = formAdd.ShowDialog(this);

                // Если пользователь нажал "Отмена", выходим из метода
                if (result == DialogResult.Cancel)
                    return;

                // Проверяем, заполнены ли обязательные поля
                if (string.IsNullOrWhiteSpace(formAdd.textBoxName.Text) ||
                    string.IsNullOrWhiteSpace(formAdd.textBoxTin.Text) ||
                    string.IsNullOrWhiteSpace(formAdd.textBoxTypeofSupplier.Text))
                {
                    // Если хотя бы одно поле пустое, выводим сообщение об ошибке
                    MessageBox.Show("Ошибка! Все поля должны быть заполнены.");
                    return; // Выходим из метода
                }

                try
                {
                    // Преобразуем текст из поля типа поставщика в целое число
                    int supplierTypeId = int.Parse(formAdd.textBoxTypeofSupplier.Text);

                    // Создаем новый объект Supplier и заполняем его свойства
                    Supplier supplier = new Supplier
                    {
                        NameSupplier = formAdd.textBoxName.Text, // Имя поставщика
                        Inn = formAdd.textBoxTin.Text, // ИНН поставщика
                        IdSupplierType = (short)supplierTypeId, // Идентификатор типа поставщика, преобразованный в short
                        IsActive = formAdd.IsCurrentChecked // Статус активности, полученный из CheckBox
                    };

                    // Добавляем нового поставщика в контекст базы данных
                    db.Suppliers.Add(supplier);
                    // Сохраняем изменения в базе данных
                    db.SaveChanges();
                    // Выводим сообщение об успешном добавлении
                    MessageBox.Show("Новый поставщик добавлен");

                    // Обновляем список поставщиков в DataGridView
                    LoadSuppliers();
                }
                catch (FormatException ex)
                {
                    // Если произошла ошибка преобразования, выводим сообщение об ошибке
                    MessageBox.Show("Ошибка! Поля 'Тип поставщика' должны содержать только числа.");
                }
            }
        }

        private void buttonTypeUpdate_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли поставщик в DataGridView
            if (dataGridViewTypes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите поставщика для редактирования.");
                return; // Выходим из метода, если ничего не выбрано
            }

            // Получаем выбранного поставщика
            var selectedRow = dataGridViewTypes.SelectedRows[0];
            int supplierId = (int)selectedRow.Cells["Id"].Value;

            // Загружаем данные выбранного поставщика из базы данных
            var supplier = db.Suppliers.Find(supplierId);
            if (supplier == null)
            {
                MessageBox.Show("Ошибка: поставщик не найден.");
                return; // Выходим из метода, если поставщик не найден
            }

            // Открываем форму редактирования и передаем данные поставщика
            using (FormAdd formEdit = new FormAdd(supplier))
            {
                if (formEdit.ShowDialog(this) == DialogResult.OK)
                {
                    // Если пользователь нажал "ОК", сохраняем изменения
                    supplier.NameSupplier = formEdit.SupplierName; // Обновляем имя
                    supplier.Inn = formEdit.SupplierInn; // Обновляем ИНН
                    supplier.IdSupplierType = (short)formEdit.SupplierTypeId; // Обновляем тип поставщика
                    supplier.IsActive = formEdit.IsCurrentChecked; // Обновляем статус активности

                    // Сохраняем изменения в базе данных
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Данные поставщика обновлены.");
                        LoadSuppliers(); // Обновляем список поставщиков
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении данных: {ex.InnerException?.Message ?? ex.Message}");
                    }
                }
            }
        }

        private void buttonTypeDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли поставщик в DataGridView
            if (dataGridViewTypes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите поставщика для удаления.");
                return; // Выходим из метода, если ничего не выбрано
            }

            // Получаем выбранного поставщика
            var selectedRow = dataGridViewTypes.SelectedRows[0];
            int supplierId = (int)selectedRow.Cells["Id"].Value; // Предполагаем, что у вас есть столбец Id

            // Загружаем данные выбранного поставщика из базы данных
            var supplier = db.Suppliers.Find(supplierId);
            if (supplier == null)
            {
                MessageBox.Show("Ошибка: поставщик не найден.");
                return; // Выходим из метода, если поставщик не найден
            }

            // Запрашиваем подтверждение у пользователя
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить этого поставщика?",
                                                 "Подтверждение удаления",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Удаляем выбранного поставщика из контекста базы данных
                db.Suppliers.Remove(supplier);

                // Сохраняем изменения в базе данных
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Поставщик удален.");
                    LoadSuppliers(); // Обновляем список поставщиков
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.InnerException?.Message ?? ex.Message}");
                }
            }
        }
    }
}



