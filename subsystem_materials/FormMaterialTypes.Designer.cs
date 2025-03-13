namespace subsystem_materials
{
    partial class FormMaterialTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonTypeAdd = new Button();
            buttonTypeUpdate = new Button();
            buttonTypeDelete = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            buttonDeliveryHistory = new Button();
            flowLayoutPanel1.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(buttonTypeAdd);
            flowLayoutPanel1.Controls.Add(buttonTypeUpdate);
            flowLayoutPanel1.Controls.Add(buttonTypeDelete);
            flowLayoutPanel1.Controls.Add(buttonDeliveryHistory);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(842, 61);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.ForeColor = Color.Black;
            buttonTypeAdd.Location = new Point(13, 13);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(150, 35);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            // 
            // buttonTypeUpdate
            // 
            buttonTypeUpdate.ForeColor = Color.Black;
            buttonTypeUpdate.Location = new Point(169, 13);
            buttonTypeUpdate.Name = "buttonTypeUpdate";
            buttonTypeUpdate.Size = new Size(150, 35);
            buttonTypeUpdate.TabIndex = 1;
            buttonTypeUpdate.Text = "Редактировать";
            buttonTypeUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.ForeColor = Color.Black;
            buttonTypeDelete.Location = new Point(325, 13);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(150, 35);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(842, 478);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(822, 458);
            dataGridViewTypes.TabIndex = 0;
            // 
            // buttonDeliveryHistory
            // 
            buttonDeliveryHistory.ForeColor = Color.Black;
            buttonDeliveryHistory.Location = new Point(481, 13);
            buttonDeliveryHistory.Name = "buttonDeliveryHistory";
            buttonDeliveryHistory.Size = new Size(182, 35);
            buttonDeliveryHistory.TabIndex = 3;
            buttonDeliveryHistory.Text = "История поставок";
            buttonDeliveryHistory.UseVisualStyleBackColor = true;
            buttonDeliveryHistory.Click += buttonDeliveryHistory_Click;
            // 
            // FormMaterialTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(842, 539);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMaterialTypes";
            Text = "Типы Материалов";
            Load += FormMaterialTypes_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonTypeAdd;
        private Button buttonTypeUpdate;
        private Button buttonTypeDelete;
        private Panel panelFill;
        private DataGridView dataGridViewTypes;
        private Button buttonDeliveryHistory;
    }
}