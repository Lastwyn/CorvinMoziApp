
namespace CorvinMoziApp
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.mentes = new System.Windows.Forms.Button();
            this.statisztika = new System.Windows.Forms.Button();
            this.jobbnyil = new System.Windows.Forms.PictureBox();
            this.ballnyil = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobbnyil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballnyil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(206, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(555, 238);
            this.panel.TabIndex = 0;
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(38, 230);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(125, 39);
            this.mentes.TabIndex = 2;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // statisztika
            // 
            this.statisztika.Location = new System.Drawing.Point(38, 302);
            this.statisztika.Name = "statisztika";
            this.statisztika.Size = new System.Drawing.Size(125, 39);
            this.statisztika.TabIndex = 3;
            this.statisztika.Text = "Statisztika";
            this.statisztika.UseVisualStyleBackColor = true;
            // 
            // jobbnyil
            // 
            this.jobbnyil.BackgroundImage = global::CorvinMoziApp.Properties.Resources.jobbra;
            this.jobbnyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobbnyil.Location = new System.Drawing.Point(464, 320);
            this.jobbnyil.Name = "jobbnyil";
            this.jobbnyil.Size = new System.Drawing.Size(126, 50);
            this.jobbnyil.TabIndex = 5;
            this.jobbnyil.TabStop = false;
            this.jobbnyil.Click += new System.EventHandler(this.jobbnyil_Click);
            // 
            // ballnyil
            // 
            this.ballnyil.BackgroundImage = global::CorvinMoziApp.Properties.Resources.balnyil;
            this.ballnyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ballnyil.Location = new System.Drawing.Point(233, 320);
            this.ballnyil.Name = "ballnyil";
            this.ballnyil.Size = new System.Drawing.Size(126, 50);
            this.ballnyil.TabIndex = 4;
            this.ballnyil.TabStop = false;
            this.ballnyil.Click += new System.EventHandler(this.ballnyil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(38, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobbnyil);
            this.Controls.Add(this.ballnyil);
            this.Controls.Add(this.statisztika);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobbnyil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballnyil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button statisztika;
        private System.Windows.Forms.PictureBox ballnyil;
        private System.Windows.Forms.PictureBox jobbnyil;
    }
}

