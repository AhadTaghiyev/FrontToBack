using System;
using FrontToBack.Context;
using FrontToBack.Models;

namespace FrontToBack.Services
{
	public class SettingService
	{
		private readonly FrontToBackDbContext _context;

        public SettingService(FrontToBackDbContext context)
        {
            _context = context;
        }

        public Setting GetSetting()
        {
            Setting setting = _context.Settings.FirstOrDefault();
            return setting;
        }
    }
}

