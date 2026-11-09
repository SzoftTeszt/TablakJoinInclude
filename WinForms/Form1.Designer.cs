namespace WinForms
{
    partial class Form1
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
            lstUgyfelek = new ListBox();
            lstRendelesek = new ListBox();
            label1 = new Label();
            lblKivalasztott = new Label();
            btnInclude = new Button();
            btnBudapest = new Button();
            btnJoin = new Button();
            dvgJOIN = new DataGridView();
            label2 = new Label();
            btnOszesites = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgJOIN).BeginInit();
            SuspendLayout();
            // 
            // lstUgyfelek
            // 
            lstUgyfelek.FormattingEnabled = true;
            lstUgyfelek.Location = new Point(33, 41);
            lstUgyfelek.Name = "lstUgyfelek";
            lstUgyfelek.Size = new Size(170, 184);
            lstUgyfelek.TabIndex = 0;
            lstUgyfelek.SelectedIndexChanged += lstUgyfelek_SelectedIndexChanged;
            // 
            // lstRendelesek
            // 
            lstRendelesek.FormattingEnabled = true;
            lstRendelesek.Location = new Point(229, 41);
            lstRendelesek.Name = "lstRendelesek";
            lstRendelesek.Size = new Size(403, 184);
            lstRendelesek.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Ügyfelek";
            // 
            // lblKivalasztott
            // 
            lblKivalasztott.AutoSize = true;
            lblKivalasztott.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKivalasztott.Location = new Point(229, 12);
            lblKivalasztott.Name = "lblKivalasztott";
            lblKivalasztott.Size = new Size(72, 15);
            lblKivalasztott.TabIndex = 1;
            lblKivalasztott.Text = "Rendelések";
            // 
            // btnInclude
            // 
            btnInclude.Location = new Point(33, 246);
            btnInclude.Name = "btnInclude";
            btnInclude.Size = new Size(114, 23);
            btnInclude.TabIndex = 2;
            btnInclude.Text = "Include összesítés";
            btnInclude.UseVisualStyleBackColor = true;
            btnInclude.Click += btnInclude_Click;
            // 
            // btnBudapest
            // 
            btnBudapest.Location = new Point(518, 246);
            btnBudapest.Name = "btnBudapest";
            btnBudapest.Size = new Size(114, 23);
            btnBudapest.TabIndex = 2;
            btnBudapest.Text = "Budapesti JOIN";
            btnBudapest.UseVisualStyleBackColor = true;
            btnBudapest.Click += btnJoin_Click;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(201, 246);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(114, 23);
            btnJoin.TabIndex = 2;
            btnJoin.Text = "Összes JOIN";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // dvgJOIN
            // 
            dvgJOIN.AllowUserToAddRows = false;
            dvgJOIN.AllowUserToDeleteRows = false;
            dvgJOIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgJOIN.Location = new Point(33, 324);
            dvgJOIN.Name = "dvgJOIN";
            dvgJOIN.ReadOnly = true;
            dvgJOIN.Size = new Size(599, 188);
            dvgJOIN.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(33, 297);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 4;
            label2.Text = "JOIN eredmény (projekció)";
            // 
            // btnOszesites
            // 
            btnOszesites.Location = new Point(361, 246);
            btnOszesites.Name = "btnOszesites";
            btnOszesites.Size = new Size(114, 23);
            btnOszesites.TabIndex = 2;
            btnOszesites.Text = "Összesített vásárlás";
            btnOszesites.UseVisualStyleBackColor = true;
            btnOszesites.Click += btnOszesites_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 540);
            Controls.Add(label2);
            Controls.Add(dvgJOIN);
            Controls.Add(btnOszesites);
            Controls.Add(btnJoin);
            Controls.Add(btnBudapest);
            Controls.Add(btnInclude);
            Controls.Add(lblKivalasztott);
            Controls.Add(label1);
            Controls.Add(lstRendelesek);
            Controls.Add(lstUgyfelek);
            Name = "Form1";
            Text = "FEF Core . include és join gyakorlás";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgJOIN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstUgyfelek;
        private ListBox lstRendelesek;
        private Label label1;
        private Label lblKivalasztott;
        private Button btnInclude;
        private Button btnBudapest;
        private Button btnJoin;
        private DataGridView dvgJOIN;
        private Label label2;
        private Button btnOszesites;
    }
}
