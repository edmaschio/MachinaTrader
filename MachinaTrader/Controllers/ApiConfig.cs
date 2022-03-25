using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using MachinaTrader.Globals.Helpers;
using MachinaTrader.Globals;
using MachinaTrader.Globals.Models;
using Microsoft.AspNetCore.Authorization;

namespace MachinaTrader.Controllers
{
    [Authorize, Route("api/config/")]
    public class ApiConfig : Controller
    {
        [HttpGet]
        [Route("mainConfig")]
        public IActionResult GetMainConfig()
        {
            var config = Global.Configuration;

            var configDto = new
            {
                config.SystemOptions,
                config.DisplayOptions,
                config.TelegramOptions,
                config.TradeOptions
            };

            return Ok(configDto);
        }

        [HttpPost]
        [Route("mainConfig")]
        public void PostMainConfig([FromBody]JObject data)
        {
            try
            {
                Global.Configuration = MergeObjects.MergeCsDictionaryAndSave(Global.Configuration, Global.DataPath + "/MainConfig.json", data).ToObject<MainConfig>();
            }
            catch (Exception ex)
            {
                Global.Logger.Error(@"Can not save config file: " + ex);
            }
        }

        [HttpGet]
        [Route("runtime")]
        public ActionResult GetRuntime()
        {
            return new JsonResult(Global.RuntimeSettings);
        }
    }
}
