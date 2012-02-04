using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;

namespace Build.Utilities
{
    public class CustomCodeTask1 : Task
    {
        public override bool Execute()
        {
            Log.LogWarning("Custom Code Task executed");
            return true;
        }
    }
}
