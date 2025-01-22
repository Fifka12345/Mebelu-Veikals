namespace FurnitureStore
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
            selectProductComboBox = new ComboBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            selectButton = new Button();
            heightTextBox = new TextBox();
            priceTextBox = new TextBox();
            widthTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            lenghtTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            exportButton = new Button();
            importButton = new Button();
            SuspendLayout();
            // 
            // selectProductComboBox
            // 
            selectProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectProductComboBox.FormattingEnabled = true;
            selectProductComboBox.Location = new Point(12, 51);
            selectProductComboBox.Name = "selectProductComboBox";
            selectProductComboBox.Size = new Size(344, 28);
            selectProductComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Izvēlies preci";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 134);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(213, 27);
            nameTextBox.TabIndex = 2;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(362, 51);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(94, 29);
            selectButton.TabIndex = 3;
            selectButton.Text = "Izvēlēties";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(250, 134);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(206, 27);
            heightTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 222);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(213, 27);
            priceTextBox.TabIndex = 5;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(250, 222);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(206, 27);
            widthTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 310);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(213, 27);
            descriptionTextBox.TabIndex = 7;
            // 
            // lenghtTextBox
            // 
            lenghtTextBox.Location = new Point(250, 310);
            lenghtTextBox.Name = "lenghtTextBox";
            lenghtTextBox.Size = new Size(206, 27);
            lenghtTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 9;
            label2.Text = "Preces nosaukums";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "Cena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 287);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 11;
            label4.Text = "Apraksts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 111);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 12;
            label5.Text = "Augstums";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 199);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 13;
            label6.Text = "Platums";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 287);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 14;
            label7.Text = "Garums";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 371);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 15;
            addButton.Text = "Pievienot";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(112, 371);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 16;
            editButton.Text = "Rediģēt";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(214, 371);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 17;
            deleteButton.Text = "Dzēst";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(328, 355);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(142, 29);
            exportButton.TabIndex = 18;
            exportButton.Text = "Eksportēt CSV";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(328, 390);
            importButton.Name = "importButton";
            importButton.Size = new Size(142, 29);
            importButton.TabIndex = 19;
            importButton.Text = "Importēt CSV";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(importButton);
            Controls.Add(exportButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lenghtTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(widthTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(selectButton);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(selectProductComboBox);
            Name = "Form1";
            Text = "Mēbeļu Veikals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectProductComboBox;
        private Label label1;
        private TextBox nameTextBox;
        private Button selectButton;
        private TextBox heightTextBox;
        private TextBox priceTextBox;
        private TextBox widthTextBox;
        private TextBox descriptionTextBox;
        private TextBox lenghtTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button exportButton;
        private Button importButton;
    }
}
