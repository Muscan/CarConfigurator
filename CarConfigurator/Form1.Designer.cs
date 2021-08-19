
namespace CarConfigurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBoxModel = new System.Windows.Forms.GroupBox();
            this.rdoBtnSkoda = new System.Windows.Forms.RadioButton();
            this.rdoBtnVolvo = new System.Windows.Forms.RadioButton();
            this.rdoBtnDacia = new System.Windows.Forms.RadioButton();
            this.btn1Calculeaza = new System.Windows.Forms.Button();
            this.btn2Calculate = new System.Windows.Forms.Button();
            this.lbl1Rezultate = new System.Windows.Forms.Label();
            this.cmbBoxCuloare = new System.Windows.Forms.ComboBox();
            this.txtBoxAdresa = new System.Windows.Forms.TextBox();
            this.grpBoxMotorizare = new System.Windows.Forms.GroupBox();
            this.rdoBtnBenzina = new System.Windows.Forms.RadioButton();
            this.rdoBtnDiesel = new System.Windows.Forms.RadioButton();
            this.grpBoxModel.SuspendLayout();
            this.grpBoxMotorizare.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxModel
            // 
            this.grpBoxModel.Controls.Add(this.rdoBtnSkoda);
            this.grpBoxModel.Controls.Add(this.rdoBtnVolvo);
            this.grpBoxModel.Controls.Add(this.rdoBtnDacia);
            this.grpBoxModel.Location = new System.Drawing.Point(12, 45);
            this.grpBoxModel.Name = "grpBoxModel";
            this.grpBoxModel.Size = new System.Drawing.Size(250, 125);
            this.grpBoxModel.TabIndex = 0;
            this.grpBoxModel.TabStop = false;
            this.grpBoxModel.Text = "Model";
            // 
            // rdoBtnSkoda
            // 
            this.rdoBtnSkoda.AutoSize = true;
            this.rdoBtnSkoda.Location = new System.Drawing.Point(7, 86);
            this.rdoBtnSkoda.Name = "rdoBtnSkoda";
            this.rdoBtnSkoda.Size = new System.Drawing.Size(111, 24);
            this.rdoBtnSkoda.TabIndex = 2;
            this.rdoBtnSkoda.TabStop = true;
            this.rdoBtnSkoda.Text = "Dacia Papuc";
            this.rdoBtnSkoda.UseVisualStyleBackColor = true;
            // 
            // rdoBtnVolvo
            // 
            this.rdoBtnVolvo.AutoSize = true;
            this.rdoBtnVolvo.Location = new System.Drawing.Point(7, 57);
            this.rdoBtnVolvo.Name = "rdoBtnVolvo";
            this.rdoBtnVolvo.Size = new System.Drawing.Size(113, 24);
            this.rdoBtnVolvo.TabIndex = 1;
            this.rdoBtnVolvo.TabStop = true;
            this.rdoBtnVolvo.Text = "Dacia Logan";
            this.rdoBtnVolvo.UseVisualStyleBackColor = true;
            // 
            // rdoBtnDacia
            // 
            this.rdoBtnDacia.AutoSize = true;
            this.rdoBtnDacia.Location = new System.Drawing.Point(7, 27);
            this.rdoBtnDacia.Name = "rdoBtnDacia";
            this.rdoBtnDacia.Size = new System.Drawing.Size(104, 24);
            this.rdoBtnDacia.TabIndex = 0;
            this.rdoBtnDacia.TabStop = true;
            this.rdoBtnDacia.Text = "Dacia 1310";
            this.rdoBtnDacia.UseVisualStyleBackColor = true;
            // 
            // btn1Calculeaza
            // 
            this.btn1Calculeaza.Location = new System.Drawing.Point(12, 421);
            this.btn1Calculeaza.Name = "btn1Calculeaza";
            this.btn1Calculeaza.Size = new System.Drawing.Size(250, 29);
            this.btn1Calculeaza.TabIndex = 2;
            this.btn1Calculeaza.Text = "Calculeaza";
            this.btn1Calculeaza.UseVisualStyleBackColor = true;
            this.btn1Calculeaza.Click += new System.EventHandler(this.btn1Calculeaza_Click);
            // 
            // btn2Calculate
            // 
            this.btn2Calculate.Location = new System.Drawing.Point(12, 480);
            this.btn2Calculate.Name = "btn2Calculate";
            this.btn2Calculate.Size = new System.Drawing.Size(250, 29);
            this.btn2Calculate.TabIndex = 3;
            this.btn2Calculate.Text = "Reset";
            this.btn2Calculate.UseVisualStyleBackColor = true;
            this.btn2Calculate.Click += new System.EventHandler(this.btn2Calculate_Click);
            // 
            // lbl1Rezultate
            // 
            this.lbl1Rezultate.AutoSize = true;
            this.lbl1Rezultate.Location = new System.Drawing.Point(385, 241);
            this.lbl1Rezultate.Name = "lbl1Rezultate";
            this.lbl1Rezultate.Size = new System.Drawing.Size(166, 20);
            this.lbl1Rezultate.TabIndex = 4;
            this.lbl1Rezultate.Text = "Rezultatele configurarii:";
            this.lbl1Rezultate.Visible = false;
            this.lbl1Rezultate.Click += new System.EventHandler(this.lbl1Rezultate_Click);
            // 
            // cmbBoxCuloare
            // 
            this.cmbBoxCuloare.FormattingEnabled = true;
            this.cmbBoxCuloare.Items.AddRange(new object[] {
            "Rosie",
            "Alba",
            "Verde"});
            this.cmbBoxCuloare.Location = new System.Drawing.Point(645, 154);
            this.cmbBoxCuloare.Name = "cmbBoxCuloare";
            this.cmbBoxCuloare.Size = new System.Drawing.Size(250, 28);
            this.cmbBoxCuloare.TabIndex = 5;
            this.cmbBoxCuloare.Text = "Selecteaza o culoare";
            // 
            // txtBoxAdresa
            // 
            this.txtBoxAdresa.Location = new System.Drawing.Point(12, 12);
            this.txtBoxAdresa.Name = "txtBoxAdresa";
            this.txtBoxAdresa.Size = new System.Drawing.Size(250, 27);
            this.txtBoxAdresa.TabIndex = 6;
            this.txtBoxAdresa.Text = "Name";
            this.txtBoxAdresa.TextChanged += new System.EventHandler(this.txtBoxAdresa_TextChanged);
            // 
            // grpBoxMotorizare
            // 
            this.grpBoxMotorizare.Controls.Add(this.rdoBtnBenzina);
            this.grpBoxMotorizare.Controls.Add(this.rdoBtnDiesel);
            this.grpBoxMotorizare.Location = new System.Drawing.Point(645, 12);
            this.grpBoxMotorizare.Name = "grpBoxMotorizare";
            this.grpBoxMotorizare.Size = new System.Drawing.Size(250, 125);
            this.grpBoxMotorizare.TabIndex = 7;
            this.grpBoxMotorizare.TabStop = false;
            this.grpBoxMotorizare.Text = "Motorizare";
            // 
            // rdoBtnBenzina
            // 
            this.rdoBtnBenzina.AutoSize = true;
            this.rdoBtnBenzina.Location = new System.Drawing.Point(16, 68);
            this.rdoBtnBenzina.Name = "rdoBtnBenzina";
            this.rdoBtnBenzina.Size = new System.Drawing.Size(82, 24);
            this.rdoBtnBenzina.TabIndex = 1;
            this.rdoBtnBenzina.TabStop = true;
            this.rdoBtnBenzina.Text = "Benzina";
            this.rdoBtnBenzina.UseVisualStyleBackColor = true;
            // 
            // rdoBtnDiesel
            // 
            this.rdoBtnDiesel.AutoSize = true;
            this.rdoBtnDiesel.Location = new System.Drawing.Point(16, 27);
            this.rdoBtnDiesel.Name = "rdoBtnDiesel";
            this.rdoBtnDiesel.Size = new System.Drawing.Size(71, 24);
            this.rdoBtnDiesel.TabIndex = 0;
            this.rdoBtnDiesel.TabStop = true;
            this.rdoBtnDiesel.Text = "Diesel";
            this.rdoBtnDiesel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.grpBoxMotorizare);
            this.Controls.Add(this.txtBoxAdresa);
            this.Controls.Add(this.cmbBoxCuloare);
            this.Controls.Add(this.lbl1Rezultate);
            this.Controls.Add(this.btn2Calculate);
            this.Controls.Add(this.btn1Calculeaza);
            this.Controls.Add(this.grpBoxModel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car configurator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxModel.ResumeLayout(false);
            this.grpBoxModel.PerformLayout();
            this.grpBoxMotorizare.ResumeLayout(false);
            this.grpBoxMotorizare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxModel;
        private System.Windows.Forms.Button btn1Calculeaza;
        private System.Windows.Forms.Button btn2Calculate;
        private System.Windows.Forms.Label lbl1Rezultate;
        private System.Windows.Forms.RadioButton rdoBtnSkoda;
        private System.Windows.Forms.RadioButton rdoBtnVolvo;
        private System.Windows.Forms.RadioButton rdoBtnDacia;
        private System.Windows.Forms.ComboBox cmbBoxCuloare;
        private System.Windows.Forms.TextBox txtBoxAdresa;
        private System.Windows.Forms.GroupBox grpBoxMotorizare;
        private System.Windows.Forms.RadioButton rdoBtnBenzina;
        private System.Windows.Forms.RadioButton rdoBtnDiesel;
    }
}

