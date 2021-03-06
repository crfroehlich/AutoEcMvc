﻿using System.Threading.Tasks;
using AutoEcMvc.Data;

using Microsoft.AspNetCore.Mvc;

namespace AutoEcMvc.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected readonly MetadataContext _context;

        protected ControllerBase(MetadataContext context) => _context = context;

        protected virtual void _AfterUpdate(object objToUpdate = null) { }

        protected virtual async Task<bool> _OnIndex(params object[] data) => true;
    }
}
