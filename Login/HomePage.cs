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
using Business.Constants;
using Login;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.DTOs;

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
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        ProductManager productManager = new(new EfProductDal());
        LogManager logManager = new(new EfLogDal());

        public void CheckIfUnitsInStock(int amount)
        {
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)<amount)
                    {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;

                    }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }
        private void BtnCategory1_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height = btnCategory1.Height;
            pnlNav.Top=btnCategory1.Top;
            pnlNav.Left=btnCategory1.Left;
            btnCategory1.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource = productManager.GetAllByCategoryId(1).Data;       
            dataGridView1.ClearSelection();
            CheckIfUnitsInStock(100);
        }
        
        private void BtnCategory2_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height=btnCategory2.Height;
            pnlNav.Top=btnCategory2.Top;
            btnCategory2.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource=productManager.GetAllByCategoryId(2).Data;
            dataGridView1.ClearSelection();
            CheckIfUnitsInStock(40);
        }

        private void BtnCategory3_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height = btnCategory3.Height;
            pnlNav.Top = btnCategory3.Top;
            btnCategory3.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource=productManager.GetAllByCategoryId(3).Data;
            dataGridView1.ClearSelection();
            CheckIfUnitsInStock(20);
        }

        private void BtnCategory4_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height = btnCategory4.Height;
            pnlNav.Top = btnCategory4.Top;
            btnCategory4.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource=productManager.GetAllByCategoryId(4).Data;
            dataGridView1.ClearSelection();
            CheckIfUnitsInStock(100);
        }
        private void btnCategory5_Click(object sender, EventArgs e)
        {
            PersonManager personManager=new(new EfPersonDal());
            //UI
            pnlNav.Height = btnCategory4.Height;
            pnlNav.Top = btnCategory4.Top;
            btnCategory4.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource = personManager.GetAll().Data;
            this.dataGridView1.Columns[1].Visible = false;
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
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == Messages.SearchName)
                txtSearch.Text = Messages.Space;
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == Messages.Space)
                txtProductName.Text = Messages.SearchName;
        }

        private void TxtProductName_Enter(object sender, EventArgs e)
        {
            if (txtProductName.Text == Messages.ProductName)
                txtProductName.Text = Messages.Space;
        }

        private void TxtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == Messages.Space)
                txtProductName.Text = Messages.ProductName;
        }

        private void TxtUnitsInStock_Enter(object sender, EventArgs e)
        {
            if (txtUnitsInStock.Text == Messages.UnitsInStock)
                txtUnitsInStock.Text = Messages.Space;
        }

        private void TxtUnitsInStock_Leave(object sender, EventArgs e)
        {
            if (txtUnitsInStock.Text == Messages.Space)
                txtUnitsInStock.Text = Messages.UnitsInStock;
        }

        private void TxtProductCode_Enter(object sender, EventArgs e)
        {
            if (txtProductCode.Text == Messages.ProductCode)
                txtProductCode.Text = Messages.Space;
        }

        private void TxtProductCode_Leave(object sender, EventArgs e)
        {
            if (txtProductCode.Text == Messages.Space)
                txtProductCode.Text = Messages.ProductCode;
        }

        private void TxtProductBarcode_Enter(object sender, EventArgs e)
        {
            if (txtProductBarcode.Text == Messages.ProductBarcode)
                txtProductBarcode.Text = Messages.Space;
        }

        private void TxtProductBarcode_Leave(object sender, EventArgs e)
        {   
            if (txtProductBarcode.Text == Messages.Space)
                txtProductBarcode.Text = Messages.ProductBarcode;
        }

        private void TxtProductDesc_Enter(object sender, EventArgs e)
        {
            if (txtProductDesc.Text == Messages.ProductDesc)
                txtProductDesc.Text = Messages.Space;
        }

        private void TxtProductDesc_Leave(object sender, EventArgs e)
        {
            if (txtProductDesc.Text == Messages.Space)
                txtProductDesc.Text = Messages.ProductDesc;
        }

        //Button Commands

        //Form Açılış
        public string adminOrNot;
        public string userName;
        public string PersonNo;
        CategoryManager categoryManager = new(new EfCategoryDal());
        private void HomePage_Load(object sender, EventArgs e)
        {
            labelSomeUser.Text = adminOrNot;
            labelUsername.Text = userName;
            if (labelSomeUser.Text=="Admin")
            {
                btnCategory5.Visible = true;
                btnLog.Visible = true;
            }
            else
            {
                btnCategory5.Visible = false;
                btnLog.Visible = false;
            }

            var result = categoryManager.GetAll();
            if (result.Succes == true)
            {
                foreach (var category in categoryManager.GetAll().Data)
                {
                    cmbCategories.Items.Add(category.CategoryName);
                }
            }
            else
                MessageBox.Show(Messages.UnknownError);

            
            
        }
        //Çıkış Yap butonu
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogOut.Height;
            pnlNav.Top = btnLogOut.Top;
            btnLogOut.BackColor = Color.FromArgb(46, 51, 73);
            //commands
            LoginPage loginPage = new();
            loginPage.Show();
            this.Close();
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
        //boyut ayarlama butonu
        private void btnSetSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        //küçültme butonu
        private void btnShrink_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Ürün ekleme Butonu
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnChange.Text = Messages.Add;
            cmbCategories.Text = Messages.Category ;
            if (panelChange.Visible == true)
                panelChange.Visible = false;
            else
                panelChange.Visible = true;
            sayi = 0;

        }

        public int sayi;
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnChange.Text = Messages.Update;
            if (panelChange.Visible == true)
                panelChange.Visible = false;
            else
                panelChange.Visible = true;
            sayi = 1;
            PanelChangeReset();
        }
        void PanelChangeReset()
        {
            cmbCategories.Text = Messages.Category;
            txtProductName.Text = Messages.ProductName;
            txtUnitsInStock.Text = Messages.UnitsInStock;
            txtProductCode.Text = Messages.ProductCode;
            txtProductBarcode.Text = Messages.ProductBarcode;
            txtProductDesc.Text= Messages.ProductDesc;
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(sayi==1)
            {
                cmbCategories.Text = Messages.Space;
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
                });
                //LOG EKLE
                logManager.Add(new Log
                {
                    Username = userName,
                    Description = txtUnitsInStock.Text + " tane " + txtProductName.Text + " Sisteme Eklendi",
                    Date = DateTime.Now.ToString()
                });

                PanelChangeReset();
                panelChange.Visible = false;
                dataGridView1.DataSource = productManager.GetAllByCategoryId(index).Data;
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

                //LOG EKLE
                logManager.Add(new Log
                {
                    Username = userName,
                    Description = txtProductId.Text + " numaralı " + txtProductName.Text + " Güncellendi",
                    Date = DateTime.Now.ToString()
                });

                PanelChangeReset();
                panelChange.Visible = false;
                dataGridView1.DataSource = productManager.GetAllByCategoryId(index).Data;
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
            dataGridView1.DataSource = productManager.GetAllByCategoryId(index).Data;
           
            //LOG EKLE
            logManager.Add(new Log
            {
                Username = userName,
                Description = dataGridView1.CurrentRow.Cells[2].Value + " Silindi",
                Date = DateTime.Now.ToString()
            });
        }

        private void labelSomeUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //UI
            pnlNav.Height = btnCategory4.Height;
            pnlNav.Top = btnCategory4.Top;
            btnCategory4.BackColor = Color.FromArgb(46, 51, 73);

            //Commands
            dataGridView1.DataSource = logManager.GetAll().Data;
            dataGridView1.ClearSelection();
        }

        //Search button
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            using (StockPostgresContext context = new())
            {
                var result = from item in context.products
                             where item.ProductName.Contains(search)
                             select item;
                dataGridView1.DataSource = result.ToList();
            }
        }


    }
}
