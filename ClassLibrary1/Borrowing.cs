using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Borrowing
    {   
        public int BorrowerId { get; private set; }
        public string BorrowerName { get; private set; }
        public string BorrowerSurname { get; private set; }
        public int BorrowingBookId { get; private set; }
        public DateOnly BorrowingDate { get; private set; }
        public DateOnly ReturnDate { get; private set; }
        public Borrowing (int borrowerId, string borrowerName, string borrowerSurname, int borrowingBookId)
            
        {
            BorrowerId = borrowerId;
            BorrowerName = borrowerName;
            BorrowerSurname = borrowerSurname;
            BorrowingBookId = borrowingBookId;
            BorrowingDate = DateOnly.FromDateTime(DateTime.Today);
            ReturnDate = BorrowingDate.AddDays(14); 
        }
    }
}
