using Business.Abstract;
using Emtities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Çıplak Class Kalmasın...
    public class PersonMenager:IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList() 
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client=new  KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.
                FirstName, person.LastName, person.DateOfBirthYear)).Result.Body.TCKimlikDogrulamaResult;
        }
    }
}
