﻿using Headway.Core.Interface;
using Headway.Core.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Headway.WebApi.Controllers
{
    [ApiController]
    [EnableCors("local")]
    [Route("[controller]")]
    [Authorize(Roles = "headwayuser")]
    public class RolesController : ApiControllerBase<RolesController>
    {
        private readonly IAuthorisationRepository authorisationRepository;

        public RolesController(
            IAuthorisationRepository authorisationRepository,
            ILogger<RolesController> logger)
            : base(logger)
        {
            this.authorisationRepository = authorisationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var claim = GetUserClaim();

            var authorised = await authorisationRepository.IsAuthorisedAsync(claim, "Admin")
                                                            .ConfigureAwait(false);
            if (!authorised)
            {
                return Unauthorized();
            }

            var permissions = await authorisationRepository.GetRolesAsync(claim)
                                                            .ConfigureAwait(false);
            return Ok(permissions);
        }

        [HttpGet("{roleId}")]
        public async Task<IActionResult> Get(int roleId)
        {
            var claim = GetUserClaim();

            var authorised = await authorisationRepository.IsAuthorisedAsync(claim, "Admin")
                                                            .ConfigureAwait(false);
            if (!authorised)
            {
                return Unauthorized();
            }

            var permissions = await authorisationRepository.GetRoleAsync(claim, roleId)
                                                            .ConfigureAwait(false);
            return Ok(permissions);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Role role)
        {
            var claim = GetUserClaim();

            var authorised = await authorisationRepository.IsAuthorisedAsync(claim, "Admin")
                                                            .ConfigureAwait(false);
            if (!authorised)
            {
                return Unauthorized();
            }

            var savedPermission = await authorisationRepository.AddRoleAsync(claim, role)
                                                                .ConfigureAwait(false);
            return Ok(savedPermission);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Role role)
        {
            var claim = GetUserClaim();

            var authorised = await authorisationRepository.IsAuthorisedAsync(claim, "Admin")
                                                            .ConfigureAwait(false);
            if (!authorised)
            {
                return Unauthorized();
            }

            var savedPermission = await authorisationRepository.UpdateRoleAsync(claim, role)
                                                                    .ConfigureAwait(false);
            return Ok(savedPermission);
        }

        [HttpDelete("{roleId}")]
        public async Task<IActionResult> Delete(int roleId)
        {
            var claim = GetUserClaim();

            var authorised = await authorisationRepository.IsAuthorisedAsync(claim, "Admin")
                                                            .ConfigureAwait(false);
            if (!authorised)
            {
                return Unauthorized();
            }

            var result = await authorisationRepository.DeleteRoleAsync(claim, roleId)
                                                            .ConfigureAwait(false);
            return Ok(result);
        }
    }
}
