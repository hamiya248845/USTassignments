using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolingSystem
{
    public class Member
    {
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } } 

        private string _email;
        public string Email { get { return _email; } set { _email = value; } }

        private string _contactNumber;
        public string ContactNumber { get { return _contactNumber; } set { _contactNumber = value; } }

        private string _licenseNumber;
        public string LicenseNumber { get { return _licenseNumber; } set { _licenseNumber = value; } }

        private DateTime _licenseStartDate;
        public DateTime LicenseStartDate { get { return _licenseStartDate; }
            set
            {
                _licenseStartDate = value;
            } }
        private DateTime _licenseExpiryDate;
        public DateTime LicenseExpiryDate { get { return _licenseExpiryDate; }
            set
            {
                _licenseExpiryDate = value;
            } }
        public Member() { }

        public Member(long id, string firstName, string lastName, string email, string contactNumber, string licenseNumber, DateTime licenseStartDate,  DateTime licenseExpiryDate)
        {
           _id= id;
            _firstName= firstName;
            _lastName= lastName;
            _email= email;
            _contactNumber = contactNumber;
            _licenseNumber = licenseNumber;
            _licenseStartDate = licenseStartDate;
            _licenseExpiryDate = licenseExpiryDate;
        }
        public override string ToString()
        {
            return string.Format($"Member: {_firstName}, {_lastName}\nMember contact details {_contactNumber},{_email}");
        }

        public override bool Equals(object obj)
        {
            Member m = obj as Member;
            if (m.Email==Email && m.ContactNumber==ContactNumber)
            {
                return true;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
