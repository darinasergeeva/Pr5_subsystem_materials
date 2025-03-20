namespace subsystem_materials
{
    partial class FormAdd
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
            buttonSave = new Button();
            labelName = new Label();
            TypeOfSupplier = new Label();
            textBoxTypeofSupplier = new TextBox();
            NameSupplier = new Label();
            textBoxName = new TextBox();
            TIN = new Label();
            textBoxTin = new TextBox();
            flowLayoutPanelBotton = new FlowLayoutPanel();
            buttonCancel = new Button();
            flowLayoutPanelFill = new FlowLayoutPanel();
            checkBoxCurrent = new CheckBox();
            flowLayoutPanelBotton.SuspendLayout();
            flowLayoutPanelFill.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(220, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(13, 13);
            labelName.Margin = new Padding(3);
            labelName.Name = "labelName";
            labelName.Size = new Size(338, 29);
            labelName.TabIndex = 0;
            labelName.Text = "Поставщики";
            // 
            // TypeOfSupplier
            // 
            TypeOfSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypeOfSupplier.Location = new Point(13, 45);
            TypeOfSupplier.Name = "TypeOfSupplier";
            TypeOfSupplier.Size = new Size(201, 29);
            TypeOfSupplier.TabIndex = 1;
            TypeOfSupplier.Text = "Тип постащика";
            // 
            // textBoxTypeofSupplier
            // 
            textBoxTypeofSupplier.Location = new Point(13, 77);
            textBoxTypeofSupplier.Name = "textBoxTypeofSupplier";
            textBoxTypeofSupplier.Size = new Size(338, 33);
            textBoxTypeofSupplier.TabIndex = 2;
            // 
            // NameSupplier
            // 
            NameSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameSupplier.Location = new Point(13, 113);
            NameSupplier.Name = "NameSupplier";
            NameSupplier.Size = new Size(256, 29);
            NameSupplier.TabIndex = 3;
            NameSupplier.Text = "Наименование";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(13, 145);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(338, 33);
            textBoxName.TabIndex = 4;
            // 
            // TIN
            // 
            TIN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TIN.Location = new Point(13, 181);
            TIN.Name = "TIN";
            TIN.Size = new Size(256, 26);
            TIN.TabIndex = 5;
            TIN.Text = "ИНН";
            // 
            // textBoxTin
            // 
            textBoxTin.Location = new Point(13, 210);
            textBoxTin.Name = "textBoxTin";
            textBoxTin.Size = new Size(338, 33);
            textBoxTin.TabIndex = 6;
            // 
            // flowLayoutPanelBotton
            // 
            flowLayoutPanelBotton.AutoSize = true;
            flowLayoutPanelBotton.BackColor = Color.White;
            flowLayoutPanelBotton.Controls.Add(buttonSave);
            flowLayoutPanelBotton.Controls.Add(buttonCancel);
            flowLayoutPanelBotton.Dock = DockStyle.Bottom;
            flowLayoutPanelBotton.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelBotton.Location = new Point(0, 295);
            flowLayoutPanelBotton.Name = "flowLayoutPanelBotton";
            flowLayoutPanelBotton.Size = new Size(373, 41);
            flowLayoutPanelBotton.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(64, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.BackColor = Color.White;
            flowLayoutPanelFill.Controls.Add(labelName);
            flowLayoutPanelFill.Controls.Add(TypeOfSupplier);
            flowLayoutPanelFill.Controls.Add(textBoxTypeofSupplier);
            flowLayoutPanelFill.Controls.Add(NameSupplier);
            flowLayoutPanelFill.Controls.Add(textBoxName);
            flowLayoutPanelFill.Controls.Add(TIN);
            flowLayoutPanelFill.Controls.Add(textBoxTin);
            flowLayoutPanelFill.Controls.Add(checkBoxCurrent);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelFill.Location = new Point(0, 0);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(373, 336);
            flowLayoutPanelFill.TabIndex = 2;
            // 
            // checkBoxCurrent
            // 
            checkBoxCurrent.AutoSize = true;
            checkBoxCurrent.Location = new Point(13, 249);
            checkBoxCurrent.Name = "checkBoxCurrent";
            checkBoxCurrent.Size = new Size(154, 29);
            checkBoxCurrent.TabIndex = 8;
            checkBoxCurrent.Text = "Действующий";
            checkBoxCurrent.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 336);
            Controls.Add(flowLayoutPanelBotton);
            Controls.Add(flowLayoutPanelFill);
            Name = "FormAdd";
            Text = "FormAdd";
            Load += FormAdd_Load;
            flowLayoutPanelBotton.ResumeLayout(false);
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label labelName;
        private Label TypeOfSupplier;
        public TextBox textBoxTypeofSupplier;
        private Label NameSupplier;
        public TextBox textBoxName;
        private Label TIN;
        public TextBox textBoxTin;
        private FlowLayoutPanel flowLayoutPanelBotton;
        private Button buttonCancel;
        private FlowLayoutPanel flowLayoutPanelFill;
        private CheckBox checkBoxCurrent;
    }
}