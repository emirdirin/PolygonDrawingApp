

namespace B231202375
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
            centerPointxText = new TextBox();
            centerPointyText = new TextBox();
            lengthText = new TextBox();
            edgeNumberText = new TextBox();
            rotationAngleText = new TextBox();
            verticesPointListBox = new ListBox();
            randomValueButton = new Button();
            drawGraphButton = new Button();
            rotateShapeButton = new Button();
            graphPictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)graphPictureBox).BeginInit();
            SuspendLayout();
            // 
            // centerPointxText
            // 
            centerPointxText.Location = new Point(164, 52);
            centerPointxText.Name = "centerPointxText";
            centerPointxText.Size = new Size(125, 27);
            centerPointxText.TabIndex = 0;
            centerPointxText.Text = "0";
            centerPointxText.TextChanged += centerPointxText_TextChanged;
            // 
            // centerPointyText
            // 
            centerPointyText.Location = new Point(308, 52);
            centerPointyText.Name = "centerPointyText";
            centerPointyText.Size = new Size(125, 27);
            centerPointyText.TabIndex = 1;
            centerPointyText.Text = "0";
            centerPointyText.TextChanged += centerPointyText_TextChanged;
            // 
            // lengthText
            // 
            lengthText.Location = new Point(164, 102);
            lengthText.Name = "lengthText";
            lengthText.Size = new Size(125, 27);
            lengthText.TabIndex = 2;
            lengthText.Text = "4";
            lengthText.TextChanged += lengthText_TextChanged;
            // 
            // edgeNumberText
            // 
            edgeNumberText.Location = new Point(164, 159);
            edgeNumberText.Name = "edgeNumberText";
            edgeNumberText.Size = new Size(125, 27);
            edgeNumberText.TabIndex = 3;
            edgeNumberText.Text = "5";
            edgeNumberText.TextChanged += edgeNumberText_TextChanged;
            // 
            // rotationAngleText
            // 
            rotationAngleText.Location = new Point(164, 224);
            rotationAngleText.Name = "rotationAngleText";
            rotationAngleText.Size = new Size(125, 27);
            rotationAngleText.TabIndex = 4;
            rotationAngleText.Text = "30";
            rotationAngleText.TextChanged += rotationAngleText_TextChanged;
            // 
            // verticesPointListBox
            // 
            verticesPointListBox.FormattingEnabled = true;
            verticesPointListBox.Location = new Point(29, 288);
            verticesPointListBox.Name = "verticesPointListBox";
            verticesPointListBox.Size = new Size(260, 144);
            verticesPointListBox.TabIndex = 5;
            verticesPointListBox.SelectedIndexChanged += verticesPointListBox_SelectedIndexChanged;
            // 
            // randomValueButton
            // 
            randomValueButton.Location = new Point(308, 286);
            randomValueButton.Name = "randomValueButton";
            randomValueButton.Size = new Size(133, 26);
            randomValueButton.TabIndex = 6;
            randomValueButton.Text = "Set random value";
            randomValueButton.UseVisualStyleBackColor = true;
            randomValueButton.Click += randomValueButton_Click;
            // 
            // drawGraphButton
            // 
            drawGraphButton.Location = new Point(308, 344);
            drawGraphButton.Name = "drawGraphButton";
            drawGraphButton.Size = new Size(133, 29);
            drawGraphButton.TabIndex = 7;
            drawGraphButton.Text = "Draw";
            drawGraphButton.UseVisualStyleBackColor = true;
            drawGraphButton.Click += drawGraphButton_Click;
            // 
            // rotateShapeButton
            // 
            rotateShapeButton.Location = new Point(308, 401);
            rotateShapeButton.Name = "rotateShapeButton";
            rotateShapeButton.Size = new Size(133, 29);
            rotateShapeButton.TabIndex = 8;
            rotateShapeButton.Text = "rotate";
            rotateShapeButton.UseVisualStyleBackColor = true;
            rotateShapeButton.Click += rotateShapeButton_Click;
            // 
            // graphPictureBox
            // 
            graphPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            graphPictureBox.BorderStyle = BorderStyle.FixedSingle;
            graphPictureBox.Location = new Point(459, 52);
            graphPictureBox.Name = "graphPictureBox";
            graphPictureBox.Size = new Size(321, 321);
            graphPictureBox.TabIndex = 9;
            graphPictureBox.TabStop = false;
            graphPictureBox.Paint += graphArea_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 10;
            label1.Text = "Center Points";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 11;
            label2.Text = "Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 159);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 12;
            label3.Text = "Number of Edge";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 224);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 13;
            label4.Text = "Rotation Angle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(graphPictureBox);
            Controls.Add(rotateShapeButton);
            Controls.Add(drawGraphButton);
            Controls.Add(randomValueButton);
            Controls.Add(verticesPointListBox);
            Controls.Add(rotationAngleText);
            Controls.Add(edgeNumberText);
            Controls.Add(lengthText);
            Controls.Add(centerPointyText);
            Controls.Add(centerPointxText);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)graphPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox centerPointxText;
        private TextBox centerPointyText;
        private TextBox lengthText;
        private TextBox edgeNumberText;
        private TextBox rotationAngleText;
        private ListBox verticesPointListBox;
        private Button randomValueButton;
        private Button drawGraphButton;
        private Button rotateShapeButton;
        private PictureBox graphPictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
