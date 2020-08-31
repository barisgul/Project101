using System;
using System.Collections.Generic;
using System.Text;

namespace Project101
{
    public class StaticClassWrapper : IStaticClassWrapper
    {
        //oluşturduğumuz bu wrap edilmiş metot ile artık mocklanan IStaticClassWrapper interfaceine ait bir stub yaratabilir ve statik classı izole edebiliriz 
        public string WriteMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
