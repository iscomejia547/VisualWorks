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
            this.closeBtn = new System.Windows.Forms.Button();
            this.bkgBtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.colorSet = new System.Windows.Forms.ColorDialog();
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
            this.TabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.TabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
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
            this.PicMain.Size = new System.Drawing.Size(794, 408);
            this.PicMain.TabIndex = 0;
            this.PicMain.TabStop = false;
            // 
            // StretchCHB
            // 
            this.StretchCHB.AutoSize = true;
            this.StretchCHB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StretchCHB.Location = new System.Drawing.Point(3, 417);
            this.StretchCHB.Name = "StretchCHB";
            this.StretchCHB.Size = new System.Drawing.Size(98, 30);
            this.StretchCHB.TabIndex = 1;
            this.StretchCHB.Text = "Strecht";
            this.StretchCHB.UseVisualStyleBackColor = true;
            this.StretchCHB.CheckedChanged += new System.EventHandler(this.StretchCHB_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.closeBtn);
            this.flowLayoutPanel1.Controls.Add(this.bkgBtn);
            this.flowLayoutPanel1.Controls.Add(this.clearbtn);
            this.flowLayoutPanel1.Controls.Add(this.openBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 417);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Location = new System.Drawing.Point(3, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Cerrar";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bkgBtn
            // 
            this.bkgBtn.AutoSize = true;
            this.bkgBtn.Location = new System.Drawing.Point(84, 3);
            this.bkgBtn.Name = "bkgBtn";
            this.bkgBtn.Size = new System.Drawing.Size(149, 23);
            this.bkgBtn.TabIndex = 1;
            this.bkgBtn.Text = "Establecer el color de fondo";
            this.bkgBtn.UseVisualStyleBackColor = true;
            this.bkgBtn.Click += new System.EventHandler(this.bkgBtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.AutoSize = true;
            this.clearbtn.Location = new System.Drawing.Point(239, 3);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(93, 23);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "Quitar la imagen";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // openBtn
            // 
            this.openBtn.AutoSize = true;
            this.openBtn.Location = new System.Drawing.Point(338, 3);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(110, 23);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "Mostrar una imagen";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // openDlg
            // 
            this.openDlg.FileName = "openFileDialog1";
            this.openDlg.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.* ";
            this.openDlg.Title = "Abrir";
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
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button bkgBtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.ColorDialog colorSet;
    }
}

