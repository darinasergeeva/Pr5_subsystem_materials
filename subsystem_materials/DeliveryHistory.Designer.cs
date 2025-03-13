namespace subsystem_materials
{
    partial class DeliveryHistory
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            labelHistory = new Label();
            panelFill = new Panel();
            dataGridViewHistory = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(labelHistory);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(728, 80);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // labelHistory
            // 
            labelHistory.Location = new Point(10, 20);
            labelHistory.Margin = new Padding(10, 20, 20, 20);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(438, 28);
            labelHistory.TabIndex = 0;
            labelHistory.Text = "История поставок: Наименование поставщика";
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewHistory);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 80);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(728, 303);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistory.BackgroundColor = Color.White;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.Location = new Point(10, 10);
            dataGridViewHistory.MultiSelect = false;
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewHistory.Size = new Size(708, 283);
            dataGridViewHistory.TabIndex = 0;
            // 
            // DeliveryHistory
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(728, 383);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "DeliveryHistory";
            Text = "История поставок";
            Load += DeliveryHistory_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Label labelHistory;
        private Panel panelFill;
        private DataGridView dataGridViewHistory;
    }
}