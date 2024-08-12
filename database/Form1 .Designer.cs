namespace database
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            viewGrid = new Button();
            Insertbt = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            name_tx = new TextBox();
            address_tx = new TextBox();
            email_tx = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(204, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(534, 296);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(350, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 1;
            label1.Text = "BAROS DATABASE";
            label1.Click += label1_Click;
            // 
            // viewGrid
            // 
            viewGrid.Location = new Point(90, 453);
            viewGrid.Name = "viewGrid";
            viewGrid.Size = new Size(113, 45);
            viewGrid.TabIndex = 2;
            viewGrid.Text = "View Database";
            viewGrid.UseVisualStyleBackColor = true;
            viewGrid.Click += viewGrid_Click;
            // 
            // Insertbt
            // 
            Insertbt.Location = new Point(267, 453);
            Insertbt.Name = "Insertbt";
            Insertbt.Size = new Size(109, 45);
            Insertbt.TabIndex = 3;
            Insertbt.Text = "Insert";
            Insertbt.UseVisualStyleBackColor = true;
            Insertbt.Click += Insertbt_Click;
            // 
            // button2
            // 
            button2.Location = new Point(428, 453);
            button2.Name = "button2";
            button2.Size = new Size(98, 45);
            button2.TabIndex = 4;
            button2.Text = "View Database";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(569, 453);
            button3.Name = "button3";
            button3.Size = new Size(98, 45);
            button3.TabIndex = 5;
            button3.Text = "View Database";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(712, 453);
            button4.Name = "button4";
            button4.Size = new Size(98, 45);
            button4.TabIndex = 6;
            button4.Text = "View Database";
            button4.UseVisualStyleBackColor = true;
            // 
            // name_tx
            // 
            name_tx.Location = new Point(70, 391);
            name_tx.Name = "name_tx";
            name_tx.Size = new Size(145, 23);
            name_tx.TabIndex = 7;
            // 
            // address_tx
            // 
            address_tx.Location = new Point(350, 391);
            address_tx.Name = "address_tx";
            address_tx.Size = new Size(145, 23);
            address_tx.TabIndex = 8;
            // 
            // email_tx
            // 
            email_tx.Location = new Point(625, 391);
            email_tx.Name = "email_tx";
            email_tx.Size = new Size(145, 23);
            email_tx.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 346);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 346);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 12;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(674, 346);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 13;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 514);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(email_tx);
            Controls.Add(address_tx);
            Controls.Add(name_tx);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Insertbt);
            Controls.Add(viewGrid);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button viewGrid;
        private Button Insertbt;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox name_tx;
        private TextBox address_tx;
        private TextBox email_tx;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}