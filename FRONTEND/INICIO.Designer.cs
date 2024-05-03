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
            gpsgo = new Button();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 126);
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
            groupBox1.Location = new Point(140, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 73);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(gpsgo);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(12, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1322, 767);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // gpsgo
            // 
            gpsgo.BackColor = Color.Transparent;
            gpsgo.BackgroundImage = Properties.Resources.maps_and_location;
            gpsgo.BackgroundImageLayout = ImageLayout.Zoom;
            gpsgo.Location = new Point(190, 110);
            gpsgo.Name = "gpsgo";
            gpsgo.Size = new Size(88, 86);
            gpsgo.TabIndex = 8;
            gpsgo.UseVisualStyleBackColor = false;
            gpsgo.Click += gpsgo_Click;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(19, 202);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(224, 278);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // INICIO
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(1346, 786);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "INICIO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RED VIAL DE LA REPÚBLICA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button gpsgo;
        private GroupBox groupBox3;
    }
}