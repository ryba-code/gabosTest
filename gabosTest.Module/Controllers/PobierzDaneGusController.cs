using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using gabosTest.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gabosTest.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PobierzDaneGusController : ViewController
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public PobierzDaneGusController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            TargetViewType = ViewType.DetailView;
            TargetObjectType = typeof(Klient);

            SimpleAction clearTasksAction = new SimpleAction(this, "PobierzDaneGus", PredefinedCategory.View)
            {                
                Caption = "Pobierz dane z GUS"             
            };

            clearTasksAction.Execute += PobierzDaneGus_Execute;
        }

        private async void PobierzDaneGus_Execute(Object sender, SimpleActionExecuteEventArgs e)
        {
            if (((Klient)View.CurrentObject).NIP != "")
            {
                var httpClient = new HttpClient();
                string baseUrl = "https://wl-api.mf.gov.pl/";

                PolaczenieApi PA = new PolaczenieApi(baseUrl, httpClient);
                PA.ReadResponseAsString = true;

                var result = await PA.PolaczRestApiAsync(((Klient)View.CurrentObject).NIP);

                ((Klient)View.CurrentObject).NIP = "";
                ((Klient)View.CurrentObject).REGON = "";
                ((Klient)View.CurrentObject).KRS = "";
                ((Klient)View.CurrentObject).Nazwa = "";
                ((Klient)View.CurrentObject).Ulica = "";
                ((Klient)View.CurrentObject).KodPocztowy = "";
                ((Klient)View.CurrentObject).Miasto = "";
                ((Klient)View.CurrentObject).DataRejestracji = DateTime.Now;
                ((Klient)View.CurrentObject).DataOdmowyRejestracji = DateTime.Now;

                while (((Klient)View.CurrentObject).KontaBankowe.Count > 0)
                {
                    ((Klient)View.CurrentObject).KontaBankowe.Remove(((Klient)View.CurrentObject).KontaBankowe[0]);
                }

                if (result == null)
                {
                    ((Klient)View.CurrentObject).NIP = "Niepoprawny numer NIP - brak danych!";
                    return;
                }

                if (result.Result.Subject == null)
                {
                    ((Klient)View.CurrentObject).NIP = "Brak danych!";
                    return;
                }
                    
                ((Klient)View.CurrentObject).NIP = result.Result.Subject.Nip;
                ((Klient)View.CurrentObject).REGON = result.Result.Subject.Regon;
                ((Klient)View.CurrentObject).KRS = result.Result.Subject.Krs;
                ((Klient)View.CurrentObject).Nazwa = result.Result.Subject.Name;  
                ((Klient)View.CurrentObject).Ulica = result.Result.Subject.WorkingAddress.Split(", ")[0];  
                ((Klient)View.CurrentObject).KodPocztowy = result.Result.Subject.WorkingAddress.Split(", ")[1].Split(' ')[0];  
                ((Klient)View.CurrentObject).Miasto = result.Result.Subject.WorkingAddress.Split(", ")[1].Split(' ')[1];
                ((Klient)View.CurrentObject).DataRejestracji = result.Result.Subject.RegistrationLegalDate.Date;
                ((Klient)View.CurrentObject).DataOdmowyRejestracji = result.Result.Subject.RegistrationDenialDate.Date;
                
                foreach (string accounts in result.Result.Subject.AccountNumbers)
                {
                    KontoBankowe KB = new KontoBankowe(((Klient)View.CurrentObject).Session);
                    KB.Numer = accounts;
                    KB.Klient = (Klient)View.CurrentObject;
                }            
            }           
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
