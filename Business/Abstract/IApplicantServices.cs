using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interfaceleri bağımlılığı çözmenin teknikleri için
//interfaceler birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlar.
//satırlarca if bloğu yazmak yerine daha mantıklı

namespace Business.Abstract
{
    public interface IApplicantServices
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);

    }
}
