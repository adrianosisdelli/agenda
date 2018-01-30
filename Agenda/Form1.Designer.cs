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
            this.pButton3 = new Agenda.PButton();
            this.pButton2 = new Agenda.PButton();
            this.pButton1 = new Agenda.PButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.checkBox1.Location = new System.Drawing.Point(208, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Médico solicitante obrigatório";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(208, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(133, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Novo nome de usuário";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(208, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(177, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Número de atendimento na guia";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 460);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Adriano";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
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
    }
}

