using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ImportDto
{
    [XmlType("Client")]
    public class ImportClientDto
    {
        [Required]
        [MaxLength(25)]
        [MinLength(10)]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(10)]
        public string NumberVat { get; set; }

        [XmlArray("Addresses")]
        public ImportAddressDto[] Addresses { get; set; }
    }
}

//•	Name – text with length [10…25] (required)
//•	NumberVat – text with length [10…15] (required)



//// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
///// <remarks/>
//[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
//public partial class Clients
//{

//    private ClientsClient[] clientField;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("Client")]
//    public ClientsClient[] Client
//    {
//        get
//        {
//            return this.clientField;
//        }
//        set
//        {
//            this.clientField = value;
//        }
//    }
//}

///// <remarks/>
//[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ClientsClient
//{

//    private string nameField;

//    private string numberVatField;

//    private ClientsClientAddresses addressesField;

//    /// <remarks/>
//    public string Name
//    {
//        get
//        {
//            return this.nameField;
//        }
//        set
//        {
//            this.nameField = value;
//        }
//    }

//    /// <remarks/>
//    public string NumberVat
//    {
//        get
//        {
//            return this.numberVatField;
//        }
//        set
//        {
//            this.numberVatField = value;
//        }
//    }

//    /// <remarks/>
//    public ClientsClientAddresses Addresses
//    {
//        get
//        {
//            return this.addressesField;
//        }
//        set
//        {
//            this.addressesField = value;
//        }
//    }
//}

///// <remarks/>
//[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ClientsClientAddresses
//{

//    private ClientsClientAddressesAddress addressField;

//    /// <remarks/>
//    public ClientsClientAddressesAddress Address
//    {
//        get
//        {
//            return this.addressField;
//        }
//        set
//        {
//            this.addressField = value;
//        }
//    }
//}

///// <remarks/>
//[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ClientsClientAddressesAddress
//{

//    private string streetNameField;

//    private ushort streetNumberField;

//    private uint postCodeField;

//    private string cityField;

//    private string countryField;

//    /// <remarks/>
//    public string StreetName
//    {
//        get
//        {
//            return this.streetNameField;
//        }
//        set
//        {
//            this.streetNameField = value;
//        }
//    }

//    /// <remarks/>
//    public ushort StreetNumber
//    {
//        get
//        {
//            return this.streetNumberField;
//        }
//        set
//        {
//            this.streetNumberField = value;
//        }
//    }

//    /// <remarks/>
//    public uint PostCode
//    {
//        get
//        {
//            return this.postCodeField;
//        }
//        set
//        {
//            this.postCodeField = value;
//        }
//    }

//    /// <remarks/>
//    public string City
//    {
//        get
//        {
//            return this.cityField;
//        }
//        set
//        {
//            this.cityField = value;
//        }
//    }

//    /// <remarks/>
//    public string Country
//    {
//        get
//        {
//            return this.countryField;
//        }
//        set
//        {
//            this.countryField = value;
//        }
//    }
//}

