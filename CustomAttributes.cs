using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Not here - but then - where? Not in NsightLib - since we do not want NsightModels to depend on a Nuget...
namespace NsightModels
{

    [AttributeUsage(AttributeTargets.Property)]
    public class SwaggerExcludeAttribute : Attribute { }

}
