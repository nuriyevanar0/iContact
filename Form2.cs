using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ContactBookWF
{
    public partial class Form2 : Form
    {
        List<Contact> contacts;
        ContactValidator validator;
        public Form2()
        {
            InitializeComponent();
            validator = new ContactValidator();
            loadData();
        }

        void loadData()
        {
            using (ContactContext db = new ContactContext())
            {
                var contact = db.contacts.Where(d => d.ID == Form1.delUserID).FirstOrDefault();
                firstnameTB.Text = contact.FirstName;
                surnameTB.Text = contact.LastName;
                phoneNumTB.Text = contact.PhoneNum;
                emailTB.Text = contact.Email;
                dateOfBirthClndr.Value = contact.dateOfBirth;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!validator.contactIsEmpty(firstnameTB.Text, surnameTB.Text, phoneNumTB.Text, emailTB.Text))
            {
                if (validator.fieldIsFormatted(phoneNumTB.Text, emailTB.Text))
                {
                    Contact user;
                    //db.Blogs.Add(new Blog { Id = id, Name = "xxx", Version = DateTime.Now.Ticks });
                    using (ContactContext db = new ContactContext())
                    {
                        user = db.contacts.Where(d => d.ID == Form1.delUserID).FirstOrDefault();
                        user.FirstName = firstnameTB.Text;
                        user.LastName = surnameTB.Text;
                        user.PhoneNum = phoneNumTB.Text;
                        user.Email = emailTB.Text;
                        user.dateOfBirth = dateOfBirthClndr.Value;
                        db.SaveChanges();
                        contacts = db.contacts.ToList();
                        MessageBox.Show("Contacts edited successfully, press refresh button please");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Your phone number or email are not in correct format");
                }
            }
            else
            {
                MessageBox.Show("One/more of the fields is empty");
            }
        }
    }
}