using Hotel.Entites;
using Hotel.Repository;
using Hotel.Service.RoomTypeDTOs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Hotel.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HotelService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HotelService.svc or HotelService.svc.cs at the Solution Explorer and start debugging.

    public class HotelService : IHotelService
    {
        private IRepository repository = new SqlServerRepository(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);

        public IRepository Repository
        {
            get
            {
                return repository;
            }

            set
            {
                repository = value;
            }
        }

        public RoomTypeDTO[] GetAllType()
        {
            var RoomTypes = Repository.GetAllType();

            var RoomTypesDTO = new List<RoomTypeDTO>();
            foreach (TypeRoom r in RoomTypes)
            {
                RoomTypesDTO.Add(new RoomTypeDTO() { Id = r.Id, Quentity = r.Quentity, Name = r.Name,  Price = r.Price });
            }

            return RoomTypesDTO.ToArray();
        }
        public void RoomReserve(string[] fields)
        {
            try
            {
                Repository.ReserverRoom(fields);
            }
            catch
            {
                throw new FaultException("Incorrect data");
            }
        }
    }
}
