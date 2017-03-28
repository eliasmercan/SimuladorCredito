namespace SimuladorCredito
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprestamo = new System.Windows.Forms.TextBox();
            this.txtcuotas = new System.Windows.Forms.TextBox();
            this.txtintereses = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cuota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Intereses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PagoTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Cuotas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Intereses:";
            // 
            // txtprestamo
            // 
            this.txtprestamo.Location = new System.Drawing.Point(99, 18);
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.Size = new System.Drawing.Size(100, 20);
            this.txtprestamo.TabIndex = 4;
            this.txtprestamo.Text = "0";
            // 
            // txtcuotas
            // 
            this.txtcuotas.Location = new System.Drawing.Point(99, 44);
            this.txtcuotas.Name = "txtcuotas";
            this.txtcuotas.Size = new System.Drawing.Size(100, 20);
            this.txtcuotas.TabIndex = 5;
            this.txtcuotas.Text = "0";
            // 
            // txtintereses
            // 
            this.txtintereses.Location = new System.Drawing.Point(100, 70);
            this.txtintereses.Name = "txtintereses";
            this.txtintereses.Size = new System.Drawing.Size(100, 20);
            this.txtintereses.TabIndex = 6;
            this.txtintereses.Text = "0";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cuota,
            this.Capital,
            this.Intereses,
            this.PagoTotal,
            this.Saldo});
            this.listView1.Location = new System.Drawing.Point(214, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(427, 251);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Cuota
            // 
            this.Cuota.Text = "Cuota";
            this.Cuota.Width = 40;
            // 
            // Capital
            // 
            this.Capital.Text = "Capital";
            this.Capital.Width = 100;
            // 
            // Intereses
            // 
            this.Intereses.Text = "Intereses";
            this.Intereses.Width = 80;
            // 
            // PagoTotal
            // 
            this.PagoTotal.Text = "Pago Total";
            this.PagoTotal.Width = 90;
            // 
            // Saldo
            // 
            this.Saldo.Text = "Saldo";
            this.Saldo.Width = 90;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Totales Intereses:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Totales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtintereses);
            this.Controls.Add(this.txtcuotas);
            this.Controls.Add(this.txtprestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Simulador de Credito";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprestamo;
        private System.Windows.Forms.TextBox txtcuotas;
        private System.Windows.Forms.TextBox txtintereses;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Cuota;
        private System.Windows.Forms.ColumnHeader Capital;
        private System.Windows.Forms.ColumnHeader Intereses;
        private System.Windows.Forms.ColumnHeader PagoTotal;
        private System.Windows.Forms.ColumnHeader Saldo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

