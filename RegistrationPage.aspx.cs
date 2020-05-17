using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace WebApplication4
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Panel4.Visible = false;
        }

        protected void btnGeri_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbAd.Text.Length==0|| tbSoyad.Text.Length == 0 || tbTel.Text.Length == 0 || tbEmail.Text.Length == 0)
            {
                Response.Write("<script>alert('Lütfen Önce Bilgilerinizi Girin!!!')</script>");
            }
            else
            {
                
                OleDbConnection db_baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("Booking.mdb"));

                string sorgu= "INSERT INTO Bookings (bookingID, busCapacity, passengerID,passengerSeatID,passengerName,passengerSurname,passengerGender,passengerEmail,passengerPhone) VALUES(@bookingID,@capacity,@passengerID,@seatNo,@ad, @soyad,@gender,@email,@phone)";
                OleDbCommand komut;
                komut = new OleDbCommand(sorgu, db_baglanti);
                try
                {
                    komut.Parameters.AddWithValue("@bookingID", Session["bookingID"].ToString());
                    komut.Parameters.AddWithValue("@capacity", 48);
                    komut.Parameters.AddWithValue("@passengerID", (int)Session["passengerID"] + 1);
                    komut.Parameters.AddWithValue("@seatNo", Session["seatNo"].ToString());
                    komut.Parameters.AddWithValue("@ad", tbAd.Text.ToString());
                    komut.Parameters.AddWithValue("@soyad", tbSoyad.Text.ToString());
                    komut.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Text.ToString());
                    komut.Parameters.AddWithValue("@email", tbEmail.Text.ToString());
                    komut.Parameters.AddWithValue("@phone", tbTel.Text.ToString());
                    
                    db_baglanti.Open();
                    komut.ExecuteNonQuery();
                    printTicket();
                    clear();
                    db_baglanti.Close();
                }
                catch { }
            }
            

        }
        void clear()
        {
            tbAd.Text = "";
            tbSoyad.Text = "";
            tbEmail.Text = "";
            tbTel.Text = "";
            
        }
        void printTicket()
        {
            tbNameSurname.Text = tbAd.Text.ToString() + " " + tbSoyad.Text.ToString();
            tbSeatNo.Text = Session["seatNo"].ToString();
            tbHour.Text = Session["hour"].ToString();
            Panel3.Enabled = false;
            Panel4.Visible = true;
            btnGeri.Text = "Anasayfaya Dön";
        }
    }
}