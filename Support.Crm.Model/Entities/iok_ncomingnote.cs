namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Сущность для регистрации действий по звонку из программы Incoming Client
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("iok_ncomingnote")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("iok_ncomingnoteSet")]
    public class iok_ncomingnote : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public iok_ncomingnote() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "iok_ncomingnote";
		
        public const int EntityTypeCode = 10077;
		
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
        /// Действия по звонку, созданные в программе IncomingCall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_callaction")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_callaction
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_callaction");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_callaction", "iok_callaction", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_callid")]
        public string iok_callid
        {
            get
            {
                return this.GetAttributeValue<string>("iok_callid");
            }
            set
            {
                this.SetAttributeValue<string>("iok_callid", "iok_callid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор экземпляров сущности
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_ncomingnoteid")]
        public System.Nullable<System.Guid> iok_ncomingnoteId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("iok_ncomingnoteid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("iok_ncomingnoteId", "iok_ncomingnoteid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_ncomingnoteid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.iok_ncomingnoteId = value;
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_notedescription")]
        public string iok_notedescription
        {
            get
            {
                return this.GetAttributeValue<string>("iok_notedescription");
            }
            set
            {
                this.SetAttributeValue<string>("iok_notedescription", "iok_notedescription", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Действие по звонку.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_regardingcontact")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_regardingcontact
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_regardingcontact");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_regardingcontact", "iok_regardingcontact", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Пользователь, связанного с объектом Действие по звонку.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_responsibleuser")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_responsibleuser
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_responsibleuser");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_responsibleuser", "iok_responsibleuser", value);
            }
        }
		
        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_title")]
        public string iok_title
        {
            get
            {
                return this.GetAttributeValue<string>("iok_title");
            }
            set
            {
                this.SetAttributeValue<string>("iok_title", "iok_title", value);
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
        /// связь обращения и звонка. 
        ///Используется для получения статистики по звонкам. 
        ///Проставляется через портал колл-центра.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_regardingincident")]
        public Microsoft.Xrm.Client.CrmEntityReference new_regardingincident
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_regardingincident");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_regardingincident", "new_regardingincident", value);
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
        /// Статус Действие по звонку
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
        /// Причина состояния Действие по звонку
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
        /// 1:N iok_ncomingnote_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_ncomingnote_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> iok_ncomingnote_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("iok_ncomingnote_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("iok_ncomingnote_ActivityPointers", "iok_ncomingnote_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_ncomingnote_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_ncomingnote_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> iok_ncomingnote_Annotations
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("iok_ncomingnote_Annotations", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("iok_ncomingnote_Annotations", "iok_ncomingnote_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_ncomingnote_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_ncomingnote_Emails")]
        public System.Collections.Generic.IEnumerable<Email> iok_ncomingnote_Emails
        {
            get
            {
                return this.GetRelatedEntities<Email>("iok_ncomingnote_Emails", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("iok_ncomingnote_Emails", "iok_ncomingnote_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_ncomingnote_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_ncomingnote_iok_action_send_SMSes")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_ncomingnote_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_ncomingnote_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_ncomingnote_iok_action_send_SMSes", "iok_ncomingnote_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_contact_iok_ncomingnote
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_callaction")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_contact_iok_ncomingnote")]
        public Contact iok_contact_iok_ncomingnote
        {
            get
            {
                return this.GetRelatedEntity<Contact>("iok_contact_iok_ncomingnote", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("iok_contact_iok_ncomingnote", "iok_contact_iok_ncomingnote", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_contact_iok_ncomingnote_regardingcontact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_regardingcontact")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_contact_iok_ncomingnote_regardingcontact")]
        public Contact iok_contact_iok_ncomingnote_regardingcontact
        {
            get
            {
                return this.GetRelatedEntity<Contact>("iok_contact_iok_ncomingnote_regardingcontact", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("iok_contact_iok_ncomingnote_regardingcontact", "iok_contact_iok_ncomingnote_regardingcontact", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_systemuser_iok_ncomingnote_responsibleuser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_responsibleuser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_systemuser_iok_ncomingnote_responsibleuser")]
        public SystemUser iok_systemuser_iok_ncomingnote_responsibleuser
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("iok_systemuser_iok_ncomingnote_responsibleuser", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("iok_systemuser_iok_ncomingnote_responsibleuser", "iok_systemuser_iok_ncomingnote_responsibleuser", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_ncomingnote_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_ncomingnote_createdby")]
        public SystemUser lk_iok_ncomingnote_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_ncomingnote_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_ncomingnote_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_ncomingnote_createdonbehalfby")]
        public SystemUser lk_iok_ncomingnote_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_ncomingnote_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_ncomingnote_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_ncomingnote_modifiedby")]
        public SystemUser lk_iok_ncomingnote_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_ncomingnote_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_ncomingnote_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_ncomingnote_modifiedonbehalfby")]
        public SystemUser lk_iok_ncomingnote_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_ncomingnote_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 new_incident_iok_ncomingnote_regardingincident
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_regardingincident")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_incident_iok_ncomingnote_regardingincident")]
        public Incident new_incident_iok_ncomingnote_regardingincident
        {
            get
            {
                return this.GetRelatedEntity<Incident>("new_incident_iok_ncomingnote_regardingincident", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("new_incident_iok_ncomingnote_regardingincident", "new_incident_iok_ncomingnote_regardingincident", null, value);
            }
        }
    }
}