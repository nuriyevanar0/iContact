using System.Text.RegularExpressions;

namespace ContactBookWF
{

    public partial class Form1 : Form
    {
        public static int delUserID = 0;
        List<Contact> contacts;
        ContactValidator validator;
        public Form1()
        {
            InitializeComponent();
            validator = new ContactValidator();

            using (ContactContext db = new ContactContext())
            {
                contacts = db.contacts.ToList();
            }
            contactsDataGrid.DataSource = contacts;
            contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            contactsDataGrid.ReadOnly = true;
            idTB.ReadOnly = true;
            datagridBrthdy.DataSource = initBirthdays();
            datagridBrthdy.ReadOnly = true;
            datagridBrthdy.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
        }


        private List<Contact> initBirthdays()
        {

            List<Contact> topContacts = new List<Contact>();
            foreach (var contact in contacts)
            {
                var date1 = DateTime.Now;
                var date2 = contact.dateOfBirth;
                if (date1.Month == date2.Month && (date1.Day - date2.Day) <= 7 && date2.Day >= date1.Day)
                {
                    topContacts.Add(contact);
                }

            }
            return topContacts;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            using (ContactContext db = new ContactContext())
            {
                if (!validator.contactIsEmpty(firstnameTB.Text, surnameTB.Text, phoneNumTB.Text, emailTB.Text))
                {
                    if (validator.fieldIsFormatted(phoneNumTB.Text, emailTB.Text))
                    {
                        db.contacts.Add(new Contact { FirstName = firstnameTB.Text, LastName = surnameTB.Text, PhoneNum = phoneNumTB.Text, Email = emailTB.Text, dateOfBirth = dateOfBirthClndr.Value });
                        db.SaveChanges();
                        infoLB.Text = "One user created!";
                        contacts = db.contacts.ToList();
                        contactsDataGrid.DataSource = null;
                        contactsDataGrid.DataSource = contacts;
                        contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";

                        datagridBrthdy.DataSource = initBirthdays();
                        datagridBrthdy.ReadOnly = true;
                        datagridBrthdy.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            Contact user;
            using (ContactContext db = new ContactContext())
            {
                int delUserID = Convert.ToInt32(idTB.Text);
                user = db.contacts.Where(d => d.ID == delUserID).FirstOrDefault();
                if (user != null)
                {
                    db.contacts.Remove(user);
                    db.SaveChanges();
                    infoLB.Text = "One user deleted";
                }
                else
                {
                    infoLB.Text = "User not found!";
                }

                contacts = db.contacts.ToList();
                contactsDataGrid.DataSource = null;
                contactsDataGrid.DataSource = contacts;
                contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";

                datagridBrthdy.DataSource = initBirthdays();
                datagridBrthdy.ReadOnly = true;
                datagridBrthdy.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Contact user;
            delUserID = Convert.ToInt32(idTB.Text);
            using (ContactContext db = new ContactContext())
            {
                user = db.contacts.Where(d => d.ID == Form1.delUserID).FirstOrDefault();

                if (user != null)
                {
                    Form2 editForm = new Form2();
                    editForm.Show();
                }
                else
                {
                    infoLB.Text = "User not found!";
                }
            }


        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            using (ContactContext db = new ContactContext())
            {
                db.SaveChanges();
                infoLB.Text = "Database Refreshed!";
                contacts = db.contacts.ToList();
                contactsDataGrid.DataSource = null;
                contactsDataGrid.DataSource = contacts;
                contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";

                datagridBrthdy.DataSource = initBirthdays();
                datagridBrthdy.ReadOnly = true;
                datagridBrthdy.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";

            }
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            Contact SearchUser;
            using (ContactContext db = new ContactContext())
            {
                if (searchTB.Text == "" || searchTB.Text == null)
                {
                    contacts = db.contacts.ToList();
                    contactsDataGrid.DataSource = null;
                    contactsDataGrid.DataSource = contacts;
                    contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
                }
                else
                {
                    if (searchTB.Text.Contains("/"))
                    {
                        try
                        {
                            DateTime date = Convert.ToDateTime(searchTB.Text);
                            var data = db.contacts.Where(x => x.dateOfBirth.Month == date.Month
                                                            && x.dateOfBirth.Day == date.Day
                                                            && x.dateOfBirth.Year == date.Year);
                            contacts = data.ToList();
                            contactsDataGrid.DataSource = null;
                            contactsDataGrid.DataSource = contacts;
                            contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
                        }
                        catch
                        {
                            contacts = db.contacts.ToList();
                            contactsDataGrid.DataSource = null;
                            contactsDataGrid.DataSource = contacts;
                            contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
                        }

                    }
                    else
                    {

                        var data = db.contacts.Where(c => c.FirstName == searchTB.Text || c.LastName == searchTB.Text || c.Email == searchTB.Text || c.PhoneNum == searchTB.Text);
                        contacts = data.ToList();
                        contactsDataGrid.DataSource = null;
                        contactsDataGrid.DataSource = contacts;
                        contactsDataGrid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
                    }
                }
            }
        }

        private void contactsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = contactsDataGrid.Rows[index];
            idTB.Text = selectedRow.Cells[0].Value.ToString();
        }
    }
}
