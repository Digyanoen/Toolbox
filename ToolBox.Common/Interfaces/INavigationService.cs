using System;
using System.Collections.Generic;
using System.Text;

namespace Toolbox.Common.Interfaces
{
    public interface INavigationService<T> where T : Enum
    {
        void Test(T test);
    }
}
