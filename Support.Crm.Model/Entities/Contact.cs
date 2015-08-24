using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Runtime.Serialization;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Metadata;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Лицо, с которым подразделение имеет отношение. Например, клиент, поставщик или коллега.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("contact")]
    [GeneratedCode("CrmSvcUtil", "5.0.9690.3739")]
    [DataServiceKey("Id")]
    [IgnoreProperties("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Entity("ContactSet")]
    public class Contact : CrmEntity
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Contact() : base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contact";
		
        public const int EntityTypeCode = 2;
		
        /// <summary>
        /// Уникальный идентификатор организации, с которой связан контакт.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public CrmEntityReference AccountId
        {
            get
            {
                return GetAttributeValue<EntityReference>("accountid");
            }
        }
		
        /// <summary>
        /// Роль контакта в организации.
        /// </summary>
        [AttributeLogicalName("accountrolecode")]
        public int? AccountRoleCode
        {
            get
            {
                return GetAttributeValue<int?>("accountrolecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("AccountRoleCode", "accountrolecode", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for address 1. 
        /// </summary>
        [AttributeLogicalName("address1_addressid")]
        public Guid? Address1_AddressId
        {
            get
            {
                return GetAttributeValue<Guid?>("address1_addressid");
            }
            set
            {
                SetAttributeValue<Guid?>("Address1_AddressId", "address1_addressid", value);
            }
        }
		
        /// <summary>
        /// Тип адреса для адреса 1 (например, адрес для выставления счетов, адрес поставки или основной адрес).
        /// </summary>
        [AttributeLogicalName("address1_addresstypecode")]
        public int? Address1_AddressTypeCode
        {
            get
            {
                return GetAttributeValue<int?>("address1_addresstypecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("Address1_AddressTypeCode", "address1_addresstypecode", value);
            }
        }
		
        /// <summary>
        /// Город для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_city")]
        public string Address1_City
        {
            get
            {
                return GetAttributeValue<string>("address1_city");
            }
            set
            {
                SetAttributeValue<string>("Address1_City", "address1_city", value);
            }
        }
		
        /// <summary>
        /// Страна или регион для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_country")]
        public string Address1_Country
        {
            get
            {
                return GetAttributeValue<string>("address1_country");
            }
            set
            {
                SetAttributeValue<string>("Address1_Country", "address1_country", value);
            }
        }
		
        /// <summary>
        /// Округ для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_county")]
        public string Address1_County
        {
            get
            {
                return GetAttributeValue<string>("address1_county");
            }
            set
            {
                SetAttributeValue<string>("Address1_County", "address1_county", value);
            }
        }
		
        /// <summary>
        /// Номер факса для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_fax")]
        public string Address1_Fax
        {
            get
            {
                return GetAttributeValue<string>("address1_fax");
            }
            set
            {
                SetAttributeValue<string>("Address1_Fax", "address1_fax", value);
            }
        }
		
        /// <summary>
        /// Условия поставки для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_freighttermscode")]
        public int? Address1_FreightTermsCode
        {
            get
            {
                return GetAttributeValue<int?>("address1_freighttermscode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("Address1_FreightTermsCode", "address1_freighttermscode", value);
            }
        }
		
        /// <summary>
        /// Широта для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_latitude")]
        public double? Address1_Latitude
        {
            get
            {
                return GetAttributeValue<double?>("address1_latitude");
            }
            set
            {
                SetAttributeValue<double?>("Address1_Latitude", "address1_latitude", value);
            }
        }
		
        /// <summary>
        /// First line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line1")]
        public string Address1_Line1
        {
            get
            {
                return GetAttributeValue<string>("address1_line1");
            }
            set
            {
                SetAttributeValue<string>("Address1_Line1", "address1_line1", value);
            }
        }
		
        /// <summary>
        /// Second line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line2")]
        public string Address1_Line2
        {
            get
            {
                return GetAttributeValue<string>("address1_line2");
            }
            set
            {
                SetAttributeValue<string>("Address1_Line2", "address1_line2", value);
            }
        }
		
        /// <summary>
        /// Third line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line3")]
        public string Address1_Line3
        {
            get
            {
                return GetAttributeValue<string>("address1_line3");
            }
            set
            {
                SetAttributeValue<string>("Address1_Line3", "address1_line3", value);
            }
        }
		
        /// <summary>
        /// Долгота для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_longitude")]
        public double? Address1_Longitude
        {
            get
            {
                return GetAttributeValue<double?>("address1_longitude");
            }
            set
            {
                SetAttributeValue<double?>("Address1_Longitude", "address1_longitude", value);
            }
        }
		
        /// <summary>
        /// Название, указываемое в адресе 1.
        /// </summary>
        [AttributeLogicalName("address1_name")]
        public string Address1_Name
        {
            get
            {
                return GetAttributeValue<string>("address1_name");
            }
            set
            {
                SetAttributeValue<string>("Address1_Name", "address1_name", value);
            }
        }
		
        /// <summary>
        /// Почтовый индекс для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_postalcode")]
        public string Address1_PostalCode
        {
            get
            {
                return GetAttributeValue<string>("address1_postalcode");
            }
            set
            {
                SetAttributeValue<string>("Address1_PostalCode", "address1_postalcode", value);
            }
        }
		
        /// <summary>
        /// Номер абонентского ящика для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get
            {
                return GetAttributeValue<string>("address1_postofficebox");
            }
            set
            {
                SetAttributeValue<string>("Address1_PostOfficeBox", "address1_postofficebox", value);
            }
        }
		
        /// <summary>
        /// Имя основного контакта для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_primarycontactname")]
        public string Address1_PrimaryContactName
        {
            get
            {
                return GetAttributeValue<string>("address1_primarycontactname");
            }
            set
            {
                SetAttributeValue<string>("Address1_PrimaryContactName", "address1_primarycontactname", value);
            }
        }
		
        /// <summary>
        /// Способ поставки для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_shippingmethodcode")]
        public int? Address1_ShippingMethodCode
        {
            get
            {
                return GetAttributeValue<int?>("address1_shippingmethodcode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("Address1_ShippingMethodCode", "address1_shippingmethodcode", value);
            }
        }
		
        /// <summary>
        /// Область, республика, край, округ для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get
            {
                return GetAttributeValue<string>("address1_stateorprovince");
            }
            set
            {
                SetAttributeValue<string>("Address1_StateOrProvince", "address1_stateorprovince", value);
            }
        }
		
        /// <summary>
        /// Первый номер телефона, связанный с адресом 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone1")]
        public string Address1_Telephone1
        {
            get
            {
                return GetAttributeValue<string>("address1_telephone1");
            }
            set
            {
                SetAttributeValue<string>("Address1_Telephone1", "address1_telephone1", value);
            }
        }
		
        /// <summary>
        /// Второй номер телефона, связанный с адресом 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone2")]
        public string Address1_Telephone2
        {
            get
            {
                return GetAttributeValue<string>("address1_telephone2");
            }
            set
            {
                SetAttributeValue<string>("Address1_Telephone2", "address1_telephone2", value);
            }
        }
		
        /// <summary>
        /// Третий номер телефона, связанный с адресом 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone3")]
        public string Address1_Telephone3
        {
            get
            {
                return GetAttributeValue<string>("address1_telephone3");
            }
            set
            {
                SetAttributeValue<string>("Address1_Telephone3", "address1_telephone3", value);
            }
        }
		
        /// <summary>
        /// Зона службы доставки UPS для адреса 1.
        /// </summary>
        [AttributeLogicalName("address1_upszone")]
        public string Address1_UPSZone
        {
            get
            {
                return GetAttributeValue<string>("address1_upszone");
            }
            set
            {
                SetAttributeValue<string>("Address1_UPSZone", "address1_upszone", value);
            }
        }
		
        /// <summary>
        /// Часовой пояс для адреса 1. Это разница между местным временем и временем в формате UTC.
        /// </summary>
        [AttributeLogicalName("address1_utcoffset")]
        public int? Address1_UTCOffset
        {
            get
            {
                return GetAttributeValue<int?>("address1_utcoffset");
            }
            set
            {
                SetAttributeValue<int?>("Address1_UTCOffset", "address1_utcoffset", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for address 2. 
        /// </summary>
        [AttributeLogicalName("address2_addressid")]
        public Guid? Address2_AddressId
        {
            get
            {
                return GetAttributeValue<Guid?>("address2_addressid");
            }
            set
            {
                SetAttributeValue<Guid?>("Address2_AddressId", "address2_addressid", value);
            }
        }
		
        /// <summary>
        /// Type of address for address 2, such as billing, shipping, or primary address. 
        /// </summary>
        [AttributeLogicalName("address2_addresstypecode")]
        public int? Address2_AddressTypeCode
        {
            get
            {
                return GetAttributeValue<int?>("address2_addresstypecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("Address2_AddressTypeCode", "address2_addresstypecode", value);
            }
        }
		
        /// <summary>
        /// Город для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_city")]
        public string Address2_City
        {
            get
            {
                return GetAttributeValue<string>("address2_city");
            }
            set
            {
                SetAttributeValue<string>("Address2_City", "address2_city", value);
            }
        }
		
        /// <summary>
        /// Страна или регион для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_country")]
        public string Address2_Country
        {
            get
            {
                return GetAttributeValue<string>("address2_country");
            }
            set
            {
                SetAttributeValue<string>("Address2_Country", "address2_country", value);
            }
        }
		
        /// <summary>
        /// Округ для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_county")]
        public string Address2_County
        {
            get
            {
                return GetAttributeValue<string>("address2_county");
            }
            set
            {
                SetAttributeValue<string>("Address2_County", "address2_county", value);
            }
        }
		
        /// <summary>
        /// Номер факса для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_fax")]
        public string Address2_Fax
        {
            get
            {
                return GetAttributeValue<string>("address2_fax");
            }
            set
            {
                SetAttributeValue<string>("Address2_Fax", "address2_fax", value);
            }
        }
		
        /// <summary>
        /// Условия поставки для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_freighttermscode")]
        public int? Address2_FreightTermsCode
        {
            get
            {
                return GetAttributeValue<int?>("address2_freighttermscode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("Address2_FreightTermsCode", "address2_freighttermscode", value);
            }
        }
		
        /// <summary>
        /// Широта для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_latitude")]
        public double? Address2_Latitude
        {
            get
            {
                return GetAttributeValue<double?>("address2_latitude");
            }
            set
            {
                SetAttributeValue<double?>("Address2_Latitude", "address2_latitude", value);
            }
        }
		
        /// <summary>
        /// Первая строка для ввода сведений об адресе 2.
        /// </summary>
        [AttributeLogicalName("address2_line1")]
        public string Address2_Line1
        {
            get
            {
                return GetAttributeValue<string>("address2_line1");
            }
            set
            {
                SetAttributeValue<string>("Address2_Line1", "address2_line1", value);
            }
        }
		
        /// <summary>
        /// Вторая строка для ввода сведений об адресе 2.
        /// </summary>
        [AttributeLogicalName("address2_line2")]
        public string Address2_Line2
        {
            get
            {
                return GetAttributeValue<string>("address2_line2");
            }
            set
            {
                SetAttributeValue<string>("Address2_Line2", "address2_line2", value);
            }
        }
		
        /// <summary>
        /// Третья строка для ввода сведений об адресе 2.
        /// </summary>
        [AttributeLogicalName("address2_line3")]
        public string Address2_Line3
        {
            get
            {
                return GetAttributeValue<string>("address2_line3");
            }
            set
            {
                SetAttributeValue<string>("Address2_Line3", "address2_line3", value);
            }
        }
		
        /// <summary>
        /// Долгота для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_longitude")]
        public double? Address2_Longitude
        {
            get
            {
                return GetAttributeValue<double?>("address2_longitude");
            }
            set
            {
                SetAttributeValue<double?>("Address2_Longitude", "address2_longitude", value);
            }
        }
		
        /// <summary>
        /// Название, указываемое в адресе 2.
        /// </summary>
        [AttributeLogicalName("address2_name")]
        public string Address2_Name
        {
            get
            {
                return GetAttributeValue<string>("address2_name");
            }
            set
            {
                SetAttributeValue<string>("Address2_Name", "address2_name", value);
            }
        }
		
        /// <summary>
        /// Почтовый индекс для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_postalcode")]
        public string Address2_PostalCode
        {
            get
            {
                return GetAttributeValue<string>("address2_postalcode");
            }
            set
            {
                SetAttributeValue<string>("Address2_PostalCode", "address2_postalcode", value);
            }
        }
		
        /// <summary>
        /// Номер абонентского ящика для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get
            {
                return GetAttributeValue<string>("address2_postofficebox");
            }
            set
            {
                SetAttributeValue<string>("Address2_PostOfficeBox", "address2_postofficebox", value);
            }
        }
		
        /// <summary>
        /// Имя основного контакта для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_primarycontactname")]
        public string Address2_PrimaryContactName
        {
            get
            {
                return GetAttributeValue<string>("address2_primarycontactname");
            }
            set
            {
                SetAttributeValue<string>("Address2_PrimaryContactName", "address2_primarycontactname", value);
            }
        }
		
        /// <summary>
        /// Способ поставки для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_shippingmethodcode")]
        public int? Address2_ShippingMethodCode
        {
            get
            {
                return GetAttributeValue<int?>("address2_shippingmethodcode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("Address2_ShippingMethodCode", "address2_shippingmethodcode", value);
            }
        }
		
        /// <summary>
        /// Область, республика, край, округ для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get
            {
                return GetAttributeValue<string>("address2_stateorprovince");
            }
            set
            {
                SetAttributeValue<string>("Address2_StateOrProvince", "address2_stateorprovince", value);
            }
        }
		
        /// <summary>
        /// Первый номер телефона, связанный с адресом 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone1")]
        public string Address2_Telephone1
        {
            get
            {
                return GetAttributeValue<string>("address2_telephone1");
            }
            set
            {
                SetAttributeValue<string>("Address2_Telephone1", "address2_telephone1", value);
            }
        }
		
        /// <summary>
        /// Второй номер телефона, связанный с адресом 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone2")]
        public string Address2_Telephone2
        {
            get
            {
                return GetAttributeValue<string>("address2_telephone2");
            }
            set
            {
                SetAttributeValue<string>("Address2_Telephone2", "address2_telephone2", value);
            }
        }
		
        /// <summary>
        /// Третий номер телефона, связанный с адресом 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone3")]
        public string Address2_Telephone3
        {
            get
            {
                return GetAttributeValue<string>("address2_telephone3");
            }
            set
            {
                SetAttributeValue<string>("Address2_Telephone3", "address2_telephone3", value);
            }
        }
		
        /// <summary>
        /// Зона службы доставки UPS для адреса 2.
        /// </summary>
        [AttributeLogicalName("address2_upszone")]
        public string Address2_UPSZone
        {
            get
            {
                return GetAttributeValue<string>("address2_upszone");
            }
            set
            {
                SetAttributeValue<string>("Address2_UPSZone", "address2_upszone", value);
            }
        }
		
        /// <summary>
        /// Часовой пояс для адреса 2. Это разница между местным временем и временем в формате UTC.
        /// </summary>
        [AttributeLogicalName("address2_utcoffset")]
        public int? Address2_UTCOffset
        {
            get
            {
                return GetAttributeValue<int?>("address2_utcoffset");
            }
            set
            {
                SetAttributeValue<int?>("Address2_UTCOffset", "address2_utcoffset", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_changepasswordatnextlogon")]
        public bool? Adx_changepasswordatnextlogon
        {
            get
            {
                return GetAttributeValue<bool?>("adx_changepasswordatnextlogon");
            }
            set
            {
                SetAttributeValue<bool?>("Adx_changepasswordatnextlogon", "adx_changepasswordatnextlogon", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_createdbyipaddress")]
        public string Adx_CreatedByIPAddress
        {
            get
            {
                return GetAttributeValue<string>("adx_createdbyipaddress");
            }
            set
            {
                SetAttributeValue<string>("Adx_CreatedByIPAddress", "adx_createdbyipaddress", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_createdbyusername")]
        public string Adx_CreatedByUsername
        {
            get
            {
                return GetAttributeValue<string>("adx_createdbyusername");
            }
            set
            {
                SetAttributeValue<string>("Adx_CreatedByUsername", "adx_createdbyusername", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_failedpasswordanswerattempts")]
        public int? Adx_failedpasswordanswerattempts
        {
            get
            {
                return GetAttributeValue<int?>("adx_failedpasswordanswerattempts");
            }
            set
            {
                SetAttributeValue<int?>("Adx_failedpasswordanswerattempts", "adx_failedpasswordanswerattempts", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_failedpasswordanswerattemptwindowstart")]
        public DateTime? Adx_failedpasswordanswerattemptwindowstart
        {
            get
            {
                return GetAttributeValue<DateTime?>("adx_failedpasswordanswerattemptwindowstart");
            }
            set
            {
                SetAttributeValue<DateTime?>("Adx_failedpasswordanswerattemptwindowstart", "adx_failedpasswordanswerattemptwindowstart", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_failedpasswordattempts")]
        public int? Adx_failedpasswordattempts
        {
            get
            {
                return GetAttributeValue<int?>("adx_failedpasswordattempts");
            }
            set
            {
                SetAttributeValue<int?>("Adx_failedpasswordattempts", "adx_failedpasswordattempts", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_failedpasswordattemptwindowstart")]
        public DateTime? Adx_failedpasswordattemptwindowstart
        {
            get
            {
                return GetAttributeValue<DateTime?>("adx_failedpasswordattemptwindowstart");
            }
            set
            {
                SetAttributeValue<DateTime?>("Adx_failedpasswordattemptwindowstart", "adx_failedpasswordattemptwindowstart", value);
            }
        }
		
        /// <summary>
        /// Identifies the identity provider of the web authenticated user
        /// </summary>
        [AttributeLogicalName("adx_identityprovidername")]
        public string adx_identityprovidername
        {
            get
            {
                return GetAttributeValue<string>("adx_identityprovidername");
            }
            set
            {
                SetAttributeValue<string>("adx_identityprovidername", "adx_identityprovidername", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_invitationcode")]
        public string Adx_InvitationCode
        {
            get
            {
                return GetAttributeValue<string>("adx_invitationcode");
            }
            set
            {
                SetAttributeValue<string>("Adx_InvitationCode", "adx_invitationcode", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_invitationcodeexpirydate")]
        public DateTime? Adx_InvitationCodeExpiryDate
        {
            get
            {
                return GetAttributeValue<DateTime?>("adx_invitationcodeexpirydate");
            }
            set
            {
                SetAttributeValue<DateTime?>("Adx_InvitationCodeExpiryDate", "adx_invitationcodeexpirydate", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_lastactivity")]
        public DateTime? Adx_lastactivity
        {
            get
            {
                return GetAttributeValue<DateTime?>("adx_lastactivity");
            }
            set
            {
                SetAttributeValue<DateTime?>("Adx_lastactivity", "adx_lastactivity", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_lastlockedout")]
        public DateTime? Adx_lastlockedout
        {
            get
            {
                return GetAttributeValue<DateTime?>("adx_lastlockedout");
            }
            set
            {
                SetAttributeValue<DateTime?>("Adx_lastlockedout", "adx_lastlockedout", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_lastpasswordchange")]
        public DateTime? Adx_lastpasswordchange
        {
            get
            {
                return GetAttributeValue<DateTime?>("adx_lastpasswordchange");
            }
            set
            {
                SetAttributeValue<DateTime?>("Adx_lastpasswordchange", "adx_lastpasswordchange", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_lastsuccessfullogon")]
        public DateTime? Adx_LastSuccessfulLogon
        {
            get
            {
                return GetAttributeValue<DateTime?>("adx_lastsuccessfullogon");
            }
            set
            {
                SetAttributeValue<DateTime?>("Adx_LastSuccessfulLogon", "adx_lastsuccessfullogon", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_lockedout")]
        public bool? Adx_lockedout
        {
            get
            {
                return GetAttributeValue<bool?>("adx_lockedout");
            }
            set
            {
                SetAttributeValue<bool?>("Adx_lockedout", "adx_lockedout", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_logonenabled")]
        public bool? Adx_LogonEnabled
        {
            get
            {
                return GetAttributeValue<bool?>("adx_logonenabled");
            }
            set
            {
                SetAttributeValue<bool?>("Adx_LogonEnabled", "adx_logonenabled", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_modifiedbyipaddress")]
        public string Adx_ModifiedByIPAddress
        {
            get
            {
                return GetAttributeValue<string>("adx_modifiedbyipaddress");
            }
            set
            {
                SetAttributeValue<string>("Adx_ModifiedByIPAddress", "adx_modifiedbyipaddress", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_modifiedbyusername")]
        public string Adx_ModifiedByUsername
        {
            get
            {
                return GetAttributeValue<string>("adx_modifiedbyusername");
            }
            set
            {
                SetAttributeValue<string>("Adx_ModifiedByUsername", "adx_modifiedbyusername", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_organizationname")]
        public string Adx_OrganizationName
        {
            get
            {
                return GetAttributeValue<string>("adx_organizationname");
            }
            set
            {
                SetAttributeValue<string>("Adx_OrganizationName", "adx_organizationname", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_password")]
        public string Adx_password
        {
            get
            {
                return GetAttributeValue<string>("adx_password");
            }
            set
            {
                SetAttributeValue<string>("Adx_password", "adx_password", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_passwordanswer")]
        public string Adx_passwordanswer
        {
            get
            {
                return GetAttributeValue<string>("adx_passwordanswer");
            }
            set
            {
                SetAttributeValue<string>("Adx_passwordanswer", "adx_passwordanswer", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_passwordformat")]
        public string Adx_passwordformat
        {
            get
            {
                return GetAttributeValue<string>("adx_passwordformat");
            }
            set
            {
                SetAttributeValue<string>("Adx_passwordformat", "adx_passwordformat", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_passwordquestion")]
        public string Adx_passwordquestion
        {
            get
            {
                return GetAttributeValue<string>("adx_passwordquestion");
            }
            set
            {
                SetAttributeValue<string>("Adx_passwordquestion", "adx_passwordquestion", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_passwordsalt")]
        public string Adx_passwordsalt
        {
            get
            {
                return GetAttributeValue<string>("adx_passwordsalt");
            }
            set
            {
                SetAttributeValue<string>("Adx_passwordsalt", "adx_passwordsalt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_resetpassword")]
        public string Adx_resetpassword
        {
            get
            {
                return GetAttributeValue<string>("adx_resetpassword");
            }
            set
            {
                SetAttributeValue<string>("Adx_resetpassword", "adx_resetpassword", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for User associated with Contact.
        /// </summary>
        [AttributeLogicalName("adx_systemuserid")]
        public CrmEntityReference adx_systemuserid
        {
            get
            {
                return GetAttributeValue<EntityReference>("adx_systemuserid");
            }
            set
            {
                SetAttributeValue<EntityReference>("adx_systemuserid", "adx_systemuserid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_timezone")]
        public int? Adx_TimeZone
        {
            get
            {
                return GetAttributeValue<int?>("adx_timezone");
            }
            set
            {
                SetAttributeValue<int?>("Adx_TimeZone", "adx_timezone", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("adx_username")]
        public string Adx_username
        {
            get
            {
                return GetAttributeValue<string>("adx_username");
            }
            set
            {
                SetAttributeValue<string>("Adx_username", "adx_username", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalName("aging30")]
        public decimal? Aging30
        {
            get
            {
                return GetAttributeValue<decimal?>("aging30");
            }
        }
		
        /// <summary>
        /// Эквивалент срока оплаты 30 для контакта в базовой валюте.
        /// </summary>
        [AttributeLogicalName("aging30_base")]
        public decimal? Aging30_Base
        {
            get
            {
                return GetAttributeValue<decimal?>("aging30_base");
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalName("aging60")]
        public decimal? Aging60
        {
            get
            {
                return GetAttributeValue<decimal?>("aging60");
            }
        }
		
        /// <summary>
        /// Эквивалент срока оплаты 60 для контакта в базовой валюте.
        /// </summary>
        [AttributeLogicalName("aging60_base")]
        public decimal? Aging60_Base
        {
            get
            {
                return GetAttributeValue<decimal?>("aging60_base");
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalName("aging90")]
        public decimal? Aging90
        {
            get
            {
                return GetAttributeValue<decimal?>("aging90");
            }
        }
		
        /// <summary>
        /// Эквивалент срока оплаты 90 для контакта в базовой валюте.
        /// </summary>
        [AttributeLogicalName("aging90_base")]
        public decimal? Aging90_Base
        {
            get
            {
                return GetAttributeValue<decimal?>("aging90_base");
            }
        }
		
        /// <summary>
        /// Wedding anniversary of the contact. 
        /// </summary>
        [AttributeLogicalName("anniversary")]
        public DateTime? Anniversary
        {
            get
            {
                return GetAttributeValue<DateTime?>("anniversary");
            }
            set
            {
                SetAttributeValue<DateTime?>("Anniversary", "anniversary", value);
            }
        }
		
        /// <summary>
        /// Ежегодный доход контакта.
        /// </summary>
        [AttributeLogicalName("annualincome")]
        public decimal? AnnualIncome
        {
            get
            {
                return GetAttributeValue<decimal?>("annualincome");
            }
            set
            {
                SetAttributeValue<Money>("AnnualIncome", "annualincome", value);
            }
        }
		
        /// <summary>
        /// Эквивалент годового дохода контакта в базовой валюте.
        /// </summary>
        [AttributeLogicalName("annualincome_base")]
        public decimal? AnnualIncome_Base
        {
            get
            {
                return GetAttributeValue<decimal?>("annualincome_base");
            }
        }
		
        /// <summary>
        /// Имя ассистента контакта.
        /// </summary>
        [AttributeLogicalName("assistantname")]
        public string AssistantName
        {
            get
            {
                return GetAttributeValue<string>("assistantname");
            }
            set
            {
                SetAttributeValue<string>("AssistantName", "assistantname", value);
            }
        }
		
        /// <summary>
        /// Телефон ассистента контакта.
        /// </summary>
        [AttributeLogicalName("assistantphone")]
        public string AssistantPhone
        {
            get
            {
                return GetAttributeValue<string>("assistantphone");
            }
            set
            {
                SetAttributeValue<string>("AssistantPhone", "assistantphone", value);
            }
        }
		
        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        [AttributeLogicalName("birthdate")]
        public DateTime? BirthDate
        {
            get
            {
                return GetAttributeValue<DateTime?>("birthdate");
            }
            set
            {
                SetAttributeValue<DateTime?>("BirthDate", "birthdate", value);
            }
        }
		
        /// <summary>
        /// Имена детей контакта.
        /// </summary>
        [AttributeLogicalName("childrensnames")]
        public string ChildrensNames
        {
            get
            {
                return GetAttributeValue<string>("childrensnames");
            }
            set
            {
                SetAttributeValue<string>("ChildrensNames", "childrensnames", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор контакта.
        /// </summary>
        [AttributeLogicalName("contactid")]
        public Guid? ContactId
        {
            get
            {
                return GetAttributeValue<Guid?>("contactid");
            }
            set
            {
                SetPrimaryIdAttributeValue<Guid?>("ContactId", "contactid", value);
            }
        }
		
        [AttributeLogicalName("contactid")]
        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                ContactId = value;
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего контакт.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public CrmEntityReference CreatedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }
		
        /// <summary>
        /// Дата и время создания контакта.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get
            {
                return GetAttributeValue<DateTime?>("createdon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор делегата, создавшего контакт.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public CrmEntityReference CreatedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdonbehalfby");
            }
        }
		
        /// <summary>
        /// Кредитный лимит контакта.
        /// </summary>
        [AttributeLogicalName("creditlimit")]
        public decimal? CreditLimit
        {
            get
            {
                return GetAttributeValue<decimal?>("creditlimit");
            }
            set
            {
                SetAttributeValue<Money>("CreditLimit", "creditlimit", value);
            }
        }
		
        /// <summary>
        /// Эквивалент кредитного лимита контакта в базовой валюте.
        /// </summary>
        [AttributeLogicalName("creditlimit_base")]
        public decimal? CreditLimit_Base
        {
            get
            {
                return GetAttributeValue<decimal?>("creditlimit_base");
            }
        }
		
        /// <summary>
        /// Information about whether credit for the contact is on hold. 
        /// </summary>
        [AttributeLogicalName("creditonhold")]
        public bool? CreditOnHold
        {
            get
            {
                return GetAttributeValue<bool?>("creditonhold");
            }
            set
            {
                SetAttributeValue<bool?>("CreditOnHold", "creditonhold", value);
            }
        }
		
        /// <summary>
        /// Размер бизнеса контакта.
        /// </summary>
        [AttributeLogicalName("customersizecode")]
        public int? CustomerSizeCode
        {
            get
            {
                return GetAttributeValue<int?>("customersizecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("CustomerSizeCode", "customersizecode", value);
            }
        }
		
        /// <summary>
        /// Тип бизнеса, связанного с контактом.
        /// </summary>
        [AttributeLogicalName("customertypecode")]
        public int? CustomerTypeCode
        {
            get
            {
                return GetAttributeValue<int?>("customertypecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("CustomerTypeCode", "customertypecode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор прайс-листа по умолчанию для контакта.
        /// </summary>
        [AttributeLogicalName("defaultpricelevelid")]
        public CrmEntityReference DefaultPriceLevelId
        {
            get
            {
                return GetAttributeValue<EntityReference>("defaultpricelevelid");
            }
            set
            {
                SetAttributeValue<EntityReference>("DefaultPriceLevelId", "defaultpricelevelid", value);
            }
        }
		
        /// <summary>
        /// Отдел в подразделении или организации, связанный с контактом.
        /// </summary>
        [AttributeLogicalName("department")]
        public string Department
        {
            get
            {
                return GetAttributeValue<string>("department");
            }
            set
            {
                SetAttributeValue<string>("Department", "department", value);
            }
        }
		
        /// <summary>
        /// Описание контакта.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get
            {
                return GetAttributeValue<string>("description");
            }
            set
            {
                SetAttributeValue<string>("Description", "description", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли непосредственная рассылка сообщений электронной почты контакту.
        /// </summary>
        [AttributeLogicalName("donotbulkemail")]
        public bool? DoNotBulkEMail
        {
            get
            {
                return GetAttributeValue<bool?>("donotbulkemail");
            }
            set
            {
                SetAttributeValue<bool?>("DoNotBulkEMail", "donotbulkemail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли массовая отправка обычной почты контакту.
        /// </summary>
        [AttributeLogicalName("donotbulkpostalmail")]
        public bool? DoNotBulkPostalMail
        {
            get
            {
                return GetAttributeValue<bool?>("donotbulkpostalmail");
            }
            set
            {
                SetAttributeValue<bool?>("DoNotBulkPostalMail", "donotbulkpostalmail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли отправка электронной почты контакту.
        /// </summary>
        [AttributeLogicalName("donotemail")]
        public bool? DoNotEMail
        {
            get
            {
                return GetAttributeValue<bool?>("donotemail");
            }
            set
            {
                SetAttributeValue<bool?>("DoNotEMail", "donotemail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли отправка факсимильных сообщений контакту.
        /// </summary>
        [AttributeLogicalName("donotfax")]
        public bool? DoNotFax
        {
            get
            {
                return GetAttributeValue<bool?>("donotfax");
            }
            set
            {
                SetAttributeValue<bool?>("DoNotFax", "donotfax", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешены ли телефонные звонки контакту.
        /// </summary>
        [AttributeLogicalName("donotphone")]
        public bool? DoNotPhone
        {
            get
            {
                return GetAttributeValue<bool?>("donotphone");
            }
            set
            {
                SetAttributeValue<bool?>("DoNotPhone", "donotphone", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли отправка обычной почты контакту.
        /// </summary>
        [AttributeLogicalName("donotpostalmail")]
        public bool? DoNotPostalMail
        {
            get
            {
                return GetAttributeValue<bool?>("donotpostalmail");
            }
            set
            {
                SetAttributeValue<bool?>("DoNotPostalMail", "donotpostalmail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешено ли отправлять маркетинговую почту контакту.
        /// </summary>
        [AttributeLogicalName("donotsendmm")]
        public bool? DoNotSendMM
        {
            get
            {
                return GetAttributeValue<bool?>("donotsendmm");
            }
            set
            {
                SetAttributeValue<bool?>("DoNotSendMM", "donotsendmm", value);
            }
        }
		
        /// <summary>
        /// Формальный уровень образования, полученного контактом.
        /// </summary>
        [AttributeLogicalName("educationcode")]
        public int? EducationCode
        {
            get
            {
                return GetAttributeValue<int?>("educationcode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("EducationCode", "educationcode", value);
            }
        }
		
        /// <summary>
        /// Первый адрес электронной почты контакта.
        /// </summary>
        [AttributeLogicalName("emailaddress1")]
        public string EMailAddress1
        {
            get
            {
                return GetAttributeValue<string>("emailaddress1");
            }
            set
            {
                SetAttributeValue<string>("EMailAddress1", "emailaddress1", value);
            }
        }
		
        /// <summary>
        /// Второй адрес электронной почты контакта.
        /// </summary>
        [AttributeLogicalName("emailaddress2")]
        public string EMailAddress2
        {
            get
            {
                return GetAttributeValue<string>("emailaddress2");
            }
            set
            {
                SetAttributeValue<string>("EMailAddress2", "emailaddress2", value);
            }
        }
		
        /// <summary>
        /// Третий адрес электронной почты контакта.
        /// </summary>
        [AttributeLogicalName("emailaddress3")]
        public string EMailAddress3
        {
            get
            {
                return GetAttributeValue<string>("emailaddress3");
            }
            set
            {
                SetAttributeValue<string>("EMailAddress3", "emailaddress3", value);
            }
        }
		
        /// <summary>
        /// Идентификатор сотрудника для контакта.
        /// </summary>
        [AttributeLogicalName("employeeid")]
        public string EmployeeId
        {
            get
            {
                return GetAttributeValue<string>("employeeid");
            }
            set
            {
                SetAttributeValue<string>("EmployeeId", "employeeid", value);
            }
        }
		
        /// <summary>
        /// Обменный курс валюты, связанной с контактом, по отношению к базовой валюте.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get
            {
                return GetAttributeValue<decimal?>("exchangerate");
            }
        }
		
        /// <summary>
        /// Идентификатор для внешнего пользователя.
        /// </summary>
        [AttributeLogicalName("externaluseridentifier")]
        public string ExternalUserIdentifier
        {
            get
            {
                return GetAttributeValue<string>("externaluseridentifier");
            }
            set
            {
                SetAttributeValue<string>("ExternalUserIdentifier", "externaluseridentifier", value);
            }
        }
		
        /// <summary>
        /// Семейное положение контакта.
        /// </summary>
        [AttributeLogicalName("familystatuscode")]
        public int? FamilyStatusCode
        {
            get
            {
                return GetAttributeValue<int?>("familystatuscode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("FamilyStatusCode", "familystatuscode", value);
            }
        }
		
        /// <summary>
        /// Номер факса контакта.
        /// </summary>
        [AttributeLogicalName("fax")]
        public string Fax
        {
            get
            {
                return GetAttributeValue<string>("fax");
            }
            set
            {
                SetAttributeValue<string>("Fax", "fax", value);
            }
        }
		
        /// <summary>
        /// Имя контакта.
        /// </summary>
        [AttributeLogicalName("firstname")]
        public string FirstName
        {
            get
            {
                return GetAttributeValue<string>("firstname");
            }
            set
            {
                SetAttributeValue<string>("FirstName", "firstname", value);
            }
        }
		
        /// <summary>
        /// новое: полная ссылка для регитсрации на портале.
        ///старое: URL-адрес FTP-сайта контакта.
        /// </summary>
        [AttributeLogicalName("ftpsiteurl")]
        public string FtpSiteUrl
        {
            get
            {
                return GetAttributeValue<string>("ftpsiteurl");
            }
            set
            {
                SetAttributeValue<string>("FtpSiteUrl", "ftpsiteurl", value);
            }
        }
		
        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        [AttributeLogicalName("fullname")]
        public string FullName
        {
            get
            {
                return GetAttributeValue<string>("fullname");
            }
        }
		
        /// <summary>
        /// Пол контакта.
        /// </summary>
        [AttributeLogicalName("gendercode")]
        public int? GenderCode
        {
            get
            {
                return GetAttributeValue<int?>("gendercode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("GenderCode", "gendercode", value);
            }
        }
		
        /// <summary>
        /// Личный идентификатор контакта.
        /// </summary>
        [AttributeLogicalName("governmentid")]
        public string GovernmentId
        {
            get
            {
                return GetAttributeValue<string>("governmentid");
            }
            set
            {
                SetAttributeValue<string>("GovernmentId", "governmentid", value);
            }
        }
		
        /// <summary>
        /// Information about whether the contact has children. 
        /// </summary>
        [AttributeLogicalName("haschildrencode")]
        public int? HasChildrenCode
        {
            get
            {
                return GetAttributeValue<int?>("haschildrencode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("HasChildrenCode", "haschildrencode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get
            {
                return GetAttributeValue<int?>("importsequencenumber");
            }
            set
            {
                SetAttributeValue<int?>("ImportSequenceNumber", "importsequencenumber", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_contact_source")]
        public int? iok_contact_source
        {
            get
            {
                return GetAttributeValue<int?>("iok_contact_source");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_contact_source", "iok_contact_source", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_mailruusername")]
        public string iok_mailruusername
        {
            get
            {
                return GetAttributeValue<string>("iok_mailruusername");
            }
            set
            {
                SetAttributeValue<string>("iok_mailruusername", "iok_mailruusername", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_routenumber")]
        public string iok_RouteNumber
        {
            get
            {
                return GetAttributeValue<string>("iok_routenumber");
            }
            set
            {
                SetAttributeValue<string>("iok_RouteNumber", "iok_routenumber", value);
            }
        }
		
        /// <summary>
        /// поле для логина на портале через сервис ЦРМ
        /// </summary>
        [AttributeLogicalName("iok_systtechusername")]
        public string iok_systtechusername
        {
            get
            {
                return GetAttributeValue<string>("iok_systtechusername");
            }
            set
            {
                SetAttributeValue<string>("iok_systtechusername", "iok_systtechusername", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_telephoneban")]
        public bool? iok_telephoneban
        {
            get
            {
                return GetAttributeValue<bool?>("iok_telephoneban");
            }
            set
            {
                SetAttributeValue<bool?>("iok_telephoneban", "iok_telephoneban", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_vkusername")]
        public string iok_vkusername
        {
            get
            {
                return GetAttributeValue<string>("iok_vkusername");
            }
            set
            {
                SetAttributeValue<string>("iok_vkusername", "iok_vkusername", value);
            }
        }
		
        /// <summary>
        /// предоставление контакту доступа к видимости  обращений на портале. как правило для сотрудников ЦО - доступ по проекту. по-умолчанию доступ по организации. при необходмисти - только пользовательские.
        /// </summary>
        [AttributeLogicalName("iok_web_case_access_level")]
        public int? iok_web_case_access_level
        {
            get
            {
                return GetAttributeValue<int?>("iok_web_case_access_level");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_web_case_access_level", "iok_web_case_access_level", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_yandexusername")]
        public string iok_yandexusername
        {
            get
            {
                return GetAttributeValue<string>("iok_yandexusername");
            }
            set
            {
                SetAttributeValue<string>("iok_yandexusername", "iok_yandexusername", value);
            }
        }
		
        /// <summary>
        /// Сведения, указывающие, связан ли контакт с базой данных Microsoft Great Plains.
        /// </summary>
        [AttributeLogicalName("isbackofficecustomer")]
        public bool? IsBackofficeCustomer
        {
            get
            {
                return GetAttributeValue<bool?>("isbackofficecustomer");
            }
            set
            {
                SetAttributeValue<bool?>("IsBackofficeCustomer", "isbackofficecustomer", value);
            }
        }
		
        /// <summary>
        /// Название должности контакта.
        /// </summary>
        [AttributeLogicalName("jobtitle")]
        public string JobTitle
        {
            get
            {
                return GetAttributeValue<string>("jobtitle");
            }
            set
            {
                SetAttributeValue<string>("JobTitle", "jobtitle", value);
            }
        }
		
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        [AttributeLogicalName("lastname")]
        public string LastName
        {
            get
            {
                return GetAttributeValue<string>("lastname");
            }
            set
            {
                SetAttributeValue<string>("LastName", "lastname", value);
            }
        }
		
        /// <summary>
        /// Дата и время последнего обращения к контакту в рамках маркетинговой кампании.
        /// </summary>
        [AttributeLogicalName("lastusedincampaign")]
        public DateTime? LastUsedInCampaign
        {
            get
            {
                return GetAttributeValue<DateTime?>("lastusedincampaign");
            }
            set
            {
                SetAttributeValue<DateTime?>("LastUsedInCampaign", "lastusedincampaign", value);
            }
        }
		
        /// <summary>
        /// Источник контакта.
        /// </summary>
        [AttributeLogicalName("leadsourcecode")]
        public int? LeadSourceCode
        {
            get
            {
                return GetAttributeValue<int?>("leadsourcecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("LeadSourceCode", "leadsourcecode", value);
            }
        }
		
        /// <summary>
        /// Name of the contact's manager. 
        /// </summary>
        [AttributeLogicalName("managername")]
        public string ManagerName
        {
            get
            {
                return GetAttributeValue<string>("managername");
            }
            set
            {
                SetAttributeValue<string>("ManagerName", "managername", value);
            }
        }
		
        /// <summary>
        /// Телефон менеджера контакта.
        /// </summary>
        [AttributeLogicalName("managerphone")]
        public string ManagerPhone
        {
            get
            {
                return GetAttributeValue<string>("managerphone");
            }
            set
            {
                SetAttributeValue<string>("ManagerPhone", "managerphone", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор главного контакта для слияния.
        /// </summary>
        [AttributeLogicalName("masterid")]
        public CrmEntityReference MasterId
        {
            get
            {
                return GetAttributeValue<EntityReference>("masterid");
            }
        }
		
        /// <summary>
        /// Сведения о том, было ли выполнено слияние организации с главным контактом.
        /// </summary>
        [AttributeLogicalName("merged")]
        public bool? Merged
        {
            get
            {
                return GetAttributeValue<bool?>("merged");
            }
        }
		
        /// <summary>
        /// Отчество контакта.
        /// </summary>
        [AttributeLogicalName("middlename")]
        public string MiddleName
        {
            get
            {
                return GetAttributeValue<string>("middlename");
            }
            set
            {
                SetAttributeValue<string>("MiddleName", "middlename", value);
            }
        }
		
        /// <summary>
        /// Мобильный телефон контакта.
        /// </summary>
        [AttributeLogicalName("mobilephone")]
        public string MobilePhone
        {
            get
            {
                return GetAttributeValue<string>("mobilephone");
            }
            set
            {
                SetAttributeValue<string>("MobilePhone", "mobilephone", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for the user who last modified the contact.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public CrmEntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }
		
        /// <summary>
        /// Дата и время последнего изменения контакта.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get
            {
                return GetAttributeValue<DateTime?>("modifiedon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор последнего делегата, изменившего контакт.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public CrmEntityReference ModifiedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedonbehalfby");
            }
        }
		
        /// <summary>
        /// Indicates the contact's level of access and permissions for the eService Accelerator.
        /// </summary>
        [AttributeLogicalName("msa_eservicesaccesslevel")]
        public int? MSA_eServicesAccessLevel
        {
            get
            {
                return GetAttributeValue<int?>("msa_eservicesaccesslevel");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("MSA_eServicesAccessLevel", "msa_eservicesaccesslevel", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for Account associated with Contact.
        /// </summary>
        [AttributeLogicalName("msa_managingpartnerid")]
        public CrmEntityReference msa_managingpartnerid
        {
            get
            {
                return GetAttributeValue<EntityReference>("msa_managingpartnerid");
            }
            set
            {
                SetAttributeValue<EntityReference>("msa_managingpartnerid", "msa_managingpartnerid", value);
            }
        }
		
        /// <summary>
        /// Признак принадлежности пользователя к ЦО, а не к дистрибьютору/ удаленному подразаделению.
        /// </summary>
        [AttributeLogicalName("msa_webuser")]
        public bool? MSA_webuser
        {
            get
            {
                return GetAttributeValue<bool?>("msa_webuser");
            }
            set
            {
                SetAttributeValue<bool?>("MSA_webuser", "msa_webuser", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_interes")]
        public bool? New_Interes
        {
            get
            {
                return GetAttributeValue<bool?>("new_interes");
            }
            set
            {
                SetAttributeValue<bool?>("New_Interes", "new_interes", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_neutral")]
        public bool? New_neutral
        {
            get
            {
                return GetAttributeValue<bool?>("new_neutral");
            }
            set
            {
                SetAttributeValue<bool?>("New_neutral", "new_neutral", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_problem")]
        public bool? New_problem
        {
            get
            {
                return GetAttributeValue<bool?>("new_problem");
            }
            set
            {
                SetAttributeValue<bool?>("New_problem", "new_problem", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_reshenie")]
        public bool? New_reshenie
        {
            get
            {
                return GetAttributeValue<bool?>("new_reshenie");
            }
            set
            {
                SetAttributeValue<bool?>("New_reshenie", "new_reshenie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_route")]
        public string new_route
        {
            get
            {
                return GetAttributeValue<string>("new_route");
            }
            set
            {
                SetAttributeValue<string>("new_route", "new_route", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_site_fullname")]
        public string New_site_fullname
        {
            get
            {
                return GetAttributeValue<string>("new_site_fullname");
            }
            set
            {
                SetAttributeValue<string>("New_site_fullname", "new_site_fullname", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_site_id")]
        public int? New_site_id
        {
            get
            {
                return GetAttributeValue<int?>("new_site_id");
            }
            set
            {
                SetAttributeValue<int?>("New_site_id", "new_site_id", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_skype")]
        public string New_skype
        {
            get
            {
                return GetAttributeValue<string>("new_skype");
            }
            set
            {
                SetAttributeValue<string>("New_skype", "new_skype", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Карточка клиента, связанного с объектом Контакт.
        /// </summary>
        [AttributeLogicalName("new_sotrudniki")]
        public CrmEntityReference new_sotrudniki
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_sotrudniki");
            }
            set
            {
                SetAttributeValue<EntityReference>("new_sotrudniki", "new_sotrudniki", value);
            }
        }
		
        /// <summary>
        /// Псеводним контакта.
        /// </summary>
        [AttributeLogicalName("nickname")]
        public string NickName
        {
            get
            {
                return GetAttributeValue<string>("nickname");
            }
            set
            {
                SetAttributeValue<string>("NickName", "nickname", value);
            }
        }
		
        /// <summary>
        /// Количество детей контакта.
        /// </summary>
        [AttributeLogicalName("numberofchildren")]
        public int? NumberOfChildren
        {
            get
            {
                return GetAttributeValue<int?>("numberofchildren");
            }
            set
            {
                SetAttributeValue<int?>("NumberOfChildren", "numberofchildren", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор интереса, из которого создан контакт.
        /// </summary>
        [AttributeLogicalName("originatingleadid")]
        public CrmEntityReference OriginatingLeadId
        {
            get
            {
                return GetAttributeValue<EntityReference>("originatingleadid");
            }
            set
            {
                SetAttributeValue<EntityReference>("OriginatingLeadId", "originatingleadid", value);
            }
        }
		
        /// <summary>
        /// Дата и время переноса записи.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get
            {
                return GetAttributeValue<DateTime?>("overriddencreatedon");
            }
            set
            {
                SetAttributeValue<DateTime?>("OverriddenCreatedOn", "overriddencreatedon", value);
            }
        }
		
        /// <summary>
        /// Unique identifier of the user or team that owns the contact.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public CrmEntityReference OwnerId
        {
            get
            {
                return GetAttributeValue<EntityReference>("ownerid");
            }
            set
            {
                SetAttributeValue<EntityReference>("OwnerId", "ownerid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор подразделения,  ответственного за контакт.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public CrmEntityReference OwningBusinessUnit
        {
            get
            {
                return GetAttributeValue<EntityReference>("owningbusinessunit");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор рабочей группы, ответственной за контакт.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public CrmEntityReference OwningTeam
        {
            get
            {
                return GetAttributeValue<EntityReference>("owningteam");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, ответственного за контакт.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public CrmEntityReference OwningUser
        {
            get
            {
                return GetAttributeValue<EntityReference>("owninguser");
            }
        }
		
        /// <summary>
        /// Номер пейджера контакта.
        /// </summary>
        [AttributeLogicalName("pager")]
        public string Pager
        {
            get
            {
                return GetAttributeValue<string>("pager");
            }
            set
            {
                SetAttributeValue<string>("Pager", "pager", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор родительского контакта.
        /// </summary>
        [AttributeLogicalName("parentcontactid")]
        public CrmEntityReference ParentContactId
        {
            get
            {
                return GetAttributeValue<EntityReference>("parentcontactid");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор организации или контакта, связанных с контактом.
        /// </summary>
        [AttributeLogicalName("parentcustomerid")]
        public CrmEntityReference ParentCustomerId
        {
            get
            {
                return GetAttributeValue<EntityReference>("parentcustomerid");
            }
            set
            {
                SetAttributeValue<EntityReference>("ParentCustomerId", "parentcustomerid", value);
            }
        }
		
        /// <summary>
        /// Сведения, указывающие, входит ли контакт в правила бизнес-процесса.
        /// </summary>
        [AttributeLogicalName("participatesinworkflow")]
        public bool? ParticipatesInWorkflow
        {
            get
            {
                return GetAttributeValue<bool?>("participatesinworkflow");
            }
            set
            {
                SetAttributeValue<bool?>("ParticipatesInWorkflow", "participatesinworkflow", value);
            }
        }
		
        /// <summary>
        /// Условия оплаты для контакта.
        /// </summary>
        [AttributeLogicalName("paymenttermscode")]
        public int? PaymentTermsCode
        {
            get
            {
                return GetAttributeValue<int?>("paymenttermscode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("PaymentTermsCode", "paymenttermscode", value);
            }
        }
		
        /// <summary>
        /// День недели, предпочитаемый контактом для планирования действий сервиса.
        /// </summary>
        [AttributeLogicalName("preferredappointmentdaycode")]
        public int? PreferredAppointmentDayCode
        {
            get
            {
                return GetAttributeValue<int?>("preferredappointmentdaycode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("PreferredAppointmentDayCode", "preferredappointmentdaycode", value);
            }
        }
		
        /// <summary>
        /// Время, предпочитаемое контактом для планирования действий сервиса.
        /// </summary>
        [AttributeLogicalName("preferredappointmenttimecode")]
        public int? PreferredAppointmentTimeCode
        {
            get
            {
                return GetAttributeValue<int?>("preferredappointmenttimecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("PreferredAppointmentTimeCode", "preferredappointmenttimecode", value);
            }
        }
		
        /// <summary>
        /// Предпочтительный способ связи с контактом.
        /// </summary>
        [AttributeLogicalName("preferredcontactmethodcode")]
        public int? PreferredContactMethodCode
        {
            get
            {
                return GetAttributeValue<int?>("preferredcontactmethodcode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("PreferredContactMethodCode", "preferredcontactmethodcode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор оборудования, предпочитаемого контактом для планирования действий сервиса.
        /// </summary>
        [AttributeLogicalName("preferredequipmentid")]
        public CrmEntityReference PreferredEquipmentId
        {
            get
            {
                return GetAttributeValue<EntityReference>("preferredequipmentid");
            }
            set
            {
                SetAttributeValue<EntityReference>("PreferredEquipmentId", "preferredequipmentid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор сервиса, предпочитаемого контактом для планирования действий сервиса.
        /// </summary>
        [AttributeLogicalName("preferredserviceid")]
        public CrmEntityReference PreferredServiceId
        {
            get
            {
                return GetAttributeValue<EntityReference>("preferredserviceid");
            }
            set
            {
                SetAttributeValue<EntityReference>("PreferredServiceId", "preferredserviceid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя системы, предпочитаемого организацией для планирования действий сервиса.
        /// </summary>
        [AttributeLogicalName("preferredsystemuserid")]
        public CrmEntityReference PreferredSystemUserId
        {
            get
            {
                return GetAttributeValue<EntityReference>("preferredsystemuserid");
            }
            set
            {
                SetAttributeValue<EntityReference>("PreferredSystemUserId", "preferredsystemuserid", value);
            }
        }
		
        /// <summary>
        /// Приветствие в переписке с контактом.
        /// </summary>
        [AttributeLogicalName("salutation")]
        public string Salutation
        {
            get
            {
                return GetAttributeValue<string>("salutation");
            }
            set
            {
                SetAttributeValue<string>("Salutation", "salutation", value);
            }
        }
		
        /// <summary>
        /// Способ поставки для контакта.
        /// </summary>
        [AttributeLogicalName("shippingmethodcode")]
        public int? ShippingMethodCode
        {
            get
            {
                return GetAttributeValue<int?>("shippingmethodcode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("ShippingMethodCode", "shippingmethodcode", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("sm_solutation")]
        public int? sm_solutation
        {
            get
            {
                return GetAttributeValue<int?>("sm_solutation");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("sm_solutation", "sm_solutation", value);
            }
        }
		
        /// <summary>
        /// Name of the contact's spouse.
        /// </summary>
        [AttributeLogicalName("spousesname")]
        public string SpousesName
        {
            get
            {
                return GetAttributeValue<string>("spousesname");
            }
            set
            {
                SetAttributeValue<string>("SpousesName", "spousesname", value);
            }
        }
		
        /// <summary>
        /// Состояние контакта.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public int? StateCode
        {
            get
            {
                return GetAttributeValue<int?>("statecode");
            }
        }
		
        /// <summary>
        /// Причина состояния контакта.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public int? StatusCode
        {
            get
            {
                return GetAttributeValue<int?>("statuscode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("StatusCode", "statuscode", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalName("subscriptionid")]
        public Guid? SubscriptionId
        {
            get
            {
                return GetAttributeValue<Guid?>("subscriptionid");
            }
            set
            {
                SetAttributeValue<Guid?>("SubscriptionId", "subscriptionid", value);
            }
        }
		
        /// <summary>
        /// Приставка к имени контакта (например, мл., ст., III).
        /// </summary>
        [AttributeLogicalName("suffix")]
        public string Suffix
        {
            get
            {
                return GetAttributeValue<string>("suffix");
            }
            set
            {
                SetAttributeValue<string>("Suffix", "suffix", value);
            }
        }
		
        /// <summary>
        /// айди пользователя от гугла
        /// </summary>
        [AttributeLogicalName("svk_googlename")]
        public string svk_googlename
        {
            get
            {
                return GetAttributeValue<string>("svk_googlename");
            }
            set
            {
                SetAttributeValue<string>("svk_googlename", "svk_googlename", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Проект, связанного с объектом Контакт.
        /// </summary>
        [AttributeLogicalName("svk_project")]
        public CrmEntityReference svk_project
        {
            get
            {
                return GetAttributeValue<EntityReference>("svk_project");
            }
            set
            {
                SetAttributeValue<EntityReference>("svk_project", "svk_project", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_role_dlya_podderzhki")]
        public int? svk_role_dlya_podderzhki
        {
            get
            {
                return GetAttributeValue<int?>("svk_role_dlya_podderzhki");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("svk_role_dlya_podderzhki", "svk_role_dlya_podderzhki", value);
            }
        }
		
        /// <summary>
        /// Первый номер телефон для контакта.
        /// </summary>
        [AttributeLogicalName("telephone1")]
        public string Telephone1
        {
            get
            {
                return GetAttributeValue<string>("telephone1");
            }
            set
            {
                SetAttributeValue<string>("Telephone1", "telephone1", value);
            }
        }
		
        /// <summary>
        /// Второй номер телефона для контакта.
        /// </summary>
        [AttributeLogicalName("telephone2")]
        public string Telephone2
        {
            get
            {
                return GetAttributeValue<string>("telephone2");
            }
            set
            {
                SetAttributeValue<string>("Telephone2", "telephone2", value);
            }
        }
		
        /// <summary>
        /// Третий номер телефона для контакта.
        /// </summary>
        [AttributeLogicalName("telephone3")]
        public string Telephone3
        {
            get
            {
                return GetAttributeValue<string>("telephone3");
            }
            set
            {
                SetAttributeValue<string>("Telephone3", "telephone3", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор территории, которой приписан контакт.
        /// </summary>
        [AttributeLogicalName("territorycode")]
        public int? TerritoryCode
        {
            get
            {
                return GetAttributeValue<int?>("territorycode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("TerritoryCode", "territorycode", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get
            {
                return GetAttributeValue<int?>("timezoneruleversionnumber");
            }
            set
            {
                SetAttributeValue<int?>("TimeZoneRuleVersionNumber", "timezoneruleversionnumber", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор валюты, связанной с контактом.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public CrmEntityReference TransactionCurrencyId
        {
            get
            {
                return GetAttributeValue<EntityReference>("transactioncurrencyid");
            }
            set
            {
                SetAttributeValue<EntityReference>("TransactionCurrencyId", "transactioncurrencyid", value);
            }
        }
		
        /// <summary>
        /// Код часового пояса, использовавшийся при создании записи.
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get
            {
                return GetAttributeValue<int?>("utcconversiontimezonecode");
            }
            set
            {
                SetAttributeValue<int?>("UTCConversionTimeZoneCode", "utcconversiontimezonecode", value);
            }
        }
		
        /// <summary>
        /// Номер версии контакта.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get
            {
                return GetAttributeValue<long?>("versionnumber");
            }
        }
		
        /// <summary>
        /// URL-адрес веб-сайта контакта.
        /// </summary>
        [AttributeLogicalName("websiteurl")]
        public string WebSiteUrl
        {
            get
            {
                return GetAttributeValue<string>("websiteurl");
            }
            set
            {
                SetAttributeValue<string>("WebSiteUrl", "websiteurl", value);
            }
        }
		
        /// <summary>
        /// Фонетическое руководство хирагана или катакана для имени контакта, используемое при сортировке фонетических имен.
        /// </summary>
        [AttributeLogicalName("yomifirstname")]
        public string YomiFirstName
        {
            get
            {
                return GetAttributeValue<string>("yomifirstname");
            }
            set
            {
                SetAttributeValue<string>("YomiFirstName", "yomifirstname", value);
            }
        }
		
        /// <summary>
        /// Фонетическое руководство хирагана или катакана для полного имени контакта, используемое при сортировке фонетических имен.
        /// </summary>
        [AttributeLogicalName("yomifullname")]
        public string YomiFullName
        {
            get
            {
                return GetAttributeValue<string>("yomifullname");
            }
        }
		
        /// <summary>
        /// Фонетическое руководство хирагана или катакана для фамилии контакта, используемое при сортировке фонетических имен.
        /// </summary>
        [AttributeLogicalName("yomilastname")]
        public string YomiLastName
        {
            get
            {
                return GetAttributeValue<string>("yomilastname");
            }
            set
            {
                SetAttributeValue<string>("YomiLastName", "yomilastname", value);
            }
        }
		
        /// <summary>
        /// Фонетическое руководство хирагана или катакана для отчества контакта, используемое при сортировке фонетических имен.
        /// </summary>
        [AttributeLogicalName("yomimiddlename")]
        public string YomiMiddleName
        {
            get
            {
                return GetAttributeValue<string>("yomimiddlename");
            }
            set
            {
                SetAttributeValue<string>("YomiMiddleName", "yomimiddlename", value);
            }
        }
		
        /// <summary>
        /// 1:N account_primary_contact
        /// </summary>
        [RelationshipSchemaName("account_primary_contact")]
        public IEnumerable<Account> account_primary_contact
        {
            get
            {
                return GetRelatedEntities<Account>("account_primary_contact", null);
            }
            set
            {
                SetRelatedEntities<Account>("account_primary_contact", "account_primary_contact", null, value);
            }
        }
		
        /// <summary>
        /// 1:N contact_activity_parties
        /// </summary>
        [RelationshipSchemaName("contact_activity_parties")]
        public IEnumerable<ActivityParty> contact_activity_parties
        {
            get
            {
                return GetRelatedEntities<ActivityParty>("contact_activity_parties", null);
            }
            set
            {
                SetRelatedEntities<ActivityParty>("contact_activity_parties", "contact_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Contact_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Contact_ActivityPointers")]
        public IEnumerable<ActivityPointer> Contact_ActivityPointers
        {
            get
            {
                return GetRelatedEntities<ActivityPointer>("Contact_ActivityPointers", null);
            }
            set
            {
                SetRelatedEntities<ActivityPointer>("Contact_ActivityPointers", "Contact_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Contact_Annotation
        /// </summary>
        [RelationshipSchemaName("Contact_Annotation")]
        public IEnumerable<Annotation> Contact_Annotation
        {
            get
            {
                return GetRelatedEntities<Annotation>("Contact_Annotation", null);
            }
            set
            {
                SetRelatedEntities<Annotation>("Contact_Annotation", "Contact_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// 1:N contact_as_responsible_contact
        /// </summary>
        [RelationshipSchemaName("contact_as_responsible_contact")]
        public IEnumerable<Incident> contact_as_responsible_contact
        {
            get
            {
                return GetRelatedEntities<Incident>("contact_as_responsible_contact", null);
            }
            set
            {
                SetRelatedEntities<Incident>("contact_as_responsible_contact", "contact_as_responsible_contact", null, value);
            }
        }
		
        /// <summary>
        /// 1:N contact_customer_contacts
        /// </summary>
        [RelationshipSchemaName("contact_customer_contacts", EntityRole.Referenced)]
        public IEnumerable<Contact> Referencedcontact_customer_contacts
        {
            get
            {
                return GetRelatedEntities<Contact>("contact_customer_contacts", EntityRole.Referenced);
            }
            set
            {
                SetRelatedEntities<Contact>("Referencedcontact_customer_contacts", "contact_customer_contacts", EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N Contact_Emails
        /// </summary>
        [RelationshipSchemaName("Contact_Emails")]
        public IEnumerable<Email> Contact_Emails
        {
            get
            {
                return GetRelatedEntities<Email>("Contact_Emails", null);
            }
            set
            {
                SetRelatedEntities<Email>("Contact_Emails", "Contact_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N contact_iok_action_send_SMSes
        /// </summary>
        [RelationshipSchemaName("contact_iok_action_send_SMSes")]
        public IEnumerable<iok_action_send_SMS> contact_iok_action_send_SMSes
        {
            get
            {
                return GetRelatedEntities<iok_action_send_SMS>("contact_iok_action_send_SMSes", null);
            }
            set
            {
                SetRelatedEntities<iok_action_send_SMS>("contact_iok_action_send_SMSes", "contact_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// 1:N contact_master_contact
        /// </summary>
        [RelationshipSchemaName("contact_master_contact", EntityRole.Referenced)]
        public IEnumerable<Contact> Referencedcontact_master_contact
        {
            get
            {
                return GetRelatedEntities<Contact>("contact_master_contact", EntityRole.Referenced);
            }
            set
            {
                SetRelatedEntities<Contact>("Referencedcontact_master_contact", "contact_master_contact", EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N incident_customer_contacts
        /// </summary>
        [RelationshipSchemaName("incident_customer_contacts")]
        public IEnumerable<Incident> incident_customer_contacts
        {
            get
            {
                return GetRelatedEntities<Incident>("incident_customer_contacts", null);
            }
            set
            {
                SetRelatedEntities<Incident>("incident_customer_contacts", "incident_customer_contacts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_contact_incident_emailcopyfield
        /// </summary>
        [RelationshipSchemaName("iok_contact_incident_emailcopyfield")]
        public IEnumerable<Incident> iok_contact_incident_emailcopyfield
        {
            get
            {
                return GetRelatedEntities<Incident>("iok_contact_incident_emailcopyfield", null);
            }
            set
            {
                SetRelatedEntities<Incident>("iok_contact_incident_emailcopyfield", "iok_contact_incident_emailcopyfield", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_contact_incident_emailto
        /// </summary>
        [RelationshipSchemaName("iok_contact_incident_emailto")]
        public IEnumerable<Incident> iok_contact_incident_emailto
        {
            get
            {
                return GetRelatedEntities<Incident>("iok_contact_incident_emailto", null);
            }
            set
            {
                SetRelatedEntities<Incident>("iok_contact_incident_emailto", "iok_contact_incident_emailto", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_contact_incident_reopen_portal_user
        /// </summary>
        [RelationshipSchemaName("iok_contact_incident_reopen_portal_user")]
        public IEnumerable<Incident> iok_contact_incident_reopen_portal_user
        {
            get
            {
                return GetRelatedEntities<Incident>("iok_contact_incident_reopen_portal_user", null);
            }
            set
            {
                SetRelatedEntities<Incident>("iok_contact_incident_reopen_portal_user", "iok_contact_incident_reopen_portal_user", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_contact_iok_getphonecall_null
        /// </summary>
        [RelationshipSchemaName("iok_contact_iok_getphonecall_null")]
        public IEnumerable<iok_getphonecall> iok_contact_iok_getphonecall_null
        {
            get
            {
                return GetRelatedEntities<iok_getphonecall>("iok_contact_iok_getphonecall_null", null);
            }
            set
            {
                SetRelatedEntities<iok_getphonecall>("iok_contact_iok_getphonecall_null", "iok_contact_iok_getphonecall_null", null, value);
            }
        }
		
        /// <summary>
        /// 1:N msa_contact_incident
        /// </summary>
        [RelationshipSchemaName("msa_contact_incident")]
        public IEnumerable<Incident> msa_contact_incident
        {
            get
            {
                return GetRelatedEntities<Incident>("msa_contact_incident", null);
            }
            set
            {
                SetRelatedEntities<Incident>("msa_contact_incident", "msa_contact_incident", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_account
        /// </summary>
        [RelationshipSchemaName("new_contact_account")]
        public IEnumerable<Account> new_contact_account
        {
            get
            {
                return GetRelatedEntities<Account>("new_contact_account", null);
            }
            set
            {
                SetRelatedEntities<Account>("new_contact_account", "new_contact_account", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_account1
        /// </summary>
        [RelationshipSchemaName("new_contact_account1")]
        public IEnumerable<Account> new_contact_account1
        {
            get
            {
                return GetRelatedEntities<Account>("new_contact_account1", null);
            }
            set
            {
                SetRelatedEntities<Account>("new_contact_account1", "new_contact_account1", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_account2
        /// </summary>
        [RelationshipSchemaName("new_contact_account2")]
        public IEnumerable<Account> new_contact_account2
        {
            get
            {
                return GetRelatedEntities<Account>("new_contact_account2", null);
            }
            set
            {
                SetRelatedEntities<Account>("new_contact_account2", "new_contact_account2", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_account3
        /// </summary>
        [RelationshipSchemaName("new_contact_account3")]
        public IEnumerable<Account> new_contact_account3
        {
            get
            {
                return GetRelatedEntities<Account>("new_contact_account3", null);
            }
            set
            {
                SetRelatedEntities<Account>("new_contact_account3", "new_contact_account3", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_account5
        /// </summary>
        [RelationshipSchemaName("new_contact_account5")]
        public IEnumerable<Account> new_contact_account5
        {
            get
            {
                return GetRelatedEntities<Account>("new_contact_account5", null);
            }
            set
            {
                SetRelatedEntities<Account>("new_contact_account5", "new_contact_account5", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_new_probe
        /// </summary>
        [RelationshipSchemaName("new_contact_new_probe")]
        public IEnumerable<New_Probe> new_contact_new_probe
        {
            get
            {
                return GetRelatedEntities<New_Probe>("new_contact_new_probe", null);
            }
            set
            {
                SetRelatedEntities<New_Probe>("new_contact_new_probe", "new_contact_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_new_probe_menedjer
        /// </summary>
        [RelationshipSchemaName("new_contact_new_probe_menedjer")]
        public IEnumerable<New_Probe> new_contact_new_probe_menedjer
        {
            get
            {
                return GetRelatedEntities<New_Probe>("new_contact_new_probe_menedjer", null);
            }
            set
            {
                SetRelatedEntities<New_Probe>("new_contact_new_probe_menedjer", "new_contact_new_probe_menedjer", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_new_probe_operator1
        /// </summary>
        [RelationshipSchemaName("new_contact_new_probe_operator1")]
        public IEnumerable<New_Probe> new_contact_new_probe_operator1
        {
            get
            {
                return GetRelatedEntities<New_Probe>("new_contact_new_probe_operator1", null);
            }
            set
            {
                SetRelatedEntities<New_Probe>("new_contact_new_probe_operator1", "new_contact_new_probe_operator1", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_new_probe_podderj_integr
        /// </summary>
        [RelationshipSchemaName("new_contact_new_probe_podderj_integr")]
        public IEnumerable<New_Probe> new_contact_new_probe_podderj_integr
        {
            get
            {
                return GetRelatedEntities<New_Probe>("new_contact_new_probe_podderj_integr", null);
            }
            set
            {
                SetRelatedEntities<New_Probe>("new_contact_new_probe_podderj_integr", "new_contact_new_probe_podderj_integr", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_new_probe_spec
        /// </summary>
        [RelationshipSchemaName("new_contact_new_probe_spec")]
        public IEnumerable<New_Probe> new_contact_new_probe_spec
        {
            get
            {
                return GetRelatedEntities<New_Probe>("new_contact_new_probe_spec", null);
            }
            set
            {
                SetRelatedEntities<New_Probe>("new_contact_new_probe_spec", "new_contact_new_probe_spec", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_contact_new_probe_sysadmin
        /// </summary>
        [RelationshipSchemaName("new_contact_new_probe_sysadmin")]
        public IEnumerable<New_Probe> new_contact_new_probe_sysadmin
        {
            get
            {
                return GetRelatedEntities<New_Probe>("new_contact_new_probe_sysadmin", null);
            }
            set
            {
                SetRelatedEntities<New_Probe>("new_contact_new_probe_sysadmin", "new_contact_new_probe_sysadmin", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_copy_letter_contact4
        /// </summary>
        [RelationshipSchemaName("new_copy_letter_contact4")]
        public IEnumerable<Account> new_copy_letter_contact4
        {
            get
            {
                return GetRelatedEntities<Account>("new_copy_letter_contact4", null);
            }
            set
            {
                SetRelatedEntities<Account>("new_copy_letter_contact4", "new_copy_letter_contact4", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_kartochka_klienta
        /// </summary>
        [RelationshipSchemaName("new_kartochka_klienta")]
        public IEnumerable<New_Probe> new_kartochka_klienta
        {
            get
            {
                return GetRelatedEntities<New_Probe>("new_kartochka_klienta", null);
            }
            set
            {
                SetRelatedEntities<New_Probe>("new_kartochka_klienta", "new_kartochka_klienta", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_contact_svk_project_incident_responsible
        /// </summary>
        [RelationshipSchemaName("svk_contact_svk_project_incident_responsible")]
        public IEnumerable<svk_project> svk_contact_svk_project_incident_responsible
        {
            get
            {
                return GetRelatedEntities<svk_project>("svk_contact_svk_project_incident_responsible", null);
            }
            set
            {
                SetRelatedEntities<svk_project>("svk_contact_svk_project_incident_responsible", "svk_contact_svk_project_incident_responsible", null, value);
            }
        }
		
        /// <summary>
        /// N:1 adx_systemuser_contact
        /// </summary>
        [AttributeLogicalName("adx_systemuserid")]
        [RelationshipSchemaName("adx_systemuser_contact")]
        public SystemUser adx_systemuser_contact
        {
            get
            {
                return GetRelatedEntity<SystemUser>("adx_systemuser_contact", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("adx_systemuser_contact", "adx_systemuser_contact", null, value);
            }
        }
		
        /// <summary>
        /// N:1 contact_customer_accounts
        /// </summary>
        [AttributeLogicalName("parentcustomerid")]
        [RelationshipSchemaName("contact_customer_accounts")]
        public Account contact_customer_accounts
        {
            get
            {
                return GetRelatedEntity<Account>("contact_customer_accounts", null);
            }
            set
            {
                SetRelatedEntity<Account>("contact_customer_accounts", "contact_customer_accounts", null, value);
            }
        }
		
        /// <summary>
        /// N:1 contact_customer_contacts
        /// </summary>
        [AttributeLogicalName("parentcustomerid")]
        [RelationshipSchemaName("contact_customer_contacts", EntityRole.Referencing)]
        public Contact Referencingcontact_customer_contacts
        {
            get
            {
                return GetRelatedEntity<Contact>("contact_customer_contacts", EntityRole.Referencing);
            }
            set
            {
                SetRelatedEntity<Contact>("Referencingcontact_customer_contacts", "contact_customer_contacts", EntityRole.Referencing, value);
            }
        }
		
        /// <summary>
        /// N:1 contact_master_contact
        /// </summary>
        [AttributeLogicalName("masterid")]
        [RelationshipSchemaName("contact_master_contact", EntityRole.Referencing)]
        public Contact Referencingcontact_master_contact
        {
            get
            {
                return GetRelatedEntity<Contact>("contact_master_contact", EntityRole.Referencing);
            }
        }
		
        /// <summary>
        /// N:1 contact_owning_user
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("contact_owning_user")]
        public SystemUser contact_owning_user
        {
            get
            {
                return GetRelatedEntity<SystemUser>("contact_owning_user", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_contact_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_contact_createdonbehalfby")]
        public SystemUser lk_contact_createdonbehalfby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_contact_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_contact_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_contact_modifiedonbehalfby")]
        public SystemUser lk_contact_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_contact_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_contactbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_contactbase_createdby")]
        public SystemUser lk_contactbase_createdby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_contactbase_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_contactbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_contactbase_modifiedby")]
        public SystemUser lk_contactbase_modifiedby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_contactbase_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 msa_contact_managingpartner
        /// </summary>
        [AttributeLogicalName("msa_managingpartnerid")]
        [RelationshipSchemaName("msa_contact_managingpartner")]
        public Account msa_contact_managingpartner
        {
            get
            {
                return GetRelatedEntity<Account>("msa_contact_managingpartner", null);
            }
            set
            {
                SetRelatedEntity<Account>("msa_contact_managingpartner", "msa_contact_managingpartner", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_sotrudniki
        /// </summary>
        [AttributeLogicalName("new_sotrudniki")]
        [RelationshipSchemaName("new_sotrudniki")]
        public New_Probe new_sotrudniki_link
        {
            get
            {
                return GetRelatedEntity<New_Probe>("new_sotrudniki", null);
            }
            set
            {
                SetRelatedEntity<New_Probe>("new_sotrudniki", "new_sotrudniki", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_svk_project_contact
        /// </summary>
        [AttributeLogicalName("svk_project")]
        [RelationshipSchemaName("svk_svk_project_contact")]
        public svk_project svk_svk_project_contact
        {
            get
            {
                return GetRelatedEntity<svk_project>("svk_svk_project_contact", null);
            }
            set
            {
                SetRelatedEntity<svk_project>("svk_svk_project_contact", "svk_svk_project_contact", null, value);
            }
        }
		
        /// <summary>
        /// N:1 system_user_contacts
        /// </summary>
        [AttributeLogicalName("preferredsystemuserid")]
        [RelationshipSchemaName("system_user_contacts")]
        public SystemUser system_user_contacts
        {
            get
            {
                return GetRelatedEntity<SystemUser>("system_user_contacts", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("system_user_contacts", "system_user_contacts", null, value);
            }
        }
    }
}