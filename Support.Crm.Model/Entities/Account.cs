namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Физическое или юридическое лицо, которому сотрудник пытается продать товар или услугу. Компания, которой выставляются счета в ходе деловых операций.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("AccountSet")]
    public partial class Account : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Account() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "account";
		
        public const int EntityTypeCode = 1;
		
        /// <summary>
        /// Раскрывающийся список для выбора категории организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
        public System.Nullable<int> AccountCategoryCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("accountcategorycode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("AccountCategoryCode", "accountcategorycode", value);
            }
        }
		
        /// <summary>
        /// Раскрывающийся список классификации организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
        public System.Nullable<int> AccountClassificationCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("accountclassificationcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("AccountClassificationCode", "accountclassificationcode", value);
            }
        }
		
        /// <summary>
        /// Unique identifier of the account. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public System.Nullable<System.Guid> AccountId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("AccountId", "accountid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.AccountId = value;
            }
        }
		
        /// <summary>
        /// Номер организации, предоставленный пользователем, использованный в корреспонденции, связанной с организацией.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountnumber")]
        public string AccountNumber
        {
            get
            {
                return this.GetAttributeValue<string>("accountnumber");
            }
            set
            {
                this.SetAttributeValue<string>("AccountNumber", "accountnumber", value);
            }
        }
		
        /// <summary>
        /// Раскрывающийся список для выбора рейтинга организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
        public System.Nullable<int> AccountRatingCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("accountratingcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("AccountRatingCode", "accountratingcode", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for address 1. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.Guid>>("Address1_AddressId", "address1_addressid", value);
            }
        }
		
        /// <summary>
        /// Тип адреса для адреса 1 (например, адрес для выставления счетов, адрес поставки или основной адрес).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public System.Nullable<int> Address1_AddressTypeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_addresstypecode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("Address1_AddressTypeCode", "address1_addresstypecode", value);
            }
        }
		
        /// <summary>
        /// Город для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
        public string Address1_City
        {
            get
            {
                return this.GetAttributeValue<string>("address1_city");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_City", "address1_city", value);
            }
        }
		
        /// <summary>
        /// Страна или регион для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
        public string Address1_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address1_country");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Country", "address1_country", value);
            }
        }
		
        /// <summary>
        /// Округ для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
        public string Address1_County
        {
            get
            {
                return this.GetAttributeValue<string>("address1_county");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_County", "address1_county", value);
            }
        }
		
        /// <summary>
        /// Номер факса для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
        public string Address1_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address1_fax");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Fax", "address1_fax", value);
            }
        }
		
        /// <summary>
        /// Условия поставки для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
        public System.Nullable<int> Address1_FreightTermsCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_freighttermscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("Address1_FreightTermsCode", "address1_freighttermscode", value);
            }
        }
		
        /// <summary>
        /// Широта для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<double>>("Address1_Latitude", "address1_latitude", value);
            }
        }
		
        /// <summary>
        /// Первая строка для ввода сведений об адресе 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
        public string Address1_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line1");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Line1", "address1_line1", value);
            }
        }
		
        /// <summary>
        /// Вторая строка для ввода сведений об адресе 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
        public string Address1_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line2");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Line2", "address1_line2", value);
            }
        }
		
        /// <summary>
        /// Третья строка для ввода сведений об адресе 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
        public string Address1_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line3");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Line3", "address1_line3", value);
            }
        }
		
        /// <summary>
        /// Долгота для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<double>>("Address1_Longitude", "address1_longitude", value);
            }
        }
		
        /// <summary>
        /// Название, указываемое в адресе 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
        public string Address1_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address1_name");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Name", "address1_name", value);
            }
        }
		
        /// <summary>
        /// Почтовый индекс для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
        public string Address1_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postalcode");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_PostalCode", "address1_postalcode", value);
            }
        }
		
        /// <summary>
        /// Номер абонентского ящика для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postofficebox");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_PostOfficeBox", "address1_postofficebox", value);
            }
        }
		
        /// <summary>
        /// Имя основного контакта для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
        public string Address1_PrimaryContactName
        {
            get
            {
                return this.GetAttributeValue<string>("address1_primarycontactname");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_PrimaryContactName", "address1_primarycontactname", value);
            }
        }
		
        /// <summary>
        /// Способ поставки для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public System.Nullable<int> Address1_ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_shippingmethodcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("Address1_ShippingMethodCode", "address1_shippingmethodcode", value);
            }
        }
		
        /// <summary>
        /// Область, республика, край, округ для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address1_stateorprovince");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_StateOrProvince", "address1_stateorprovince", value);
            }
        }
		
        /// <summary>
        /// Первый номер телефона, связанный с адресом 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
        public string Address1_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone1");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Telephone1", "address1_telephone1", value);
            }
        }
		
        /// <summary>
        /// Второй номер телефона, связанный с адресом 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
        public string Address1_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone2");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Telephone2", "address1_telephone2", value);
            }
        }
		
        /// <summary>
        /// Третий номер телефона, связанный с адресом 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
        public string Address1_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone3");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_Telephone3", "address1_telephone3", value);
            }
        }
		
        /// <summary>
        /// Зона службы доставки UPS для адреса 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
        public string Address1_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address1_upszone");
            }
            set
            {
                this.SetAttributeValue<string>("Address1_UPSZone", "address1_upszone", value);
            }
        }
		
        /// <summary>
        /// Часовой пояс для адреса 1. Это разница между местным временем и временем в формате UTC.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("Address1_UTCOffset", "address1_utcoffset", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.Guid>>("Address2_AddressId", "address2_addressid", value);
            }
        }
		
        /// <summary>
        /// Type of address for address 2, such as billing, shipping, or primary address. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public System.Nullable<int> Address2_AddressTypeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_addresstypecode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("Address2_AddressTypeCode", "address2_addresstypecode", value);
            }
        }
		
        /// <summary>
        /// Город для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
        public string Address2_City
        {
            get
            {
                return this.GetAttributeValue<string>("address2_city");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_City", "address2_city", value);
            }
        }
		
        /// <summary>
        /// Страна или регион для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
        public string Address2_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address2_country");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Country", "address2_country", value);
            }
        }
		
        /// <summary>
        /// Округ для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
        public string Address2_County
        {
            get
            {
                return this.GetAttributeValue<string>("address2_county");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_County", "address2_county", value);
            }
        }
		
        /// <summary>
        /// Номер факса для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
        public string Address2_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address2_fax");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Fax", "address2_fax", value);
            }
        }
		
        /// <summary>
        /// Условия поставки для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
        public System.Nullable<int> Address2_FreightTermsCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_freighttermscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("Address2_FreightTermsCode", "address2_freighttermscode", value);
            }
        }
		
        /// <summary>
        /// Широта для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<double>>("Address2_Latitude", "address2_latitude", value);
            }
        }
		
        /// <summary>
        /// Первая строка для ввода сведений об адресе 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
        public string Address2_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line1");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Line1", "address2_line1", value);
            }
        }
		
        /// <summary>
        /// Вторая строка для ввода сведений об адресе 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
        public string Address2_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line2");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Line2", "address2_line2", value);
            }
        }
		
        /// <summary>
        /// Третья строка для ввода сведений об адресе 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
        public string Address2_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line3");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Line3", "address2_line3", value);
            }
        }
		
        /// <summary>
        /// Долгота для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<double>>("Address2_Longitude", "address2_longitude", value);
            }
        }
		
        /// <summary>
        /// Название, указываемое в адресе 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
        public string Address2_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address2_name");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Name", "address2_name", value);
            }
        }
		
        /// <summary>
        /// Почтовый индекс для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
        public string Address2_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postalcode");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_PostalCode", "address2_postalcode", value);
            }
        }
		
        /// <summary>
        /// Номер абонентского ящика для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postofficebox");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_PostOfficeBox", "address2_postofficebox", value);
            }
        }
		
        /// <summary>
        /// В данное поле через ; заносятся email адреса сотрудников, которые должны стоять в копи всех писем СП. Такие сотрудники должны быть ОБЯЗАТЕЛЬНО заведены в MS CRM в виде контактов. Иначе они не попадут
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
        public string Address2_PrimaryContactName
        {
            get
            {
                return this.GetAttributeValue<string>("address2_primarycontactname");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_PrimaryContactName", "address2_primarycontactname", value);
            }
        }
		
        /// <summary>
        /// Способ поставки для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public System.Nullable<int> Address2_ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_shippingmethodcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("Address2_ShippingMethodCode", "address2_shippingmethodcode", value);
            }
        }
		
        /// <summary>
        /// Область, республика, край, округ для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address2_stateorprovince");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_StateOrProvince", "address2_stateorprovince", value);
            }
        }
		
        /// <summary>
        /// Первый номер телефона, связанный с адресом 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
        public string Address2_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone1");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Telephone1", "address2_telephone1", value);
            }
        }
		
        /// <summary>
        /// Второй номер телефона, связанный с адресом 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
        public string Address2_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone2");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Telephone2", "address2_telephone2", value);
            }
        }
		
        /// <summary>
        /// Третий номер телефона, связанный с адресом 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
        public string Address2_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone3");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_Telephone3", "address2_telephone3", value);
            }
        }
		
        /// <summary>
        /// Зона службы доставки UPS для адреса 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
        public string Address2_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address2_upszone");
            }
            set
            {
                this.SetAttributeValue<string>("Address2_UPSZone", "address2_upszone", value);
            }
        }
		
        /// <summary>
        /// Часовой пояс для адреса 2. Это разница между местным временем и временем в формате UTC.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("Address2_UTCOffset", "address2_utcoffset", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyipaddress")]
        public string Adx_CreatedByIPAddress
        {
            get
            {
                return this.GetAttributeValue<string>("adx_createdbyipaddress");
            }
            set
            {
                this.SetAttributeValue<string>("Adx_CreatedByIPAddress", "adx_createdbyipaddress", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyusername")]
        public string Adx_CreatedByUsername
        {
            get
            {
                return this.GetAttributeValue<string>("adx_createdbyusername");
            }
            set
            {
                this.SetAttributeValue<string>("Adx_CreatedByUsername", "adx_createdbyusername", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_modifiedbyipaddress")]
        public string Adx_ModifiedByIPAddress
        {
            get
            {
                return this.GetAttributeValue<string>("adx_modifiedbyipaddress");
            }
            set
            {
                this.SetAttributeValue<string>("Adx_ModifiedByIPAddress", "adx_modifiedbyipaddress", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_modifiedbyusername")]
        public string Adx_ModifiedByUsername
        {
            get
            {
                return this.GetAttributeValue<string>("adx_modifiedbyusername");
            }
            set
            {
                this.SetAttributeValue<string>("Adx_ModifiedByUsername", "adx_modifiedbyusername", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
        public System.Nullable<decimal> Aging30
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("aging30");
            }
        }
		
        /// <summary>
        /// Эквивалент срока оплаты 30 для организации в базовой валюте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
        public System.Nullable<decimal> Aging30_Base
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("aging30_base");
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
        public System.Nullable<decimal> Aging60
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("aging60");
            }
        }
		
        /// <summary>
        /// Эквивалент срока оплаты 60 для организации в базовой валюте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
        public System.Nullable<decimal> Aging60_Base
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("aging60_base");
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
        public System.Nullable<decimal> Aging90
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("aging90");
            }
        }
		
        /// <summary>
        /// Эквивалент срока оплаты 90 для организации в базовой валюте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
        public System.Nullable<decimal> Aging90_Base
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("aging90_base");
            }
        }
		
        /// <summary>
        /// Тип бизнеса, связанный с этой организацией.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
        public System.Nullable<int> BusinessTypeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("businesstypecode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("BusinessTypeCode", "businesstypecode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Client.CrmEntityReference CreatedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }
		
        /// <summary>
        /// Дата и время создания организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор делегата, создавшего организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Client.CrmEntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }
		
        /// <summary>
        /// Кредитный лимит организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
        public System.Nullable<decimal> CreditLimit
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("creditlimit");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.Money>("CreditLimit", "creditlimit", value);
            }
        }
		
        /// <summary>
        /// Эквивалент кредитного лимита для организации в базовой валюте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
        public System.Nullable<decimal> CreditLimit_Base
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("creditlimit_base");
            }
        }
		
        /// <summary>
        /// Information about whether credit for the account is on hold. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
        public System.Nullable<bool> CreditOnHold
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("CreditOnHold", "creditonhold", value);
            }
        }
		
        /// <summary>
        /// Размер организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
        public System.Nullable<int> CustomerSizeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("customersizecode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("CustomerSizeCode", "customersizecode", value);
            }
        }
		
        /// <summary>
        /// Тип организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
        public System.Nullable<int> CustomerTypeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("customertypecode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("CustomerTypeCode", "customertypecode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор прайс-листа по умолчанию, связанного с организацией.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
        public Microsoft.Xrm.Client.CrmEntityReference DefaultPriceLevelId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("DefaultPriceLevelId", "defaultpricelevelid", value);
            }
        }
		
        /// <summary>
        /// Описание организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get
            {
                return this.GetAttributeValue<string>("description");
            }
            set
            {
                this.SetAttributeValue<string>("Description", "description", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли непосредственная рассылка сообщений в организацию по электронной почте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
        public System.Nullable<bool> DoNotBulkEMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DoNotBulkEMail", "donotbulkemail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли массовая отправка писем в организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
        public System.Nullable<bool> DoNotBulkPostalMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DoNotBulkPostalMail", "donotbulkpostalmail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли отправка электронной почты в организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DoNotEMail", "donotemail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли отправка факсов в организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DoNotFax", "donotfax", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешены ли телефонные звонки в организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DoNotPhone", "donotphone", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли отправка обычной почты в организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DoNotPostalMail", "donotpostalmail", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешено ли отправлять маркетинговую почту в организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
        public System.Nullable<bool> DoNotSendMM
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DoNotSendMM", "donotsendmm", value);
            }
        }
		
        /// <summary>
        /// Первый адрес электронной почты организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
        public string EMailAddress1
        {
            get
            {
                return this.GetAttributeValue<string>("emailaddress1");
            }
            set
            {
                this.SetAttributeValue<string>("EMailAddress1", "emailaddress1", value);
            }
        }
		
        /// <summary>
        /// Второй адрес электронной почты организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
        public string EMailAddress2
        {
            get
            {
                return this.GetAttributeValue<string>("emailaddress2");
            }
            set
            {
                this.SetAttributeValue<string>("EMailAddress2", "emailaddress2", value);
            }
        }
		
        /// <summary>
        /// Третий адрес электронной почты организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
        public string EMailAddress3
        {
            get
            {
                return this.GetAttributeValue<string>("emailaddress3");
            }
            set
            {
                this.SetAttributeValue<string>("EMailAddress3", "emailaddress3", value);
            }
        }
		
        /// <summary>
        /// Обменный курс для валюты, связанной с организацией, по отношению к базовой валюте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }
		
        /// <summary>
        /// Номер факса организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
        public string Fax
        {
            get
            {
                return this.GetAttributeValue<string>("fax");
            }
            set
            {
                this.SetAttributeValue<string>("Fax", "fax", value);
            }
        }
		
        /// <summary>
        /// URL-адрес FTP-сайта организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
        public string FtpSiteURL
        {
            get
            {
                return this.GetAttributeValue<string>("ftpsiteurl");
            }
            set
            {
                this.SetAttributeValue<string>("FtpSiteURL", "ftpsiteurl", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("ImportSequenceNumber", "importsequencenumber", value);
            }
        }
		
        /// <summary>
        /// Тип отрасли, с которой связана организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
        public System.Nullable<int> IndustryCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("industrycode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("IndustryCode", "industrycode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Конкурент, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_consolid")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_consolid
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_consolid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_consolid", "iok_consolid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_ofice_po_adoption_year")]
        public string iok_ofice_PO_adoption_year
        {
            get
            {
                return this.GetAttributeValue<string>("iok_ofice_po_adoption_year");
            }
            set
            {
                this.SetAttributeValue<string>("iok_ofice_PO_adoption_year", "iok_ofice_po_adoption_year", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Конкурент, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_po_logistic2")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_PO_logistic2
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_po_logistic2");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_PO_logistic2", "iok_po_logistic2", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Конкурент, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_tekushaya_sfa")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_tekushaya_SFA
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_tekushaya_sfa");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_tekushaya_SFA", "iok_tekushaya_sfa", value);
            }
        }
		
        /// <summary>
        /// Дата и время связи с организацией в ходе маркетинговой кампании.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
        public System.Nullable<System.DateTime> LastUsedInCampaign
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("LastUsedInCampaign", "lastusedincampaign", value);
            }
        }
		
        /// <summary>
        /// Рыночная капитализация организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap")]
        public System.Nullable<decimal> MarketCap
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("marketcap");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.Money>("MarketCap", "marketcap", value);
            }
        }
		
        /// <summary>
        /// Эквивалент рыночной капитализации организации в базовой валюте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap_base")]
        public System.Nullable<decimal> MarketCap_Base
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("marketcap_base");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор главной организации для слияния.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        public Microsoft.Xrm.Client.CrmEntityReference MasterId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
            }
        }
		
        /// <summary>
        /// Сведения о том, было ли выполнено слияние организации с главной организацией.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
        public System.Nullable<bool> Merged
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("merged");
            }
        }
		
        /// <summary>
        /// Unique identifier of the user who last modified the account. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Client.CrmEntityReference ModifiedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }
		
        /// <summary>
        /// Дата и время последнего изменения организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор делегата который последним изменил организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Client.CrmEntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }
		
        /// <summary>
        /// Unique identifier for Account associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msa_managingpartnerid")]
        public Microsoft.Xrm.Client.CrmEntityReference msa_managingpartnerid
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msa_managingpartnerid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msa_managingpartnerid", "msa_managingpartnerid", value);
            }
        }
		
        /// <summary>
        /// Название организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            set
            {
                this.SetAttributeValue<string>("Name", "name", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_1cid")]
        public string New_1CID
        {
            get
            {
                return this.GetAttributeValue<string>("new_1cid");
            }
            set
            {
                this.SetAttributeValue<string>("New_1CID", "new_1cid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_accoutsystem")]
        public System.Nullable<int> New_AccoutSystem
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_accoutsystem");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_AccoutSystem", "new_accoutsystem", value);
            }
        }
		
        /// <summary>
        /// Указывает источник, из которого клиент узнал о нас
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_advert")]
        public System.Nullable<int> New_Advert
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_advert");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_Advert", "new_advert", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_bp")]
        public System.Nullable<int> New_BP
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_bp");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_BP", "new_bp", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_brands")]
        public string New_Brands
        {
            get
            {
                return this.GetAttributeValue<string>("new_brands");
            }
            set
            {
                this.SetAttributeValue<string>("New_Brands", "new_brands", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Подразделение, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_businessunit_account")]
        public Microsoft.Xrm.Client.CrmEntityReference New_businessunit_account
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_businessunit_account");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_businessunit_account", "new_businessunit_account", value);
            }
        }
		
        /// <summary>
        /// код площадки из Чикаго. для свзик отчетности из crm и чикаго
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_code_chicago")]
        public string New_code_chicago
        {
            get
            {
                return this.GetAttributeValue<string>("new_code_chicago");
            }
            set
            {
                this.SetAttributeValue<string>("New_code_chicago", "new_code_chicago", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_contact_copy")]
        public string New_contact_copy
        {
            get
            {
                return this.GetAttributeValue<string>("new_contact_copy");
            }
            set
            {
                this.SetAttributeValue<string>("New_contact_copy", "new_contact_copy", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_contact_copy_data")]
        public string New_contact_copy_data
        {
            get
            {
                return this.GetAttributeValue<string>("new_contact_copy_data");
            }
            set
            {
                this.SetAttributeValue<string>("New_contact_copy_data", "new_contact_copy_data", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact")]
        public Microsoft.Xrm.Client.CrmEntityReference New_copy_letter_contact
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_copy_letter_contact");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_copy_letter_contact", "new_copy_letter_contact", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact1")]
        public Microsoft.Xrm.Client.CrmEntityReference New_copy_letter_contact1
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_copy_letter_contact1");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_copy_letter_contact1", "new_copy_letter_contact1", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact2")]
        public Microsoft.Xrm.Client.CrmEntityReference New_copy_letter_contact2
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_copy_letter_contact2");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_copy_letter_contact2", "new_copy_letter_contact2", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact3")]
        public Microsoft.Xrm.Client.CrmEntityReference New_copy_letter_contact3
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_copy_letter_contact3");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_copy_letter_contact3", "new_copy_letter_contact3", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact4")]
        public Microsoft.Xrm.Client.CrmEntityReference New_copy_letter_contact4
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_copy_letter_contact4");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_copy_letter_contact4", "new_copy_letter_contact4", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact5")]
        public Microsoft.Xrm.Client.CrmEntityReference New_copy_letter_contact5
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_copy_letter_contact5");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_copy_letter_contact5", "new_copy_letter_contact5", value);
            }
        }
		
        /// <summary>
        /// Список стран.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_countrylist")]
        public System.Nullable<int> new_countryList
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_countrylist");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("new_countryList", "new_countrylist", value);
            }
        }
		
        /// <summary>
        /// Дата приода с сайта зявки от этой организации
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_dateappearfromsite")]
        public System.Nullable<System.DateTime> New_DateAppearFromSite
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_dateappearfromsite");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("New_DateAppearFromSite", "new_dateappearfromsite", value);
            }
        }
		
        /// <summary>
        /// Дата Откакза 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datereject")]
        public System.Nullable<System.DateTime> New_datereject
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_datereject");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("New_datereject", "new_datereject", value);
            }
        }
		
        /// <summary>
        /// Кто внедрил проект: мы, партнер или клиент самостоятельно
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_depl")]
        public System.Nullable<int> New_Depl
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_depl");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_Depl", "new_depl", value);
            }
        }
		
        /// <summary>
        /// Дата окончания внедрения (первое из внедрений, если было несколько)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_deploymentfinishdate")]
        public System.Nullable<System.DateTime> New_DeploymentFinishDate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_deploymentfinishdate");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("New_DeploymentFinishDate", "new_deploymentfinishdate", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_distributed")]
        public System.Nullable<int> New_Distributed
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_distributed");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_Distributed", "new_distributed", value);
            }
        }
		
        /// <summary>
        /// Какой клиент
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_distributor")]
        public Microsoft.Xrm.Client.CrmEntityReference New_distributor
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_distributor");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_distributor", "new_distributor", value);
            }
        }
		
        /// <summary>
        /// Федеральный округ
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_district")]
        public System.Nullable<int> New_District
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_district");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_District", "new_district", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_focus_group")]
        public string New_focus_group
        {
            get
            {
                return this.GetAttributeValue<string>("new_focus_group");
            }
            set
            {
                this.SetAttributeValue<string>("New_focus_group", "new_focus_group", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_fromsite")]
        public System.Nullable<bool> New_fromSite
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_fromsite");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_fromSite", "new_fromsite", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_inn")]
        public string New_inn
        {
            get
            {
                return this.GetAttributeValue<string>("new_inn");
            }
            set
            {
                this.SetAttributeValue<string>("New_inn", "new_inn", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_involvement")]
        public System.Nullable<int> New_involvement
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_involvement");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_involvement", "new_involvement", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ka")]
        public System.Nullable<int> New_KA
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_ka");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_KA", "new_ka", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_kpp")]
        public string New_kpp
        {
            get
            {
                return this.GetAttributeValue<string>("new_kpp");
            }
            set
            {
                this.SetAttributeValue<string>("New_kpp", "new_kpp", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_manufacter")]
        public System.Nullable<int> New_Manufacter
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_manufacter");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_Manufacter", "new_manufacter", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_mobequipment")]
        public System.Nullable<int> New_MobEquipment
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_mobequipment");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_MobEquipment", "new_mobequipment", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_mobileos")]
        public System.Nullable<int> New_MobileOS
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_mobileos");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_MobileOS", "new_mobileos", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_nodeid")]
        public string New_nodeid
        {
            get
            {
                return this.GetAttributeValue<string>("new_nodeid");
            }
            set
            {
                this.SetAttributeValue<string>("New_nodeid", "new_nodeid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_numofbranches")]
        public System.Nullable<int> New_NumOfBranches
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_numofbranches");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_NumOfBranches", "new_numofbranches", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_numofdistr")]
        public System.Nullable<int> New_NumOfDistr
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_numofdistr");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_NumOfDistr", "new_numofdistr", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_numofsrs")]
        public System.Nullable<int> New_NumOfSRs
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_numofsrs");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_NumOfSRs", "new_numofsrs", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_numoftrucks")]
        public System.Nullable<int> New_NumOfTrucks
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_numoftrucks");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_NumOfTrucks", "new_numoftrucks", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_office_soft")]
        public System.Nullable<int> New_office_soft
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_office_soft");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_office_soft", "new_office_soft", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Организация, связанного с объектом Организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_parent_net")]
        public Microsoft.Xrm.Client.CrmEntityReference New_parent_net
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_parent_net");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_parent_net", "new_parent_net", value);
            }
        }
		
        /// <summary>
        /// Есть ли проблема в интеграции из Поддержка - Клиенты
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_integration")]
        public System.Nullable<bool> New_problem_integration
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_integration");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_integration", "new_problem_integration", value);
            }
        }
		
        /// <summary>
        /// Проект внедрения клиента в УФУ
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_project")]
        public System.Nullable<int> New_Project
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_project");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_Project", "new_project", value);
            }
        }
		
        /// <summary>
        /// Имя контакта, который может рассказать о нашей системе и утроить ее демонстрацию для потенциального клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_referencecontact")]
        public string New_ReferenceContact
        {
            get
            {
                return this.GetAttributeValue<string>("new_referencecontact");
            }
            set
            {
                this.SetAttributeValue<string>("New_ReferenceContact", "new_referencecontact", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_referencevisit")]
        public System.Nullable<int> New_ReferenceVisit
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_referencevisit");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_ReferenceVisit", "new_referencevisit", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_refusal")]
        public System.Nullable<int> New_refusal
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_refusal");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_refusal", "new_refusal", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_region")]
        public System.Nullable<int> New_Region
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_region");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_Region", "new_region", value);
            }
        }
		
        /// <summary>
        /// Фамилия отсветственного со стороны клиента
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_responsiblefromcustomer")]
        public string New_ResponsibleFromCustomer
        {
            get
            {
                return this.GetAttributeValue<string>("new_responsiblefromcustomer");
            }
            set
            {
                this.SetAttributeValue<string>("New_ResponsibleFromCustomer", "new_responsiblefromcustomer", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sale_method")]
        public System.Nullable<int> New_sale_method
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_sale_method");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_sale_method", "new_sale_method", value);
            }
        }
		
        /// <summary>
        /// для производителя - это система автоматизации его ЭТК и ШТП
        ///для дистрибьютора - это система автоматизации его ТП общего прайса
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sfa")]
        public System.Nullable<int> New_SFA
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_sfa");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_SFA", "new_sfa", value);
            }
        }
		
        /// <summary>
        /// Год начала внедрения текущей SFA
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sfaimplementyear")]
        public System.Nullable<int> New_sfaimplementyear
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_sfaimplementyear");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_sfaimplementyear", "new_sfaimplementyear", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_st")]
        public System.Nullable<int> New_St
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_st");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_St", "new_st", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_st_mt")]
        public System.Nullable<int> New_ST_MT
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_st_mt");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_ST_MT", "new_st_mt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_st_rel")]
        public System.Nullable<int> New_st_rel
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_st_rel");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_st_rel", "new_st_rel", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_statuslida")]
        public System.Nullable<int> new_statusLida
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_statuslida");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("new_statusLida", "new_statuslida", value);
            }
        }
		
        /// <summary>
        /// Расшифровка поля "Состояние отношений"
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_statusstate")]
        public System.Nullable<int> New_StatusState
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_statusstate");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_StatusState", "new_statusstate", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_structure")]
        public System.Nullable<int> New_structure
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_structure");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_structure", "new_structure", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_support_phone")]
        public string New_support_phone
        {
            get
            {
                return this.GetAttributeValue<string>("new_support_phone");
            }
            set
            {
                this.SetAttributeValue<string>("New_support_phone", "new_support_phone", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_tempfield")]
        public System.Nullable<bool> new_tempField
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_tempfield");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_tempField", "new_tempfield", value);
            }
        }
		
        /// <summary>
        /// Текстом, что используют.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_tlogisticsoftware")]
        public string New_TLogisticSoftware
        {
            get
            {
                return this.GetAttributeValue<string>("new_tlogisticsoftware");
            }
            set
            {
                this.SetAttributeValue<string>("New_TLogisticSoftware", "new_tlogisticsoftware", value);
            }
        }
		
        /// <summary>
        /// В этом поле указывается дата передачи на подержку.
        ///Поле заполняется инженером СП, принявшим дистибьютора на поддержку после внедрения. Проставляется дата того дня, когда инженер проверил материалы
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ttosupportdate")]
        public System.Nullable<System.DateTime> New_TToSupportDate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_ttosupportdate");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("New_TToSupportDate", "new_ttosupportdate", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_unformadress")]
        public string New_UnformAdress
        {
            get
            {
                return this.GetAttributeValue<string>("new_unformadress");
            }
            set
            {
                this.SetAttributeValue<string>("New_UnformAdress", "new_unformadress", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_unformphone")]
        public string New_UnformPhone
        {
            get
            {
                return this.GetAttributeValue<string>("new_unformphone");
            }
            set
            {
                this.SetAttributeValue<string>("New_UnformPhone", "new_unformphone", value);
            }
        }
		
        /// <summary>
        /// Указатель на то, что данная компания - клиент UPS LT
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_upsltaccount")]
        public System.Nullable<bool> New_UPSLTAccount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_upsltaccount");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_UPSLTAccount", "new_upsltaccount", value);
            }
        }
		
        /// <summary>
        /// Страна (-ны) в которых клиент автоматизирован по UPS LT в скобках количество машин/ТП. Например: "Бразилия (50 ТП), США (40 машин)"
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_upsltcountry")]
        public string New_UPSLTCountry
        {
            get
            {
                return this.GetAttributeValue<string>("new_upsltcountry");
            }
            set
            {
                this.SetAttributeValue<string>("New_UPSLTCountry", "new_upsltcountry", value);
            }
        }
		
        /// <summary>
        /// Количество сотрудников организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
        public System.Nullable<int> NumberOfEmployees
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("NumberOfEmployees", "numberofemployees", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор интереса, из которого была создана организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
        public Microsoft.Xrm.Client.CrmEntityReference OriginatingLeadId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("OriginatingLeadId", "originatingleadid", value);
            }
        }
		
        /// <summary>
        /// Дата и время переноса записи.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("OverriddenCreatedOn", "overriddencreatedon", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя или рабочей группы, ответственных за организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Client.CrmEntityReference OwnerId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("OwnerId", "ownerid", value);
            }
        }
		
        /// <summary>
        /// Тип собственности компании (например, государственная или частная).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
        public System.Nullable<int> OwnershipCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("ownershipcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("OwnershipCode", "ownershipcode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор подразделения, ответственного за организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningBusinessUnit
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор рабочей группы, ответственной за организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningTeam
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, ответственного за организацию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningUser
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор головной организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        public Microsoft.Xrm.Client.CrmEntityReference ParentAccountId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ParentAccountId", "parentaccountid", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, входит ли организация в правила бизнес-процесса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("ParticipatesInWorkflow", "participatesinworkflow", value);
            }
        }
		
        /// <summary>
        /// Условия оплаты для организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
        public System.Nullable<int> PaymentTermsCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("paymenttermscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PaymentTermsCode", "paymenttermscode", value);
            }
        }
		
        /// <summary>
        /// День недели, предпочитаемый организацией для планирования действий сервиса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
        public System.Nullable<int> PreferredAppointmentDayCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("preferredappointmentdaycode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PreferredAppointmentDayCode", "preferredappointmentdaycode", value);
            }
        }
		
        /// <summary>
        /// Время, предпочитаемое организацией для планирования действий сервиса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
        public System.Nullable<int> PreferredAppointmentTimeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("preferredappointmenttimecode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PreferredAppointmentTimeCode", "preferredappointmenttimecode", value);
            }
        }
		
        /// <summary>
        /// Предпочтительный способ связи с организацией.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
        public System.Nullable<int> PreferredContactMethodCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("preferredcontactmethodcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PreferredContactMethodCode", "preferredcontactmethodcode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор оборудования, предпочитаемого организацией для планирования действий сервиса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
        public Microsoft.Xrm.Client.CrmEntityReference PreferredEquipmentId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("PreferredEquipmentId", "preferredequipmentid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор сервиса, предпочитаемого организацией для планирования действий сервиса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
        public Microsoft.Xrm.Client.CrmEntityReference PreferredServiceId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("PreferredServiceId", "preferredserviceid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя системы, предпочитаемого организацией для планирования действий сервиса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
        public Microsoft.Xrm.Client.CrmEntityReference PreferredSystemUserId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("PreferredSystemUserId", "preferredsystemuserid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор основного контакта организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
        public Microsoft.Xrm.Client.CrmEntityReference PrimaryContactId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("PrimaryContactId", "primarycontactid", value);
            }
        }
		
        /// <summary>
        /// Сумма дохода организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
        public System.Nullable<decimal> Revenue
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("revenue");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.Money>("Revenue", "revenue", value);
            }
        }
		
        /// <summary>
        /// Эквивалент суммы выручки организации в базовой валюте.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
        public System.Nullable<decimal> Revenue_Base
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("revenue_base");
            }
        }
		
        /// <summary>
        /// Акции организации в обращении.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharesoutstanding")]
        public System.Nullable<int> SharesOutstanding
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("sharesoutstanding");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("SharesOutstanding", "sharesoutstanding", value);
            }
        }
		
        /// <summary>
        /// Способ поставки для организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
        public System.Nullable<int> ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("shippingmethodcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ShippingMethodCode", "shippingmethodcode", value);
            }
        }
		
        /// <summary>
        /// Код отрасли организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
        public string SIC
        {
            get
            {
                return this.GetAttributeValue<string>("sic");
            }
            set
            {
                this.SetAttributeValue<string>("SIC", "sic", value);
            }
        }
		
        /// <summary>
        /// Состояние организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<int> StateCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("statecode");
            }
        }
		
        /// <summary>
        /// Причина состояния организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public System.Nullable<int> StatusCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("statuscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("StatusCode", "statuscode", value);
            }
        }
		
        /// <summary>
        /// Фондовая биржа, на которой зарегистрирована компания, связанная с организацией.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
        public string StockExchange
        {
            get
            {
                return this.GetAttributeValue<string>("stockexchange");
            }
            set
            {
                this.SetAttributeValue<string>("StockExchange", "stockexchange", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_equipment_type_mt3")]
        public System.Nullable<int> svk_equipment_type_MT3
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_equipment_type_mt3");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_equipment_type_MT3", "svk_equipment_type_mt3", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_ko_date")]
        public System.Nullable<System.DateTime> svk_ko_date
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("svk_ko_date");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("svk_ko_date", "svk_ko_date", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt2_adoption")]
        public System.Nullable<int> svk_mt2_adoption
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt2_adoption");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_mt2_adoption", "svk_mt2_adoption", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt2_equipment_type")]
        public System.Nullable<int> svk_mt2_equipment_type
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt2_equipment_type");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_mt2_equipment_type", "svk_mt2_equipment_type", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt2_licenses")]
        public System.Nullable<int> svk_mt2_licenses
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt2_licenses");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("svk_mt2_licenses", "svk_mt2_licenses", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt2_os_type")]
        public System.Nullable<int> svk_mt2_OS_type
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt2_os_type");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_mt2_OS_type", "svk_mt2_os_type", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt3_adoption")]
        public System.Nullable<int> svk_mt3_adoption
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt3_adoption");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_mt3_adoption", "svk_mt3_adoption", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt3_licenses")]
        public System.Nullable<int> svk_mt3_licenses
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt3_licenses");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("svk_mt3_licenses", "svk_mt3_licenses", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt3_os_type")]
        public System.Nullable<int> svk_mt3_os_type
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt3_os_type");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_mt3_os_type", "svk_mt3_os_type", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_mt3_version")]
        public System.Nullable<int> svk_mt3_version
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_mt3_version");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_mt3_version", "svk_mt3_version", value);
            }
        }
		
        /// <summary>
        /// пиклист с выбором проекта. строится из набора параметров "Project_Global"
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_project")]
        public System.Nullable<int> svk_project
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_project");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_project", "svk_project", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_unavtomated_agents")]
        public System.Nullable<int> svk_unavtomated_agents
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_unavtomated_agents");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("svk_unavtomated_agents", "svk_unavtomated_agents", value);
            }
        }
		
        /// <summary>
        /// Первый номер телефона организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
        public string Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("telephone1");
            }
            set
            {
                this.SetAttributeValue<string>("Telephone1", "telephone1", value);
            }
        }
		
        /// <summary>
        /// Второй номер телефона организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
        public string Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("telephone2");
            }
            set
            {
                this.SetAttributeValue<string>("Telephone2", "telephone2", value);
            }
        }
		
        /// <summary>
        /// Третий номер телефона организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
        public string Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("telephone3");
            }
            set
            {
                this.SetAttributeValue<string>("Telephone3", "telephone3", value);
            }
        }
		
        /// <summary>
        /// Территория, на которой находится организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
        public System.Nullable<int> TerritoryCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("territorycode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("TerritoryCode", "territorycode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор территории, на которой находится организация.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        public Microsoft.Xrm.Client.CrmEntityReference TerritoryId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("TerritoryId", "territoryid", value);
            }
        }
		
        /// <summary>
        /// Символ организации на фондовой бирже.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
        public string TickerSymbol
        {
            get
            {
                return this.GetAttributeValue<string>("tickersymbol");
            }
            set
            {
                this.SetAttributeValue<string>("TickerSymbol", "tickersymbol", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("TimeZoneRuleVersionNumber", "timezoneruleversionnumber", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор валюты, связанной с организацией.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Client.CrmEntityReference TransactionCurrencyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("TransactionCurrencyId", "transactioncurrencyid", value);
            }
        }
		
        /// <summary>
        /// Код часового пояса, использовавшийся при создании записи.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("UTCConversionTimeZoneCode", "utcconversiontimezonecode", value);
            }
        }
		
        /// <summary>
        /// Номер версии организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }
		
        /// <summary>
        /// URL-адрес веб-сайта организации.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
        public string WebSiteURL
        {
            get
            {
                return this.GetAttributeValue<string>("websiteurl");
            }
            set
            {
                this.SetAttributeValue<string>("WebSiteURL", "websiteurl", value);
            }
        }
		
        /// <summary>
        /// Фонетическая транскрипция названия организации, написанная символами хираганы или катаканы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
        public string YomiName
        {
            get
            {
                return this.GetAttributeValue<string>("yominame");
            }
            set
            {
                this.SetAttributeValue<string>("YomiName", "yominame", value);
            }
        }
		
        /// <summary>
        /// 1:N account_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> account_activity_parties
        {
            get
            {
                return this.GetRelatedEntities<ActivityParty>("account_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityParty>("account_activity_parties", "account_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Account_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Account_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("Account_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("Account_ActivityPointers", "Account_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Account_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Account_Annotation
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("Account_Annotation", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("Account_Annotation", "Account_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Account_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Account_Emails
        {
            get
            {
                return this.GetRelatedEntities<Email>("Account_Emails", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("Account_Emails", "Account_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N account_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_iok_action_send_SMSes")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> account_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("account_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("account_iok_action_send_SMSes", "account_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// 1:N account_master_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Account> Referencedaccount_master_account
        {
            get
            {
                return this.GetRelatedEntities<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<Account>("Referencedaccount_master_account", "account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N account_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Account> Referencedaccount_parent_account
        {
            get
            {
                return this.GetRelatedEntities<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<Account>("Referencedaccount_parent_account", "account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N contact_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Contact> contact_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Contact>("contact_customer_accounts", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("contact_customer_accounts", "contact_customer_accounts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N incident_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Incident> incident_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Incident>("incident_customer_accounts", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("incident_customer_accounts", "incident_customer_accounts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N msa_account_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_account_incident")]
        public System.Collections.Generic.IEnumerable<Incident> msa_account_incident
        {
            get
            {
                return this.GetRelatedEntities<Incident>("msa_account_incident", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("msa_account_incident", "msa_account_incident", null, value);
            }
        }
		
        /// <summary>
        /// 1:N msa_account_managingpartner
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Account> Referencedmsa_account_managingpartner
        {
            get
            {
                return this.GetRelatedEntities<Account>("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<Account>("Referencedmsa_account_managingpartner", "msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N msa_contact_managingpartner
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_contact_managingpartner")]
        public System.Collections.Generic.IEnumerable<Contact> msa_contact_managingpartner
        {
            get
            {
                return this.GetRelatedEntities<Contact>("msa_contact_managingpartner", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("msa_contact_managingpartner", "msa_contact_managingpartner", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_account_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_account_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Account> Referencednew_account_account
        {
            get
            {
                return this.GetRelatedEntities<Account>("new_account_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<Account>("Referencednew_account_account", "new_account_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N new_account_new_probe
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_account_new_probe")]
        public System.Collections.Generic.IEnumerable<New_Probe> new_account_new_probe
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("new_account_new_probe", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("new_account_new_probe", "new_account_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_account_svk_project
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_account_svk_project")]
        public System.Collections.Generic.IEnumerable<svk_project> new_account_svk_project
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("new_account_svk_project", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("new_account_svk_project", "new_account_svk_project", null, value);
            }
        }
		
        /// <summary>
        /// N:1 account_master_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Account Referencingaccount_master_account
        {
            get
            {
                return this.GetRelatedEntity<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }
		
        /// <summary>
        /// N:1 account_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Account Referencingaccount_parent_account
        {
            get
            {
                return this.GetRelatedEntity<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            set
            {
                this.SetRelatedEntity<Account>("Referencingaccount_parent_account", "account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
            }
        }
		
        /// <summary>
        /// N:1 account_primary_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
        public Contact account_primary_contact
        {
            get
            {
                return this.GetRelatedEntity<Contact>("account_primary_contact", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("account_primary_contact", "account_primary_contact", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_accountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
        public SystemUser lk_accountbase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_accountbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
        public SystemUser lk_accountbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_accountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
        public SystemUser lk_accountbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_accountbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
        public SystemUser lk_accountbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 msa_account_managingpartner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msa_managingpartnerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Account Referencingmsa_account_managingpartner
        {
            get
            {
                return this.GetRelatedEntity<Account>("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            set
            {
                this.SetRelatedEntity<Account>("Referencingmsa_account_managingpartner", "msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
            }
        }
		
        /// <summary>
        /// N:1 new_account_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_parent_net")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_account_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Account Referencingnew_account_account
        {
            get
            {
                return this.GetRelatedEntity<Account>("new_account_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            set
            {
                this.SetRelatedEntity<Account>("Referencingnew_account_account", "new_account_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_account")]
        public Contact new_contact_account
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_account", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_account", "new_contact_account", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_account1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact1")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_account1")]
        public Contact new_contact_account1
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_account1", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_account1", "new_contact_account1", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_account2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact2")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_account2")]
        public Contact new_contact_account2
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_account2", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_account2", "new_contact_account2", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_account3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact3")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_account3")]
        public Contact new_contact_account3
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_account3", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_account3", "new_contact_account3", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_account5
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact5")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_account5")]
        public Contact new_contact_account5
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_account5", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_account5", "new_contact_account5", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_copy_letter_contact4
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_copy_letter_contact4")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_copy_letter_contact4")]
        public Contact new_copy_letter_contact4
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_copy_letter_contact4", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_copy_letter_contact4", "new_copy_letter_contact4", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_new_probe_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_distributor")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_new_probe_account")]
        public New_Probe new_new_probe_account
        {
            get
            {
                return this.GetRelatedEntity<New_Probe>("new_new_probe_account", null);
            }
            set
            {
                this.SetRelatedEntity<New_Probe>("new_new_probe_account", "new_new_probe_account", null, value);
            }
        }
		
        /// <summary>
        /// N:1 system_user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
        public SystemUser system_user_accounts
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("system_user_accounts", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("system_user_accounts", "system_user_accounts", null, value);
            }
        }
		
        /// <summary>
        /// N:1 user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
        public SystemUser user_accounts
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("user_accounts", null);
            }
        }
    }
}