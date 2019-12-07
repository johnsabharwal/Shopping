using Dal.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.common
{
    public class Response
    {/// <summary>
     /// ResponseText require for Response message from server
     /// </summary>
        public ResponseTypes Status { get; set; }

        public string ErrorMessage;

        public dynamic Data { get; set; }


    }
}
