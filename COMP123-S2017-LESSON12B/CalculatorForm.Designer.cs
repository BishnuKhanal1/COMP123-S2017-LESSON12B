namespace COMP123_S2017_LESSON12B
{
    partial class CalculatorForm
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
            this.ButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonTimes = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonTableLayoutPanel
            // 
            this.ButtonTableLayoutPanel.ColumnCount = 4;
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonDecimal, 2, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonZero, 1, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.PlusMinus, 0, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonPlus, 3, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonThree, 2, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonTwo, 1, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonOne, 0, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonMinus, 3, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonSix, 2, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonFive, 1, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonFour, 0, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonTimes, 3, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonEight, 1, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.BackSpaceButton, 2, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.ClearButton, 0, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonNine, 2, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonEquals, 3, 4);
            this.ButtonTableLayoutPanel.Location = new System.Drawing.Point(1, 138);
            this.ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            this.ButtonTableLayoutPanel.RowCount = 5;
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.Size = new System.Drawing.Size(304, 307);
            this.ButtonTableLayoutPanel.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(4, 57);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(296, 60);
            this.ResultTextBox.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ButtonTableLayoutPanel.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(142, 55);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpaceButton.Location = new System.Drawing.Point(155, 3);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(68, 53);
            this.BackSpaceButton.TabIndex = 2;
            this.BackSpaceButton.Text = "⌫";
            this.BackSpaceButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(231, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(68, 53);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.White;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(3, 64);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(68, 53);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.Color.White;
            this.ButtonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEight.Location = new System.Drawing.Point(79, 64);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(68, 53);
            this.ButtonEight.TabIndex = 5;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = false;
            // 
            // ButtonNine
            // 
            this.ButtonNine.BackColor = System.Drawing.Color.White;
            this.ButtonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNine.Location = new System.Drawing.Point(155, 64);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(68, 53);
            this.ButtonNine.TabIndex = 6;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = false;
            // 
            // ButtonTimes
            // 
            this.ButtonTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTimes.Location = new System.Drawing.Point(231, 64);
            this.ButtonTimes.Name = "ButtonTimes";
            this.ButtonTimes.Size = new System.Drawing.Size(68, 53);
            this.ButtonTimes.TabIndex = 7;
            this.ButtonTimes.Text = "x";
            this.ButtonTimes.UseVisualStyleBackColor = true;
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.Color.White;
            this.ButtonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFour.Location = new System.Drawing.Point(3, 125);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(68, 53);
            this.ButtonFour.TabIndex = 8;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = false;
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.Color.White;
            this.ButtonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFive.Location = new System.Drawing.Point(79, 125);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(68, 53);
            this.ButtonFive.TabIndex = 9;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = false;
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.Color.White;
            this.ButtonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSix.Location = new System.Drawing.Point(155, 125);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(68, 53);
            this.ButtonSix.TabIndex = 10;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = false;
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinus.Location = new System.Drawing.Point(231, 125);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(68, 53);
            this.ButtonMinus.TabIndex = 11;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.Color.White;
            this.ButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOne.Location = new System.Drawing.Point(3, 186);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(68, 53);
            this.ButtonOne.TabIndex = 12;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = false;
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.Color.White;
            this.ButtonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTwo.Location = new System.Drawing.Point(79, 186);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(68, 53);
            this.ButtonTwo.TabIndex = 13;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.Color.White;
            this.ButtonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThree.Location = new System.Drawing.Point(155, 186);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(68, 53);
            this.ButtonThree.TabIndex = 14;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = false;
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlus.Location = new System.Drawing.Point(231, 186);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(68, 53);
            this.ButtonPlus.TabIndex = 15;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            // 
            // PlusMinus
            // 
            this.PlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinus.Location = new System.Drawing.Point(3, 247);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(68, 53);
            this.PlusMinus.TabIndex = 16;
            this.PlusMinus.Text = "±";
            this.PlusMinus.UseVisualStyleBackColor = true;
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.Color.White;
            this.ButtonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZero.Location = new System.Drawing.Point(79, 247);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(68, 53);
            this.ButtonZero.TabIndex = 17;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.BackColor = System.Drawing.Color.White;
            this.ButtonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDecimal.Location = new System.Drawing.Point(155, 247);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(68, 53);
            this.ButtonDecimal.TabIndex = 18;
            this.ButtonDecimal.Text = ".";
            this.ButtonDecimal.UseVisualStyleBackColor = false;
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.BackColor = System.Drawing.Color.SkyBlue;
            this.ButtonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquals.Location = new System.Drawing.Point(231, 247);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(68, 53);
            this.ButtonEquals.TabIndex = 19;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ButtonTableLayoutPanel);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPanel;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonDecimal;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonTimes;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button BackSpaceButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

