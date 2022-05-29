using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPErson(Gamer gamer )
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
               (gamer.NationalityId,
               gamer.GamerFirstName.ToUpper(),
               gamer.GamerLastName.ToUpper(),
               gamer.DateOfBirth.Year)
               )).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
