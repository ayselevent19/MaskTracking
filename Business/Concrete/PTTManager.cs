using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//bir uygulama iş sınıfı içinde iş sınıfı kullanıyosa yenilikte bu uygulama direnç gösterir.
//PersonManager a bağımlı oldu çunku


namespace Business.Concrete
{
    public class PTTManager:ISupplierService
    {
        private IApplicantServices _applicantServices;
        //yukarıdaki satırın amacı global alana değişken tanımlamak
        // ve aşağıda onu kullanabilmek 

        public PTTManager(IApplicantServices applicantServices)//contructor new yapıldığnda çalışır
        {
            _applicantServices = applicantServices;
            //bu satırda da tanımladığımız global değişkene atadık bitti!

        }
        public void GiveMask(Person person)
        {
            if (_applicantServices.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine("Maske Verilemedi");
            }
        }
    }
}
