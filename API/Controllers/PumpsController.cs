using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class PumpsController : BaseApiController
    {
        private readonly DataContext _context;
        public PumpsController(DataContext context)
        {
            _context = context;   
        }

        //api/pumps
        [HttpGet]
        public async Task<ActionResult<List<Pump>>> GetPumps() 
        {
            return await _context.Pumps.ToListAsync();
        }

        //api/pumps/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Pump>> GetPump(Guid id) 
        {
            return await _context.Pumps.FindAsync(id);
        }
    }
}