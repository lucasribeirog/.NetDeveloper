using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Domain.Enumerators
{
    public static class EnumsEcommerce
    {
        public enum UserStatus : byte
        {
            [Description("Active")]
            Ativo = 1,
            [Description("Inactive")]
            Inativo = 2,
            [Description("Blocked")]
            Bloqueado = 3,
        }
        
    }
}
