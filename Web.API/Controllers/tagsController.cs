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
    public class tagsController : ApiController
    {
        private readonly IEntityBaseRepository<Tag> _tagsRepo;
        private IUnitOfWork _unitOfWork;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public tagsController(IEntityBaseRepository<Tag> _tagsRepo, IUnitOfWork _unitOfWork)
        {
            this._tagsRepo = _tagsRepo;
            this._unitOfWork = _unitOfWork;
        }

        // GET: api/tags
        public async Task<IEnumerable<Tag>> Get()
        {
            return await _tagsRepo.AllAsync();
        }

        // GET: api/tags/5
        public async Task<IHttpActionResult> Get(Guid id)
        {
            return Ok(await _tagsRepo.FindByAsync(x => x.ID == id));
        }

        // POST: api/tags
        public async Task<IHttpActionResult> Post([FromBody]Tag value)
        {
            if (ModelState.IsValid)
            {
                _tagsRepo.Create(value);
                await _unitOfWork.SaveChangesAsync();
            }
            return BadRequest();
        }

        // PUT: api/tags/5
        public async Task<IHttpActionResult> Put(Guid id, [FromBody]Tag value)
        {
            if (ModelState.IsValid)
            {
                _tagsRepo.Update(value);
                await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        // DELETE: api/tags/5
        public async Task Delete(Guid id)
        {
            var t = await _tagsRepo.GetByIdAsync(id);
            _tagsRepo.Delete(t);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
