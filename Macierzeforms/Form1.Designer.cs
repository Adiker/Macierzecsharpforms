namespace Macierzeforms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FirstMatrixRowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstMatrixColumnsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondMatrixColumnsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SecondMatrixRowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MultiplyMatricesButton = new System.Windows.Forms.Button();
            this.MatricesCreate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstMatrixRowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstMatrixColumnsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondMatrixColumnsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondMatrixRowsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(807, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mnożenie macierzy by Adiker ®";
            // 
            // FirstMatrixRowsNumericUpDown
            // 
            this.FirstMatrixRowsNumericUpDown.Location = new System.Drawing.Point(917, 122);
            this.FirstMatrixRowsNumericUpDown.Name = "FirstMatrixRowsNumericUpDown";
            this.FirstMatrixRowsNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.FirstMatrixRowsNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wiersze (macierz 1):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(993, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kolumny (macierz 1):";
            // 
            // FirstMatrixColumnsNumericUpDown
            // 
            this.FirstMatrixColumnsNumericUpDown.Location = new System.Drawing.Point(1101, 122);
            this.FirstMatrixColumnsNumericUpDown.Name = "FirstMatrixColumnsNumericUpDown";
            this.FirstMatrixColumnsNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.FirstMatrixColumnsNumericUpDown.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(993, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kolumny (macierz 2):";
            // 
            // SecondMatrixColumnsNumericUpDown
            // 
            this.SecondMatrixColumnsNumericUpDown.Location = new System.Drawing.Point(1101, 171);
            this.SecondMatrixColumnsNumericUpDown.Name = "SecondMatrixColumnsNumericUpDown";
            this.SecondMatrixColumnsNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.SecondMatrixColumnsNumericUpDown.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(809, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wiersze (macierz 2):";
            // 
            // SecondMatrixRowsNumericUpDown
            // 
            this.SecondMatrixRowsNumericUpDown.Location = new System.Drawing.Point(917, 171);
            this.SecondMatrixRowsNumericUpDown.Name = "SecondMatrixRowsNumericUpDown";
            this.SecondMatrixRowsNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.SecondMatrixRowsNumericUpDown.TabIndex = 5;
            // 
            // MultiplyMatricesButton
            // 
            this.MultiplyMatricesButton.BackColor = System.Drawing.Color.White;
            this.MultiplyMatricesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultiplyMatricesButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MultiplyMatricesButton.Location = new System.Drawing.Point(1014, 253);
            this.MultiplyMatricesButton.Name = "MultiplyMatricesButton";
            this.MultiplyMatricesButton.Size = new System.Drawing.Size(195, 23);
            this.MultiplyMatricesButton.TabIndex = 9;
            this.MultiplyMatricesButton.Text = "Wykonaj mnożenie";
            this.MultiplyMatricesButton.UseVisualStyleBackColor = false;
            // 
            // MatricesCreate
            // 
            this.MatricesCreate.BackColor = System.Drawing.Color.White;
            this.MatricesCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MatricesCreate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatricesCreate.Location = new System.Drawing.Point(763, 253);
            this.MatricesCreate.Name = "MatricesCreate";
            this.MatricesCreate.Size = new System.Drawing.Size(195, 23);
            this.MatricesCreate.TabIndex = 13;
            this.MatricesCreate.Text = "Utwórz macierze";
            this.MatricesCreate.UseVisualStyleBackColor = false;
            this.MatricesCreate.Click += new System.EventHandler(this.MatricesCreate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 299);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(626, 388);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 299);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1200, 388);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(526, 299);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(194, 716);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Macierz 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(773, 716);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Macierz 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1315, 716);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Macierz 3 (wynikowa)";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1934, 985);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MatricesCreate);
            this.Controls.Add(this.MultiplyMatricesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecondMatrixColumnsNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SecondMatrixRowsNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstMatrixColumnsNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstMatrixRowsNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstMatrixRowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstMatrixColumnsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondMatrixColumnsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondMatrixRowsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FirstMatrixRowsNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FirstMatrixColumnsNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SecondMatrixColumnsNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SecondMatrixRowsNumericUpDown;
        private System.Windows.Forms.Button MultiplyMatricesButton;
        private System.Windows.Forms.Button MatricesCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

