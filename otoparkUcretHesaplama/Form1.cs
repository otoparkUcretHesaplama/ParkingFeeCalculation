using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingFeeCalculation;

namespace ParkingFeeCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _checkinTime = string.Empty;
        private string _checkOutTime = string.Empty;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtcheckinTime.Text))
            {
                MessageBox.Show("You must enter the entry time", "Error");
                // It sends the error code to the screen.

                txtcheckinTime.Focus();
                // If the input clock is blank, the cursor will be highlighted in the box
            }
            else
            {
                try
                {
                    _checkinTime = Convert.ToDateTime(txtcheckinTime.Text).ToShortTimeString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("You must enter the Checkin Time.. - Examp. 12:42  ", "Error: "+ex.Message+"");//Giriş Saati Doğru Girmelisiniz
                }
                
               //giriş saati degişkene atandı
            }
            if (string.IsNullOrEmpty(txtcheckOutTime.Text))
            {
                MessageBox.Show("You must enter the Checkout Time.. - Examp. 12:42  ", "Error");//Çıkış Saati Girmelisiniz.
                txtcheckOutTime.Focus();
            }
            else
            {
                try
                {
                    _checkOutTime = Convert.ToDateTime(txtcheckOutTime.Text).ToShortTimeString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("You must enter the Checkout Time.", "Error: " + ex.Message + "");
                }
                
                // çıkış saati degişkene atandı
            }
            if (!string.IsNullOrEmpty(_checkinTime) && !string.IsNullOrEmpty(_checkOutTime))
            {
                TimeSpan calculate = (Convert.ToDateTime(_checkOutTime) - Convert.ToDateTime(_checkinTime));
                lblTotalTime.Text = calculate.Hours.ToString() + ":" + calculate.Minutes.ToString();
                int _parkingType = 0;
                int _vehicleType = 0;
                switch (cbParkingType.SelectedIndex)
                {
                    case 0:
                    {
                        _parkingType = 2;
                        //açık otopark fiyat 
                        //Indoor parking price
                        break;
                        
                    }
                    case 1:
                    {
                        _parkingType = 5;
                        //Outdoor parking price

                        break;
                        
                    }
                    default:
                    {
                        _parkingType = 1;
                        //Default parking price
                        break;
                    }
                }
                switch (cbCarType.SelectedIndex)
                {
                    // Truck 0 - 6 TL difference
                    // Mini Pickup 1 - 5 TL difference
                    // Taxi 2 - 4 TL difference
                    // Commercial Vehicle - 3 TL difference
                    // Motorcycle - 2 TL difference
                    // Others - $ 1 difference

                    case 0:
                    {
                        _vehicleType = 6;
                        break;
                    }
                    case 1:
                    {
                        _vehicleType = 5;
                        break;
                    }
                    case 2:
                    {
                        _vehicleType = 4;
                        break;
                    }
                    case 3:
                    {
                        _vehicleType = 3;
                        break;
                    }
                    case 4:
                    {
                        _vehicleType = 2;
                        break;
                    }
                    case 5:
                    {
                        _vehicleType = 1;
                        break;
                    }

                }
                lblTotalTL.Text = ((Convert.ToInt32(calculate.Hours)*_parkingType + (Convert.ToDecimal(calculate.Minutes)/60)*_parkingType)*_vehicleType).ToString();
                lblTotalEuro.Text = (Convert.ToDecimal(lblTotalTL.Text)*Convert.ToDecimal(txtEuroKur.Text)).ToString().Substring(0,6);

            }

        }

       
        //DateTime.Now.ToShortTimeString();

    }
}
