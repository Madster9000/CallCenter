namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teammembership")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("TeamMembershipSet")]
    public partial class TeamMembership : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TeamMembership() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "teammembership";
		
        public const int EntityTypeCode = 23;
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
        public System.Nullable<System.Guid> TeamId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid");
            }
        }
		
        /// <summary>
        /// ”никальный идентификатор участника рабочей группы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teammembershipid")]
        public System.Nullable<System.Guid> TeamMembershipId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("teammembershipid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("TeamMembershipId", "teammembershipid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teammembershipid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.TeamMembershipId = value;
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
    }
}