namespace Lab2_XPath
{
    partial class Form1
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.txtboxItemInfo = new System.Windows.Forms.TextBox();
            this.txtboxShippingInfo = new System.Windows.Forms.TextBox();
            this.txtboxBillingInfo = new System.Windows.Forms.TextBox();
            this.lblTotalCostOfOrder = new System.Windows.Forms.Label();
            this.lblNumberOfItemsBought = new System.Windows.Forms.Label();
            this.btnItemInformation = new System.Windows.Forms.Button();
            this.btnShippingInformation = new System.Windows.Forms.Button();
            this.btnBillingInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(661, 271);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 22;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(661, 36);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(75, 23);
            this.btnGetOrder.TabIndex = 21;
            this.btnGetOrder.Text = "Get Order";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // txtboxItemInfo
            // 
            this.txtboxItemInfo.Location = new System.Drawing.Point(414, 58);
            this.txtboxItemInfo.Multiline = true;
            this.txtboxItemInfo.Name = "txtboxItemInfo";
            this.txtboxItemInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxItemInfo.Size = new System.Drawing.Size(173, 236);
            this.txtboxItemInfo.TabIndex = 20;
            // 
            // txtboxShippingInfo
            // 
            this.txtboxShippingInfo.Location = new System.Drawing.Point(220, 58);
            this.txtboxShippingInfo.Multiline = true;
            this.txtboxShippingInfo.Name = "txtboxShippingInfo";
            this.txtboxShippingInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxShippingInfo.Size = new System.Drawing.Size(173, 236);
            this.txtboxShippingInfo.TabIndex = 19;
            // 
            // txtboxBillingInfo
            // 
            this.txtboxBillingInfo.Location = new System.Drawing.Point(18, 58);
            this.txtboxBillingInfo.Multiline = true;
            this.txtboxBillingInfo.Name = "txtboxBillingInfo";
            this.txtboxBillingInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxBillingInfo.Size = new System.Drawing.Size(173, 236);
            this.txtboxBillingInfo.TabIndex = 18;
            // 
            // lblTotalCostOfOrder
            // 
            this.lblTotalCostOfOrder.AutoSize = true;
            this.lblTotalCostOfOrder.Location = new System.Drawing.Point(615, 141);
            this.lblTotalCostOfOrder.Name = "lblTotalCostOfOrder";
            this.lblTotalCostOfOrder.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCostOfOrder.TabIndex = 17;
            this.lblTotalCostOfOrder.Text = "label2";
            // 
            // lblNumberOfItemsBought
            // 
            this.lblNumberOfItemsBought.AutoSize = true;
            this.lblNumberOfItemsBought.Location = new System.Drawing.Point(615, 111);
            this.lblNumberOfItemsBought.Name = "lblNumberOfItemsBought";
            this.lblNumberOfItemsBought.Size = new System.Drawing.Size(35, 13);
            this.lblNumberOfItemsBought.TabIndex = 16;
            this.lblNumberOfItemsBought.Text = "label1";
            // 
            // btnItemInformation
            // 
            this.btnItemInformation.Location = new System.Drawing.Point(433, 12);
            this.btnItemInformation.Name = "btnItemInformation";
            this.btnItemInformation.Size = new System.Drawing.Size(137, 23);
            this.btnItemInformation.TabIndex = 15;
            this.btnItemInformation.Text = "Item Information";
            this.btnItemInformation.UseVisualStyleBackColor = true;
            this.btnItemInformation.Click += new System.EventHandler(this.btnItemInformation_Click);
            // 
            // btnShippingInformation
            // 
            this.btnShippingInformation.Location = new System.Drawing.Point(238, 12);
            this.btnShippingInformation.Name = "btnShippingInformation";
            this.btnShippingInformation.Size = new System.Drawing.Size(137, 23);
            this.btnShippingInformation.TabIndex = 14;
            this.btnShippingInformation.Text = "Shipping Information";
            this.btnShippingInformation.UseVisualStyleBackColor = true;
            this.btnShippingInformation.Click += new System.EventHandler(this.btnShippingInformation_Click);
            // 
            // btnBillingInformation
            // 
            this.btnBillingInformation.Location = new System.Drawing.Point(35, 12);
            this.btnBillingInformation.Name = "btnBillingInformation";
            this.btnBillingInformation.Size = new System.Drawing.Size(137, 23);
            this.btnBillingInformation.TabIndex = 13;
            this.btnBillingInformation.Text = "Billing Information";
            this.btnBillingInformation.UseVisualStyleBackColor = true;
            this.btnBillingInformation.Click += new System.EventHandler(this.btnBillingInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 317);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.txtboxItemInfo);
            this.Controls.Add(this.txtboxShippingInfo);
            this.Controls.Add(this.txtboxBillingInfo);
            this.Controls.Add(this.lblTotalCostOfOrder);
            this.Controls.Add(this.lblNumberOfItemsBought);
            this.Controls.Add(this.btnItemInformation);
            this.Controls.Add(this.btnShippingInformation);
            this.Controls.Add(this.btnBillingInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.TextBox txtboxItemInfo;
        private System.Windows.Forms.TextBox txtboxShippingInfo;
        private System.Windows.Forms.TextBox txtboxBillingInfo;
        private System.Windows.Forms.Label lblTotalCostOfOrder;
        private System.Windows.Forms.Label lblNumberOfItemsBought;
        private System.Windows.Forms.Button btnItemInformation;
        private System.Windows.Forms.Button btnShippingInformation;
        private System.Windows.Forms.Button btnBillingInformation;
    }
}

