using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session5
{
    public partial class AmenitiesRepot : Form
    {

        SQLConnect r = new SQLConnect();
        String sql;
        public AmenitiesRepot()
        {
            InitializeComponent();
        }

        private void AmenitiesRepot_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            sql = @"select Amenities.Service as [Amenities],
	(Select CabinTypes.Name from CabinTypes where ID=AmenitiesCabinType.CabinTypeID)as [Cabins],
	Count(Tickets.CabinTypeID)as [Number of amenities per cabin],
	case when AmenitiesTickets.AmenityID is null then 0
	else AmenitiesTickets.AmenityID end as [Additional Amenities]
	from Amenities
	inner join AmenitiesCabinType on Amenities.ID=AmenitiesCabinType.AmenityID
	inner join CabinTypes on CabinTypes.ID=AmenitiesCabinType.CabinTypeID
	inner join Tickets on CabinTypes.ID=Tickets.CabinTypeID
	inner join Schedules on Tickets.ScheduleID=Schedules.ID
	Left join AmenitiesTickets on Amenities.ID=AmenitiesTickets.AmenityID
	where Schedules.FlightNumber='" + txtfligh.Text + "' or Schedules.Date between '" + fromdate.Value.ToString("yyyyMMdd") + "' and '" + todate.Value.ToString("yyyyMMdd") +
    "'group by Amenities.Service,AmenitiesCabinType.CabinTypeID,AmenitiesTickets.AmenityID";
     dataGridView1.DataSource = r.MultipleData(sql).Tables["tbl"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchase a = new Purchase();
            a.Show();
            this.Hide();
        }
    }
}
