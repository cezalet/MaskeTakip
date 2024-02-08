using Business.Abstract;
using Emtities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttMenager
    {
        private IApplicantService _applicantService;

        public PttMenager(IApplicantService applicantService)//Constructor new yazıldığında çalışır.
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonMenager personMenager = new PersonMenager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
        }
    }
}
