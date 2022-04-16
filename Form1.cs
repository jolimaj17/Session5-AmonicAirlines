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
    public partial class Purchase : Form
    {
        SQLConnect r = new SQLConnect();
        String sql;
        String a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;
        String d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12;
        Double items, txx, total;

        private void ch3_CheckedChanged(object sender, EventArgs e)
        {
            if (ch3.Checked == true && ch3.Enabled == true)
            {
                items = items + 50.00;
                txx = txx + 2.5;
                a3 = "3";
                d3 = "50.00";
            }
            else
            {
                items = items - 50.00;
                txx = txx - 2.5;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch4_CheckedChanged(object sender, EventArgs e)
        {
            if (ch4.Checked == true && ch4.Enabled == true)
            {
                items = items + 12.00;
                txx = txx + 0.6;
                a4 = "4";
                d4 = "12.00";
            }
            else
            {
                items = items - 12.00;
                txx = txx - 0.6;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch5_CheckedChanged(object sender, EventArgs e)
        {
            if (ch5.Checked == true && ch5.Enabled == true)
            {
                items = items + 15.00;
                txx = txx + 0.75;
                a5 = "5";
                d5 = "15.00";
            }
            else
            {
                items = items - 15.00;
                txx = txx - 0.75;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch6_CheckedChanged(object sender, EventArgs e)
        {
            if (ch6.Checked == true && ch6.Enabled == true)
            {
                items = items + 25.00;
                txx = txx + 1.25;
                a6 = "6";
                d6 = "25.00";
            }
            else
            {
                items = items - 25.00;
                txx = txx - 1.25;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch7_CheckedChanged(object sender, EventArgs e)
        {
            if (ch7.Checked == true && ch7.Enabled == true)
            {
                items = items + 0.00;
                txx = txx + 0;
                a7 = "7";
                d7 = "0.00";
            }
            else
            {
                items = items - 0.00;
                txx = txx - 0;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch8_CheckedChanged(object sender, EventArgs e)
        {
            if (ch8.Checked == true && ch8.Enabled == true)
            {
                items = items + 5.00;
                txx = txx + 0.25;
                a8 = "8";
                d8 = "5.00";
            }
            else
            {
                items = items - 5.00;
                txx = txx - 0.25;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch9_CheckedChanged(object sender, EventArgs e)
        {
            if (ch9.Checked == true && ch9.Enabled == true)
            {
                items = items + 15.00;
                txx = txx + 0.75;
                a9 = "9";
                d9 = "15.00";
            }
            else
            {
                items = items - 15.00;
                txx = txx - 0.75;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch10_CheckedChanged(object sender, EventArgs e)
        {
            if (ch10.Checked == true && ch10.Enabled == true)
            {
                items = items + 10.00;
                txx = txx + 0.5;
                a10 = "10";
                d10 = "10.00";
            }
            else
            {
                items = items - 10.00;
                txx = txx - 0.5;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch11_CheckedChanged(object sender, EventArgs e)
        {
            if (ch4.Checked == true && ch4.Enabled == true)
            {
                items = items + 0.00;
                txx = txx + 0;
                a11= "11";
                d11 = "0.00";
            }
            else
            {
                items = items - 0.00;
                txx = txx - 0;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        private void ch12_CheckedChanged(object sender, EventArgs e)
        {
            if (ch12.Checked == true && ch12.Enabled == true)
            {
                items = items + 25.00;
                txx = txx + 1.25;
                a12 = "12";
                d12 = "25.00";
            }
            else
            {
                items = items - 25.00;
                txx = txx - 1.25;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        

        private void ch2_CheckedChanged(object sender, EventArgs e)
        {
            if (ch2.Checked == true && ch2.Enabled == true)
            {
                items = items + 30.00;
                txx = txx + 1.5;
                a2 = "2";
                d2 = "30.00";
            }
            else
            {
                items = items - 30.00;
                txx = txx - 1.5;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

       
        private void ch1_CheckedChanged(object sender, EventArgs e)
        {
            if(ch1.Checked==true && ch1.Enabled == true)
            {
                items = items + 10.00;
                txx = txx + 0.5;
                a1 = "1";
                d1 = "10.00";
            }
            else
            {
                items = items- 10.00;
                txx = txx - 0.5;
            }
            total = items + txx;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }

        
        public Purchase()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbk.Text == "")
            {
                MessageBox.Show("Please Enter book references!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbflights.Text == " ")
            {
                MessageBox.Show("Please choose flight first!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                save();
            }
        }
        //save code
        private void save()
        {
            string optio1;
            sql = @"Select AmenityID from AmenitiesTickets  where TicketID='"+ticketID.Text+"'";
            r.DisplaySingle(sql);
            optio1 = r.getf1();
            
            if(optio1=="")
            {
                //ch1
                if (ch1.Checked == true && ch1.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a1 + "','" + ticketID.Text + "','" + d1 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a1 + "'";
                    r.Modify(sql);
                }
                //ch2
                if (ch2.Checked == true && ch2.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a2 + "','" + ticketID.Text + "','" + d2 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a2 + "'";
                    r.Modify(sql);
                }
                //ch3
                if (ch3.Checked == true && ch3.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a3 + "','" + ticketID.Text + "','" + d3 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a3 + "'";
                    r.Modify(sql);
                }
                //ch4
                if (ch4.Checked == true && ch4.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a4 + "','" + ticketID.Text + "','" + d4 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a4 + "'";
                    r.Modify(sql);
                }
                //ch5
                if (ch5.Checked == true && ch5.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a5 + "','" + ticketID.Text + "','" + d5 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a5 + "'";
                    r.Modify(sql);
                }
                //ch6
                if (ch6.Checked == true && ch6.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a6 + "','" + ticketID.Text + "','" + d6 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a6 + "'";
                    r.Modify(sql);
                }
                //ch7
                if (ch7.Checked == true && ch7.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a7 + "','" + ticketID.Text + "','" + d7 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a7 + "'";
                    r.Modify(sql);
                }
                //ch8
                if (ch8.Checked == true && ch8.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a8 + "','" + ticketID.Text + "','" + d8 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a8 + "'";
                    r.Modify(sql);
                }
                //ch9
                if (ch9.Checked == true && ch9.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a9 + "','" + ticketID.Text + "','" + d9 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a9 + "'";
                    r.Modify(sql);
                }
                //ch10
                if (ch10.Checked == true && ch10.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a10 + "','" + ticketID.Text + "','" + d10 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a10 + "'";
                    r.Modify(sql);
                }
                //ch11
                if (ch11.Checked == true && ch11.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a11 + "','" + ticketID.Text + "','" + d11 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a11 + "'";
                    r.Modify(sql);
                }
                //ch12
                if (ch12.Checked == true && ch12.Enabled == true)
                {
                    sql = "insert into AmenitiesTickets values('" + a12 + "','" + ticketID.Text + "','" + d12 + "')";
                    r.Modify(sql);
                }
                else
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID='" + a12 + "'";
                    r.Modify(sql);
                }
            }
            else if (optio1 != "")
            {
                //ch1
                if (ch1.Checked == false && ch1.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=1";
                    r.Modify(sql);

                }
                //ch2
                if (ch2.Checked == false && ch2.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=2";
                    r.Modify(sql);
                }

           
                //ch3
                 if (ch3.Checked == false && ch3.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=3";
                    r.Modify(sql);
                }
                //ch4
                 if (ch4.Checked == false && ch4.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=4";
                    r.Modify(sql);
                }

                //ch5
                 if (ch5.Checked == false && ch5.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=5";
                    r.Modify(sql);
                }

                //ch6
                 if (ch6.Checked == false && ch6.Enabled == true)
                {

                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=6";
                    r.Modify(sql);
                }

                //ch7
                 if (ch7.Checked == false && ch7.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=7";
                    r.Modify(sql);
                }

                //ch8
                 if (ch8.Checked == false && ch8.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=8";
                    r.Modify(sql);
                }

                //ch9
                 if (ch9.Checked == false && ch9.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=9";
                    r.Modify(sql);
                }

                //ch10
                if (ch10.Checked == false && ch10.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=10";
                    r.Modify(sql);
                }

                //ch11
                if (ch11.Checked == false && ch11.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=11";
                    r.Modify(sql);
                }

                //ch12
                if (ch12.Checked == false && ch12.Enabled == true)
                {
                    sql = "delete from AmenitiesTickets where TicketID='" + ticketID.Text + "' and AmenityID=12";
                    r.Modify(sql);
                }
              
            }
            MessageBox.Show("Amenities Sucessfully save!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ch1.Enabled = true;
            ch2.Enabled = true;
            ch3.Enabled = true;
            ch4.Enabled = true;
            ch5.Enabled = true;
            ch6.Enabled = true;
            ch7.Enabled = true;
            ch8.Enabled = true;
            ch9.Enabled = true;
            ch10.Enabled = true;
            ch11.Enabled = true;
            ch12.Enabled = true;
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;
            ch12.Checked = false;
            lblcabin.Text = "[xxxxxxxxx]";
            lblfname.Text = "[xxxxxxxxx]";
            lblpassport.Text = "[xxxxxxxxx]";
            ticketID.Text = "[xxxxxxxxx]";
            cmbflights.Text = "";
            items =0;
            txx = 0;
            total = 0;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
            txtbk.Text = "";

        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            AmenitiesRepot a = new AmenitiesRepot();
            a.Show();
            this.Hide();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtbk.Text == "")
            {
                MessageBox.Show("Please Enter book references!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cabin();
            }
         }
        //code for showing ammenities
        private void ShowAmm()
        {
            sql= @"Select Tickets.FirstName+' '+Tickets.Lastname,
            CabinTypes.Name, Tickets.PassportNumber, Tickets.ID 
            from Tickets
            inner join CabinTypes on CabinTypes.ID=Tickets.CabinTypeID
             where BookingReference='" + txtbk.Text + "'";
            r.DisplaySingle(sql);
            lblfname.Text = r.getf1();
            lblcabin.Text = r.getf2();
            lblpassport.Text = r.getf3();
            ticketID.Text = r.getf4();

        }

        //cabin 
        private void cabin()
        {
            string option1,price;
            
            ShowAmm();
          

            if (lblcabin.Text== "Economy")
            {
                ch1.Enabled = true;
                ch2.Enabled = true;
                ch3.Enabled = true;
                ch4.Enabled = true;
                ch5.Enabled = true;
                ch6.Enabled = true;
                ch7.Enabled = false;
                ch8.Enabled = true;
                ch9.Enabled = true;
                ch10.Enabled = true;
                ch11.Enabled = false;
                ch12.Enabled = true;
                ch1.Checked = false;
                ch2.Checked = false;
                ch3.Checked = false;
                ch4.Checked = false;
                ch5.Checked = false;
                ch6.Checked = false;
                ch7.Checked = true;
                ch8.Checked = false;
                ch9.Checked = false;
                ch10.Checked = false;
                ch11.Checked = true;
                ch12.Checked = false;
                items = 0;
                txx = 0;
                total = 0;
                lblitems.Text = items.ToString();
                lbltax.Text = txx.ToString();
                lbltotal.Text = total.ToString();
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=1";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();

                if (option1 != "")
                {
                    ch1.Checked = true;


                   
                }
                else
                {
                    ch1.Checked = false;
                    items = 0;
                    txx = 0;
                    total = 0;
                    lblitems.Text = items.ToString();
                    lbltax.Text = txx.ToString();
                    lbltotal.Text = total.ToString();
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=2";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch2.Checked = true;


                    
                }
                else
                {
                    ch2.Checked = false;
                   
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=3";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch3.Checked = true;


                   
                }
                else
                {
                    ch3.Checked = false;
                   
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=4";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch4.Checked = true;


                    
                }
                else
                {
                    ch4.Checked = false;
                    
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=1";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch5.Checked = true;


                }
                else
                {
                    ch5.Checked = false;
                    
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=6";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch6.Checked = true;


                   
                }
                else
                {
                    ch6.Checked = false;
                   
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=8";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch8.Checked = true;


                   
                }
                else
                {
                    ch8.Checked = false;
                    
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=9";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch9.Checked = true;


                }
                else
                {
                    ch9.Checked = false;
                    
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=10";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch10.Checked = true;


                   
                }
                else
                {
                    ch10.Checked = false;
                   
                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=12";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch12.Checked = true;


                   
                }
                else
                {
                    ch12.Checked = false;
                   
                }


            }
            else if (lblcabin.Text == "Business")
            {
                ch1.Enabled = false;
                ch2.Enabled = true;
                ch3.Enabled = true;
                ch4.Enabled = false;
                ch5.Enabled = true;
                ch6.Enabled = false;
                ch7.Enabled = false;
                ch8.Enabled = true;
                ch9.Enabled = true;
                ch10.Enabled = true;
                ch11.Enabled = false;
                ch12.Enabled = true;
                ch1.Checked = true;
                ch2.Checked = false;
                ch3.Checked = false;
                ch4.Checked = true;
                ch5.Checked = false;
                ch6.Checked = true;
                ch7.Checked = true;
                ch8.Checked = false;
                ch9.Checked = false;
                ch10.Checked = false;
                ch11.Checked = true;
                ch12.Checked = false;
                items = 0;
                txx = 0;
                total = 0;
                lblitems.Text = items.ToString();
                lbltax.Text = txx.ToString();
                lbltotal.Text = total.ToString();
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=2";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch1.Checked = true;


                }
                else
                {
                    ch1.Checked = false;

                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=3";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch3.Checked = true;


                }
                else
                {
                    ch3.Checked = false;

                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=10";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch10.Checked = true;


                }
                else
                {
                    ch10.Checked = false;

                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=12";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch12.Checked = true;


                }
                else
                {
                    ch12.Checked = false;

                }
            }
            else if (lblcabin.Text == "First Class")
            {
                ch1.Enabled = false;
                ch2.Enabled = true;
                ch3.Enabled = true;
                ch4.Enabled = false;
                ch5.Enabled = false;
                ch6.Enabled = false;
                ch7.Enabled = false;
                ch8.Enabled = false;
                ch9.Enabled = false;
                ch10.Enabled = true;
                ch11.Enabled = false;
                ch12.Enabled = false;
                ch1.Checked = true;
                ch2.Checked = false;
                ch3.Checked = false;
                ch4.Checked = true;
                ch5.Checked = true;
                ch6.Checked = true;
                ch7.Checked = true;
                ch8.Checked = true;
                ch9.Checked = true;
                ch10.Checked = false;
                ch11.Checked = true;
                ch12.Checked = true;
                items = 0;
                txx = 0;
                total = 0;
                lblitems.Text = items.ToString();
                lbltax.Text = txx.ToString();
                lbltotal.Text = total.ToString();
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=2";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch2.Checked = true;


                }
                else
                {
                    ch2.Checked = false;

                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=3";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch3.Checked = true;


                }
                else
                {
                    ch3.Checked = false;

                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=10";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch3.Checked = true;


                }
                else
                {
                    ch3.Checked = false;

                }
                sql = @"Select AmenitiesTickets.AmenityID,AmenitiesTickets.Price from Tickets
	            inner join AmenitiesTickets on Tickets.ID=AmenitiesTickets.TicketID
	            where BookingReference='" + txtbk.Text + "'and AmenitiesTickets.AmenityID=11";
                r.DisplaySingle(sql);
                option1 = r.getf1();
                price = r.getf2();
                if (option1 != "")
                {
                    ch11.Checked = true;


                }
                else
                {
                    ch11.Checked = false;

                }
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            
            
                bookrefsearch();
            
            
        }

        //code for book references search
        private void bookrefsearch()
        {
            

            if (txtbk.Text == "")
            {
                MessageBox.Show("Please Enter book references!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                sql = @"select Schedules.FlightNumber,
	            (Select IATACode from Airports where ID=Routes.DepartureAirportID), 
	            (Select IATACode from Airports where ID=Routes.ArrivalAirportID), 
	            Schedules.Date,
	            Schedules.Time
                from Schedules
                inner join Routes on Schedules.RouteID=Routes.ID
                inner join Tickets on Schedules.ID=Tickets.ScheduleID
                where BookingReference='" + txtbk.Text + "'";
                r.DisplaySingle(sql);
                cmbflights.Text = r.getf1().ToString() + "," + r.getf2().ToString() + "-" + r.getf3().ToString() + "," + Convert.ToDateTime(r.getf4()).ToShortDateString() + "," + r.getf5().ToString();

            }
           
            
            
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            ch1.Enabled = true;
            ch2.Enabled = true;
            ch3.Enabled = true;
            ch4.Enabled = true;
            ch5.Enabled = true;
            ch6.Enabled = true;
            ch7.Enabled = true;
            ch8.Enabled = true;
            ch9.Enabled = true;
            ch10.Enabled = true;
            ch11.Enabled = true;
            ch12.Enabled = true;
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;
            ch12.Checked = false;
            items = 0;
            txx = 0;
            total = 0;
            lblitems.Text = items.ToString();
            lbltax.Text = txx.ToString();
            lbltotal.Text = total.ToString();
        }
    }
}
