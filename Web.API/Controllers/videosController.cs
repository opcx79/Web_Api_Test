using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Web.Domain.Abstracts.Services;
using Web.Domain.Entities;
using Web.Domain.Infrastructure;

namespace Web.API.Controllers
{
    public class videosController : ApiController
    {
        private readonly IEntityBaseRepository<Video> _videoRepo;
        private IUnitOfWork _unitOfWork;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public videosController(IEntityBaseRepository<Video> _videoRepo, IUnitOfWork _unitOfWork)
        {
            this._videoRepo = _videoRepo;
            this._unitOfWork = _unitOfWork;
        }

        // GET: api/videos
        public async Task<IEnumerable<Video>> Get()
        {
            return await _videoRepo.AllAsync();
        }

        // GET: api/videos/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var video = await _videoRepo.GetByIdAsync(id);
            if (video == null)
                return BadRequest("Video Null");
            else
                return Ok(video);
        }

        // POST: api/videos
        public async Task<IHttpActionResult> Post([FromBody]Video value)
        {
            if (ModelState.IsValid)
            {
                _videoRepo.Create(value);
                var v =  await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }

        // PUT: api/videos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/videos/5
        public void Delete(int id)
        {
        }
    }
}
