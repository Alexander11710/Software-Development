namespace TestWinAlexander
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbIzdatel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHudojestvena = new System.Windows.Forms.RadioButton();
            this.rbNauchna = new System.Windows.Forms.RadioButton();
            this.rbSpravochna = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbTvurda = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведи автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Въведи заглавие";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(204, 63);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(125, 27);
            this.txtAutor.TabIndex = 2;
            this.txtAutor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(226, 123);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 27);
            this.txtTitle.TabIndex = 3;
            // 
            // cmbIzdatel
            // 
            this.cmbIzdatel.FormattingEnabled = true;
            this.cmbIzdatel.Items.AddRange(new object[] {
            "Просвета",
            "Архимед "});
            this.cmbIzdatel.Location = new System.Drawing.Point(41, 43);
            this.cmbIzdatel.Name = "cmbIzdatel";
            this.cmbIzdatel.Size = new System.Drawing.Size(151, 28);
            this.cmbIzdatel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIzdatel);
            this.groupBox1.Location = new System.Drawing.Point(91, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Избери издателство";
            // 
            // rbHudojestvena
            // 
            this.rbHudojestvena.AutoSize = true;
            this.rbHudojestvena.Location = new System.Drawing.Point(21, 27);
            this.rbHudojestvena.Name = "rbHudojestvena";
            this.rbHudojestvena.Size = new System.Drawing.Size(128, 24);
            this.rbHudojestvena.TabIndex = 6;
            this.rbHudojestvena.TabStop = true;
            this.rbHudojestvena.Text = "Художествена";
            this.rbHudojestvena.UseVisualStyleBackColor = true;
            // 
            // rbNauchna
            // 
            this.rbNauchna.AutoSize = true;
            this.rbNauchna.Location = new System.Drawing.Point(21, 76);
            this.rbNauchna.Name = "rbNauchna";
            this.rbNauchna.Size = new System.Drawing.Size(162, 24);
            this.rbNauchna.TabIndex = 7;
            this.rbNauchna.TabStop = true;
            this.rbNauchna.Text = "научно-популярна";
            this.rbNauchna.UseVisualStyleBackColor = true;
            // 
            // rbSpravochna
            // 
            this.rbSpravochna.AutoSize = true;
            this.rbSpravochna.Location = new System.Drawing.Point(21, 128);
            this.rbSpravochna.Name = "rbSpravochna";
            this.rbSpravochna.Size = new System.Drawing.Size(105, 24);
            this.rbSpravochna.TabIndex = 8;
            this.rbSpravochna.TabStop = true;
            this.rbSpravochna.Text = "справочна";
            this.rbSpravochna.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSpravochna);
            this.groupBox2.Controls.Add(this.rbNauchna);
            this.groupBox2.Controls.Add(this.rbHudojestvena);
            this.groupBox2.Location = new System.Drawing.Point(622, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 200);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Жанр";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbTvurda);
            this.groupBox3.Location = new System.Drawing.Point(624, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 166);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вид на корица";
            // 
            // chbTvurda
            // 
            this.chbTvurda.AutoSize = true;
            this.chbTvurda.Location = new System.Drawing.Point(39, 75);
            this.chbTvurda.Name = "chbTvurda";
            this.chbTvurda.Size = new System.Drawing.Size(81, 24);
            this.chbTvurda.TabIndex = 12;
            this.chbTvurda.Text = "Твърда";
            this.chbTvurda.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(94, 371);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(235, 100);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Отпечатай";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 553);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Книжарница";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAutor;
        private TextBox txtTitle;
        private ComboBox cmbIzdatel;
        private GroupBox groupBox1;
        private RadioButton rbHudojestvena;
        private RadioButton rbNauchna;
        private RadioButton rbSpravochna;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox chbTvurda;
        private Button btnPrint;
    }
}