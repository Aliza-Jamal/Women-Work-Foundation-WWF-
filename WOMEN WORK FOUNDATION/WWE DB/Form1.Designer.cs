namespace WWE_DB
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tables_panel = new System.Windows.Forms.Panel();
            this.BUY_NOW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SHOW_ITEMS = new System.Windows.Forms.Button();
            this.SHOW_MAKER = new System.Windows.Forms.Button();
            this.SHOW_BUYER = new System.Windows.Forms.Button();
            this.SHOW_EMP = new System.Windows.Forms.Button();
            this.SHIPPING_WOKERS = new System.Windows.Forms.Button();
            this.tables_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tables_panel
            // 
            this.tables_panel.BackColor = System.Drawing.Color.DarkCyan;
            this.tables_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tables_panel.Controls.Add(this.BUY_NOW);
            this.tables_panel.Controls.Add(this.dataGridView1);
            this.tables_panel.Location = new System.Drawing.Point(53, 92);
            this.tables_panel.Name = "tables_panel";
            this.tables_panel.Size = new System.Drawing.Size(847, 470);
            this.tables_panel.TabIndex = 0;
            this.tables_panel.Visible = false;
            // 
            // BUY_NOW
            // 
            this.BUY_NOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BUY_NOW.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUY_NOW.ForeColor = System.Drawing.Color.Cyan;
            this.BUY_NOW.Location = new System.Drawing.Point(327, 371);
            this.BUY_NOW.Name = "BUY_NOW";
            this.BUY_NOW.Size = new System.Drawing.Size(192, 64);
            this.BUY_NOW.TabIndex = 1;
            this.BUY_NOW.Text = "ORDER HERE";
            this.BUY_NOW.UseVisualStyleBackColor = false;
            this.BUY_NOW.Visible = false;
            this.BUY_NOW.Click += new System.EventHandler(this.BUY_NOW_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Cyan;
            this.dataGridView1.Location = new System.Drawing.Point(177, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SHOW_ITEMS
            // 
            this.SHOW_ITEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SHOW_ITEMS.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW_ITEMS.ForeColor = System.Drawing.Color.Cyan;
            this.SHOW_ITEMS.Location = new System.Drawing.Point(3, 45);
            this.SHOW_ITEMS.Name = "SHOW_ITEMS";
            this.SHOW_ITEMS.Size = new System.Drawing.Size(159, 32);
            this.SHOW_ITEMS.TabIndex = 1;
            this.SHOW_ITEMS.Text = "SHOW ITEMS";
            this.SHOW_ITEMS.UseVisualStyleBackColor = false;
            this.SHOW_ITEMS.Click += new System.EventHandler(this.SHOW_ITEMS_Click);
            // 
            // SHOW_MAKER
            // 
            this.SHOW_MAKER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SHOW_MAKER.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW_MAKER.ForeColor = System.Drawing.Color.Cyan;
            this.SHOW_MAKER.Location = new System.Drawing.Point(168, 45);
            this.SHOW_MAKER.Name = "SHOW_MAKER";
            this.SHOW_MAKER.Size = new System.Drawing.Size(177, 32);
            this.SHOW_MAKER.TabIndex = 2;
            this.SHOW_MAKER.Text = "SHOW MAKER\r\n";
            this.SHOW_MAKER.UseVisualStyleBackColor = false;
            this.SHOW_MAKER.Click += new System.EventHandler(this.SHOW_MAKER_Click);
            // 
            // SHOW_BUYER
            // 
            this.SHOW_BUYER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SHOW_BUYER.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW_BUYER.ForeColor = System.Drawing.Color.Cyan;
            this.SHOW_BUYER.Location = new System.Drawing.Point(351, 45);
            this.SHOW_BUYER.Name = "SHOW_BUYER";
            this.SHOW_BUYER.Size = new System.Drawing.Size(159, 31);
            this.SHOW_BUYER.TabIndex = 3;
            this.SHOW_BUYER.Text = "SHOW BUYER";
            this.SHOW_BUYER.UseVisualStyleBackColor = false;
            this.SHOW_BUYER.Click += new System.EventHandler(this.SHOW_BUYER_Click);
            // 
            // SHOW_EMP
            // 
            this.SHOW_EMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SHOW_EMP.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW_EMP.ForeColor = System.Drawing.Color.Cyan;
            this.SHOW_EMP.Location = new System.Drawing.Point(516, 45);
            this.SHOW_EMP.Name = "SHOW_EMP";
            this.SHOW_EMP.Size = new System.Drawing.Size(210, 32);
            this.SHOW_EMP.TabIndex = 4;
            this.SHOW_EMP.Text = "SHOW EMPLOYEES";
            this.SHOW_EMP.UseVisualStyleBackColor = false;
            this.SHOW_EMP.Click += new System.EventHandler(this.SHOW_EMP_Click);
            // 
            // SHIPPING_WOKERS
            // 
            this.SHIPPING_WOKERS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SHIPPING_WOKERS.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHIPPING_WOKERS.ForeColor = System.Drawing.Color.Cyan;
            this.SHIPPING_WOKERS.Location = new System.Drawing.Point(732, 45);
            this.SHIPPING_WOKERS.Name = "SHIPPING_WOKERS";
            this.SHIPPING_WOKERS.Size = new System.Drawing.Size(205, 32);
            this.SHIPPING_WOKERS.TabIndex = 5;
            this.SHIPPING_WOKERS.Text = "SHOW SHIPPERS";
            this.SHIPPING_WOKERS.UseVisualStyleBackColor = false;
            this.SHIPPING_WOKERS.Click += new System.EventHandler(this.SHIPPING_WOKERS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.SHIPPING_WOKERS);
            this.Controls.Add(this.SHOW_EMP);
            this.Controls.Add(this.SHOW_BUYER);
            this.Controls.Add(this.SHOW_MAKER);
            this.Controls.Add(this.SHOW_ITEMS);
            this.Controls.Add(this.tables_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tables_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tables_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BUY_NOW;
        private System.Windows.Forms.Button SHOW_ITEMS;
        private System.Windows.Forms.Button SHOW_MAKER;
        private System.Windows.Forms.Button SHOW_BUYER;
        private System.Windows.Forms.Button SHOW_EMP;
        private System.Windows.Forms.Button SHIPPING_WOKERS;
    }
}

