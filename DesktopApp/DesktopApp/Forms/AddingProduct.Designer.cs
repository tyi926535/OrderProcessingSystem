namespace DesktopApp.Forms
{
    partial class AddingProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingProduct));
            this.createOrder = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decreaseQuantity = new System.Windows.Forms.Button();
            this.increaseQuantity = new System.Windows.Forms.Button();
            this.removeProductOrder = new System.Windows.Forms.Button();
            this.ProductQuantity = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createOrder
            // 
            this.createOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.createOrder.AutoSize = true;
            this.createOrder.BackColor = System.Drawing.Color.White;
            this.createOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createOrder.FlatAppearance.BorderSize = 8;
            this.createOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.createOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.createOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrder.ForeColor = System.Drawing.Color.Black;
            this.createOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createOrder.ImageKey = "(отсутствует)";
            this.createOrder.Location = new System.Drawing.Point(220, 381);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(164, 45);
            this.createOrder.TabIndex = 2;
            this.createOrder.Text = "Добавить товар";
            this.createOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.createOrder.UseVisualStyleBackColor = false;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // label0
            // 
            this.label0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(202, 27);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(203, 33);
            this.label0.TabIndex = 1;
            this.label0.Text = "Список товаров";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(68, 63);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(500, 300);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(500, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 300);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.decreaseQuantity);
            this.groupBox1.Controls.Add(this.increaseQuantity);
            this.groupBox1.Controls.Add(this.removeProductOrder);
            this.groupBox1.Controls.Add(this.ProductQuantity);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.groupBox1.MaximumSize = new System.Drawing.Size(470, 100);
            this.groupBox1.MinimumSize = new System.Drawing.Size(470, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ID.Location = new System.Drawing.Point(59, 54);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(55, 19);
            this.ID.TabIndex = 21;
            this.ID.Text = "6";
            this.ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(59, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // decreaseQuantity
            // 
            this.decreaseQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.decreaseQuantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.decreaseQuantity.FlatAppearance.BorderSize = 0;
            this.decreaseQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decreaseQuantity.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decreaseQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decreaseQuantity.Location = new System.Drawing.Point(420, 54);
            this.decreaseQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.decreaseQuantity.Name = "decreaseQuantity";
            this.decreaseQuantity.Size = new System.Drawing.Size(35, 38);
            this.decreaseQuantity.TabIndex = 13;
            this.decreaseQuantity.Text = "-";
            this.decreaseQuantity.UseVisualStyleBackColor = false;
            this.decreaseQuantity.Click += new System.EventHandler(this.decreaseQuantity_Click);
            // 
            // increaseQuantity
            // 
            this.increaseQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.increaseQuantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.increaseQuantity.FlatAppearance.BorderSize = 0;
            this.increaseQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.increaseQuantity.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increaseQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.increaseQuantity.Location = new System.Drawing.Point(420, 15);
            this.increaseQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.increaseQuantity.Name = "increaseQuantity";
            this.increaseQuantity.Size = new System.Drawing.Size(35, 38);
            this.increaseQuantity.TabIndex = 12;
            this.increaseQuantity.Text = "+";
            this.increaseQuantity.UseVisualStyleBackColor = false;
            this.increaseQuantity.Click += new System.EventHandler(this.increaseQuantity_Click);
            // 
            // removeProductOrder
            // 
            this.removeProductOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.removeProductOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.removeProductOrder.FlatAppearance.BorderSize = 0;
            this.removeProductOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeProductOrder.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeProductOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeProductOrder.Location = new System.Drawing.Point(11, 35);
            this.removeProductOrder.Margin = new System.Windows.Forms.Padding(0);
            this.removeProductOrder.Name = "removeProductOrder";
            this.removeProductOrder.Size = new System.Drawing.Size(35, 38);
            this.removeProductOrder.TabIndex = 11;
            this.removeProductOrder.Text = "X";
            this.removeProductOrder.UseVisualStyleBackColor = false;
            this.removeProductOrder.Click += new System.EventHandler(this.removeProductOrder_Click);
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductQuantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductQuantity.Location = new System.Drawing.Point(343, 54);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(64, 19);
            this.ProductQuantity.TabIndex = 19;
            this.ProductQuantity.Text = "6";
            this.ProductQuantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Price.Location = new System.Drawing.Point(229, 54);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(84, 19);
            this.Price.TabIndex = 18;
            this.Price.Text = "678";
            this.Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductName.Location = new System.Drawing.Point(109, 54);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(114, 38);
            this.ProductName.TabIndex = 17;
            this.ProductName.Text = "Book";
            this.ProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(105, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(229, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Стоимость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(343, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Кол-во";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.MinimumSize = new System.Drawing.Size(215, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Список пуст";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.button3.AllowDrop = true;
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.button3.Location = new System.Drawing.Point(565, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 3;
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(637, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(655, 500);
            this.Name = "AddingProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddingProduct_FormClosing);
            this.Load += new System.EventHandler(this.AddingProduct_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeProductOrder;
        private System.Windows.Forms.Label ProductQuantity;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decreaseQuantity;
        private System.Windows.Forms.Button increaseQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label6;
    }
}