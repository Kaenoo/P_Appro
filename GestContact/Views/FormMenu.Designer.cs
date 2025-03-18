namespace GestContact
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lab_Titre = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.img_Search = new System.Windows.Forms.PictureBox();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Titre
            // 
            this.lab_Titre.AutoSize = true;
            this.lab_Titre.Location = new System.Drawing.Point(322, 102);
            this.lab_Titre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lab_Titre.Name = "lab_Titre";
            this.lab_Titre.Size = new System.Drawing.Size(372, 33);
            this.lab_Titre.TabIndex = 0;
            this.lab_Titre.Text = "Gestionnaire de contact";
            this.lab_Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(856, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(361, 173);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(333, 37);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // img_Search
            // 
            this.img_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_Search.Image = ((System.Drawing.Image)(resources.GetObject("img_Search.Image")));
            this.img_Search.Location = new System.Drawing.Point(322, 173);
            this.img_Search.Name = "img_Search";
            this.img_Search.Size = new System.Drawing.Size(42, 37);
            this.img_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Search.TabIndex = 4;
            this.img_Search.TabStop = false;
            this.img_Search.Click += new System.EventHandler(this.img_Search_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Location = new System.Drawing.Point(403, 279);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(231, 62);
            this.btn_ShowAll.TabIndex = 5;
            this.btn_ShowAll.Text = "Tout afficher";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.img_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lab_Titre);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormMenu";
            this.Text = "Gestionnaire de Contact";
            ((System.ComponentModel.ISupportInitialize)(this.img_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lab_Titre;
        private Button btnAdd;
        private TextBox txt_Search;
        private PictureBox img_Search;
        private Button btn_ShowAll;
    }
}