namespace Mission10.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<BowlerScore> BowlerScores { get; }
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<MatchGame> MatchGames { get; }
        IEnumerable<Team> Teams { get; }
        IEnumerable<Tournament> Tournaments { get; }
        IEnumerable<TourneyMatch> TourneyMatches { get; }
        IEnumerable<ZtblBowlerRating> ZtblBowlers { get; }
        IEnumerable<ZtblSkipLabel> ZtblSkipLabels { get; }
        IEnumerable<ZtblWeek> ztblWeeks { get; }
    }
}
