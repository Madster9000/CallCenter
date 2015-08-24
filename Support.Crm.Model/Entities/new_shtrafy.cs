namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("new_shtrafy")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("new_shtrafySet")]
    public partial class new_shtrafy : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public new_shtrafy() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "new_shtrafy";
		
        public const int EntityTypeCode = 10079;
		
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datetime")]
        public System.Nullable<System.DateTime> new_datetime
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("new_datetime");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("new_datetime", "new_datetime", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_id")]
        public System.Nullable<int> new_id
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_id");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_id", "new_id", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор для объекта Обращение, связанного с объектом Штрафы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_incident")]
        public Microsoft.Xrm.Client.CrmEntityReference new_incident
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_incident");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_incident", "new_incident", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_ingeener")]
        public string new_ingeener
        {
            get
            {
                return this.GetAttributeValue<string>("new_ingeener");
            }
            set
            {
                this.SetAttributeValue<string>("new_ingeener", "new_ingeener", value);
            }
        }
		
        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_name")]
        public string new_name
        {
            get
            {
                return this.GetAttributeValue<string>("new_name");
            }
            set
            {
                this.SetAttributeValue<string>("new_name", "new_name", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_new_opravdanie")]
        public string new_new_opravdanie
        {
            get
            {
                return this.GetAttributeValue<string>("new_new_opravdanie");
            }
            set
            {
                this.SetAttributeValue<string>("new_new_opravdanie", "new_new_opravdanie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_opravdanie")]
        public string new_opravdanie
        {
            get
            {
                return this.GetAttributeValue<string>("new_opravdanie");
            }
            set
            {
                this.SetAttributeValue<string>("new_opravdanie", "new_opravdanie", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_prichina")]
        public System.Nullable<int> new_prichina
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_prichina");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("new_prichina", "new_prichina", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор экземпляров сущности
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_shtrafyid")]
        public System.Nullable<System.Guid> new_shtrafyId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("new_shtrafyid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("new_shtrafyId", "new_shtrafyid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_shtrafyid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.new_shtrafyId = value;
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_time")]
        public System.Nullable<int> new_time
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("new_time");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("new_time", "new_time", value);
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
        /// Статус Штрафы
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
        /// Причина состояния Штрафы
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
        /// 1:N new_shtrafy_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> new_shtrafy_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("new_shtrafy_ActivityPointers", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("new_shtrafy_ActivityPointers", "new_shtrafy_ActivityPointers", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_shtrafy_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> new_shtrafy_Annotations
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("new_shtrafy_Annotations", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("new_shtrafy_Annotations", "new_shtrafy_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_shtrafy_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_Emails")]
        public System.Collections.Generic.IEnumerable<Email> new_shtrafy_Emails
        {
            get
            {
                return this.GetRelatedEntities<Email>("new_shtrafy_Emails", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("new_shtrafy_Emails", "new_shtrafy_Emails", null, value);
            }
        }
		
        /// <summary>
        /// 1:N new_shtrafy_iok_action_send_SMSes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_iok_action_send_SMSes")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> new_shtrafy_iok_action_send_SMSes
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("new_shtrafy_iok_action_send_SMSes", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("new_shtrafy_iok_action_send_SMSes", "new_shtrafy_iok_action_send_SMSes", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_shtrafy_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_createdby")]
        public SystemUser lk_new_shtrafy_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_shtrafy_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_shtrafy_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_createdonbehalfby")]
        public SystemUser lk_new_shtrafy_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_shtrafy_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_shtrafy_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_modifiedby")]
        public SystemUser lk_new_shtrafy_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_shtrafy_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_new_shtrafy_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_shtrafy_modifiedonbehalfby")]
        public SystemUser lk_new_shtrafy_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_new_shtrafy_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 new_incident_new_shtrafy_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_incident")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_incident_new_shtrafy_incident")]
        public Incident new_incident_new_shtrafy_incident
        {
            get
            {
                return this.GetRelatedEntity<Incident>("new_incident_new_shtrafy_incident", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("new_incident_new_shtrafy_incident", "new_incident_new_shtrafy_incident", null, value);
            }
        }
    }
}