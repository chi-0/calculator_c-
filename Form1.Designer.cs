namespace Caculator_cy
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
            display = new Label();
            keyLayout = new TableLayoutPanel();
            ButtonSub = new Button();
            ButtonPoint = new Button();
            Reset = new Button();
            Button0 = new Button();
            ButtonAdd = new Button();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            ButtonMul = new Button();
            Button6 = new Button();
            Button5 = new Button();
            Button4 = new Button();
            ButtonDiv = new Button();
            Button9 = new Button();
            Button8 = new Button();
            Button7 = new Button();
            ButtonResult = new Button();
            keyLayout.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("돋움", 24F, FontStyle.Bold);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(320, 54);
            display.TabIndex = 0;
            display.Text = "0";
            display.TextAlign = ContentAlignment.MiddleRight;
            // 
            // keyLayout
            // 
            keyLayout.ColumnCount = 4;
            keyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            keyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            keyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            keyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            keyLayout.Controls.Add(ButtonSub, 3, 3);
            keyLayout.Controls.Add(ButtonPoint, 2, 3);
            keyLayout.Controls.Add(Reset, 1, 3);
            keyLayout.Controls.Add(Button0, 0, 3);
            keyLayout.Controls.Add(ButtonAdd, 3, 2);
            keyLayout.Controls.Add(Button3, 2, 2);
            keyLayout.Controls.Add(Button2, 1, 2);
            keyLayout.Controls.Add(Button1, 0, 2);
            keyLayout.Controls.Add(ButtonMul, 3, 1);
            keyLayout.Controls.Add(Button6, 2, 1);
            keyLayout.Controls.Add(Button5, 1, 1);
            keyLayout.Controls.Add(Button4, 0, 1);
            keyLayout.Controls.Add(ButtonDiv, 3, 0);
            keyLayout.Controls.Add(Button9, 2, 0);
            keyLayout.Controls.Add(Button8, 1, 0);
            keyLayout.Controls.Add(Button7, 0, 0);
            keyLayout.Location = new Point(0, 57);
            keyLayout.Name = "keyLayout";
            keyLayout.RowCount = 4;
            keyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            keyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            keyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            keyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            keyLayout.Size = new Size(320, 320);
            keyLayout.TabIndex = 1;
            // 
            // ButtonSub
            // 
            ButtonSub.Font = new Font("돋움", 20F, FontStyle.Bold);
            ButtonSub.Location = new Point(243, 243);
            ButtonSub.Name = "ButtonSub";
            ButtonSub.Size = new Size(74, 74);
            ButtonSub.TabIndex = 15;
            ButtonSub.Tag = "Subtract";
            ButtonSub.Text = "-";
            ButtonSub.UseVisualStyleBackColor = true;
            ButtonSub.Click += OperatorButton;
            // 
            // ButtonPoint
            // 
            ButtonPoint.Font = new Font("돋움", 20F, FontStyle.Bold);
            ButtonPoint.Location = new Point(163, 243);
            ButtonPoint.Name = "ButtonPoint";
            ButtonPoint.Size = new Size(74, 74);
            ButtonPoint.TabIndex = 14;
            ButtonPoint.Text = ".";
            ButtonPoint.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            Reset.Font = new Font("돋움", 20F, FontStyle.Bold);
            Reset.Location = new Point(83, 243);
            Reset.Name = "Reset";
            Reset.Size = new Size(74, 74);
            Reset.TabIndex = 13;
            Reset.Text = "AC";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Button0
            // 
            Button0.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button0.Location = new Point(3, 243);
            Button0.Name = "Button0";
            Button0.Size = new Size(74, 74);
            Button0.TabIndex = 12;
            Button0.Text = "0";
            Button0.UseVisualStyleBackColor = true;
            Button0.Click += NumButton_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Font = new Font("돋움", 20F, FontStyle.Bold);
            ButtonAdd.Location = new Point(243, 163);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(74, 74);
            ButtonAdd.TabIndex = 11;
            ButtonAdd.Tag = "Add";
            ButtonAdd.Text = "+";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += OperatorButton;
            // 
            // Button3
            // 
            Button3.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button3.Location = new Point(163, 163);
            Button3.Name = "Button3";
            Button3.Size = new Size(74, 74);
            Button3.TabIndex = 10;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += NumButton_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button2.Location = new Point(83, 163);
            Button2.Name = "Button2";
            Button2.Size = new Size(74, 74);
            Button2.TabIndex = 9;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += NumButton_Click;
            // 
            // Button1
            // 
            Button1.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button1.Location = new Point(3, 163);
            Button1.Name = "Button1";
            Button1.Size = new Size(74, 74);
            Button1.TabIndex = 8;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += NumButton_Click;
            // 
            // ButtonMul
            // 
            ButtonMul.Font = new Font("돋움", 20F, FontStyle.Bold);
            ButtonMul.Location = new Point(243, 83);
            ButtonMul.Name = "ButtonMul";
            ButtonMul.Size = new Size(74, 74);
            ButtonMul.TabIndex = 7;
            ButtonMul.Tag = "Multiply";
            ButtonMul.Text = "*";
            ButtonMul.UseVisualStyleBackColor = true;
            ButtonMul.Click += OperatorButton;
            // 
            // Button6
            // 
            Button6.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button6.Location = new Point(163, 83);
            Button6.Name = "Button6";
            Button6.Size = new Size(74, 74);
            Button6.TabIndex = 6;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = true;
            Button6.Click += NumButton_Click;
            // 
            // Button5
            // 
            Button5.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button5.Location = new Point(83, 83);
            Button5.Name = "Button5";
            Button5.Size = new Size(74, 74);
            Button5.TabIndex = 5;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = true;
            Button5.Click += NumButton_Click;
            // 
            // Button4
            // 
            Button4.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button4.Location = new Point(3, 83);
            Button4.Name = "Button4";
            Button4.Size = new Size(74, 74);
            Button4.TabIndex = 4;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += NumButton_Click;
            // 
            // ButtonDiv
            // 
            ButtonDiv.Font = new Font("돋움", 20F, FontStyle.Bold);
            ButtonDiv.Location = new Point(243, 3);
            ButtonDiv.Name = "ButtonDiv";
            ButtonDiv.Size = new Size(74, 74);
            ButtonDiv.TabIndex = 3;
            ButtonDiv.Tag = "Divide";
            ButtonDiv.Text = "/";
            ButtonDiv.UseVisualStyleBackColor = true;
            ButtonDiv.Click += OperatorButton;
            // 
            // Button9
            // 
            Button9.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button9.Location = new Point(163, 3);
            Button9.Name = "Button9";
            Button9.Size = new Size(74, 74);
            Button9.TabIndex = 2;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = true;
            Button9.Click += NumButton_Click;
            // 
            // Button8
            // 
            Button8.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button8.Location = new Point(83, 3);
            Button8.Name = "Button8";
            Button8.Size = new Size(74, 74);
            Button8.TabIndex = 1;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = true;
            Button8.Click += NumButton_Click;
            // 
            // Button7
            // 
            Button7.Font = new Font("돋움", 20F, FontStyle.Bold);
            Button7.Location = new Point(3, 3);
            Button7.Name = "Button7";
            Button7.Size = new Size(74, 74);
            Button7.TabIndex = 0;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = true;
            Button7.Click += NumButton_Click;
            // 
            // ButtonResult
            // 
            ButtonResult.Dock = DockStyle.Bottom;
            ButtonResult.Font = new Font("돋움", 20F, FontStyle.Bold);
            ButtonResult.Location = new Point(0, 380);
            ButtonResult.Name = "ButtonResult";
            ButtonResult.Size = new Size(320, 54);
            ButtonResult.TabIndex = 16;
            ButtonResult.Text = "=";
            ButtonResult.UseVisualStyleBackColor = true;
            ButtonResult.Click += ButtonResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 434);
            Controls.Add(ButtonResult);
            Controls.Add(keyLayout);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            keyLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private TableLayoutPanel keyLayout;
        private Button Button7;
        private Button ButtonPoint;
        private Button Reset;
        private Button Button0;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private Button Button9;
        private Button Button8;
        private Button ButtonSub;
        private Button ButtonAdd;
        private Button ButtonMul;
        private Button ButtonDiv;
        private Button ButtonResult;
    }
}
