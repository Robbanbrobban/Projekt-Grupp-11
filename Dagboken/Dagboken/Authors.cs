using System;
using System.Collections.Generic;

namespace Dagboken
{
    class Authors
    {
        public string foreName{ set; get; }
        public string lastName;

        public override string ToString()
        {
            return $"Författare: {foreName} {lastName}";
        }
    }



}