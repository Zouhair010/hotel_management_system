namespace hotel__managment
{
    partial class Hotel
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            txbnompren = new TextBox();
            txbcin = new TextBox();
            txbtel = new TextBox();
            txbaddres = new TextBox();
            txbnmchmbr = new TextBox();
            btreserver = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btverifier = new Button();
            label1 = new Label();
            label2 = new Label();
            bttotal = new Button();
            dataGridView1 = new DataGridView();
            nom = new DataGridViewTextBoxColumn();
            cin = new DataGridViewTextBoxColumn();
            adress = new DataGridViewTextBoxColumn();
            tele = new DataGridViewTextBoxColumn();
            dateentr = new DataGridViewTextBoxColumn();
            datsort = new DataGridViewTextBoxColumn();
            numcham = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btfnreserv = new Button();
            btactualiser = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txbnompren
            // 
            txbnompren.ForeColor = SystemColors.MenuText;
            txbnompren.Location = new Point(52, 47);
            txbnompren.Name = "txbnompren";
            txbnompren.PlaceholderText = "inserer le nom et prenom";
            txbnompren.Size = new Size(153, 25);
            txbnompren.TabIndex = 0;
            txbnompren.Tag = "";
            txbnompren.TextAlign = HorizontalAlignment.Center;
            txbnompren.TextChanged += txbnompren_TextChanged;
            // 
            // txbcin
            // 
            txbcin.ForeColor = SystemColors.MenuText;
            txbcin.Location = new Point(52, 88);
            txbcin.Name = "txbcin";
            txbcin.PlaceholderText = "inserer le CIN";
            txbcin.Size = new Size(153, 25);
            txbcin.TabIndex = 1;
            txbcin.TextAlign = HorizontalAlignment.Center;
            // 
            // txbtel
            // 
            txbtel.ForeColor = SystemColors.MenuText;
            txbtel.Location = new Point(52, 129);
            txbtel.Name = "txbtel";
            txbtel.PlaceholderText = "inserer le numero de Tel";
            txbtel.Size = new Size(153, 25);
            txbtel.TabIndex = 2;
            txbtel.TextAlign = HorizontalAlignment.Center;
            // 
            // txbaddres
            // 
            txbaddres.ForeColor = SystemColors.MenuText;
            txbaddres.Location = new Point(52, 170);
            txbaddres.Name = "txbaddres";
            txbaddres.PlaceholderText = "inserer l'adresse";
            txbaddres.Size = new Size(153, 25);
            txbaddres.TabIndex = 3;
            txbaddres.TextAlign = HorizontalAlignment.Center;
            txbaddres.TextChanged += txbaddres_TextChanged;
            // 
            // txbnmchmbr
            // 
            txbnmchmbr.ForeColor = SystemColors.MenuText;
            txbnmchmbr.Location = new Point(344, 126);
            txbnmchmbr.Name = "txbnmchmbr";
            txbnmchmbr.PlaceholderText = "inserer numero de chamber";
            txbnmchmbr.Size = new Size(154, 25);
            txbnmchmbr.TabIndex = 7;
            txbnmchmbr.TextAlign = HorizontalAlignment.Center;
            // 
            // btreserver
            // 
            btreserver.BackColor = Color.SpringGreen;
            btreserver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btreserver.ForeColor = SystemColors.ControlText;
            btreserver.Location = new Point(523, 170);
            btreserver.Name = "btreserver";
            btreserver.Size = new Size(89, 33);
            btreserver.TabIndex = 8;
            btreserver.Text = "reserver";
            btreserver.UseVisualStyleBackColor = false;
            btreserver.Click += btreserver_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton1.Location = new Point(45, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 21);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "individuel";
            radioButton1.TextAlign = ContentAlignment.BottomCenter;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(45, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 21);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "familiale";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // btverifier
            // 
            btverifier.BackColor = Color.GreenYellow;
            btverifier.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btverifier.ForeColor = SystemColors.ControlText;
            btverifier.Location = new Point(148, 46);
            btverifier.Name = "btverifier";
            btverifier.Size = new Size(88, 30);
            btverifier.TabIndex = 11;
            btverifier.Text = "verifier";
            btverifier.UseVisualStyleBackColor = false;
            btverifier.Click += btverifier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 87);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 16;
            label1.Text = "date sortant :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 48);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 17;
            label2.Text = "date entrant :";
            label2.Click += label2_Click;
            // 
            // bttotal
            // 
            bttotal.BackColor = Color.Pink;
            bttotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttotal.ForeColor = SystemColors.ControlText;
            bttotal.Location = new Point(148, 66);
            bttotal.Name = "bttotal";
            bttotal.Size = new Size(116, 33);
            bttotal.TabIndex = 18;
            bttotal.Text = "total prd";
            bttotal.UseVisualStyleBackColor = false;
            bttotal.Click += bttotal_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nom, cin, adress, tele, dateentr, datsort, numcham });
            dataGridView1.Location = new Point(62, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(881, 183);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nom
            // 
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            nom.DefaultCellStyle = dataGridViewCellStyle10;
            nom.HeaderText = "Nom et prenom";
            nom.Name = "nom";
            nom.Width = 120;
            // 
            // cin
            // 
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            cin.DefaultCellStyle = dataGridViewCellStyle11;
            cin.HeaderText = "CIN";
            cin.Name = "cin";
            cin.Width = 120;
            // 
            // adress
            // 
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            adress.DefaultCellStyle = dataGridViewCellStyle12;
            adress.HeaderText = "Adress";
            adress.Name = "adress";
            adress.Width = 120;
            // 
            // tele
            // 
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            tele.DefaultCellStyle = dataGridViewCellStyle13;
            tele.HeaderText = "Num de tele";
            tele.Name = "tele";
            tele.Width = 120;
            // 
            // dateentr
            // 
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dateentr.DefaultCellStyle = dataGridViewCellStyle14;
            dateentr.HeaderText = "Date dentrant";
            dateentr.Name = "dateentr";
            dateentr.Width = 120;
            // 
            // datsort
            // 
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            datsort.DefaultCellStyle = dataGridViewCellStyle15;
            datsort.HeaderText = "Date sortant";
            datsort.Name = "datsort";
            datsort.Width = 120;
            // 
            // numcham
            // 
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            numcham.DefaultCellStyle = dataGridViewCellStyle16;
            numcham.HeaderText = "Numero de chamber";
            numcham.Name = "numcham";
            numcham.Width = 120;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(344, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 25);
            dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(344, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(154, 25);
            dateTimePicker2.TabIndex = 21;
            // 
            // btfnreserv
            // 
            btfnreserv.BackColor = Color.Thistle;
            btfnreserv.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btfnreserv.ForeColor = SystemColors.ControlText;
            btfnreserv.ImageAlign = ContentAlignment.TopCenter;
            btfnreserv.Location = new Point(148, 27);
            btfnreserv.Name = "btfnreserv";
            btfnreserv.Size = new Size(116, 33);
            btfnreserv.TabIndex = 22;
            btfnreserv.Text = "fin reservation";
            btfnreserv.TextImageRelation = TextImageRelation.ImageAboveText;
            btfnreserv.UseVisualStyleBackColor = false;
            btfnreserv.Click += btfnreserv_Click;
            // 
            // btactualiser
            // 
            btactualiser.BackColor = Color.Khaki;
            btactualiser.BackgroundImageLayout = ImageLayout.Stretch;
            btactualiser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btactualiser.ForeColor = SystemColors.ControlText;
            btactualiser.Location = new Point(855, 30);
            btactualiser.Name = "btactualiser";
            btactualiser.Size = new Size(88, 33);
            btactualiser.TabIndex = 23;
            btactualiser.Text = "actualiser";
            btactualiser.UseVisualStyleBackColor = false;
            btactualiser.Click += btactualiser_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(414, 182);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 21);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.Text = "familiale";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton4.Location = new Point(414, 156);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(88, 21);
            radioButton4.TabIndex = 24;
            radioButton4.TabStop = true;
            radioButton4.Text = "individuel";
            radioButton4.TextAlign = ContentAlignment.BottomCenter;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(txbaddres);
            groupBox1.Controls.Add(txbcin);
            groupBox1.Controls.Add(txbtel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(txbnmchmbr);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(btreserver);
            groupBox1.Controls.Add(txbnompren);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(169, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 233);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "La reservation";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(btverifier);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HighlightText;
            groupBox2.Location = new Point(876, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 109);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Verifiez la chamber";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(btactualiser);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HighlightText;
            groupBox3.Location = new Point(169, 359);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(999, 300);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Donnees client";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btfnreserv);
            groupBox4.Controls.Add(bttotal);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.HighlightText;
            groupBox4.Location = new Point(876, 193);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(292, 117);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Autre operations";
            // 
            // Hotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1285, 653);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Hotel";
            Text = "Hotel";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbnompren;
        private TextBox txbcin;
        private TextBox txbtel;
        private TextBox txbaddres;
        private TextBox txbnmchmbr;
        private TextBox txbnomberelem;
        private Button btreserver;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btverifier;
        private Label label1;
        private Label label2;
        private Button bttotal;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btfnreserv;
        private Button btactualiser;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn cin;
        private DataGridViewTextBoxColumn adress;
        private DataGridViewTextBoxColumn tele;
        private DataGridViewTextBoxColumn dateentr;
        private DataGridViewTextBoxColumn datsort;
        private DataGridViewTextBoxColumn numcham;
        private GroupBox groupBox4;
    }
}
