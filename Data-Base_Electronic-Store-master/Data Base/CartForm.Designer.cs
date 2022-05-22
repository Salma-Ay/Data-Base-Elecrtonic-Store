
namespace Data_Base
{
    partial class CartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CusID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.CusName = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.CusAge = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.CusPass = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.CusDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdGDV1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Prodcat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CusDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGDV1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(462, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "CARD";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(32, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "BillID";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CusID
            // 
            this.CusID.Location = new System.Drawing.Point(211, 113);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(193, 22);
            this.CusID.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(32, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "ProductName";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // CusName
            // 
            this.CusName.Location = new System.Drawing.Point(211, 189);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(193, 22);
            this.CusName.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(32, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 36);
            this.button6.TabIndex = 8;
            this.button6.Text = "Price";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CusAge
            // 
            this.CusAge.Location = new System.Drawing.Point(211, 253);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(193, 22);
            this.CusAge.TabIndex = 9;
            this.CusAge.TextChanged += new System.EventHandler(this.CusAge_TextChanged);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(32, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(185, 36);
            this.button7.TabIndex = 10;
            this.button7.Text = "Quantity";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // CusPass
            // 
            this.CusPass.Location = new System.Drawing.Point(216, 313);
            this.CusPass.Name = "CusPass";
            this.CusPass.Size = new System.Drawing.Size(193, 22);
            this.CusPass.TabIndex = 11;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(611, 551);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(109, 54);
            this.button11.TabIndex = 4;
            this.button11.Text = "ADD";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button12.Location = new System.Drawing.Point(925, 551);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(118, 54);
            this.button12.TabIndex = 19;
            this.button12.Text = "DELETE";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(766, 551);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(111, 54);
            this.button13.TabIndex = 20;
            this.button13.Text = "EDIT";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // CusDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CusDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CusDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CusDGV.BackgroundColor = System.Drawing.Color.White;
            this.CusDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CusDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CusDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CusDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CusDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CusDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CusDGV.EnableHeadersVisualStyles = false;
            this.CusDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CusDGV.Location = new System.Drawing.Point(525, 611);
            this.CusDGV.Name = "CusDGV";
            this.CusDGV.RowHeadersVisible = false;
            this.CusDGV.RowHeadersWidth = 51;
            this.CusDGV.RowTemplate.Height = 24;
            this.CusDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CusDGV.Size = new System.Drawing.Size(589, 278);
            this.CusDGV.TabIndex = 21;
            this.CusDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CusDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CusDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CusDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CusDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CusDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CusDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CusDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CusDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CusDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CusDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CusDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CusDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CusDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.CusDGV.ThemeStyle.ReadOnly = false;
            this.CusDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CusDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CusDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CusDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CusDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CusDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CusDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(545, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(209, 31);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.Text = "Select Category";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button14.Location = new System.Drawing.Point(266, 391);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(121, 46);
            this.button14.TabIndex = 23;
            this.button14.Text = "Refresh";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(986, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "DATE";
            // 
            // ProdGDV1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProdGDV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdGDV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdGDV1.BackgroundColor = System.Drawing.Color.White;
            this.ProdGDV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdGDV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdGDV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdGDV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProdGDV1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdGDV1.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProdGDV1.EnableHeadersVisualStyles = false;
            this.ProdGDV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdGDV1.Location = new System.Drawing.Point(32, 436);
            this.ProdGDV1.Name = "ProdGDV1";
            this.ProdGDV1.RowHeadersVisible = false;
            this.ProdGDV1.RowHeadersWidth = 51;
            this.ProdGDV1.RowTemplate.Height = 24;
            this.ProdGDV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdGDV1.Size = new System.Drawing.Size(378, 453);
            this.ProdGDV1.TabIndex = 25;
            this.ProdGDV1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProdGDV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdGDV1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdGDV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdGDV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdGDV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdGDV1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdGDV1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdGDV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProdGDV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdGDV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProdGDV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdGDV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdGDV1.ThemeStyle.HeaderStyle.Height = 4;
            this.ProdGDV1.ThemeStyle.ReadOnly = false;
            this.ProdGDV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdGDV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdGDV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProdGDV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdGDV1.ThemeStyle.RowsStyle.Height = 24;
            this.ProdGDV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdGDV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdGDV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdGDV1_CellContentClick);
            // 
            // Prodcat
            // 
            this.Prodcat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prodcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Prodcat.FormattingEnabled = true;
            this.Prodcat.Location = new System.Drawing.Point(32, 399);
            this.Prodcat.Name = "Prodcat";
            this.Prodcat.Size = new System.Drawing.Size(209, 31);
            this.Prodcat.TabIndex = 26;
            this.Prodcat.Text = "Select Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Prodcat);
            this.panel1.Controls.Add(this.ProdGDV1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.CusDGV);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.CusPass);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.CusAge);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.CusName);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.CusID);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(89, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 919);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1316, 975);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CusDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGDV1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CusID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox CusName;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox CusAge;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox CusPass;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private Guna.UI.WinForms.GunaDataGridView CusDGV;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView ProdGDV1;
        private System.Windows.Forms.ComboBox Prodcat;
        private System.Windows.Forms.Panel panel1;
    }
}