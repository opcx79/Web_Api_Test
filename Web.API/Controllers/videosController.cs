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
        public async Task<IHttpActionResult> Get(Guid id)
        {
            return Ok(await _videoRepo.GetByIdAsync(id));

        }

        // POST: api/videos
        public async Task<IHttpActionResult> Post([FromBody]Video model)
        {
            if (ModelState.IsValid)
            {
                _videoRepo.Create(model);
                var v = await _unitOfWork.SaveChangesAsync();
                return Ok(v);
            }
            return BadRequest(ModelState);
        }

        // PUT: api/videos/5
        public async Task<IHttpActionResult> Put(Guid id, [FromBody]Video model)
        {
            if (ModelState.IsValid)
            {
                _videoRepo.Update(model);
                var v = await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        // DELETE: api/videos/5
        public async Task Delete(Guid id)
        {
            var v = await _videoRepo.GetByIdAsync(id);
            _videoRepo.Delete(v);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
