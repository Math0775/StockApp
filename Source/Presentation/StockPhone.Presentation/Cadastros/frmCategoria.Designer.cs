﻿namespace StockPhone.Presentation.Cadastros
{
    partial class frmCategoria
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtNome = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(chkStatus);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(128, 85);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(116, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(128, 51);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(57, 19);
            chkStatus.TabIndex = 2;
            chkStatus.Text = "Ativo ";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 49);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnSalvar;
        private CheckBox chkStatus;
        private TextBox txtNome;
    }
}