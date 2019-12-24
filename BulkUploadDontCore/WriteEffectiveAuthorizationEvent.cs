using System;
using System.Collections.Generic;
using System.Text;

namespace BulkUploadDontCore
{
    public class WriteEffectiveAuthorizationEvent
    {
        public string Action { get; set; }

        public EffectiveAuthorization EffectiveAuthorization { get; set; }

        public DateTime DateCreated
        {
            get; set;
        }
    }
}
