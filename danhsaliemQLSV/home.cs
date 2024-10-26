using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danhsaliemQLSV
{
    public partial class home : Form
    {
        string flag;
        DataTable dtSV;
        int index;
        public home()
        {
            InitializeComponent();
        }
        private bool ValidateInputs()
        {

            if (txtMaSV.Text.Length != 10 || !txtMaSV.Text.All(char.IsDigit))
            {
                MessageBox.Show("ID phải là chuỗi 10 ký tự số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSV.Text) || txtTenSV.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Tên không được chứa số và không được để trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

     
            if (!double.TryParse(txtdiem.Text, out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số và nằm trong khoảng từ 0 đến 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNganh.Text) || txtNganh.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ngành chỉ được chứa chữ và không được để trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Nganh");
            dt.Columns.Add("Lop");
            dt.Columns.Add("Điểm");
            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            DongControl();
            dtSV = createTable();
        }
        public void DongControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaSV.ReadOnly = true;
            txtTenSV.ReadOnly = true;
            txtNganh.ReadOnly = true;
            txtLop.ReadOnly = true;
            txtdiem.ReadOnly = true;
        }

        public void MoControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaSV.ReadOnly = false;
            txtTenSV.ReadOnly = false;
            txtNganh.ReadOnly = false;
            txtLop.ReadOnly = false;
            txtdiem.ReadOnly = false;
            txtMaSV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoControl();
            flag = "add";
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtNganh.Text = "";
            txtLop.Text = "";
            txtdiem.Text = "";


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoControl();
            flag = "edit";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            if (flag == "add")
            {
                if (checkData())
                {

                    dtSV.Rows.Add(txtMaSV.Text, txtTenSV.Text, txtNganh.Text, txtLop.Text, txtdiem.Text);
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                    ResetTextBoxes();
                }

            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    dtSV.Rows[index][0] = txtMaSV.Text;
                    dtSV.Rows[index][1] = txtTenSV.Text;
                    dtSV.Rows[index][2] = txtNganh.Text;
                    dtSV.Rows[index][3] = txtLop.Text;
                    dtSV.Rows[index][4] = txtdiem.Text;
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                    ResetTextBoxes();
                }
            }
            DongControl();
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("ban chua nhap ma sinh vien", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("ban chua nhap ten sinh vien", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNganh.Text) || txtNganh.Text.Any(char.IsDigit))
            {
                MessageBox.Show("ban chua nhap nganh cua  sinh vien", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNganh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("ban chua nhap lop ", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtdiem.Text))
            {
                MessageBox.Show("ban chua nhap diem ", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiem.Focus();
                return false;
            }
            return true;
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridSinhVien.CurrentRow != null && dataGridSinhVien.CurrentRow.Index >= 0)
            {
                index = dataGridSinhVien.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dataGridSinhVien.DataSource;
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtMaSV.Text = dataGridSinhVien.Rows[index].Cells[0].Value.ToString();
                    txtTenSV.Text = dataGridSinhVien.Rows[index].Cells[1].Value.ToString();
                    txtNganh.Text = dataGridSinhVien.Rows[index].Cells[2].Value.ToString();
                    txtLop.Text = dataGridSinhVien.Rows[index].Cells[3].Value.ToString();
                    txtdiem.Text = dataGridSinhVien.Rows[index].Cells[4].Value.ToString();

                }
            }
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("bạn có muốn xóa sinh viên này ?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        dtSV.Rows.RemoveAt(index);
        //        dataGridSinhVien.DataSource = dtSV;
        //        dataGridSinhVien.RefreshEdit();
        //    }
        //}

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (index >= 0 && index < dtSV.Rows.Count) 
                {
                    dtSV.Rows.RemoveAt(index);
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                }
                else
                {
                    MessageBox.Show("Không có sinh viên nào để xóa .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

       

       
        public void ResetTextBoxes()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtNganh.Text = "";
            txtLop.Text = "";
            txtdiem.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
