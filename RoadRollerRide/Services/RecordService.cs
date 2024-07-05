using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoadRollerRide.Models;
using RoadRollerRide.Persistence;

namespace RoadRollerRide.Services
{
    public class RecordService
    {
        private readonly IAppDbContext _appDbContext;
        public RecordService(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Record> GetAll()
        {
            var records = _appDbContext.Records.ToList();

            return records;
        }
    }
}
