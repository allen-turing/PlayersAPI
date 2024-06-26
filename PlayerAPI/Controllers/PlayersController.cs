﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerAPI.Model;
using PlayerAPI.Repository;
using System.ComponentModel.DataAnnotations;

namespace PlayerAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlayersController : ControllerBase
	{
		private readonly PlayerDbContext _playerDbContext;

		public PlayersController(PlayerDbContext playerDbContext)
		{
			_playerDbContext = playerDbContext;
		}

		[HttpGet("{playerID}")]
		[ProducesResponseType(typeof(Player), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetPlayerById([Required] int playerID)
		{
			var player = await _playerDbContext.Players.FirstOrDefaultAsync(_ => _.Id == playerID);
			if (player == null)
			{
				return new NotFoundResult();
			}
			return Ok(player);
		}

		[HttpGet("stream")]
		public async IAsyncEnumerable<Player> GetPlayerStreamAsync([FromQuery] int limit, [FromQuery] int offSet)
		{
			await foreach (var player in _playerDbContext.Players.Skip(offSet).Take(limit).AsAsyncEnumerable())
			{
				yield return player;
			}
		}

		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<Player>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetPlayerAsync([FromQuery] int limit, [FromQuery] int offSet)
		{
			var player = await _playerDbContext.Players.Skip(offSet).Take(limit).ToListAsync();

			return Ok(player);
		}
	}
}
