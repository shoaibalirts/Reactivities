using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}