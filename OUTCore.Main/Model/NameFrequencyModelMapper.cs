using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OUTCore.Domain;
using AutoMapper;

namespace OUTCore.Main.Model
{
    public static class NameFrequencyModelMapper
    {
        public static NameFrequencyModel ToModel(this NameFrequency person)
        {
            return Mapper.DynamicMap<NameFrequency, NameFrequencyModel>(person);
        }
    }
}
