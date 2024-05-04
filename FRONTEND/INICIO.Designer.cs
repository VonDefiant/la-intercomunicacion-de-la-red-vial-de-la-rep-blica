namespace la_intercomunicacion_de_la_red_vial_de_la_república
{
    partial class INICIO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox11 = new GroupBox();
            label4 = new Label();
            lugaresview = new DataGridView();
            groupBox10 = new GroupBox();
            NOMUNILABEL = new Label();
            groupBox9 = new GroupBox();
            MAPADEPABOX = new PictureBox();
            groupBox8 = new GroupBox();
            distancialabel = new Label();
            groupBox7 = new GroupBox();
            POBLALABEL = new Label();
            groupBox6 = new GroupBox();
            CABECERALABEL = new Label();
            groupBox5 = new GroupBox();
            DEPAPREVIOSVIEW = new DataGridView();
            groupBox4 = new GroupBox();
            label3 = new Label();
            lugareslejanosview = new DataGridView();
            groupBox3 = new GroupBox();
            label2 = new Label();
            lugarescercanosview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lugaresview).BeginInit();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MAPADEPABOX).BeginInit();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DEPAPREVIOSVIEW).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lugareslejanosview).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lugarescercanosview).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(200, 19);
            label1.TabIndex = 2;
            label1.Text = "Seleccione un Departamento";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(185, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 73);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(groupBox11);
            groupBox2.Controls.Add(groupBox10);
            groupBox2.Controls.Add(groupBox9);
            groupBox2.Controls.Add(groupBox8);
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(12, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1322, 851);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(label4);
            groupBox11.Controls.Add(lugaresview);
            groupBox11.Location = new Point(1057, 90);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(253, 184);
            groupBox11.TabIndex = 8;
            groupBox11.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(25, 19);
            label4.Name = "label4";
            label4.Size = new Size(184, 19);
            label4.TabIndex = 5;
            label4.Text = "LUGARES TURISTICOS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lugaresview
            // 
            lugaresview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lugaresview.Location = new Point(12, 44);
            lugaresview.Name = "lugaresview";
            lugaresview.RowTemplate.Height = 25;
            lugaresview.Size = new Size(229, 126);
            lugaresview.TabIndex = 4;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(NOMUNILABEL);
            groupBox10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox10.ForeColor = Color.White;
            groupBox10.Location = new Point(16, 173);
            groupBox10.Name = "groupBox10";
            groupBox10.RightToLeft = RightToLeft.No;
            groupBox10.Size = new Size(253, 67);
            groupBox10.TabIndex = 10;
            groupBox10.TabStop = false;
            groupBox10.Text = "CANTIDAD DE MUNICIPIOS";
            groupBox10.UseWaitCursor = true;
            // 
            // NOMUNILABEL
            // 
            NOMUNILABEL.AutoSize = true;
            NOMUNILABEL.Location = new Point(22, 31);
            NOMUNILABEL.Name = "NOMUNILABEL";
            NOMUNILABEL.Size = new Size(17, 19);
            NOMUNILABEL.TabIndex = 0;
            NOMUNILABEL.Text = "*";
            NOMUNILABEL.UseWaitCursor = true;
            NOMUNILABEL.Click += NOMUNILABEL_Click;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(MAPADEPABOX);
            groupBox9.Location = new Point(347, 96);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(640, 560);
            groupBox9.TabIndex = 13;
            groupBox9.TabStop = false;
            // 
            // MAPADEPABOX
            // 
            MAPADEPABOX.InitialImage = (Image)resources.GetObject("MAPADEPABOX.InitialImage");
            MAPADEPABOX.Location = new Point(17, 22);
            MAPADEPABOX.Name = "MAPADEPABOX";
            MAPADEPABOX.Size = new Size(611, 524);
            MAPADEPABOX.SizeMode = PictureBoxSizeMode.StretchImage;
            MAPADEPABOX.TabIndex = 12;
            MAPADEPABOX.TabStop = false;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(distancialabel);
            groupBox8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(955, 23);
            groupBox8.Name = "groupBox8";
            groupBox8.RightToLeft = RightToLeft.No;
            groupBox8.Size = new Size(234, 67);
            groupBox8.TabIndex = 11;
            groupBox8.TabStop = false;
            groupBox8.Text = "DISTANCIA DE LA CAPITAL";
            groupBox8.UseWaitCursor = true;
            // 
            // distancialabel
            // 
            distancialabel.AutoSize = true;
            distancialabel.Location = new Point(15, 31);
            distancialabel.Name = "distancialabel";
            distancialabel.Size = new Size(17, 19);
            distancialabel.TabIndex = 2;
            distancialabel.Text = "1";
            distancialabel.TextAlign = ContentAlignment.MiddleCenter;
            distancialabel.UseWaitCursor = true;
            distancialabel.Click += distancialabel_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(POBLALABEL);
            groupBox7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(688, 23);
            groupBox7.Name = "groupBox7";
            groupBox7.RightToLeft = RightToLeft.No;
            groupBox7.Size = new Size(261, 67);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "POBLACION ESTIMADA";
            groupBox7.UseWaitCursor = true;
            // 
            // POBLALABEL
            // 
            POBLALABEL.AutoSize = true;
            POBLALABEL.Location = new Point(22, 31);
            POBLALABEL.Name = "POBLALABEL";
            POBLALABEL.Size = new Size(17, 19);
            POBLALABEL.TabIndex = 1;
            POBLALABEL.Text = "1";
            POBLALABEL.UseWaitCursor = true;
            POBLALABEL.Click += POBLALABEL_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(CABECERALABEL);
            groupBox6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(421, 23);
            groupBox6.Name = "groupBox6";
            groupBox6.RightToLeft = RightToLeft.No;
            groupBox6.Size = new Size(261, 67);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "CABECERA DEPARTAMENTAL";
            groupBox6.UseWaitCursor = true;
            // 
            // CABECERALABEL
            // 
            CABECERALABEL.AutoSize = true;
            CABECERALABEL.Location = new Point(79, 31);
            CABECERALABEL.Name = "CABECERALABEL";
            CABECERALABEL.Size = new Size(0, 19);
            CABECERALABEL.TabIndex = 0;
            CABECERALABEL.TextAlign = ContentAlignment.MiddleCenter;
            CABECERALABEL.UseWaitCursor = true;
            CABECERALABEL.Click += CABECERALABEL_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(DEPAPREVIOSVIEW);
            groupBox5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(16, 673);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1286, 163);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "DEPARTAMAENTOS PREVIOS";
            // 
            // DEPAPREVIOSVIEW
            // 
            DEPAPREVIOSVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DEPAPREVIOSVIEW.Location = new Point(9, 38);
            DEPAPREVIOSVIEW.Name = "DEPAPREVIOSVIEW";
            DEPAPREVIOSVIEW.RowTemplate.Height = 25;
            DEPAPREVIOSVIEW.Size = new Size(1265, 108);
            DEPAPREVIOSVIEW.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(lugareslejanosview);
            groupBox4.Location = new Point(1057, 280);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(253, 387);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 19);
            label3.Name = "label3";
            label3.Size = new Size(189, 38);
            label3.TabIndex = 5;
            label3.Text = "TOP 10 LUGARES\r\nLEJANOS A LA CAPITAL";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lugareslejanosview
            // 
            lugareslejanosview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lugareslejanosview.Location = new Point(8, 61);
            lugareslejanosview.Name = "lugareslejanosview";
            lugareslejanosview.RowTemplate.Height = 25;
            lugareslejanosview.Size = new Size(233, 317);
            lugareslejanosview.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lugarescercanosview);
            groupBox3.Location = new Point(16, 261);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(253, 406);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 19);
            label2.Name = "label2";
            label2.Size = new Size(205, 38);
            label2.TabIndex = 5;
            label2.Text = "TOP 10 LUGARES\r\nCERCANOS A LA CAPITAL";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lugarescercanosview
            // 
            lugarescercanosview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lugarescercanosview.Location = new Point(8, 61);
            lugarescercanosview.Name = "lugarescercanosview";
            lugarescercanosview.RowTemplate.Height = 25;
            lugarescercanosview.Size = new Size(233, 330);
            lugarescercanosview.TabIndex = 4;
            lugarescercanosview.CellContentClick += lugarescercanosview_CellContentClick;
            // 
            // INICIO
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(1346, 870);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "INICIO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RED VIAL DE LA REPÚBLICA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lugaresview).EndInit();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MAPADEPABOX).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DEPAPREVIOSVIEW).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lugareslejanosview).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lugarescercanosview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView lugarescercanosview;
        private Label label2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Label label3;
        private DataGridView lugareslejanosview;
        private GroupBox groupBox6;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private Label distancialabel;
        private Label POBLALABEL;
        private Label CABECERALABEL;
        private DataGridView DEPAPREVIOSVIEW;
        private PictureBox MAPADEPABOX;
        private GroupBox groupBox9;
        private GroupBox groupBox11;
        private Label label4;
        private DataGridView lugaresview;
        private GroupBox groupBox10;
        private Label NOMUNILABEL;
    }
}