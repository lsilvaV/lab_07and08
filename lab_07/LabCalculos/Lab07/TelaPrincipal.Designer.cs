
namespace lab_07.LabCalculos.Lab07
{
    partial class TelaPrincipal
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.nudValor1 = new System.Windows.Forms.NumericUpDown();
            this.nudValor2 = new System.Windows.Forms.NumericUpDown();
            this.nudValor3 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(149, 25);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(42, 15);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(149, 71);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(42, 15);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(149, 121);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(42, 15);
            this.lblValor3.TabIndex = 2;
            this.lblValor3.Text = "Valor 3";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.SteelBlue;
            this.lblResultado.Location = new System.Drawing.Point(149, 202);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(164, 90);
            this.lblResultado.TabIndex = 3;
            // 
            // nudValor1
            // 
            this.nudValor1.Location = new System.Drawing.Point(193, 23);
            this.nudValor1.Name = "nudValor1";
            this.nudValor1.Size = new System.Drawing.Size(120, 23);
            this.nudValor1.TabIndex = 4;
            this.nudValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudValor2
            // 
            this.nudValor2.Location = new System.Drawing.Point(193, 69);
            this.nudValor2.Name = "nudValor2";
            this.nudValor2.Size = new System.Drawing.Size(120, 23);
            this.nudValor2.TabIndex = 5;
            this.nudValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudValor3
            // 
            this.nudValor3.Location = new System.Drawing.Point(193, 119);
            this.nudValor3.Name = "nudValor3";
            this.nudValor3.Size = new System.Drawing.Size(120, 23);
            this.nudValor3.TabIndex = 6;
            this.nudValor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(193, 164);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudValor3);
            this.Controls.Add(this.nudValor2);
            this.Controls.Add(this.nudValor1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cálculo";
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown nudValor1;
        private System.Windows.Forms.NumericUpDown nudValor2;
        private System.Windows.Forms.NumericUpDown nudValor3;
        private System.Windows.Forms.Button btnCalcular;
    }
}