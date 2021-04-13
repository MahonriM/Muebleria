namespace Muebleria
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
            this.btnvender = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtliteras = new System.Windows.Forms.TextBox();
            this.txtcomedor = new System.Windows.Forms.TextBox();
            this.txttv = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvender
            // 
            this.btnvender.Location = new System.Drawing.Point(12, 270);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(74, 24);
            this.btnvender.TabIndex = 0;
            this.btnvender.Text = "Vender";
            this.btnvender.UseVisualStyleBackColor = true;
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(102, 270);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(74, 24);
            this.cancelar.TabIndex = 1;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtliteras);
            this.groupBox1.Controls.Add(this.txtcomedor);
            this.groupBox1.Controls.Add(this.txttv);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // txtliteras
            // 
            this.txtliteras.Enabled = false;
            this.txtliteras.Location = new System.Drawing.Point(124, 90);
            this.txtliteras.Name = "txtliteras";
            this.txtliteras.Size = new System.Drawing.Size(62, 20);
            this.txtliteras.TabIndex = 8;
            // 
            // txtcomedor
            // 
            this.txtcomedor.Enabled = false;
            this.txtcomedor.Location = new System.Drawing.Point(124, 61);
            this.txtcomedor.Name = "txtcomedor";
            this.txtcomedor.Size = new System.Drawing.Size(62, 20);
            this.txtcomedor.TabIndex = 7;
            // 
            // txttv
            // 
            this.txttv.Enabled = false;
            this.txttv.Location = new System.Drawing.Point(125, 35);
            this.txttv.Name = "txttv";
            this.txttv.Size = new System.Drawing.Size(62, 20);
            this.txttv.TabIndex = 6;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(136, 16);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 5;
            this.Cantidad.Text = "Cantidad";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Literas $ 2500";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "comedor $7,500";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Smart TV $4,500";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst);
            this.groupBox2.Location = new System.Drawing.Point(24, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket";
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Items.AddRange(new object[] {
            "Total a pagar es ________________",
            "Articulos comprados _____________",
            "Gracias por su compra"});
            this.lst.Location = new System.Drawing.Point(19, 20);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(171, 56);
            this.lst.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.btnvender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvender;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtliteras;
        private System.Windows.Forms.TextBox txtcomedor;
        private System.Windows.Forms.TextBox txttv;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst;
    }
}

