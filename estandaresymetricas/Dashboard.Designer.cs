namespace estandaresymetricas
{
    partial class Dashboard
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            buttonLogOut = new Button();
            labelUserHi = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonSuplier = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(buttonSuplier);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 130);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 320);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserHi);
            panel1.Controls.Add(buttonLogOut);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 4;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = SystemColors.ButtonFace;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Popup;
            buttonLogOut.ImageAlign = ContentAlignment.TopCenter;
            buttonLogOut.Location = new Point(21, 45);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(126, 49);
            buttonLogOut.TabIndex = 0;
            buttonLogOut.Text = "logout";
            buttonLogOut.TextAlign = ContentAlignment.BottomCenter;
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // labelUserHi
            // 
            labelUserHi.AutoSize = true;
            labelUserHi.Location = new Point(33, 22);
            labelUserHi.Name = "labelUserHi";
            labelUserHi.Size = new Size(95, 20);
            labelUserHi.TabIndex = 1;
            labelUserHi.Text = "Hi, username";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(209, 209, 209);
            button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(147, 29);
            button2.TabIndex = 0;
            button2.Text = "Users";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(209, 209, 209);
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(156, 3);
            button3.Name = "button3";
            button3.Size = new Size(147, 29);
            button3.TabIndex = 1;
            button3.Text = "Sales";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(209, 209, 209);
            button4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(309, 3);
            button4.Name = "button4";
            button4.Size = new Size(147, 29);
            button4.TabIndex = 2;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(209, 209, 209);
            button5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(462, 3);
            button5.Name = "button5";
            button5.Size = new Size(147, 29);
            button5.TabIndex = 3;
            button5.Text = "Products";
            button5.UseVisualStyleBackColor = false;
            // 
            // buttonSuplier
            // 
            buttonSuplier.BackColor = Color.FromArgb(209, 209, 209);
            buttonSuplier.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSuplier.Cursor = Cursors.Hand;
            buttonSuplier.FlatAppearance.BorderSize = 0;
            buttonSuplier.FlatStyle = FlatStyle.Flat;
            buttonSuplier.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSuplier.ImageAlign = ContentAlignment.TopCenter;
            buttonSuplier.Location = new Point(615, 3);
            buttonSuplier.Name = "buttonSuplier";
            buttonSuplier.Size = new Size(157, 29);
            buttonSuplier.TabIndex = 4;
            buttonSuplier.Text = "Suppliers";
            buttonSuplier.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Dashboard";
            Text = "Dashboard";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label labelUserHi;
        private Button buttonLogOut;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button buttonSuplier;
    }
}