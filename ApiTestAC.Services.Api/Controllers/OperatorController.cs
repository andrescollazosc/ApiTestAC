using ApiTestAC.Domain.Contracts;
using ApiTestAC.Domain.Entities;
using ApiTestAC.Services.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTestAC.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : ControllerBase
    {
        #region Attributes
        private readonly IGenericRepository<Operator> _genericRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Controllers
        public OperatorController(IGenericRepository<Operator> genericRepository, IMapper mapper)
        {
            this._genericRepository = genericRepository;
            this._mapper = mapper;
        }
        #endregion

        #region End points
        [HttpGet]
        [Route("operators")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<OperatorDto>>> GetAll() {
            try
            {
                var result = await _genericRepository.GetAll();

                if (result.Count() == 0)
                {
                    return NotFound();
                }

                return _mapper.Map<List<OperatorDto>>(result);
            }
            catch (System.Exception){
                return BadRequest();
            }
        }
        #endregion

    }
}