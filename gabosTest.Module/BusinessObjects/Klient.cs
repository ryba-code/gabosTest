using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Utils.About;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gabosTest.Module.BusinessObjects
{
    //[NavigationItem("Klienci")]
    [DefaultClassOptions]
    public class Klient : BaseObject
    {
        public Klient(Session session) : base(session) { }

        private string _nip;
        private string _regon;
        private string _krs;
        private string _nazwa;
        private string _telefon;
        private string _email;
        private string _ulica;
        private string _kodPocztowy;
        private string _miasto;
        private DateTime _DataRejestracji;
        private DateTime _DataOdmowyRejestracji;      

        public string NIP
        {
            get { return _nip; }
            set { SetPropertyValue(nameof(NIP), ref _nip, value); }
        }

        public string REGON
        {
            get { return _regon; }
            set { SetPropertyValue(nameof(REGON), ref _regon, value); }
        }

        public string KRS
        {
            get { return _krs; }
            set { SetPropertyValue(nameof(KRS), ref _krs, value); }
        }

        public string Nazwa
        {
            get { return _nazwa; }
            set { SetPropertyValue(nameof(Nazwa), ref _nazwa, value); }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { SetPropertyValue(nameof(Telefon), ref _telefon, value); }
        }

        public string Email
        {
            get { return _email; }
            set { SetPropertyValue(nameof(Email), ref _email, value); }
        }

        public string Ulica
        {
            get { return _ulica; }
            set { SetPropertyValue(nameof(Ulica), ref _ulica, value); }
        }

        public string KodPocztowy
        {
            get { return _kodPocztowy; }
            set { SetPropertyValue(nameof(KodPocztowy), ref _kodPocztowy, value); }
        }

        public string Miasto
        {
            get { return _miasto; }
            set { SetPropertyValue(nameof(Miasto), ref _miasto, value); }
        }
        
        public DateTime DataRejestracji
        {
            get { return _DataRejestracji; }
            set { SetPropertyValue(nameof(DataRejestracji), ref _DataRejestracji, value); }
        }

        public DateTime DataOdmowyRejestracji
        {
            get { return _DataOdmowyRejestracji; }
            set { SetPropertyValue(nameof(DataOdmowyRejestracji), ref _DataOdmowyRejestracji, value); }
        }

        [Association("Klient-KontaBankowe")]
        public XPCollection<KontoBankowe> KontaBankowe
        {
            get
            {
                return GetCollection<KontoBankowe>(nameof(KontaBankowe));
            }
        }
    }

    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Numer))]
    public class KontoBankowe : BaseObject
    {
        public KontoBankowe(Session session) : base(session) { }
        private string _numer;

        public string Numer
        {
            get { return _numer; }
            set { SetPropertyValue(nameof(Numer), ref _numer, value); }
        }

        private Klient _klient;
        [Association("Klient-KontaBankowe")]
        public Klient Klient
        {
            get { return _klient; }
            set { SetPropertyValue(nameof(Klient), ref _klient, value); }
        }
    }
}
