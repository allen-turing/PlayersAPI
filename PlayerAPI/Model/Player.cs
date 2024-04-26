using System.ComponentModel.DataAnnotations.Schema;

namespace PlayerAPI.Model
{
	[Table("all_seasons")]
	public class Player
	{
		public int Id { get; set; }
		[Column("player_name")]
		public string PlayerName { get; set; }
		[Column("team_abbreviation")]
		public string TeamAbbreviation { get; set; }
		public double Age { get; set; }
		[Column("Player_height")]

		public double PlayerHeight { get; set; }
		[Column("Player_weight")]
		public double PlayerWeight { get; set; }
		public string College { get; set; }
		public string Country { get; set; }
		[Column("Draft_year")]
		public int DraftYear { get; set; }
		[Column("Draft_round")]
		public int DraftRound { get; set; }
		[Column("Draft_number")]
		public int DraftNumber { get; set; }
		public int Gp { get; set; }
		public double Pts { get; set; }
		public double Reb { get; set; }
		public double Ast { get; set; }
		[Column("Net_rating")]
		public double NetRating { get; set; }
		[Column("Oreb_pct")]
		public double OrebPct { get; set; }
		[Column("Dreb_pct")]
		public double DrebPct { get; set; }
		[Column("Usg_pct")]
		public double UsgPct { get; set; }
		[Column("Ts_pct")]
		public double TsPct { get; set; }
		[Column("Ast_pct")]
		public double AstPct { get; set; }
		public string Season { get; set; }
	}
}