using exercicio04.Entities.Enums;
using System;

namespace exercicio04.Entities
{
    internal class Loans
    {
        
        public Client Client { get; set; }
        public Catalog Book { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime DueDate { get; set; }

        public ItemStatus Status { get; set; }

        public Loans(Client client, Catalog book, ItemStatus status)
        {
            Client = client;
            Book = book;
            CheckOutDate = DateTime.Now;
            DueDate = CheckOutDate.AddMonths(1);
            Status = status;
        }

        public void Borrow()
        {
            if (Status == ItemStatus.Available)
            {
                Status = ItemStatus.CheckedOut;
            }
        }

        public void Return()
        {
            Status = ItemStatus.Available;
        }

        public override string ToString()
        {
            string str = Book + "Status: " + Status + "\n";
            if (Status == ItemStatus.CheckedOut)
            {
                str += "Emprestado para: "
                       + Client.Name 
                       + " (" + Client.Email + ")\n"
                       + "Data prevista de devolução: " + DueDate + "\n";
            }
            else if (Status == ItemStatus.InUse)
            {
                str += "Em uso na biblioteca sob a resposabilidade de: "
                       + Client.Name
                       + " (" + Client.Email + ")\n";
            }

            return str;
        }
    }
}
