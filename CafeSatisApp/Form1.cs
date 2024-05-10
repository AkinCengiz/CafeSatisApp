namespace CafeSatisApp;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	Dictionary<string, decimal> products = new Dictionary<string, decimal>();
	decimal totalPrice = 0;
	private static decimal casing = 0;
	private void btnAddToCart_Click(object sender, EventArgs e)
	{
		if (nudAmount.Value == 0)
		{
			MessageBox.Show("Lütfen miktar giriniz.");
			return;
		}
		lstCart.Items.Add(cmbProducts.SelectedItem.ToString() + " - " + nudAmount.Text + " Adet - " + lblPriceValue.Text + " TL");
		totalPrice += Convert.ToInt32(lblPriceValue.Text) * nudAmount.Value;
		lblTotal.Text = totalPrice.ToString();
		Temizle();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		lblCasing.Text = casing.ToString();
		products.Add("Tost", 75);
		products.Add("Hamburger", 50);
		products.Add("Patso", 40);
		products.Add("Pizza", 60);
		products.Add("Kahve", 30);
		products.Add("Çay", 15);
		products.Add("Su", 10);
		products.Add("Limonata", 20);
		products.Add("Meyve Suyu", 15);
		products.Add("Kola", 25);
		products.Add("Ayran", 20);
		cmbProducts.DataSource = products.Keys.ToList();
		lblPriceValue.Text = products.Values.ToList()[0].ToString();
	}

	private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
	{
		lblPriceValue.Text = products[cmbProducts.SelectedItem.ToString()].ToString();
	}

	public void Temizle()
	{
		lblPriceValue.Text = "";
		cmbProducts.SelectedIndex = 0;
		nudAmount.Value = 0;
	}

	private void btnPay_Click(object sender, EventArgs e)
	{
		casing += totalPrice;
		lblCasing.Text = casing.ToString();
		MessageBox.Show("Ödeme iþlemi tamamlandý...");
		lstCart.Items.Clear();
		Temizle();
		totalPrice = 0;
		lblTotal.Text = totalPrice.ToString();
	}
}
