namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Выполненная пользователем задача или задача, которую пользователь должен выполнить. "Действие" — это любое действие, для которого в календаре можно создать запись.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activitypointer")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("ActivityPointerSet")]
    public partial class ActivityPointer : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ActivityPointer() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "activitypointer";
		
        public const int EntityTypeCode = 4200;
		
        /// <summary>
        /// Уникальный идентификатор действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public System.Nullable<System.Guid> ActivityId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("activityid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("ActivityId", "activityid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.ActivityId = value;
            }
        }
		
        /// <summary>
        /// Тип действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
        public string ActivityTypeCode
        {
            get
            {
                return this.GetAttributeValue<string>("activitytypecode");
            }
        }
		
        /// <summary>
        /// Фактическая длительность действия в минутах.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
        public System.Nullable<int> ActualDurationMinutes
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("ActualDurationMinutes", "actualdurationminutes", value);
            }
        }
		
        /// <summary>
        /// Фактическое время окончания действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
        public System.Nullable<System.DateTime> ActualEnd
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ActualEnd", "actualend", value);
            }
        }
		
        /// <summary>
        /// Фактическое время начала действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
        public System.Nullable<System.DateTime> ActualStart
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ActualStart", "actualstart", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allparties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> allparties
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("allparties");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего действие.
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
        /// Дата и время создания действия.
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
        /// Уникальный идентификатор делегата, создавшего activitypointer.
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
        /// Описание действия.
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
        /// Валютный курс денежной единицы, связанной с activitypointer, по отношению к базовой валюте.
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
        /// Тип экземпляра повторяющегося ряда.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
        public System.Nullable<int> InstanceTypeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("instancetypecode");
            }
        }
		
        /// <summary>
        /// Сведения о том, был ли выставлен счет по действию как часть разрешения обращения.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
        public System.Nullable<bool> IsBilled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isbilled");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsBilled", "isbilled", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismapiprivate")]
        public System.Nullable<bool> IsMapiPrivate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ismapiprivate");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsMapiPrivate", "ismapiprivate", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, является ли действие обычным действием или событием.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
        public System.Nullable<bool> IsRegularActivity
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity");
            }
        }
		
        /// <summary>
        /// Сведения о том, было ли действие создано из бизнес-правила.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
        public System.Nullable<bool> IsWorkflowCreated
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsWorkflowCreated", "isworkflowcreated", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leftvoicemail")]
        public System.Nullable<bool> LeftVoiceMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("leftvoicemail");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("LeftVoiceMail", "leftvoicemail", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор последнего пользователя, изменившего действие.
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
        /// Дата и время последнего изменения действия.
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
        /// Уникальный идентификатор делегата, который последним изменил activitypointer.
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
        /// Уникальный идентификатор пользователя или рабочей группы, ответственных за действие.
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
        /// Уникальный идентификатор подразделения, ответственного за действие.
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
        /// Уникальный идентификатор рабочей группы, ответственной за действие.
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
        /// Уникальный идентификатор пользователя, ответственного за действие.
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
        /// Приоритет действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public System.Nullable<int> PriorityCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("prioritycode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PriorityCode", "prioritycode", value);
            }
        }
		
        /// <summary>
        /// Unique identifier of the object with which the activity is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Client.CrmEntityReference RegardingObjectId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("RegardingObjectId", "regardingobjectid", value);
            }
        }
		
        /// <summary>
        /// "Запланированная длительность действия, указанная в минутах."
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("ScheduledDurationMinutes", "scheduleddurationminutes", value);
            }
        }
		
        /// <summary>
        /// Плановое время окончания действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ScheduledEnd", "scheduledend", value);
            }
        }
		
        /// <summary>
        /// Плановое время начала действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ScheduledStart", "scheduledstart", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор, определяющий код повторяющегося ряда экземпляра.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("seriesid")]
        public System.Nullable<System.Guid> SeriesId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("seriesid");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор связанного сервиса.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        public Microsoft.Xrm.Client.CrmEntityReference ServiceId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ServiceId", "serviceid", value);
            }
        }
		
        /// <summary>
        /// Состояние действия.
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
        /// Состояние действия.
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
        /// Тема, связанная с действием.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get
            {
                return this.GetAttributeValue<string>("subject");
            }
            set
            {
                this.SetAttributeValue<string>("Subject", "subject", value);
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
        /// Уникальный идентификатор валюты, связанной с activitypointer.
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
        /// Номер версии действия.
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
        /// 1:N activity_pointer_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_email")]
        public System.Collections.Generic.IEnumerable<Email> activity_pointer_email
        {
            get
            {
                return this.GetRelatedEntities<Email>("activity_pointer_email", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("activity_pointer_email", "activity_pointer_email", null, value);
            }
        }
		
        /// <summary>
        /// 1:N activity_pointer_iok_action_send_SMS
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_iok_action_send_SMS")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> activity_pointer_iok_action_send_SMS
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("activity_pointer_iok_action_send_SMS", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("activity_pointer_iok_action_send_SMS", "activity_pointer_iok_action_send_SMS", null, value);
            }
        }
		
        /// <summary>
        /// 1:N activitypointer_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> activitypointer_activity_parties
        {
            get
            {
                return this.GetRelatedEntities<ActivityParty>("activitypointer_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityParty>("activitypointer_activity_parties", "activitypointer_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Account_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_ActivityPointers")]
        public Account Account_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntity<Account>("Account_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntity<Account>("Account_ActivityPointers", "Account_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Contact_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_ActivityPointers")]
        public Contact Contact_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntity<Contact>("Contact_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("Contact_ActivityPointers", "Contact_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Incident_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_ActivityPointers")]
        public Incident Incident_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntity<Incident>("Incident_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("Incident_ActivityPointers", "Incident_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_getphonecall_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_ActivityPointers")]
        public iok_getphonecall iok_getphonecall_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntity<iok_getphonecall>("iok_getphonecall_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntity<iok_getphonecall>("iok_getphonecall_ActivityPointers", "iok_getphonecall_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_activitypointer_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdby")]
        public SystemUser lk_activitypointer_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_activitypointer_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_activitypointer_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdonbehalfby")]
        public SystemUser lk_activitypointer_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_activitypointer_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_activitypointer_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedby")]
        public SystemUser lk_activitypointer_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_activitypointer_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_activitypointer_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedonbehalfby")]
        public SystemUser lk_activitypointer_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_activitypointer_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 new_probe_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_ActivityPointers")]
        public New_Probe new_probe_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntity<New_Probe>("new_probe_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntity<New_Probe>("new_probe_ActivityPointers", "new_probe_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_shtrafy_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_ActivityPointers")]
        public new_shtrafy new_shtrafy_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntity<new_shtrafy>("new_shtrafy_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntity<new_shtrafy>("new_shtrafy_ActivityPointers", "new_shtrafy_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_project_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_ActivityPointers")]
        public svk_project svk_project_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntity<svk_project>("svk_project_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntity<svk_project>("svk_project_ActivityPointers", "svk_project_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// N:1 user_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_activity")]
        public SystemUser user_activity
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("user_activity", null);
            }
        }
    }
}