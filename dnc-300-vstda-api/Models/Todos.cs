using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dnc_300_vstda_api.Models
{
    public class Todos
    {
        public int todoItemId { get; set; }
        public string name { get; set; }
        public int priority { get; set; }
        public bool completed { get; set; }
    }
}