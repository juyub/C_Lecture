using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameModelingT
{
    internal class oGlobal
    {
    }

    // Log Level을 지정할 Enum
    public enum enLogLevel
    {
        Info,
        Wrning,
        Error,
    }

    public delegate void delLogSender(object oSender, enLogLevel eLevel, string strLog);
}
