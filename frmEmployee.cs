using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class frmEmployee : Form
    {
        private void BindGrid()
        {
            DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
            dataGrid.DataSource = repo.GetAll();
        }
        private void ClearForm()
        {
          txtName.Text = string.Empty;
          txtLastName.Text = string.Empty;
          txtTitle.Text = string.Empty;
          txtAddress.Text = string.Empty;
        }
        public frmEmployee()
        {
            InitializeComponent();
            BindGrid();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess.EmployeeRepository empRep = new DataAccess.EmployeeRepository();
            Employee emp = new Employee();
            emp.FirstName=txtName.Text;
            emp.LastName=txtLastName.Text;
            emp.Title=txtTitle.Text;
            emp.Address=txtAddress.Text;
            emp.BirthDate=dpBirthDate.Value;
            emp.HireDate=dpHireDate.Value;
            empRep.AddNew(emp);
            BindGrid();
            ClearForm();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
