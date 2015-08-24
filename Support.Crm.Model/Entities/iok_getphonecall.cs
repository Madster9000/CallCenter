namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// сущность для заказа звонков с портала
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("iok_getphonecall")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("iok_getphonecallSet")]
    public partial class iok_getphonecall : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public iok_getphonecall() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "iok_getphonecall";
		
        public const int EntityTypeCode = 10078;
		
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_callcomment")]
        public string iok_callcomment
        {
            get
            {
                return this.GetAttributeValue<string>("iok_callcomment");
            }
            set
            {
                this.SetAttributeValue<string>("iok_callcomment", "iok_callcomment", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Контакт, связанного с объектом Заказанный звонок.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_contacttocall")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_contacttocall
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_contacttocall");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_contacttocall", "iok_contacttocall", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор экземпляров сущности
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_getphonecallid")]
        public System.Nullable<System.Guid> iok_getphonecallId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("iok_getphonecallid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("iok_getphonecallId", "iok_getphonecallid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_getphonecallid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.iok_getphonecallId = value;
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Обращение, связанного с объектом Заказанный звонок.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_incidenttocall")]
        public Microsoft.Xrm.Client.CrmEntityReference iok_incidenttocall
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_incidenttocall");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("iok_incidenttocall", "iok_incidenttocall", value);
            }
        }
		
        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_name")]
        public string iok_name
        {
            get
            {
                return this.GetAttributeValue<string>("iok_name");
            }
            set
            {
                this.SetAttributeValue<string>("iok_name", "iok_name", value);
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
        /// Идентификатор ответственного
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
        /// Уникальный идентификатор подразделения, владеющего этой записью
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
        /// Уникальный идентификатор группы, владеющей записью
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
        /// Уникальный идентификатор пользователя, владеющего этой записью.
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
        /// Статус Заказанный звонок
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
        /// Причина состояния Заказанный звонок
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
        /// 1:N iok_getphonecall_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> iok_getphonecall_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("iok_getphonecall_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("iok_getphonecall_ActivityPointers", "iok_getphonecall_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_getphonecall_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> iok_getphonecall_Annotations
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("iok_getphonecall_Annotations", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("iok_getphonecall_Annotations", "iok_getphonecall_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_getphonecall_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_Emails")]
        public System.Collections.Generic.IEnumerable<Email> iok_getphonecall_Emails
        {
            get
            {
                return this.GetRelatedEntities<Email>("iok_getphonecall_Emails", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("iok_getphonecall_Emails", "iok_getphonecall_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N iok_getphonecall_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_iok_action_send_SMSes")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_getphonecall_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_getphonecall_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_getphonecall_iok_action_send_SMSes", "iok_getphonecall_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_contact_iok_getphonecall_null
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_contacttocall")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_contact_iok_getphonecall_null")]
        public Contact iok_contact_iok_getphonecall_null
        {
            get
            {
                return this.GetRelatedEntity<Contact>("iok_contact_iok_getphonecall_null", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("iok_contact_iok_getphonecall_null", "iok_contact_iok_getphonecall_null", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_incident_iok_getphonecall_incidenttocall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_incidenttocall")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_incident_iok_getphonecall_incidenttocall")]
        public Incident iok_incident_iok_getphonecall_incidenttocall
        {
            get
            {
                return this.GetRelatedEntity<Incident>("iok_incident_iok_getphonecall_incidenttocall", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("iok_incident_iok_getphonecall_incidenttocall", "iok_incident_iok_getphonecall_incidenttocall", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_getphonecall_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_createdby")]
        public SystemUser lk_iok_getphonecall_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_getphonecall_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_getphonecall_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_createdonbehalfby")]
        public SystemUser lk_iok_getphonecall_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_getphonecall_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_getphonecall_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_modifiedby")]
        public SystemUser lk_iok_getphonecall_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_getphonecall_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_iok_getphonecall_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_iok_getphonecall_modifiedonbehalfby")]
        public SystemUser lk_iok_getphonecall_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_iok_getphonecall_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 user_iok_getphonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_iok_getphonecall")]
        public SystemUser user_iok_getphonecall
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("user_iok_getphonecall", null);
            }
        }
    }
}