using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OUTCore.Bll.Interfaces;
using OUTCore.DI;

namespace OUTCore.Main
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            var personService =  DependencyResolver<BindingModule>.Get<IPersonService>();
            var filePrefix = DateTime.Now.ToString(OUTCore.Main.Main.Default.OutPutFilePrefix);
            var addressFileName = OUTCore.Main.Main.Default.AddFilePrefix;
            var frequenceFileName = OUTCore.Main.Main.Default.FreqFilePrefix;

            using(TextWriter tw = new StreamWriter(filePrefix + frequenceFileName  ))
            {
               foreach (var s in  personService.GetOrderedNameFrequencyList())
                  tw.WriteLine(s);
            }

            using (TextWriter tw = new StreamWriter(filePrefix + addressFileName))
            {
                foreach (var s in personService.GetOrderedAddressList())
                    tw.WriteLine(s);
            }

        }
    }
}
