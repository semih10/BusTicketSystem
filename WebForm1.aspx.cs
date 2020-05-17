using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ArrayList availableSeat = new ArrayList();
        ArrayList availableSeatt = new ArrayList();
        ArrayList availableSeattt = new ArrayList();
        ImageButton myButton;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            pnlAccord.Visible = false;
            lbSonuc.Visible = false;
            ArrayList list = new ArrayList();
            int busCapacity = 48;

            for (int i = 1; i <= busCapacity; i++)
            {
                availableSeat.Add(i);
            }
          

            OleDbConnection db_baglanti=new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("Booking.mdb"));
            db_baglanti.Open();
            OleDbCommand db_komut = new OleDbCommand("select passengerSeatID from Bookings where bookingID like'%0315'", db_baglanti);
            OleDbDataReader alinan_veri;
            alinan_veri = db_komut.ExecuteReader();

            while (alinan_veri.Read())
            {
                list.Add(alinan_veri[0]);
            }
            

           
            int counter = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (availableSeat.Contains(list[i]))
                {
                    availableSeat.Remove(list[i]);
                    counter++;
                }
            }
            Label3.Text = (busCapacity - counter).ToString()+" adet boş koltuk vardır";
            
            for (int i = 1; i <= busCapacity; i++)
            {
                myButton = new ImageButton();

                myButton.ID = "imgBtn" + i;
                myButton.Height = Unit.Pixel(50);
                myButton.Width = Unit.Pixel(50);
                myButton.Style.Add("margin-top", "10px");
                if (i % 2 == 0)
                {
                    myButton.Style.Add("margin-left", "5px");
                }
                else
                {
                    myButton.Style.Add("margin-left", "25px");
                }
                if (availableSeat.Contains(i))
                {
                    myButton.ImageUrl = "~/image/seats/boş" + i + ".png";
                    myButton.Enabled = true;
                }
                else
                {
                    myButton.ImageUrl = "~/image/seats/dolu" + i + ".png";
                    myButton.Enabled = false;
                }
                myButton.Click += new ImageClickEventHandler(this.imgBtn_Click);
                
                AccordionPane1.ContentContainer.Controls.Add(myButton);
            }
           
            db_baglanti.Close();

            ArrayList listt = new ArrayList();

            for (int i = 1; i <= busCapacity; i++)
            {
                availableSeatt.Add(i);
            }

           

            OleDbConnection db_baglantii = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("Booking.mdb"));
            db_baglantii.Open();
            OleDbCommand db_komutt = new OleDbCommand("select passengerSeatID from Bookings where bookingID like'%0700'", db_baglantii);
            OleDbDataReader alinan_verii;
            alinan_verii = db_komutt.ExecuteReader();

            while (alinan_verii.Read())
            {
                listt.Add(alinan_verii[0]);
            }
           
            counter = 0;
            for (int i = 0; i < listt.Count; i++)
            {
                if (availableSeatt.Contains(listt[i]))
                {
                    availableSeatt.Remove(listt[i]);
                    counter++;
                }
            }
            Label4.Text = (busCapacity - counter).ToString() + " adet boş koltuk vardır";
            for (int i = 1; i <= busCapacity; i++)
            {
                myButton = new ImageButton();

                myButton.ID = "imButn" + i;
                myButton.Height = Unit.Pixel(50);
                myButton.Width = Unit.Pixel(50);
                myButton.Style.Add("margin-top", "10px");
                if (i % 2 == 0)
                {
                    myButton.Style.Add("margin-left", "5px");
                }
                else
                {
                    myButton.Style.Add("margin-left", "25px");
                }
                if (availableSeatt.Contains(i))
                {
                    myButton.ImageUrl = "~/image/seats/boş" + i + ".png";
                    myButton.Enabled = true;
                }
                else
                {
                    myButton.ImageUrl = "~/image/seats/dolu" + i + ".png";
                    myButton.Enabled = false;
                }
                myButton.Click += new ImageClickEventHandler(this.imgBtn_Click);




                AccordionPane2.ContentContainer.Controls.Add(myButton);
            }
            db_baglantii.Close();
            

            ArrayList listtt = new ArrayList();

            for (int i = 1; i <= busCapacity; i++)
            {
                availableSeattt.Add(i);
            }
           

            OleDbConnection db_baglantiii = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("Booking.mdb"));
            db_baglantiii.Open();
            OleDbCommand db_komuttt = new OleDbCommand("select passengerSeatID from Bookings where bookingID like'%0900'", db_baglantiii);
            OleDbDataReader alinan_veriii;
            alinan_veriii = db_komuttt.ExecuteReader();

            while (alinan_veriii.Read())
            {
                listtt.Add(alinan_veriii[0]);
            }

           
            counter = 0;
            for (int i = 0; i < listtt.Count; i++)
            {
                if (availableSeattt.Contains(listtt[i]))
                {
                    availableSeattt.Remove(listtt[i]);
                    counter++;
                }
            }
            Label5.Text = (busCapacity-counter).ToString() + " adet boş koltuk vardır";
            for (int i = 1; i <= busCapacity; i++)
            {
                myButton = new ImageButton();

                myButton.ID = "imBton" + i;
                myButton.Height = Unit.Pixel(50);
                myButton.Width = Unit.Pixel(50);
                myButton.Style.Add("margin-top", "10px");
                if (i % 2 == 0)
                {
                    myButton.Style.Add("margin-left", "5px");
                }
                else
                {
                    myButton.Style.Add("margin-left", "25px");
                }
                if (availableSeattt.Contains(i))
                {
                    myButton.ImageUrl = "~/image/seats/boş" + i + ".png";
                    myButton.Enabled = true;
                }
                else
                {
                    myButton.ImageUrl = "~/image/seats/dolu" + i + ".png";
                    myButton.Enabled = false;
                }
                myButton.Click += new ImageClickEventHandler(this.imgBtn_Click);


                AccordionPane3.ContentContainer.Controls.Add(myButton);
            }
            
            db_baglantiii.Close();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Button btn;
            for(int i = 0; i < 2; i++)
            {
                btn = (Button)AccordionPane1.FindControl("mb"+i);
                btn.Text = ""+i+". buton";
            }*/


        }

        protected void btnSorgula_Click(object sender, EventArgs e)
        {
            if (dlFrom.SelectedItem.Text == "Bursa" && dlTo.SelectedItem.Text == "İstanbul"
                && Calendar1.SelectedDate.ToShortDateString() == "28.03.2020")
            {
                pnlAccord.Visible = true;

            }
            else
            {
                lbSonuc.Visible = true;
            }
        }
        void imgBtn_Click(object sender, EventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;
            string seatNo = imageButton.ID.Substring(6);
            if (imageButton.ID.Contains("imgBtn"))
            {
                Session["bookingID"] = "26PMK26-20200328-0315";
                Session["hour"] = "03:15";

                

                OleDbConnection db_baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("Booking.mdb"));
                db_baglanti.Open();
                OleDbCommand db_komut = new OleDbCommand("select max(passengerID) from Bookings where bookingID='26PMK26-20200328-0315'", db_baglanti);
                OleDbDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                int passengerID=0;
                while (alinan_veri.Read())
                {
                    passengerID = (int)alinan_veri[0];
                }
             
                db_baglanti.Close();
                Session["passengerID"] = passengerID;
            }
            if (imageButton.ID.Contains("imButn"))
            {
                Session["bookingID"] = "26PMK26-20200328-0700";
                Session["hour"] = "07:00";
              

                OleDbConnection db_baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("Booking.mdb"));
                db_baglanti.Open();
                OleDbCommand db_komut = new OleDbCommand("select max(passengerID) from Bookings where bookingID='26PMK26-20200328-0700'", db_baglanti);
                OleDbDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                int passengerID = 0;
                while (alinan_veri.Read())
                {
                    passengerID = (int)alinan_veri[0];
                }
              
                db_baglanti.Close();
                Session["passengerID"] = passengerID;
            }
            if (imageButton.ID.Contains("imBton"))
            {
                Session["bookingID"] = "26PMK26-20200328-0900";
                Session["hour"] = "09:00";
                

                OleDbConnection db_baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("Booking.mdb"));
                db_baglanti.Open();
                OleDbCommand db_komut = new OleDbCommand("select max(passengerID) from Bookings where bookingID='26PMK26-20200328-0900'", db_baglanti);
                OleDbDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                int passengerID = 0;
                while (alinan_veri.Read())
                {
                    passengerID = (int)alinan_veri[0];
                }
             
                db_baglanti.Close();
                Session["passengerID"] = passengerID;
            }
            Session["seatNo"] = seatNo;
            Response.Redirect("RegistrationPage.aspx");
        }
    }
}