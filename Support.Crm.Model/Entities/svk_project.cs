namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Проекты поддержки
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("svk_project")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("svk_projectSet")]
    public partial class svk_project : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public svk_project() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "svk_project";
		
        public const int EntityTypeCode = 10052;
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего запись.
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
        /// Дата и время создания записи.
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
        /// Уникальный идентификатор пользователя-делегата, создавшего запись.
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
        /// Порядковый номер импорта, в результате которого была создана эта запись.
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
        /// Уникальный идентификатор пользователя, изменившего запись.
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
        /// Дата и время изменения записи.
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
        /// Уникальный идентификатор делегата, который изменил запись.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_1priority_business")]
        public string new_1priority_business
        {
            get
            {
                return this.GetAttributeValue<string>("new_1priority_business");
            }
            set
            {
                this.SetAttributeValue<string>("new_1priority_business", "new_1priority_business", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_1priority_reaction")]
        public string new_1priority_reaction
        {
            get
            {
                return this.GetAttributeValue<string>("new_1priority_reaction");
            }
            set
            {
                this.SetAttributeValue<string>("new_1priority_reaction", "new_1priority_reaction", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_1priority_time")]
        public string new_1priority_time
        {
            get
            {
                return this.GetAttributeValue<string>("new_1priority_time");
            }
            set
            {
                this.SetAttributeValue<string>("new_1priority_time", "new_1priority_time", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_2priority_business")]
        public string new_2priority_business
        {
            get
            {
                return this.GetAttributeValue<string>("new_2priority_business");
            }
            set
            {
                this.SetAttributeValue<string>("new_2priority_business", "new_2priority_business", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_2priority_reaction")]
        public string new_2priority_reaction
        {
            get
            {
                return this.GetAttributeValue<string>("new_2priority_reaction");
            }
            set
            {
                this.SetAttributeValue<string>("new_2priority_reaction", "new_2priority_reaction", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_2priority_time")]
        public string new_2priority_time
        {
            get
            {
                return this.GetAttributeValue<string>("new_2priority_time");
            }
            set
            {
                this.SetAttributeValue<string>("new_2priority_time", "new_2priority_time", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_3priority_business")]
        public string new_3priority_business
        {
            get
            {
                return this.GetAttributeValue<string>("new_3priority_business");
            }
            set
            {
                this.SetAttributeValue<string>("new_3priority_business", "new_3priority_business", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_3priority_reaction")]
        public string new_3priority_reaction
        {
            get
            {
                return this.GetAttributeValue<string>("new_3priority_reaction");
            }
            set
            {
                this.SetAttributeValue<string>("new_3priority_reaction", "new_3priority_reaction", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_3priority_time")]
        public string new_3priority_time
        {
            get
            {
                return this.GetAttributeValue<string>("new_3priority_time");
            }
            set
            {
                this.SetAttributeValue<string>("new_3priority_time", "new_3priority_time", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_4priority_business")]
        public string new_4priority_business
        {
            get
            {
                return this.GetAttributeValue<string>("new_4priority_business");
            }
            set
            {
                this.SetAttributeValue<string>("new_4priority_business", "new_4priority_business", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_4priority_reaction")]
        public string new_4priority_reaction
        {
            get
            {
                return this.GetAttributeValue<string>("new_4priority_reaction");
            }
            set
            {
                this.SetAttributeValue<string>("new_4priority_reaction", "new_4priority_reaction", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_4priority_time")]
        public string new_4priority_time
        {
            get
            {
                return this.GetAttributeValue<string>("new_4priority_time");
            }
            set
            {
                this.SetAttributeValue<string>("new_4priority_time", "new_4priority_time", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_actual_version_mt")]
        public string new_actual_version_mt
        {
            get
            {
                return this.GetAttributeValue<string>("new_actual_version_mt");
            }
            set
            {
                this.SetAttributeValue<string>("new_actual_version_mt", "new_actual_version_mt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_archive_agents")]
        public string new_archive_agents
        {
            get
            {
                return this.GetAttributeValue<string>("new_archive_agents");
            }
            set
            {
                this.SetAttributeValue<string>("new_archive_agents", "new_archive_agents", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_bd_chicago")]
        public string new_BD_Chicago
        {
            get
            {
                return this.GetAttributeValue<string>("new_bd_chicago");
            }
            set
            {
                this.SetAttributeValue<string>("new_BD_Chicago", "new_bd_chicago", value);
            }
        }
		
        /// <summary>
        /// Как обрабатываем обращения по замене оборудования
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_broken_kpk")]
        public string new_broken_kpk
        {
            get
            {
                return this.GetAttributeValue<string>("new_broken_kpk");
            }
            set
            {
                this.SetAttributeValue<string>("new_broken_kpk", "new_broken_kpk", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_cab_mt")]
        public string new_CAB_mt
        {
            get
            {
                return this.GetAttributeValue<string>("new_cab_mt");
            }
            set
            {
                this.SetAttributeValue<string>("new_CAB_mt", "new_cab_mt", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Карточка клиента, связанного с объектом Проект.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_customer_card")]
        public Microsoft.Xrm.Client.CrmEntityReference new_customer_card
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_customer_card");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_customer_card", "new_customer_card", value);
            }
        }
		
        /// <summary>
        /// Долг по количеству часов, уменьшается, если нет активных контрактов.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_debthours")]
        public System.Nullable<double> new_debtHours
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("new_debthours");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<double>>("new_debtHours", "new_debthours", value);
            }
        }
		
        /// <summary>
        /// Долг по количеству обращений, уменьшается, если нет активный контрактов.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_debtincidents")]
        public System.Nullable<int> new_debtIncidents
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_debtincidents");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_debtIncidents", "new_debtincidents", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_description")]
        public string new_description
        {
            get
            {
                return this.GetAttributeValue<string>("new_description");
            }
            set
            {
                this.SetAttributeValue<string>("new_description", "new_description", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_dogovor")]
        public string new_dogovor
        {
            get
            {
                return this.GetAttributeValue<string>("new_dogovor");
            }
            set
            {
                this.SetAttributeValue<string>("new_dogovor", "new_dogovor", value);
            }
        }
		
        /// <summary>
        /// Доступ на портал поддержки
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_dostup_portal")]
        public string new_dostup_portal
        {
            get
            {
                return this.GetAttributeValue<string>("new_dostup_portal");
            }
            set
            {
                this.SetAttributeValue<string>("new_dostup_portal", "new_dostup_portal", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_login_ftp")]
        public string new_login_FTP
        {
            get
            {
                return this.GetAttributeValue<string>("new_login_ftp");
            }
            set
            {
                this.SetAttributeValue<string>("new_login_FTP", "new_login_ftp", value);
            }
        }
		
        /// <summary>
        /// Процесс создания новых пользователей
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_new_users")]
        public string new_new_users
        {
            get
            {
                return this.GetAttributeValue<string>("new_new_users");
            }
            set
            {
                this.SetAttributeValue<string>("new_new_users", "new_new_users", value);
            }
        }
		
        /// <summary>
        /// К кому обращаться, если по обращению нет ответа
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_no_answer")]
        public string new_no_answer
        {
            get
            {
                return this.GetAttributeValue<string>("new_no_answer");
            }
            set
            {
                this.SetAttributeValue<string>("new_no_answer", "new_no_answer", value);
            }
        }
		
        /// <summary>
        /// Количество часов, которое берется из нового контракта.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_numberofhours")]
        public System.Nullable<double> new_numberOfHours
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("new_numberofhours");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<double>>("new_numberOfHours", "new_numberofhours", value);
            }
        }
		
        /// <summary>
        /// Количество обращений, которое берется из нового контракта.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_numberofincidents")]
        public System.Nullable<int> new_numberOfIncidents
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_numberofincidents");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_numberOfIncidents", "new_numberofincidents", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Организация, связанного с объектом Проект.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_organization")]
        public Microsoft.Xrm.Client.CrmEntityReference new_organization
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_organization");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_organization", "new_organization", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_papka_obmen_sod")]
        public string new_papka_obmen_sod
        {
            get
            {
                return this.GetAttributeValue<string>("new_papka_obmen_sod");
            }
            set
            {
                this.SetAttributeValue<string>("new_papka_obmen_sod", "new_papka_obmen_sod", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_papka_sinchronization")]
        public string new_papka_sinchronization
        {
            get
            {
                return this.GetAttributeValue<string>("new_papka_sinchronization");
            }
            set
            {
                this.SetAttributeValue<string>("new_papka_sinchronization", "new_papka_sinchronization", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_password_ftp")]
        public string new_password_FTP
        {
            get
            {
                return this.GetAttributeValue<string>("new_password_ftp");
            }
            set
            {
                this.SetAttributeValue<string>("new_password_FTP", "new_password_ftp", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_password_replik_rasp")]
        public string new_password_replik_rasp
        {
            get
            {
                return this.GetAttributeValue<string>("new_password_replik_rasp");
            }
            set
            {
                this.SetAttributeValue<string>("new_password_replik_rasp", "new_password_replik_rasp", value);
            }
        }
		
        /// <summary>
        /// От кого регистрируем обращения
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_register_cases")]
        public string new_register_cases
        {
            get
            {
                return this.GetAttributeValue<string>("new_register_cases");
            }
            set
            {
                this.SetAttributeValue<string>("new_register_cases", "new_register_cases", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sla_prime")]
        public string new_SLA_prime
        {
            get
            {
                return this.GetAttributeValue<string>("new_sla_prime");
            }
            set
            {
                this.SetAttributeValue<string>("new_SLA_prime", "new_sla_prime", value);
            }
        }
		
        /// <summary>
        /// Другие особенности БП клиента
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_bp")]
        public string new_special_bp
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_bp");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_bp", "new_special_bp", value);
            }
        }
		
        /// <summary>
        /// Особенности работы в Чикаго
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_chicago")]
        public string new_special_chicago
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_chicago");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_chicago", "new_special_chicago", value);
            }
        }
		
        /// <summary>
        /// Поддержка отчетов, написанных клиентом
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_customreports")]
        public string new_special_customreports
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_customreports");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_customreports", "new_special_customreports", value);
            }
        }
		
        /// <summary>
        /// Особенности работы с документами
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_docs")]
        public string new_special_docs
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_docs");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_docs", "new_special_docs", value);
            }
        }
		
        /// <summary>
        /// Особенности работы в МТ
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_mt")]
        public string new_special_mt
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_mt");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_mt", "new_special_mt", value);
            }
        }
		
        /// <summary>
        /// Особенности работы с маршрутами
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_routes")]
        public string new_special_routes
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_routes");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_routes", "new_special_routes", value);
            }
        }
		
        /// <summary>
        /// Особенности работы в OLAP,RS
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_rs")]
        public string new_special_rs
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_rs");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_rs", "new_special_rs", value);
            }
        }
		
        /// <summary>
        /// Особенности сверки данных
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_special_sverka")]
        public string new_special_sverka
        {
            get
            {
                return this.GetAttributeValue<string>("new_special_sverka");
            }
            set
            {
                this.SetAttributeValue<string>("new_special_sverka", "new_special_sverka", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sql_server")]
        public string new_SQL_server
        {
            get
            {
                return this.GetAttributeValue<string>("new_sql_server");
            }
            set
            {
                this.SetAttributeValue<string>("new_SQL_server", "new_sql_server", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_support_days")]
        public string new_support_days
        {
            get
            {
                return this.GetAttributeValue<string>("new_support_days");
            }
            set
            {
                this.SetAttributeValue<string>("new_support_days", "new_support_days", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_support_time")]
        public string new_support_time
        {
            get
            {
                return this.GetAttributeValue<string>("new_support_time");
            }
            set
            {
                this.SetAttributeValue<string>("new_support_time", "new_support_time", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_tkm_support")]
        public System.Nullable<bool> new_tkm_support
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_tkm_support");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_tkm_support", "new_tkm_support", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_tkm_support_chicago")]
        public System.Nullable<bool> new_tkm_support_chicago
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_tkm_support_chicago");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_tkm_support_chicago", "new_tkm_support_chicago", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_tkm_support_mt3")]
        public System.Nullable<bool> new_tkm_support_mt3
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_tkm_support_mt3");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_tkm_support_mt3", "new_tkm_support_mt3", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_tkm_support_od")]
        public System.Nullable<bool> new_tkm_support_od
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_tkm_support_od");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_tkm_support_od", "new_tkm_support_od", value);
            }
        }
		
        /// <summary>
        /// какой тип поддержки оказывается, пакет услуг
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_type_podderzhka")]
        public System.Nullable<int> new_type_podderzhka
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_type_podderzhka");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("new_type_podderzhka", "new_type_podderzhka", value);
            }
        }
		
        /// <summary>
        /// Как обрабатываем обращения от агентов по выгрузке в УС
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_upload_to_us")]
        public string new_upload_to_us
        {
            get
            {
                return this.GetAttributeValue<string>("new_upload_to_us");
            }
            set
            {
                this.SetAttributeValue<string>("new_upload_to_us", "new_upload_to_us", value);
            }
        }
		
        /// <summary>
        /// Сколько ждем ответа по обращению
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_wait_for_answer")]
        public string new_wait_for_answer
        {
            get
            {
                return this.GetAttributeValue<string>("new_wait_for_answer");
            }
            set
            {
                this.SetAttributeValue<string>("new_wait_for_answer", "new_wait_for_answer", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор организации
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Client.CrmEntityReference OrganizationId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
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
        /// Статус Проект
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<int> statecode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("statecode");
            }
        }
		
        /// <summary>
        /// Причина состояния Проект
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public System.Nullable<int> statuscode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("statuscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode", "statuscode", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_bz")]
        public string svk_bz
        {
            get
            {
                return this.GetAttributeValue<string>("svk_bz");
            }
            set
            {
                this.SetAttributeValue<string>("svk_bz", "svk_bz", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_canreg")]
        public System.Nullable<bool> svk_canReg
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("svk_canreg");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("svk_canReg", "svk_canreg", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_citrixrdweb")]
        public string svk_CitrixRdWeb
        {
            get
            {
                return this.GetAttributeValue<string>("svk_citrixrdweb");
            }
            set
            {
                this.SetAttributeValue<string>("svk_CitrixRdWeb", "svk_citrixrdweb", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Проект.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_incident_responsible")]
        public Microsoft.Xrm.Client.CrmEntityReference svk_incident_responsible
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_incident_responsible");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_incident_responsible", "svk_incident_responsible", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_ipftp")]
        public string svk_IPFTP
        {
            get
            {
                return this.GetAttributeValue<string>("svk_ipftp");
            }
            set
            {
                this.SetAttributeValue<string>("svk_IPFTP", "svk_ipftp", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_ipsod")]
        public string svk_IPsod
        {
            get
            {
                return this.GetAttributeValue<string>("svk_ipsod");
            }
            set
            {
                this.SetAttributeValue<string>("svk_IPsod", "svk_ipsod", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Проект.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_klient_menejer")]
        public Microsoft.Xrm.Client.CrmEntityReference svk_klient_menejer
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_klient_menejer");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_klient_menejer", "svk_klient_menejer", value);
            }
        }
		
        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_name")]
        public string svk_name
        {
            get
            {
                return this.GetAttributeValue<string>("svk_name");
            }
            set
            {
                this.SetAttributeValue<string>("svk_name", "svk_name", value);
            }
        }
		
        /// <summary>
        /// Поле используется для связи проекта с сущностью "организация".
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_org_project")]
        public System.Nullable<int> svk_org_project
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("svk_org_project");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("svk_org_project", "svk_org_project", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_port_sod")]
        public string svk_port_sod
        {
            get
            {
                return this.GetAttributeValue<string>("svk_port_sod");
            }
            set
            {
                this.SetAttributeValue<string>("svk_port_sod", "svk_port_sod", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор экземпляров сущности
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_projectid")]
        public System.Nullable<System.Guid> svk_projectId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("svk_projectid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("svk_projectId", "svk_projectid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_projectid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.svk_projectId = value;
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_projectsodname")]
        public string svk_projectSODName
        {
            get
            {
                return this.GetAttributeValue<string>("svk_projectsodname");
            }
            set
            {
                this.SetAttributeValue<string>("svk_projectSODName", "svk_projectsodname", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_reportingservice")]
        public string svk_ReportingService
        {
            get
            {
                return this.GetAttributeValue<string>("svk_reportingservice");
            }
            set
            {
                this.SetAttributeValue<string>("svk_ReportingService", "svk_reportingservice", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Проект.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_rukovod")]
        public Microsoft.Xrm.Client.CrmEntityReference svk_rukovod
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_rukovod");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_rukovod", "svk_rukovod", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_telefon")]
        public string svk_telefon
        {
            get
            {
                return this.GetAttributeValue<string>("svk_telefon");
            }
            set
            {
                this.SetAttributeValue<string>("svk_telefon", "svk_telefon", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Проект.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_trp")]
        public Microsoft.Xrm.Client.CrmEntityReference svk_trp
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_trp");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_trp", "svk_trp", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_urlftp")]
        public string svk_URLFTP
        {
            get
            {
                return this.GetAttributeValue<string>("svk_urlftp");
            }
            set
            {
                this.SetAttributeValue<string>("svk_URLFTP", "svk_urlftp", value);
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
        /// 
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
        /// 1:N iok_svk_project_incident_KK_project
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_svk_project_incident_KK_project")]
        public System.Collections.Generic.IEnumerable<Incident> iok_svk_project_incident_KK_project
        {
            get
            {
                return this.GetRelatedEntities<Incident>("iok_svk_project_incident_KK_project", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("iok_svk_project_incident_KK_project", "iok_svk_project_incident_KK_project", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_project_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> svk_project_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("svk_project_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("svk_project_ActivityPointers", "svk_project_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_project_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> svk_project_Annotations
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("svk_project_Annotations", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("svk_project_Annotations", "svk_project_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_project_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_Emails")]
        public System.Collections.Generic.IEnumerable<Email> svk_project_Emails
        {
            get
            {
                return this.GetRelatedEntities<Email>("svk_project_Emails", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("svk_project_Emails", "svk_project_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_project_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_iok_action_send_SMSes")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> svk_project_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("svk_project_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("svk_project_iok_action_send_SMSes", "svk_project_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_svk_project_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_svk_project_contact")]
        public System.Collections.Generic.IEnumerable<Contact> svk_svk_project_contact
        {
            get
            {
                return this.GetRelatedEntities<Contact>("svk_svk_project_contact", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("svk_svk_project_contact", "svk_svk_project_contact", null, value);
            }
        }
		
        /// <summary>
        /// 1:N svk_svk_project_new_probe
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_svk_project_new_probe")]
        public System.Collections.Generic.IEnumerable<New_Probe> svk_svk_project_new_probe
        {
            get
            {
                return this.GetRelatedEntities<New_Probe>("svk_svk_project_new_probe", null);
            }
            set
            {
                this.SetRelatedEntities<New_Probe>("svk_svk_project_new_probe", "svk_svk_project_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_svk_project_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_createdby")]
        public SystemUser lk_svk_project_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_svk_project_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_svk_project_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_createdonbehalfby")]
        public SystemUser lk_svk_project_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_svk_project_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_svk_project_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_modifiedby")]
        public SystemUser lk_svk_project_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_svk_project_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_svk_project_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_svk_project_modifiedonbehalfby")]
        public SystemUser lk_svk_project_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_svk_project_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 new_account_svk_project
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_organization")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_account_svk_project")]
        public Account new_account_svk_project
        {
            get
            {
                return this.GetRelatedEntity<Account>("new_account_svk_project", null);
            }
            set
            {
                this.SetRelatedEntity<Account>("new_account_svk_project", "new_account_svk_project", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_new_probe_svk_project_customer_card
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_customer_card")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_new_probe_svk_project_customer_card")]
        public New_Probe new_new_probe_svk_project_customer_card
        {
            get
            {
                return this.GetRelatedEntity<New_Probe>("new_new_probe_svk_project_customer_card", null);
            }
            set
            {
                this.SetRelatedEntity<New_Probe>("new_new_probe_svk_project_customer_card", "new_new_probe_svk_project_customer_card", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_contact_svk_project_incident_responsible
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_incident_responsible")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_contact_svk_project_incident_responsible")]
        public Contact svk_contact_svk_project_incident_responsible
        {
            get
            {
                return this.GetRelatedEntity<Contact>("svk_contact_svk_project_incident_responsible", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("svk_contact_svk_project_incident_responsible", "svk_contact_svk_project_incident_responsible", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_systemuser_svk_project
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_klient_menejer")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_svk_project")]
        public SystemUser svk_systemuser_svk_project
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("svk_systemuser_svk_project", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("svk_systemuser_svk_project", "svk_systemuser_svk_project", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_systemuser_svk_project_ruk
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_rukovod")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_svk_project_ruk")]
        public SystemUser svk_systemuser_svk_project_ruk
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("svk_systemuser_svk_project_ruk", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("svk_systemuser_svk_project_ruk", "svk_systemuser_svk_project_ruk", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_systemuser_svk_project_trp
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_trp")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_svk_project_trp")]
        public SystemUser svk_systemuser_svk_project_trp
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("svk_systemuser_svk_project_trp", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("svk_systemuser_svk_project_trp", "svk_systemuser_svk_project_trp", null, value);
            }
        }
    }
}