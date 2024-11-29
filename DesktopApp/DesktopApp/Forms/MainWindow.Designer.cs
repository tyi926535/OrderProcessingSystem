namespace DesktopApp.Forms
{
    partial class MainWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeOrder = new System.Windows.Forms.Button();
            this.viewProductList = new System.Windows.Forms.Button();
            this.OrderCost = new System.Windows.Forms.Label();
            this.OrderCreationDate = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.createOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(52, 64);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(500, 300);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(500, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 300);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.groupBox1.Controls.Add(this.removeOrder);
            this.groupBox1.Controls.Add(this.viewProductList);
            this.groupBox1.Controls.Add(this.OrderCost);
            this.groupBox1.Controls.Add(this.OrderCreationDate);
            this.groupBox1.Controls.Add(this.OrderID);
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
            // removeOrder
            // 
            this.removeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.removeOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.removeOrder.FlatAppearance.BorderSize = 0;
            this.removeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeOrder.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeOrder.Location = new System.Drawing.Point(12, 35);
            this.removeOrder.Margin = new System.Windows.Forms.Padding(0);
            this.removeOrder.Name = "removeOrder";
            this.removeOrder.Size = new System.Drawing.Size(35, 38);
            this.removeOrder.TabIndex = 17;
            this.removeOrder.Text = "X";
            this.removeOrder.UseVisualStyleBackColor = false;
            this.removeOrder.Click += new System.EventHandler(this.removeOrder_Click);
            // 
            // viewProductList
            // 
            this.viewProductList.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.viewProductList.AllowDrop = true;
            this.viewProductList.AutoEllipsis = true;
            this.viewProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.viewProductList.BackgroundImage = global::DesktopApp.Properties.Resources.eye;
            this.viewProductList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewProductList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewProductList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewProductList.Location = new System.Drawing.Point(418, 30);
            this.viewProductList.Name = "viewProductList";
            this.viewProductList.Size = new System.Drawing.Size(42, 41);
            this.viewProductList.TabIndex = 18;
            this.viewProductList.UseCompatibleTextRendering = true;
            this.viewProductList.UseVisualStyleBackColor = false;
            this.viewProductList.Click += new System.EventHandler(this.viewProductList_Click);
            // 
            // OrderCost
            // 
            this.OrderCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OrderCost.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderCost.Location = new System.Drawing.Point(293, 57);
            this.OrderCost.Name = "OrderCost";
            this.OrderCost.Size = new System.Drawing.Size(108, 25);
            this.OrderCost.TabIndex = 16;
            this.OrderCost.Text = "678";
            this.OrderCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderCreationDate
            // 
            this.OrderCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OrderCreationDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCreationDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderCreationDate.Location = new System.Drawing.Point(179, 57);
            this.OrderCreationDate.Name = "OrderCreationDate";
            this.OrderCreationDate.Size = new System.Drawing.Size(108, 25);
            this.OrderCreationDate.TabIndex = 15;
            this.OrderCreationDate.Text = "0.0.2024";
            this.OrderCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderID
            // 
            this.OrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OrderID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderID.Location = new System.Drawing.Point(55, 57);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(108, 25);
            this.OrderID.TabIndex = 14;
            this.OrderID.Text = "544567889";
            this.OrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(179, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Дата";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(293, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Стоимость";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.MinimumSize = new System.Drawing.Size(215, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Список пуст";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label0
            // 
            this.label0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(186, 28);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(198, 33);
            this.label0.TabIndex = 1;
            this.label0.Text = "Список заказов";
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
            this.createOrder.Location = new System.Drawing.Point(204, 381);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(164, 45);
            this.createOrder.TabIndex = 3;
            this.createOrder.Text = "Создать заказ";
            this.createOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.createOrder.UseVisualStyleBackColor = false;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 8;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "(отсутствует)";
            this.button1.Location = new System.Drawing.Point(497, 381);
            this.button1.MaximumSize = new System.Drawing.Size(179, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сменить пользователя";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(637, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(655, 500);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OrderCost;
        private System.Windows.Forms.Label OrderCreationDate;
        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewProductList;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeOrder;
        private System.Windows.Forms.Button button1;
    }
}