namespace Seeabattle
{
    partial class SeaBattle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Rasstanovka_odnopalubnih;
            this.Player1_field = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewButtonColumn();
            this.B = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C = new System.Windows.Forms.DataGridViewButtonColumn();
            this.D = new System.Windows.Forms.DataGridViewButtonColumn();
            this.E = new System.Windows.Forms.DataGridViewButtonColumn();
            this.F = new System.Windows.Forms.DataGridViewButtonColumn();
            this.G = new System.Windows.Forms.DataGridViewButtonColumn();
            this.H = new System.Windows.Forms.DataGridViewButtonColumn();
            this.I = new System.Windows.Forms.DataGridViewButtonColumn();
            this.J = new System.Windows.Forms.DataGridViewButtonColumn();
            this.K = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            Rasstanovka_odnopalubnih = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1_field)).BeginInit();
            this.SuspendLayout();
            // 
            // Rasstanovka_odnopalubnih
            // 
            Rasstanovka_odnopalubnih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            Rasstanovka_odnopalubnih.Location = new System.Drawing.Point(467, 31);
            Rasstanovka_odnopalubnih.Name = "Rasstanovka_odnopalubnih";
            Rasstanovka_odnopalubnih.Size = new System.Drawing.Size(170, 42);
            Rasstanovka_odnopalubnih.TabIndex = 9;
            Rasstanovka_odnopalubnih.Text = "Раставить однопалубные корабли";
            Rasstanovka_odnopalubnih.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Rasstanovka_odnopalubnih.UseVisualStyleBackColor = true;
            Rasstanovka_odnopalubnih.Click += new System.EventHandler(this.button1_Click);
            // 
            // Player1_field
            // 
            this.Player1_field.AllowUserToAddRows = false;
            this.Player1_field.AllowUserToDeleteRows = false;
            this.Player1_field.AllowUserToResizeColumns = false;
            this.Player1_field.AllowUserToResizeRows = false;
            this.Player1_field.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.Player1_field.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player1_field.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Player1_field.ColumnHeadersVisible = false;
            this.Player1_field.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H,
            this.I,
            this.J,
            this.K});
            this.Player1_field.Enabled = false;
            this.Player1_field.Location = new System.Drawing.Point(35, 31);
            this.Player1_field.MultiSelect = false;
            this.Player1_field.Name = "Player1_field";
            this.Player1_field.ReadOnly = true;
            this.Player1_field.RowHeadersVisible = false;
            this.Player1_field.RowTemplate.Height = 24;
            this.Player1_field.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Player1_field.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Player1_field.ShowCellErrors = false;
            this.Player1_field.ShowCellToolTips = false;
            this.Player1_field.ShowEditingIcon = false;
            this.Player1_field.ShowRowErrors = false;
            this.Player1_field.Size = new System.Drawing.Size(403, 297);
            this.Player1_field.TabIndex = 7;
            this.Player1_field.TabStop = false;
            this.Player1_field.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Player1_field_CellContentClick);
            this.Player1_field.VisibleChanged += new System.EventHandler(this.SeaBattle_Load);
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.A.HeaderText = "";
            this.A.MinimumWidth = 30;
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Width = 30;
            // 
            // B
            // 
            this.B.HeaderText = "";
            this.B.MinimumWidth = 30;
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 30;
            // 
            // C
            // 
            this.C.HeaderText = "";
            this.C.MinimumWidth = 30;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 30;
            // 
            // D
            // 
            this.D.HeaderText = "";
            this.D.MinimumWidth = 30;
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Width = 30;
            // 
            // E
            // 
            this.E.HeaderText = "";
            this.E.MinimumWidth = 30;
            this.E.Name = "E";
            this.E.ReadOnly = true;
            this.E.Width = 30;
            // 
            // F
            // 
            this.F.HeaderText = "";
            this.F.MinimumWidth = 30;
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 30;
            // 
            // G
            // 
            this.G.HeaderText = "";
            this.G.MinimumWidth = 30;
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Width = 30;
            // 
            // H
            // 
            this.H.HeaderText = "";
            this.H.MinimumWidth = 30;
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Width = 30;
            // 
            // I
            // 
            this.I.HeaderText = "";
            this.I.MinimumWidth = 30;
            this.I.Name = "I";
            this.I.ReadOnly = true;
            this.I.Width = 30;
            // 
            // J
            // 
            this.J.HeaderText = "";
            this.J.MinimumWidth = 30;
            this.J.Name = "J";
            this.J.ReadOnly = true;
            this.J.Width = 30;
            // 
            // K
            // 
            this.K.HeaderText = "";
            this.K.MinimumWidth = 30;
            this.K.Name = "K";
            this.K.ReadOnly = true;
            this.K.Width = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(467, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SeaBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 506);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(Rasstanovka_odnopalubnih);
            this.Controls.Add(this.Player1_field);
            this.Name = "SeaBattle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SeaBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1_field)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Player1_field;
        private System.Windows.Forms.DataGridViewButtonColumn A;
        private System.Windows.Forms.DataGridViewButtonColumn B;
        private System.Windows.Forms.DataGridViewButtonColumn C;
        private System.Windows.Forms.DataGridViewButtonColumn D;
        private System.Windows.Forms.DataGridViewButtonColumn E;
        private System.Windows.Forms.DataGridViewButtonColumn F;
        private System.Windows.Forms.DataGridViewButtonColumn G;
        private System.Windows.Forms.DataGridViewButtonColumn H;
        private System.Windows.Forms.DataGridViewButtonColumn I;
        private System.Windows.Forms.DataGridViewButtonColumn J;
        private System.Windows.Forms.DataGridViewButtonColumn K;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

