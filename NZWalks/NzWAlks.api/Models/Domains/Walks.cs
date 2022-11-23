namespace NzWAlks.api.Models.Domains
{
    public class Walks
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid Length { get; set; }
        public double RegionId { get; set; }
        public double WalkDifficultyId { get; set; }
        //navigation property
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
