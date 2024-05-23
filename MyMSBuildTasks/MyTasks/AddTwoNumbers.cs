using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks
{
    public class AddTwoNumbers : ITask
    {

        [Required]
        public double Number1 { get; set; }

        [Required]
        public double Number2 { get; set; }

        // pass a value back to MS build

        [Output]
        public double Result { get; set; }

        public IBuildEngine BuildEngine { get;set; }

        public ITaskHost HostObject { get;set; }

        public bool Execute()
        {
            Result = Number1 + Number2;

            var args = new BuildMessageEventArgs("Added two numbers ", "Add", nameof(AddTwoNumbers), MessageImportance.High);
            BuildEngine.LogMessageEvent(args);

            return true;
        }
    }
}
