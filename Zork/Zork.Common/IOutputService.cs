using System;
using System.Collections.Generic;
using System.Text;

namespace Zork.Common
{
    public interface IOutputService
    {
        //"contract"
        //no implentation
        //must fullfill all details of the contract

        void Write(string value);

        void Write(object value);

        void WriteLine(string value);

        void WriteLine(object value);

        //everything in an interface is public

        void Clear();



    }
}
