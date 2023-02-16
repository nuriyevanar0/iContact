using System.Text.RegularExpressions;

namespace ContactBookWF
{
    public class ContactValidator
    {
        public bool contactIsEmpty(string firstname, string surname, string phoneNumber, string email)
        {
            if (!string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(email))
            {
                return false;
            }
            return true;
        }

        public bool fieldIsFormatted(string phone, string email)
        {
            if (Regex.IsMatch(phone, "^[0-9]+$") && Regex.IsMatch(email, @"(@)(.+)$"))
            {
                return true;
            }
            return false;
        }
    }
}
