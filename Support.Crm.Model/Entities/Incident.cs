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
    /// Service request case associated with a contract.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("incident")]
    [GeneratedCode("CrmSvcUtil", "5.0.9690.3739")]
    [DataServiceKey("Id")]
    [IgnoreProperties("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Entity("IncidentSet")]
    public class Incident : CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Incident() : base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "incident";
		
        public const int EntityTypeCode = 112;
		
        /// <summary>
        /// Уникальный идентификатор организации, с которой связано обращение.
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
        /// Actual number of service units provided for the case. 
        /// </summary>
        [AttributeLogicalName("actualserviceunits")]
        public int? ActualServiceUnits
        {
            get
            {
                return GetAttributeValue<int?>("actualserviceunits");
            }
            set
            {
                SetAttributeValue<int?>("ActualServiceUnits", "actualserviceunits", value);
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
        /// Число единиц сервиса, за которые выставлен счет по обращению.
        /// </summary>
        [AttributeLogicalName("billedserviceunits")]
        public int? BilledServiceUnits
        {
            get
            {
                return GetAttributeValue<int?>("billedserviceunits");
            }
            set
            {
                SetAttributeValue<int?>("BilledServiceUnits", "billedserviceunits", value);
            }
        }
		
        /// <summary>
        /// Сведения об источнике поступления обращения: Интернет, телефон или электронная почта.
        /// </summary>
        [AttributeLogicalName("caseorigincode")]
        public int? CaseOriginCode
        {
            get
            {
                return GetAttributeValue<int?>("caseorigincode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("CaseOriginCode", "caseorigincode", value);
            }
        }
		
        /// <summary>
        /// Сведения о типе обращения.
        /// </summary>
        [AttributeLogicalName("casetypecode")]
        public int? CaseTypeCode
        {
            get
            {
                return GetAttributeValue<int?>("casetypecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("CaseTypeCode", "casetypecode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор контакта, связанного с обращением.
        /// </summary>
        [AttributeLogicalName("contactid")]
        public CrmEntityReference ContactId
        {
            get
            {
                return GetAttributeValue<EntityReference>("contactid");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор конкретной позиции строки контракта, с которой связано обращение.
        /// </summary>
        [AttributeLogicalName("contractdetailid")]
        public CrmEntityReference ContractDetailId
        {
            get
            {
                return GetAttributeValue<EntityReference>("contractdetailid");
            }
            set
            {
                SetAttributeValue<EntityReference>("ContractDetailId", "contractdetailid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор контракта, указанный при обращении.
        /// </summary>
        [AttributeLogicalName("contractid")]
        public CrmEntityReference ContractId
        {
            get
            {
                return GetAttributeValue<EntityReference>("contractid");
            }
            set
            {
                SetAttributeValue<EntityReference>("ContractId", "contractid", value);
            }
        }
		
        /// <summary>
        /// Уровень ответа на обращение. Уровень ответа соответствует уровню обслуживания, указанному в контракте.
        /// </summary>
        [AttributeLogicalName("contractservicelevelcode")]
        public int? ContractServiceLevelCode
        {
            get
            {
                return GetAttributeValue<int?>("contractservicelevelcode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("ContractServiceLevelCode", "contractservicelevelcode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего обращение.
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
        /// Дата и время создания обращения.
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
        /// Уникальный идентификатор делегированного пользователя, создавшего инцидент.
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
        /// Уникальный идентификатор организации или контакта, связанных с обращением.
        /// </summary>
        [AttributeLogicalName("customerid")]
        public CrmEntityReference CustomerId
        {
            get
            {
                return GetAttributeValue<EntityReference>("customerid");
            }
            set
            {
                SetAttributeValue<EntityReference>("CustomerId", "customerid", value);
            }
        }
		
        /// <summary>
        /// Степень удовлетворенности клиента разрешением обращения.
        /// </summary>
        [AttributeLogicalName("customersatisfactioncode")]
        public int? CustomerSatisfactionCode
        {
            get
            {
                return GetAttributeValue<int?>("customersatisfactioncode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("CustomerSatisfactionCode", "customersatisfactioncode", value);
            }
        }
		
        /// <summary>
        /// Описание обращения.
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
        /// Обменный курс валюты, связанной с инцидентом, по отношению к базовой валюте.
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
        /// Выберите существующее обращение для клиента, который заполнен. Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalName("existingcase")]
        public CrmEntityReference ExistingCase
        {
            get
            {
                return GetAttributeValue<EntityReference>("existingcase");
            }
            set
            {
                SetAttributeValue<EntityReference>("ExistingCase", "existingcase", value);
            }
        }
		
        /// <summary>
        /// Дата, до которой представитель службы поддержки должен обработать обращение.
        /// </summary>
        [AttributeLogicalName("followupby")]
        public DateTime? FollowupBy
        {
            get
            {
                return GetAttributeValue<DateTime?>("followupby");
            }
            set
            {
                SetAttributeValue<DateTime?>("FollowupBy", "followupby", value);
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
        /// Уникальный идентификатор обращения.
        /// </summary>
        [AttributeLogicalName("incidentid")]
        public Guid? IncidentId
        {
            get
            {
                return GetAttributeValue<Guid?>("incidentid");
            }
            set
            {
                SetPrimaryIdAttributeValue<Guid?>("IncidentId", "incidentid", value);
            }
        }
		
        [AttributeLogicalName("incidentid")]
        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                IncidentId = value;
            }
        }
		
        /// <summary>
        /// Стадия процесса разрешения обращения.
        /// </summary>
        [AttributeLogicalName("incidentstagecode")]
        public int? IncidentStageCode
        {
            get
            {
                return GetAttributeValue<int?>("incidentstagecode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("IncidentStageCode", "incidentstagecode", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_1_liniya_defekt")]
        public bool? iok_1_liniya_defekt
        {
            get
            {
                return GetAttributeValue<bool?>("iok_1_liniya_defekt");
            }
            set
            {
                SetAttributeValue<bool?>("iok_1_liniya_defekt", "iok_1_liniya_defekt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_birzha")]
        public int? iok_birzha
        {
            get
            {
                return GetAttributeValue<int?>("iok_birzha");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_birzha", "iok_birzha", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_bp_description")]
        public string iok_BP_description
        {
            get
            {
                return GetAttributeValue<string>("iok_bp_description");
            }
            set
            {
                SetAttributeValue<string>("iok_BP_description", "iok_bp_description", value);
            }
        }
		
        /// <summary>
        /// ID звонка, который привел к регистрации обращения
        /// </summary>
        [AttributeLogicalName("iok_callid")]
        public string iok_callid
        {
            get
            {
                return GetAttributeValue<string>("iok_callid");
            }
            set
            {
                SetAttributeValue<string>("iok_callid", "iok_callid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_changeinternalstate")]
        public bool? iok_changeinternalstate
        {
            get
            {
                return GetAttributeValue<bool?>("iok_changeinternalstate");
            }
            set
            {
                SetAttributeValue<bool?>("iok_changeinternalstate", "iok_changeinternalstate", value);
            }
        }
		
        /// <summary>
        /// поле для сильверлайт-контрола отправки комментария
        /// </summary>
        [AttributeLogicalName("iok_commentaction")]
        public int? iok_commentaction
        {
            get
            {
                return GetAttributeValue<int?>("iok_commentaction");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_commentaction", "iok_commentaction", value);
            }
        }
		
        /// <summary>
        /// Поле для сильверлайт-контрола отправки комментариев
        /// </summary>
        [AttributeLogicalName("iok_commenttext")]
        public string iok_commenttext
        {
            get
            {
                return GetAttributeValue<string>("iok_commenttext");
            }
            set
            {
                SetAttributeValue<string>("iok_commenttext", "iok_commenttext", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_developershavetime")]
        public bool? iok_developershaveTime
        {
            get
            {
                return GetAttributeValue<bool?>("iok_developershavetime");
            }
            set
            {
                SetAttributeValue<bool?>("iok_developershaveTime", "iok_developershavetime", value);
            }
        }
		
        /// <summary>
        /// поле поиска контакта для копии письма. Для сильверлайт-контрорла отправки комментария.
        /// </summary>
        [AttributeLogicalName("iok_emailcopyfield")]
        public CrmEntityReference iok_emailcopyfield
        {
            get
            {
                return GetAttributeValue<EntityReference>("iok_emailcopyfield");
            }
            set
            {
                SetAttributeValue<EntityReference>("iok_emailcopyfield", "iok_emailcopyfield", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_emailsendmark")]
        public bool? iok_emailsendmark
        {
            get
            {
                return GetAttributeValue<bool?>("iok_emailsendmark");
            }
            set
            {
                SetAttributeValue<bool?>("iok_emailsendmark", "iok_emailsendmark", value);
            }
        }
		
        /// <summary>
        /// Поле поиска контакта для отправки письма для сильверлайт-контрола добавления комментария
        /// </summary>
        [AttributeLogicalName("iok_emailto")]
        public CrmEntityReference iok_emailto
        {
            get
            {
                return GetAttributeValue<EntityReference>("iok_emailto");
            }
            set
            {
                SetAttributeValue<EntityReference>("iok_emailto", "iok_emailto", value);
            }
        }
		
        /// <summary>
        /// Костыль для корректного создания обращения - не дает отправлять сообщение о смене приоритета в автоматическом режиме при создании обращения
        /// </summary>
        [AttributeLogicalName("iok_firstrun")]
        public bool? iok_FirstRun
        {
            get
            {
                return GetAttributeValue<bool?>("iok_firstrun");
            }
            set
            {
                SetAttributeValue<bool?>("iok_FirstRun", "iok_firstrun", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_gki")]
        public int? iok_GKI
        {
            get
            {
                return GetAttributeValue<int?>("iok_gki");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_GKI", "iok_gki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_isfavorite")]
        public bool? iok_isfavorite
        {
            get
            {
                return GetAttributeValue<bool?>("iok_isfavorite");
            }
            set
            {
                SetAttributeValue<bool?>("iok_isfavorite", "iok_isfavorite", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Проект, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("iok_kk_project")]
        public CrmEntityReference iok_KK_project
        {
            get
            {
                return GetAttributeValue<EntityReference>("iok_kk_project");
            }
            set
            {
                SetAttributeValue<EntityReference>("iok_KK_project", "iok_kk_project", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_new_plan_analysic_man_hour_before")]
        public double? iok_new_plan_analysic_man_hour_before
        {
            get
            {
                return GetAttributeValue<double?>("iok_new_plan_analysic_man_hour_before");
            }
            set
            {
                SetAttributeValue<double?>("iok_new_plan_analysic_man_hour_before", "iok_new_plan_analysic_man_hour_before", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_new_plan_deployment_before")]
        public double? iok_new_plan_deployment_before
        {
            get
            {
                return GetAttributeValue<double?>("iok_new_plan_deployment_before");
            }
            set
            {
                SetAttributeValue<double?>("iok_new_plan_deployment_before", "iok_new_plan_deployment_before", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_new_plan_realization_man_hour_before")]
        public double? iok_new_plan_realization_man_hour_before
        {
            get
            {
                return GetAttributeValue<double?>("iok_new_plan_realization_man_hour_before");
            }
            set
            {
                SetAttributeValue<double?>("iok_new_plan_realization_man_hour_before", "iok_new_plan_realization_man_hour_before", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_new_plan_uat_before")]
        public double? iok_new_plan_uat_before
        {
            get
            {
                return GetAttributeValue<double?>("iok_new_plan_uat_before");
            }
            set
            {
                SetAttributeValue<double?>("iok_new_plan_uat_before", "iok_new_plan_uat_before", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Обращение, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("iok_parentincident")]
        public CrmEntityReference iok_parentincident
        {
            get
            {
                return GetAttributeValue<EntityReference>("iok_parentincident");
            }
            set
            {
                SetAttributeValue<EntityReference>("iok_parentincident", "iok_parentincident", value);
            }
        }
		
        /// <summary>
        /// Ссылка на обращение на портале
        /// </summary>
        [AttributeLogicalName("iok_portal_url")]
        public string iok_portal_url
        {
            get
            {
                return GetAttributeValue<string>("iok_portal_url");
            }
            set
            {
                SetAttributeValue<string>("iok_portal_url", "iok_portal_url", value);
            }
        }
		
        /// <summary>
        /// тип уточнения для сильверлайт-контрола создания комментария
        /// </summary>
        [AttributeLogicalName("iok_questiontype")]
        public int? iok_questiontype
        {
            get
            {
                return GetAttributeValue<int?>("iok_questiontype");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_questiontype", "iok_questiontype", value);
            }
        }
		
        /// <summary>
        /// Поле - костыль для корректной регистрации обращений с помощью БП "Регистрация.СозданиеОбращения". решает проблему отправки письма в случае смены приоритета непосредственно при создании обращения.
        /// </summary>
        [AttributeLogicalName("iok_registerpriorhack")]
        public bool? iok_RegisterPriorHack
        {
            get
            {
                return GetAttributeValue<bool?>("iok_registerpriorhack");
            }
            set
            {
                SetAttributeValue<bool?>("iok_RegisterPriorHack", "iok_registerpriorhack", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("iok_reopen_portal_user")]
        public CrmEntityReference iok_reopen_portal_user
        {
            get
            {
                return GetAttributeValue<EntityReference>("iok_reopen_portal_user");
            }
            set
            {
                SetAttributeValue<EntityReference>("iok_reopen_portal_user", "iok_reopen_portal_user", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_resolvebyphone")]
        public bool? iok_resolvebyphone
        {
            get
            {
                return GetAttributeValue<bool?>("iok_resolvebyphone");
            }
            set
            {
                SetAttributeValue<bool?>("iok_resolvebyphone", "iok_resolvebyphone", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_sdo_reg")]
        public string iok_sdo_reg
        {
            get
            {
                return GetAttributeValue<string>("iok_sdo_reg");
            }
            set
            {
                SetAttributeValue<string>("iok_sdo_reg", "iok_sdo_reg", value);
            }
        }
		
        /// <summary>
        /// Поле даты для откладывания обращения в сильверлайт-контроле отправки комментария
        /// </summary>
        [AttributeLogicalName("iok_sleepuntill")]
        public DateTime? iok_sleepuntill
        {
            get
            {
                return GetAttributeValue<DateTime?>("iok_sleepuntill");
            }
            set
            {
                SetAttributeValue<DateTime?>("iok_sleepuntill", "iok_sleepuntill", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_sort_group")]
        public int? iok_sort_group
        {
            get
            {
                return GetAttributeValue<int?>("iok_sort_group");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_sort_group", "iok_sort_group", value);
            }
        }
		
        /// <summary>
        /// Затраченное время на решение обращения в минутах (Время HDA). Необходимо для БП, который списывает количество часов и обращений из проекта.
        /// </summary>
        [AttributeLogicalName("iok_spendedtime")]
        public int? iok_spendedTime
        {
            get
            {
                return GetAttributeValue<int?>("iok_spendedtime");
            }
            set
            {
                SetAttributeValue<int?>("iok_spendedTime", "iok_spendedtime", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_zzl_data_peredachi_dorabotki_clientu")]
        public DateTime? iok_zzl_data_peredachi_dorabotki_clientu
        {
            get
            {
                return GetAttributeValue<DateTime?>("iok_zzl_data_peredachi_dorabotki_clientu");
            }
            set
            {
                SetAttributeValue<DateTime?>("iok_zzl_data_peredachi_dorabotki_clientu", "iok_zzl_data_peredachi_dorabotki_clientu", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_zzl_data_realizatcii_dorabotki")]
        public DateTime? iok_zzl_data_realizatcii_dorabotki
        {
            get
            {
                return GetAttributeValue<DateTime?>("iok_zzl_data_realizatcii_dorabotki");
            }
            set
            {
                SetAttributeValue<DateTime?>("iok_zzl_data_realizatcii_dorabotki", "iok_zzl_data_realizatcii_dorabotki", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("iok_zzl_payment_mark")]
        public int? iok_zzl_payment_mark
        {
            get
            {
                return GetAttributeValue<int?>("iok_zzl_payment_mark");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("iok_zzl_payment_mark", "iok_zzl_payment_mark", value);
            }
        }
		
        /// <summary>
        /// Сведения об уменьшении числа вопросов в обращении.
        /// </summary>
        [AttributeLogicalName("isdecrementing")]
        public bool? IsDecrementing
        {
            get
            {
                return GetAttributeValue<bool?>("isdecrementing");
            }
            set
            {
                SetAttributeValue<bool?>("IsDecrementing", "isdecrementing", value);
            }
        }
		
        /// <summary>
        /// Unique identifier of the knowledge base article associated with the case.
        /// </summary>
        [AttributeLogicalName("kbarticleid")]
        public CrmEntityReference KbArticleId
        {
            get
            {
                return GetAttributeValue<EntityReference>("kbarticleid");
            }
            set
            {
                SetAttributeValue<EntityReference>("KbArticleId", "kbarticleid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор последнего пользователя, изменившего обращение.
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
        /// Дата и время последнего изменения обращения.
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
        /// Уникальный идентификатор последнего делегированного пользователя, изменившего инцидент.
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
        /// Allows a partner contact to be assigned to a specific case.
        /// </summary>
        [AttributeLogicalName("msa_partnercontactid")]
        public CrmEntityReference msa_partnercontactid
        {
            get
            {
                return GetAttributeValue<EntityReference>("msa_partnercontactid");
            }
            set
            {
                SetAttributeValue<EntityReference>("msa_partnercontactid", "msa_partnercontactid", value);
            }
        }
		
        /// <summary>
        /// Creates a Relationship between a Partner (account) and a case for indirect service arrangements.
        /// </summary>
        [AttributeLogicalName("msa_partnerid")]
        public CrmEntityReference msa_partnerid
        {
            get
            {
                return GetAttributeValue<EntityReference>("msa_partnerid");
            }
            set
            {
                SetAttributeValue<EntityReference>("msa_partnerid", "msa_partnerid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("msa_webportalcloseflag")]
        public bool? MSA_WebPortalCloseFlag
        {
            get
            {
                return GetAttributeValue<bool?>("msa_webportalcloseflag");
            }
            set
            {
                SetAttributeValue<bool?>("MSA_WebPortalCloseFlag", "msa_webportalcloseflag", value);
            }
        }
		
        /// <summary>
        /// Выбор наличия альтернативного решения
        /// </summary>
        [AttributeLogicalName("new_alt_solution")]
        public bool? new_alt_solution
        {
            get
            {
                return GetAttributeValue<bool?>("new_alt_solution");
            }
            set
            {
                SetAttributeValue<bool?>("new_alt_solution", "new_alt_solution", value);
            }
        }
		
        /// <summary>
        /// Заносится альтернативный вариант реализации. Если его нет - выхода нет!
        ///или комментарий тестировщика о качестве переданного обращения
        /// </summary>
        [AttributeLogicalName("new_alt_variant")]
        public string New_alt_variant
        {
            get
            {
                return GetAttributeValue<string>("new_alt_variant");
            }
            set
            {
                SetAttributeValue<string>("New_alt_variant", "new_alt_variant", value);
            }
        }
		
        /// <summary>
        /// поле для проставления состояний по обращению для аналитика.
        /// </summary>
        [AttributeLogicalName("new_analit")]
        public int? New_analit
        {
            get
            {
                return GetAttributeValue<int?>("new_analit");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_analit", "new_analit", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_analitic_uchastie")]
        public bool? new_analitic_uchastie
        {
            get
            {
                return GetAttributeValue<bool?>("new_analitic_uchastie");
            }
            set
            {
                SetAttributeValue<bool?>("new_analitic_uchastie", "new_analitic_uchastie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_analysis_man_hour")]
        public double? New_analysis_man_hour
        {
            get
            {
                return GetAttributeValue<double?>("new_analysis_man_hour");
            }
            set
            {
                SetAttributeValue<double?>("New_analysis_man_hour", "new_analysis_man_hour", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_birzha")]
        public bool? new_birzha
        {
            get
            {
                return GetAttributeValue<bool?>("new_birzha");
            }
            set
            {
                SetAttributeValue<bool?>("new_birzha", "new_birzha", value);
            }
        }
		
        /// <summary>
        /// билд ПО, в котором буде исправлена ошибка (если обращение вызванно ошибкой)
        /// </summary>
        [AttributeLogicalName("new_build")]
        public string New_Build
        {
            get
            {
                return GetAttributeValue<string>("new_build");
            }
            set
            {
                SetAttributeValue<string>("New_Build", "new_build", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_business_process")]
        public int? New_business_process
        {
            get
            {
                return GetAttributeValue<int?>("new_business_process");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_business_process", "new_business_process", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_cause_level_2")]
        public int? New_cause_level_2
        {
            get
            {
                return GetAttributeValue<int?>("new_cause_level_2");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_cause_level_2", "new_cause_level_2", value);
            }
        }
		
        /// <summary>
        /// Список выбора возможных причин возникновения ошибок у пользователя
        /// </summary>
        [AttributeLogicalName("new_cause_of_error")]
        public int? New_cause_of_error
        {
            get
            {
                return GetAttributeValue<int?>("new_cause_of_error");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_cause_of_error", "new_cause_of_error", value);
            }
        }
		
        /// <summary>
        /// Второй уровень классификации списка причин возникновения ошибок
        /// </summary>
        [AttributeLogicalName("new_cause_of_error_level_2")]
        public int? New_cause_of_error_level_2
        {
            get
            {
                return GetAttributeValue<int?>("new_cause_of_error_level_2");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_cause_of_error_level_2", "new_cause_of_error_level_2", value);
            }
        }
		
        /// <summary>
        /// причина переноса крайней (плановой) даты решения обращения
        /// </summary>
        [AttributeLogicalName("new_cause_of_move")]
        public int? New_cause_of_move
        {
            get
            {
                return GetAttributeValue<int?>("new_cause_of_move");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_cause_of_move", "new_cause_of_move", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_causeofsleep")]
        public int? new_CauseOfSleep
        {
            get
            {
                return GetAttributeValue<int?>("new_causeofsleep");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("new_CauseOfSleep", "new_causeofsleep", value);
            }
        }
		
        /// <summary>
        /// В этом поле отмечается результат проврки датацентра
        /// </summary>
        [AttributeLogicalName("new_checkdcresult")]
        public int? New_CheckDCResult
        {
            get
            {
                return GetAttributeValue<int?>("new_checkdcresult");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_CheckDCResult", "new_checkdcresult", value);
            }
        }
		
        /// <summary>
        /// Текстовое описание тестов, которые не прошли
        /// </summary>
        [AttributeLogicalName("new_checksdcfailed")]
        public string New_ChecksDCFailed
        {
            get
            {
                return GetAttributeValue<string>("new_checksdcfailed");
            }
            set
            {
                SetAttributeValue<string>("New_ChecksDCFailed", "new_checksdcfailed", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_chicago_uchastie")]
        public bool? new_chicago_uchastie
        {
            get
            {
                return GetAttributeValue<bool?>("new_chicago_uchastie");
            }
            set
            {
                SetAttributeValue<bool?>("new_chicago_uchastie", "new_chicago_uchastie", value);
            }
        }
		
        /// <summary>
        /// Код объекта в ClearQuest
        /// </summary>
        [AttributeLogicalName("new_clearquest")]
        public string New_ClearQuest
        {
            get
            {
                return GetAttributeValue<string>("new_clearquest");
            }
            set
            {
                SetAttributeValue<string>("New_ClearQuest", "new_clearquest", value);
            }
        }
		
        /// <summary>
        /// Комментарий, мнение руководства Клиента
        /// </summary>
        [AttributeLogicalName("new_clientleaderopinion")]
        public string New_ClientLeaderOpinion
        {
            get
            {
                return GetAttributeValue<string>("new_clientleaderopinion");
            }
            set
            {
                SetAttributeValue<string>("New_ClientLeaderOpinion", "new_clientleaderopinion", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_close_child")]
        public bool? new_close_child
        {
            get
            {
                return GetAttributeValue<bool?>("new_close_child");
            }
            set
            {
                SetAttributeValue<bool?>("new_close_child", "new_close_child", value);
            }
        }
		
        /// <summary>
        /// Отправить и закрыть форму
        /// </summary>
        [AttributeLogicalName("new_closeformcheckbox")]
        public bool? new_CloseFormCheckBox
        {
            get
            {
                return GetAttributeValue<bool?>("new_closeformcheckbox");
            }
            set
            {
                SetAttributeValue<bool?>("new_CloseFormCheckBox", "new_closeformcheckbox", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_comment")]
        public string New_Comment
        {
            get
            {
                return GetAttributeValue<string>("new_comment");
            }
            set
            {
                SetAttributeValue<string>("New_Comment", "new_comment", value);
            }
        }
		
        /// <summary>
        /// вносится текст для добавления в поле "комментарий".
        /// </summary>
        [AttributeLogicalName("new_comment_text")]
        public string New_comment_text
        {
            get
            {
                return GetAttributeValue<string>("new_comment_text");
            }
            set
            {
                SetAttributeValue<string>("New_comment_text", "new_comment_text", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_complexity_analit")]
        public int? New_complexity_analit
        {
            get
            {
                return GetAttributeValue<int?>("new_complexity_analit");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_complexity_analit", "new_complexity_analit", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_complexity_eng")]
        public int? New_complexity_eng
        {
            get
            {
                return GetAttributeValue<int?>("new_complexity_eng");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_complexity_eng", "new_complexity_eng", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_contract_state")]
        public int? New_contract_state
        {
            get
            {
                return GetAttributeValue<int?>("new_contract_state");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_contract_state", "new_contract_state", value);
            }
        }
		
        /// <summary>
        /// счетчик отсылки уточнений
        /// </summary>
        [AttributeLogicalName("new_count_sv")]
        public int? new_count_sv
        {
            get
            {
                return GetAttributeValue<int?>("new_count_sv");
            }
            set
            {
                SetAttributeValue<int?>("new_count_sv", "new_count_sv", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_crucialspecialist")]
        public string New_CrucialSpecialist
        {
            get
            {
                return GetAttributeValue<string>("new_crucialspecialist");
            }
            set
            {
                SetAttributeValue<string>("New_CrucialSpecialist", "new_crucialspecialist", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_data_send_notif")]
        public DateTime? New_data_send_notif
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_data_send_notif");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_data_send_notif", "new_data_send_notif", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_date_create")]
        public DateTime? New_date_create
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_date_create");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_date_create", "new_date_create", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_date_end")]
        public DateTime? New_date_end
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_date_end");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_date_end", "new_date_end", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_date_enter")]
        public DateTime? New_date_enter
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_date_enter");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_date_enter", "new_date_enter", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_date_plan")]
        public DateTime? New_date_plan
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_date_plan");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_date_plan", "new_date_plan", value);
            }
        }
		
        /// <summary>
        /// Дата полной загрузки
        /// </summary>
        [AttributeLogicalName("new_datedownload")]
        public string new_dateDownload
        {
            get
            {
                return GetAttributeValue<string>("new_datedownload");
            }
            set
            {
                SetAttributeValue<string>("new_dateDownload", "new_datedownload", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Дефект, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_defekt")]
        public CrmEntityReference new_defekt
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_defekt");
            }
            set
            {
                SetAttributeValue<EntityReference>("new_defekt", "new_defekt", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_deviation_percent")]
        public double? New_deviation_percent
        {
            get
            {
                return GetAttributeValue<double?>("new_deviation_percent");
            }
            set
            {
                SetAttributeValue<double?>("New_deviation_percent", "new_deviation_percent", value);
            }
        }
		
        /// <summary>
        /// Признак «Серийная/индивидуальная доработка» с тремя статусами: серийная, индивидуальная, смешанная.
        /// </summary>
        [AttributeLogicalName("new_dorabotka")]
        public int? new_dorabotka
        {
            get
            {
                return GetAttributeValue<int?>("new_dorabotka");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("new_dorabotka", "new_dorabotka", value);
            }
        }
		
        /// <summary>
        /// Ошибка возникла в результате обновления?
        /// </summary>
        [AttributeLogicalName("new_error_after_update")]
        public bool? New_error_after_update
        {
            get
            {
                return GetAttributeValue<bool?>("new_error_after_update");
            }
            set
            {
                SetAttributeValue<bool?>("New_error_after_update", "new_error_after_update", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_fact_deployment")]
        public double? New_fact_deployment
        {
            get
            {
                return GetAttributeValue<double?>("new_fact_deployment");
            }
            set
            {
                SetAttributeValue<double?>("New_fact_deployment", "new_fact_deployment", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_fact_uat")]
        public double? New_fact_UAT
        {
            get
            {
                return GetAttributeValue<double?>("new_fact_uat");
            }
            set
            {
                SetAttributeValue<double?>("New_fact_UAT", "new_fact_uat", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_fixed")]
        public bool? New_fixed
        {
            get
            {
                return GetAttributeValue<bool?>("new_fixed");
            }
            set
            {
                SetAttributeValue<bool?>("New_fixed", "new_fixed", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_gki")]
        public bool? new_gki
        {
            get
            {
                return GetAttributeValue<bool?>("new_gki");
            }
            set
            {
                SetAttributeValue<bool?>("new_gki", "new_gki", value);
            }
        }
		
        /// <summary>
        /// содержит гуиид
        /// </summary>
        [AttributeLogicalName("new_guid")]
        public string New_guid
        {
            get
            {
                return GetAttributeValue<string>("new_guid");
            }
            set
            {
                SetAttributeValue<string>("New_guid", "new_guid", value);
            }
        }
		
        /// <summary>
        /// пишется лог изменений по обращению.
        /// </summary>
        [AttributeLogicalName("new_history")]
        public string New_history
        {
            get
            {
                return GetAttributeValue<string>("new_history");
            }
            set
            {
                SetAttributeValue<string>("New_history", "new_history", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_hochu_znat")]
        public bool? new_hochu_znat
        {
            get
            {
                return GetAttributeValue<bool?>("new_hochu_znat");
            }
            set
            {
                SetAttributeValue<bool?>("new_hochu_znat", "new_hochu_znat", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_influence_to_business")]
        public string New_influence_to_business
        {
            get
            {
                return GetAttributeValue<string>("new_influence_to_business");
            }
            set
            {
                SetAttributeValue<string>("New_influence_to_business", "new_influence_to_business", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_jobtitle")]
        public string New_jobtitle
        {
            get
            {
                return GetAttributeValue<string>("new_jobtitle");
            }
            set
            {
                SetAttributeValue<string>("New_jobtitle", "new_jobtitle", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_klassifikator")]
        public int? New_klassifikator
        {
            get
            {
                return GetAttributeValue<int?>("new_klassifikator");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_klassifikator", "new_klassifikator", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_kto_hochet_znat")]
        public CrmEntityReference new_Kto_hochet_znat
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_kto_hochet_znat");
            }
            set
            {
                SetAttributeValue<EntityReference>("new_Kto_hochet_znat", "new_kto_hochet_znat", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_last_owner")]
        public CrmEntityReference New_last_owner
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_last_owner");
            }
            set
            {
                SetAttributeValue<EntityReference>("New_last_owner", "new_last_owner", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_licen")]
        public string New_licen
        {
            get
            {
                return GetAttributeValue<string>("new_licen");
            }
            set
            {
                SetAttributeValue<string>("New_licen", "new_licen", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_locator_uchastie")]
        public bool? new_locator_uchastie
        {
            get
            {
                return GetAttributeValue<bool?>("new_locator_uchastie");
            }
            set
            {
                SetAttributeValue<bool?>("new_locator_uchastie", "new_locator_uchastie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_man_hour")]
        public string New_Man_Hour
        {
            get
            {
                return GetAttributeValue<string>("new_man_hour");
            }
            set
            {
                SetAttributeValue<string>("New_Man_Hour", "new_man_hour", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_man_hour_money")]
        public string New_man_hour_money
        {
            get
            {
                return GetAttributeValue<string>("new_man_hour_money");
            }
            set
            {
                SetAttributeValue<string>("New_man_hour_money", "new_man_hour_money", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_mt_uchastie")]
        public bool? new_MT_uchastie
        {
            get
            {
                return GetAttributeValue<bool?>("new_mt_uchastie");
            }
            set
            {
                SetAttributeValue<bool?>("new_MT_uchastie", "new_mt_uchastie", value);
            }
        }
		
        /// <summary>
        /// Номер маршрута, достаем с сущности Контакт.
        /// </summary>
        [AttributeLogicalName("new_numberrouteofcontact")]
        public string new_NumberRouteOfContact
        {
            get
            {
                return GetAttributeValue<string>("new_numberrouteofcontact");
            }
            set
            {
                SetAttributeValue<string>("new_NumberRouteOfContact", "new_numberrouteofcontact", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_observer")]
        public string new_observer
        {
            get
            {
                return GetAttributeValue<string>("new_observer");
            }
            set
            {
                SetAttributeValue<string>("new_observer", "new_observer", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_observer1")]
        public CrmEntityReference new_observer1
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_observer1");
            }
            set
            {
                SetAttributeValue<EntityReference>("new_observer1", "new_observer1", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_obuchil_polzovatelya")]
        public bool? New_obuchil_polzovatelya
        {
            get
            {
                return GetAttributeValue<bool?>("new_obuchil_polzovatelya");
            }
            set
            {
                SetAttributeValue<bool?>("New_obuchil_polzovatelya", "new_obuchil_polzovatelya", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_ocenka_testirovshika")]
        public int? New_ocenka_testirovshika
        {
            get
            {
                return GetAttributeValue<int?>("new_ocenka_testirovshika");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_ocenka_testirovshika", "new_ocenka_testirovshika", value);
            }
        }
		
        /// <summary>
        /// Порядок выполнения запроса
        /// </summary>
        [AttributeLogicalName("new_order")]
        public int? New_order
        {
            get
            {
                return GetAttributeValue<int?>("new_order");
            }
            set
            {
                SetAttributeValue<int?>("New_order", "new_order", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_orderst")]
        public int? New_orderST
        {
            get
            {
                return GetAttributeValue<int?>("new_orderst");
            }
            set
            {
                SetAttributeValue<int?>("New_orderST", "new_orderst", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_orient_stoim")]
        public int? New_orient_stoim
        {
            get
            {
                return GetAttributeValue<int?>("new_orient_stoim");
            }
            set
            {
                SetAttributeValue<int?>("New_orient_stoim", "new_orient_stoim", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_oshibka_vnedreniya")]
        public bool? New_oshibka_vnedreniya
        {
            get
            {
                return GetAttributeValue<bool?>("new_oshibka_vnedreniya");
            }
            set
            {
                SetAttributeValue<bool?>("New_oshibka_vnedreniya", "new_oshibka_vnedreniya", value);
            }
        }
		
        /// <summary>
        /// Отправил ли инженер памятку по этому вопросу?
        /// </summary>
        [AttributeLogicalName("new_otpravil_pamyatku")]
        public bool? New_otpravil_pamyatku
        {
            get
            {
                return GetAttributeValue<bool?>("new_otpravil_pamyatku");
            }
            set
            {
                SetAttributeValue<bool?>("New_otpravil_pamyatku", "new_otpravil_pamyatku", value);
            }
        }
		
        /// <summary>
        /// Поле необходимо для уведомления предыдущего Ответственного о переназначении.
        /// </summary>
        [AttributeLogicalName("new_owner_prev")]
        public string New_owner_prev
        {
            get
            {
                return GetAttributeValue<string>("new_owner_prev");
            }
            set
            {
                SetAttributeValue<string>("New_owner_prev", "new_owner_prev", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_owner_substitution")]
        public CrmEntityReference new_owner_substitution
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_owner_substitution");
            }
            set
            {
                SetAttributeValue<EntityReference>("new_owner_substitution", "new_owner_substitution", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_p_platnosti")]
        public int? New_p_platnosti
        {
            get
            {
                return GetAttributeValue<int?>("new_p_platnosti");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_p_platnosti", "new_p_platnosti", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_paid")]
        public int? New_paid
        {
            get
            {
                return GetAttributeValue<int?>("new_paid");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_paid", "new_paid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_paid_man_hour")]
        public string New_paid_man_hour
        {
            get
            {
                return GetAttributeValue<string>("new_paid_man_hour");
            }
            set
            {
                SetAttributeValue<string>("New_paid_man_hour", "new_paid_man_hour", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_plan_analysis_man_hour")]
        public double? New_plan_analysis_man_hour
        {
            get
            {
                return GetAttributeValue<double?>("new_plan_analysis_man_hour");
            }
            set
            {
                SetAttributeValue<double?>("New_plan_analysis_man_hour", "new_plan_analysis_man_hour", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_plan_change")]
        public bool? New_plan_change
        {
            get
            {
                return GetAttributeValue<bool?>("new_plan_change");
            }
            set
            {
                SetAttributeValue<bool?>("New_plan_change", "new_plan_change", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_plan_change2")]
        public bool? New_plan_change2
        {
            get
            {
                return GetAttributeValue<bool?>("new_plan_change2");
            }
            set
            {
                SetAttributeValue<bool?>("New_plan_change2", "new_plan_change2", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_plan_deployment")]
        public double? New_plan_deployment
        {
            get
            {
                return GetAttributeValue<double?>("new_plan_deployment");
            }
            set
            {
                SetAttributeValue<double?>("New_plan_deployment", "new_plan_deployment", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_plan_realization_man_hour")]
        public double? New_plan_realization_man_hour
        {
            get
            {
                return GetAttributeValue<double?>("new_plan_realization_man_hour");
            }
            set
            {
                SetAttributeValue<double?>("New_plan_realization_man_hour", "new_plan_realization_man_hour", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_plan_uat")]
        public double? New_plan_UAT
        {
            get
            {
                return GetAttributeValue<double?>("new_plan_uat");
            }
            set
            {
                SetAttributeValue<double?>("New_plan_UAT", "new_plan_uat", value);
            }
        }
		
        /// <summary>
        /// Плановая дата разрешения обращения. Зависит от приоритета.
        /// </summary>
        [AttributeLogicalName("new_planed_resolve")]
        public DateTime? New_planed_resolve
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_planed_resolve");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_planed_resolve", "new_planed_resolve", value);
            }
        }
		
        /// <summary>
        /// Карточка клиента
        /// </summary>
        [AttributeLogicalName("new_podderzhka_klienty")]
        public CrmEntityReference New_podderzhka_klienty
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_podderzhka_klienty");
            }
            set
            {
                SetAttributeValue<EntityReference>("New_podderzhka_klienty", "new_podderzhka_klienty", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_polnoe_zatrachennoe_vremya")]
        public int? new_polnoe_zatrachennoe_vremya
        {
            get
            {
                return GetAttributeValue<int?>("new_polnoe_zatrachennoe_vremya");
            }
            set
            {
                SetAttributeValue<int?>("new_polnoe_zatrachennoe_vremya", "new_polnoe_zatrachennoe_vremya", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_povtorenie_problemi_polzovatel")]
        public bool? New_povtorenie_problemi_polzovatel
        {
            get
            {
                return GetAttributeValue<bool?>("new_povtorenie_problemi_polzovatel");
            }
            set
            {
                SetAttributeValue<bool?>("New_povtorenie_problemi_polzovatel", "new_povtorenie_problemi_polzovatel", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_povtorno_otkr")]
        public CrmEntityReference new_povtorno_otkr
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_povtorno_otkr");
            }
            set
            {
                SetAttributeValue<EntityReference>("new_povtorno_otkr", "new_povtorno_otkr", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_povtorno_otkr_2")]
        public CrmEntityReference new_povtorno_otkr_2
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_povtorno_otkr_2");
            }
            set
            {
                SetAttributeValue<EntityReference>("new_povtorno_otkr_2", "new_povtorno_otkr_2", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_price")]
        public int? New_price
        {
            get
            {
                return GetAttributeValue<int?>("new_price");
            }
            set
            {
                SetAttributeValue<int?>("New_price", "new_price", value);
            }
        }
		
        /// <summary>
        /// Описание основной причины обращения
        /// </summary>
        [AttributeLogicalName("new_prichina")]
        public string New_prichina
        {
            get
            {
                return GetAttributeValue<string>("new_prichina");
            }
            set
            {
                SetAttributeValue<string>("New_prichina", "new_prichina", value);
            }
        }
		
        /// <summary>
        /// Проблема, к которой относится обращение
        /// </summary>
        [AttributeLogicalName("new_problem")]
        public CrmEntityReference New_problem
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_problem");
            }
            set
            {
                SetAttributeValue<EntityReference>("New_problem", "new_problem", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_problema_na_storone")]
        public int? New_problema_na_storone
        {
            get
            {
                return GetAttributeValue<int?>("new_problema_na_storone");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_problema_na_storone", "new_problema_na_storone", value);
            }
        }
		
        /// <summary>
        /// информация о проекте. из карточки организации-клиента
        /// </summary>
        [AttributeLogicalName("new_project")]
        public string New_project
        {
            get
            {
                return GetAttributeValue<string>("new_project");
            }
            set
            {
                SetAttributeValue<string>("New_project", "new_project", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_realization_man_hour")]
        public double? New_realization_man_hour
        {
            get
            {
                return GetAttributeValue<double?>("new_realization_man_hour");
            }
            set
            {
                SetAttributeValue<double?>("New_realization_man_hour", "new_realization_man_hour", value);
            }
        }
		
        /// <summary>
        /// Краткое описание причин просрочки плановой даты.
        /// </summary>
        [AttributeLogicalName("new_reason")]
        public string New_reason
        {
            get
            {
                return GetAttributeValue<string>("new_reason");
            }
            set
            {
                SetAttributeValue<string>("New_reason", "new_reason", value);
            }
        }
		
        /// <summary>
        /// Date and time when the case was received.
        /// </summary>
        [AttributeLogicalName("new_receive")]
        public DateTime? New_receive
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_receive");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_receive", "new_receive", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_reglament")]
        public string new_reglament
        {
            get
            {
                return GetAttributeValue<string>("new_reglament");
            }
            set
            {
                SetAttributeValue<string>("new_reglament", "new_reglament", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_replication_uchastie")]
        public bool? new_replication_uchastie
        {
            get
            {
                return GetAttributeValue<bool?>("new_replication_uchastie");
            }
            set
            {
                SetAttributeValue<bool?>("new_replication_uchastie", "new_replication_uchastie", value);
            }
        }
		
        /// <summary>
        /// Фактическая дата решения проставляется при разрешении обращения.
        /// </summary>
        [AttributeLogicalName("new_resolve")]
        public DateTime? New_resolve
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_resolve");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_resolve", "new_resolve", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_responsible")]
        public string New_responsible
        {
            get
            {
                return GetAttributeValue<string>("new_responsible");
            }
            set
            {
                SetAttributeValue<string>("New_responsible", "new_responsible", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_responsible_fullname")]
        public string New_responsible_fullname
        {
            get
            {
                return GetAttributeValue<string>("new_responsible_fullname");
            }
            set
            {
                SetAttributeValue<string>("New_responsible_fullname", "new_responsible_fullname", value);
            }
        }
		
        /// <summary>
        /// имя инициатора
        /// </summary>
        [AttributeLogicalName("new_responsiblecontact_name")]
        public string New_responsiblecontact_name
        {
            get
            {
                return GetAttributeValue<string>("new_responsiblecontact_name");
            }
            set
            {
                SetAttributeValue<string>("New_responsiblecontact_name", "new_responsiblecontact_name", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_scale_incident")]
        public int? New_scale_incident
        {
            get
            {
                return GetAttributeValue<int?>("new_scale_incident");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_scale_incident", "new_scale_incident", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_severityst")]
        public int? New_severityST
        {
            get
            {
                return GetAttributeValue<int?>("new_severityst");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_severityST", "new_severityst", value);
            }
        }
		
        /// <summary>
        /// Cостояния Обращений для работы процесса сервисной поддержки.
        /// </summary>
        [AttributeLogicalName("new_state_intenal")]
        public int? New_state_intenal
        {
            get
            {
                return GetAttributeValue<int?>("new_state_intenal");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_state_intenal", "new_state_intenal", value);
            }
        }
		
        /// <summary>
        /// В это поля заносятся номера похожих (или полностью дублирующих) данный ЗЗЛ к продукту но поступившие от других клиентов. Цель данного поля: дать возможность аналитику при изучении карточки ЗЗЛ.
        /// </summary>
        [AttributeLogicalName("new_strq_dub")]
        public string New_STRQ_Dub
        {
            get
            {
                return GetAttributeValue<string>("new_strq_dub");
            }
            set
            {
                SetAttributeValue<string>("New_STRQ_Dub", "new_strq_dub", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_support_line1")]
        public string New_support_line1
        {
            get
            {
                return GetAttributeValue<string>("new_support_line1");
            }
            set
            {
                SetAttributeValue<string>("New_support_line1", "new_support_line1", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_support_line1_fullname")]
        public string New_support_line1_fullname
        {
            get
            {
                return GetAttributeValue<string>("new_support_line1_fullname");
            }
            set
            {
                SetAttributeValue<string>("New_support_line1_fullname", "new_support_line1_fullname", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_supported_pda")]
        public bool? New_supported_PDA
        {
            get
            {
                return GetAttributeValue<bool?>("new_supported_pda");
            }
            set
            {
                SetAttributeValue<bool?>("New_supported_PDA", "new_supported_pda", value);
            }
        }
		
        /// <summary>
        /// указывается тестировщик, проверевший исправление дефекта
        /// </summary>
        [AttributeLogicalName("new_tester")]
        public CrmEntityReference New_tester
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_tester");
            }
            set
            {
                SetAttributeValue<EntityReference>("New_tester", "new_tester", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_time_client")]
        public int? New_time_client
        {
            get
            {
                return GetAttributeValue<int?>("new_time_client");
            }
            set
            {
                SetAttributeValue<int?>("New_time_client", "new_time_client", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_time_left")]
        public DateTime? New_time_left
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_time_left");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_time_left", "new_time_left", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_time_left_days")]
        public string New_time_left_days
        {
            get
            {
                return GetAttributeValue<string>("new_time_left_days");
            }
            set
            {
                SetAttributeValue<string>("New_time_left_days", "new_time_left_days", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_time_left_hours")]
        public string New_time_left_hours
        {
            get
            {
                return GetAttributeValue<string>("new_time_left_hours");
            }
            set
            {
                SetAttributeValue<string>("New_time_left_hours", "new_time_left_hours", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_to_be_paid")]
        public int? New_to_be_paid
        {
            get
            {
                return GetAttributeValue<int?>("new_to_be_paid");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_to_be_paid", "new_to_be_paid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_to_do")]
        public DateTime? New_to_do
        {
            get
            {
                return GetAttributeValue<DateTime?>("new_to_do");
            }
            set
            {
                SetAttributeValue<DateTime?>("New_to_do", "new_to_do", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_transfer_defect")]
        public bool? New_transfer_defect
        {
            get
            {
                return GetAttributeValue<bool?>("new_transfer_defect");
            }
            set
            {
                SetAttributeValue<bool?>("New_transfer_defect", "new_transfer_defect", value);
            }
        }
		
        /// <summary>
        /// заносится ответственный за передачу дефекта тестировщикам
        /// </summary>
        [AttributeLogicalName("new_transfer_defect_l")]
        public CrmEntityReference New_transfer_defect_l
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_transfer_defect_l");
            }
            set
            {
                SetAttributeValue<EntityReference>("New_transfer_defect_l", "new_transfer_defect_l", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_trudozatraty")]
        public int? New_trudozatraty
        {
            get
            {
                return GetAttributeValue<int?>("new_trudozatraty");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_trudozatraty", "new_trudozatraty", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_urgency_incident")]
        public int? New_urgency_incident
        {
            get
            {
                return GetAttributeValue<int?>("new_urgency_incident");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_urgency_incident", "new_urgency_incident", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_variant_real")]
        public string New_variant_real
        {
            get
            {
                return GetAttributeValue<string>("new_variant_real");
            }
            set
            {
                SetAttributeValue<string>("New_variant_real", "new_variant_real", value);
            }
        }
		
        /// <summary>
        /// Версия ПО СТ. Заполняется в том случае, если ТЕМОЙ обращения является ПО СТ
        /// </summary>
        [AttributeLogicalName("new_version")]
        public string New_version
        {
            get
            {
                return GetAttributeValue<string>("new_version");
            }
            set
            {
                SetAttributeValue<string>("New_version", "new_version", value);
            }
        }
		
        /// <summary>
        /// Версия в момент регистрации
        /// </summary>
        [AttributeLogicalName("new_versionattimeofregistration")]
        public string new_versionAtTimeOfRegistration
        {
            get
            {
                return GetAttributeValue<string>("new_versionattimeofregistration");
            }
            set
            {
                SetAttributeValue<string>("new_versionAtTimeOfRegistration", "new_versionattimeofregistration", value);
            }
        }
		
        /// <summary>
        /// важность для сотрудника СП
        /// </summary>
        [AttributeLogicalName("new_vip")]
        public int? New_vip
        {
            get
            {
                return GetAttributeValue<int?>("new_vip");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_vip", "new_vip", value);
            }
        }
		
        /// <summary>
        /// Время договора Крафт
        /// </summary>
        [AttributeLogicalName("new_vremya_dogovor_kraft")]
        public int? new_vremya_dogovor_kraft
        {
            get
            {
                return GetAttributeValue<int?>("new_vremya_dogovor_kraft");
            }
            set
            {
                SetAttributeValue<int?>("new_vremya_dogovor_kraft", "new_vremya_dogovor_kraft", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_vremya_obnovleno")]
        public bool? new_vremya_obnovleno
        {
            get
            {
                return GetAttributeValue<bool?>("new_vremya_obnovleno");
            }
            set
            {
                SetAttributeValue<bool?>("new_vremya_obnovleno", "new_vremya_obnovleno", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_web_type_incident")]
        public int? New_web_type_incident
        {
            get
            {
                return GetAttributeValue<int?>("new_web_type_incident");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("New_web_type_incident", "new_web_type_incident", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Задание, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("new_zadanie")]
        public CrmEntityReference New_zadanie
        {
            get
            {
                return GetAttributeValue<EntityReference>("new_zadanie");
            }
            set
            {
                SetAttributeValue<EntityReference>("New_zadanie", "new_zadanie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_zakaz_zvonok")]
        public bool? new_zakaz_zvonok
        {
            get
            {
                return GetAttributeValue<bool?>("new_zakaz_zvonok");
            }
            set
            {
                SetAttributeValue<bool?>("new_zakaz_zvonok", "new_zakaz_zvonok", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_zatrat_vremya")]
        public int? New_zatrat_vremya
        {
            get
            {
                return GetAttributeValue<int?>("new_zatrat_vremya");
            }
            set
            {
                SetAttributeValue<int?>("New_zatrat_vremya", "new_zatrat_vremya", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("new_zzl_project_prime")]
        public int? new_zzl_project_prime
        {
            get
            {
                return GetAttributeValue<int?>("new_zzl_project_prime");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("new_zzl_project_prime", "new_zzl_project_prime", value);
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
        /// Unique identifier of the user or team that owns the case.
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
        /// Уникальный идентификатор подразделения, ответственного за обращение.
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
        /// Уникальный идентификатор рабочей группы, ответственной за обращение.
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
        /// Уникальный идентификатор пользователя, ответственного за обращение.
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
        /// Приоритет обращения.
        /// </summary>
        [AttributeLogicalName("prioritycode")]
        public int? PriorityCode
        {
            get
            {
                return GetAttributeValue<int?>("prioritycode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("PriorityCode", "prioritycode", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор продукта, связанного с обращением.
        /// </summary>
        [AttributeLogicalName("productid")]
        public CrmEntityReference ProductId
        {
            get
            {
                return GetAttributeValue<EntityReference>("productid");
            }
            set
            {
                SetAttributeValue<EntityReference>("ProductId", "productid", value);
            }
        }
		
        /// <summary>
        /// Серийный номер продукта, указанного в обращении.
        /// </summary>
        [AttributeLogicalName("productserialnumber")]
        public string ProductSerialNumber
        {
            get
            {
                return GetAttributeValue<string>("productserialnumber");
            }
            set
            {
                SetAttributeValue<string>("ProductSerialNumber", "productserialnumber", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор контакта, ответственного за разрешение обращения.
        /// </summary>
        [AttributeLogicalName("responsiblecontactid")]
        public CrmEntityReference ResponsibleContactId
        {
            get
            {
                return GetAttributeValue<EntityReference>("responsiblecontactid");
            }
            set
            {
                SetAttributeValue<EntityReference>("ResponsibleContactId", "responsiblecontactid", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalName("servicestage")]
        public int? ServiceStage
        {
            get
            {
                return GetAttributeValue<int?>("servicestage");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("ServiceStage", "servicestage", value);
            }
        }
		
        /// <summary>
        /// Степень серьезности обращения.
        /// </summary>
        [AttributeLogicalName("severitycode")]
        public int? SeverityCode
        {
            get
            {
                return GetAttributeValue<int?>("severitycode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("SeverityCode", "severitycode", value);
            }
        }
		
        /// <summary>
        /// Состояние обращения.
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
        /// Причина состояния обращения.
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
        /// Уникальный идентификатор темы, связанной с обращением.
        /// </summary>
        [AttributeLogicalName("subjectid")]
        public CrmEntityReference SubjectId
        {
            get
            {
                return GetAttributeValue<EntityReference>("subjectid");
            }
            set
            {
                SetAttributeValue<EntityReference>("SubjectId", "subjectid", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_close_with_article")]
        public bool? svk_close_with_article
        {
            get
            {
                return GetAttributeValue<bool?>("svk_close_with_article");
            }
            set
            {
                SetAttributeValue<bool?>("svk_close_with_article", "svk_close_with_article", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_exec_contract")]
        public bool? svk_exec_contract
        {
            get
            {
                return GetAttributeValue<bool?>("svk_exec_contract");
            }
            set
            {
                SetAttributeValue<bool?>("svk_exec_contract", "svk_exec_contract", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Функционал, связанного с объектом Обращение.
        /// </summary>
        [AttributeLogicalName("svk_functional")]
        public CrmEntityReference svk_functional
        {
            get
            {
                return GetAttributeValue<EntityReference>("svk_functional");
            }
            set
            {
                SetAttributeValue<EntityReference>("svk_functional", "svk_functional", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_integr_vremya_ostalos")]
        public int? svk_integr_vremya_ostalos
        {
            get
            {
                return GetAttributeValue<int?>("svk_integr_vremya_ostalos");
            }
            set
            {
                SetAttributeValue<int?>("svk_integr_vremya_ostalos", "svk_integr_vremya_ostalos", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_integr_vremya_potr")]
        public int? svk_integr_vremya_potr
        {
            get
            {
                return GetAttributeValue<int?>("svk_integr_vremya_potr");
            }
            set
            {
                SetAttributeValue<int?>("svk_integr_vremya_potr", "svk_integr_vremya_potr", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_razr_vremya_potracheno")]
        public int? svk_razr_vremya_potracheno
        {
            get
            {
                return GetAttributeValue<int?>("svk_razr_vremya_potracheno");
            }
            set
            {
                SetAttributeValue<int?>("svk_razr_vremya_potracheno", "svk_razr_vremya_potracheno", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_razrab_vremya_ostalos")]
        public int? svk_razrab_vremya_ostalos
        {
            get
            {
                return GetAttributeValue<int?>("svk_razrab_vremya_ostalos");
            }
            set
            {
                SetAttributeValue<int?>("svk_razrab_vremya_ostalos", "svk_razrab_vremya_ostalos", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_vremya_klient_kraft")]
        public string svk_vremya_klient_kraft
        {
            get
            {
                return GetAttributeValue<string>("svk_vremya_klient_kraft");
            }
            set
            {
                SetAttributeValue<string>("svk_vremya_klient_kraft", "svk_vremya_klient_kraft", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("svk_vremya_klienta")]
        public int? svk_vremya_klienta
        {
            get
            {
                return GetAttributeValue<int?>("svk_vremya_klienta");
            }
            set
            {
                SetAttributeValue<int?>("svk_vremya_klienta", "svk_vremya_klienta", value);
            }
        }
		
        /// <summary>
        /// Сгенерированный автоматически номер обращения.
        /// </summary>
        [AttributeLogicalName("ticketnumber")]
        public string TicketNumber
        {
            get
            {
                return GetAttributeValue<string>("ticketnumber");
            }
            set
            {
                SetAttributeValue<string>("TicketNumber", "ticketnumber", value);
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
        /// Тема обращения.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get
            {
                return GetAttributeValue<string>("title");
            }
            set
            {
                SetAttributeValue<string>("Title", "title", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор валюты, связанной с инцидентом.
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
        /// Номер версии обращения.
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
        /// 1:N incident_activity_parties
        /// </summary>
        [RelationshipSchemaName("incident_activity_parties")]
        public IEnumerable<ActivityParty> incident_activity_parties
        {
            get
            {
                return GetRelatedEntities<ActivityParty>("incident_activity_parties", null);
            }
            set
            {
                SetRelatedEntities<ActivityParty>("incident_activity_parties", "incident_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Incident_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Incident_ActivityPointers")]
        public IEnumerable<ActivityPointer> Incident_ActivityPointers
        {
            get
            {
                return GetRelatedEntities<ActivityPointer>("Incident_ActivityPointers", null);
            }
            set
            {
                SetRelatedEntities<ActivityPointer>("Incident_ActivityPointers", "Incident_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Incident_Annotation
        /// </summary>
        [RelationshipSchemaName("Incident_Annotation")]
        public IEnumerable<Annotation> Incident_Annotation
        {
            get
            {
                return GetRelatedEntities<Annotation>("Incident_Annotation", null);
            }
            set
            {
                SetRelatedEntities<Annotation>("Incident_Annotation", "Incident_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Incident_Emails
        /// </summary>
        [RelationshipSchemaName("Incident_Emails")]
        public IEnumerable<Email> Incident_Emails
        {
            get
            {
                return GetRelatedEntities<Email>("Incident_Emails", null);
            }
            set
            {
                SetRelatedEntities<Email>("Incident_Emails", "Incident_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N incident_existingcase
        /// </summary>
        [RelationshipSchemaName("incident_existingcase", EntityRole.Referenced)]
        public IEnumerable<Incident> Referencedincident_existingcase
        {
            get
            {
                return GetRelatedEntities<Incident>("incident_existingcase", EntityRole.Referenced);
            }
            set
            {
                SetRelatedEntities<Incident>("Referencedincident_existingcase", "incident_existingcase", EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N incident_iok_action_send_SMSes
        /// </summary>
        [RelationshipSchemaName("incident_iok_action_send_SMSes")]
        public IEnumerable<iok_action_send_SMS> incident_iok_action_send_SMSes
        {
            get
            {
                return GetRelatedEntities<iok_action_send_SMS>("incident_iok_action_send_SMSes", null);
            }
            set
            {
                SetRelatedEntities<iok_action_send_SMS>("incident_iok_action_send_SMSes", "incident_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_incident_incident_parentincident
        /// </summary>
        [RelationshipSchemaName("iok_incident_incident_parentincident", EntityRole.Referenced)]
        public IEnumerable<Incident> Referencediok_incident_incident_parentincident
        {
            get
            {
                return GetRelatedEntities<Incident>("iok_incident_incident_parentincident", EntityRole.Referenced);
            }
            set
            {
                SetRelatedEntities<Incident>("Referencediok_incident_incident_parentincident", "iok_incident_incident_parentincident", EntityRole.Referenced, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_incident_iok_getphonecall_incidenttocall
        /// </summary>
        [RelationshipSchemaName("iok_incident_iok_getphonecall_incidenttocall")]
        public IEnumerable<iok_getphonecall> iok_incident_iok_getphonecall_incidenttocall
        {
            get
            {
                return GetRelatedEntities<iok_getphonecall>("iok_incident_iok_getphonecall_incidenttocall", null);
            }
            set
            {
                SetRelatedEntities<iok_getphonecall>("iok_incident_iok_getphonecall_incidenttocall", "iok_incident_iok_getphonecall_incidenttocall", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_incident_new_shtrafy_incident
        /// </summary>
        [RelationshipSchemaName("new_incident_new_shtrafy_incident")]
        public IEnumerable<new_shtrafy> new_incident_new_shtrafy_incident
        {
            get
            {
                return GetRelatedEntities<new_shtrafy>("new_incident_new_shtrafy_incident", null);
            }
            set
            {
                SetRelatedEntities<new_shtrafy>("new_incident_new_shtrafy_incident", "new_incident_new_shtrafy_incident", null, value);
            }
        }
		
        /// <summary>
        /// N:1 contact_as_responsible_contact
        /// </summary>
        [AttributeLogicalName("responsiblecontactid")]
        [RelationshipSchemaName("contact_as_responsible_contact")]
        public Contact contact_as_responsible_contact
        {
            get
            {
                return GetRelatedEntity<Contact>("contact_as_responsible_contact", null);
            }
            set
            {
                SetRelatedEntity<Contact>("contact_as_responsible_contact", "contact_as_responsible_contact", null, value);
            }
        }
		
        /// <summary>
        /// N:1 incident_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("incident_customer_accounts")]
        public Account incident_customer_accounts
        {
            get
            {
                return GetRelatedEntity<Account>("incident_customer_accounts", null);
            }
            set
            {
                SetRelatedEntity<Account>("incident_customer_accounts", "incident_customer_accounts", null, value);
            }
        }
		
        /// <summary>
        /// N:1 incident_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("incident_customer_contacts")]
        public Contact incident_customer_contacts
        {
            get
            {
                return GetRelatedEntity<Contact>("incident_customer_contacts", null);
            }
            set
            {
                SetRelatedEntity<Contact>("incident_customer_contacts", "incident_customer_contacts", null, value);
            }
        }
		
        /// <summary>
        /// N:1 incident_existingcase
        /// </summary>
        [AttributeLogicalName("existingcase")]
        [RelationshipSchemaName("incident_existingcase", EntityRole.Referencing)]
        public Incident Referencingincident_existingcase
        {
            get
            {
                return GetRelatedEntity<Incident>("incident_existingcase", EntityRole.Referencing);
            }
            set
            {
                SetRelatedEntity<Incident>("Referencingincident_existingcase", "incident_existingcase", EntityRole.Referencing, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_contact_incident_emailcopyfield
        /// </summary>
        [AttributeLogicalName("iok_emailcopyfield")]
        [RelationshipSchemaName("iok_contact_incident_emailcopyfield")]
        public Contact iok_contact_incident_emailcopyfield
        {
            get
            {
                return GetRelatedEntity<Contact>("iok_contact_incident_emailcopyfield", null);
            }
            set
            {
                SetRelatedEntity<Contact>("iok_contact_incident_emailcopyfield", "iok_contact_incident_emailcopyfield", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_contact_incident_emailto
        /// </summary>
        [AttributeLogicalName("iok_emailto")]
        [RelationshipSchemaName("iok_contact_incident_emailto")]
        public Contact iok_contact_incident_emailto
        {
            get
            {
                return GetRelatedEntity<Contact>("iok_contact_incident_emailto", null);
            }
            set
            {
                SetRelatedEntity<Contact>("iok_contact_incident_emailto", "iok_contact_incident_emailto", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_contact_incident_reopen_portal_user
        /// </summary>
        [AttributeLogicalName("iok_reopen_portal_user")]
        [RelationshipSchemaName("iok_contact_incident_reopen_portal_user")]
        public Contact iok_contact_incident_reopen_portal_user
        {
            get
            {
                return GetRelatedEntity<Contact>("iok_contact_incident_reopen_portal_user", null);
            }
            set
            {
                SetRelatedEntity<Contact>("iok_contact_incident_reopen_portal_user", "iok_contact_incident_reopen_portal_user", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_incident_incident_parentincident
        /// </summary>
        [AttributeLogicalName("iok_parentincident")]
        [RelationshipSchemaName("iok_incident_incident_parentincident", EntityRole.Referencing)]
        public Incident Referencingiok_incident_incident_parentincident
        {
            get
            {
                return GetRelatedEntity<Incident>("iok_incident_incident_parentincident", EntityRole.Referencing);
            }
            set
            {
                SetRelatedEntity<Incident>("Referencingiok_incident_incident_parentincident", "iok_incident_incident_parentincident", EntityRole.Referencing, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_svk_project_incident_KK_project
        /// </summary>
        [AttributeLogicalName("iok_kk_project")]
        [RelationshipSchemaName("iok_svk_project_incident_KK_project")]
        public svk_project iok_svk_project_incident_KK_project
        {
            get
            {
                return GetRelatedEntity<svk_project>("iok_svk_project_incident_KK_project", null);
            }
            set
            {
                SetRelatedEntity<svk_project>("iok_svk_project_incident_KK_project", "iok_svk_project_incident_KK_project", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_incidentbase_createdby")]
        public SystemUser lk_incidentbase_createdby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentbase_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_incidentbase_createdonbehalfby")]
        public SystemUser lk_incidentbase_createdonbehalfby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentbase_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_incidentbase_modifiedby")]
        public SystemUser lk_incidentbase_modifiedby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentbase_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_incidentbase_modifiedonbehalfby")]
        public SystemUser lk_incidentbase_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentbase_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 msa_account_incident
        /// </summary>
        [AttributeLogicalName("msa_partnerid")]
        [RelationshipSchemaName("msa_account_incident")]
        public Account msa_account_incident
        {
            get
            {
                return GetRelatedEntity<Account>("msa_account_incident", null);
            }
            set
            {
                SetRelatedEntity<Account>("msa_account_incident", "msa_account_incident", null, value);
            }
        }
		
        /// <summary>
        /// N:1 msa_contact_incident
        /// </summary>
        [AttributeLogicalName("msa_partnercontactid")]
        [RelationshipSchemaName("msa_contact_incident")]
        public Contact msa_contact_incident
        {
            get
            {
                return GetRelatedEntity<Contact>("msa_contact_incident", null);
            }
            set
            {
                SetRelatedEntity<Contact>("msa_contact_incident", "msa_contact_incident", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_new_probe_incident
        /// </summary>
        [AttributeLogicalName("new_podderzhka_klienty")]
        [RelationshipSchemaName("new_new_probe_incident")]
        public New_Probe new_new_probe_incident
        {
            get
            {
                return GetRelatedEntity<New_Probe>("new_new_probe_incident", null);
            }
            set
            {
                SetRelatedEntity<New_Probe>("new_new_probe_incident", "new_new_probe_incident", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident
        /// </summary>
        [AttributeLogicalName("new_transfer_defect_l")]
        [RelationshipSchemaName("new_systemuser_incident")]
        public SystemUser new_systemuser_incident
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident", "new_systemuser_incident", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident_Kto_hochet_znat
        /// </summary>
        [AttributeLogicalName("new_kto_hochet_znat")]
        [RelationshipSchemaName("new_systemuser_incident_Kto_hochet_znat")]
        public SystemUser new_systemuser_incident_Kto_hochet_znat
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident_Kto_hochet_znat", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident_Kto_hochet_znat", "new_systemuser_incident_Kto_hochet_znat", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident_last_owner
        /// </summary>
        [AttributeLogicalName("new_last_owner")]
        [RelationshipSchemaName("new_systemuser_incident_last_owner")]
        public SystemUser new_systemuser_incident_last_owner
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident_last_owner", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident_last_owner", "new_systemuser_incident_last_owner", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident_observer1
        /// </summary>
        [AttributeLogicalName("new_observer1")]
        [RelationshipSchemaName("new_systemuser_incident_observer1")]
        public SystemUser new_systemuser_incident_observer1
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident_observer1", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident_observer1", "new_systemuser_incident_observer1", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident_owner_substitution
        /// </summary>
        [AttributeLogicalName("new_owner_substitution")]
        [RelationshipSchemaName("new_systemuser_incident_owner_substitution")]
        public SystemUser new_systemuser_incident_owner_substitution
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident_owner_substitution", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident_owner_substitution", "new_systemuser_incident_owner_substitution", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident_povtorno_otkr
        /// </summary>
        [AttributeLogicalName("new_povtorno_otkr")]
        [RelationshipSchemaName("new_systemuser_incident_povtorno_otkr")]
        public SystemUser new_systemuser_incident_povtorno_otkr
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident_povtorno_otkr", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident_povtorno_otkr", "new_systemuser_incident_povtorno_otkr", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident_povtorno_otkr_2
        /// </summary>
        [AttributeLogicalName("new_povtorno_otkr_2")]
        [RelationshipSchemaName("new_systemuser_incident_povtorno_otkr_2")]
        public SystemUser new_systemuser_incident_povtorno_otkr_2
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident_povtorno_otkr_2", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident_povtorno_otkr_2", "new_systemuser_incident_povtorno_otkr_2", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_systemuser_incident_tester
        /// </summary>
        [AttributeLogicalName("new_tester")]
        [RelationshipSchemaName("new_systemuser_incident_tester")]
        public SystemUser new_systemuser_incident_tester
        {
            get
            {
                return GetRelatedEntity<SystemUser>("new_systemuser_incident_tester", null);
            }
            set
            {
                SetRelatedEntity<SystemUser>("new_systemuser_incident_tester", "new_systemuser_incident_tester", null, value);
            }
        }
		
        /// <summary>
        /// N:1 system_user_incidents
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_incidents")]
        public SystemUser system_user_incidents
        {
            get
            {
                return GetRelatedEntity<SystemUser>("system_user_incidents", null);
            }
        }
    }
}