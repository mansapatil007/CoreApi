using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoveMarriage.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class xFamilyValuesController : ControllerBase
    {
        //xFamilyValue/Get
        public IEnumerable<XFamilyValues> Get()
        {
            var lMDBContext = new LoveMarriageDBContext();
            return lMDBContext.XFamilyValues.ToList();

        }

        //xFamilyValue/Get/1
        public IEnumerable<XFamilyValues> Get(int familyValueId)
        {
            var lMDBContext = new LoveMarriageDBContext();
            return lMDBContext.XFamilyValues.Where(x => x.FamilyValueId == familyValueId);
        }
    }
}