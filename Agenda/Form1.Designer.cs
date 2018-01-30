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
            this.pButton3 = new Agenda.PButton();
            this.pButton2 = new Agenda.PButton();
            this.pButton1 = new Agenda.PButton();
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
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 454);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Adriano";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private PButton pButton3;
        private PButton pButton2;
        private PButton pButton1;
    }
}

