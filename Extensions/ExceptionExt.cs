using System;

namespace Lazar.Extensions
{
    public static class ExceptionExt
    {
        public static string ExceptionMessages(this Exception ex)
        {
            if (ex == null) throw new NullReferenceException();

            string msgs = ex.Message;

            if (ex.InnerException != null)
            {
                msgs += $"{Environment.NewLine}  - InnerException: {ExceptionMessages(ex.InnerException)}";
            }

            return msgs;
        }
    }
}