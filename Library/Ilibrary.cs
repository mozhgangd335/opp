using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  interface  Ilibrary
    {
       
        void Add(string name,int type);

        void Delete(string name,int type);
        void ShowDetails(int type);
    }
}
