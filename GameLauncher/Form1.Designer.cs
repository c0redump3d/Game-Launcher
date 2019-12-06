namespace GameLauncher
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
            this.infoTetris = new MaterialSkin.Controls.MaterialRaisedButton();
            this.downloadGameButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gameDescription = new System.Windows.Forms.Label();
            this.gameNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.backButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.infoPaint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.infoSnake = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updateLog = new System.Windows.Forms.TextBox();
            this.snakeGamePicture = new System.Windows.Forms.PictureBox();
            this.paintAppPicture = new System.Windows.Forms.PictureBox();
            this.tetrisPicture = new System.Windows.Forms.PictureBox();
            this.gameMenuPicture = new System.Windows.Forms.PictureBox();
            this.inGamePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakeGamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintAppPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMenuPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inGamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // infoTetris
            // 
            this.infoTetris.AutoSize = true;
            this.infoTetris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoTetris.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.infoTetris.Depth = 0;
            this.infoTetris.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.infoTetris.Icon = null;
            this.infoTetris.Location = new System.Drawing.Point(117, 237);
            this.infoTetris.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.infoTetris.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoTetris.Name = "infoTetris";
            this.infoTetris.Primary = true;
            this.infoTetris.Size = new System.Drawing.Size(52, 36);
            this.infoTetris.TabIndex = 8;
            this.infoTetris.Text = "Info";
            this.infoTetris.UseVisualStyleBackColor = false;
            this.infoTetris.Click += new System.EventHandler(this.infoTetris_Click);
            // 
            // downloadGameButton
            // 
            this.downloadGameButton.AutoSize = true;
            this.downloadGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadGameButton.Depth = 0;
            this.downloadGameButton.Icon = null;
            this.downloadGameButton.Location = new System.Drawing.Point(627, 444);
            this.downloadGameButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.downloadGameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadGameButton.Name = "downloadGameButton";
            this.downloadGameButton.Primary = true;
            this.downloadGameButton.Size = new System.Drawing.Size(96, 36);
            this.downloadGameButton.TabIndex = 24;
            this.downloadGameButton.Text = "Download";
            this.downloadGameButton.UseVisualStyleBackColor = true;
            this.downloadGameButton.Visible = false;
            this.downloadGameButton.Click += new System.EventHandler(this.downloadGameButton_Click);
            // 
            // gameDescription
            // 
            this.gameDescription.AutoSize = true;
            this.gameDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.gameDescription.Location = new System.Drawing.Point(570, 156);
            this.gameDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameDescription.Name = "gameDescription";
            this.gameDescription.Size = new System.Drawing.Size(245, 108);
            this.gameDescription.TabIndex = 23;
            this.gameDescription.Text = "Tetris - just as you remember, but \r\nwith a few twists. With this game,\r\nyou can " +
    "select any level to start on,\r\nand higher the level, the more \r\nchallenge. This " +
    "game also \r\nsupports controllers!\r\n";
            this.gameDescription.Visible = false;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Depth = 0;
            this.gameNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.gameNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameNameLabel.Location = new System.Drawing.Point(364, 87);
            this.gameNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(48, 19);
            this.gameNameLabel.TabIndex = 20;
            this.gameNameLabel.Text = "Tetris";
            this.gameNameLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Depth = 0;
            this.backButton.Icon = null;
            this.backButton.Location = new System.Drawing.Point(11, 70);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.Primary = true;
            this.backButton.Size = new System.Drawing.Size(56, 36);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // infoPaint
            // 
            this.infoPaint.AutoSize = true;
            this.infoPaint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoPaint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.infoPaint.Depth = 0;
            this.infoPaint.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.infoPaint.Icon = null;
            this.infoPaint.Location = new System.Drawing.Point(415, 237);
            this.infoPaint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.infoPaint.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoPaint.Name = "infoPaint";
            this.infoPaint.Primary = true;
            this.infoPaint.Size = new System.Drawing.Size(52, 36);
            this.infoPaint.TabIndex = 25;
            this.infoPaint.Text = "Info";
            this.infoPaint.UseVisualStyleBackColor = false;
            this.infoPaint.Click += new System.EventHandler(this.infoPaint_Click);
            // 
            // infoSnake
            // 
            this.infoSnake.AutoSize = true;
            this.infoSnake.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoSnake.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.infoSnake.Depth = 0;
            this.infoSnake.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.infoSnake.Icon = null;
            this.infoSnake.Location = new System.Drawing.Point(117, 457);
            this.infoSnake.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.infoSnake.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoSnake.Name = "infoSnake";
            this.infoSnake.Primary = true;
            this.infoSnake.Size = new System.Drawing.Size(52, 36);
            this.infoSnake.TabIndex = 27;
            this.infoSnake.Text = "Info";
            this.infoSnake.UseVisualStyleBackColor = false;
            this.infoSnake.Click += new System.EventHandler(this.SnakeInfo_Click);
            // 
            // updateLog
            // 
            this.updateLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateLog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLog.ForeColor = System.Drawing.SystemColors.Control;
            this.updateLog.Location = new System.Drawing.Point(570, 276);
            this.updateLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updateLog.Multiline = true;
            this.updateLog.Name = "updateLog";
            this.updateLog.ReadOnly = true;
            this.updateLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.updateLog.Size = new System.Drawing.Size(245, 157);
            this.updateLog.TabIndex = 28;
            this.updateLog.Visible = false;
            // 
            // snakeGamePicture
            // 
            this.snakeGamePicture.Image = global::GameLauncher.Properties.Resources.snakeLogo;
            this.snakeGamePicture.Location = new System.Drawing.Point(26, 300);
            this.snakeGamePicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.snakeGamePicture.Name = "snakeGamePicture";
            this.snakeGamePicture.Size = new System.Drawing.Size(250, 200);
            this.snakeGamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snakeGamePicture.TabIndex = 7;
            this.snakeGamePicture.TabStop = false;
            // 
            // paintAppPicture
            // 
            this.paintAppPicture.Image = global::GameLauncher.Properties.Resources.paint;
            this.paintAppPicture.Location = new System.Drawing.Point(316, 78);
            this.paintAppPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.paintAppPicture.Name = "paintAppPicture";
            this.paintAppPicture.Size = new System.Drawing.Size(250, 200);
            this.paintAppPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paintAppPicture.TabIndex = 6;
            this.paintAppPicture.TabStop = false;
            // 
            // tetrisPicture
            // 
            this.tetrisPicture.BackColor = System.Drawing.Color.Transparent;
            this.tetrisPicture.Image = global::GameLauncher.Properties.Resources.tetris_logo;
            this.tetrisPicture.Location = new System.Drawing.Point(26, 78);
            this.tetrisPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tetrisPicture.Name = "tetrisPicture";
            this.tetrisPicture.Size = new System.Drawing.Size(250, 200);
            this.tetrisPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tetrisPicture.TabIndex = 5;
            this.tetrisPicture.TabStop = false;
            // 
            // gameMenuPicture
            // 
            this.gameMenuPicture.BackColor = System.Drawing.Color.Transparent;
            this.gameMenuPicture.Image = global::GameLauncher.Properties.Resources.tetrisCapture;
            this.gameMenuPicture.Location = new System.Drawing.Point(11, 132);
            this.gameMenuPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gameMenuPicture.Name = "gameMenuPicture";
            this.gameMenuPicture.Size = new System.Drawing.Size(265, 365);
            this.gameMenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameMenuPicture.TabIndex = 21;
            this.gameMenuPicture.TabStop = false;
            this.gameMenuPicture.Visible = false;
            // 
            // inGamePicture
            // 
            this.inGamePicture.BackColor = System.Drawing.Color.Transparent;
            this.inGamePicture.Image = global::GameLauncher.Properties.Resources.tetrisGameplay;
            this.inGamePicture.Location = new System.Drawing.Point(286, 132);
            this.inGamePicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inGamePicture.Name = "inGamePicture";
            this.inGamePicture.Size = new System.Drawing.Size(265, 365);
            this.inGamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inGamePicture.TabIndex = 22;
            this.inGamePicture.TabStop = false;
            this.inGamePicture.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 510);
            this.Controls.Add(this.gameMenuPicture);
            this.Controls.Add(this.updateLog);
            this.Controls.Add(this.infoSnake);
            this.Controls.Add(this.infoPaint);
            this.Controls.Add(this.downloadGameButton);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.infoTetris);
            this.Controls.Add(this.snakeGamePicture);
            this.Controls.Add(this.paintAppPicture);
            this.Controls.Add(this.tetrisPicture);
            this.Controls.Add(this.gameDescription);
            this.Controls.Add(this.inGamePicture);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Game Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.snakeGamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintAppPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMenuPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inGamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox tetrisPicture;
        private System.Windows.Forms.PictureBox paintAppPicture;
        private System.Windows.Forms.PictureBox snakeGamePicture;
        private MaterialSkin.Controls.MaterialRaisedButton infoTetris;
        private MaterialSkin.Controls.MaterialRaisedButton downloadGameButton;
        private System.Windows.Forms.Label gameDescription;
        private System.Windows.Forms.PictureBox inGamePicture;
        private System.Windows.Forms.PictureBox gameMenuPicture;
        private MaterialSkin.Controls.MaterialLabel gameNameLabel;
        private MaterialSkin.Controls.MaterialRaisedButton backButton;
        private MaterialSkin.Controls.MaterialRaisedButton infoPaint;
        private MaterialSkin.Controls.MaterialRaisedButton infoSnake;
        private System.Windows.Forms.TextBox updateLog;
    }
}

