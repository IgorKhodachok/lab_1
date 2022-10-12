using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class PrintedEdition
    {
        private string type { get; set; }
        private string isbn { get; set; }
        private string address_edition { get; set; }
        private string name_editor { get; set; }
        private string last_name_editor { get; set; }
        private string surname_editor { get; set; }
        private string address_editor { get; set; }
        private int circulation { get; set; }
        private int publication_frequency { get; set; }
        private string site_address { get; set; }
        //
        public PrintedEdition(string type,
            string isbn,
            string address_edition,
            string name_editor,
            string last_name_editor,
            string surname_editor,
            string address_editor,
            int circulation,
            int publication_frequency,
            string site_address)
        {
            this.type = type;
            this.isbn = isbn;
            this.address_edition = address_edition;
            this.name_editor = name_editor;
            this.last_name_editor = last_name_editor;
            this.surname_editor = surname_editor;
            this.address_editor = address_editor;
            this.circulation = circulation;
            this.publication_frequency = publication_frequency;
            this.site_address = site_address;
        }

        public void Print()
        {
            Console.WriteLine($"isbn: {isbn}");
            Console.WriteLine($"address_edition: {address_edition}");
            Console.WriteLine($"name_editor: {name_editor}");
            Console.WriteLine($"last_name_editor: {last_name_editor}");
            Console.WriteLine($"surname_editor: {surname_editor}");
            Console.WriteLine($"address_editor: {address_editor}");
            Console.WriteLine($"circulation: {circulation}");
            Console.WriteLine($"publication_frequency: {publication_frequency}");
            Console.WriteLine($"site_address: {site_address}");

        }
    }
}
