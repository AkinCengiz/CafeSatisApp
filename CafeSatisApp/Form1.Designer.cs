namespace CafeSatisApp;

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
		gbxSalesPanel = new GroupBox();
		label1 = new Label();
		lblPriceValue = new Label();
		lblPrice = new Label();
		btnAddToCart = new Button();
		nudAmount = new NumericUpDown();
		lblAmount = new Label();
		lblProduct = new Label();
		cmbProducts = new ComboBox();
		gbxCart = new GroupBox();
		label4 = new Label();
		lblTotal = new Label();
		label2 = new Label();
		lstCart = new ListBox();
		groupBox1 = new GroupBox();
		label6 = new Label();
		lblCasing = new Label();
		label3 = new Label();
		btnPay = new Button();
		gbxSalesPanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
		gbxCart.SuspendLayout();
		groupBox1.SuspendLayout();
		SuspendLayout();
		// 
		// gbxSalesPanel
		// 
		gbxSalesPanel.Controls.Add(label1);
		gbxSalesPanel.Controls.Add(lblPriceValue);
		gbxSalesPanel.Controls.Add(lblPrice);
		gbxSalesPanel.Controls.Add(btnAddToCart);
		gbxSalesPanel.Controls.Add(nudAmount);
		gbxSalesPanel.Controls.Add(lblAmount);
		gbxSalesPanel.Controls.Add(lblProduct);
		gbxSalesPanel.Controls.Add(cmbProducts);
		gbxSalesPanel.Location = new Point(12, 12);
		gbxSalesPanel.Name = "gbxSalesPanel";
		gbxSalesPanel.Size = new Size(272, 205);
		gbxSalesPanel.TabIndex = 0;
		gbxSalesPanel.TabStop = false;
		gbxSalesPanel.Text = "Satış Paneli";
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(184, 122);
		label1.Name = "label1";
		label1.Size = new Size(19, 15);
		label1.TabIndex = 8;
		label1.Text = "TL";
		// 
		// lblPriceValue
		// 
		lblPriceValue.AutoSize = true;
		lblPriceValue.Location = new Point(101, 122);
		lblPriceValue.Name = "lblPriceValue";
		lblPriceValue.Size = new Size(0, 15);
		lblPriceValue.TabIndex = 7;
		// 
		// lblPrice
		// 
		lblPrice.AutoSize = true;
		lblPrice.Location = new Point(49, 122);
		lblPrice.Name = "lblPrice";
		lblPrice.Size = new Size(41, 15);
		lblPrice.TabIndex = 6;
		lblPrice.Text = "Fiyat : ";
		// 
		// btnAddToCart
		// 
		btnAddToCart.Location = new Point(104, 157);
		btnAddToCart.Name = "btnAddToCart";
		btnAddToCart.Size = new Size(118, 23);
		btnAddToCart.TabIndex = 4;
		btnAddToCart.Text = "Sepete Ekle";
		btnAddToCart.UseVisualStyleBackColor = true;
		btnAddToCart.Click += btnAddToCart_Click;
		// 
		// nudAmount
		// 
		nudAmount.Location = new Point(102, 79);
		nudAmount.Name = "nudAmount";
		nudAmount.Size = new Size(120, 23);
		nudAmount.TabIndex = 3;
		nudAmount.TextAlign = HorizontalAlignment.Center;
		// 
		// lblAmount
		// 
		lblAmount.AutoSize = true;
		lblAmount.Location = new Point(40, 81);
		lblAmount.Name = "lblAmount";
		lblAmount.Size = new Size(50, 15);
		lblAmount.TabIndex = 2;
		lblAmount.Text = "Miktar : ";
		// 
		// lblProduct
		// 
		lblProduct.AutoSize = true;
		lblProduct.Location = new Point(48, 34);
		lblProduct.Name = "lblProduct";
		lblProduct.Size = new Size(42, 15);
		lblProduct.TabIndex = 1;
		lblProduct.Text = "Ürün : ";
		// 
		// cmbProducts
		// 
		cmbProducts.FormattingEnabled = true;
		cmbProducts.Location = new Point(101, 31);
		cmbProducts.Name = "cmbProducts";
		cmbProducts.Size = new Size(121, 23);
		cmbProducts.TabIndex = 0;
		cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
		// 
		// gbxCart
		// 
		gbxCart.Controls.Add(label4);
		gbxCart.Controls.Add(lblTotal);
		gbxCart.Controls.Add(label2);
		gbxCart.Controls.Add(lstCart);
		gbxCart.Location = new Point(290, 14);
		gbxCart.Name = "gbxCart";
		gbxCart.Size = new Size(240, 344);
		gbxCart.TabIndex = 1;
		gbxCart.TabStop = false;
		gbxCart.Text = "Alışveriş Sepeti";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(215, 307);
		label4.Name = "label4";
		label4.Size = new Size(19, 15);
		label4.TabIndex = 9;
		label4.Text = "TL";
		// 
		// lblTotal
		// 
		lblTotal.AutoSize = true;
		lblTotal.Location = new Point(144, 307);
		lblTotal.Name = "lblTotal";
		lblTotal.Size = new Size(0, 15);
		lblTotal.TabIndex = 2;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(15, 307);
		label2.Name = "label2";
		label2.Size = new Size(99, 15);
		label2.TabIndex = 1;
		label2.Text = "Ödenecek Tutar : ";
		// 
		// lstCart
		// 
		lstCart.FormattingEnabled = true;
		lstCart.ItemHeight = 15;
		lstCart.Location = new Point(6, 22);
		lstCart.Name = "lstCart";
		lstCart.Size = new Size(228, 259);
		lstCart.TabIndex = 0;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(label6);
		groupBox1.Controls.Add(lblCasing);
		groupBox1.Controls.Add(label3);
		groupBox1.Controls.Add(btnPay);
		groupBox1.Location = new Point(12, 223);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(272, 135);
		groupBox1.TabIndex = 2;
		groupBox1.TabStop = false;
		groupBox1.Text = "Ödeme Paneli";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(104, 28);
		label6.Name = "label6";
		label6.Size = new Size(19, 15);
		label6.TabIndex = 9;
		label6.Text = "TL";
		// 
		// lblCasing
		// 
		lblCasing.AutoSize = true;
		lblCasing.Location = new Point(52, 28);
		lblCasing.Name = "lblCasing";
		lblCasing.Size = new Size(38, 15);
		lblCasing.TabIndex = 2;
		lblCasing.Text = "label5";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(14, 28);
		label3.Name = "label3";
		label3.Size = new Size(40, 15);
		label3.TabIndex = 1;
		label3.Text = "Kasa : ";
		// 
		// btnPay
		// 
		btnPay.Location = new Point(172, 79);
		btnPay.Name = "btnPay";
		btnPay.Size = new Size(84, 50);
		btnPay.TabIndex = 0;
		btnPay.Text = "Ödeme Yap";
		btnPay.UseVisualStyleBackColor = true;
		btnPay.Click += btnPay_Click;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(542, 370);
		Controls.Add(groupBox1);
		Controls.Add(gbxCart);
		Controls.Add(gbxSalesPanel);
		Name = "Form1";
		Text = "Form1";
		Load += Form1_Load;
		gbxSalesPanel.ResumeLayout(false);
		gbxSalesPanel.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
		gbxCart.ResumeLayout(false);
		gbxCart.PerformLayout();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private GroupBox gbxSalesPanel;
	private Button btnAddToCart;
	private NumericUpDown nudAmount;
	private Label lblAmount;
	private Label lblProduct;
	private ComboBox cmbProducts;
	private Label lblPrice;
	private Label lblPriceValue;
	private GroupBox gbxCart;
	private ListBox lstCart;
	private Label label1;
	private Label label4;
	private Label lblTotal;
	private Label label2;
	private GroupBox groupBox1;
	private Button btnPay;
	private Label label6;
	private Label lblCasing;
	private Label label3;
}
