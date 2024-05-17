using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ForeignPassport
    {
        private string _passportNumber;
        private string _fullName;
        private DateTime _dateOfIssue;

        public ForeignPassport(string passportNumber, string fullName, DateTime dateOfIssue)
        {
            if (string.IsNullOrEmpty(passportNumber))
            {
                throw new ArgumentException("Недопустимый номер паспорта");
            }

            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("Недопустимое ФИО владельца паспорта");
            }

            if (dateOfIssue == DateTime.MinValue)
            {
                throw new ArgumentException("Недопустимая дата выдачи паспорта");
            }

            _passportNumber = passportNumber;
            _fullName = fullName;
            _dateOfIssue = dateOfIssue;
        }
    }
}
