﻿namespace ClickerGame
{
    partial class Form4
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
            this.snakeGrid = new System.Windows.Forms.TableLayoutPanel();
            this.apple = new System.Windows.Forms.FlowLayoutPanel();
            this.snake = new System.Windows.Forms.FlowLayoutPanel();
            this.snakeGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // snakeGrid
            // 
            this.snakeGrid.ColumnCount = 10;
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.Controls.Add(this.apple, 0, 0);
            this.snakeGrid.Controls.Add(this.snake, 6, 4);
            this.snakeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snakeGrid.Location = new System.Drawing.Point(0, 0);
            this.snakeGrid.Name = "snakeGrid";
            this.snakeGrid.RowCount = 10;
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.snakeGrid.Size = new System.Drawing.Size(682, 653);
            this.snakeGrid.TabIndex = 0;
            // 
            // apple
            // 
            this.apple.BackColor = System.Drawing.Color.Red;
            this.apple.Location = new System.Drawing.Point(3, 3);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(62, 59);
            this.apple.TabIndex = 0;
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.LimeGreen;
            this.snake.Location = new System.Drawing.Point(411, 263);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(62, 59);
            this.snake.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.snakeGrid);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Activated += new System.EventHandler(this.Form4_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            this.snakeGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel snakeGrid;
        private System.Windows.Forms.FlowLayoutPanel apple;
        private System.Windows.Forms.FlowLayoutPanel snake;
    }
}