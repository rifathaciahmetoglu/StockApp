using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult //Sonuç
    {
        bool Succes { get; }//Başarılı mı? Başarısız mı?
        string Message { get; }//kullanıcıya dönecek mesaj
    }
}
