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
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonTypeAdd);
            flowLayoutPanel1.Controls.Add(buttonTypeUpdate);
            flowLayoutPanel1.Controls.Add(buttonTypeDelete);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(842, 80);
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
            // panel1
            // 
            panel1.Location = new Point(476, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // FormMaterialTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(842, 539);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormMaterialTypes";
            Text = "Типы Материалов";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonTypeAdd;
        private Button buttonTypeUpdate;
        private Button buttonTypeDelete;
        private Panel panel1;
    }
}