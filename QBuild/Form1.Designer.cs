namespace QBuild
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
            this.lb_NameOfFunction = new System.Windows.Forms.Label();
            this.gb_treeview = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_populate = new System.Windows.Forms.Button();
            this.treeview_populateData = new System.Windows.Forms.TreeView();
            this.dataGrid_showData = new System.Windows.Forms.DataGridView();
            this.lbl_CurentPart = new System.Windows.Forms.Label();
            this.lbl_ParentChildPart = new System.Windows.Forms.Label();
            this.gb_treeview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_showData)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_NameOfFunction
            // 
            this.lb_NameOfFunction.AutoSize = true;
            this.lb_NameOfFunction.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameOfFunction.Location = new System.Drawing.Point(416, 27);
            this.lb_NameOfFunction.Name = "lb_NameOfFunction";
            this.lb_NameOfFunction.Size = new System.Drawing.Size(593, 35);
            this.lb_NameOfFunction.TabIndex = 0;
            this.lb_NameOfFunction.Text = "Testing Functionality For Tree and DaraGrid";
            this.lb_NameOfFunction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb_treeview
            // 
            this.gb_treeview.Controls.Add(this.lbl_ParentChildPart);
            this.gb_treeview.Controls.Add(this.lbl_CurentPart);
            this.gb_treeview.Controls.Add(this.btn_exit);
            this.gb_treeview.Controls.Add(this.btn_populate);
            this.gb_treeview.Controls.Add(this.treeview_populateData);
            this.gb_treeview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_treeview.Location = new System.Drawing.Point(12, 78);
            this.gb_treeview.Name = "gb_treeview";
            this.gb_treeview.Size = new System.Drawing.Size(1249, 266);
            this.gb_treeview.TabIndex = 1;
            this.gb_treeview.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(589, 195);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(198, 44);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit From Application";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_populate
            // 
            this.btn_populate.Location = new System.Drawing.Point(589, 127);
            this.btn_populate.Name = "btn_populate";
            this.btn_populate.Size = new System.Drawing.Size(198, 44);
            this.btn_populate.TabIndex = 1;
            this.btn_populate.Text = "Populate Data In Tree";
            this.btn_populate.UseVisualStyleBackColor = true;
            this.btn_populate.Click += new System.EventHandler(this.btn_populate_Click);
            // 
            // treeview_populateData
            // 
            this.treeview_populateData.Location = new System.Drawing.Point(27, 24);
            this.treeview_populateData.Name = "treeview_populateData";
            this.treeview_populateData.Size = new System.Drawing.Size(524, 236);
            this.treeview_populateData.TabIndex = 0;
            this.treeview_populateData.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGrid_showData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGrid_showData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_showData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_showData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_showData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_showData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_showData.Location = new System.Drawing.Point(12, 359);
            this.dataGrid_showData.Name = "dataGrid_showData";
            this.dataGrid_showData.ReadOnly = true;
            this.dataGrid_showData.RowHeadersWidth = 62;
            this.dataGrid_showData.RowTemplate.Height = 28;
            this.dataGrid_showData.RowTemplate.ReadOnly = true;
            this.dataGrid_showData.Size = new System.Drawing.Size(1249, 309);
            this.dataGrid_showData.TabIndex = 2;
            // 
            // lbl_CurentPart
            // 
            this.lbl_CurentPart.AutoSize = true;
            this.lbl_CurentPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurentPart.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_CurentPart.Location = new System.Drawing.Point(590, 80);
            this.lbl_CurentPart.Name = "lbl_CurentPart";
            this.lbl_CurentPart.Size = new System.Drawing.Size(0, 20);
            this.lbl_CurentPart.TabIndex = 3;
            // 
            // lbl_ParentChildPart
            // 
            this.lbl_ParentChildPart.AutoSize = true;
            this.lbl_ParentChildPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ParentChildPart.ForeColor = System.Drawing.Color.Turquoise;
            this.lbl_ParentChildPart.Location = new System.Drawing.Point(585, 36);
            this.lbl_ParentChildPart.Name = "lbl_ParentChildPart";
            this.lbl_ParentChildPart.Size = new System.Drawing.Size(0, 20);
            this.lbl_ParentChildPart.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1439, 680);
            this.Controls.Add(this.dataGrid_showData);
            this.Controls.Add(this.gb_treeview);
            this.Controls.Add(this.lb_NameOfFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QBuild";
            this.gb_treeview.ResumeLayout(false);
            this.gb_treeview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_showData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NameOfFunction;
        private System.Windows.Forms.GroupBox gb_treeview;
        private System.Windows.Forms.TreeView treeview_populateData;
        private System.Windows.Forms.DataGridView dataGrid_showData;
        private System.Windows.Forms.Button btn_populate;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_CurentPart;
        private System.Windows.Forms.Label lbl_ParentChildPart;
    }
}

