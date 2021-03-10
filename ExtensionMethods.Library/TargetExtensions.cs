using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Library
{
    public static class TargetExtensions
    {
        static void ExtendInternal(this InternalTarget target)
        {

        }

        // But you cannot extend unless the type is accessable -- ProtectedSubClass is protected
        //static void ExtendInternalProtected(this InternalTarget.ProtectedSubClass  target)
        //{

        //}

        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();

        }


    }
}
