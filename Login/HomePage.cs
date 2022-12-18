using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework.DataAccessLayer;
using Entities.Concrete;
using DataAccess.Abstract.DataAccessLayer;

namespace UI
{
    public partial class HomePage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
    );

        public HomePage()
        {
            InitializeComponent();

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnCategory1.Height;
            pnlNav.Top = btnCategory1.Top;
            pnlNav.Left = btnCategory1.Left;
            btnCategory1.BackColor = Color.FromArgb(46, 51, 73);

            //Form
            this.Text=string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= true;
            /*this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea*/; //Tam ekran olunca köşelerde boşluk bırak
        }

        //UI DESIGN
        ProductManager productManager = new(new EfProductDal());
        private void BtnCategory1_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height = btnCategory1.Height;
            pnlNav.Top=btnCategory1.Top;
            pnlNav.Left=btnCategory1.Left;
            btnCategory1.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource = productManager.GetAllByCategoryId(1);       
            dataGridView1.ClearSelection();
        }

        private void BtnCategory2_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height=btnCategory2.Height;
            pnlNav.Top=btnCategory2.Top;
            btnCategory2.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource=productManager.GetAllByCategoryId(2);
            dataGridView1.ClearSelection();
        }

        private void BtnCategory3_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height = btnCategory3.Height;
            pnlNav.Top = btnCategory3.Top;
            btnCategory3.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource=productManager.GetAllByCategoryId(3);
            dataGridView1.ClearSelection();
        }

        private void BtnCategory4_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height = btnCategory4.Height;
            pnlNav.Top = btnCategory4.Top;
            btnCategory4.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource=productManager.GetAllByCategoryId(4);
            dataGridView1.ClearSelection();
        }
        //DRAG FORM

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //panelChange textbox design
        private void TxtProductName_Enter(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Ürün Adı")
                txtProductName.Text = "";
        }

        private void TxtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
                txtProductName.Text = "Ürün Adı";
        }

        private void TxtUnitsInStock_Enter(object sender, EventArgs e)
        {
            if (txtUnitsInStock.Text == "Ürün Adedi")
                txtUnitsInStock.Text = "";
        }

        private void TxtUnitsInStock_Leave(object sender, EventArgs e)
        {
            if (txtUnitsInStock.Text == "")
                txtUnitsInStock.Text = "Ürün Adedi";
        }

        private void TxtProductCode_Enter(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "Ürün Kodu")
                txtProductCode.Text = "";
        }

        private void TxtProductCode_Leave(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "")
                txtProductCode.Text = "Ürün Kodu";
        }

        private void TxtProductBarcode_Enter(object sender, EventArgs e)
        {
            if (txtProductBarcode.Text == "Ürün Barkod")
                txtProductBarcode.Text = "";
        }

        private void TxtProductBarcode_Leave(object sender, EventArgs e)
        {
            if (txtProductBarcode.Text == "")
                txtProductBarcode.Text = "Ürün Barkod";
        }

        private void TxtProductDesc_Enter(object sender, EventArgs e)
        {
            if (txtProductDesc.Text == "Ürün Açıklaması")
                txtProductDesc.Text = "";
        }

        private void TxtProductDesc_Leave(object sender, EventArgs e)
        {
            if (txtProductDesc.Text == "")
                txtProductDesc.Text = "Ürün Açıklaması";
        }

        //Button Commands

        //Form Açılış
        CategoryManager categoryManager = new(new EfCategoryDal());
        private void HomePage_Load(object sender, EventArgs e)
        {
            foreach (var category in categoryManager.GetAll())
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                cmbCategories.Items.Add(category.CategoryName.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }

        }
        //Çıkış Yap butonu
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogOut.Height;
            pnlNav.Top = btnLogOut.Top;
            btnLogOut.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void BtnLogOut_Leave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Kategori butonları
        private void BtnCategory1_Leave(object sender, EventArgs e)
        {
            btnCategory1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCategory2_Leave(object sender, EventArgs e)
        {
            btnCategory2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCategory3_Leave(object sender, EventArgs e)
        {
            btnCategory3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCategory4_Leave(object sender, EventArgs e)
        {
            btnCategory4.BackColor = Color.FromArgb(24, 30, 54);
        }


        //Close butonuna basınca
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Ürün ekleme Butonu
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnChange.Text = "EKLE";
            cmbCategories.Text = "Kategoriler";
            if (panelChange.Visible == true)
                panelChange.Visible = false;
            else
                panelChange.Visible = true;
            sayi = 0;

        }
        public int sayi;
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnChange.Text = "Güncelle";
            if (panelChange.Visible == true)
                panelChange.Visible = false;
            else
                panelChange.Visible = true;
            sayi = 1;
            PanelChangeReset();
        }
        void PanelChangeReset()
        {
            cmbCategories.Text = "Kategoriler";
            txtProductName.Text = "Ürün Adı";
            txtUnitsInStock.Text = "Ürün Adedi";
            txtProductCode.Text = "Ürün Kodu";
            txtProductBarcode.Text = "Ürün Barkod";
            txtProductDesc.Text= "Ürün Açıklaması";
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(sayi==1)
            {
                cmbCategories.Text = "";
                string? id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string? categoryName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string? productName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string? unitInStock = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string? productCode = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string? productBarcode = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string? productDescription = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                txtProductId.Text = id;
                cmbCategories.SelectedText= categoryName;
                txtProductName.Text= productName;
                txtUnitsInStock.Text= unitInStock;
                txtProductCode.Text = productCode;
                txtProductBarcode.Text= productBarcode;
                txtProductDesc.Text= productDescription;
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (sayi==0)
            {
            productManager.Add(new Product
            {
                CategoryId = index,
                ProductName = txtProductName.Text,
                UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                ProductCode = txtProductCode.Text,
                ProductBarcode = txtProductBarcode.Text,
                ProductDescription = txtProductDesc.Text
            }) ;
                PanelChangeReset();
                panelChange.Visible = false;
                dataGridView1.DataSource = productManager.GetAllByCategoryId(index);
            }
            else if (sayi==1)
            {
                productManager.Update(new Product
                {
                    ProductId=Convert.ToInt32(txtProductId.Text),
                    CategoryId = index,
                    ProductName = txtProductName.Text,
                    UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                    ProductCode = txtProductCode.Text,
                    ProductBarcode = txtProductBarcode.Text,
                    ProductDescription = txtProductDesc.Text
                });
                PanelChangeReset();
                panelChange.Visible = false;
                dataGridView1.DataSource = productManager.GetAllByCategoryId(index);
            }
        }
        int index;
        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex == 0)
                index = 1;
            else if(cmbCategories.SelectedIndex==1) index = 2;
            else if(cmbCategories.SelectedIndex==2) index = 3;
            else if(cmbCategories.SelectedIndex==3) index = 4;


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            productManager.Delete(new Product { ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) });
            dataGridView1.DataSource = productManager.GetAllByCategoryId(index);
            
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
