﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WeCareWebApp.Entities;
using WeCareWebApp.Helpers;
using WeCareWebApp.Models;

namespace WeCareWebApp.Pages.BusinessClientPages
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _client;

        public IndexModel(HttpClient client)
        {
            _client = client;
        }

        public IList<BusinessClient> BusinessClient { get;set; }

        public async Task OnGetAsync()
        {
            BusinessClient = await _client.GetFromJsonAsync<List<BusinessClient>>(Connection.ApiHost + "/businessClients");
        }
    }
}
