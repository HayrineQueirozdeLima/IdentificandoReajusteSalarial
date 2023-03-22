
namespace IdentificandoReajusteSalarial
{
    partial class frmCalculoDeSalario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.radioCalouro = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.radioVeterano = new System.Windows.Forms.RadioButton();
            this.radioMatutino = new System.Windows.Forms.RadioButton();
            this.radioVespertino = new System.Windows.Forms.RadioButton();
            this.radioNoturno = new System.Windows.Forms.RadioButton();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.bttCalcular = new System.Windows.Forms.Button();
            this.txtSituacaoSalario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Location = new System.Drawing.Point(12, 23);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(104, 17);
            this.lblSalarioMinimo.TabIndex = 0;
            this.lblSalarioMinimo.Text = "Salário Mínimo:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(147, 20);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(117, 22);
            this.txtSalarioMinimo.TabIndex = 1;
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.radioVeterano);
            this.gbxCategoria.Controls.Add(this.radioCalouro);
            this.gbxCategoria.Location = new System.Drawing.Point(15, 75);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(249, 51);
            this.gbxCategoria.TabIndex = 2;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // radioCalouro
            // 
            this.radioCalouro.AutoSize = true;
            this.radioCalouro.Location = new System.Drawing.Point(6, 21);
            this.radioCalouro.Name = "radioCalouro";
            this.radioCalouro.Size = new System.Drawing.Size(78, 21);
            this.radioCalouro.TabIndex = 0;
            this.radioCalouro.TabStop = true;
            this.radioCalouro.Text = "Calouro";
            this.radioCalouro.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.radioNoturno);
            this.gbxTurno.Controls.Add(this.radioVespertino);
            this.gbxTurno.Controls.Add(this.radioMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(270, 12);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(106, 114);
            this.gbxTurno.TabIndex = 3;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // radioVeterano
            // 
            this.radioVeterano.AutoSize = true;
            this.radioVeterano.Location = new System.Drawing.Point(156, 21);
            this.radioVeterano.Name = "radioVeterano";
            this.radioVeterano.Size = new System.Drawing.Size(87, 21);
            this.radioVeterano.TabIndex = 0;
            this.radioVeterano.TabStop = true;
            this.radioVeterano.Text = "Veterano";
            this.radioVeterano.UseVisualStyleBackColor = true;
            // 
            // radioMatutino
            // 
            this.radioMatutino.AutoSize = true;
            this.radioMatutino.Location = new System.Drawing.Point(6, 30);
            this.radioMatutino.Name = "radioMatutino";
            this.radioMatutino.Size = new System.Drawing.Size(83, 21);
            this.radioMatutino.TabIndex = 1;
            this.radioMatutino.TabStop = true;
            this.radioMatutino.Text = "Matutino";
            this.radioMatutino.UseVisualStyleBackColor = true;
            // 
            // radioVespertino
            // 
            this.radioVespertino.AutoSize = true;
            this.radioVespertino.Location = new System.Drawing.Point(6, 57);
            this.radioVespertino.Name = "radioVespertino";
            this.radioVespertino.Size = new System.Drawing.Size(97, 21);
            this.radioVespertino.TabIndex = 2;
            this.radioVespertino.TabStop = true;
            this.radioVespertino.Text = "Vespertino";
            this.radioVespertino.UseVisualStyleBackColor = true;
            // 
            // radioNoturno
            // 
            this.radioNoturno.AutoSize = true;
            this.radioNoturno.Location = new System.Drawing.Point(6, 84);
            this.radioNoturno.Name = "radioNoturno";
            this.radioNoturno.Size = new System.Drawing.Size(80, 21);
            this.radioNoturno.TabIndex = 3;
            this.radioNoturno.TabStop = true;
            this.radioNoturno.Text = "Noturno";
            this.radioNoturno.UseVisualStyleBackColor = true;
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(12, 50);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(129, 17);
            this.lblHorasTrabalhadas.TabIndex = 4;
            this.lblHorasTrabalhadas.Text = "Horas trabalhadas:";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(147, 47);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(117, 22);
            this.txtHorasTrabalhadas.TabIndex = 5;
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 16;
            this.lbxResumo.Location = new System.Drawing.Point(16, 132);
            this.lbxResumo.MultiColumn = true;
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxResumo.Size = new System.Drawing.Size(361, 132);
            this.lbxResumo.TabIndex = 6;
            // 
            // bttCalcular
            // 
            this.bttCalcular.Location = new System.Drawing.Point(301, 284);
            this.bttCalcular.Name = "bttCalcular";
            this.bttCalcular.Size = new System.Drawing.Size(75, 23);
            this.bttCalcular.TabIndex = 7;
            this.bttCalcular.Text = "Calcular";
            this.bttCalcular.UseVisualStyleBackColor = true;
            this.bttCalcular.Click += new System.EventHandler(this.bttCalcular_Click);
            // 
            // txtSituacaoSalario
            // 
            this.txtSituacaoSalario.Location = new System.Drawing.Point(16, 285);
            this.txtSituacaoSalario.Name = "txtSituacaoSalario";
            this.txtSituacaoSalario.Size = new System.Drawing.Size(279, 22);
            this.txtSituacaoSalario.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // frmCalculoDeSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 317);
            this.Controls.Add(this.txtSituacaoSalario);
            this.Controls.Add(this.bttCalcular);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.lblSalarioMinimo);
            this.Name = "frmCalculoDeSalario";
            this.Text = "Cálculo de Salário";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton radioVeterano;
        private System.Windows.Forms.RadioButton radioCalouro;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton radioNoturno;
        private System.Windows.Forms.RadioButton radioVespertino;
        private System.Windows.Forms.RadioButton radioMatutino;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.Button bttCalcular;
        private System.Windows.Forms.TextBox txtSituacaoSalario;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

