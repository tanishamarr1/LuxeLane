using LuxeLane.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace LuxeLane
{
    public partial class FormNotiExample : Form
    {
        public FormNotiExample()
        {
            InitializeComponent();
        }

        private void FormNotiExample_Load(object sender, EventArgs e)
        {
            using var dbContext = new LuxeLaneContext();    
            var notifications = dbContext.Notifications.ToList();
            notificationGrid.DataSource = notifications;
            notificationGrid.Columns["Id"].Visible = false;
            var notisQty = notificationGrid.Rows.Count.ToString();
            

        }
    }
}
