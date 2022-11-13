namespace Encantamientos
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxEnchantment = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelEnchantments = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxProperties = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelProperties = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelNotifications = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.buttonAddEnchantment = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnchantment)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Location = new System.Drawing.Point(-4, -7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(891, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(5, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(123, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(638, 61);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ENCHANTMENT DB";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.pictureBoxEnchantment);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.labelEnchantments);
            this.groupBox3.Location = new System.Drawing.Point(12, 181);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(195, 393);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // pictureBoxEnchantment
            // 
            this.pictureBoxEnchantment.Image = global::Encantamientos.Properties.Resources.Enchanted_book_jpeg;
            this.pictureBoxEnchantment.Location = new System.Drawing.Point(139, 11);
            this.pictureBoxEnchantment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEnchantment.Name = "pictureBoxEnchantment";
            this.pictureBoxEnchantment.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxEnchantment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnchantment.TabIndex = 2;
            this.pictureBoxEnchantment.TabStop = false;
            this.pictureBoxEnchantment.Click += new System.EventHandler(this.pictureBoxEnchantment_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(27, 46);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(144, 306);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // labelEnchantments
            // 
            this.labelEnchantments.AutoSize = true;
            this.labelEnchantments.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnchantments.Location = new System.Drawing.Point(12, 21);
            this.labelEnchantments.Name = "labelEnchantments";
            this.labelEnchantments.Size = new System.Drawing.Size(121, 13);
            this.labelEnchantments.TabIndex = 0;
            this.labelEnchantments.Text = "Enchantments";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.pictureBoxProperties);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.labelProperties);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(212, 181);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(659, 393);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // pictureBoxProperties
            // 
            this.pictureBoxProperties.Image = global::Encantamientos.Properties.Resources.wrench;
            this.pictureBoxProperties.Location = new System.Drawing.Point(373, 9);
            this.pictureBoxProperties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProperties.Name = "pictureBoxProperties";
            this.pictureBoxProperties.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxProperties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProperties.TabIndex = 3;
            this.pictureBoxProperties.TabStop = false;
            this.pictureBoxProperties.Click += new System.EventHandler(this.pictureBoxProperties_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(43, 46);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(580, 306);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // labelProperties
            // 
            this.labelProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelProperties.AutoSize = true;
            this.labelProperties.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProperties.Location = new System.Drawing.Point(273, 21);
            this.labelProperties.Name = "labelProperties";
            this.labelProperties.Size = new System.Drawing.Size(97, 13);
            this.labelProperties.TabIndex = 0;
            this.labelProperties.Text = "Properties";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Minecraft", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(207, 127);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(520, 25);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // labelNotifications
            // 
            this.labelNotifications.AutoSize = true;
            this.labelNotifications.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotifications.Location = new System.Drawing.Point(227, 159);
            this.labelNotifications.Name = "labelNotifications";
            this.labelNotifications.Size = new System.Drawing.Size(0, 13);
            this.labelNotifications.TabIndex = 6;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Font = new System.Drawing.Font("Minecraft", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLevel.Location = new System.Drawing.Point(824, 127);
            this.textBoxLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(37, 25);
            this.textBoxLevel.TabIndex = 2;
            this.textBoxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLevel.TextChanged += new System.EventHandler(this.textBoxLevel_TextChanged);
            this.textBoxLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLevel_KeyPress);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(752, 133);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(62, 15);
            this.labelLevel.TabIndex = 8;
            this.labelLevel.Text = "Power";
            // 
            // buttonAddEnchantment
            // 
            this.buttonAddEnchantment.BackColor = System.Drawing.Color.White;
            this.buttonAddEnchantment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEnchantment.FlatAppearance.BorderSize = 0;
            this.buttonAddEnchantment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddEnchantment.Font = new System.Drawing.Font("Minecraft", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEnchantment.Location = new System.Drawing.Point(255, 592);
            this.buttonAddEnchantment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddEnchantment.Name = "buttonAddEnchantment";
            this.buttonAddEnchantment.Size = new System.Drawing.Size(384, 39);
            this.buttonAddEnchantment.TabIndex = 9;
            this.buttonAddEnchantment.Text = "Add enchantment";
            this.buttonAddEnchantment.UseVisualStyleBackColor = false;
            this.buttonAddEnchantment.Click += new System.EventHandler(this.buttonAddEnchantment_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelSearch.Location = new System.Drawing.Point(35, 131);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(149, 21);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Search Bar";
            this.labelSearch.Click += new System.EventHandler(this.labelError_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(144, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(883, 654);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonAddEnchantment);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.labelNotifications);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enchantment DB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnchantment)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelEnchantments;
        private System.Windows.Forms.Label labelProperties;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBoxEnchantment;
        private System.Windows.Forms.PictureBox pictureBoxProperties;
        private System.Windows.Forms.Label labelNotifications;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Button buttonAddEnchantment;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

