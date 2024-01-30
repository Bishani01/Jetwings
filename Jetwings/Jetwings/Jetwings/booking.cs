using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static db;

namespace Jetwings
{
    public partial class booking : Form
    {
        private int userID;
        private string userEmail;
        public booking(int id)
        {
            InitializeComponent();
            this.userID = id;
            userEmail = Get.email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_backtoHome_Click(object sender, EventArgs e)
        {
            home1 Home = new home1(userID);
            this.Hide();
            Home.Show();
        }

        private void txt_Cal_Click(object sender, EventArgs e)
        {
            
            

                if (cmb_HotelBranch.SelectedIndex == 0)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);
                    int totalperson = adults + children;

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(30000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(46000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(50000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
                else if (cmb_HotelBranch.SelectedIndex == 1)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(40000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(56000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(60000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
                if (cmb_HotelBranch.SelectedIndex == 2)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(50000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(66000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(75000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
                if (cmb_HotelBranch.SelectedIndex == 3)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(45000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(52000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(65000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
                if (cmb_HotelBranch.SelectedIndex == 4)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(25000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(38000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(47000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
                if (cmb_HotelBranch.SelectedIndex == 5)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(40000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(55000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(68000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
                if (cmb_HotelBranch.SelectedIndex == 5)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(32000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(42000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(52000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
                if (cmb_HotelBranch.SelectedIndex == 6)
                {

                    // Maximum guests for each package
                    int standardMaxAdults = 2;
                    int standardMaxChildren = 1;

                    int classicMaxAdults = 3;
                    int classicMaxChildren = 2;

                    int premiumMaxAdults = 5;
                    int premiumMaxChildren = 1;

                    // Get user inputs
                    string selectedPackage = cmb_package.SelectedItem?.ToString();
                    DateTime checkInDate = dob_DateIn.Value;
                    DateTime checkOutDate = dob_DateOut.Value;
                    int adults = Convert.ToInt32(txt_Adults.Text);
                    int children = Convert.ToInt32(txt_Child.Text);

                    // Perform calculation and validation based on selected package and dates
                    decimal totalPrice = 0;
                    string errorMessage = "";

                    switch (selectedPackage)
                    {
                        case "Standard":
                            if (adults <= standardMaxAdults && children <= standardMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(52000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Standard package.";
                            break;

                        case "Classic":
                            if (adults <= classicMaxAdults && children <= classicMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(60000 * duration.TotalDays);
                                   label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Classic package.";
                            break;

                        case "Premium":
                            if (adults <= premiumMaxAdults && children <= premiumMaxChildren)
                            {
                                TimeSpan duration = checkOutDate - checkInDate;
                                if (duration.TotalDays >= 0)
                                {
                                    totalPrice = (decimal)(80000 * duration.TotalDays);
                                    label_Total.Text = totalPrice.ToString("F2");
                                }
                                else
                                {
                                    errorMessage = "Invalid date range. Check-out date should be greater than or equal to check-in date.";
                                }
                            }
                            else
                                errorMessage = "Maximum guests exceeded for the Premium package.";
                            break;

                        default:
                            errorMessage = "Invalid package selection.";
                            break;
                    }

                }
               

            }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             
            
                
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-JSOA6DH;Initial Catalog=jetwings;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();

                        // Assuming you have the required data for database insertion
                        string bookBranch = cmb_HotelBranch.Text;
                        string bookPackage = cmb_package.Text;
                        DateTime checkInDate = dob_DateIn.Value;
                        DateTime checkOutDate = dob_DateOut.Value;
                        int adults = Convert.ToInt32(txt_Adults.Text);
                        int children = Convert.ToInt32(txt_Child.Text);
                    

                        // Calculate the total count of adults and children
                        int totalPerson = adults + children;

                        SqlCommand cmd = new SqlCommand("INSERT INTO BookingDetails (Book_Branch, Book_Packages, Book_TotalPerson, Book_DateIn, Book_DateOut,Amount, Cust_ID) " +
                                                        "VALUES (@BookBranch, @BookPackage, @TotalPerson, @CheckInDate, @CheckOutDate,'"+label_Total.Text+"','"+userID+ "') SELECT SCOPE_IDENTITY()", con);

                        cmd.Parameters.AddWithValue("@BookBranch", bookBranch);
                        cmd.Parameters.AddWithValue("@BookPackage", bookPackage);
                        cmd.Parameters.AddWithValue("@TotalPerson", totalPerson);
                        cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                        cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                        int booking_id = Convert.ToInt32(cmd.ExecuteScalar());


                        

                   

                        MessageBox.Show("Booking successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Bill bill = new Bill(booking_id, userID,userEmail);
                    bill.Show();

                    
                }
               
            
        }
    }
    }

