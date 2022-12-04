namespace FORmule
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.idcar = new System.Windows.Forms.Label();
            this.labelmarque = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Label();
            this.labematricule = new System.Windows.Forms.Label();
            this.buttajouute = new System.Windows.Forms.Button();
            this.buttmodifier = new System.Windows.Forms.Button();
            this.buttonsupp = new System.Windows.Forms.Button();
            this.buttoncomfirm = new System.Windows.Forms.Button();
            this.buttonannul = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idcar
            // 
            this.idcar.AutoSize = true;
            this.idcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcar.Location = new System.Drawing.Point(87, 43);
            this.idcar.Name = "idcar";
            this.idcar.Size = new System.Drawing.Size(37, 16);
            this.idcar.TabIndex = 0;
            this.idcar.Text = "idcar";
            // 
            // labelmarque
            // 
            this.labelmarque.AutoSize = true;
            this.labelmarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmarque.Location = new System.Drawing.Point(87, 83);
            this.labelmarque.Name = "labelmarque";
            this.labelmarque.Size = new System.Drawing.Size(53, 16);
            this.labelmarque.TabIndex = 1;
            this.labelmarque.Text = "marque";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 20);
            this.textBox4.TabIndex = 5;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.Location = new System.Drawing.Point(87, 125);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(37, 16);
            this.color.TabIndex = 6;
            this.color.Text = "color";
            // 
            // labematricule
            // 
            this.labematricule.AutoSize = true;
            this.labematricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labematricule.Location = new System.Drawing.Point(87, 169);
            this.labematricule.Name = "labematricule";
            this.labematricule.Size = new System.Drawing.Size(53, 16);
            this.labematricule.TabIndex = 7;
            this.labematricule.Text = "mtricule";
            // 
            // buttajouute
            // 
            this.buttajouute.BackColor = System.Drawing.Color.Gray;
            this.buttajouute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttajouute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttajouute.Location = new System.Drawing.Point(550, 53);
            this.buttajouute.Name = "buttajouute";
            this.buttajouute.Size = new System.Drawing.Size(95, 46);
            this.buttajouute.TabIndex = 8;
            this.buttajouute.Text = "Ajouter";
            this.buttajouute.UseVisualStyleBackColor = false;
            this.buttajouute.Click += new System.EventHandler(this.buttajouute_Click);
            // 
            // buttmodifier
            // 
            this.buttmodifier.BackColor = System.Drawing.Color.Gray;
            this.buttmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttmodifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttmodifier.Location = new System.Drawing.Point(556, 136);
            this.buttmodifier.Name = "buttmodifier";
            this.buttmodifier.Size = new System.Drawing.Size(91, 46);
            this.buttmodifier.TabIndex = 9;
            this.buttmodifier.Text = "Modifier";
            this.buttmodifier.UseVisualStyleBackColor = false;
            this.buttmodifier.Click += new System.EventHandler(this.buttmodifier_Click);
            // 
            // buttonsupp
            // 
            this.buttonsupp.BackColor = System.Drawing.Color.Gray;
            this.buttonsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsupp.Location = new System.Drawing.Point(552, 215);
            this.buttonsupp.Name = "buttonsupp";
            this.buttonsupp.Size = new System.Drawing.Size(93, 46);
            this.buttonsupp.TabIndex = 10;
            this.buttonsupp.Text = "supprimer";
            this.buttonsupp.UseVisualStyleBackColor = false;
            this.buttonsupp.Click += new System.EventHandler(this.buttonsupp_Click);
            // 
            // buttoncomfirm
            // 
            this.buttoncomfirm.BackColor = System.Drawing.Color.Gray;
            this.buttoncomfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncomfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttoncomfirm.Location = new System.Drawing.Point(559, 280);
            this.buttoncomfirm.Name = "buttoncomfirm";
            this.buttoncomfirm.Size = new System.Drawing.Size(86, 46);
            this.buttoncomfirm.TabIndex = 11;
            this.buttoncomfirm.Text = "confirmer";
            this.buttoncomfirm.UseVisualStyleBackColor = false;
            this.buttoncomfirm.Click += new System.EventHandler(this.buttoncomfirm_Click);
            // 
            // buttonannul
            // 
            this.buttonannul.BackColor = System.Drawing.Color.Gray;
            this.buttonannul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonannul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonannul.Location = new System.Drawing.Point(562, 344);
            this.buttonannul.Name = "buttonannul";
            this.buttonannul.Size = new System.Drawing.Size(85, 46);
            this.buttonannul.TabIndex = 12;
            this.buttonannul.Text = "annuler";
            this.buttonannul.UseVisualStyleBackColor = false;
            this.buttonannul.Click += new System.EventHandler(this.buttonannul_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(90, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 178);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idcar";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "marque";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "color";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "mtricule";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonannul);
            this.Controls.Add(this.buttoncomfirm);
            this.Controls.Add(this.buttonsupp);
            this.Controls.Add(this.buttmodifier);
            this.Controls.Add(this.buttajouute);
            this.Controls.Add(this.labematricule);
            this.Controls.Add(this.color);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelmarque);
            this.Controls.Add(this.idcar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idcar;
        private System.Windows.Forms.Label labelmarque;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label labematricule;
        private System.Windows.Forms.Button buttajouute;
        private System.Windows.Forms.Button buttmodifier;
        private System.Windows.Forms.Button buttonsupp;
        private System.Windows.Forms.Button buttoncomfirm;
        private System.Windows.Forms.Button buttonannul;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

