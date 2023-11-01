using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Common
{
    public class CommonUtils
    {
        public static bool Success { get; private set; } = false;

        public static void SetSuccess(bool value)
        {
            Success = value;
        }
    }
}
