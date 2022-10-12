﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Newspaper : PrintedEdition
    {
        public string name { get; set; }
        public int number { get; set; }
        public string date_release { get; set; }


        public Newspaper(string type,
            string isbn,
            string address_edition,
            string name_editor,
            string last_name_editor,
            string surname_editor,
            string address_editor,
            int circulation,
            int publication_frequency,
            string site_address,
            string name,
            int number,
            string data_release) : base(type, isbn, address_edition, name_editor, last_name_editor,
                surname_editor, address_editor, circulation, publication_frequency, site_address)
        {
            this.name = name;
            this.number = number;
            this.date_release = data_release;

        }
        public void PrintNewspaper()
        {
            base.Print();
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"number: {number}");
            Console.WriteLine($"date_release: {date_release}");
        }
    }
}
