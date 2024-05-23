using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks
{
    public class MultiplyTwoNumbers : Microsoft.Build.Utilities.Task
    {
        [Required]
        public double Number1 { get; set; }

        [Required]
        public double Number2 { get; set; }

        // pass a value back to MS build

        [Output]
        public double Result { get; set; }

        public override bool Execute()
        {
            Result = Number1 * Number2;

            Log.LogMessage(MessageImportance.High, "Multiplied two numbers", null);
            
            return true;
        }
    }
}
