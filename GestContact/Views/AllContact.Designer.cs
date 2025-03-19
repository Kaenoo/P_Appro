namespace GestContact.Views
{
    partial class AllContact
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
            this.lbl_TitleAllContact = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tab_lay_panel_contact = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_TitleAllContact
            // 
            this.lbl_TitleAllContact.AutoSize = true;
            this.lbl_TitleAllContact.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TitleAllContact.Location = new System.Drawing.Point(388, 70);
            this.lbl_TitleAllContact.Name = "lbl_TitleAllContact";
            this.lbl_TitleAllContact.Size = new System.Drawing.Size(269, 33);
            this.lbl_TitleAllContact.TabIndex = 0;
            this.lbl_TitleAllContact.Text = "Tous les contacts";
            // 
            // btn_Home
            // 
            this.btn_Home.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Home.Location = new System.Drawing.Point(228, 440);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(131, 44);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Menu";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tab_lay_panel_contact
            // 
            this.tab_lay_panel_contact.ColumnCount = 4;
            this.tab_lay_panel_contact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.93168F));
            this.tab_lay_panel_contact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.06832F));
            this.tab_lay_panel_contact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tab_lay_panel_contact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tab_lay_panel_contact.Location = new System.Drawing.Point(158, 118);
            this.tab_lay_panel_contact.Name = "tab_lay_panel_contact";
            this.tab_lay_panel_contact.RowCount = 1;
            this.tab_lay_panel_contact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab_lay_panel_contact.Size = new System.Drawing.Size(714, 294);
            this.tab_lay_panel_contact.TabIndex = 2;
            // 
            // AllContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tab_lay_panel_contact);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.lbl_TitleAllContact);
            this.Name = "AllContact";
            this.Text = "Tous les contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_TitleAllContact;
        private Button btn_Home;
        private TableLayoutPanel tab_lay_panel_contact;
    }
}