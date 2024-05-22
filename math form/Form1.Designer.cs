namespace VizsgaForm
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            debugok = new Label();
            label7 = new Label();
            errorok = new Label();
            label5 = new Label();
            osszes = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            mentesm = new Button();
            vissza = new Button();
            kereses = new Button();
            textBox3 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1697, 580);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 620);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1578, 124);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 808);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1578, 124);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 620);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 3;
            label1.Text = "Message:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 808);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 4;
            label2.Text = "Exception:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(debugok);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(errorok);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(osszes);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(1715, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 580);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statisztika";
            // 
            // debugok
            // 
            debugok.AutoSize = true;
            debugok.Location = new Point(144, 200);
            debugok.Name = "debugok";
            debugok.Size = new Size(27, 32);
            debugok.TabIndex = 5;
            debugok.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 200);
            label7.Name = "label7";
            label7.Size = new Size(117, 32);
            label7.TabIndex = 4;
            label7.Text = "Debugok:";
            // 
            // errorok
            // 
            errorok.AutoSize = true;
            errorok.Location = new Point(144, 132);
            errorok.Name = "errorok";
            errorok.Size = new Size(27, 32);
            errorok.TabIndex = 3;
            errorok.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 132);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 2;
            label5.Text = "Errorok:";
            // 
            // osszes
            // 
            osszes.AutoSize = true;
            osszes.Location = new Point(144, 63);
            osszes.Name = "osszes";
            osszes.Size = new Size(27, 32);
            osszes.TabIndex = 1;
            osszes.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 63);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 0;
            label3.Text = "Összes:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mentesm);
            groupBox2.Controls.Add(vissza);
            groupBox2.Controls.Add(kereses);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(1715, 620);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 312);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Keresés";
            // 
            // mentesm
            // 
            mentesm.Enabled = false;
            mentesm.Location = new Point(6, 250);
            mentesm.Name = "mentesm";
            mentesm.Size = new Size(319, 46);
            mentesm.TabIndex = 7;
            mentesm.Text = "Mentés másként";
            mentesm.UseVisualStyleBackColor = true;
            mentesm.Click += mentesm_Click;
            // 
            // vissza
            // 
            vissza.Location = new Point(176, 181);
            vissza.Name = "vissza";
            vissza.Size = new Size(149, 46);
            vissza.TabIndex = 6;
            vissza.Text = "Visszaállít";
            vissza.UseVisualStyleBackColor = true;
            vissza.Click += vissza_Click;
            // 
            // kereses
            // 
            kereses.Location = new Point(6, 181);
            kereses.Name = "kereses";
            kereses.Size = new Size(164, 46);
            kereses.TabIndex = 5;
            kereses.Text = "Keresés";
            kereses.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 39);
            textBox3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 121);
            label8.Name = "label8";
            label8.Size = new Size(72, 32);
            label8.TabIndex = 3;
            label8.Text = "Érték:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 40);
            comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 61);
            label6.Name = "label6";
            label6.Size = new Size(79, 32);
            label6.TabIndex = 1;
            label6.Text = "Mező:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 61);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2058, 1035);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label debugok;
        private Label label7;
        private Label errorok;
        private Label label5;
        private Label osszes;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox textBox3;
        private Button mentesm;
        private Button vissza;
        private Button kereses;
    }
}