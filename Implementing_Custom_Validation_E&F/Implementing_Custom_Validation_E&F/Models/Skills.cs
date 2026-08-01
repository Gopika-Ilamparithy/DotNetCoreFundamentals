using System;

namespace Implementing_Custom_Validation_E_F.Models
{
    [Flags]
    public enum Skills
    {
        None = 0,
        CSharp = 1,
        ASPNetCore = 2,
        SQL = 4,
        Javascript = 8
    }
}
