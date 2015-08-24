namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Пользователь, имеющий доступ к системе Microsoft CRM, которому принадлежат объекты в базе данных Microsoft CRM.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("SystemUserSet")]
    public partial class SystemUser : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUser() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "systemuser";
		
        public const int EntityTypeCode = 8;
		
        /// <summary>
        /// Тип пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
        public System.Nullable<int> AccessMode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("accessmode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("AccessMode", "accessmode", value);
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
        /// Страна/область в адресе 1.
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
        /// Unique identifier for address 2. 
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
        /// Страна/область в адресе 2.
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
        /// Уникальный идентификатор подразделения, с которым связан пользователь.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Client.CrmEntityReference BusinessUnitId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("BusinessUnitId", "businessunitid", value);
            }
        }
		
        /// <summary>
        /// Финансовый календарь, связанный с пользователем.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public Microsoft.Xrm.Client.CrmEntityReference CalendarId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("CalendarId", "calendarid", value);
            }
        }
		
        /// <summary>
        /// Тип лицензии пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
        public System.Nullable<int> CALType
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("caltype");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("CALType", "caltype", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего пользователя.
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
        /// Date and time when the user was created. 
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
        /// Уникальный идентификатор делегата, создавшего системного пользователя.
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
        /// Указывает на заполнение фильтров Outlook по умолчанию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
        public System.Nullable<bool> DefaultFiltersPopulated
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated");
            }
        }
		
        /// <summary>
        /// Reason for disabling the user. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
        public string DisabledReason
        {
            get
            {
                return this.GetAttributeValue<string>("disabledreason");
            }
        }
		
        /// <summary>
        /// Сведения, следует ли отображать пользователя в представлениях сервиса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
        public System.Nullable<bool> DisplayInServiceViews
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DisplayInServiceViews", "displayinserviceviews", value);
            }
        }
		
        /// <summary>
        /// Домен Active Directory, участником которого является пользователь.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
        public string DomainName
        {
            get
            {
                return this.GetAttributeValue<string>("domainname");
            }
            set
            {
                this.SetAttributeValue<string>("DomainName", "domainname", value);
            }
        }
		
        /// <summary>
        /// Отображает состояние основного адреса электронной почты.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
        public System.Nullable<int> EmailRouterAccessApproval
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("emailrouteraccessapproval");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("EmailRouterAccessApproval", "emailrouteraccessapproval", value);
            }
        }
		
        /// <summary>
        /// Код сотрудника пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
        public string EmployeeId
        {
            get
            {
                return this.GetAttributeValue<string>("employeeid");
            }
            set
            {
                this.SetAttributeValue<string>("EmployeeId", "employeeid", value);
            }
        }
		
        /// <summary>
        /// Курс обмена валюты, связанной с системным пользователем, по отношению к базовой валюте.
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
        /// Имя пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            get
            {
                return this.GetAttributeValue<string>("firstname");
            }
            set
            {
                this.SetAttributeValue<string>("FirstName", "firstname", value);
            }
        }
		
        /// <summary>
        /// ФИО пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            get
            {
                return this.GetAttributeValue<string>("fullname");
            }
        }
		
        /// <summary>
        /// Government identifier for the user. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
        public string GovernmentId
        {
            get
            {
                return this.GetAttributeValue<string>("governmentid");
            }
            set
            {
                this.SetAttributeValue<string>("GovernmentId", "governmentid", value);
            }
        }
		
        /// <summary>
        /// Номер домашнего телефона пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
        public string HomePhone
        {
            get
            {
                return this.GetAttributeValue<string>("homephone");
            }
            set
            {
                this.SetAttributeValue<string>("HomePhone", "homephone", value);
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
        /// Способ доставки входящей почты для пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
        public System.Nullable<int> IncomingEmailDeliveryMethod
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("incomingemaildeliverymethod");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("IncomingEmailDeliveryMethod", "incomingemaildeliverymethod", value);
            }
        }
		
        /// <summary>
        /// Внутренний адрес электронной почты пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
        public string InternalEMailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("internalemailaddress");
            }
            set
            {
                this.SetAttributeValue<string>("InternalEMailAddress", "internalemailaddress", value);
            }
        }
		
        /// <summary>
        /// Состояние приглашения пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
        public System.Nullable<int> InviteStatusCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("invitestatuscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("InviteStatusCode", "invitestatuscode", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_user_online")]
        public System.Nullable<bool> iok_user_online
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("iok_user_online");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("iok_user_online", "iok_user_online", value);
            }
        }
		
        /// <summary>
        /// Сведения об активации пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
            }
        }
		
        /// <summary>
        /// Отметьте, если пользователь является пользователем-интегратором.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
        public System.Nullable<bool> IsIntegrationUser
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsIntegrationUser", "isintegrationuser", value);
            }
        }
		
        /// <summary>
        /// Сведения о наличии лицензии у данного пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
        public System.Nullable<bool> IsLicensed
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsLicensed", "islicensed", value);
            }
        }
		
        /// <summary>
        /// Информация о синхронизации пользователя с каталогом.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
        public System.Nullable<bool> IsSyncWithDirectory
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsSyncWithDirectory", "issyncwithdirectory", value);
            }
        }
		
        /// <summary>
        /// Job title of the user. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
        public string JobTitle
        {
            get
            {
                return this.GetAttributeValue<string>("jobtitle");
            }
            set
            {
                this.SetAttributeValue<string>("JobTitle", "jobtitle", value);
            }
        }
		
        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            get
            {
                return this.GetAttributeValue<string>("lastname");
            }
            set
            {
                this.SetAttributeValue<string>("LastName", "lastname", value);
            }
        }
		
        /// <summary>
        /// Отчество пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
        public string MiddleName
        {
            get
            {
                return this.GetAttributeValue<string>("middlename");
            }
            set
            {
                this.SetAttributeValue<string>("MiddleName", "middlename", value);
            }
        }
		
        /// <summary>
        /// Адрес электронной почты оповещения мобильного устройства пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
        public string MobileAlertEMail
        {
            get
            {
                return this.GetAttributeValue<string>("mobilealertemail");
            }
            set
            {
                this.SetAttributeValue<string>("MobileAlertEMail", "mobilealertemail", value);
            }
        }
		
        /// <summary>
        /// Номер мобильного телефона пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
        public string MobilePhone
        {
            get
            {
                return this.GetAttributeValue<string>("mobilephone");
            }
            set
            {
                this.SetAttributeValue<string>("MobilePhone", "mobilephone", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, внесшего последнее изменение в пользователя.
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
        /// Date and time when the user was last modified. 
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
        /// Уникальный идентификатор делегата, внесшего последнее изменение в системного пользователя.
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
        /// Сред. затраченное время
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_averagetimeincident")]
        public System.Nullable<int> new_AverageTimeIncident
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_averagetimeincident");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_AverageTimeIncident", "new_averagetimeincident", value);
            }
        }
		
        /// <summary>
        /// Сред. затраченное время Крафт
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_averagetimeincidentkraft")]
        public System.Nullable<int> new_AverageTimeIncidentKraft
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_averagetimeincidentkraft");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_AverageTimeIncidentKraft", "new_averagetimeincidentkraft", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_otsutstvie_s")]
        public System.Nullable<System.DateTime> new_otsutstvie_s
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_otsutstvie_s");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("new_otsutstvie_s", "new_otsutstvie_s", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_otsutstvuet_po")]
        public System.Nullable<System.DateTime> new_otsutstvuet_po
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_otsutstvuet_po");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("new_otsutstvuet_po", "new_otsutstvuet_po", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_prichina_otsutstviya")]
        public System.Nullable<int> new_prichina_otsutstviya
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_prichina_otsutstviya");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("new_prichina_otsutstviya", "new_prichina_otsutstviya", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_rol_tehpodderzhka")]
        public System.Nullable<int> New_rol_tehpodderzhka
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_rol_tehpodderzhka");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_rol_tehpodderzhka", "new_rol_tehpodderzhka", value);
            }
        }
		
        /// <summary>
        /// Salutation for correspondence with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_salutation")]
        public System.Nullable<int> New_salutation
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_salutation");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_salutation", "new_salutation", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_shtraf_begin")]
        public System.Nullable<System.DateTime> new_shtraf_begin
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_shtraf_begin");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("new_shtraf_begin", "new_shtraf_begin", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sip")]
        public System.Nullable<int> new_sip
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_sip");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_sip", "new_sip", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_userid_portal")]
        public System.Nullable<int> new_userid_portal
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_userid_portal");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_userid_portal", "new_userid_portal", value);
            }
        }
		
        /// <summary>
        /// Псевдоним пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
        public string NickName
        {
            get
            {
                return this.GetAttributeValue<string>("nickname");
            }
            set
            {
                this.SetAttributeValue<string>("NickName", "nickname", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор организации, связанной с пользователем.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
            }
        }
		
        /// <summary>
        /// Способ доставки исходящей почты для пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
        public System.Nullable<int> OutgoingEmailDeliveryMethod
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("outgoingemaildeliverymethod");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("OutgoingEmailDeliveryMethod", "outgoingemaildeliverymethod", value);
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
        /// Уникальный идентификатор руководителя пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        public Microsoft.Xrm.Client.CrmEntityReference ParentSystemUserId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ParentSystemUserId", "parentsystemuserid", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
        public System.Nullable<int> PassportHi
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passporthi");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("PassportHi", "passporthi", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
        public System.Nullable<int> PassportLo
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passportlo");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("PassportLo", "passportlo", value);
            }
        }
		
        /// <summary>
        /// Личный адрес электронной почты пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
        public string PersonalEMailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("personalemailaddress");
            }
            set
            {
                this.SetAttributeValue<string>("PersonalEMailAddress", "personalemailaddress", value);
            }
        }
		
        /// <summary>
        /// URL for the Web site on which a photo of the user is located. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
        public string PhotoUrl
        {
            get
            {
                return this.GetAttributeValue<string>("photourl");
            }
            set
            {
                this.SetAttributeValue<string>("PhotoUrl", "photourl", value);
            }
        }
		
        /// <summary>
        /// Предпочтительный адрес пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
        public System.Nullable<int> PreferredAddressCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("preferredaddresscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PreferredAddressCode", "preferredaddresscode", value);
            }
        }
		
        /// <summary>
        /// Предпочтительный адрес электронной почты пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
        public System.Nullable<int> PreferredEmailCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("preferredemailcode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PreferredEmailCode", "preferredemailcode", value);
            }
        }
		
        /// <summary>
        /// Предпочтительный номер телефона пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
        public System.Nullable<int> PreferredPhoneCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("preferredphonecode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PreferredPhoneCode", "preferredphonecode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор очереди по умолчанию пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Client.CrmEntityReference QueueId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("QueueId", "queueid", value);
            }
        }
		
        /// <summary>
        /// Обращение для ведения переписки с пользователем.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
        public string Salutation
        {
            get
            {
                return this.GetAttributeValue<string>("salutation");
            }
            set
            {
                this.SetAttributeValue<string>("Salutation", "salutation", value);
            }
        }
		
        /// <summary>
        /// Отметьте, если пользователь является пользователем-установщиком.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
        public System.Nullable<bool> SetupUser
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("setupuser");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("SetupUser", "setupuser", value);
            }
        }
		
        /// <summary>
        /// Место, в котором находится пользователь.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Client.CrmEntityReference SiteId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("SiteId", "siteid", value);
            }
        }
		
        /// <summary>
        /// Набор навыков пользователя.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
        public string Skills
        {
            get
            {
                return this.GetAttributeValue<string>("skills");
            }
            set
            {
                this.SetAttributeValue<string>("Skills", "skills", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_support_line")]
        public System.Nullable<int> svk_support_line
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_support_line");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_support_line", "svk_support_line", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for the user. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("SystemUserId", "systemuserid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SystemUserId = value;
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор территории, которой назначен пользователь.
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
        /// Обращение к пользователю.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get
            {
                return this.GetAttributeValue<string>("title");
            }
            set
            {
                this.SetAttributeValue<string>("Title", "title", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор валюты, связанной с системным пользователем.
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
        /// Номер версии пользователя.
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
        /// Windows Live ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
        public string WindowsLiveID
        {
            get
            {
                return this.GetAttributeValue<string>("windowsliveid");
            }
            set
            {
                this.SetAttributeValue<string>("WindowsLiveID", "windowsliveid", value);
            }
        }
		
        /// <summary>
        /// Адрес электронной почты имени входа в Yammer пользователям
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeremailaddress")]
        public string YammerEmailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("yammeremailaddress");
            }
            set
            {
                this.SetAttributeValue<string>("YammerEmailAddress", "yammeremailaddress", value);
            }
        }
		
        /// <summary>
        /// Код пользователя в Yammer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeruserid")]
        public string YammerUserId
        {
            get
            {
                return this.GetAttributeValue<string>("yammeruserid");
            }
            set
            {
                this.SetAttributeValue<string>("YammerUserId", "yammeruserid", value);
            }
        }
		
        /// <summary>
        /// Фонетическое имя пользователя, записанное фонетическими знаками хираганы или катаканы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            get
            {
                return this.GetAttributeValue<string>("yomifirstname");
            }
            set
            {
                this.SetAttributeValue<string>("YomiFirstName", "yomifirstname", value);
            }
        }
		
        /// <summary>
        /// Фонетическое полное имя пользователя, записанное фонетическими знаками хираганы или катаканы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            get
            {
                return this.GetAttributeValue<string>("yomifullname");
            }
        }
		
        /// <summary>
        /// Фонетическая фамилия пользователя, записанная фонетическими знаками хираганы или катаканы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            get
            {
                return this.GetAttributeValue<string>("yomilastname");
            }
            set
            {
                this.SetAttributeValue<string>("YomiLastName", "yomilastname", value);
            }
        }
		
        /// <summary>
        /// Фонетическое отчество пользователя, записанное фонетическими знаками хираганы или катаканы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
        public string YomiMiddleName
        {
            get
            {
                return this.GetAttributeValue<string>("yomimiddlename");
            }
            set
            {
                this.SetAttributeValue<string>("YomiMiddleName", "yomimiddlename", value);
            }
        }
		
        /// <summary>
        /// 1:N adx_systemuser_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_systemuser_contact")]
        public System.Collections.Generic.IEnumerable<Contact> adx_systemuser_contact
        {
            get
            {
                return this.GetRelatedEntities<Contact>("adx_systemuser_contact", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("adx_systemuser_contact", "adx_systemuser_contact", null, value);
            }
        }
		
        /// <summary>
        /// 1:N annotation_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("annotation_owning_user")]
        public System.Collections.Generic.IEnumerable<Annotation> annotation_owning_user
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("annotation_owning_user", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("annotation_owning_user", "annotation_owning_user", null, value);
            }
        }
		
        /// <summary>
        /// 1:N contact_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
        public System.Collections.Generic.IEnumerable<Contact> contact_owning_user
        {
            get
            {
                return this.GetRelatedEntities<Contact>("contact_owning_user", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("contact_owning_user", "contact_owning_user", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_action_send_sms_systemuser_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_createdby")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_action_send_sms_systemuser_createdby
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_createdby", "iok_action_send_sms_systemuser_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_action_send_sms_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_action_send_sms_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_createdonbehalfby", "iok_action_send_sms_systemuser_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_action_send_sms_systemuser_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_modifiedby")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_action_send_sms_systemuser_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_modifiedby", "iok_action_send_sms_systemuser_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_action_send_sms_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_action_send_sms_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_modifiedonbehalfby", "iok_action_send_sms_systemuser_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_action_send_sms_systemuser_owninguser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_owninguser")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_action_send_sms_systemuser_owninguser
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_owninguser", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_systemuser_owninguser", "iok_action_send_sms_systemuser_owninguser", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_accountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<Account>("lk_accountbase_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("lk_accountbase_createdby", "lk_accountbase_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_accountbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", "lk_accountbase_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_accountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<Account>("lk_accountbase_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("lk_accountbase_modifiedby", "lk_accountbase_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_accountbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", "lk_accountbase_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_activitypointer_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_createdby
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_createdby", "lk_activitypointer_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_activitypointer_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_createdonbehalfby", "lk_activitypointer_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_activitypointer_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedby", "lk_activitypointer_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_activitypointer_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedonbehalfby", "lk_activitypointer_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_annotationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("lk_annotationbase_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("lk_annotationbase_createdby", "lk_annotationbase_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_annotationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("lk_annotationbase_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("lk_annotationbase_createdonbehalfby", "lk_annotationbase_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_annotationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("lk_annotationbase_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("lk_annotationbase_modifiedby", "lk_annotationbase_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_annotationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("lk_annotationbase_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("lk_annotationbase_modifiedonbehalfby", "lk_annotationbase_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_contact_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contact_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Contact>("lk_contact_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("lk_contact_createdonbehalfby", "lk_contact_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_contact_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contact_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", "lk_contact_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_contactbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contactbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<Contact>("lk_contactbase_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("lk_contactbase_createdby", "lk_contactbase_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_contactbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contactbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<Contact>("lk_contactbase_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("lk_contactbase_modifiedby", "lk_contactbase_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_email_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_createdby
        {
            get
            {
                return this.GetRelatedEntities<Email>("lk_email_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("lk_email_createdby", "lk_email_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_email_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Email>("lk_email_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("lk_email_createdonbehalfby", "lk_email_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_email_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<Email>("lk_email_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("lk_email_modifiedby", "lk_email_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_email_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Email>("lk_email_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("lk_email_modifiedonbehalfby", "lk_email_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_incidentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<Incident>("lk_incidentbase_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("lk_incidentbase_createdby", "lk_incidentbase_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_incidentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Incident>("lk_incidentbase_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("lk_incidentbase_createdonbehalfby", "lk_incidentbase_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_incidentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<Incident>("lk_incidentbase_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("lk_incidentbase_modifiedby", "lk_incidentbase_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_incidentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<Incident>("lk_incidentbase_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("lk_incidentbase_modifiedonbehalfby", "lk_incidentbase_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_iok_getphonecall_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_createdby")]
        public System.Collections.Generic.IEnumerable<iok_getphonecall> lk_iok_getphonecall_createdby
        {
            get
            {
                return this.GetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_createdby", "lk_iok_getphonecall_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_iok_getphonecall_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<iok_getphonecall> lk_iok_getphonecall_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_createdonbehalfby", "lk_iok_getphonecall_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_iok_getphonecall_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_modifiedby")]
        public System.Collections.Generic.IEnumerable<iok_getphonecall> lk_iok_getphonecall_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_modifiedby", "lk_iok_getphonecall_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_iok_getphonecall_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<iok_getphonecall> lk_iok_getphonecall_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<iok_getphonecall>("lk_iok_getphonecall_modifiedonbehalfby", "lk_iok_getphonecall_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_probe_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_createdby")]
        public System.Collections.Generic.IEnumerable<New_Probe> lk_new_probe_createdby
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("lk_new_probe_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("lk_new_probe_createdby", "lk_new_probe_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_probe_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<New_Probe> lk_new_probe_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("lk_new_probe_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("lk_new_probe_createdonbehalfby", "lk_new_probe_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_probe_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_modifiedby")]
        public System.Collections.Generic.IEnumerable<New_Probe> lk_new_probe_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("lk_new_probe_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("lk_new_probe_modifiedby", "lk_new_probe_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_probe_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<New_Probe> lk_new_probe_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("lk_new_probe_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("lk_new_probe_modifiedonbehalfby", "lk_new_probe_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_shtrafy_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_createdby")]
        public System.Collections.Generic.IEnumerable<new_shtrafy> lk_new_shtrafy_createdby
        {
            get
            {
                return this.GetRelatedEntities<new_shtrafy>("lk_new_shtrafy_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<new_shtrafy>("lk_new_shtrafy_createdby", "lk_new_shtrafy_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_shtrafy_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<new_shtrafy> lk_new_shtrafy_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<new_shtrafy>("lk_new_shtrafy_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<new_shtrafy>("lk_new_shtrafy_createdonbehalfby", "lk_new_shtrafy_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_shtrafy_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_modifiedby")]
        public System.Collections.Generic.IEnumerable<new_shtrafy> lk_new_shtrafy_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<new_shtrafy>("lk_new_shtrafy_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<new_shtrafy>("lk_new_shtrafy_modifiedby", "lk_new_shtrafy_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_new_shtrafy_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<new_shtrafy> lk_new_shtrafy_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<new_shtrafy>("lk_new_shtrafy_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<new_shtrafy>("lk_new_shtrafy_modifiedonbehalfby", "lk_new_shtrafy_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_svk_project_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_createdby")]
        public System.Collections.Generic.IEnumerable<svk_project> lk_svk_project_createdby
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("lk_svk_project_createdby", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("lk_svk_project_createdby", "lk_svk_project_createdby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_svk_project_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<svk_project> lk_svk_project_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("lk_svk_project_createdonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("lk_svk_project_createdonbehalfby", "lk_svk_project_createdonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_svk_project_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_modifiedby")]
        public System.Collections.Generic.IEnumerable<svk_project> lk_svk_project_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("lk_svk_project_modifiedby", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("lk_svk_project_modifiedby", "lk_svk_project_modifiedby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_svk_project_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<svk_project> lk_svk_project_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("lk_svk_project_modifiedonbehalfby", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("lk_svk_project_modifiedonbehalfby", "lk_svk_project_modifiedonbehalfby", null, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<SystemUser>("Referencedlk_systemuser_createdonbehalfby", "lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<SystemUser>("Referencedlk_systemuser_modifiedonbehalfby", "lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<SystemUser>("Referencedlk_systemuserbase_createdby", "lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<SystemUser>("Referencedlk_systemuserbase_modifiedby", "lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident", "new_systemuser_incident", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident_Kto_hochet_znat
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident_Kto_hochet_znat")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident_Kto_hochet_znat
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident_Kto_hochet_znat", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident_Kto_hochet_znat", "new_systemuser_incident_Kto_hochet_znat", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident_last_owner
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident_last_owner")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident_last_owner
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident_last_owner", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident_last_owner", "new_systemuser_incident_last_owner", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident_observer1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident_observer1")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident_observer1
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident_observer1", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident_observer1", "new_systemuser_incident_observer1", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident_owner_substitution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident_owner_substitution")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident_owner_substitution
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident_owner_substitution", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident_owner_substitution", "new_systemuser_incident_owner_substitution", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident_povtorno_otkr
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident_povtorno_otkr")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident_povtorno_otkr
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident_povtorno_otkr", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident_povtorno_otkr", "new_systemuser_incident_povtorno_otkr", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident_povtorno_otkr_2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident_povtorno_otkr_2")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident_povtorno_otkr_2
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident_povtorno_otkr_2", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident_povtorno_otkr_2", "new_systemuser_incident_povtorno_otkr_2", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_incident_tester
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_incident_tester")]
        public System.Collections.Generic.IEnumerable<Incident> new_systemuser_incident_tester
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_systemuser_incident_tester", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_systemuser_incident_tester", "new_systemuser_incident_tester", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_new_probe
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_new_probe")]
        public System.Collections.Generic.IEnumerable<New_Probe> new_systemuser_new_probe
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("new_systemuser_new_probe", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("new_systemuser_new_probe", "new_systemuser_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_new_probe_insurance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_new_probe_insurance")]
        public System.Collections.Generic.IEnumerable<New_Probe> new_systemuser_new_probe_insurance
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("new_systemuser_new_probe_insurance", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("new_systemuser_new_probe_insurance", "new_systemuser_new_probe_insurance", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_systemuser_new_probe_vnedrenec
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_new_probe_vnedrenec")]
        public System.Collections.Generic.IEnumerable<New_Probe> new_systemuser_new_probe_vnedrenec
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("new_systemuser_new_probe_vnedrenec", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("new_systemuser_new_probe_vnedrenec", "new_systemuser_new_probe_vnedrenec", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_systemuser_new_probe_otvetstvenniy
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_new_probe_otvetstvenniy")]
        public System.Collections.Generic.IEnumerable<New_Probe> svk_systemuser_new_probe_otvetstvenniy
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("svk_systemuser_new_probe_otvetstvenniy", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("svk_systemuser_new_probe_otvetstvenniy", "svk_systemuser_new_probe_otvetstvenniy", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_systemuser_svk_project
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_svk_project")]
        public System.Collections.Generic.IEnumerable<svk_project> svk_systemuser_svk_project
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("svk_systemuser_svk_project", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("svk_systemuser_svk_project", "svk_systemuser_svk_project", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_systemuser_svk_project_ruk
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_svk_project_ruk")]
        public System.Collections.Generic.IEnumerable<svk_project> svk_systemuser_svk_project_ruk
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("svk_systemuser_svk_project_ruk", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("svk_systemuser_svk_project_ruk", "svk_systemuser_svk_project_ruk", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_systemuser_svk_project_trp
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_svk_project_trp")]
        public System.Collections.Generic.IEnumerable<svk_project> svk_systemuser_svk_project_trp
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("svk_systemuser_svk_project_trp", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("svk_systemuser_svk_project_trp", "svk_systemuser_svk_project_trp", null, value);
            }
        }
		
        /// <summary>
        /// 1:N system_user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
        public System.Collections.Generic.IEnumerable<Account> system_user_accounts
        {
            get
            {
                return this.GetRelatedEntities<Account>("system_user_accounts", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("system_user_accounts", "system_user_accounts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N system_user_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> system_user_activity_parties
        {
            get
            {
                return this.GetRelatedEntities<ActivityParty>("system_user_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityParty>("system_user_activity_parties", "system_user_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// 1:N system_user_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
        public System.Collections.Generic.IEnumerable<Contact> system_user_contacts
        {
            get
            {
                return this.GetRelatedEntities<Contact>("system_user_contacts", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("system_user_contacts", "system_user_contacts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N system_user_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> system_user_incidents
        {
            get
            {
                return this.GetRelatedEntities<Incident>("system_user_incidents", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("system_user_incidents", "system_user_incidents", null, value);
            }
        }
		
        /// <summary>
        /// 1:N user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
        public System.Collections.Generic.IEnumerable<Account> user_accounts
        {
            get
            {
                return this.GetRelatedEntities<Account>("user_accounts", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("user_accounts", "user_accounts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N user_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_activity")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> user_activity
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("user_activity", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("user_activity", "user_activity", null, value);
            }
        }
		
        /// <summary>
        /// 1:N user_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_email")]
        public System.Collections.Generic.IEnumerable<Email> user_email
        {
            get
            {
                return this.GetRelatedEntities<Email>("user_email", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("user_email", "user_email", null, value);
            }
        }
		
        /// <summary>
        /// 1:N user_iok_getphonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_iok_getphonecall")]
        public System.Collections.Generic.IEnumerable<iok_getphonecall> user_iok_getphonecall
        {
            get
            {
                return this.GetRelatedEntities<iok_getphonecall>("user_iok_getphonecall", null);
            }
            set
            {
                this.SetRelatedEntities<iok_getphonecall>("user_iok_getphonecall", "user_iok_getphonecall", null, value);
            }
        }
		
        /// <summary>
        /// 1:N user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referenceduser_parent_user
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.SetRelatedEntities<SystemUser>("Referenceduser_parent_user", "user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }
		
        /// <summary>
        /// N:1 lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }
		
        /// <summary>
        /// N:1 lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }
		
        /// <summary>
        /// N:1 lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }
		
        /// <summary>
        /// N:1 user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinguser_parent_user
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("Referencinguser_parent_user", "user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
            }
        }
    }
}