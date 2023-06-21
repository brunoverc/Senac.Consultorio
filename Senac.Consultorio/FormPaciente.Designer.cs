﻿namespace Senac.Consultorio
{
    partial class FormPaciente
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
            btnCadastrar = new Button();
            txtEndereco = new TextBox();
            txtPeso = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtAltura = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblQuantidadePacientes = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtBuscaPorCPF = new TextBox();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(539, 326);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 33;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(12, 280);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(602, 23);
            txtEndereco.TabIndex = 7;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(369, 191);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(245, 23);
            txtPeso.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(245, 23);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(369, 104);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(245, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 104);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(245, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(12, 191);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(245, 23);
            txtAltura.TabIndex = 5;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(369, 27);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(245, 23);
            dtpDataNascimento.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 262);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 25;
            label7.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 173);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 24;
            label6.Text = "Peso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 86);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 23;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 22;
            label4.Text = "Altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 21;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 20;
            label2.Text = "Data De Nascimento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 19;
            label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblQuantidadePacientes);
            groupBox1.Location = new Point(807, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quantidade de pacientes cadastrados";
            // 
            // lblQuantidadePacientes
            // 
            lblQuantidadePacientes.AutoSize = true;
            lblQuantidadePacientes.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadePacientes.ForeColor = Color.DarkCyan;
            lblQuantidadePacientes.Location = new Point(79, 35);
            lblQuantidadePacientes.Name = "lblQuantidadePacientes";
            lblQuantidadePacientes.Size = new Size(38, 46);
            lblQuantidadePacientes.TabIndex = 0;
            lblQuantidadePacientes.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBuscaPorCPF);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(807, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 181);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 46);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 0;
            label8.Text = "CPF";
            // 
            // txtBuscaPorCPF
            // 
            txtBuscaPorCPF.Location = new Point(22, 81);
            txtBuscaPorCPF.Name = "txtBuscaPorCPF";
            txtBuscaPorCPF.Size = new Size(178, 23);
            txtBuscaPorCPF.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(22, 128);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 366);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtPeso);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtAltura);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPaciente";
            Text = "Consultorio";
            Load += FormPaciente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtEndereco;
        private TextBox txtPeso;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtAltura;
        private DateTimePicker dtpDataNascimento;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblQuantidadePacientes;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private TextBox txtBuscaPorCPF;
        private Label label8;
    }
}