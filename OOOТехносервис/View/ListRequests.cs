using OOOТехносервис.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOТехносервис.View
{
    public partial class ListRequests : Form
    {

        List<Model.Request> requests;

        public ListRequests()
        {
            InitializeComponent();
        }

        private void ListRequests_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowRequests()
        {
            requests = Helper.DB.Request.ToList();
            dgvRequests.Rows.Clear();

            for (int i = 0; i < requests.Count; i++)
            {
                dgvRequests.Rows.Add();
                dgvRequests.Rows[i].Cells[0].Value = requests[i].RequestID.ToString();
                //dgvRequests.Rows[i].Cells[1].Value = requests[i].RequestDate.ToShortDateString();
                dgvRequests.Rows[i].Cells[1].Value = requests[i].Equipment.EquipmentName.ToString();
                dgvRequests.Rows[i].Cells[2].Value = requests[i].User.UserFullName.ToString();
                dgvRequests.Rows[i].Cells[3].Value = requests[i].Status.StatusName.ToString();
                //dgvRequests.Rows[i].Cells[5].Value = requests[i].User1.UserFullName.ToString();
                dgvRequests.Rows[i].Cells[4].Value = requests[i].Stage.StageName.ToString();
            }
        }

        private void ListRequests_Shown(object sender, EventArgs e)
        {
            newRequest_button.Visible = editRequest_button.Visible = false;

            switch (Helper.user.UserRoleID)
            {
                case 2:
                    editRequest_button.Visible = true;
                    break;
                case 3:
                    newRequest_button.Visible = editRequest_button.Visible = true;
                    break;
                case 4:
                    editRequest_button.Visible = true;
                    break;
            }

            /*Настройка списка статусов*/

            List<Model.Status> statuses = Helper.DB.Status.ToList();
            Model.Status status = new Model.Status();
            status.StatusID = 0;
            status.StatusName = "Все статусы";
            statuses.Insert(0, status);
            filter_comboBox.DataSource = statuses;
            filter_comboBox.DisplayMember = "StatusName";
            filter_comboBox.ValueMember = "StatusID";

            ShowRequests();
        }
    }
}
