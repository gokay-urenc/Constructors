using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapici_Method_
{
    class MyClass
    {
        public MyClass()
        {

        }
        public int MyProperty { get; set; }
    }
}
// Constructor: Bir classtan instance almak için kullanılan özel bir methoddur.
// Constructor olmadan instance alınamaz.
// Eğer constructor kullanılmazsa derleyici gizli bir constructor kullanır.
// Constructor özel bir methoddur.
// Geriye değer dönüş tipi olmayan bir methoddur.
// Constructor oluştururken erişim seviyesi genel(public) olmalıdır.
// Adı class ismiyle birebir aynı olmalıdır.
// Kısayolu: ctor + tab + tab