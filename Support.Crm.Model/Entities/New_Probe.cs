namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Карточки клиентов
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("new_probe")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("New_ProbeSet")]
    public partial class New_Probe : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public New_Probe() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "new_probe";
		
        public const int EntityTypeCode = 10000;
		
        /// <summary>
        /// Unique identifier of the user who created the record.
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
        /// Date and time when the record was created.
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
        /// Sequence number of the import that created this record.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_adoption_state")]
        public System.Nullable<int> iok_adoption_state
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("iok_adoption_state");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("iok_adoption_state", "iok_adoption_state", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_support_type")]
        public System.Nullable<int> iok_support_type
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("iok_support_type");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("iok_support_type", "iok_support_type", value);
            }
        }
		
        /// <summary>
        /// Unique identifier of the user who modified the record.
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
        /// Date and time when the record was modified.
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
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_1cid_spec")]
        public Microsoft.Xrm.Client.CrmEntityReference New_1cId_spec
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_1cid_spec");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_1cId_spec", "new_1cid_spec", value);
            }
        }
		
        /// <summary>
        /// Активность проблемы с отгрузками.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_aktivnost_problem_otgruzka")]
        public System.Nullable<bool> New_aktivnost_problem_otgruzka
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_aktivnost_problem_otgruzka");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_aktivnost_problem_otgruzka", "new_aktivnost_problem_otgruzka", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_aktualnie_ceni_na_kpk")]
        public string New_aktualnie_ceni_na_kpk
        {
            get
            {
                return this.GetAttributeValue<string>("new_aktualnie_ceni_na_kpk");
            }
            set
            {
                this.SetAttributeValue<string>("New_aktualnie_ceni_na_kpk", "new_aktualnie_ceni_na_kpk", value);
            }
        }
		
        /// <summary>
        /// Отмечаем настроен ли автообмен.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_avtoobmen_nastroen")]
        public System.Nullable<bool> New_avtoobmen_nastroen
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_avtoobmen_nastroen");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_avtoobmen_nastroen", "new_avtoobmen_nastroen", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_chas_ostatki")]
        public System.Nullable<int> New_chas_ostatki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_chas_ostatki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_chas_ostatki", "new_chas_ostatki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_chas_otgruzki")]
        public System.Nullable<int> New_chas_otgruzki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_chas_otgruzki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_chas_otgruzki", "new_chas_otgruzki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_chas_regist")]
        public System.Nullable<int> New_chas_regist
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_chas_regist");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_chas_regist", "new_chas_regist", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_chas_sprav")]
        public System.Nullable<int> New_chas_sprav
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_chas_sprav");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_chas_sprav", "new_chas_sprav", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_chas_zadolj")]
        public System.Nullable<int> New_chas_zadolj
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_chas_zadolj");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_chas_zadolj", "new_chas_zadolj", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_chas_zayavki")]
        public System.Nullable<int> New_chas_zayavki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_chas_zayavki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_chas_zayavki", "new_chas_zayavki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_citrix_fio")]
        public string New_Citrix_fio
        {
            get
            {
                return this.GetAttributeValue<string>("new_citrix_fio");
            }
            set
            {
                this.SetAttributeValue<string>("New_Citrix_fio", "new_citrix_fio", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_citrix_login")]
        public string New_Citrix_login
        {
            get
            {
                return this.GetAttributeValue<string>("new_citrix_login");
            }
            set
            {
                this.SetAttributeValue<string>("New_Citrix_login", "new_citrix_login", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_citrix_password")]
        public string New_Citrix_password
        {
            get
            {
                return this.GetAttributeValue<string>("new_citrix_password");
            }
            set
            {
                this.SetAttributeValue<string>("New_Citrix_password", "new_citrix_password", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_count_incidents")]
        public System.Nullable<int> new_count_incidents
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_count_incidents");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_count_incidents", "new_count_incidents", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_data_nach_vnedreniya")]
        public System.Nullable<System.DateTime> new_data_nach_vnedreniya
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_data_nach_vnedreniya");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("new_data_nach_vnedreniya", "new_data_nach_vnedreniya", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_date_postanovka_kontrol")]
        public System.Nullable<System.DateTime> new_date_postanovka_kontrol
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_date_postanovka_kontrol");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("new_date_postanovka_kontrol", "new_date_postanovka_kontrol", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_date_prinyatiya_podderzhka")]
        public System.Nullable<System.DateTime> New_date_prinyatiya_podderzhka
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_date_prinyatiya_podderzhka");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("New_date_prinyatiya_podderzhka", "new_date_prinyatiya_podderzhka", value);
            }
        }
		
        /// <summary>
        /// Дата снятия с контроля
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_date_snyatie_kontrol")]
        public System.Nullable<System.DateTime> new_date_snyatie_kontrol
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_date_snyatie_kontrol");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("new_date_snyatie_kontrol", "new_date_snyatie_kontrol", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_dbexport_papka")]
        public string New_DBExport_papka
        {
            get
            {
                return this.GetAttributeValue<string>("new_dbexport_papka");
            }
            set
            {
                this.SetAttributeValue<string>("New_DBExport_papka", "new_dbexport_papka", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_dop_dorabotki_mt")]
        public string New_dop_dorabotki_mt
        {
            get
            {
                return this.GetAttributeValue<string>("new_dop_dorabotki_mt");
            }
            set
            {
                this.SetAttributeValue<string>("New_dop_dorabotki_mt", "new_dop_dorabotki_mt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_dop_nastroyki_mt")]
        public string New_dop_nastroyki_mt
        {
            get
            {
                return this.GetAttributeValue<string>("new_dop_nastroyki_mt");
            }
            set
            {
                this.SetAttributeValue<string>("New_dop_nastroyki_mt", "new_dop_nastroyki_mt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_fio_chicago")]
        public string New_fio_chicago
        {
            get
            {
                return this.GetAttributeValue<string>("new_fio_chicago");
            }
            set
            {
                this.SetAttributeValue<string>("New_fio_chicago", "new_fio_chicago", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_group")]
        public System.Nullable<int> New_group
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_group");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_group", "new_group", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_idi")]
        public string new_idi
        {
            get
            {
                return this.GetAttributeValue<string>("new_idi");
            }
            set
            {
                this.SetAttributeValue<string>("new_idi", "new_idi", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_imeet_operator_dostup_papkarepl")]
        public System.Nullable<bool> New_imeet_operator_dostup_papkarepl
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_imeet_operator_dostup_papkarepl");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_imeet_operator_dostup_papkarepl", "new_imeet_operator_dostup_papkarepl", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_imeet_operator_dostup_us")]
        public System.Nullable<bool> New_imeet_operator_dostup_us
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_imeet_operator_dostup_us");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_imeet_operator_dostup_us", "new_imeet_operator_dostup_us", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_insurance")]
        public Microsoft.Xrm.Client.CrmEntityReference new_insurance
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_insurance");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_insurance", "new_insurance", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_integrator")]
        public Microsoft.Xrm.Client.CrmEntityReference New_integrator
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_integrator");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_integrator", "new_integrator", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_interface_obmen_mt")]
        public System.Nullable<int> New_interface_obmen_mt
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_interface_obmen_mt");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_interface_obmen_mt", "new_interface_obmen_mt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ip")]
        public string New_IP
        {
            get
            {
                return this.GetAttributeValue<string>("new_ip");
            }
            set
            {
                this.SetAttributeValue<string>("New_IP", "new_ip", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ip_udalenniy_dostup")]
        public string New_IP_udalenniy_dostup
        {
            get
            {
                return this.GetAttributeValue<string>("new_ip_udalenniy_dostup");
            }
            set
            {
                this.SetAttributeValue<string>("New_IP_udalenniy_dostup", "new_ip_udalenniy_dostup", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ispolzovanie_skidki_nacenki_kpk")]
        public System.Nullable<bool> New_ispolzovanie_skidki_nacenki_kpk
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_ispolzovanie_skidki_nacenki_kpk");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_ispolzovanie_skidki_nacenki_kpk", "new_ispolzovanie_skidki_nacenki_kpk", value);
            }
        }
		
        /// <summary>
        /// К какому изменению относятся какие площадки
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_izmenenie")]
        public Microsoft.Xrm.Client.CrmEntityReference New_izmenenie
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_izmenenie");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_izmenenie", "new_izmenenie", value);
            }
        }
		
        /// <summary>
        /// Контролируется ли в данный момент площадка
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_kontrol_ploshadki")]
        public System.Nullable<bool> new_kontrol_ploshadki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_kontrol_ploshadki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_kontrol_ploshadki", "new_kontrol_ploshadki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_kto_pisal_inter")]
        public System.Nullable<int> New_kto_pisal_inter
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_kto_pisal_inter");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_kto_pisal_inter", "new_kto_pisal_inter", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_login_chicago")]
        public string New_login_chicago
        {
            get
            {
                return this.GetAttributeValue<string>("new_login_chicago");
            }
            set
            {
                this.SetAttributeValue<string>("New_login_chicago", "new_login_chicago", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_login_udalennoe_podkluchenie")]
        public string New_login_udalennoe_podkluchenie
        {
            get
            {
                return this.GetAttributeValue<string>("new_login_udalennoe_podkluchenie");
            }
            set
            {
                this.SetAttributeValue<string>("New_login_udalennoe_podkluchenie", "new_login_udalennoe_podkluchenie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_marshruti_iz_us")]
        public System.Nullable<bool> New_marshruti_iz_us
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_marshruti_iz_us");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_marshruti_iz_us", "new_marshruti_iz_us", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_menedjer")]
        public Microsoft.Xrm.Client.CrmEntityReference New_menedjer
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_menedjer");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_menedjer", "new_menedjer", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_minut_ostat")]
        public System.Nullable<int> New_minut_ostat
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_minut_ostat");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_minut_ostat", "new_minut_ostat", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_minut_otgruzki")]
        public System.Nullable<int> New_minut_otgruzki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_minut_otgruzki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_minut_otgruzki", "new_minut_otgruzki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_minut_regist")]
        public System.Nullable<int> New_minut_regist
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_minut_regist");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_minut_regist", "new_minut_regist", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_minut_sprav")]
        public System.Nullable<int> New_minut_sprav
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_minut_sprav");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_minut_sprav", "new_minut_sprav", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_minut_zadolj")]
        public System.Nullable<int> New_minut_zadolj
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_minut_zadolj");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_minut_zadolj", "new_minut_zadolj", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_minut_zayavki")]
        public System.Nullable<int> New_minut_zayavki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_minut_zayavki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_minut_zayavki", "new_minut_zayavki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_model_kpk")]
        public string New_model_kpk
        {
            get
            {
                return this.GetAttributeValue<string>("new_model_kpk");
            }
            set
            {
                this.SetAttributeValue<string>("New_model_kpk", "new_model_kpk", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_module_mt")]
        public string New_module_mt
        {
            get
            {
                return this.GetAttributeValue<string>("new_module_mt");
            }
            set
            {
                this.SetAttributeValue<string>("New_module_mt", "new_module_mt", value);
            }
        }
		
        /// <summary>
        /// Имя настраиваемого объекта.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_name")]
        public string New_name
        {
            get
            {
                return this.GetAttributeValue<string>("new_name");
            }
            set
            {
                this.SetAttributeValue<string>("New_name", "new_name", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_nazvanie_us")]
        public string New_nazvanie_us
        {
            get
            {
                return this.GetAttributeValue<string>("new_nazvanie_us");
            }
            set
            {
                this.SetAttributeValue<string>("New_nazvanie_us", "new_nazvanie_us", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_node")]
        public string New_node
        {
            get
            {
                return this.GetAttributeValue<string>("new_node");
            }
            set
            {
                this.SetAttributeValue<string>("New_node", "new_node", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ogranichenie_zagruz_dokum_vus")]
        public string New_ogranichenie_zagruz_dokum_vus
        {
            get
            {
                return this.GetAttributeValue<string>("new_ogranichenie_zagruz_dokum_vus");
            }
            set
            {
                this.SetAttributeValue<string>("New_ogranichenie_zagruz_dokum_vus", "new_ogranichenie_zagruz_dokum_vus", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ogranicheniya_rabota_tp_kpk")]
        public string New_ogranicheniya_rabota_tp_kpk
        {
            get
            {
                return this.GetAttributeValue<string>("new_ogranicheniya_rabota_tp_kpk");
            }
            set
            {
                this.SetAttributeValue<string>("New_ogranicheniya_rabota_tp_kpk", "new_ogranicheniya_rabota_tp_kpk", value);
            }
        }
		
        /// <summary>
        /// Ответственный контакт
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_operator")]
        public Microsoft.Xrm.Client.CrmEntityReference New_operator
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_operator");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_operator", "new_operator", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_operator1")]
        public Microsoft.Xrm.Client.CrmEntityReference New_operator1
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_operator1");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_operator1", "new_operator1", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_opisanie")]
        public string New_opisanie
        {
            get
            {
                return this.GetAttributeValue<string>("new_opisanie");
            }
            set
            {
                this.SetAttributeValue<string>("New_opisanie", "new_opisanie", value);
            }
        }
		
        /// <summary>
        /// Организация
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_organization")]
        public Microsoft.Xrm.Client.CrmEntityReference New_organization
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_organization");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_organization", "new_organization", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_oshibka_vnedreniya")]
        public string New_oshibka_vnedreniya
        {
            get
            {
                return this.GetAttributeValue<string>("new_oshibka_vnedreniya");
            }
            set
            {
                this.SetAttributeValue<string>("New_oshibka_vnedreniya", "new_oshibka_vnedreniya", value);
            }
        }
		
        /// <summary>
        /// Описание особенностей интеграции.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_osobennosti_integracii")]
        public string New_osobennosti_integracii
        {
            get
            {
                return this.GetAttributeValue<string>("new_osobennosti_integracii");
            }
            set
            {
                this.SetAttributeValue<string>("New_osobennosti_integracii", "new_osobennosti_integracii", value);
            }
        }
		
        /// <summary>
        /// Текст обращения автоинформатор
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_otsutstvie_dannih_avto")]
        public string New_otsutstvie_dannih_avto
        {
            get
            {
                return this.GetAttributeValue<string>("new_otsutstvie_dannih_avto");
            }
            set
            {
                this.SetAttributeValue<string>("New_otsutstvie_dannih_avto", "new_otsutstvie_dannih_avto", value);
            }
        }
		
        /// <summary>
        /// Какой объект отсутствует
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_otsutstvuet_object")]
        public System.Nullable<int> New_otsutstvuet_object
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_otsutstvuet_object");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_otsutstvuet_object", "new_otsutstvuet_object", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_papka_hraneniya_vneshnih_obrabotok")]
        public string New_papka_hraneniya_vneshnih_obrabotok
        {
            get
            {
                return this.GetAttributeValue<string>("new_papka_hraneniya_vneshnih_obrabotok");
            }
            set
            {
                this.SetAttributeValue<string>("New_papka_hraneniya_vneshnih_obrabotok", "new_papka_hraneniya_vneshnih_obrabotok", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_papka_replication")]
        public string New_papka_replication
        {
            get
            {
                return this.GetAttributeValue<string>("new_papka_replication");
            }
            set
            {
                this.SetAttributeValue<string>("New_papka_replication", "new_papka_replication", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_papka_s_batnikami_replication")]
        public string New_papka_s_batnikami_replication
        {
            get
            {
                return this.GetAttributeValue<string>("new_papka_s_batnikami_replication");
            }
            set
            {
                this.SetAttributeValue<string>("New_papka_s_batnikami_replication", "new_papka_s_batnikami_replication", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_papka_sinhronizacii")]
        public string New_papka_sinhronizacii
        {
            get
            {
                return this.GetAttributeValue<string>("new_papka_sinhronizacii");
            }
            set
            {
                this.SetAttributeValue<string>("New_papka_sinhronizacii", "new_papka_sinhronizacii", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_parol_us")]
        public string New_parol_us
        {
            get
            {
                return this.GetAttributeValue<string>("new_parol_us");
            }
            set
            {
                this.SetAttributeValue<string>("New_parol_us", "new_parol_us", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_password")]
        public string New_password
        {
            get
            {
                return this.GetAttributeValue<string>("new_password");
            }
            set
            {
                this.SetAttributeValue<string>("New_password", "new_password", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_password_udalennoe_podkluchenie")]
        public string New_password_udalennoe_podkluchenie
        {
            get
            {
                return this.GetAttributeValue<string>("new_password_udalennoe_podkluchenie");
            }
            set
            {
                this.SetAttributeValue<string>("New_password_udalennoe_podkluchenie", "new_password_udalennoe_podkluchenie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_pereodich_zadolj")]
        public System.Nullable<int> New_pereodich_zadolj
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_pereodich_zadolj");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_pereodich_zadolj", "new_pereodich_zadolj", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_periodich_ostat")]
        public System.Nullable<int> New_periodich_ostat
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_periodich_ostat");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_periodich_ostat", "new_periodich_ostat", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_periodich_regist")]
        public System.Nullable<int> New_periodich_regist
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_periodich_regist");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_periodich_regist", "new_periodich_regist", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_periodich_sprav")]
        public System.Nullable<int> New_periodich_sprav
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_periodich_sprav");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_periodich_sprav", "new_periodich_sprav", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_periodichnost")]
        public System.Nullable<int> New_periodichnost
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_periodichnost");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_periodichnost", "new_periodichnost", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_periodichnost_otgruzki")]
        public System.Nullable<int> New_periodichnost_otgruzki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_periodichnost_otgruzki");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_periodichnost_otgruzki", "new_periodichnost_otgruzki", value);
            }
        }
		
        /// <summary>
        /// Кураторам падают письма, что в обращении привышен лимит уточнений. Они начинают мотивировать инженера произвести звонок, вместо письма. Если в КК стоит "Да", на данную строку, то по этой площадке оповещения не приходят.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_phon_need")]
        public System.Nullable<bool> new_phon_need
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_phon_need");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_phon_need", "new_phon_need", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_po_ostatki")]
        public System.Nullable<int> New_po_ostatki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_po_ostatki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_po_ostatki", "new_po_ostatki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_po_otgruzki")]
        public System.Nullable<int> New_po_otgruzki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_po_otgruzki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_po_otgruzki", "new_po_otgruzki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_po_regist")]
        public System.Nullable<int> New_Po_regist
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_po_regist");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_Po_regist", "new_po_regist", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_po_sprav")]
        public System.Nullable<int> New_Po_sprav
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_po_sprav");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_Po_sprav", "new_po_sprav", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_po_zadolj")]
        public System.Nullable<int> New_po_zadolj
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_po_zadolj");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_po_zadolj", "new_po_zadolj", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_podderj_integr")]
        public Microsoft.Xrm.Client.CrmEntityReference new_podderj_integr
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_podderj_integr");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_podderj_integr", "new_podderj_integr", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_polzovatel_us")]
        public string New_polzovatel_us
        {
            get
            {
                return this.GetAttributeValue<string>("new_polzovatel_us");
            }
            set
            {
                this.SetAttributeValue<string>("New_polzovatel_us", "new_polzovatel_us", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_port_udalennoe_podkluchenie")]
        public System.Nullable<int> New_port_udalennoe_podkluchenie
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_port_udalennoe_podkluchenie");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_port_udalennoe_podkluchenie", "new_port_udalennoe_podkluchenie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_prim_rasp")]
        public string New_prim_rasp
        {
            get
            {
                return this.GetAttributeValue<string>("new_prim_rasp");
            }
            set
            {
                this.SetAttributeValue<string>("New_prim_rasp", "new_prim_rasp", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_prim_udal")]
        public string New_prim_udal
        {
            get
            {
                return this.GetAttributeValue<string>("new_prim_udal");
            }
            set
            {
                this.SetAttributeValue<string>("New_prim_udal", "new_prim_udal", value);
            }
        }
		
        /// <summary>
        /// Инженер, который принял на поддержку.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_prinyal_na_podderzhku")]
        public Microsoft.Xrm.Client.CrmEntityReference New_prinyal_na_podderzhku
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_prinyal_na_podderzhku");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_prinyal_na_podderzhku", "new_prinyal_na_podderzhku", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_probeid")]
        public System.Nullable<System.Guid> New_ProbeId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("new_probeid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("New_ProbeId", "new_probeid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_probeid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.New_ProbeId = value;
            }
        }
		
        /// <summary>
        /// Активность консультации, другого
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
        /// Отмечается есть ли у дистрибьютора проблемы с нетом или нет.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_internet")]
        public System.Nullable<bool> New_problem_internet
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_internet");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_internet", "new_problem_internet", value);
            }
        }
		
        /// <summary>
        /// Описание почему проблемы с нетом
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_internet_text")]
        public string New_problem_internet_text
        {
            get
            {
                return this.GetAttributeValue<string>("new_problem_internet_text");
            }
            set
            {
                this.SetAttributeValue<string>("New_problem_internet_text", "new_problem_internet_text", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Проблема, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_konsult_drugoe")]
        public Microsoft.Xrm.Client.CrmEntityReference New_problem_konsult_drugoe
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_problem_konsult_drugoe");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_problem_konsult_drugoe", "new_problem_konsult_drugoe", value);
            }
        }
		
        /// <summary>
        /// Проблема с остатками
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_ostatki")]
        public System.Nullable<bool> New_problem_ostatki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_ostatki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_ostatki", "new_problem_ostatki", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Проблема, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_ostatki_pr")]
        public Microsoft.Xrm.Client.CrmEntityReference New_problem_ostatki_pr
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_problem_ostatki_pr");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_problem_ostatki_pr", "new_problem_ostatki_pr", value);
            }
        }
		
        /// <summary>
        /// Проблема с остатками описание
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_ostatki_text")]
        public string New_problem_ostatki_text
        {
            get
            {
                return this.GetAttributeValue<string>("new_problem_ostatki_text");
            }
            set
            {
                this.SetAttributeValue<string>("New_problem_ostatki_text", "new_problem_ostatki_text", value);
            }
        }
		
        /// <summary>
        /// Есть ли проблема с отгрузками
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_otgruzka")]
        public System.Nullable<bool> New_problem_otgruzka
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_otgruzka");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_otgruzka", "new_problem_otgruzka", value);
            }
        }
		
        /// <summary>
        /// Проблема с отгрузками описание
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_otgruzka_text")]
        public string New_problem_otgruzka_text
        {
            get
            {
                return this.GetAttributeValue<string>("new_problem_otgruzka_text");
            }
            set
            {
                this.SetAttributeValue<string>("New_problem_otgruzka_text", "new_problem_otgruzka_text", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_polzovatel")]
        public string New_problem_polzovatel
        {
            get
            {
                return this.GetAttributeValue<string>("new_problem_polzovatel");
            }
            set
            {
                this.SetAttributeValue<string>("New_problem_polzovatel", "new_problem_polzovatel", value);
            }
        }
		
        /// <summary>
        /// Проблемы атообмена/расписания
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_raspisanie")]
        public System.Nullable<bool> New_problem_raspisanie
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_raspisanie");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_raspisanie", "new_problem_raspisanie", value);
            }
        }
		
        /// <summary>
        /// Проблемы с автообмена/расписания текст
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_raspisanie_text")]
        public string New_problem_raspisanie_text
        {
            get
            {
                return this.GetAttributeValue<string>("new_problem_raspisanie_text");
            }
            set
            {
                this.SetAttributeValue<string>("New_problem_raspisanie_text", "new_problem_raspisanie_text", value);
            }
        }
		
        /// <summary>
        /// Есть ли проблемы в репликации
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_replication")]
        public System.Nullable<bool> New_problem_replication
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_replication");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_replication", "new_problem_replication", value);
            }
        }
		
        /// <summary>
        /// Ссылка на проблему с отгрузками
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_s_otgruzkami_pr")]
        public Microsoft.Xrm.Client.CrmEntityReference New_problem_s_otgruzkami_pr
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_problem_s_otgruzkami_pr");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_problem_s_otgruzkami_pr", "new_problem_s_otgruzkami_pr", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_spravochniki")]
        public System.Nullable<bool> New_problem_spravochniki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_spravochniki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_spravochniki", "new_problem_spravochniki", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Проблема, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_spravochniki_pr")]
        public Microsoft.Xrm.Client.CrmEntityReference New_problem_spravochniki_pr
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_problem_spravochniki_pr");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_problem_spravochniki_pr", "new_problem_spravochniki_pr", value);
            }
        }
		
        /// <summary>
        /// Проблема задолженности
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_zadoljennosti")]
        public System.Nullable<bool> New_problem_zadoljennosti
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_zadoljennosti");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_zadoljennosti", "new_problem_zadoljennosti", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Проблема, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_zadolzhennosti_pr")]
        public Microsoft.Xrm.Client.CrmEntityReference New_problem_zadolzhennosti_pr
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_problem_zadolzhennosti_pr");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_problem_zadolzhennosti_pr", "new_problem_zadolzhennosti_pr", value);
            }
        }
		
        /// <summary>
        /// Проблема заявки
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_zayavki")]
        public System.Nullable<bool> New_problem_zayavki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_problem_zayavki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_problem_zayavki", "new_problem_zayavki", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Проблема, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_problem_zayavki_pr")]
        public Microsoft.Xrm.Client.CrmEntityReference New_problem_zayavki_pr
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_problem_zayavki_pr");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_problem_zayavki_pr", "new_problem_zayavki_pr", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_profil_svyazi_mt_port")]
        public System.Nullable<int> New_profil_svyazi_mt_port
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_profil_svyazi_mt_port");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_profil_svyazi_mt_port", "new_profil_svyazi_mt_port", value);
            }
        }
		
        /// <summary>
        /// Проверка исправлена ли проблема
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_proverka")]
        public System.Nullable<bool> New_proverka
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_proverka");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_proverka", "new_proverka", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_put_k_rabochey_baze_us")]
        public string New_put_k_rabochey_baze_us
        {
            get
            {
                return this.GetAttributeValue<string>("new_put_k_rabochey_baze_us");
            }
            set
            {
                this.SetAttributeValue<string>("New_put_k_rabochey_baze_us", "new_put_k_rabochey_baze_us", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_rabota_so_skladami")]
        public string New_rabota_so_skladami
        {
            get
            {
                return this.GetAttributeValue<string>("new_rabota_so_skladami");
            }
            set
            {
                this.SetAttributeValue<string>("New_rabota_so_skladami", "new_rabota_so_skladami", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_rasp_repl_chast")]
        public System.Nullable<bool> New_rasp_repl_chast
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_rasp_repl_chast");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_rasp_repl_chast", "new_rasp_repl_chast", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_s_ostatki")]
        public System.Nullable<int> New_s_ostatki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_s_ostatki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_s_ostatki", "new_s_ostatki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_s_otgruzki")]
        public System.Nullable<int> New_S_otgruzki
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_s_otgruzki");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_S_otgruzki", "new_s_otgruzki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_s_regist")]
        public System.Nullable<int> New_S_regist
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_s_regist");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_S_regist", "new_s_regist", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_s_sprav")]
        public System.Nullable<int> New_S_sprav
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_s_sprav");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_S_sprav", "new_s_sprav", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_s_zadolj")]
        public System.Nullable<int> New_s_zadolj
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_s_zadolj");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_s_zadolj", "new_s_zadolj", value);
            }
        }
		
        /// <summary>
        /// События в интеграции
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sobytiya_integraciya")]
        public string New_sobytiya_integraciya
        {
            get
            {
                return this.GetAttributeValue<string>("new_sobytiya_integraciya");
            }
            set
            {
                this.SetAttributeValue<string>("New_sobytiya_integraciya", "new_sobytiya_integraciya", value);
            }
        }
		
        /// <summary>
        /// События в репликации
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sobytiya_replicaciya")]
        public string New_sobytiya_replicaciya
        {
            get
            {
                return this.GetAttributeValue<string>("new_sobytiya_replicaciya");
            }
            set
            {
                this.SetAttributeValue<string>("New_sobytiya_replicaciya", "new_sobytiya_replicaciya", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sotoviy_operator")]
        public System.Nullable<int> New_sotoviy_operator
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_sotoviy_operator");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_sotoviy_operator", "new_sotoviy_operator", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ssilkatz")]
        public string new_ssilkatz
        {
            get
            {
                return this.GetAttributeValue<string>("new_ssilkatz");
            }
            set
            {
                this.SetAttributeValue<string>("new_ssilkatz", "new_ssilkatz", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sysadmin")]
        public Microsoft.Xrm.Client.CrmEntityReference New_sysadmin
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_sysadmin");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_sysadmin", "new_sysadmin", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_text")]
        public string New_text
        {
            get
            {
                return this.GetAttributeValue<string>("new_text");
            }
            set
            {
                this.SetAttributeValue<string>("New_text", "new_text", value);
            }
        }
		
        /// <summary>
        /// Тип автообмена
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_type_avtoobmen")]
        public System.Nullable<int> New_type_avtoobmen
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_type_avtoobmen");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_type_avtoobmen", "new_type_avtoobmen", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_type_udalenniy_dostup")]
        public System.Nullable<int> New_type_udalenniy_dostup
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_type_udalenniy_dostup");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_type_udalenniy_dostup", "new_type_udalenniy_dostup", value);
            }
        }
		
        /// <summary>
        /// Удаленный доступ есть или нет.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_udalenniy_dostup")]
        public System.Nullable<bool> New_udalenniy_dostup
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_udalenniy_dostup");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_udalenniy_dostup", "new_udalenniy_dostup", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_usluga_avtoobmena")]
        public System.Nullable<int> New_usluga_avtoobmena
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_usluga_avtoobmena");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("New_usluga_avtoobmena", "new_usluga_avtoobmena", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_version_mt")]
        public string New_version_mt
        {
            get
            {
                return this.GetAttributeValue<string>("new_version_mt");
            }
            set
            {
                this.SetAttributeValue<string>("New_version_mt", "new_version_mt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_versiya_os_kpk")]
        public string New_versiya_os_kpk
        {
            get
            {
                return this.GetAttributeValue<string>("new_versiya_os_kpk");
            }
            set
            {
                this.SetAttributeValue<string>("New_versiya_os_kpk", "new_versiya_os_kpk", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_versiya_us")]
        public string New_versiya_us
        {
            get
            {
                return this.GetAttributeValue<string>("new_versiya_us");
            }
            set
            {
                this.SetAttributeValue<string>("New_versiya_us", "new_versiya_us", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_vnedrenec")]
        public Microsoft.Xrm.Client.CrmEntityReference New_vnedrenec
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_vnedrenec");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("New_vnedrenec", "new_vnedrenec", value);
            }
        }
		
        /// <summary>
        /// Вопрос
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_vopros")]
        public string New_vopros
        {
            get
            {
                return this.GetAttributeValue<string>("new_vopros");
            }
            set
            {
                this.SetAttributeValue<string>("New_vopros", "new_vopros", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_vremya_nachal_raboti")]
        public System.Nullable<int> New_vremya_nachal_raboti
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_vremya_nachal_raboti");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_vremya_nachal_raboti", "new_vremya_nachal_raboti", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_vremya_okonch_raboti")]
        public System.Nullable<int> New_vremya_okonch_raboti
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_vremya_okonch_raboti");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_vremya_okonch_raboti", "new_vremya_okonch_raboti", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_vremya_raboti1")]
        public System.Nullable<int> New_vremya_raboti1
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_vremya_raboti1");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_vremya_raboti1", "new_vremya_raboti1", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_vremya_raboti2")]
        public System.Nullable<int> New_vremya_raboti2
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_vremya_raboti2");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("New_vremya_raboti2", "new_vremya_raboti2", value);
            }
        }
		
        /// <summary>
        /// Unique identifier for the organization
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
        /// Date and time that the record was migrated.
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
        /// Status of the Probe
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
        /// Reason for the status of the Probe
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
        /// Уникальный идентификатор для объекта Проект, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_ditributors")]
        public Microsoft.Xrm.Client.CrmEntityReference svk_ditributors
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_ditributors");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_ditributors", "svk_ditributors", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_loginftp")]
        public string svk_loginFTP
        {
            get
            {
                return this.GetAttributeValue<string>("svk_loginftp");
            }
            set
            {
                this.SetAttributeValue<string>("svk_loginFTP", "svk_loginftp", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Карточка клиента.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_otvetstvenniy")]
        public Microsoft.Xrm.Client.CrmEntityReference svk_otvetstvenniy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_otvetstvenniy");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("svk_otvetstvenniy", "svk_otvetstvenniy", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_passwordftp")]
        public string svk_passwordFTP
        {
            get
            {
                return this.GetAttributeValue<string>("svk_passwordftp");
            }
            set
            {
                this.SetAttributeValue<string>("svk_passwordFTP", "svk_passwordftp", value);
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
        /// 1:N new_new_probe_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_new_probe_account")]
        public System.Collections.Generic.IEnumerable<Account> new_new_probe_account
        {
            get
            {
                return this.GetRelatedEntities<Account>("new_new_probe_account", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("new_new_probe_account", "new_new_probe_account", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_new_probe_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_new_probe_incident")]
        public System.Collections.Generic.IEnumerable<Incident> new_new_probe_incident
        {
            get
            {
                return this.GetRelatedEntities<Incident>("new_new_probe_incident", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("new_new_probe_incident", "new_new_probe_incident", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_new_probe_svk_project_customer_card
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_new_probe_svk_project_customer_card")]
        public System.Collections.Generic.IEnumerable<svk_project> new_new_probe_svk_project_customer_card
        {
            get
            {
                return this.GetRelatedEntities<svk_project>("new_new_probe_svk_project_customer_card", null);
            }
            set
            {
                this.SetRelatedEntities<svk_project>("new_new_probe_svk_project_customer_card", "new_new_probe_svk_project_customer_card", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_probe_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> new_probe_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("new_probe_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("new_probe_ActivityPointers", "new_probe_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_probe_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> new_probe_Annotations
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("new_probe_Annotations", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("new_probe_Annotations", "new_probe_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_probe_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_Emails")]
        public System.Collections.Generic.IEnumerable<Email> new_probe_Emails
        {
            get
            {
                return this.GetRelatedEntities<Email>("new_probe_Emails", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("new_probe_Emails", "new_probe_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_probe_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_iok_action_send_SMSes")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> new_probe_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("new_probe_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("new_probe_iok_action_send_SMSes", "new_probe_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_sotrudniki
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_sotrudniki")]
        public System.Collections.Generic.IEnumerable<Contact> new_sotrudniki
        {
            get
            {
                return this.GetRelatedEntities<Contact>("new_sotrudniki", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("new_sotrudniki", "new_sotrudniki", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_probe_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_createdby")]
        public SystemUser lk_new_probe_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_probe_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_probe_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_createdonbehalfby")]
        public SystemUser lk_new_probe_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_probe_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_probe_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_modifiedby")]
        public SystemUser lk_new_probe_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_probe_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_probe_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_probe_modifiedonbehalfby")]
        public SystemUser lk_new_probe_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_probe_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 new_account_new_probe
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_organization")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_account_new_probe")]
        public Account new_account_new_probe
        {
            get
            {
                return this.GetRelatedEntity<Account>("new_account_new_probe", null);
            }
            set
            {
                this.SetRelatedEntity<Account>("new_account_new_probe", "new_account_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_new_probe
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_integrator")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_new_probe")]
        public Contact new_contact_new_probe
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_new_probe", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_new_probe", "new_contact_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_new_probe_menedjer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_menedjer")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_new_probe_menedjer")]
        public Contact new_contact_new_probe_menedjer
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_new_probe_menedjer", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_new_probe_menedjer", "new_contact_new_probe_menedjer", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_new_probe_operator1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_operator1")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_new_probe_operator1")]
        public Contact new_contact_new_probe_operator1
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_new_probe_operator1", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_new_probe_operator1", "new_contact_new_probe_operator1", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_new_probe_podderj_integr
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_podderj_integr")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_new_probe_podderj_integr")]
        public Contact new_contact_new_probe_podderj_integr
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_new_probe_podderj_integr", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_new_probe_podderj_integr", "new_contact_new_probe_podderj_integr", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_new_probe_spec
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_1cid_spec")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_new_probe_spec")]
        public Contact new_contact_new_probe_spec
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_new_probe_spec", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_new_probe_spec", "new_contact_new_probe_spec", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_contact_new_probe_sysadmin
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_sysadmin")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_new_probe_sysadmin")]
        public Contact new_contact_new_probe_sysadmin
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_contact_new_probe_sysadmin", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_contact_new_probe_sysadmin", "new_contact_new_probe_sysadmin", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_kartochka_klienta
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_operator")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_kartochka_klienta")]
        public Contact new_kartochka_klienta
        {
            get
            {
                return this.GetRelatedEntity<Contact>("new_kartochka_klienta", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("new_kartochka_klienta", "new_kartochka_klienta", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_new_probe
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_prinyal_na_podderzhku")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_new_probe")]
        public SystemUser new_systemuser_new_probe
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("new_systemuser_new_probe", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("new_systemuser_new_probe", "new_systemuser_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_new_probe_insurance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_insurance")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_new_probe_insurance")]
        public SystemUser new_systemuser_new_probe_insurance
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("new_systemuser_new_probe_insurance", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("new_systemuser_new_probe_insurance", "new_systemuser_new_probe_insurance", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_new_probe_vnedrenec
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_vnedrenec")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_systemuser_new_probe_vnedrenec")]
        public SystemUser new_systemuser_new_probe_vnedrenec
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("new_systemuser_new_probe_vnedrenec", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("new_systemuser_new_probe_vnedrenec", "new_systemuser_new_probe_vnedrenec", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_svk_project_new_probe
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_ditributors")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_svk_project_new_probe")]
        public svk_project svk_svk_project_new_probe
        {
            get
            {
                return this.GetRelatedEntity<svk_project>("svk_svk_project_new_probe", null);
            }
            set
            {
                this.SetRelatedEntity<svk_project>("svk_svk_project_new_probe", "svk_svk_project_new_probe", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_systemuser_new_probe_otvetstvenniy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("svk_otvetstvenniy")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_systemuser_new_probe_otvetstvenniy")]
        public SystemUser svk_systemuser_new_probe_otvetstvenniy
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("svk_systemuser_new_probe_otvetstvenniy", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("svk_systemuser_new_probe_otvetstvenniy", "svk_systemuser_new_probe_otvetstvenniy", null, value);
            }
        }
    }
}