namespace Mission10.Models
{
    public class EFBowlerRepository: IBowlerRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext temp) { 
            _context = temp;
        }
        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<BowlerScore> BowlerScores => _context.BowlerScores;
        public IEnumerable<MatchGame> MatchGames => _context.MatchGames;
        public IEnumerable<Team> Teams => _context.Teams;
        public IEnumerable<Tournament> Tournaments => _context.Tournaments;
        public IEnumerable<TourneyMatch> TourneyMatches => _context.TourneyMatches;
        public IEnumerable<ZtblBowlerRating> ZtblBowlerRatings => _context.ZtblBowlerRatings;
        public IEnumerable<ZtblSkipLabel> ZtblSkipLabels => _context.ZtblSkipLabels;
        public IEnumerable<ZtblWeek> ZtblWeeks => _context.ZtblWeeks;

        public IEnumerable<ZtblWeek> ztblWeeks => throw new NotImplementedException();

        public IEnumerable<ZtblBowlerRating> ZtblBowlers => throw new NotImplementedException();
    }
}
