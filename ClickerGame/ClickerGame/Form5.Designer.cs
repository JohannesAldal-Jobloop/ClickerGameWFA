namespace ClickerGame
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.playfield = new System.Windows.Forms.TableLayoutPanel();
            this.scoreTitle = new System.Windows.Forms.Label();
            this.scoreTekst = new System.Windows.Forms.Label();
            this.nextPiceTitle = new System.Windows.Forms.Label();
            this.nextPicePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.levelTitle = new System.Windows.Forms.Label();
            this.levelText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playfield
            // 
            this.playfield.ColumnCount = 10;
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playfield.Location = new System.Drawing.Point(320, 62);
            this.playfield.Name = "playfield";
            this.playfield.RowCount = 16;
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.playfield.Size = new System.Drawing.Size(187, 342);
            this.playfield.TabIndex = 0;
            // 
            // scoreTitle
            // 
            this.scoreTitle.AutoSize = true;
            this.scoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.Location = new System.Drawing.Point(629, 25);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(73, 20);
            this.scoreTitle.TabIndex = 0;
            this.scoreTitle.Text = "SCORE";
            // 
            // scoreTekst
            // 
            this.scoreTekst.AutoSize = true;
            this.scoreTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTekst.Location = new System.Drawing.Point(630, 45);
            this.scoreTekst.Name = "scoreTekst";
            this.scoreTekst.Size = new System.Drawing.Size(72, 20);
            this.scoreTekst.TabIndex = 1;
            this.scoreTekst.Text = "0000000";
            // 
            // nextPiceTitle
            // 
            this.nextPiceTitle.AutoSize = true;
            this.nextPiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPiceTitle.Location = new System.Drawing.Point(630, 139);
            this.nextPiceTitle.Name = "nextPiceTitle";
            this.nextPiceTitle.Size = new System.Drawing.Size(57, 20);
            this.nextPiceTitle.TabIndex = 2;
            this.nextPiceTitle.Text = "NEXT";
            // 
            // nextPicePanel
            // 
            this.nextPicePanel.Location = new System.Drawing.Point(611, 162);
            this.nextPicePanel.Name = "nextPicePanel";
            this.nextPicePanel.Size = new System.Drawing.Size(100, 100);
            this.nextPicePanel.TabIndex = 3;
            // 
            // levelTitle
            // 
            this.levelTitle.AutoSize = true;
            this.levelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelTitle.Location = new System.Drawing.Point(629, 302);
            this.levelTitle.Name = "levelTitle";
            this.levelTitle.Size = new System.Drawing.Size(54, 20);
            this.levelTitle.TabIndex = 0;
            this.levelTitle.Text = "Level";
            // 
            // levelText
            // 
            this.levelText.AutoSize = true;
            this.levelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelText.Location = new System.Drawing.Point(631, 322);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(18, 20);
            this.levelText.TabIndex = 4;
            this.levelText.Text = "0";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levelText);
            this.Controls.Add(this.levelTitle);
            this.Controls.Add(this.nextPicePanel);
            this.Controls.Add(this.nextPiceTitle);
            this.Controls.Add(this.scoreTekst);
            this.Controls.Add(this.scoreTitle);
            this.Controls.Add(this.playfield);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel playfield;
        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Label scoreTekst;
        private System.Windows.Forms.Label nextPiceTitle;
        private System.Windows.Forms.FlowLayoutPanel nextPicePanel;
        private System.Windows.Forms.Label levelTitle;
        private System.Windows.Forms.Label levelText;
        private System.Windows.Forms.Timer timer1;
    }
}