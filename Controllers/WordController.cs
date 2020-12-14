using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[Controller]")]
    public class WordController : Controller
    {
        private Context _context;
        public WordController(Context context)
        {
            _context = context;
        }
        public List<Word> Get()
        {
            return _context.words.ToList();
        }
    }
}
