namespace Coding_Main.LLD.Solid.Single_Responsibilty_Principle
{
    internal class Marker
    {
        public string Name { get; set; }

        public string  Color { get; set; }

        public DateTime ManufacturingYear { get; set; }

        public int Price { get; set; }

        public Marker(string name, string color, DateTime yom, int price)
        {
            this.Name = name;
            this.Color = color;
            this.ManufacturingYear = yom;
            this.Price = price;
        }
    }

    // Single responsibility principle states that each class should have only one reason to change but this class is voilating

    internal class Invoice
    {
        public Marker Marker;
        public int Quantity;

        public Invoice(Marker marker, int quantity)
        {
            this.Marker = marker;
            this.Quantity = quantity;
        }


        // one reason to change if in future calculation logic changes 
        public int CalculateInvoice()
        {

            return this.Quantity * this.Marker.Price;
        }

        public void SaveInvoiceToDb()
        {
            //Second reason to change if in future saving logic changes
        }

        public void PrintInvoice()
        {
            // Third reason to change if in future print logic changes
        }
    }


    // Now we can clearly say that every class will have only one reason to change 

    internal class CalculateInvoice
    {

    }

    internal class InvoiceRepository
    {

    }

    internal class PrintInvoice
    {

    }
}
