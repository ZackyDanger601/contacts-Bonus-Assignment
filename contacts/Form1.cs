using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contacts
{
    
    
    public partial class Form1 : Form
    {
        private contact[] phoneBook = new contact[1];

        public Form1()
        {
            InitializeComponent();
        }

        private void Write(contact obj)
        {
            StreamWriter sw = new StreamWriter("contacts.txt");
            sw.WriteLine(phoneBook.Length + 1);
            sw.WriteLine(obj.FirstName);
            sw.WriteLine(obj.LastName);
            sw.WriteLine(obj.Phone);

            for(int x = 0; x < phoneBook.Length; x++)
            {
                sw.WriteLine(phoneBook[x].FirstName);
                sw.WriteLine(phoneBook[x].LastName);
                sw.WriteLine(phoneBook[x].Phone);
            }

            sw.Close();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("contacts.txt");
            phoneBook = new contact[Convert.ToInt32(sr.ReadLine())];

            for(int x = 0; x < phoneBook.Length; x++)
            {
                phoneBook[x] = new contact();
                phoneBook[x].FirstName = sr.ReadLine();
                phoneBook[x].LastName = sr.ReadLine();
                phoneBook[x].Phone = sr.ReadLine();
            }

            sr.Close();
        }

        private void Display()
        {
            lstContacts.Items.Clear();

            for(int x = 0; x < phoneBook.Length; x++)
            {
                lstContacts.Items.Add(phoneBook[x].ToString());
            }
        }

        private void Reset()
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPhoneNum.Text = String.Empty;

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            contact obj = new contact();
            obj.FirstName = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.Phone = txtPhoneNum.Text;

            Write(obj);
            Read();
            Display();
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            Display();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void BubbleSort()
        {
            contact temp;
            bool swap;

            do
            {
                swap = false;

                for (int x = 0; x < (phoneBook.Length - 1) ; x++)
                {
                    
                }
            } while (swap == true);
        }
    }
}
