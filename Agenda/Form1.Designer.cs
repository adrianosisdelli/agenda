namespace Agenda
{
    partial class Inicial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pButton3 = new Agenda.PButton();
            this.pButton2 = new Agenda.PButton();
            this.pButton1 = new Agenda.PButton();
            this.pButton4 = new Agenda.PButton();
            this.pButton5 = new Agenda.PButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pButton5);
            this.groupBox1.Controls.Add(this.pButton4);
            this.groupBox1.Controls.Add(this.pButton3);
            this.groupBox1.Controls.Add(this.pButton2);
            this.groupBox1.Controls.Add(this.pButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(208, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Médico solicitante obrigatório";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(208, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(133, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Novo nome de usuário";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(208, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(177, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Número de atendimento na guia";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Umidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(424, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 114);
            this.panel1.TabIndex = 3;
            // 
            // pButton3
            // 
            this.pButton3.Location = new System.Drawing.Point(32, 90);
            this.pButton3.Name = "pButton3";
            this.pButton3.Size = new System.Drawing.Size(106, 23);
            this.pButton3.TabIndex = 0;
            this.pButton3.Text = "Consulta CNPJ";
            this.pButton3.UseVisualStyleBackColor = true;
            // 
            // pButton2
            // 
            this.pButton2.Location = new System.Drawing.Point(32, 61);
            this.pButton2.Name = "pButton2";
            this.pButton2.Size = new System.Drawing.Size(106, 23);
            this.pButton2.TabIndex = 0;
            this.pButton2.Text = "Deletar";
            this.pButton2.UseVisualStyleBackColor = true;
            // 
            // pButton1
            // 
            this.pButton1.Location = new System.Drawing.Point(32, 32);
            this.pButton1.Name = "pButton1";
            this.pButton1.Size = new System.Drawing.Size(106, 23);
            this.pButton1.TabIndex = 0;
            this.pButton1.Text = "Nova tarefa";
            this.pButton1.UseVisualStyleBackColor = true;
            // 
            // pButton4
            // 
            this.pButton4.Location = new System.Drawing.Point(32, 119);
            this.pButton4.Name = "pButton4";
            this.pButton4.Size = new System.Drawing.Size(106, 23);
            this.pButton4.TabIndex = 0;
            this.pButton4.Text = "Consulta CPF";
            this.pButton4.UseVisualStyleBackColor = true;
            // 
            // pButton5
            // 
            this.pButton5.Location = new System.Drawing.Point(32, 148);
            this.pButton5.Name = "pButton5";
            this.pButton5.Size = new System.Drawing.Size(106, 23);
            this.pButton5.TabIndex = 0;
            this.pButton5.Text = "Consulta Saldo";
            this.pButton5.UseVisualStyleBackColor = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Adriano";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private PButton pButton3;
        private PButton pButton2;
        private PButton pButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private PButton pButton5;
        private PButton pButton4;
    }
}

