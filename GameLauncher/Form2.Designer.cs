namespace GameLauncher
{
    partial class Form2
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.libraryButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.homeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tetrisMenuPicture = new System.Windows.Forms.PictureBox();
            this.tetrisInGamePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadTetrisButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisMenuPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisInGamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(98, 64);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(13, 385);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // libraryButton
            // 
            this.libraryButton.AutoSize = true;
            this.libraryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.libraryButton.Depth = 0;
            this.libraryButton.Icon = null;
            this.libraryButton.Location = new System.Drawing.Point(12, 122);
            this.libraryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.libraryButton.Name = "libraryButton";
            this.libraryButton.Primary = true;
            this.libraryButton.Size = new System.Drawing.Size(76, 36);
            this.libraryButton.TabIndex = 10;
            this.libraryButton.Text = "Library";
            this.libraryButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = true;
            this.homeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeButton.Depth = 0;
            this.homeButton.Icon = null;
            this.homeButton.Location = new System.Drawing.Point(12, 75);
            this.homeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.homeButton.Name = "homeButton";
            this.homeButton.Primary = true;
            this.homeButton.Size = new System.Drawing.Size(60, 36);
            this.homeButton.TabIndex = 9;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(117, 75);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(56, 36);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "Back";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(428, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Tetris";
            // 
            // tetrisMenuPicture
            // 
            this.tetrisMenuPicture.BackColor = System.Drawing.Color.Transparent;
            this.tetrisMenuPicture.Image = global::GameLauncher.Properties.Resources.tetrisCapture;
            this.tetrisMenuPicture.Location = new System.Drawing.Point(117, 122);
            this.tetrisMenuPicture.Name = "tetrisMenuPicture";
            this.tetrisMenuPicture.Size = new System.Drawing.Size(212, 321);
            this.tetrisMenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tetrisMenuPicture.TabIndex = 15;
            this.tetrisMenuPicture.TabStop = false;
            // 
            // tetrisInGamePicture
            // 
            this.tetrisInGamePicture.BackColor = System.Drawing.Color.Transparent;
            this.tetrisInGamePicture.Image = global::GameLauncher.Properties.Resources.tetrisGameplay;
            this.tetrisInGamePicture.Location = new System.Drawing.Point(335, 122);
            this.tetrisInGamePicture.Name = "tetrisInGamePicture";
            this.tetrisInGamePicture.Size = new System.Drawing.Size(212, 321);
            this.tetrisInGamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tetrisInGamePicture.TabIndex = 16;
            this.tetrisInGamePicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 108);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tetris - just as you remember, but \r\nwith a few twists. With this game,\r\nyou can " +
    "select any level to start on,\r\nand higher the level, the more \r\nchallenge. This " +
    "game also \r\nsupports controllers!\r\n";
            // 
            // downloadTetrisButton
            // 
            this.downloadTetrisButton.AutoSize = true;
            this.downloadTetrisButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadTetrisButton.Depth = 0;
            this.downloadTetrisButton.Icon = null;
            this.downloadTetrisButton.Location = new System.Drawing.Point(620, 340);
            this.downloadTetrisButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadTetrisButton.Name = "downloadTetrisButton";
            this.downloadTetrisButton.Primary = true;
            this.downloadTetrisButton.Size = new System.Drawing.Size(96, 36);
            this.downloadTetrisButton.TabIndex = 18;
            this.downloadTetrisButton.Text = "Download";
            this.downloadTetrisButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downloadTetrisButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tetrisInGamePicture);
            this.Controls.Add(this.tetrisMenuPicture);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.libraryButton);
            this.Controls.Add(this.homeButton);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tetrisMenuPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisInGamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton libraryButton;
        private MaterialSkin.Controls.MaterialRaisedButton homeButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox tetrisMenuPicture;
        private System.Windows.Forms.PictureBox tetrisInGamePicture;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton downloadTetrisButton;
    }
}