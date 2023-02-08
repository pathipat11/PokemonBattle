namespace PokemonBattle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pichu = new System.Windows.Forms.Button();
            this.Pikachu = new System.Windows.Forms.Button();
            this.Froakie = new System.Windows.Forms.Button();
            this.Greninja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Attack = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbHPMon = new System.Windows.Forms.TextBox();
            this.tbNameMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokemonBattle.Properties.Resources._172;
            this.pictureBox1.Location = new System.Drawing.Point(12, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pichu
            // 
            this.Pichu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pichu.Location = new System.Drawing.Point(22, 38);
            this.Pichu.Name = "Pichu";
            this.Pichu.Size = new System.Drawing.Size(94, 34);
            this.Pichu.TabIndex = 2;
            this.Pichu.Text = "Pichu";
            this.Pichu.UseVisualStyleBackColor = true;
            this.Pichu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pikachu
            // 
            this.Pikachu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pikachu.Location = new System.Drawing.Point(22, 78);
            this.Pikachu.Name = "Pikachu";
            this.Pikachu.Size = new System.Drawing.Size(94, 34);
            this.Pikachu.TabIndex = 3;
            this.Pikachu.Text = "Pikachu";
            this.Pikachu.UseVisualStyleBackColor = true;
            this.Pikachu.Click += new System.EventHandler(this.button2_Click);
            // 
            // Froakie
            // 
            this.Froakie.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Froakie.Location = new System.Drawing.Point(22, 118);
            this.Froakie.Name = "Froakie";
            this.Froakie.Size = new System.Drawing.Size(94, 34);
            this.Froakie.TabIndex = 4;
            this.Froakie.Text = "Froakie";
            this.Froakie.UseVisualStyleBackColor = true;
            this.Froakie.Click += new System.EventHandler(this.button3_Click);
            // 
            // Greninja
            // 
            this.Greninja.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Greninja.Location = new System.Drawing.Point(22, 158);
            this.Greninja.Name = "Greninja";
            this.Greninja.Size = new System.Drawing.Size(94, 34);
            this.Greninja.TabIndex = 5;
            this.Greninja.Text = "Greninja";
            this.Greninja.UseVisualStyleBackColor = true;
            this.Greninja.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Pikachu);
            this.groupBox1.Controls.Add(this.Greninja);
            this.groupBox1.Controls.Add(this.Pichu);
            this.groupBox1.Controls.Add(this.Froakie);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Pokemon";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.Attack);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(580, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 184);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(30, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 34);
            this.button5.TabIndex = 3;
            this.button5.Text = "HP + 50";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Attack
            // 
            this.Attack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Attack.Location = new System.Drawing.Point(30, 40);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(147, 34);
            this.Attack.TabIndex = 2;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(30, 120);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 34);
            this.button8.TabIndex = 4;
            this.button8.Text = "Defense + 50";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(218, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "HP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(290, 381);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 31);
            this.tbName.TabIndex = 10;
            // 
            // tbHP
            // 
            this.tbHP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbHP.Location = new System.Drawing.Point(290, 418);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(165, 31);
            this.tbHP.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PokemonBattle.Properties.Resources._006;
            this.pictureBox2.Location = new System.Drawing.Point(589, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // tbHPMon
            // 
            this.tbHPMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbHPMon.Location = new System.Drawing.Point(404, 53);
            this.tbHPMon.Name = "tbHPMon";
            this.tbHPMon.Size = new System.Drawing.Size(165, 31);
            this.tbHPMon.TabIndex = 16;
            this.tbHPMon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNameMon
            // 
            this.tbNameMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNameMon.Location = new System.Drawing.Point(404, 16);
            this.tbNameMon.Name = "tbNameMon";
            this.tbNameMon.Size = new System.Drawing.Size(165, 31);
            this.tbNameMon.TabIndex = 15;
            this.tbNameMon.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(332, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "HP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(332, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonBattle.Properties.Resources.d843okx_eb13e8e4_0fa4_4fa9_968a_e0f36ff168de;
            this.ClientSize = new System.Drawing.Size(796, 480);
            this.Controls.Add(this.tbHPMon);
            this.Controls.Add(this.tbNameMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbHP);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Pichu;
        private Button Pikachu;
        private Button Froakie;
        private Button Greninja;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private Button Attack;
        private Button button8;
        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbHP;
        private PictureBox pictureBox2;
        private TextBox tbHPMon;
        private TextBox tbNameMon;
        private Label label3;
        private Label label4;
    }
}