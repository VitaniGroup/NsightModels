using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsightModels.Keycloak
{
    public class KCAuth
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public int refresh_expires_in { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public int notBeforePolicy { get; set; }
        public string session_state { get; set; }
        public string scope { get; set; }
    }
}
