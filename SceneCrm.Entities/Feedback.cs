//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SceneCrm.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string FeedbackText { get; set; }
        public Nullable<System.DateTime> FeedbackLeft { get; set; }
        public string eventBriteId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string OrganisationName { get; set; }
        public Nullable<bool> Approved { get; set; }
    }
}