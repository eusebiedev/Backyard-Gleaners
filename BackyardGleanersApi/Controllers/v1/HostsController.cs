using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace BackyardGleanersApi.Controllers.v1
{
  [ApiController] 
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  
  public class HostsController : ControllerBase
  {
    
  }
}
