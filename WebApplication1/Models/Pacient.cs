using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pacient
    {
        public Pacient(data_pacient d)
        {
            id = d.id;
            login = d.login;
            password = d.password;
             name = d.name;
            family = d.family;
            patronymic = d.patronymic;
            bithdate = d.bithdate;
            seriya = d.seriya;
            nomer = d.nomer;
            phone = d.phone;
            email = d.email;
        }

        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string patronymic { get; set; }
        public Nullable<System.DateTime> bithdate { get; set; }
        public Nullable<long> seriya { get; set; }
        public Nullable<long> nomer { get; set; }
        public Nullable<long> phone { get; set; }
        public string email { get; set; }
    }
}