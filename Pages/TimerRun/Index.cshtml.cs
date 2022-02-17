﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFitTimer.Data;
using MyFitTimer.Models;

namespace MyFitTimer.Pages.TimerRun
{
    public class IndexModel : PageModel
    {
        private readonly MyFitTimer.Data.MyFitTimerContext _context;
        [ViewData]
        public int TimerId { get; set; }

        public IndexModel(MyFitTimer.Data.MyFitTimerContext context)
        {
            _context = context;
        }

        public IList<MyFitTimer.Models.TimerRun> TimerRuns { get; set; }

        public async Task OnGetAsync()
        {
            TimerRuns = await _context.TimerRuns.ToListAsync();
        }

    }

}
