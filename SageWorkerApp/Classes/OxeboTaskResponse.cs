using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageWorkerApp.Classes
{
    public class OxeboTaskResponse
    {
        public int id { get; set; }
        public string uid { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public Metas metas { get; set; }
        public Properties properties { get; set; }
        public string code { get; set; }
        public Type type { get; set; }
        public Priority priority { get; set; }
        public DateTime rv { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public CurrentState currentState { get; set; }
        public EndState endState { get; set; }
        public Client client { get; set; }
        public ClientAddress clientAddress { get; set; }
        public Location location { get; set; }
        public LocationAddress locationAddress { get; set; }
        public List<object> helpers { get; set; }
        public TaxConfig taxConfig { get; set; }
        public string duration { get; set; }
        public string signatureText { get; set; }
        public List<object> attachments { get; set; }
        public PriceList priceList { get; set; }
        public string lang { get; set; }
        public List<object> equipments { get; set; }
        public CreatorUser creatorUser { get; set; }
        public ItemList itemList { get; set; }
    }

    public class Client
    {
        public int id { get; set; }
        public string uid { get; set; }
        public string label { get; set; }
    }

    public class ClientAddress
    {
        public string address { get; set; }
        public string app { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
    }

    public class CreatorUser
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class CurrentState
    {
        public int id { get; set; }
        public string label { get; set; }
        public int logicId { get; set; }
        public DateTime datetime { get; set; }
        public Task task { get; set; }
        public User user { get; set; }
        public HumanResource humanResource { get; set; }
    }

    public class EndState
    {
        public int id { get; set; }
        public string label { get; set; }
        public int logicId { get; set; }
        public DateTime datetime { get; set; }
        public Task task { get; set; }
        public User user { get; set; }
        public HumanResource humanResource { get; set; }
    }

    public class HumanResource
    {
        public int id { get; set; }
        public string uid { get; set; }
        public string label { get; set; }
    }

    public class Location
    {
        public int id { get; set; }
        public string uid { get; set; }
        public string label { get; set; }
    }

    public class LocationAddress
    {
        public string address { get; set; }
        public string app { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public Position position { get; set; }
    }

    public class Metas
    {
        [JsonProperty("email.messageID")]
        public string emailmessageID { get; set; }
    }

    public class Position
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public string uid { get; set; }
        public string label { get; set; }
        public double quantity { get; set; }
        public double quantityConfirmed { get; set; }
        public double price { get; set; }
        public double rebate { get; set; }
        public double total { get; set; }
        public bool taxable { get; set; }
        public Properties properties { get; set; }
        public Type type { get; set; }
        public Product product { get; set; }
        public DateTime? updated { get; set; }
    }

    public class Tax
    {
        public int id { get; set; }
        public string label { get; set; }
        public double percent { get; set; }
        public bool taxable { get; set; }
    }

    public class TaxTotal
    {
        public int id { get; set; }
        public Tax tax { get; set; }
        public double amount { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string uid { get; set; }
        public string label { get; set; }
    }

    public class ItemList
    {
        public int id { get; set; }
        public string uid { get; set; }
        public double subTotal { get; set; }
        public List<TaxTotal> taxTotals { get; set; }
        public double total { get; set; }
        public bool marginValid { get; set; }
        public List<Item> items { get; set; }
        public double? amountDue { get; set; }
    }
    public class PriceList
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class Priority
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class Properties
    {

        [JsonProperty("copie_bon_travail.courriel")]
        public string copie_bon_travailcourriel { get; set; }

        [JsonProperty("travaux_effectues.competence_requise")]
        public string travaux_effectuescompetence_requise { get; set; }

        [JsonProperty("details_probleme.manufacturier")]
        public string details_problememanufacturier { get; set; }

        [JsonProperty("informations_generales.plage_horaire_to")]
        public string informations_generalesplage_horaire_to { get; set; }

        [JsonProperty("travaux_effectues.type_travail.id")]
        public string travaux_effectuestype_travailid { get; set; }

        [JsonProperty("SERIAVAL.SERIALVAL")]
        public string SERIAVALSERIALVAL { get; set; }

        [JsonProperty("historique.detail_travaux")]
        public string historiquedetail_travaux { get; set; }

        [JsonProperty("notification.phone")]
        public string notificationphone { get; set; }

        [JsonProperty("historique.no_appel")]
        public string historiqueno_appel { get; set; }

        [JsonProperty("details_probleme.no_serie")]
        public string details_problemeno_serie { get; set; }

        [JsonProperty("informations_generales.rapporte_par")]
        public string informations_generalesrapporte_par { get; set; }

        [JsonProperty("informations_generales.RTAT")]
        public string informations_generalesRTAT { get; set; }

        [JsonProperty("details_probleme.description_probleme")]
        public string details_problemedescription_probleme { get; set; }

        [JsonProperty("notification.Contact")]
        public string notificationContact { get; set; }

        [JsonProperty("informations_generales.zone")]
        public string informations_generaleszone { get; set; }

        [JsonProperty("informations_generales.contact_sur_place")]
        public string informations_generalescontact_sur_place { get; set; }

        [JsonProperty("informations_generales.nb_visite")]
        public string informations_generalesnb_visite { get; set; }

        [JsonProperty("notification.phone2")]
        public string notificationphone2 { get; set; }

        [JsonProperty("informations_generales.plage_horaire_from")]
        public string informations_generalesplage_horaire_from { get; set; }

        [JsonProperty("informations_generales.numero_contact")]
        public string informations_generalesnumero_contact { get; set; }

        [JsonProperty("travaux_effectues.resource_requise")]
        public string travaux_effectuesresource_requise { get; set; }

        [JsonProperty("travaux_effectues.type_travail")]
        public string travaux_effectuestype_travail { get; set; }

        [JsonProperty("informations_generales.bon_commande")]
        public string informations_generalesbon_commande { get; set; }

        [JsonProperty("historique.active")]
        public string historiqueactive { get; set; }

        [JsonProperty("details_probleme.date_achat")]
        public string details_problemedate_achat { get; set; }

        [JsonProperty("notespeciale.note_")]
        public string notespecialenote_ { get; set; }

        [JsonProperty("informations_generales.date_reporte")]
        public string informations_generalesdate_reporte { get; set; }

        [JsonProperty("historique.rh")]
        public string historiquerh { get; set; }

        [JsonProperty("details_probleme.modele")]
        public string details_problememodele { get; set; }

        [JsonProperty("details_probleme.type_appareil")]
        public string details_problemetype_appareil { get; set; }

        [JsonProperty("copie_bon_travail.daterappel")]
        public string copie_bon_travaildaterappel { get; set; }

        [JsonProperty("notification.Email")]
        public string notificationEmail { get; set; }

        [JsonProperty("informations_generales.zone.id")]
        public string informations_generaleszoneid { get; set; }

        [JsonProperty("travaux_effectues.etat_travaux")]
        public string travaux_effectuesetat_travaux { get; set; }

        [JsonProperty("travaux_effectues.detail_travaux")]
        public string travaux_effectuesdetail_travaux { get; set; }
    }

    public class Task
    {
        public int id { get; set; }
        public string uid { get; set; }
        public string label { get; set; }
    }

    public class TaxConfig
    {
        public int id { get; set; }
        public string label { get; set; }
        public bool defaultConfig { get; set; }
        public bool exception { get; set; }
    }

    public class Type
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string label { get; set; }
    }
}

