using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Helper
{
    public enum APIStatus
    {
        [Description("success")]
        Success,

        [Description("error")]
        Error,

        [Description("pending")]
        Pending,

        [Description("timeout")]
        Timeout,

        [Description("unauthorized")]
        Unauthorized,

        [Description("forbidden")]
        Forbidden,

        [Description("not_found")]
        NotFound,

        [Description("server_error")]
        ServerError,

        [Description("bad_request")]
        BadRequest,

        [Description("rate_limited")]
        RateLimited
    }
}
