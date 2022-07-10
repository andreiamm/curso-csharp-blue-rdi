using System.Globalization;

namespace exercicio03
{
    internal class Invoice
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public int InvoiceNumber { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityBought { get; set; }
        public double ProductPrice { get; set; }

        public Invoice(int invoiceNumber, string productDescription, int quantityBought, double productPrice)
        {
            InvoiceNumber = invoiceNumber;
            ProductDescription = productDescription;
            QuantityBought = quantityBought;
            ProductPrice = productPrice;
        }

        public double TotalValue()
        {
            return QuantityBought * ProductPrice;
        }

        public override string ToString()
        {
            return "Fatura #" + InvoiceNumber + "\n"
                   + "Produto: " + ProductDescription + "\n"
                   + "Quantidade: " + QuantityBought + "\n"
                   + "Preço unitário: R$ " + ProductPrice.ToString("F2", CI);
        }
    }
}