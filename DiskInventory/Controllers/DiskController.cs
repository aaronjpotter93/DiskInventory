using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiskInventory.Models;

namespace DiskInventory.Controllers
{
    public class DiskController : Controller
    {
        private disk_inventoryapContext context { get; set; }
        public DiskController(disk_inventoryapContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            List<Disk> disks = context.Disks.ToList();
            return View(disks);
        }
    }
}
