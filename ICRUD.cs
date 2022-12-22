using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastpractin2022___________
{
    internal interface ICRUD
    {
        void Create(User user);

        User Read(int userId); //с помошью данного значения нужно сделать поиск)!

        void Update(User user);

        void Delete(int userId);

    }
}
