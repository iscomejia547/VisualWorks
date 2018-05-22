namespace ImageApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PicMain = new System.Windows.Forms.PictureBox();
            this.StretchCHB = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TabLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMain)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLayout
            // 
            this.TabLayout.ColumnCount = 2;
            this.TabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.TabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.95652F));
            this.TabLayout.Controls.Add(this.PicMain, 0, 0);
            this.TabLayout.Controls.Add(this.StretchCHB, 0, 1);
            this.TabLayout.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.TabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayout.Location = new System.Drawing.Point(0, 0);
            this.TabLayout.Name = "TabLayout";
            this.TabLayout.RowCount = 2;
            this.TabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.22222F));
            this.TabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.77778F));
            this.TabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabLayout.Size = new System.Drawing.Size(800, 450);
            this.TabLayout.TabIndex = 0;
            this.TabLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // PicMain
            // 
            this.TabLayout.SetColumnSpan(this.PicMain, 2);
            this.PicMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicMain.Location = new System.Drawing.Point(3, 3);
            this.PicMain.Name = "PicMain";
            this.PicMain.Size = new System.Drawing.Size(794, 354);
            this.PicMain.TabIndex = 0;
            this.PicMain.TabStop = false;
            // 
            // StretchCHB
            // 
            this.StretchCHB.AutoSize = true;
            this.StretchCHB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StretchCHB.Location = new System.Drawing.Point(3, 363);
            this.StretchCHB.Name = "StretchCHB";
            this.StretchCHB.Size = new System.Drawing.Size(98, 84);
            this.StretchCHB.TabIndex = 1;
            this.StretchCHB.Text = "Strecht";
            this.StretchCHB.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 363);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 84);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Establecer el color de fondo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(239, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Borrar la imagen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(338, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Mostrar una imagen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabLayout);
            this.Name = "MainForm";
            this.Text = "Visor de Imágenes";
            this.TabLayout.ResumeLayout(false);
            this.TabLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMain)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabLayout;
        private System.Windows.Forms.PictureBox PicMain;
        private System.Windows.Forms.CheckBox StretchCHB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

