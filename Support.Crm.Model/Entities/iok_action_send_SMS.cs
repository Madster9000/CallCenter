namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// действие для от
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("iok_action_send_sms")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("iok_action_send_SMSSet")]
    public partial class iok_action_send_SMS : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public iok_action_send_SMS() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "iok_action_send_sms";
		
        public const int EntityTypeCode = 10065;
		
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
        /// Получатели скрытой копии (bcc) действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bcc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Bcc
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("bcc");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Bcc", "bcc", value);
            }
        }
		
        /// <summary>
        /// Получатели копии (cc) действия
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Cc
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("cc");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Cc", "cc", value);
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
        /// Клиент, с которым связано действие.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customers")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Customers
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("customers");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Customers", "customers", value);
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
        /// Лицо, создавшее действие.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("from")]
        public System.Collections.Generic.IEnumerable<ActivityParty> From
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("from");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("From", "from", value);
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
        /// Список необязательных участников действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("optionalattendees")]
        public System.Collections.Generic.IEnumerable<ActivityParty> OptionalAttendees
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("optionalattendees");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("OptionalAttendees", "optionalattendees", value);
            }
        }
		
        /// <summary>
        /// Лицо, организовавшее действие.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizer")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Organizer
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("organizer");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Organizer", "organizer", value);
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
        /// Внешний исполнитель, с которым связано действие.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partners")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Partners
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("partners");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Partners", "partners", value);
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
        /// Список обязательных участников действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredattendees")]
        public System.Collections.Generic.IEnumerable<ActivityParty> RequiredAttendees
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("requiredattendees");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("RequiredAttendees", "requiredattendees", value);
            }
        }
		
        /// <summary>
        /// Пользователи, помещения и оборудование, которые требуются для действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resources")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Resources
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("resources");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Resources", "resources", value);
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
        /// Лица, являющееся получателем действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("to")]
        public System.Collections.Generic.IEnumerable<ActivityParty> To
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("to");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("To", "to", value);
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
        /// 1:N iok_action_send_SMS_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_SMS_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> iok_action_send_SMS_activity_parties
        {
            get
            {
                return this.GetRelatedEntities<ActivityParty>("iok_action_send_SMS_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityParty>("iok_action_send_SMS_activity_parties", "iok_action_send_SMS_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_action_send_sms_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> iok_action_send_sms_Annotations
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("iok_action_send_sms_Annotations", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("iok_action_send_sms_Annotations", "iok_action_send_sms_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// N:1 account_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_iok_action_send_SMSes")]
        public Account account_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntity<Account>("account_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntity<Account>("account_iok_action_send_SMSes", "account_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 activity_pointer_iok_action_send_SMS
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_iok_action_send_SMS")]
        public ActivityPointer activity_pointer_iok_action_send_SMS
        {
            get
            {
                return this.GetRelatedEntity<ActivityPointer>("activity_pointer_iok_action_send_SMS", null);
            }
            set
            {
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_iok_action_send_SMS", "activity_pointer_iok_action_send_SMS", null, value);
            }
        }
		
        /// <summary>
        /// N:1 contact_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_iok_action_send_SMSes")]
        public Contact contact_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntity<Contact>("contact_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("contact_iok_action_send_SMSes", "contact_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 incident_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_iok_action_send_SMSes")]
        public Incident incident_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntity<Incident>("incident_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("incident_iok_action_send_SMSes", "incident_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_action_send_sms_systemuser_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_createdby")]
        public SystemUser iok_action_send_sms_systemuser_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("iok_action_send_sms_systemuser_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 iok_action_send_sms_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_createdonbehalfby")]
        public SystemUser iok_action_send_sms_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("iok_action_send_sms_systemuser_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 iok_action_send_sms_systemuser_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_modifiedby")]
        public SystemUser iok_action_send_sms_systemuser_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("iok_action_send_sms_systemuser_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 iok_action_send_sms_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_modifiedonbehalfby")]
        public SystemUser iok_action_send_sms_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("iok_action_send_sms_systemuser_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 iok_action_send_sms_systemuser_owninguser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_systemuser_owninguser")]
        public SystemUser iok_action_send_sms_systemuser_owninguser
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("iok_action_send_sms_systemuser_owninguser", null);
            }
        }
		
        /// <summary>
        /// N:1 iok_getphonecall_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_iok_action_send_SMSes")]
        public iok_getphonecall iok_getphonecall_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntity<iok_getphonecall>("iok_getphonecall_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntity<iok_getphonecall>("iok_getphonecall_iok_action_send_SMSes", "iok_getphonecall_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_probe_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_iok_action_send_SMSes")]
        public New_Probe new_probe_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntity<New_Probe>("new_probe_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntity<New_Probe>("new_probe_iok_action_send_SMSes", "new_probe_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_shtrafy_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_iok_action_send_SMSes")]
        public new_shtrafy new_shtrafy_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntity<new_shtrafy>("new_shtrafy_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntity<new_shtrafy>("new_shtrafy_iok_action_send_SMSes", "new_shtrafy_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_project_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_iok_action_send_SMSes")]
        public svk_project svk_project_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntity<svk_project>("svk_project_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntity<svk_project>("svk_project_iok_action_send_SMSes", "svk_project_iok_action_send_SMSes", null, value);
            }
        }
    }
}