﻿namespace MathTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sumLeft = new System.Windows.Forms.Label();
            this.sumResult = new System.Windows.Forms.NumericUpDown();
            this.sumRight = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.restLeft = new System.Windows.Forms.Label();
            this.rest = new System.Windows.Forms.Label();
            this.restRight = new System.Windows.Forms.Label();
            this.multLeft = new System.Windows.Forms.Label();
            this.mult = new System.Windows.Forms.Label();
            this.divLeft = new System.Windows.Forms.Label();
            this.multRight = new System.Windows.Forms.Label();
            this.div = new System.Windows.Forms.Label();
            this.divRight = new System.Windows.Forms.Label();
            this.divResult = new System.Windows.Forms.NumericUpDown();
            this.multResult = new System.Windows.Forms.NumericUpDown();
            this.resResult = new System.Windows.Forms.NumericUpDown();
            this.startbtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sumcheck = new System.Windows.Forms.Label();
            this.divcheck = new System.Windows.Forms.Label();
            this.multcheck = new System.Windows.Forms.Label();
            this.rescheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resResult)).BeginInit();
            this.SuspendLayout();
            // 
            // timelabel
            // 
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.timelabel.Location = new System.Drawing.Point(272, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(200, 30);
            this.timelabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 17.5F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo Restante: ";
            // 
            // sumLeft
            // 
            this.sumLeft.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.sumLeft.Location = new System.Drawing.Point(50, 75);
            this.sumLeft.Name = "sumLeft";
            this.sumLeft.Size = new System.Drawing.Size(60, 50);
            this.sumLeft.TabIndex = 2;
            this.sumLeft.Text = "?";
            this.sumLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumResult
            // 
            this.sumResult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.sumResult.Location = new System.Drawing.Point(306, 82);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(120, 39);
            this.sumResult.TabIndex = 2;
            this.sumResult.Enter += new System.EventHandler(this.answer_enter);
            // 
            // sumRight
            // 
            this.sumRight.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.sumRight.Location = new System.Drawing.Point(209, 75);
            this.sumRight.Name = "sumRight";
            this.sumRight.Size = new System.Drawing.Size(60, 50);
            this.sumRight.TabIndex = 5;
            this.sumRight.Text = "?";
            this.sumRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.sum.Location = new System.Drawing.Point(131, 76);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(60, 50);
            this.sum.TabIndex = 6;
            this.sum.Text = "➕";
            this.sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // restLeft
            // 
            this.restLeft.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.restLeft.Location = new System.Drawing.Point(50, 143);
            this.restLeft.Name = "restLeft";
            this.restLeft.Size = new System.Drawing.Size(60, 50);
            this.restLeft.TabIndex = 7;
            this.restLeft.Text = "?";
            this.restLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rest
            // 
            this.rest.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rest.Location = new System.Drawing.Point(131, 143);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(60, 50);
            this.rest.TabIndex = 8;
            this.rest.Text = "➖";
            this.rest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restRight
            // 
            this.restRight.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.restRight.Location = new System.Drawing.Point(209, 143);
            this.restRight.Name = "restRight";
            this.restRight.Size = new System.Drawing.Size(60, 50);
            this.restRight.TabIndex = 9;
            this.restRight.Text = "?";
            this.restRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multLeft
            // 
            this.multLeft.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.multLeft.Location = new System.Drawing.Point(50, 210);
            this.multLeft.Name = "multLeft";
            this.multLeft.Size = new System.Drawing.Size(60, 50);
            this.multLeft.TabIndex = 10;
            this.multLeft.Text = "?";
            this.multLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.mult.Location = new System.Drawing.Point(131, 210);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(60, 50);
            this.mult.TabIndex = 11;
            this.mult.Text = "✖";
            this.mult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeft
            // 
            this.divLeft.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.divLeft.Location = new System.Drawing.Point(50, 271);
            this.divLeft.Name = "divLeft";
            this.divLeft.Size = new System.Drawing.Size(60, 50);
            this.divLeft.TabIndex = 12;
            this.divLeft.Text = "?";
            this.divLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multRight
            // 
            this.multRight.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.multRight.Location = new System.Drawing.Point(209, 210);
            this.multRight.Name = "multRight";
            this.multRight.Size = new System.Drawing.Size(60, 50);
            this.multRight.TabIndex = 13;
            this.multRight.Text = "?";
            this.multRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.div.Location = new System.Drawing.Point(131, 271);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 50);
            this.div.TabIndex = 14;
            this.div.Text = "➗";
            this.div.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRight
            // 
            this.divRight.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.divRight.Location = new System.Drawing.Point(209, 271);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(60, 50);
            this.divRight.TabIndex = 15;
            this.divRight.Text = "?";
            this.divRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divResult
            // 
            this.divResult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.divResult.Location = new System.Drawing.Point(306, 278);
            this.divResult.Name = "divResult";
            this.divResult.Size = new System.Drawing.Size(120, 39);
            this.divResult.TabIndex = 5;
            this.divResult.Enter += new System.EventHandler(this.answer_enter);
            // 
            // multResult
            // 
            this.multResult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.multResult.Location = new System.Drawing.Point(306, 217);
            this.multResult.Name = "multResult";
            this.multResult.Size = new System.Drawing.Size(120, 39);
            this.multResult.TabIndex = 4;
            this.multResult.Enter += new System.EventHandler(this.answer_enter);
            // 
            // resResult
            // 
            this.resResult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.resResult.Location = new System.Drawing.Point(306, 150);
            this.resResult.Name = "resResult";
            this.resResult.Size = new System.Drawing.Size(120, 39);
            this.resResult.TabIndex = 3;
            this.resResult.Enter += new System.EventHandler(this.answer_enter);
            // 
            // startbtn
            // 
            this.startbtn.AutoSize = true;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.startbtn.Location = new System.Drawing.Point(148, 329);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(159, 35);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Iniciar la prueba";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // sumcheck
            // 
            this.sumcheck.AutoSize = true;
            this.sumcheck.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.sumcheck.ForeColor = System.Drawing.Color.Red;
            this.sumcheck.Location = new System.Drawing.Point(476, 87);
            this.sumcheck.Name = "sumcheck";
            this.sumcheck.Size = new System.Drawing.Size(25, 30);
            this.sumcheck.TabIndex = 16;
            this.sumcheck.Text = "X";
            // 
            // divcheck
            // 
            this.divcheck.AutoSize = true;
            this.divcheck.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.divcheck.ForeColor = System.Drawing.Color.Red;
            this.divcheck.Location = new System.Drawing.Point(476, 287);
            this.divcheck.Name = "divcheck";
            this.divcheck.Size = new System.Drawing.Size(25, 30);
            this.divcheck.TabIndex = 17;
            this.divcheck.Text = "X";
            // 
            // multcheck
            // 
            this.multcheck.AutoSize = true;
            this.multcheck.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.multcheck.ForeColor = System.Drawing.Color.Red;
            this.multcheck.Location = new System.Drawing.Point(476, 226);
            this.multcheck.Name = "multcheck";
            this.multcheck.Size = new System.Drawing.Size(25, 30);
            this.multcheck.TabIndex = 18;
            this.multcheck.Text = "X";
            // 
            // rescheck
            // 
            this.rescheck.AutoSize = true;
            this.rescheck.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.rescheck.ForeColor = System.Drawing.Color.Red;
            this.rescheck.Location = new System.Drawing.Point(476, 154);
            this.rescheck.Name = "rescheck";
            this.rescheck.Size = new System.Drawing.Size(25, 30);
            this.rescheck.TabIndex = 19;
            this.rescheck.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 376);
            this.Controls.Add(this.rescheck);
            this.Controls.Add(this.multcheck);
            this.Controls.Add(this.divcheck);
            this.Controls.Add(this.sumcheck);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.resResult);
            this.Controls.Add(this.multResult);
            this.Controls.Add(this.divResult);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multRight);
            this.Controls.Add(this.divLeft);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.multLeft);
            this.Controls.Add(this.restRight);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.restLeft);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.sumRight);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.sumLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timelabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Test (Aplicaciones 🅱ergas)";
            ((System.ComponentModel.ISupportInitialize)(this.sumResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumLeft;
        private System.Windows.Forms.NumericUpDown sumResult;
        private System.Windows.Forms.Label sumRight;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label restLeft;
        private System.Windows.Forms.Label rest;
        private System.Windows.Forms.Label restRight;
        private System.Windows.Forms.Label multLeft;
        private System.Windows.Forms.Label mult;
        private System.Windows.Forms.Label divLeft;
        private System.Windows.Forms.Label multRight;
        private System.Windows.Forms.Label div;
        private System.Windows.Forms.Label divRight;
        private System.Windows.Forms.NumericUpDown divResult;
        private System.Windows.Forms.NumericUpDown multResult;
        private System.Windows.Forms.NumericUpDown resResult;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label sumcheck;
        private System.Windows.Forms.Label divcheck;
        private System.Windows.Forms.Label multcheck;
        private System.Windows.Forms.Label rescheck;
    }
}

