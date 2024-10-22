namespace AbbieGillespieA7
{
    partial class CarLotForm
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
            ChooseFileBtn = new Button();
            SortByMakeBtn = new Button();
            SortByMakeAndPriceBtn = new Button();
            DataDisplayListBox = new ListBox();
            SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            ChooseFileBtn.Location = new Point(12, 12);
            ChooseFileBtn.Name = "ChooseFileBtn";
            ChooseFileBtn.Size = new Size(112, 34);
            ChooseFileBtn.TabIndex = 0;
            ChooseFileBtn.Text = "Choose File";
            ChooseFileBtn.UseVisualStyleBackColor = true;
            ChooseFileBtn.Click += ChooseFileBtn_Click;
            // 
            // SortByMakeBtn
            // 
            SortByMakeBtn.Location = new Point(21, 364);
            SortByMakeBtn.Name = "SortByMakeBtn";
            SortByMakeBtn.Size = new Size(144, 34);
            SortByMakeBtn.TabIndex = 1;
            SortByMakeBtn.Text = "Sort by Make";
            SortByMakeBtn.UseVisualStyleBackColor = true;
            SortByMakeBtn.Click += SortByMakeBtn_Click;
            // 
            // SortByMakeAndPriceBtn
            // 
            SortByMakeAndPriceBtn.Location = new Point(21, 404);
            SortByMakeAndPriceBtn.Name = "SortByMakeAndPriceBtn";
            SortByMakeAndPriceBtn.Size = new Size(205, 34);
            SortByMakeAndPriceBtn.TabIndex = 2;
            SortByMakeAndPriceBtn.Text = "Sort by Make and Price";
            SortByMakeAndPriceBtn.UseVisualStyleBackColor = true;
            SortByMakeAndPriceBtn.Click += SortByMakeAndPriceBtn_Click;
            // 
            // DataDisplayListBox
            // 
            DataDisplayListBox.FormattingEnabled = true;
            DataDisplayListBox.ItemHeight = 25;
            DataDisplayListBox.Location = new Point(12, 52);
            DataDisplayListBox.Name = "DataDisplayListBox";
            DataDisplayListBox.Size = new Size(712, 304);
            DataDisplayListBox.TabIndex = 3;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataDisplayListBox);
            Controls.Add(SortByMakeAndPriceBtn);
            Controls.Add(SortByMakeBtn);
            Controls.Add(ChooseFileBtn);
            Name = "CarLotForm";
            Text = "Abbie Gillespie Assignment 7";
            ResumeLayout(false);
        }

        #endregion

        private Button ChooseFileBtn;
        private Button SortByMakeBtn;
        private Button SortByMakeAndPriceBtn;
        private ListBox DataDisplayListBox;
    }
}
