using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Enum
{
    public enum GameType
    {
        [StringSyntax("FPS")]
        FPS,

        [Display(Name = "Moba")]
        Moba,

        [Display(Name = "RTS")]
        RTS,
    }
}
